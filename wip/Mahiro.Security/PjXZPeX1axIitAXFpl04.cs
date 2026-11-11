using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace vEgbMXX11dbY3lmsJwuP;

internal class PjXZPeX1axIitAXFpl04
{
	private static object yDBwfIZPjYdXKmKmVUOH;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool voxX13sh3xl(object executablePath)
	{
		int num = 3;
		string text = default(string);
		int num5 = default(int);
		bool result = default(bool);
		int num7 = default(int);
		int num9 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		global::System.Exception ex = default(global::System.Exception);
		int num11 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num14 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						string text2 = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath((string)executablePath));
						if (text2 == null)
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						text = text2;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
						{
							num3 = 7;
						}
						continue;
					}
					case 2:
						return false;
					case 5:
						return true;
					case 4:
						try
						{
							global::System.Collections.Generic.IEnumerator<string> enumerator = (global::System.Collections.Generic.IEnumerator<string>)System.IO.Directory.EnumerateFiles(text, "*.renderer", (SearchOption)0);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										goto IL_00bf;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_00c3;
								}
								try
								{
									while (true)
									{
										int num6;
										if (!(enumerator).MoveNext())
										{
											num6 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
											{
												num6 = 0;
											}
											goto IL_0105;
										}
										goto IL_01c4;
										IL_0163:
										result = true;
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
										{
											num6 = 8;
										}
										goto IL_0105;
										IL_0101:
										num6 = num7;
										goto IL_0105;
										IL_01c4:
										if (!KCxX1Eo1OWT(enumerator, "98E392824E31C7760663CCB1B19F1CD872DF71193FA1F8E47F57D41E9886A8EF"))
										{
											num7 = 12;
											goto IL_0101;
										}
										goto IL_0163;
										IL_0105:
										switch (num6)
										{
										case 1:
											return result;
										case 2:
											goto IL_0163;
										case 4:
											continue;
										case 3:
											goto IL_01c4;
										case 0:
											goto end_IL_0185;
										}
										if (num7 != 12)
										{
											if (num7 == 992)
											{
												goto IL_0101;
											}
											goto IL_01c4;
										}
										continue;
										end_IL_0185:
										break;
									}
								}
								finally
								{
									int num8;
									if (enumerator == null)
									{
										num8 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
										{
											num8 = 0;
										}
										goto IL_0239;
									}
									goto IL_025d;
									IL_0239:
									while (true)
									{
										switch (num8)
										{
										default:
											if (num9 == 990)
											{
												goto IL_0235;
											}
											goto end_IL_0239;
										case 1:
											break;
										case 0:
											goto end_IL_0239;
										case 2:
											goto end_IL_0239;
										}
										goto IL_025d;
										IL_0235:
										num8 = num9;
										continue;
										end_IL_0239:
										break;
									}
									goto end_IL_0201;
									IL_025d:
									(enumerator).Dispose();
									num8 = 2;
									goto IL_0239;
									end_IL_0201:;
								}
								break;
								IL_00bf:
								num4 = num5;
								continue;
								end_IL_00c3:
								break;
							}
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num10 = 2;
							}
							else
							{
								ex = obj2;
								num10 = 13;
							}
							num11 = num10;
							while (true)
							{
								num12 = num11;
								while (true)
								{
									switch (num12)
									{
									default:
										if (num11 != 13)
										{
											if (num11 == 993)
											{
												goto end_IL_02e4;
											}
											goto case 4;
										}
										if (!(ex is IOException))
										{
											num12 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
											{
												num12 = 7;
											}
											continue;
										}
										goto case 5;
									case 5:
										flag = true;
										num12 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
										{
											num12 = 10;
										}
										continue;
									case 4:
										flag = false;
										num12 = 3;
										continue;
									case 1:
										if (ex is UnauthorizedAccessException)
										{
											num12 = 5;
											continue;
										}
										goto case 4;
									case 2:
										result2 = 0;
										break;
									case 0:
									case 3:
										result2 = (flag ? 1 : 0);
										break;
									}
									return (byte)result2 != 0;
									continue;
									end_IL_02e4:
									break;
								}
							}
						}).Invoke())
						{
							int num13 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								num13 = 0;
							}
							while (true)
							{
								switch (num13)
								{
								default:
									if (num14 == 988)
									{
										num13 = num14;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 2;
					case 1:
						num3 = (KCxX1Eo1OWT(System.IO.Path.Combine(text, "api-ms-win-core-runtime-l1-1-0.dll"), "740AD625520A5DA3098C665A83446B52A1DC71F523C50959047635DACC559EAB") ? 5 : 4);
						continue;
					case 3:
						break;
					case 0:
						throw new global::System.Exception("Bedrock executable directory is unavailable");
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
			System.ArgumentException.ThrowIfNullOrWhiteSpace((string)executablePath, "executablePath");
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kyMX1vsTTA6(object fileName, object sha256)
	{
		int num = 1;
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
					return string.Equals((string)sha256, "98E392824E31C7760663CCB1B19F1CD872DF71193FA1F8E47F57D41E9886A8EF", (StringComparison)5);
				case 0:
					return string.Equals((string)sha256, "740AD625520A5DA3098C665A83446B52A1DC71F523C50959047635DACC559EAB", (StringComparison)5);
				case 1:
					break;
				}
				goto IL_00e2;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_00e2;
				IL_00e2:
				if (!string.Equals((string)fileName, "api-ms-win-core-runtime-l1-1-0.dll", (StringComparison)5))
				{
					if (!string.Equals(System.IO.Path.GetExtension((string)fileName), ".renderer", (StringComparison)5))
					{
						return false;
					}
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool KCxX1Eo1OWT(object path, object expectedSha256)
	{
		//IL_007f: Expected O, but got I4
		int num = 2;
		bool result = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		global::System.Exception ex = default(global::System.Exception);
		int num11 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num13 = default(int);
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
				case 0:
					return result;
				case 1:
					return false;
				case 2:
					if (System.IO.File.Exists((string)path))
					{
						num2 = 3;
						break;
					}
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					try
					{
						_ = 3;
						_ = 1;
						FileStream val = (FileStream)(object)7;
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_00ac;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_00ac:
							num3 = num4;
						}
						try
						{
							result = string.Equals(System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val)), (string)expectedSha256, (StringComparison)4);
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
							{
								num5 = 4;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 988)
									{
										num5 = num6;
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
							if (val != null)
							{
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
								{
									num7 = 4;
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
										goto end_IL_017b;
									}
									(val).Dispose();
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
									{
										num7 = 0;
									}
									continue;
									end_IL_017b:
									break;
								}
							}
						}
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num9 = 3;
						}
						else
						{
							ex = obj2;
							num9 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
							{
								num9 = 6;
							}
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num11 != 14)
								{
									if (num11 == 994)
									{
										goto IL_01eb;
									}
									goto case 5;
								}
								goto case 4;
							case 5:
								if (!(ex is UnauthorizedAccessException))
								{
									num9 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
									{
										num9 = 1;
									}
									continue;
								}
								goto case 0;
							case 1:
							case 2:
								flag = false;
								num10 = 4;
								goto IL_01e7;
							case 0:
								flag = true;
								num10 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
								{
									num10 = 14;
								}
								goto IL_01e7;
							case 6:
								if (!(ex is IOException))
								{
									num9 = 5;
									continue;
								}
								goto case 0;
							case 3:
								result2 = 0;
								break;
							case 4:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_01e7:
								num11 = num10;
								goto IL_01eb;
								IL_01eb:
								num9 = num11;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num12 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
						{
							num12 = 3;
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
								result = false;
								num12 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
								{
									num12 = 5;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
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
	private static void _cctor()
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 1:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool m0ryLxZPZN5LgvhkVnik()
	{
		return yDBwfIZPjYdXKmKmVUOH == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PjXZPeX1axIitAXFpl04 Tf5jdBZP9p8gZUKfuXvw()
	{
		return (PjXZPeX1axIitAXFpl04)yDBwfIZPjYdXKmKmVUOH;
	}
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CvQ8qLfIaPhOpHAJXxwb;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace yIYtF0fIn7KHlAY0LkTJ;

public class BMBwE6fIiRdqmheZPl4M
{
	private static readonly object bo2fIzw08pm;

	private static object CEZ7ufZaEOICVurxr79B;

	private static string SettingsPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(JNVYTu71oRZRpWuML35.LocalDataRoot, "bedrock-proxy.dat");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static jX93P4fIu15bhq10GXXT Load()
	{
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		object obj = default(object);
		bool flag = default(bool);
		int num10 = default(int);
		jX93P4fIu15bhq10GXXT result = default(jX93P4fIu15bhq10GXXT);
		byte[] array = default(byte[]);
		int num5 = default(int);
		jX93P4fIu15bhq10GXXT jX93P4fIu15bhq10GXXT2 = default(jX93P4fIu15bhq10GXXT);
		int num9 = default(int);
		int num7 = default(int);
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
					goto case 0;
				case 3:
					try
					{
						System.Threading.Monitor.Enter(obj, ref flag);
						int num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num10 != 11)
								{
									if (num10 == 991)
									{
										goto IL_0074;
									}
									goto case 1;
								}
								result = (jX93P4fIu15bhq10GXXT)new jX93P4fIu15bhq10GXXT();
								num3 = 3;
								continue;
							case 1:
								if (!System.IO.File.Exists(SettingsPath))
								{
									int num11 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
									{
										num11 = 11;
									}
									num10 = num11;
									goto IL_0074;
								}
								goto case 2;
							case 2:
								array = null;
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
								{
									num3 = 11;
								}
								continue;
							case 3:
								break;
							case 0:
								{
									try
									{
										array = System.Security.Cryptography.ProtectedData.Unprotect(System.Convert.FromBase64String(System.IO.File.ReadAllText(SettingsPath)), null, (DataProtectionScope)0);
										int num4 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num4 = 1;
										}
										while (true)
										{
											switch (num4)
											{
											default:
												if (num5 != 13)
												{
													if (num5 == 993)
													{
														goto IL_0179;
													}
													goto case 5;
												}
												goto case 4;
											case 3:
												jX93P4fIu15bhq10GXXT2.mt3fI1FkNVe();
												num5 = 13;
												goto IL_0179;
											case 5:
												if (!jX93P4fIu15bhq10GXXT2.Enabled)
												{
													num4 = 12;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
													{
														num4 = 4;
													}
													continue;
												}
												goto case 3;
											case 4:
												result = jX93P4fIu15bhq10GXXT2;
												num4 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
												{
													num4 = 13;
												}
												continue;
											case 1:
											{
												jX93P4fIu15bhq10GXXT jX93P4fIu15bhq10GXXT = JsonSerializer.Deserialize<jX93P4fIu15bhq10GXXT>(default(global::System.ReadOnlySpan<byte>), (JsonSerializerOptions)null);
												if (jX93P4fIu15bhq10GXXT == null)
												{
													num4 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
													{
														num4 = 13;
													}
													continue;
												}
												jX93P4fIu15bhq10GXXT2 = jX93P4fIu15bhq10GXXT;
												num4 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
												{
													num4 = 5;
												}
												continue;
											}
											case 0:
												throw new InvalidDataException("代理配置为空。");
											case 2:
												break;
												IL_0179:
												num4 = num5;
												continue;
											}
											break;
										}
									}
									catch (global::System.Exception ex)
									{
										int num6 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
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
													goto IL_02d7;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_02d7:
											num6 = num7;
										}
										throw new InvalidOperationException("基岩版代理配置无法读取，请在设置与关于页重新保存配置。", ex);
									}
									finally
									{
										int num8;
										if (array == null)
										{
											num8 = 2;
											goto IL_0343;
										}
										goto IL_0367;
										IL_0367:
										System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
										{
											num8 = 3;
										}
										goto IL_0343;
										IL_0343:
										while (true)
										{
											switch (num8)
											{
											default:
												if (num9 == 990)
												{
													goto IL_033f;
												}
												goto end_IL_0343;
											case 0:
												break;
											case 2:
												goto end_IL_0343;
											case 1:
												goto end_IL_0343;
											}
											goto IL_0367;
											IL_033f:
											num8 = num9;
											continue;
											end_IL_0343:
											break;
										}
									}
									break;
								}
								IL_0074:
								num3 = num10;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num12;
						if (!flag)
						{
							num12 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num12 = 0;
							}
							goto IL_03f4;
						}
						goto IL_0418;
						IL_03f4:
						while (true)
						{
							switch (num12)
							{
							default:
								if (num13 == 990)
								{
									goto IL_03f0;
								}
								goto end_IL_03f4;
							case 2:
								break;
							case 0:
								goto end_IL_03f4;
							case 1:
								goto end_IL_03f4;
							}
							goto IL_0418;
							IL_03f0:
							num12 = num13;
							continue;
							end_IL_03f4:
							break;
						}
						goto end_IL_03bc;
						IL_0418:
						System.Threading.Monitor.Exit(obj);
						num12 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
						{
							num12 = 0;
						}
						goto IL_03f4;
						end_IL_03bc:;
					}
					goto case 0;
				case 0:
					return result;
				case 1:
					flag = false;
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					obj = bo2fIzw08pm;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
					{
						num2 = 6;
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
	public static void Save(jX93P4fIu15bhq10GXXT options)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		int num = 1;
		bool flag = default(bool);
		object obj = default(object);
		int num5 = default(int);
		string text2 = default(string);
		byte[] array = default(byte[]);
		int num8 = default(int);
		int num10 = default(int);
		int num12 = default(int);
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
							goto case 0;
						}
						goto case 5;
					case 6:
						flag = false;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 2;
						}
						continue;
					case 5:
						obj = bo2fIzw08pm;
						num3 = 6;
						continue;
					case 3:
						return;
					case 4:
						options.mt3fI1FkNVe();
						num3 = 5;
						continue;
					case 0:
						if (!options.Enabled)
						{
							break;
						}
						goto case 4;
					case 2:
						try
						{
							System.Threading.Monitor.Enter(obj, ref flag);
							int num4 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num4 = 4;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 990)
									{
										num4 = num5;
										continue;
									}
									break;
								case 1:
								{
									string settingsPath = SettingsPath;
									string text = ".";
									Guid val = System.Guid.NewGuid();
									text2 = string.Concat(settingsPath, text, (val).ToString("N"), ".tmp");
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num4 = 5;
									}
									continue;
								}
								case 2:
									array = JsonSerializer.SerializeToUtf8Bytes<jX93P4fIu15bhq10GXXT>(options, (JsonSerializerOptions)null);
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
									{
										num4 = 1;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							try
							{
								byte[] array2 = System.Security.Cryptography.ProtectedData.Protect(array, null, (DataProtectionScope)0);
								int num6 = 2;
								while (true)
								{
									switch (num6)
									{
									case 1:
										return;
									default:
										if (num8 != 10)
										{
											if (num8 != 990)
											{
												break;
											}
											goto IL_021e;
										}
										System.IO.File.Move(text2, SettingsPath, true);
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
										{
											num6 = 3;
										}
										continue;
									case 0:
									{
										System.IO.File.WriteAllText(text2, System.Convert.ToBase64String(array2), (Encoding)new UTF8Encoding(false));
										int num7 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
										{
											num7 = 5;
										}
										num8 = num7;
										goto IL_021e;
									}
									case 2:
										break;
										IL_021e:
										num6 = num8;
										continue;
									}
									System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(SettingsPath));
									num6 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
									{
										num6 = 0;
									}
								}
							}
							finally
							{
								System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
								int num9 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
								{
									num9 = 8;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										if (num10 == 990)
										{
											num9 = num10;
											continue;
										}
										break;
									case 1:
										System.IO.File.Delete(text2);
										num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
										{
											num9 = 1;
										}
										continue;
									case 2:
										break;
									case 0:
										goto end_IL_0342;
									}
									if (System.IO.File.Exists(text2))
									{
										num9 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
										{
											num9 = 6;
										}
										continue;
									}
									break;
									continue;
									end_IL_0342:
									break;
								}
							}
						}
						finally
						{
							if (flag)
							{
								int num11 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
								{
									num11 = 1;
								}
								while (true)
								{
									switch (num11)
									{
									default:
										if (num12 == 989)
										{
											num11 = num12;
											continue;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_03fa;
									}
									System.Threading.Monitor.Exit(obj);
									num11 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
									{
										num11 = 1;
									}
									continue;
									end_IL_03fa:
									break;
								}
							}
						}
					case 1:
						System.ArgumentNullException.ThrowIfNull(options, "options");
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
						{
							num3 = 0;
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
			num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
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
	internal static bool UnDyAsZa2lWE2NX5KtJZ()
	{
		return CEZ7ufZaEOICVurxr79B == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static BMBwE6fIiRdqmheZPl4M XVfG93ZaqPqsafOjtP1t()
	{
		return (BMBwE6fIiRdqmheZPl4M)CEZ7ufZaEOICVurxr79B;
	}
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace BqKL3wffhEPrvBS3U8BK;

internal sealed class YtPZc0ff4HhtXJ66KDeo
{
	private readonly object uJbffOSvrlj;

	private readonly Func<string, bool> A4Pff5CCTQ3;

	private readonly Action<string>? bdVff6kwITg;

	internal static object qvIqL7ZszkUJ51IKGShA;

	[MethodImpl((MethodImplOptions)8)]
	internal YtPZc0ff4HhtXJ66KDeo(string currentSha256, Func<string, bool> isKnownPreviousSha256, Action<string>? log)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool sqaffUmppI4(string path)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool taZffr0uFRI(string path)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool TpGffoYRP7y(string path, string purpose, out string? quarantinePath, out bool foreignFileDetected)
	{
		quarantinePath = default(string?);
		foreignFileDetected = default(bool);
		int num = 3;
		string text = default(string);
		int num6 = default(int);
		bool result = default(bool);
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						foreignFileDetected = false;
						num3 = 5;
						continue;
					case 9:
						R26ffHLErFd(path);
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						return true;
					case 6:
						if (!v62ffB9WiqW(UC3ffgJjJFG(path)))
						{
							num3 = 2;
							continue;
						}
						text = WV5ffluvL6S(path, purpose);
						num = 4;
						break;
					case 0:
						return false;
					case 2:
						foreignFileDetected = true;
						num = 9;
						break;
					case 7:
						try
						{
							int num4;
							if (!v62ffB9WiqW(UC3ffgJjJFG(text)))
							{
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
								{
									num4 = 5;
								}
								goto IL_012c;
							}
							goto IL_01b9;
							IL_012c:
							while (true)
							{
								int num5;
								switch (num4)
								{
								default:
									switch (num6)
									{
									case 996:
										break;
									default:
										goto end_IL_012c;
									case 16:
										text = null;
										num4 = 2;
										continue;
									}
									goto IL_0128;
								case 5:
									hpQffKqiYwt(text, path, discardIfOriginalExists: false);
									num5 = 16;
									goto IL_0124;
								case 4:
									result = true;
									num4 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
									{
										num4 = 8;
									}
									continue;
								case 7:
									break;
								case 3:
									text = null;
									num4 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
									{
										num4 = 4;
									}
									continue;
								case 1:
									R26ffHLErFd(path);
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
									{
										num4 = 10;
									}
									continue;
								case 0:
									result = false;
									num5 = 6;
									goto IL_0124;
								case 2:
									foreignFileDetected = true;
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num4 = 6;
									}
									continue;
								case 6:
									goto end_IL_012c;
								case 8:
									goto end_IL_012c;
									IL_0124:
									num6 = num5;
									goto IL_0128;
									IL_0128:
									num4 = num6;
									continue;
								}
								goto IL_01b9;
								continue;
								end_IL_012c:
								break;
							}
							goto end_IL_00e9;
							IL_01b9:
							quarantinePath = text;
							num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
							{
								num4 = 16;
							}
							goto IL_012c;
							end_IL_00e9:;
						}
						finally
						{
							if (text != null)
							{
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
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
										hpQffKqiYwt(text, path, discardIfOriginalExists: false);
										num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
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
						goto case 8;
					case 8:
						return result;
					case 5:
						if (System.IO.File.Exists(path))
						{
							num3 = 6;
							continue;
						}
						goto case 1;
					case 4:
						System.IO.File.Move(path, text, false);
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
						{
							num3 = 7;
						}
						continue;
					case 3:
						quarantinePath = null;
						num = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
						{
							num = 1;
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
	internal bool KX9ffmQZvxE(string targetPath, byte[] data)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		int num = 1;
		string text3 = default(string);
		bool result = default(bool);
		bool flag = default(bool);
		string text = default(string);
		int num6 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		int num16 = default(int);
		int num18 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		string text2 = default(string);
		int num20 = default(int);
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
							goto case 3;
						}
						text3 = null;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
						{
							num3 = 3;
						}
						continue;
					case 1:
						break;
					case 2:
						return result;
					case 3:
						flag = false;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						try
						{
							FileStream val = new FileStream(text, (FileMode)1, (FileAccess)2, (FileShare)0, 4096, (FileOptions)(-2147483648));
							int num4 = 30;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								int num5;
								switch (num4)
								{
								default:
									if (num6 != 33)
									{
										if (num6 == 1013)
										{
											goto IL_01e1;
										}
										goto case 4;
									}
									try
									{
										System.IO.File.Move(text, targetPath, false);
										int num7 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
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
									catch (IOException)
									{
										int num9 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
										{
											num9 = 3;
										}
										while (true)
										{
											switch (num9)
											{
											default:
												switch (num10)
												{
												case 990:
													break;
												default:
													goto end_IL_04f8;
												case 10:
													result = false;
													num9 = 10;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
													{
														num9 = 0;
													}
													continue;
												}
												goto IL_04f4;
											case 2:
												text3 = null;
												num10 = 10;
												goto IL_04f4;
											case 1:
												hpQffKqiYwt(text3, targetPath, discardIfOriginalExists: true);
												num9 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
												{
													num9 = 8;
												}
												continue;
											case 0:
												break;
												IL_04f4:
												num9 = num10;
												continue;
												end_IL_04f8:
												break;
											}
											break;
										}
										goto end_IL_01e5;
									}
									goto case 7;
								case 6:
									goto end_IL_01e5;
								case 7:
									System.IO.File.Delete(text3);
									num4 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
									{
										num4 = 17;
									}
									continue;
								case 23:
									result = false;
									num4 = 13;
									continue;
								case 14:
									R26ffHLErFd(targetPath);
									num4 = 17;
									continue;
								case 12:
									flag = v62ffB9WiqW(UC3ffgJjJFG(text3));
									num4 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										num4 = 12;
									}
									continue;
								case 5:
									result = true;
									num4 = 8;
									continue;
								case 20:
									try
									{
										System.IO.File.Move(text, targetPath, false);
										int num15 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
										{
											num15 = 1;
										}
										while (true)
										{
											switch (num15)
											{
											default:
												if (num16 == 989)
												{
													num15 = num16;
													continue;
												}
												break;
											case 1:
												break;
											case 0:
												goto end_IL_0346;
											}
											result = true;
											num15 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
											{
												num15 = 0;
											}
											continue;
											end_IL_0346:
											break;
										}
									}
									catch (IOException)
									{
										int num17 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
										{
											num17 = 1;
										}
										while (true)
										{
											switch (num17)
											{
											default:
												if (num18 == 989)
												{
													num17 = num18;
													continue;
												}
												break;
											case 1:
												result = false;
												num17 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
												{
													num17 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									goto end_IL_01e5;
								case 1:
									goto end_IL_01e5;
								case 13:
									goto end_IL_01e5;
								case 19:
									text3 = null;
									num4 = 5;
									continue;
								case 4:
									hpQffKqiYwt(text3, targetPath, discardIfOriginalExists: false);
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
									{
										num4 = 23;
									}
									continue;
								case 0:
									try
									{
										(val).Write(data);
										int num11 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
										{
											num11 = 0;
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
												goto end_IL_0613;
											}
											(val).Flush(true);
											num11 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
											{
												num11 = 4;
											}
											continue;
											end_IL_0613:
											break;
										}
									}
									finally
									{
										if (val != null)
										{
											int num13 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
											{
												num13 = 4;
											}
											while (true)
											{
												switch (num13)
												{
												default:
													if (num14 == 989)
													{
														num13 = num14;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_069c;
												}
												(val).Dispose();
												num13 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
												{
													num13 = 0;
												}
												continue;
												end_IL_069c:
												break;
											}
										}
									}
									goto case 24;
								case 25:
									R26ffHLErFd(targetPath);
									num4 = 22;
									continue;
								case 24:
									if (!System.IO.File.Exists(targetPath))
									{
										num4 = 20;
										continue;
									}
									goto case 11;
								case 9:
									if (!string.Equals(text2, (string)uJbffOSvrlj, (StringComparison)4))
									{
										num4 = 15;
										continue;
									}
									goto case 23;
								case 16:
									System.IO.File.Move(targetPath, text3, false);
									num4 = 25;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num4 = 12;
									}
									continue;
								case 22:
									result = false;
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
									{
										num4 = 5;
									}
									continue;
								case 2:
									text3 = null;
									num5 = 14;
									goto IL_01dd;
								case 10:
									num5 = 33;
									goto IL_01dd;
								case 18:
									if (!flag)
									{
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
										{
											num4 = 27;
										}
										continue;
									}
									goto case 10;
								case 11:
									text2 = UC3ffgJjJFG(targetPath);
									num4 = 9;
									continue;
								case 3:
								case 15:
									if (!A4Pff5CCTQ3.Invoke(text2))
									{
										num4 = 33;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
										{
											num4 = 25;
										}
										continue;
									}
									break;
								case 17:
									result = false;
									num4 = 6;
									continue;
								case 21:
									break;
								case 8:
									goto end_IL_01e5;
									IL_01dd:
									num6 = num5;
									goto IL_01e1;
									IL_01e1:
									num4 = num6;
									continue;
								}
								text3 = WV5ffluvL6S(targetPath, "replace");
								num4 = 16;
								continue;
								end_IL_01e5:
								break;
							}
						}
						finally
						{
							int num19;
							if (text3 == null)
							{
								num19 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
								{
									num19 = 2;
								}
								goto IL_08bf;
							}
							goto IL_090b;
							IL_08bf:
							while (true)
							{
								switch (num19)
								{
								default:
									if (num20 == 991)
									{
										num19 = num20;
										continue;
									}
									break;
								case 3:
									break;
								case 1:
								case 2:
									I77fftUEAti(text);
									num19 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
									{
										num19 = 0;
									}
									continue;
								case 0:
									goto end_IL_08bf;
								}
								goto IL_090b;
								continue;
								end_IL_08bf:
								break;
							}
							goto end_IL_0887;
							IL_090b:
							hpQffKqiYwt(text3, targetPath, flag);
							num19 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num19 = 1;
							}
							goto IL_08bf;
							end_IL_0887:;
						}
						goto case 2;
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
			string text4 = LelffdgSLEd(targetPath);
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(6, 2);
			(defaultInterpolatedStringHandler).AppendLiteral(".");
			(defaultInterpolatedStringHandler).AppendFormatted(System.IO.Path.GetFileName(targetPath));
			(defaultInterpolatedStringHandler).AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted<Guid>(System.Guid.NewGuid(), "N");
			(defaultInterpolatedStringHandler).AppendLiteral(".tmp");
			text = System.IO.Path.Combine(text4, (defaultInterpolatedStringHandler).ToStringAndClear());
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool SDUff7jrRta(string targetPath)
	{
		int num = 4;
		string text = default(string);
		int num5 = default(int);
		bool result = default(bool);
		bool flag = default(bool);
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						text = WV5ffluvL6S(targetPath, "withdraw");
						num3 = 2;
						continue;
					case 0:
						return false;
					case 3:
						try
						{
							System.IO.File.Move(targetPath, text, false);
							int num4 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								num4 = 4;
							}
							while (true)
							{
								int num6;
								switch (num4)
								{
								default:
									if (num5 != 17)
									{
										if (num5 != 997)
										{
											break;
										}
										goto IL_00b5;
									}
									result = false;
									num6 = 1;
									goto IL_00b1;
								case 3:
									hpQffKqiYwt(text, targetPath, discardIfOriginalExists: false);
									num4 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num4 = 6;
									}
									continue;
								case 6:
									text = null;
									num6 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
									{
										num6 = 12;
									}
									goto IL_00b1;
								case 2:
									if (flag)
									{
										num4 = 7;
										continue;
									}
									goto case 3;
								case 1:
									break;
								case 5:
								case 7:
									System.IO.File.Delete(text);
									num4 = 8;
									continue;
								case 0:
									result = true;
									num4 = 9;
									continue;
								case 8:
									text = null;
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
									{
										num4 = 7;
									}
									continue;
								case 4:
									flag = v62ffB9WiqW(UC3ffgJjJFG(text));
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
									{
										num4 = 8;
									}
									continue;
								case 9:
									break;
									IL_00b5:
									num4 = num5;
									continue;
									IL_00b1:
									num5 = num6;
									goto IL_00b5;
								}
								break;
							}
						}
						finally
						{
							int num7;
							if (text == null)
							{
								num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
								{
									num7 = 8;
								}
								goto IL_023e;
							}
							goto IL_0262;
							IL_023e:
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 990)
									{
										goto IL_023a;
									}
									goto end_IL_023e;
								case 0:
									break;
								case 1:
									goto end_IL_023e;
								case 2:
									goto end_IL_023e;
								}
								goto IL_0262;
								IL_023a:
								num7 = num8;
								continue;
								end_IL_023e:
								break;
							}
							goto end_IL_0206;
							IL_0262:
							hpQffKqiYwt(text, targetPath, flag);
							num7 = 2;
							goto IL_023e;
							end_IL_0206:;
						}
						goto case 1;
					case 2:
						flag = false;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num3 = 3;
						}
						continue;
					case 1:
						return result;
					case 4:
						if (taZffr0uFRI(targetPath))
						{
							break;
						}
						goto case 0;
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
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void q9BffA52Xuk(string quarantinePath)
	{
		System.IO.File.Delete(quarantinePath);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void mPfffIOZLeh(string quarantinePath, string originalPath)
	{
		hpQffKqiYwt(quarantinePath, originalPath, discardIfOriginalExists: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool v62ffB9WiqW(string sha256)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string UC3ffgJjJFG(object path)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		int num = 1;
		string result = default(string);
		FileStream val = default(FileStream);
		int num4 = default(int);
		int num6 = default(int);
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
					goto case 2;
				case 2:
					return result;
				case 1:
					val = new FileStream((string)path, (FileMode)3, (FileAccess)1, (FileShare)7);
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					try
					{
						result = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val));
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
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
									num3 = num4;
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
						int num5;
						if (val == null)
						{
							num5 = 2;
							goto IL_00ef;
						}
						goto IL_0137;
						IL_0137:
						(val).Dispose();
						num5 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num5 = 1;
						}
						goto IL_00ef;
						IL_00ef:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_00eb;
								}
								goto end_IL_00ef;
							case 2:
								goto end_IL_00ef;
							case 0:
								break;
							case 1:
								goto end_IL_00ef;
							}
							goto IL_0137;
							IL_00eb:
							num5 = num6;
							continue;
							end_IL_00ef:
							break;
						}
					}
					goto case 2;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string WV5ffluvL6S(object originalPath, object purpose)
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		string text = LelffdgSLEd(originalPath);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(14, 3);
		(defaultInterpolatedStringHandler).AppendLiteral(".");
		(defaultInterpolatedStringHandler).AppendFormatted(System.IO.Path.GetFileName((string)originalPath));
		(defaultInterpolatedStringHandler).AppendLiteral(".");
		(defaultInterpolatedStringHandler).AppendFormatted((string)purpose);
		(defaultInterpolatedStringHandler).AppendLiteral(".");
		defaultInterpolatedStringHandler.AppendFormatted<Guid>(System.Guid.NewGuid(), "N");
		(defaultInterpolatedStringHandler).AppendLiteral(".quarantine");
		return System.IO.Path.Combine(text, (defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string LelffdgSLEd(object path)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void hpQffKqiYwt(string quarantinePath, string originalPath, bool discardIfOriginalExists)
	{
		int num = 3;
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					try
					{
						int num3;
						if (System.IO.File.Exists(originalPath))
						{
							num3 = 2;
							goto IL_0066;
						}
						goto IL_00c3;
						IL_00c3:
						System.IO.File.Move(quarantinePath, originalPath, false);
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
						{
							num3 = 0;
						}
						goto IL_0066;
						IL_0066:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 0:
								return;
							case 5:
								return;
							case 6:
								return;
							case 7:
								return;
							default:
								if (num5 != 15)
								{
									if (num5 == 995)
									{
										goto IL_0062;
									}
									goto case 1;
								}
								System.IO.File.Delete(quarantinePath);
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
								{
									num3 = 5;
								}
								continue;
							case 1:
							{
								Action<string>? obj = bdVff6kwITg;
								if (obj == null)
								{
									num4 = 7;
									goto IL_005e;
								}
								obj.Invoke(string.Concat("foreign patch quarantined file=", System.IO.Path.GetFileName(quarantinePath)));
								num3 = 6;
								continue;
							}
							case 4:
								break;
							case 2:
							case 3:
								{
									if (discardIfOriginalExists)
									{
										num4 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
										{
											num4 = 15;
										}
										goto IL_005e;
									}
									goto case 1;
								}
								IL_0062:
								num3 = num5;
								continue;
								IL_005e:
								num5 = num4;
								goto IL_0062;
							}
							break;
						}
						goto IL_00c3;
					}
					catch (IOException)
					{
						int num6 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 0:
								return;
							case 2:
								return;
							default:
								if (num7 == 990)
								{
									num6 = num7;
									continue;
								}
								break;
							case 1:
								break;
							}
							Action<string>? obj2 = bdVff6kwITg;
							if (obj2 == null)
							{
								num6 = 2;
								continue;
							}
							obj2.Invoke(string.Concat("patch quarantine restore deferred file=", System.IO.Path.GetFileName(quarantinePath)));
							num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num6 = 6;
							}
						}
					}
					catch (UnauthorizedAccessException)
					{
						int num8 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							case 1:
								return;
							case 2:
								return;
							default:
								if (num9 != 990)
								{
									return;
								}
								num8 = num9;
								break;
							case 0:
							{
								Action<string>? obj3 = bdVff6kwITg;
								if (obj3 == null)
								{
									num8 = 2;
									break;
								}
								obj3.Invoke(string.Concat("patch quarantine restore denied file=", System.IO.Path.GetFileName(quarantinePath)));
								num8 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
								{
									num8 = 1;
								}
								break;
							}
							}
						}
					}
				case 3:
					if (!System.IO.File.Exists(quarantinePath))
					{
						num2 = 2;
						continue;
					}
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
					{
						num2 = 8;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
		}
		while (num == 991);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void R26ffHLErFd(string path)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void I77fftUEAti(object path)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			case 1:
				try
				{
					System.IO.File.Delete((string)path);
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
					{
						num2 = 6;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						}
						if (num3 == 988)
						{
							num2 = num3;
							continue;
						}
						return;
					}
				}
				catch (IOException)
				{
					int num4 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 0:
							return;
						}
						if (num5 == 988)
						{
							num4 = num5;
							continue;
						}
						return;
					}
				}
				catch (UnauthorizedAccessException)
				{
					int num6 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
					{
						num6 = 6;
					}
					while (true)
					{
						switch (num6)
						{
						case 0:
							return;
						}
						if (num7 == 988)
						{
							num6 = num7;
							continue;
						}
						return;
					}
				}
			default:
				return;
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
	internal static bool ThCkjwZTbNajqXW36gIu()
	{
		return qvIqL7ZszkUJ51IKGShA == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static YtPZc0ff4HhtXJ66KDeo Rx53NnZTXUGNuU9chawE()
	{
		return (YtPZc0ff4HhtXJ66KDeo)qvIqL7ZszkUJ51IKGShA;
	}
}

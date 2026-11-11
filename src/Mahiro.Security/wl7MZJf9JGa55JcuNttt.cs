using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OWRumnXNe7U48tXBXFAY;
using fDAldojjppXrctUVYOJn;

namespace VmyCchf9QcHocsriWV0s;

internal class wl7MZJf9JGa55JcuNttt
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass3_0_6
	{
		public string directory;

		public Func<string, string> __9__0;

		internal static __c__DisplayClass3_0_6 UAKNwhD8DZloGkScttBv;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass3_0_6()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
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
		internal string NlALSTxNx8J(string path)
		{
			return System.IO.Path.GetRelativePath(directory, path);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool RAH15hD8kMPeaeh514a2()
		{
			return UAKNwhD8DZloGkScttBv == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass3_0_6 Kj5iHdD8V27KabLJB1g8()
		{
			return UAKNwhD8DZloGkScttBv;
		}
	}

	internal static object FFXrcuZNc0yQx3KnwRp7;

	[MethodImpl((MethodImplOptions)8)]
	internal static string xvbf9C7rgNk(object directory)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return O9rf9Ugobdu(directory, null, System.Threading.CancellationToken.None).Item1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ValueTuple<string, string> V5Jf94rpGNV(object directory)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return O9rf9Ugobdu(directory, null, System.Threading.CancellationToken.None);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string RfPf9h5jD5u(object directory, object destination, CancellationToken cancellationToken)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return O9rf9Ugobdu(directory, System.IO.Path.GetFullPath((string)destination), cancellationToken).Item1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ValueTuple<string, string> O9rf9Ugobdu(object directory, string? destination, CancellationToken cancellationToken)
	{
		//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		__c__DisplayClass3_0_6 _c__DisplayClass3_0_ = default(__c__DisplayClass3_0_6);
		string text2 = default(string);
		int num28 = default(int);
		string current2 = default(string);
		int num31 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		ValueTuple<string, string> result = default(ValueTuple<string, string>);
		IncrementalHash val2 = default(IncrementalHash);
		int num10 = default(int);
		string current = default(string);
		FileStream val3 = default(FileStream);
		bool flag = default(bool);
		string text = default(string);
		byte[] array2 = default(byte[]);
		int num18 = default(int);
		int num15 = default(int);
		FileStream val4 = default(FileStream);
		int num13 = default(int);
		int num17 = default(int);
		int num20 = default(int);
		int num22 = default(int);
		int num24 = default(int);
		int num26 = default(int);
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
						if (num2 != 22)
						{
							if (num2 == 1003)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						enumerator = System.IO.Directory.EnumerateDirectories(_c__DisplayClass3_0_.directory, "*", (SearchOption)1).GetEnumerator();
						num3 = 4;
						continue;
					case 8:
						text2 = string.Concat(((System.ReadOnlySpan<char>)(_c__DisplayClass3_0_.directory).TrimEnd(new char[2]
						{
							Path.DirectorySeparatorChar,
							Path.AltDirectorySeparatorChar
						})), new global::System.ReadOnlySpan<char>(new char[] { Path.DirectorySeparatorChar }));
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							num3 = 15;
						}
						continue;
					case 15:
						if (!string.Equals(_c__DisplayClass3_0_.directory, destination, (StringComparison)5))
						{
							num3 = 20;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 11;
					case 4:
						try
						{
							while (true)
							{
								if (!(enumerator).MoveNext())
								{
									int num27 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
									{
										num27 = 2;
									}
									num28 = num27;
									goto IL_0144;
								}
								goto IL_0225;
								IL_0225:
								current2 = enumerator.Current;
								int num29 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num29 = 6;
								}
								goto IL_0148;
								IL_0148:
								while (true)
								{
									switch (num29)
									{
									default:
										if (num28 != 12)
										{
											if (num28 == 992)
											{
												goto IL_0144;
											}
											goto case 1;
										}
										goto end_IL_01f5;
									case 4:
										System.IO.Directory.CreateDirectory(System.IO.Path.Combine(destination, System.IO.Path.GetRelativePath(_c__DisplayClass3_0_.directory, current2)));
										num29 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num29 = 2;
										}
										continue;
									case 0:
										(cancellationToken).ThrowIfCancellationRequested();
										num29 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
										{
											num29 = 11;
										}
										continue;
									case 2:
										break;
									case 3:
										goto IL_0225;
									case 1:
										KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(current2);
										num29 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
										{
											num29 = 10;
										}
										continue;
									}
									break;
								}
								continue;
								IL_0144:
								num29 = num28;
								goto IL_0148;
								continue;
								end_IL_01f5:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num30 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
								{
									num30 = 6;
								}
								while (true)
								{
									switch (num30)
									{
									default:
										if (num31 == 989)
										{
											num30 = num31;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_02b0;
									}
									(enumerator).Dispose();
									num30 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
									{
										num30 = 0;
									}
									continue;
									end_IL_02b0:
									break;
								}
							}
						}
						goto case 9;
					case 7:
						if (!(destination).StartsWith(text2, (StringComparison)5))
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
							{
								num3 = 10;
							}
							continue;
						}
						goto case 11;
					case 12:
						_c__DisplayClass3_0_.directory = System.IO.Path.GetFullPath(_c__DisplayClass3_0_.directory);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
						{
							num3 = 21;
						}
						continue;
					case 2:
						_c__DisplayClass3_0_ = (__c__DisplayClass3_0_6)new __c__DisplayClass3_0_6();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
						{
							num3 = 11;
						}
						continue;
					case 3:
						try
						{
							IncrementalHash val = System.Security.Cryptography.IncrementalHash.CreateHash(System.Security.Cryptography.HashAlgorithmName.SHA256);
							int num4 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										goto IL_03ee;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_03ee:
								num4 = num5;
							}
							try
							{
								byte[] array = new byte[131072];
								int num6 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
								{
									num6 = 0;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 991)
										{
											num6 = num7;
											continue;
										}
										goto case 1;
									case 1:
										result = new ValueTuple<string, string>(System.Convert.ToHexString((val2).GetHashAndReset()), System.Convert.ToHexString((val).GetHashAndReset()));
										num6 = 3;
										continue;
									case 2:
										try
										{
											while (true)
											{
												IL_0bb5:
												int num8;
												if (!(enumerator).MoveNext())
												{
													num8 = 7;
													goto IL_04cb;
												}
												goto IL_0aee;
												IL_04cf:
												int num9 = num10;
												goto IL_04d3;
												IL_0aee:
												current = enumerator.Current;
												num9 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
												{
													num9 = 14;
												}
												goto IL_04d3;
												IL_0b16:
												val3 = new FileStream(current, (FileMode)3, (FileAccess)1, (FileShare)1);
												num8 = 24;
												goto IL_04cb;
												IL_04d3:
												while (true)
												{
													switch (num9)
													{
													case 13:
														flag = !(text).Equals("contents.json", (StringComparison)5);
														num9 = 8;
														continue;
													case 1:
														if (!flag)
														{
															num9 = 4;
															continue;
														}
														goto case 5;
													case 11:
														(val2).AppendData(System.BitConverter.GetBytes(array2.Length));
														num9 = 15;
														continue;
													case 2:
														(val).AppendData(array2);
														num9 = 10;
														continue;
													case 8:
														array2 = (System.Text.Encoding.UTF8).GetBytes((text).Replace('\\', '/'));
														num9 = 9;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
														{
															num9 = 11;
														}
														continue;
													case 15:
														(val2).AppendData(array2);
														num9 = 14;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
														{
															num9 = 1;
														}
														continue;
													case 3:
														KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(current);
														num9 = 9;
														continue;
													case 9:
														if ((System.IO.File.GetAttributes(current) & (FileAttributes)(0x400)) == 0)
														{
															num9 = 6;
															continue;
														}
														goto case 12;
													case 16:
														goto IL_0aee;
													case 4:
													case 10:
														goto IL_0b16;
													case 5:
														(val).AppendData(System.BitConverter.GetBytes(array2.Length));
														num9 = 2;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
														{
															num9 = 22;
														}
														continue;
													case 12:
														throw new InvalidDataException("资源备份不能包含符号链接");
													case 6:
														text = System.IO.Path.GetRelativePath(_c__DisplayClass3_0_.directory, current);
														num9 = 13;
														continue;
													case 0:
														goto IL_0bb5;
													case 14:
														goto IL_0bd0;
													case 7:
														goto end_IL_0bb5;
													}
													break;
												}
												if (num10 != 24)
												{
													if (num10 == 1004)
													{
														goto IL_04cf;
													}
													goto IL_0b16;
												}
												try
												{
													int num11;
													if (destination != null)
													{
														num11 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
														{
															num11 = 2;
														}
														goto IL_05e7;
													}
													object obj = null;
													goto IL_0630;
													IL_05e7:
													while (true)
													{
														switch (num11)
														{
														default:
															if (num18 == 989)
															{
																goto IL_05e3;
															}
															goto case 1;
														case 1:
															obj = (object)new FileStream(System.IO.Path.Combine(destination, text), (FileMode)1, (FileAccess)2, (FileShare)0, array.Length, (FileOptions)134217728);
															break;
														case 0:
															try
															{
																(val2).AppendData(System.BitConverter.GetBytes((val3).Length));
																int num12 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
																{
																	num12 = 16;
																}
																while (true)
																{
																	switch (num12)
																	{
																	default:
																		if (num15 != 20)
																		{
																			if (num15 == 1000)
																			{
																				goto IL_06a1;
																			}
																			goto case 5;
																		}
																		goto case 2;
																	case 1:
																		if (!flag)
																		{
																			num12 = 12;
																			continue;
																		}
																		goto case 4;
																	case 7:
																		(val4).Write(array, 0, num13);
																		num12 = 16;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
																		{
																			num12 = 2;
																		}
																		continue;
																	case 2:
																	case 11:
																	case 12:
																		if ((num13 = (val3).Read(array, 0, array.Length)) <= 0)
																		{
																			num12 = 8;
																			continue;
																		}
																		goto case 10;
																	case 5:
																	case 6:
																		if (val4 == null)
																		{
																			int num14 = 6;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
																			{
																				num14 = 20;
																			}
																			num15 = num14;
																			goto IL_06a1;
																		}
																		goto case 7;
																	case 4:
																		(val).AppendData(System.BitConverter.GetBytes((val3).Length));
																		num12 = 11;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
																		{
																			num12 = 5;
																		}
																		continue;
																	case 3:
																		if (!flag)
																		{
																			num12 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
																			{
																				num12 = 6;
																			}
																			continue;
																		}
																		goto case 9;
																	case 9:
																		(val).AppendData(array, 0, num13);
																		num12 = 5;
																		continue;
																	case 10:
																		(cancellationToken).ThrowIfCancellationRequested();
																		num12 = 17;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
																		{
																			num12 = 0;
																		}
																		continue;
																	case 0:
																		(val2).AppendData(array, 0, num13);
																		num12 = 3;
																		continue;
																	case 8:
																		break;
																		IL_06a1:
																		num12 = num15;
																		continue;
																	}
																	break;
																}
															}
															finally
															{
																int num16;
																if (val4 == null)
																{
																	num16 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
																	{
																		num16 = 1;
																	}
																	goto IL_090c;
																}
																goto IL_0930;
																IL_090c:
																while (true)
																{
																	switch (num16)
																	{
																	default:
																		if (num17 == 990)
																		{
																			goto IL_0908;
																		}
																		break;
																	case 0:
																		break;
																	case 1:
																		goto end_IL_090c;
																	case 2:
																		goto end_IL_090c;
																	}
																	goto IL_0930;
																	IL_0908:
																	num16 = num17;
																	continue;
																	end_IL_090c:
																	break;
																}
																goto end_IL_08d4;
																IL_0930:
																(val4).Dispose();
																num16 = 2;
																goto IL_090c;
																end_IL_08d4:;
															}
															goto end_IL_05e7;
														}
														goto IL_0630;
														IL_05e3:
														num11 = num18;
														continue;
														end_IL_05e7:
														break;
													}
													goto end_IL_05b0;
													IL_0630:
													val4 = (FileStream)obj;
													num11 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
													{
														num11 = 0;
													}
													goto IL_05e7;
													end_IL_05b0:;
												}
												finally
												{
													if (val3 != null)
													{
														int num19 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
														{
															num19 = 1;
														}
														while (true)
														{
															switch (num19)
															{
															default:
																if (num20 == 989)
																{
																	num19 = num20;
																	continue;
																}
																break;
															case 1:
																(val3).Dispose();
																num19 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
																{
																	num19 = 3;
																}
																continue;
															case 0:
																break;
															}
															break;
														}
													}
												}
												continue;
												IL_0bd0:
												(cancellationToken).ThrowIfCancellationRequested();
												num8 = 3;
												goto IL_04cb;
												IL_04cb:
												num10 = num8;
												goto IL_04cf;
												continue;
												end_IL_0bb5:
												break;
											}
										}
										finally
										{
											int num21;
											if (enumerator == null)
											{
												num21 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
												{
													num21 = 2;
												}
												goto IL_0c23;
											}
											goto IL_0c47;
											IL_0c23:
											while (true)
											{
												switch (num21)
												{
												default:
													if (num22 == 990)
													{
														goto IL_0c1f;
													}
													goto end_IL_0c23;
												case 0:
													break;
												case 2:
													goto end_IL_0c23;
												case 1:
													goto end_IL_0c23;
												}
												goto IL_0c47;
												IL_0c1f:
												num21 = num22;
												continue;
												end_IL_0c23:
												break;
											}
											goto end_IL_0beb;
											IL_0c47:
											(enumerator).Dispose();
											num21 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
											{
												num21 = 1;
											}
											goto IL_0c23;
											end_IL_0beb:;
										}
										goto case 1;
									case 0:
										enumerator = ((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(System.IO.Directory.EnumerateFiles(_c__DisplayClass3_0_.directory, "*", (SearchOption)1), (Func<string, string>)_c__DisplayClass3_0_.NlALSTxNx8J, (IComparer<string>)(object)System.StringComparer.Ordinal)).GetEnumerator();
										num6 = 2;
										continue;
									case 3:
										break;
									}
									break;
								}
							}
							finally
							{
								int num23;
								if (val == null)
								{
									num23 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
									{
										num23 = 0;
									}
									goto IL_0d6c;
								}
								goto IL_0d90;
								IL_0d6c:
								while (true)
								{
									switch (num23)
									{
									default:
										if (num24 == 990)
										{
											goto IL_0d68;
										}
										goto end_IL_0d6c;
									case 2:
										break;
									case 0:
										goto end_IL_0d6c;
									case 1:
										goto end_IL_0d6c;
									}
									goto IL_0d90;
									IL_0d68:
									num23 = num24;
									continue;
									end_IL_0d6c:
									break;
								}
								goto end_IL_0d34;
								IL_0d90:
								(val).Dispose();
								num23 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
								{
									num23 = 1;
								}
								goto IL_0d6c;
								end_IL_0d34:;
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num25 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
								{
									num25 = 0;
								}
								while (true)
								{
									switch (num25)
									{
									default:
										if (num26 == 989)
										{
											num25 = num26;
											continue;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_0e03;
									}
									(val2).Dispose();
									num25 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
									{
										num25 = 1;
									}
									continue;
									end_IL_0e03:
									break;
								}
							}
						}
						goto case 5;
					case 1:
						_c__DisplayClass3_0_.directory = (string)directory;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
						{
							num3 = 12;
						}
						continue;
					case 0:
						KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(_c__DisplayClass3_0_.directory);
						num3 = 6;
						continue;
					case 9:
					case 13:
						val2 = System.Security.Cryptography.IncrementalHash.CreateHash(System.Security.Cryptography.HashAlgorithmName.SHA256);
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num3 = 3;
						}
						continue;
					case 11:
						throw new InvalidDataException("资源快照目标不能位于源目录内");
					case 10:
						KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(destination);
						num3 = 14;
						continue;
					case 14:
						break;
					case 6:
						if (destination == null)
						{
							num3 = 13;
							continue;
						}
						goto case 8;
					case 5:
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
			System.IO.Directory.CreateDirectory(destination);
			num = 22;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
			{
				num = 12;
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
	internal static bool MMRlclZN0qwbNYeskcr5()
	{
		return FFXrcuZNc0yQx3KnwRp7 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static wl7MZJf9JGa55JcuNttt AFXZgHZN8ZwiH7liYVS6()
	{
		return (wl7MZJf9JGa55JcuNttt)FFXrcuZNc0yQx3KnwRp7;
	}
}

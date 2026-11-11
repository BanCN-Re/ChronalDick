using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using ACrmHXX7wb4EPSETD4RP;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace Hi4QHxX7PLuootHtw8EB;

internal sealed class fdt6pMX7eoS1M4d274Eb
{
	private readonly object SiDX7sxBpHX;

	private readonly global::System.DateTime wgeX7TeEXGH;

	private long ymbX7NvjLES;

	private global::System.DateTime C72X7MLOmJx;

	private object UupX7psHWX5;

	internal static object EnIGeiZtMVT69Spb6OWK;

	[MethodImpl((MethodImplOptions)8)]
	internal fdt6pMX7eoS1M4d274Eb(string path, global::System.DateTime startedUtc)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void u6dX7x1wseV(Action<TetaPsX7ROWISPYULlR1> report)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		int num = 2;
		FileInfo val2 = default(FileInfo);
		FileStream val = default(FileStream);
		int num6 = default(int);
		string text = default(string);
		byte[] array = default(byte[]);
		int num7 = default(int);
		string text2 = default(string);
		string[] array2 = default(string[]);
		int num8 = default(int);
		int num5 = default(int);
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 5;
						}
						if (!(val2).Exists)
						{
							num3 = 7;
							continue;
						}
						if ((val2).Length >= ymbX7NvjLES)
						{
							num = 5;
							break;
						}
						goto case 4;
					case 5:
						if (((val2).CreationTimeUtc != C72X7MLOmJx))
						{
							num3 = 4;
							continue;
						}
						goto case 8;
					case 6:
						UupX7psHWX5 = string.Empty;
						num3 = 3;
						continue;
					case 3:
						C72X7MLOmJx = (val2).CreationTimeUtc;
						num3 = 8;
						continue;
					case 7:
						return;
					case 4:
						ymbX7NvjLES = 0L;
						num3 = 6;
						continue;
					case 2:
						val2 = new FileInfo((string)SiDX7sxBpHX);
						num = 15;
						break;
					case 8:
						val = new FileStream((string)SiDX7sxBpHX, (FileMode)3, (FileAccess)1, (FileShare)7);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						try
						{
							(val).Position = ymbX7NvjLES;
							int num4 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
							{
								num4 = 4;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num6 != 25)
									{
										if (num6 == 1005)
										{
											goto IL_018b;
										}
										goto case 7;
									}
									text = string.Concat((string)UupX7psHWX5, (System.Text.Encoding.ASCII).GetString(array, 0, num7));
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
									{
										num4 = 17;
									}
									break;
								case 16:
									text2 = array2[num8];
									num4 = 4;
									break;
								case 15:
									num8++;
									num4 = 7;
									break;
								case 0:
									num5 = (text).LastIndexOf('\n');
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
									{
										num4 = 9;
									}
									break;
								case 14:
									array = new byte[131072];
									num4 = 10;
									break;
								case 6:
									return;
								case 11:
									array2 = ((text).Substring(0, num5)).Split('\n', (StringSplitOptions)0);
									num4 = 17;
									break;
								case 10:
									num7 = (val).Read(array, 0, array.Length);
									num4 = 3;
									break;
								case 7:
								case 13:
									if (num8 >= array2.Length)
									{
										num4 = 12;
										break;
									}
									goto case 16;
								case 17:
									num8 = 0;
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
									{
										num4 = 13;
									}
									break;
								case 5:
									UupX7psHWX5 = (text).Substring(num5 + 1);
									num4 = 2;
									break;
								case 9:
									if (num5 < 0)
									{
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
										{
											num4 = 15;
										}
										break;
									}
									goto case 5;
								case 4:
									report.Invoke(lxBX7FKsN5s((text2).TrimEnd('\r'), wgeX7TeEXGH));
									num4 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
									{
										num4 = 8;
									}
									break;
								case 3:
									ymbX7NvjLES += num7;
									num6 = 25;
									goto IL_018b;
								case 2:
									if (((dynamic)(UupX7psHWX5)).Length > 65536)
									{
										num4 = 8;
										break;
									}
									goto case 11;
								case 8:
									UupX7psHWX5 = string.Empty;
									num4 = 11;
									break;
								case 1:
									UupX7psHWX5 = (((text).Length <= 65536) ? text : string.Empty);
									num4 = 6;
									break;
								case 12:
									return;
									IL_018b:
									num4 = num6;
									break;
								}
							}
						}
						finally
						{
							int num9;
							if (val == null)
							{
								num9 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
								{
									num9 = 2;
								}
								goto IL_0495;
							}
							goto IL_04dd;
							IL_0495:
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 990)
									{
										goto IL_0491;
									}
									goto end_IL_0495;
								case 2:
									goto end_IL_0495;
								case 1:
									break;
								case 0:
									goto end_IL_0495;
								}
								goto IL_04dd;
								IL_0491:
								num9 = num10;
								continue;
								end_IL_0495:
								break;
							}
							goto end_IL_045d;
							IL_04dd:
							(val).Dispose();
							num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num9 = 1;
							}
							goto IL_0495;
							end_IL_045d:;
						}
					case 1:
						return;
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
	internal static TetaPsX7ROWISPYULlR1 lxBX7FKsN5s(object encoded, global::System.DateTime startedUtc)
	{
		int num = 9;
		int num6 = default(int);
		TetaPsX7ROWISPYULlR1 result = default(TetaPsX7ROWISPYULlR1);
		int num7 = default(int);
		global::System.DateTime dateTime = default(global::System.DateTime);
		string text2 = default(string);
		int num9 = default(int);
		bool flag = default(bool);
		int num4 = default(int);
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
							goto case 0;
						}
						goto case 4;
					case 0:
						try
						{
							string text = (System.Text.Encoding.UTF8).GetString(System.Convert.FromBase64String((string)encoded));
							int num5 = 13;
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 != 27)
									{
										if (num6 == 1007)
										{
											goto IL_0098;
										}
										goto case 1;
									}
									goto end_IL_009c;
								case 12:
									result = TetaPsX7ROWISPYULlR1.None;
									num6 = 27;
									goto IL_0098;
								case 3:
									if (num7 != 26)
									{
										num5 = 12;
										continue;
									}
									break;
								case 2:
									goto end_IL_009c;
								case 0:
									goto end_IL_009c;
								case 4:
								case 8:
									result = TetaPsX7ROWISPYULlR1.None;
									num5 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
									{
										num5 = 0;
									}
									continue;
								case 16:
									if (!((dateTime).ToUniversalTime() < startedUtc))
									{
										num5 = 19;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
										{
											num5 = 2;
										}
										continue;
									}
									goto case 4;
								case 11:
									if (((dynamic)(text)).Chars == '[')
									{
										num5 = 9;
										continue;
									}
									goto case 4;
								case 1:
								case 15:
									if ((text2 == "link server login success"))
									{
										num5 = 18;
										continue;
									}
									goto IL_0524;
								case 18:
									result = TetaPsX7ROWISPYULlR1.LinkConnected;
									num5 = 2;
									continue;
								case 17:
								case 19:
									num7 = (text).IndexOf("[INFO] ", 25, (StringComparison)4);
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
									{
										num5 = 16;
									}
									continue;
								case 14:
									goto end_IL_009c;
								case 13:
									if ((text).Length < 25)
									{
										num5 = 4;
										continue;
									}
									goto case 11;
								case 7:
									result = TetaPsX7ROWISPYULlR1.LoginSucceeded;
									num5 = 14;
									continue;
								case 5:
									if (!(text2 == "seayoung -------------------> application OnLoginSuccess"))
									{
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
										{
											num5 = 8;
										}
										continue;
									}
									goto case 7;
								case 9:
									if (System.DateTime.TryParseExact((text).Substring(1, 23), "yyyy-MM-dd HH:mm:ss,fff", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, (DateTimeStyles)32, out dateTime))
									{
										num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
										{
											num5 = 16;
										}
										continue;
									}
									goto case 4;
								case 10:
									break;
								case 6:
									goto IL_0524;
									IL_0098:
									num5 = num6;
									continue;
								}
								text2 = ((text).Substring(num7 + 7)).TrimEnd();
								num5 = 5;
								continue;
								end_IL_009c:
								break;
							}
						}
						catch (FormatException)
						{
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
							{
								num8 = 6;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 988)
									{
										num8 = num9;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
							goto IL_0524;
						}
						return result;
					case 7:
						flag = true;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
						{
							num3 = 11;
						}
						continue;
					case 6:
						break;
					case 8:
						if (num4 <= 65536)
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 7;
					case 2:
						return TetaPsX7ROWISPYULlR1.None;
					case 3:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
						{
							num3 = 7;
						}
						continue;
					case 4:
						if (!flag)
						{
							num3 = 3;
							continue;
						}
						goto case 2;
					case 9:
						num4 = ((dynamic)(encoded)).Length;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
						{
							num3 = 8;
						}
						continue;
					case 5:
						goto IL_0524;
					case 1:
						{
							if (num4 == 0)
							{
								num3 = 7;
								continue;
							}
							break;
						}
						IL_0524:
						return TetaPsX7ROWISPYULlR1.None;
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
			flag = false;
			num = 16;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
			{
				num = 15;
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
	internal static bool sfW6XhZtpe0a2hnlLRr9()
	{
		return EnIGeiZtMVT69Spb6OWK == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static fdt6pMX7eoS1M4d274Eb RJgPkNZtuXPe2EHYcNCC()
	{
		return (fdt6pMX7eoS1M4d274Eb)EnIGeiZtMVT69Spb6OWK;
	}
}

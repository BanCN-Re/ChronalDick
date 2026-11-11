using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using RkEBBcxE6uQHIJCVGy1;
using pymVW0xBtExkA35SOSf;

namespace O969sp28LcEieuLKifC;

internal sealed class QARu6t20fxWDHoSEZUQ : IEquatable<QARu6t20fxWDHoSEZUQ>
{
	[CompilerGenerated]
	private string NDc2Chq2aG;

	[CompilerGenerated]
	private string LIb24mxXGg;

	private static IReadOnlyDictionary<string, QARu6t20fxWDHoSEZUQ> Xt62hQPQjI;

	private static object y24psnZrMXR6Mgc9BOug;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(QARu6t20fxWDHoSEZUQ).TypeHandle);
		}
	}

	public string BootstrapMd5
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return NDc2Chq2aG;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						NDc2Chq2aG = value;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	public string DatMd5
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return LIb24mxXGg;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
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
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					LIb24mxXGg = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
					{
						num2 = 6;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public QARu6t20fxWDHoSEZUQ(string BootstrapMd5, string DatMd5)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		NDc2Chq2aG = BootstrapMd5;
		LIb24mxXGg = DatMd5;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QARu6t20fxWDHoSEZUQ qWT2y4km5Y(object paths, object version)
	{
		//IL_064c->IL0010: Incompatible stack heights: 3 vs 1
		int num = 13;
		string text2 = default(string);
		string text = default(string);
		int num5 = default(int);
		QARu6t20fxWDHoSEZUQ result = default(QARu6t20fxWDHoSEZUQ);
		int num7 = default(int);
		int num9 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		global::System.Exception ex = default(global::System.Exception);
		int num12 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num14 = default(int);
		QARu6t20fxWDHoSEZUQ qARu6t20fxWDHoSEZUQ = default(QARu6t20fxWDHoSEZUQ);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 20)
						{
							if (num2 == 1001)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						obj = null;
						goto IL_0653;
					case 10:
						if (System.IO.File.Exists(text2))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 4;
					case 9:
						if (string.IsNullOrWhiteSpace(text))
						{
							num3 = 2;
							continue;
						}
						text2 = System.IO.Path.Combine(((bnHA9vxvBiUJqO7FLm4)paths).MinecraftPath, "versions", (string)version, string.Concat((string)version, ".dat"));
						num3 = 10;
						continue;
					case 13:
						System.ArgumentNullException.ThrowIfNull(paths, "paths");
						num3 = 12;
						continue;
					case 6:
						try
						{
							FileStream val = System.IO.File.OpenRead(text2);
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
							{
								num4 = 3;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										goto IL_0125;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0125:
								num4 = num5;
							}
							try
							{
								result = (QARu6t20fxWDHoSEZUQ)new QARu6t20fxWDHoSEZUQ(text, System.Convert.ToHexString(System.Security.Cryptography.MD5.HashData((Stream)(object)val)));
								int num6 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
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
											num6 = num7;
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
									int num8 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
									{
										num8 = 6;
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
											(val).Dispose();
											num8 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
											{
												num8 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						}
						catch (object obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj3 = obj2 as global::System.Exception;
							if (obj3 == null)
							{
								num10 = 2;
							}
							else
							{
								ex = obj3;
								num10 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
								{
									num10 = 6;
								}
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num12 != 14 && num12 == 994)
									{
										goto IL_025f;
									}
									goto case 3;
								case 4:
									flag = true;
									num10 = 5;
									continue;
								case 3:
									flag = false;
									num10 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
									{
										num10 = 0;
									}
									continue;
								case 6:
									if (!(ex is UnauthorizedAccessException))
									{
										num11 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
										{
											num11 = 4;
										}
										num12 = num11;
										goto IL_025f;
									}
									goto case 4;
								case 1:
									if (!(ex is IOException))
									{
										num10 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
										{
											num10 = 3;
										}
										continue;
									}
									goto case 4;
								case 2:
									result2 = 0;
									break;
								case 0:
								case 5:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_025f:
									num10 = num12;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num13 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
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
										goto IL_03b9;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_03b9:
								num13 = num14;
							}
							string.Concat("Java ", (string)version, " 认证数据文件无法读取；请先在版本管理执行完整修复");
							throw ex;
						}
						goto case 1;
					case 5:
						if ((object)qARu6t20fxWDHoSEZUQ == null)
						{
							num = 20;
							break;
						}
						obj = qARu6t20fxWDHoSEZUQ.BootstrapMd5;
						goto IL_0653;
					case 11:
						return (QARu6t20fxWDHoSEZUQ)new QARu6t20fxWDHoSEZUQ(text, qARu6t20fxWDHoSEZUQ.DatMd5);
					case 7:
						string.Concat("Java ", (string)version, " 缺少认证数据文件；请先在版本管理执行完整修复");
						throw text2;
					case 3:
						num = 6;
						break;
					case 4:
						if ((object)qARu6t20fxWDHoSEZUQ == null)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 11;
					case 2:
						throw string.Concat("Java ", (string)version, " 未找到可用于认证的启动器组件；请先在版本管理执行完整修复");
					case 1:
						return result;
					case 12:
						if (string.IsNullOrWhiteSpace((string)version))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
							{
								num3 = 14;
							}
						}
						else
						{
							_ = Xt62hQPQjI;
							_ = qARu6t20fxWDHoSEZUQ;
							_ = 8;
						}
						continue;
					case 8:
						obj = T9aWH1xI0Xs2EEuP6v4.AVCxgB5QUo(paths, version);
						if (obj == null)
						{
							num = 5;
							break;
						}
						goto IL_0653;
					case 0:
						{
							_ = "Java 版本不能为空";
							throw new global::System.Exception("version");
						}
						IL_0653:
						text = (string)obj;
						num3 = 9;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool MjB2WHZaO4(StringBuilder builder)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 11)
						{
							(builder).Append("BootstrapMd5 = ");
							num3 = 3;
							continue;
						}
						goto end_IL_0010;
					case 0:
						return true;
					case 4:
						(builder).Append(", DatMd5 = ");
						num3 = 2;
						continue;
					case 2:
						(builder).Append(DatMd5);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						(builder).Append(BootstrapMd5);
						num3 = 4;
						continue;
					case 1:
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
			while (num2 == 992);
			System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
			{
				num = 2;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(QARu6t20fxWDHoSEZUQ? left, QARu6t20fxWDHoSEZUQ? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(QARu6t20fxWDHoSEZUQ? left, QARu6t20fxWDHoSEZUQ? right)
	{
		int num = 2;
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
					goto case 0;
				case 0:
					return ((QARu6t20fxWDHoSEZUQ)left).Equals((QARu6t20fxWDHoSEZUQ?)right);
				case 2:
					if (left == right)
					{
						return true;
					}
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					if (left == null)
					{
						return false;
					}
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
					{
						num2 = 5;
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
	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		return (int)((EqualityContract * -1521134295 + NDc2Chq2aG) * -1521134295 + LIb24mxXGg);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as QARu6t20fxWDHoSEZUQ);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(QARu6t20fxWDHoSEZUQ? other)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public QARu6t20fxWDHoSEZUQ Mat2Jhhh4u()
	{
		return (QARu6t20fxWDHoSEZUQ)new QARu6t20fxWDHoSEZUQ(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private QARu6t20fxWDHoSEZUQ(QARu6t20fxWDHoSEZUQ original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void E6i2QEssqP(out string BootstrapMd5, out string DatMd5)
	{
		//IL_003c: Expected I8, but got O
		//IL_0064: Expected I8, but got O
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
				case 0:
					DatMd5 = default;
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					BootstrapMd5 = default;
					DatMd5 = default;
					return;
				case 1:
					break;
				}
				goto IL_005c;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_005c;
				IL_005c:
				BootstrapMd5 = default;
				num2 = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		_ = 2;
		System.StringComparer.OrdinalIgnoreCase;
		_ = "1.7.10";
		new QARu6t20fxWDHoSEZUQ("A895FE657915D58F55919CEACD30209D", "538D33D5F35EF01736EDA30F94C61DF6");
		_ = "1.8.9";
		new QARu6t20fxWDHoSEZUQ("A895FE657915D58F55919CEACD30209D", "0CF2074AA7D4B543E35A3D6BB57AF861");
		_ = "1.12.2";
		new QARu6t20fxWDHoSEZUQ("A895FE657915D58F55919CEACD30209D", "51581ADD89B8AC5A0D8CCDD0E33EE1DE");
		_ = "1.16";
		new QARu6t20fxWDHoSEZUQ("7B101583C3965371B89A3C9115B27526", "B0712F34B0A584D05D9D29FA68759E29");
		_ = "1.18";
		new QARu6t20fxWDHoSEZUQ("C3BD2115F23F6FE4B2ADCC7FC4DEFFEA", "56677A2BB31E18246FA241FB02E16D0E");
		_ = "1.19.2";
		new QARu6t20fxWDHoSEZUQ("C3BD2115F23F6FE4B2ADCC7FC4DEFFEA", "56677A2BB31E18246FA241FB02E16D0E");
		_ = "1.20";
		new QARu6t20fxWDHoSEZUQ("2A7A476411A1687A56DC6848829C1AE4", "D285CBF97D9BA30D3C445DBF1C342634");
		_ = "1.20.6";
		new QARu6t20fxWDHoSEZUQ("2A7A476411A1687A56DC6848829C1AE4", "D285CBF97D9BA30D3C445DBF1C342634");
		_ = "1.21";
		new QARu6t20fxWDHoSEZUQ("684528BF492A84489F825F5599B3E1C6", "574033E7E4841D8AC4C14D7FA5E05337");
		_ = "1.21.8";
		Xt62hQPQjI = (IReadOnlyDictionary<string, QARu6t20fxWDHoSEZUQ>)new QARu6t20fxWDHoSEZUQ("5BF6153C69DD28951A699F7F834EFE1A", "C9906B5809A92C73299279E562A78D81");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool UavOPyZrpaxnGARvWZaN()
	{
		return y24psnZrMXR6Mgc9BOug == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QARu6t20fxWDHoSEZUQ emC2WlZruSbsCG25litj()
	{
		return (QARu6t20fxWDHoSEZUQ)y24psnZrMXR6Mgc9BOug;
	}
}

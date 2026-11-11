using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using RkEBBcxE6uQHIJCVGy1;
using fDAldojjppXrctUVYOJn;
using pymVW0xBtExkA35SOSf;

namespace O969sp28LcEieuLKifC;

internal sealed class QARu6t20fxWDHoSEZUQ : IEquatable<QARu6t20fxWDHoSEZUQ>
{
	[CompilerGenerated]
	private string NDc2Chq2aG;

	[CompilerGenerated]
	private string LIb24mxXGg;

	private static readonly IReadOnlyDictionary<string, QARu6t20fxWDHoSEZUQ> Xt62hQPQjI;

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
			NDc2Chq2aG = value;
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
			LIb24mxXGg = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public QARu6t20fxWDHoSEZUQ(string BootstrapMd5, string DatMd5)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QARu6t20fxWDHoSEZUQ qWT2y4km5Y(object paths, object version)
	{
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
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
						goto IL_0667;
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
						catch (global::System.Exception obj2) when (((Func<bool>)delegate
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
							throw new InvalidDataException(string.Concat("Java ", (string)version, " 认证数据文件无法读取；请先在版本管理执行完整修复"), ex);
						}
						goto case 1;
					case 5:
						if ((object)qARu6t20fxWDHoSEZUQ == null)
						{
							num = 20;
							break;
						}
						obj = qARu6t20fxWDHoSEZUQ.BootstrapMd5;
						goto IL_0667;
					case 11:
						return (QARu6t20fxWDHoSEZUQ)new QARu6t20fxWDHoSEZUQ(text, qARu6t20fxWDHoSEZUQ.DatMd5);
					case 7:
						throw new FileNotFoundException(string.Concat("Java ", (string)version, " 缺少认证数据文件；请先在版本管理执行完整修复"), text2);
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
						throw new NotSupportedException(string.Concat("Java ", (string)version, " 未找到可用于认证的启动器组件；请先在版本管理执行完整修复"));
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
							Xt62hQPQjI.TryGetValue((string)version, out qARu6t20fxWDHoSEZUQ);
							num3 = 8;
						}
						continue;
					case 8:
						obj = T9aWH1xI0Xs2EEuP6v4.AVCxgB5QUo(paths, version);
						if (obj == null)
						{
							num = 5;
							break;
						}
						goto IL_0667;
					case 0:
						{
							throw new ArgumentException("Java 版本不能为空", "version");
						}
						IL_0667:
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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool MjB2WHZaO4(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
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
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NDc2Chq2aG)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LIb24mxXGg);
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
		int num = 2;
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void E6i2QEssqP(out string BootstrapMd5, out string DatMd5)
	{
		BootstrapMd5 = default(string);
		DatMd5 = default(string);
		//IL_0008: Expected I8, but got O
DatMd5 = this.DatMd5;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

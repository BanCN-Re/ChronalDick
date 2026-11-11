using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using smtl6Xfx6GZDWuxByNV3;

namespace vYmlyBfslFXKQh5C4Pa2;

public sealed class QTHpUQfsgtyJIMkBwTYM : IEquatable<QTHpUQfsgtyJIMkBwTYM>
{
	[CompilerGenerated]
	private string _Id_k__BackingField;

	[CompilerGenerated]
	private string _Name_k__BackingField;

	[CompilerGenerated]
	private string _GameId_k__BackingField;

	[CompilerGenerated]
	private string _UserId_k__BackingField;

	[CompilerGenerated]
	private I6JeiOfx5MeLutOmkxHA _GameType_k__BackingField;

	[CompilerGenerated]
	private long _CreatedAtUnixSeconds_k__BackingField;

	[CompilerGenerated]
	private long _ExpiresAtUnixSeconds_k__BackingField;

	[CompilerGenerated]
	private bool _IsSynchronized_k__BackingField;

	internal static object Qmpkji99yRFS84RZwcgw;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(QTHpUQfsgtyJIMkBwTYM).TypeHandle);
		}
	}

	public string Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Id_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Id_k__BackingField = value;
		}
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Name_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Name_k__BackingField = value;
		}
	}

	public string GameId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _GameId_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_GameId_k__BackingField = value;
		}
	}

	public string UserId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _UserId_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_UserId_k__BackingField = value;
		}
	}

	public I6JeiOfx5MeLutOmkxHA GameType
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _GameType_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_GameType_k__BackingField = value;
		}
	}

	public long CreatedAtUnixSeconds
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _CreatedAtUnixSeconds_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_CreatedAtUnixSeconds_k__BackingField = value;
		}
	}

	public long ExpiresAtUnixSeconds
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ExpiresAtUnixSeconds_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_ExpiresAtUnixSeconds_k__BackingField = value;
		}
	}

	public bool IsSynchronized
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _IsSynchronized_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_IsSynchronized_k__BackingField = value;
		}
	}

	public DateTimeOffset? CreatedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return QGEfsdP1kyV(CreatedAtUnixSeconds);
		}
	}

	public DateTimeOffset? ExpiresAt
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return QGEfsdP1kyV(ExpiresAtUnixSeconds);
		}
	}

	public bool IsExpired
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset? val = default(DateTimeOffset?);
			DateTimeOffset valueOrDefault = val.GetValueOrDefault();
			return default(bool);
		}
	}

	public bool IsAvailable
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return default(bool);
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	public string DisplayText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public QTHpUQfsgtyJIMkBwTYM(string Id, string Name)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public override string ToString()
	{
		return DisplayText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static DateTimeOffset? QGEfsdP1kyV(long value)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		DateTimeOffset? result = default(DateTimeOffset?);
		int num5 = default(int);
		int num7 = default(int);
		DateTimeOffset? val = default(DateTimeOffset?);
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
							goto case 1;
						}
						return result;
					case 0:
						num3 = 4;
						continue;
					case 1:
						if (value > 0)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_000c;
					case 3:
						goto end_IL_000c;
					case 4:
						try
						{
							result = System.DateTimeOffset.FromUnixTimeSeconds(value);
							int num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
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
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch (ArgumentOutOfRangeException)
						{
							int num6 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										num6 = num7;
										continue;
									}
									goto case 0;
								case 0:
									val = null;
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
									result = val;
									num6 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
									{
										num6 = 3;
									}
									continue;
								case 2:
									break;
								}
								break;
							}
						}
						break;
					case 2:
						break;
					}
					return result;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			result = null;
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool SWlfsKArdb1(StringBuilder builder)
	{
		int num = 19;
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
						if (num2 != 35)
						{
							if (num2 == 1016)
							{
								goto end_IL_0010;
							}
							goto case 26;
						}
						(builder).Append(", CreatedAtUnixSeconds = ");
						num = 16;
						break;
					case 5:
						(builder).Append(UserId);
						num3 = 24;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
						{
							num3 = 6;
						}
						continue;
					case 10:
						(builder).Append(GameId);
						num3 = 8;
						continue;
					case 14:
						(builder).Append(((object)GameType/*cast due to .constrained prefix*/).ToString());
						num = 35;
						break;
					case 23:
						(builder).Append(", ExpiresAtUnixSeconds = ");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num3 = 21;
						}
						continue;
					case 17:
						return true;
					case 13:
						(builder).Append(Name);
						num3 = 7;
						continue;
					case 6:
						(builder).Append(", GameType = ");
						num3 = 14;
						continue;
					case 19:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
						{
							num3 = 9;
						}
						continue;
					case 8:
						(builder).Append(", UserId = ");
						num3 = 5;
						continue;
					case 27:
						(builder).Append(Id);
						num = 20;
						break;
					case 3:
						(builder).Append(((object)IsSynchronized/*cast due to .constrained prefix*/).ToString());
						num3 = 9;
						continue;
					case 12:
						(builder).Append(DisplayText);
						num3 = 17;
						continue;
					case 0:
						(builder).Append(((object)ExpiresAtUnixSeconds/*cast due to .constrained prefix*/).ToString());
						num = 28;
						break;
					case 22:
						(builder).Append(((object)IsExpired/*cast due to .constrained prefix*/).ToString());
						num3 = 24;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
						{
							num3 = 33;
						}
						continue;
					case 9:
						(builder).Append(", CreatedAt = ");
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
						{
							num3 = 21;
						}
						continue;
					case 18:
						(builder).Append("Id = ");
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num3 = 16;
						}
						continue;
					case 4:
						(builder).Append(", DisplayText = ");
						num3 = 30;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
						{
							num3 = 12;
						}
						continue;
					case 28:
						(builder).Append(", IsSynchronized = ");
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num3 = 6;
						}
						continue;
					case 15:
						(builder).Append(((object)ExpiresAt/*cast due to .constrained prefix*/).ToString());
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num3 = 1;
						}
						continue;
					case 20:
						(builder).Append(", Name = ");
						num3 = 13;
						continue;
					case 21:
						(builder).Append(((object)CreatedAt/*cast due to .constrained prefix*/).ToString());
						num3 = 2;
						continue;
					case 2:
						(builder).Append(", ExpiresAt = ");
						num3 = 15;
						continue;
					case 7:
						(builder).Append(", GameId = ");
						num = 10;
						break;
					case 1:
						(builder).Append(", IsExpired = ");
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num3 = 22;
						}
						continue;
					case 26:
						(builder).Append(", StatusText = ");
						num3 = 11;
						continue;
					case 24:
						(builder).Append(", IsAvailable = ");
						num3 = 25;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
						{
							num3 = 27;
						}
						continue;
					case 25:
						(builder).Append(((object)IsAvailable/*cast due to .constrained prefix*/).ToString());
						num = 26;
						break;
					case 16:
						(builder).Append(((object)CreatedAtUnixSeconds/*cast due to .constrained prefix*/).ToString());
						num3 = 26;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
						{
							num3 = 23;
						}
						continue;
					case 11:
						(builder).Append(StatusText);
						num3 = 4;
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
	public static bool operator !=(QTHpUQfsgtyJIMkBwTYM? left, QTHpUQfsgtyJIMkBwTYM? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(QTHpUQfsgtyJIMkBwTYM? left, QTHpUQfsgtyJIMkBwTYM? right)
	{
		int num = 3;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Id_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Name_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_GameId_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_UserId_k__BackingField)) * -1521134295 + EqualityComparer<I6JeiOfx5MeLutOmkxHA>.Default.GetHashCode(_GameType_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_CreatedAtUnixSeconds_k__BackingField)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(_ExpiresAtUnixSeconds_k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_IsSynchronized_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as QTHpUQfsgtyJIMkBwTYM);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(QTHpUQfsgtyJIMkBwTYM? other)
	{
		int num = 6;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public QTHpUQfsgtyJIMkBwTYM LTxfsHC1ujd()
	{
		return (QTHpUQfsgtyJIMkBwTYM)new QTHpUQfsgtyJIMkBwTYM(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private QTHpUQfsgtyJIMkBwTYM(QTHpUQfsgtyJIMkBwTYM original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void LbyfsteJWh7(out string Id, out string Name)
	{
		Id = default(string);
		Name = default(string);
		//IL_0008: Expected I8, but got O
Id = this.Id;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool rU9U8s99WrqPakQO7WTK()
	{
		return Qmpkji99yRFS84RZwcgw == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QTHpUQfsgtyJIMkBwTYM NxHY5T99J8aHlf2itxnf()
	{
		return (QTHpUQfsgtyJIMkBwTYM)Qmpkji99yRFS84RZwcgw;
	}
}

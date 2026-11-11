using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using L920rlXJE07t7SweCSKe;
using fDAldojjppXrctUVYOJn;

namespace Yh4txuXJnTvW8Kqtdvjl;

public sealed class lfXX0hXJiENbR2koEBGi : IEquatable<lfXX0hXJiENbR2koEBGi>
{
	[CompilerGenerated]
	private global::System.Collections.Generic.IReadOnlyList<c2coImXJvwEghB4hbjMJ> _Entries_k__BackingField;

	[CompilerGenerated]
	private global::System.Collections.Generic.IReadOnlyList<string> _Diagnostics_k__BackingField;

	internal static object Ljjx3mZdAvw7V8b4aOu7;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(lfXX0hXJiENbR2koEBGi).TypeHandle);
		}
	}

	public global::System.Collections.Generic.IReadOnlyList<c2coImXJvwEghB4hbjMJ> Entries
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Entries_k__BackingField;
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
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_Entries_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public global::System.Collections.Generic.IReadOnlyList<string> Diagnostics
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Diagnostics_k__BackingField;
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
					case 0:
						return;
					case 1:
						_Diagnostics_k__BackingField = value;
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public lfXX0hXJiENbR2koEBGi(global::System.Collections.Generic.IReadOnlyList<c2coImXJvwEghB4hbjMJ> Entries, global::System.Collections.Generic.IReadOnlyList<string> Diagnostics)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_Entries_k__BackingField = Entries;
		_Diagnostics_k__BackingField = Diagnostics;
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
	private bool rk6XJzJOmbt(StringBuilder builder)
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
						switch (num2)
						{
						case 992:
							break;
						case 11:
							goto IL_00a6;
						default:
							goto end_IL_000c;
						}
						break;
					case 2:
						return true;
					case 1:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
						{
							num3 = 5;
						}
						continue;
					case 4:
						(builder).Append(Diagnostics);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
						{
							num3 = 1;
						}
						continue;
					case 3:
						(builder).Append(", Diagnostics = ");
						num3 = 4;
						continue;
					case 0:
						goto end_IL_000c;
						IL_00a6:
						(builder).Append(Entries);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
						{
							num3 = 3;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			(builder).Append("Entries = ");
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(lfXX0hXJiENbR2koEBGi? left, lfXX0hXJiENbR2koEBGi? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(lfXX0hXJiENbR2koEBGi? left, lfXX0hXJiENbR2koEBGi? right)
	{
		int num = 3;
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
					goto case 2;
				case 2:
					if (left == null)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 1:
					return ((lfXX0hXJiENbR2koEBGi)left).Equals((lfXX0hXJiENbR2koEBGi?)right);
				case 0:
					return false;
				case 3:
					if (left == right)
					{
						return true;
					}
					num2 = 2;
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
		return (EqualityContract * -1521134295 + _Entries_k__BackingField) * -1521134295 + _Diagnostics_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as lfXX0hXJiENbR2koEBGi);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(lfXX0hXJiENbR2koEBGi? other)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public lfXX0hXJiENbR2koEBGi RWsXQbVp5lP()
	{
		return (lfXX0hXJiENbR2koEBGi)new lfXX0hXJiENbR2koEBGi(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private lfXX0hXJiENbR2koEBGi(lfXX0hXJiENbR2koEBGi original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void kWUXQXfW3y2(out global::System.Collections.Generic.IReadOnlyList<c2coImXJvwEghB4hbjMJ> Entries, out global::System.Collections.Generic.IReadOnlyList<string> Diagnostics)
	{
		//IL_003d: Expected I8, but got O
		//IL_0064: Expected I8, but got O
		int num = 2;
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
					Diagnostics = default;
					Entries = default;
					return;
				case 1:
					Diagnostics = default;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
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
				Entries = default;
				num2 = 4;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
				{
					num2 = 1;
				}
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
						switch (num2)
						{
						case 990:
							goto end_IL_0012;
						case 9:
							return;
						}
						goto end_IL_000e;
					case 2:
						goto end_IL_000e;
					case 1:
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						end_IL_0012:
						break;
					}
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
	internal static bool wnKuENZdICuW8V7kg5ig()
	{
		return Ljjx3mZdAvw7V8b4aOu7 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static lfXX0hXJiENbR2koEBGi BsVnydZdBFXBwOfl2CBc()
	{
		return (lfXX0hXJiENbR2koEBGi)Ljjx3mZdAvw7V8b4aOu7;
	}
}

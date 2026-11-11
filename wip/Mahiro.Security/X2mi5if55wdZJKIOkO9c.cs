using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace sS8xkjf567jgr9GZ44oO;

public sealed class X2mi5if55wdZJKIOkO9c
{
	[CompilerGenerated]
	private long _UserId_k__BackingField;

	[CompilerGenerated]
	private string _Username_k__BackingField;

	[CompilerGenerated]
	private int _ClaimCount_k__BackingField;

	[CompilerGenerated]
	private int _ChargeCount_k__BackingField;

	[CompilerGenerated]
	private int _Rank_k__BackingField;

	internal static object IMrTrZZigDMhbhZZQrra;

	[JsonPropertyName("userId")]
	public long UserId
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
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_UserId_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
						{
							num2 = 4;
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

	[JsonPropertyName("username")]
	public string Username
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Username_k__BackingField;
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
						_Username_k__BackingField = value;
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
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

	[JsonPropertyName("claimCount")]
	public int ClaimCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ClaimCount_k__BackingField;
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
						_ClaimCount_k__BackingField = value;
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
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

	[JsonPropertyName("chargeCount")]
	public int ChargeCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ChargeCount_k__BackingField;
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
					_ChargeCount_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
					{
						num2 = 3;
					}
				}
			}
		}
	}

	[JsonIgnore]
	public int Count
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ClaimCount + ChargeCount;
		}
	}

	[JsonIgnore]
	public string DisplayCount
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			int count = default(int);
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
						count = Count;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num2 = 4;
						}
						continue;
					case 0:
						break;
					}
					goto IL_0057;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0057;
					IL_0057:
					return (count).ToString();
				}
			}
		}
	}

	[JsonIgnore]
	public int Rank
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Rank_k__BackingField;
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
						_Rank_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
						{
							num2 = 1;
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

	[MethodImpl((MethodImplOptions)8)]
	public X2mi5if55wdZJKIOkO9c()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
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
						if (num2 == 9)
						{
							return;
						}
						goto end_IL_0012;
					case 1:
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						break;
					case 0:
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
						{
							num3 = 2;
						}
						continue;
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool fdrxuCZilULJAbXbcJCy()
	{
		return IMrTrZZigDMhbhZZQrra == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static X2mi5if55wdZJKIOkO9c S3KHcdZid0REfJbWJwJi()
	{
		return (X2mi5if55wdZJKIOkO9c)IMrTrZZigDMhbhZZQrra;
	}
}

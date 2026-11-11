using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace xAceLqXWMytQDox0p5bJ;

internal sealed class HTA2r6XWNKDt09pf0WBJ : IEquatable<HTA2r6XWNKDt09pf0WBJ>
{
	[CompilerGenerated]
	private int _ProcessId_k__BackingField;

	[CompilerGenerated]
	private global::System.DateTime _StartTimeUtc_k__BackingField;

	internal static object MqlbNmZlF7nNdo0gyeqh;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(HTA2r6XWNKDt09pf0WBJ).TypeHandle);
		}
	}

	public int ProcessId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ProcessId_k__BackingField;
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
					_ProcessId_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
					{
						num2 = 6;
					}
				}
			}
		}
	}

	public global::System.DateTime StartTimeUtc
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _StartTimeUtc_k__BackingField;
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
						_StartTimeUtc_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
						{
							num2 = 4;
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
	public HTA2r6XWNKDt09pf0WBJ(int ProcessId, global::System.DateTime StartTimeUtc)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_ProcessId_k__BackingField = ProcessId;
		_StartTimeUtc_k__BackingField = StartTimeUtc;
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
	private bool yLxXWpv9UX2(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(HTA2r6XWNKDt09pf0WBJ? left, HTA2r6XWNKDt09pf0WBJ? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(HTA2r6XWNKDt09pf0WBJ? left, HTA2r6XWNKDt09pf0WBJ? right)
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
					goto case 2;
				case 1:
					if (left != null)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num2 = 2;
						}
						break;
					}
					return false;
				case 2:
					if (left != right)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
						{
							num2 = 2;
						}
						break;
					}
					return true;
				case 0:
					return ((HTA2r6XWNKDt09pf0WBJ)left).Equals((HTA2r6XWNKDt09pf0WBJ?)right);
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
		return (EqualityContract * -1521134295 + _ProcessId_k__BackingField) * -1521134295 + _StartTimeUtc_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as HTA2r6XWNKDt09pf0WBJ);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(HTA2r6XWNKDt09pf0WBJ? other)
	{
		int num = 5;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public HTA2r6XWNKDt09pf0WBJ S7dXWuXbAR8()
	{
		return (HTA2r6XWNKDt09pf0WBJ)new HTA2r6XWNKDt09pf0WBJ(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private HTA2r6XWNKDt09pf0WBJ(HTA2r6XWNKDt09pf0WBJ original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void SVYXWayhTTR(out int ProcessId, out global::System.DateTime StartTimeUtc)
	{
		ProcessId = default;
		StartTimeUtc = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 0:
						return;
					case 1:
						break;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
						{
							num3 = 7;
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
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool bmMeQ4Zls8eDjgKyY3hM()
	{
		return MqlbNmZlF7nNdo0gyeqh == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static HTA2r6XWNKDt09pf0WBJ RicnfLZlTF2jx9mIboCR()
	{
		return (HTA2r6XWNKDt09pf0WBJ)MqlbNmZlF7nNdo0gyeqh;
	}
}

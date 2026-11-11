using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using qUVWohfFWy6g8p9LphlU;

namespace mSDIDW1LdgKLMSN7TMq;

internal sealed class hEfV2a1fvrAmFo59pgq : IEquatable<hEfV2a1fvrAmFo59pgq>
{
	[CompilerGenerated]
	private ehKrWCfFyUBmIViVuUtd _State_k__BackingField;

	[CompilerGenerated]
	private int? _ExitCode_k__BackingField;

	[CompilerGenerated]
	private string _Detail_k__BackingField;

	[CompilerGenerated]
	private DateTimeOffset _ChangedAt_k__BackingField;

	private static object ydEuaUZU6V9r057kb8Yl;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(hEfV2a1fvrAmFo59pgq).TypeHandle);
		}
	}

	public ehKrWCfFyUBmIViVuUtd State
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _State_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_State_k__BackingField = value;
		}
	}

	public int? ExitCode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ExitCode_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_ExitCode_k__BackingField = value;
		}
	}

	public string Detail
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Detail_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Detail_k__BackingField = value;
		}
	}

	public DateTimeOffset ChangedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return _ChangedAt_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_ChangedAt_k__BackingField = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public hEfV2a1fvrAmFo59pgq(ehKrWCfFyUBmIViVuUtd State, int? ExitCode, string Detail, DateTimeOffset ChangedAt)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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
	private bool WTE1jXfSqT(StringBuilder builder)
	{
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						(builder).Append(", Detail = ");
						num3 = 6;
						continue;
					case 3:
						(builder).Append(((object)State/*cast due to .constrained prefix*/).ToString());
						num3 = 8;
						continue;
					case 4:
						(builder).Append(((object)ExitCode/*cast due to .constrained prefix*/).ToString());
						num = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num = 10;
						}
						break;
					case 7:
						return true;
					case 6:
						(builder).Append(Detail);
						num = 5;
						break;
					case 5:
						(builder).Append(", ChangedAt = ");
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 2;
						}
						continue;
					case 8:
						(builder).Append(", ExitCode = ");
						num3 = 4;
						continue;
					case 0:
						(builder).Append("State = ");
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num3 = 15;
						}
						continue;
					case 1:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							num3 = 8;
						}
						continue;
					case 2:
						(builder).Append(((object)ChangedAt/*cast due to .constrained prefix*/).ToString());
						num3 = 7;
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
	public static bool operator !=(hEfV2a1fvrAmFo59pgq? left, hEfV2a1fvrAmFo59pgq? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(hEfV2a1fvrAmFo59pgq? left, hEfV2a1fvrAmFo59pgq? right)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ehKrWCfFyUBmIViVuUtd>.Default.GetHashCode(_State_k__BackingField)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(_ExitCode_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Detail_k__BackingField)) * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(_ChangedAt_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as hEfV2a1fvrAmFo59pgq);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(hEfV2a1fvrAmFo59pgq? other)
	{
		int num = 7;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public hEfV2a1fvrAmFo59pgq fqI1ZvTIdx()
	{
		return (hEfV2a1fvrAmFo59pgq)new hEfV2a1fvrAmFo59pgq(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private hEfV2a1fvrAmFo59pgq(hEfV2a1fvrAmFo59pgq original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void qky19aKHfK(out ehKrWCfFyUBmIViVuUtd State, out int? ExitCode, out string Detail, out DateTimeOffset ChangedAt)
	{
		State = default(ehKrWCfFyUBmIViVuUtd);
		ExitCode = default(int?);
		Detail = default(string);
		ChangedAt = default(DateTimeOffset);
		ExitCode = this.ExitCode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool poP9XlZURPX3ZAJsu2H4()
	{
		return ydEuaUZU6V9r057kb8Yl == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static hEfV2a1fvrAmFo59pgq rTkC4cZUwyqgSrxDB4VO()
	{
		return (hEfV2a1fvrAmFo59pgq)ydEuaUZU6V9r057kb8Yl;
	}
}

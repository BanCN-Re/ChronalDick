using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace b61SBNfMPmhr8rBaHFsX;

internal sealed class nWmdYYfMehOhwJjICbaM : IEquatable<nWmdYYfMehOhwJjICbaM>
{
	[CompilerGenerated]
	private uint _UserId_k__BackingField;

	[CompilerGenerated]
	private string _UserName_k__BackingField;

	[CompilerGenerated]
	private string _Urs_k__BackingField;

	private static object Yn5dIY9k2Lxhs4MZaTuS;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(nWmdYYfMehOhwJjICbaM).TypeHandle);
		}
	}

	[JsonPropertyName("user_id")]
	public uint UserId
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

	[JsonPropertyName("user_name")]
	public string UserName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _UserName_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_UserName_k__BackingField = value;
		}
	}

	[JsonPropertyName("urs")]
	public string Urs
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Urs_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Urs_k__BackingField = value;
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
	private bool pfBfMxA9vfc(StringBuilder builder)
	{
		int num = 3;
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
						case 994:
							goto end_IL_0010;
						case 13:
							return true;
						}
						goto end_IL_000c;
					case 6:
						goto end_IL_000c;
					case 1:
						(builder).Append(", Urs = ");
						num3 = 6;
						continue;
					case 2:
						(builder).Append("UserId = ");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
						{
							num3 = 2;
						}
						continue;
					case 0:
						(builder).Append(((object)UserId/*cast due to .constrained prefix*/).ToString());
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
						{
							num3 = 5;
						}
						continue;
					case 5:
						(builder).Append(", UserName = ");
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
						{
							num3 = 9;
						}
						continue;
					case 4:
						{
							(builder).Append(UserName);
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num3 = 1;
							}
							continue;
						}
						end_IL_0010:
						break;
					}
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			(builder).Append(Urs);
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(nWmdYYfMehOhwJjICbaM? left, nWmdYYfMehOhwJjICbaM? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(nWmdYYfMehOhwJjICbaM? left, nWmdYYfMehOhwJjICbaM? right)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(_UserId_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_UserName_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Urs_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as nWmdYYfMehOhwJjICbaM);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(nWmdYYfMehOhwJjICbaM? other)
	{
		int num = 5;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public nWmdYYfMehOhwJjICbaM SJlfMFnBmCy()
	{
		return (nWmdYYfMehOhwJjICbaM)new nWmdYYfMehOhwJjICbaM(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[SetsRequiredMembers]
	private nWmdYYfMehOhwJjICbaM(nWmdYYfMehOhwJjICbaM original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	public nWmdYYfMehOhwJjICbaM()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool fNLqGd9kqVdNCjfHIKbZ()
	{
		return Yn5dIY9k2Lxhs4MZaTuS == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nWmdYYfMehOhwJjICbaM qcgCyA9kGTUgJOyGQHPp()
	{
		return (nWmdYYfMehOhwJjICbaM)Yn5dIY9k2Lxhs4MZaTuS;
	}
}

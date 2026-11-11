using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using EwWgaBfa4W9cw78uxYKL;
using fDAldojjppXrctUVYOJn;

namespace ROZe5Gf1WgRr9IZ64gbr;

public sealed class wjHCLDf1ydVEraHow39U : IEquatable<wjHCLDf1ydVEraHow39U>
{
	[CompilerGenerated]
	private string _Id_k__BackingField;

	[CompilerGenerated]
	private string _Name_k__BackingField;

	[CompilerGenerated]
	private string _BriefSummary_k__BackingField;

	[CompilerGenerated]
	private string _OnlineCount_k__BackingField;

	[CompilerGenerated]
	private string _Version_k__BackingField;

	[CompilerGenerated]
	private string _TitleImageUrl_k__BackingField;

	[CompilerGenerated]
	private global::System.Collections.Generic.IReadOnlyList<cVOOWvfaCOSSV88yDpW5> _MinecraftVersions_k__BackingField;

	private static object CWypTC9S7Dlx9y3IoCdH;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(wjHCLDf1ydVEraHow39U).TypeHandle);
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

	public string BriefSummary
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _BriefSummary_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_BriefSummary_k__BackingField = value;
		}
	}

	public string OnlineCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _OnlineCount_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_OnlineCount_k__BackingField = value;
		}
	}

	public string Version
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Version_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Version_k__BackingField = value;
		}
	}

	public string TitleImageUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _TitleImageUrl_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_TitleImageUrl_k__BackingField = value;
		}
	}

	public global::System.Collections.Generic.IReadOnlyList<cVOOWvfaCOSSV88yDpW5> MinecraftVersions
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _MinecraftVersions_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_MinecraftVersions_k__BackingField = value;
		}
	}

	public bool SupportsBedrock
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			global::System.Collections.Generic.IEnumerator<cVOOWvfaCOSSV88yDpW5> enumerator = default(global::System.Collections.Generic.IEnumerator<cVOOWvfaCOSSV88yDpW5>);
			int num4 = default(int);
			bool result = default(bool);
			int num6 = default(int);
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
						goto case 1;
					case 2:
						enumerator = ((global::System.Collections.Generic.IEnumerable<cVOOWvfaCOSSV88yDpW5>)MinecraftVersions).GetEnumerator();
						num2 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						try
						{
							while (true)
							{
								int num3;
								if (!(enumerator).MoveNext())
								{
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
									{
										num3 = 6;
									}
									goto IL_0082;
								}
								goto IL_0117;
								IL_0082:
								switch (num3)
								{
								case 2:
									goto IL_00cb;
								case 0:
								case 4:
									continue;
								case 3:
									goto IL_0117;
								case 1:
									goto end_IL_00e7;
								}
								if (num4 != 12)
								{
									if (num4 == 992)
									{
										goto IL_007e;
									}
									goto IL_00cb;
								}
								return result;
								IL_00cb:
								result = true;
								num4 = 12;
								goto IL_007e;
								IL_0117:
								if (!enumerator.Current.IsBedrock)
								{
									num3 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
									{
										num3 = 0;
									}
									goto IL_0082;
								}
								goto IL_00cb;
								IL_007e:
								num3 = num4;
								goto IL_0082;
								continue;
								end_IL_00e7:
								break;
							}
						}
						finally
						{
							int num5;
							if (enumerator == null)
							{
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
								{
									num5 = 0;
								}
								goto IL_0184;
							}
							goto IL_01cc;
							IL_0184:
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 990)
									{
										goto IL_0180;
									}
									goto end_IL_0184;
								case 0:
									goto end_IL_0184;
								case 2:
									break;
								case 1:
									goto end_IL_0184;
								}
								goto IL_01cc;
								IL_0180:
								num5 = num6;
								continue;
								end_IL_0184:
								break;
							}
							goto end_IL_014c;
							IL_01cc:
							(enumerator).Dispose();
							num5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
							{
								num5 = 7;
							}
							goto IL_0184;
							end_IL_014c:;
						}
						break;
					case 0:
						break;
					}
					return false;
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public wjHCLDf1ydVEraHow39U(string Id, string Name, string BriefSummary, string OnlineCount, string Version, string TitleImageUrl, global::System.Collections.Generic.IReadOnlyList<cVOOWvfaCOSSV88yDpW5> MinecraftVersions)
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
	private bool h5Uf1JQOmXY(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(wjHCLDf1ydVEraHow39U? left, wjHCLDf1ydVEraHow39U? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(wjHCLDf1ydVEraHow39U? left, wjHCLDf1ydVEraHow39U? right)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Id_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Name_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_BriefSummary_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_OnlineCount_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Version_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_TitleImageUrl_k__BackingField)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<cVOOWvfaCOSSV88yDpW5>>.Default.GetHashCode(_MinecraftVersions_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as wjHCLDf1ydVEraHow39U);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(wjHCLDf1ydVEraHow39U? other)
	{
		int num = 11;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public wjHCLDf1ydVEraHow39U mnXf1QiXpPc()
	{
		return (wjHCLDf1ydVEraHow39U)new wjHCLDf1ydVEraHow39U(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private wjHCLDf1ydVEraHow39U(wjHCLDf1ydVEraHow39U original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void wa7f1Ct00uQ(out string Id, out string Name, out string BriefSummary, out string OnlineCount, out string Version, out string TitleImageUrl, out global::System.Collections.Generic.IReadOnlyList<cVOOWvfaCOSSV88yDpW5> MinecraftVersions)
	{
		Id = default(string);
		Name = default(string);
		BriefSummary = default(string);
		OnlineCount = default(string);
		Version = default(string);
		TitleImageUrl = default(string);
		MinecraftVersions = default(global::System.Collections.Generic.IReadOnlyList<cVOOWvfaCOSSV88yDpW5>);
		//IL_0008: Expected I8, but got O
Name = this.Name;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HMwp7G9SAtwuf5OHxbKZ()
	{
		return CWypTC9S7Dlx9y3IoCdH == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static wjHCLDf1ydVEraHow39U wNfDtj9SIHxFBVVgJXdn()
	{
		return (wjHCLDf1ydVEraHow39U)CWypTC9S7Dlx9y3IoCdH;
	}
}

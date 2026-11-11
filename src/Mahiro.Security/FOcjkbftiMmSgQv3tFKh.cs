using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace njA7TyftnNbfUa50eBbM;

public sealed class FOcjkbftiMmSgQv3tFKh
{
	internal static object pRH9TvZqCpg1nqQvgUnN;

	[JsonPropertyName("id")]
	[field: CompilerGenerated]
	public long Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("actor")]
	[field: CompilerGenerated]
	public string? Actor
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("action")]
	[field: CompilerGenerated]
	public string Action
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("targetType")]
	[field: CompilerGenerated]
	public string? TargetType
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("targetId")]
	[field: CompilerGenerated]
	public long? TargetId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("detail")]
	[field: CompilerGenerated]
	public JsonElement Detail
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("createdAt")]
	[field: CompilerGenerated]
	public global::System.DateTime CreatedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public string TargetText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<long?>(TargetId);
			return null;
		}
	}

	[JsonIgnore]
	public unsafe string DetailText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Invalid comparison between Unknown and I4
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			JsonValueKind val = default(JsonValueKind);
			JsonElement detail = default(JsonElement);
			bool flag = default(bool);
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
							if (num2 != 17)
							{
								if (num2 == 998)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							return "{}";
						case 4:
							if ((int)val == 7)
							{
								num3 = 7;
								continue;
							}
							goto case 6;
						case 3:
							if ((int)val == 0)
							{
								num3 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto case 4;
						case 1:
							detail = Detail;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num3 = 9;
							}
							continue;
						case 5:
						case 9:
							if (flag)
							{
								break;
							}
							goto case 10;
						case 8:
							return ((object)(detail)/*cast due to .constrained prefix*/).ToString();
						case 0:
							val = (detail).ValueKind;
							num3 = 3;
							continue;
						case 10:
							detail = Detail;
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
							{
								num3 = 13;
							}
							continue;
						case 6:
							flag = false;
							num3 = 9;
							continue;
						case 2:
						case 7:
							flag = true;
							num3 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								num3 = 5;
							}
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
				num = 17;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
				{
					num = 2;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public FOcjkbftiMmSgQv3tFKh()
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
	internal static bool vF6OEtZq4HI7vGFDZaS9()
	{
		return pRH9TvZqCpg1nqQvgUnN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static FOcjkbftiMmSgQv3tFKh MXQoY9Zqhuc81nZITXnS()
	{
		return (FOcjkbftiMmSgQv3tFKh)pRH9TvZqCpg1nqQvgUnN;
	}
}

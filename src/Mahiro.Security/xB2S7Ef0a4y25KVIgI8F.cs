using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace AHCHY0f012HXIPgw0yYN;

public sealed class xB2S7Ef0a4y25KVIgI8F : IEquatable<xB2S7Ef0a4y25KVIgI8F>
{
	[CompilerGenerated]
	private Guid _Id_k__BackingField;

	[CompilerGenerated]
	private IPEndPoint _LocalEndpoint_k__BackingField;

	[CompilerGenerated]
	private string _LocalAddressText_k__BackingField;

	[CompilerGenerated]
	private string? _LanAddressText_k__BackingField;

	[CompilerGenerated]
	private string _RemoteAddressText_k__BackingField;

	[CompilerGenerated]
	private int _FrontendProtocol_k__BackingField;

	[CompilerGenerated]
	private int _BackendProtocol_k__BackingField;

	[CompilerGenerated]
	private DateTimeOffset _StartedAt_k__BackingField;

	internal static object pgtN8fZp6WSM3SxuwPpv;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(xB2S7Ef0a4y25KVIgI8F).TypeHandle);
		}
	}

	public Guid Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return _Id_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_Id_k__BackingField = value;
		}
	}

	public IPEndPoint LocalEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _LocalEndpoint_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_LocalEndpoint_k__BackingField = value;
		}
	}

	public string LocalAddressText
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _LocalAddressText_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_LocalAddressText_k__BackingField = value;
		}
	}

	public string? LanAddressText
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _LanAddressText_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_LanAddressText_k__BackingField = value;
		}
	}

	public string RemoteAddressText
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _RemoteAddressText_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_RemoteAddressText_k__BackingField = value;
		}
	}

	public int FrontendProtocol
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _FrontendProtocol_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_FrontendProtocol_k__BackingField = value;
		}
	}

	public int BackendProtocol
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _BackendProtocol_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_BackendProtocol_k__BackingField = value;
		}
	}

	public DateTimeOffset StartedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return _StartedAt_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_StartedAt_k__BackingField = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public xB2S7Ef0a4y25KVIgI8F(Guid Id, IPEndPoint LocalEndpoint, string LocalAddressText, string? LanAddressText, string RemoteAddressText, int FrontendProtocol, int BackendProtocol, DateTimeOffset StartedAt)
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
	private bool MU9f033vyTS(StringBuilder builder)
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		int num = 7;
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
						if (num2 != 23)
						{
							if (num2 == 1004)
							{
								goto end_IL_0010;
							}
							goto case 15;
						}
						(builder).Append(LocalEndpoint);
						num3 = 8;
						continue;
					case 10:
						(builder).Append(((object)BackendProtocol/*cast due to .constrained prefix*/).ToString());
						num3 = 14;
						continue;
					case 5:
						(builder).Append(LocalAddressText);
						num3 = 4;
						continue;
					case 16:
						(builder).Append(", BackendProtocol = ");
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num3 = 12;
						}
						continue;
					case 8:
						(builder).Append(", LocalAddressText = ");
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
						{
							num3 = 5;
						}
						continue;
					case 9:
						(builder).Append(((object)StartedAt/*cast due to .constrained prefix*/).ToString());
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
						{
							num3 = 6;
						}
						continue;
					case 13:
						(builder).Append(", FrontendProtocol = ");
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						(builder).Append(", LanAddressText = ");
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							num3 = 19;
						}
						continue;
					case 3:
						(builder).Append(LanAddressText);
						num3 = 12;
						continue;
					case 0:
						(builder).Append(((object)FrontendProtocol/*cast due to .constrained prefix*/).ToString());
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
						{
							num3 = 16;
						}
						continue;
					case 2:
						(builder).Append(RemoteAddressText);
						num = 13;
						break;
					case 11:
						(builder).Append(((object)Id/*cast due to .constrained prefix*/).ToString());
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num3 = 1;
						}
						continue;
					case 7:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 6;
						continue;
					case 14:
						(builder).Append(", StartedAt = ");
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
						{
							num3 = 7;
						}
						continue;
					case 1:
						(builder).Append(", LocalEndpoint = ");
						num = 23;
						break;
					case 6:
						(builder).Append("Id = ");
						num = 11;
						break;
					case 15:
						return true;
					case 12:
						(builder).Append(", RemoteAddressText = ");
						num3 = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
						{
							num3 = 2;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(xB2S7Ef0a4y25KVIgI8F? left, xB2S7Ef0a4y25KVIgI8F? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(xB2S7Ef0a4y25KVIgI8F? left, xB2S7Ef0a4y25KVIgI8F? right)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		return (((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(_Id_k__BackingField)) * -1521134295 + EqualityComparer<IPEndPoint>.Default.GetHashCode(_LocalEndpoint_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_LocalAddressText_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_LanAddressText_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_RemoteAddressText_k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_FrontendProtocol_k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(_BackendProtocol_k__BackingField)) * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(_StartedAt_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as xB2S7Ef0a4y25KVIgI8F);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(xB2S7Ef0a4y25KVIgI8F? other)
	{
		int num = 10;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public xB2S7Ef0a4y25KVIgI8F VAjf0vGXlAe()
	{
		return (xB2S7Ef0a4y25KVIgI8F)new xB2S7Ef0a4y25KVIgI8F(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private xB2S7Ef0a4y25KVIgI8F(xB2S7Ef0a4y25KVIgI8F original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void GSOf0EhU092(out Guid Id, out IPEndPoint LocalEndpoint, out string LocalAddressText, out string? LanAddressText, out string RemoteAddressText, out int FrontendProtocol, out int BackendProtocol, out DateTimeOffset StartedAt)
	{
		Id = default(Guid);
		LocalEndpoint = default(IPEndPoint);
		LocalAddressText = default(string);
		LanAddressText = default(string?);
		RemoteAddressText = default(string);
		FrontendProtocol = default(int);
		BackendProtocol = default(int);
		StartedAt = default(DateTimeOffset);
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Id = this.Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SfU20IZpRwk0ggLgcVso()
	{
		return pgtN8fZp6WSM3SxuwPpv == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static xB2S7Ef0a4y25KVIgI8F OUl8gHZpwpoHvpbOYm5G()
	{
		return (xB2S7Ef0a4y25KVIgI8F)pgtN8fZp6WSM3SxuwPpv;
	}
}

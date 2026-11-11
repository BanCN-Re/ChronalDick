using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace D7xJjNfwCFnMZjlFZPVf;

public sealed class tZ40E3fwQFywClnXCq1A_1<xS0CgdjfZQ94LVxNcG2Y>
{
	private static object? SbnOCo9XUpIHPtnd5kGd;
	private int _Status_k__BackingField;
	private xS0CgdjfZQ94LVxNcG2Y? _Data_k__BackingField;
	private JsonElement _RawData_k__BackingField;

	[JsonPropertyName("status")]
	public int Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return this._Status_k__BackingField;
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
						this._Status_k__BackingField = value;
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
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

	[JsonPropertyName("data")]
	public xS0CgdjfZQ94LVxNcG2Y? Data
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return this._Data_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			this._Data_k__BackingField = value;
		}
	}

	[JsonIgnore]
	public JsonElement RawData
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return this._RawData_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						this._RawData_k__BackingField = value;
						num2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
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

	[JsonIgnore]
	public bool IsSuccessStatusCode
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			int status = default(int);
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
						goto case 0;
					case 0:
						return status <= 299;
					case 3:
						return false;
					case 2:
						status = Status;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						if (status < 200)
						{
							num2 = 3;
							break;
						}
						goto case 0;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	[JsonIgnore]
	public string? ErrorMessage
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Invalid comparison between Unknown and I4
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Invalid comparison between Unknown and I4
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			int num = 5;
			JsonElement rawData = default(JsonElement);
			JsonElement val = default(JsonElement);
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
							if (num2 != 14)
							{
								if (num2 == 995)
								{
									goto end_IL_0010;
								}
								goto case 1;
							}
							break;
						case 2:
							if (!(rawData).TryGetProperty("message", out val))
							{
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 6;
						case 6:
							if ((int)(val).ValueKind != 3)
							{
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							return (val).GetString();
						case 3:
							rawData = RawData;
							num3 = 2;
							continue;
						case 5:
							if (IsSuccessStatusCode)
							{
								goto end_IL_000c;
							}
							goto case 7;
						case 0:
							if ((int)(rawData).ValueKind == 1)
							{
								num3 = 3;
								continue;
							}
							break;
						case 7:
							rawData = RawData;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
						case 4:
							return null;
						}
						return null;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				num = 14;
			}
		}
	}

	[JsonIgnore]
	public string? ErrorCode
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Invalid comparison between Unknown and I4
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Invalid comparison between Unknown and I4
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			JsonElement rawData = default(JsonElement);
			JsonElement val = default(JsonElement);
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
							if (num2 != 12)
							{
								if (num2 == 993)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							rawData = RawData;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num3 = 8;
							}
							continue;
						case 1:
							if ((int)(rawData).ValueKind == 1)
							{
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
								{
									num3 = 5;
								}
								continue;
							}
							goto IL_00f8;
						case 4:
							if ((int)(val).ValueKind != 3)
							{
								num3 = 2;
								continue;
							}
							return (val).GetString();
						case 5:
							rawData = RawData;
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return null;
						case 3:
							if (!IsSuccessStatusCode)
							{
								break;
							}
							goto IL_00f8;
						case 0:
							{
								if ((rawData).TryGetProperty("code", out val))
								{
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto case 2;
							}
							IL_00f8:
							return null;
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
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
				{
					num = 12;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public tZ40E3fwQFywClnXCq1A_1()
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
	internal static bool xUO6WD9Xr5PbOkWOU6b4()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object? e0Sv2J9XoWnxqM1INDF6()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}
}

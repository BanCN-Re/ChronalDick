using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace A9qCRxfTFcpTmOPevGxU;

public sealed class wCXHhVfTxU0EHc20TDtH : IEquatable<wCXHhVfTxU0EHc20TDtH>
{
	[CompilerGenerated]
	private IPEndPoint _ClientEndpoint_k__BackingField;

	[CompilerGenerated]
	private IPEndPoint _ListenerEndpoint_k__BackingField;

	internal static object U37NRk9DYTdcX5HZZdkr;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(wCXHhVfTxU0EHc20TDtH).TypeHandle);
		}
	}

	public IPEndPoint ClientEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ClientEndpoint_k__BackingField;
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
					_ClientEndpoint_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
					{
						num2 = 4;
					}
				}
			}
		}
	}

	public IPEndPoint ListenerEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ListenerEndpoint_k__BackingField;
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
						_ListenerEndpoint_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
						{
							num2 = 3;
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
	public wCXHhVfTxU0EHc20TDtH(IPEndPoint ClientEndpoint, IPEndPoint ListenerEndpoint)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_ClientEndpoint_k__BackingField = ClientEndpoint;
		_ListenerEndpoint_k__BackingField = ListenerEndpoint;
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
	private bool xC6fTshWh6P(StringBuilder builder)
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						(builder).Append(ClientEndpoint);
						num3 = 2;
						continue;
					case 4:
						return true;
					case 3:
						(builder).Append(ListenerEndpoint);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num3 = 4;
						}
						continue;
					case 2:
						(builder).Append(", ListenerEndpoint = ");
						num3 = 3;
						continue;
					case 1:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						break;
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
			(builder).Append("ClientEndpoint = ");
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(wCXHhVfTxU0EHc20TDtH? left, wCXHhVfTxU0EHc20TDtH? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(wCXHhVfTxU0EHc20TDtH? left, wCXHhVfTxU0EHc20TDtH? right)
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
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 0:
					if (left != null)
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num2 = 6;
						}
						break;
					}
					return false;
				case 2:
					return ((wCXHhVfTxU0EHc20TDtH)left).Equals((wCXHhVfTxU0EHc20TDtH?)right);
				case 1:
					if (left == right)
					{
						return true;
					}
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
					{
						num2 = 0;
					}
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
		return (EqualityContract * -1521134295 + _ClientEndpoint_k__BackingField) * -1521134295 + _ListenerEndpoint_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as wCXHhVfTxU0EHc20TDtH);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(wCXHhVfTxU0EHc20TDtH? other)
	{
		int num = 3;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public wCXHhVfTxU0EHc20TDtH x80fTTGNfeo()
	{
		return (wCXHhVfTxU0EHc20TDtH)new wCXHhVfTxU0EHc20TDtH(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private wCXHhVfTxU0EHc20TDtH(wCXHhVfTxU0EHc20TDtH original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void aKKfTN3xE3c(out IPEndPoint ClientEndpoint, out IPEndPoint ListenerEndpoint)
	{
		//IL_0064: Expected I8, but got O
		//IL_003c: Expected I8, but got O
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 1:
					ClientEndpoint = (IPEndPoint)this.ClientEndpoint;
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					ClientEndpoint = default;
					ListenerEndpoint = default;
					return;
				case 0:
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
				ListenerEndpoint = (IPEndPoint)this.ListenerEndpoint;
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
				{
					num2 = 2;
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						continue;
					case 0:
						break;
					case 1:
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						return;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool k3k4BL9DSul1fZ3xE3mQ()
	{
		return U37NRk9DYTdcX5HZZdkr == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static wCXHhVfTxU0EHc20TDtH FEtHYX9DcnK9Gnq2oKry()
	{
		return (wCXHhVfTxU0EHc20TDtH)U37NRk9DYTdcX5HZZdkr;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace b7C8sgfNUlsIIZiFPiE3;

public sealed class I8UL5cfNhu2cgReqF3g8 : IEquatable<I8UL5cfNhu2cgReqF3g8>
{
	[CompilerGenerated]
	private long _ClientToServerBytes_k__BackingField;

	[CompilerGenerated]
	private long _ServerToClientBytes_k__BackingField;

	[CompilerGenerated]
	private long _ClientToServerPackets_k__BackingField;

	[CompilerGenerated]
	private long _ServerToClientPackets_k__BackingField;

	private static object BhmIad9DxnBQKJ9hSKeB;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(I8UL5cfNhu2cgReqF3g8).TypeHandle);
		}
	}

	public long ClientToServerBytes
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ClientToServerBytes_k__BackingField;
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
						_ClientToServerBytes_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
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

	public long ServerToClientBytes
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ServerToClientBytes_k__BackingField;
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
					_ServerToClientBytes_k__BackingField = value;
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public long ClientToServerPackets
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ClientToServerPackets_k__BackingField;
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
					_ClientToServerPackets_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	public long ServerToClientPackets
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ServerToClientPackets_k__BackingField;
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
					_ServerToClientPackets_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
					{
						num2 = 2;
					}
				}
			}
		}
	}

	public long TotalBytes
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ClientToServerBytes + ServerToClientBytes;
		}
	}

	public long TotalPackets
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ClientToServerPackets + ServerToClientPackets;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public I8UL5cfNhu2cgReqF3g8(long ClientToServerBytes, long ServerToClientBytes, long ClientToServerPackets, long ServerToClientPackets)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_ClientToServerBytes_k__BackingField = ClientToServerBytes;
		_ServerToClientBytes_k__BackingField = ServerToClientBytes;
		_ClientToServerPackets_k__BackingField = ClientToServerPackets;
		_ServerToClientPackets_k__BackingField = ServerToClientPackets;
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
	private bool oc4fNrRAxn5(StringBuilder builder)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(I8UL5cfNhu2cgReqF3g8? left, I8UL5cfNhu2cgReqF3g8? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(I8UL5cfNhu2cgReqF3g8? left, I8UL5cfNhu2cgReqF3g8? right)
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
					goto case 0;
				case 2:
					if (left == null)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 3:
					if (left != right)
					{
						num2 = 2;
						break;
					}
					return true;
				case 1:
					return ((I8UL5cfNhu2cgReqF3g8)left).Equals((I8UL5cfNhu2cgReqF3g8?)right);
				case 0:
					return false;
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
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as I8UL5cfNhu2cgReqF3g8);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(I8UL5cfNhu2cgReqF3g8? other)
	{
		_ = 4;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388;
		_ = 2;
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8;
		_ = 8;
		_ = _ClientToServerPackets_k__BackingField;
		_ = other._ClientToServerPackets_k__BackingField;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public I8UL5cfNhu2cgReqF3g8 uSOfNoRKtOO()
	{
		return (I8UL5cfNhu2cgReqF3g8)new I8UL5cfNhu2cgReqF3g8(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private I8UL5cfNhu2cgReqF3g8(I8UL5cfNhu2cgReqF3g8 original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void G5EfNmloii0(out long ClientToServerBytes, out long ServerToClientBytes, out long ClientToServerPackets, out long ServerToClientPackets)
	{
		ClientToServerBytes = default;
		ClientToServerPackets = default;
		ServerToClientBytes = default;
		ServerToClientPackets = default;
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
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
							goto case 2;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
					case 2:
						num = 1;
						break;
					case 1:
						num = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							num = 1;
						}
						break;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool E8gf099DF9OQd0Au8Hk6()
	{
		return BhmIad9DxnBQKJ9hSKeB == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static I8UL5cfNhu2cgReqF3g8 N4sf5W9DsKtPhdtEuqiR()
	{
		return (I8UL5cfNhu2cgReqF3g8)BhmIad9DxnBQKJ9hSKeB;
	}
}

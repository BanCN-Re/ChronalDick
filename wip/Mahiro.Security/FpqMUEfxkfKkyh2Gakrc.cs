using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace xysbBnfxVcX9hX2IYacd;

public sealed class FpqMUEfxkfKkyh2Gakrc : IEquatable<FpqMUEfxkfKkyh2Gakrc>
{
	[CompilerGenerated]
	private long _ClientToServerBytes_k__BackingField;

	[CompilerGenerated]
	private long _ServerToClientBytes_k__BackingField;

	[CompilerGenerated]
	private bool _LocalClientConnected_k__BackingField;

	[CompilerGenerated]
	private bool _UpstreamConnected_k__BackingField;

	internal static object x7NFAZ9jIYcAjZDVoN26;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(FpqMUEfxkfKkyh2Gakrc).TypeHandle);
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
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
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
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_ServerToClientBytes_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num2 = 3;
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

	public bool LocalClientConnected
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _LocalClientConnected_k__BackingField;
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
					_LocalClientConnected_k__BackingField = value;
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public bool UpstreamConnected
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _UpstreamConnected_k__BackingField;
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
					_UpstreamConnected_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
					{
						num2 = 5;
					}
				}
			}
		}
	}

	[field: CompilerGenerated]
	public static FpqMUEfxkfKkyh2Gakrc Empty
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public long TotalBytes
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return checked(ClientToServerBytes + ServerToClientBytes);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public FpqMUEfxkfKkyh2Gakrc(long ClientToServerBytes, long ServerToClientBytes, bool LocalClientConnected, bool UpstreamConnected)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_ClientToServerBytes_k__BackingField = ClientToServerBytes;
		_ServerToClientBytes_k__BackingField = ServerToClientBytes;
		_LocalClientConnected_k__BackingField = LocalClientConnected;
		_UpstreamConnected_k__BackingField = UpstreamConnected;
	}

	[MethodImpl((MethodImplOptions)8)]
	public FpqMUEfxkfKkyh2Gakrc t62fxYwFVbM()
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
						if (num2 == 10)
						{
							return this;
						}
						goto IL_0033;
					case 3:
						_ = "ServerToClientBytes";
						throw new global::System.Exception("Java 下行流量不能为负数");
					case 2:
						if (ClientToServerBytes >= 0)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 0;
					case 0:
						_ = "ClientToServerBytes";
						throw new global::System.Exception("Java 上行流量不能为负数");
					case 1:
						break;
					}
					goto IL_010f;
					IL_0033:
					if (num2 == 991)
					{
						break;
					}
					goto IL_010f;
					IL_010f:
					if (ServerToClientBytes >= 0)
					{
						goto end_IL_000c;
					}
					num3 = 10;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
					{
						num3 = 3;
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			_ = TotalBytes;
			num = 10;
		}
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
	private bool wXsfxSaAZD4(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(FpqMUEfxkfKkyh2Gakrc? left, FpqMUEfxkfKkyh2Gakrc? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(FpqMUEfxkfKkyh2Gakrc? left, FpqMUEfxkfKkyh2Gakrc? right)
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
					goto case 2;
				case 2:
					return ((FpqMUEfxkfKkyh2Gakrc)left).Equals((FpqMUEfxkfKkyh2Gakrc?)right);
				case 0:
					if (left == null)
					{
						return false;
					}
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					if (left == right)
					{
						return true;
					}
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
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
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as FpqMUEfxkfKkyh2Gakrc);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(FpqMUEfxkfKkyh2Gakrc? other)
	{
		_ = 15;
		(EqualityContract == other.EqualityContract);
		_ = 2;
		_ = _ServerToClientBytes_k__BackingField;
		_ = other._ServerToClientBytes_k__BackingField;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public FpqMUEfxkfKkyh2Gakrc udNfxcjwas1()
	{
		return (FpqMUEfxkfKkyh2Gakrc)new FpqMUEfxkfKkyh2Gakrc(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private FpqMUEfxkfKkyh2Gakrc(FpqMUEfxkfKkyh2Gakrc original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void ysafx0b58oV(out long ClientToServerBytes, out long ServerToClientBytes, out bool LocalClientConnected, out bool UpstreamConnected)
	{
		ClientToServerBytes = default;
		LocalClientConnected = default;
		ServerToClientBytes = default;
		UpstreamConnected = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 4;
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
								goto end_IL_0012;
							}
							goto case 4;
						}
						num = 3;
						break;
					case 3:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
						{
							num3 = 6;
						}
						continue;
					case 4:
						num = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num = 11;
						}
						break;
					case 2:
						return;
					case 1:
						_Empty_k__BackingField = (FpqMUEfxkfKkyh2Gakrc)new FpqMUEfxkfKkyh2Gakrc(0L, 0L, LocalClientConnected: false, UpstreamConnected: false);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
						{
							num3 = 2;
						}
						continue;
					case 0:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num3 = 1;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool V1UAF59jBu0Mge5dPX5k()
	{
		return x7NFAZ9jIYcAjZDVoN26 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static FpqMUEfxkfKkyh2Gakrc yVKUtg9jgqL0ME4IO8ry()
	{
		return (FpqMUEfxkfKkyh2Gakrc)x7NFAZ9jIYcAjZDVoN26;
	}
}

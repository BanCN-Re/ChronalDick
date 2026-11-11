using System;
using System.Net;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using iM65eRXiKVWZgs63pZCd;

namespace vwSH4QfyThQLohRaATPy;

internal sealed class PbsVqpfysxOZ9LNyUL1e : global::System.Exception
{
	internal static object ClNk9SZp3wLAn4lC2Eoa;

	[field: CompilerGenerated]
	internal IPEndPoint ClientEndPoint
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	internal byte[] Datagram
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	internal bool HasPendingDatagram
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Datagram.Length != 0;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal PbsVqpfysxOZ9LNyUL1e(IPEndPoint clientEndPoint, byte[] datagram)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_ = "Client started a new RakNet offline handshake";
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 990)
				{
					num = num2;
					break;
				}
				return;
			case 1:
				return;
			case 2:
				_ClientEndPoint_k__BackingField = clientEndPoint;
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
				{
					num = 7;
				}
				break;
			case 0:
				_Datagram_k__BackingField = (byte[])(object)(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(datagram).Clone();
				num = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
				{
					num = 1;
				}
				break;
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
							goto case 0;
						}
						return;
					case 2:
						break;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							num3 = 7;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num3 = 3;
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool vY3hyyZpv4ehymaxjKb7()
	{
		return ClNk9SZp3wLAn4lC2Eoa == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PbsVqpfysxOZ9LNyUL1e gGqUhDZpE6kl0JnMd8BZ()
	{
		return (PbsVqpfysxOZ9LNyUL1e)ClNk9SZp3wLAn4lC2Eoa;
	}
}

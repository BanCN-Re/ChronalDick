using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using I8kVvQmUGdEncAIoxaC;
using fDAldojjppXrctUVYOJn;

namespace Bq8RQiXJKPoYAokn45Ln;

internal class ELfn2xXJd7Ivm97I82xx
{
	private delegate uint gXn1bNLbla19ctR8dpvi([In] byte[] name, uint count);

	private delegate uint qAQC2TLbd0nu3I8d0SEW([In] byte[] name, uint count, uint pid, ulong created);

	internal static object auBE9NZdQMb15TtGWxCV;

	[MethodImpl((MethodImplOptions)8)]
	static T eleXJHr6HI7<T>(object name) where T : global::System.Delegate
	{
		return Marshal.GetDelegateForFunctionPointer<T>((global::System.IntPtr)rDf13emhypQ5FFQEmmM.pI3mIjtv0a(name));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void VIHXJtNvQbs(uint status)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("原生管理员委派失败：0x");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void f9uXJOJL4ZW(object name)
	{
		byte[] array = default(byte[]);
		VIHXJtNvQbs(eleXJHr6HI7<gXn1bNLbla19ctR8dpvi>("chronal_create_game_delegation")(array, (uint)array.Length));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void pKpXJ517OBd(object name, int pid, long created)
	{
		byte[] array = default(byte[]);
		VIHXJtNvQbs(eleXJHr6HI7<qAQC2TLbd0nu3I8d0SEW>("chronal_accept_game_delegation")(array, (uint)array.Length, checked((uint)pid), checked((ulong)created)));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int DaZXJ6oSJQO(object name, int debugPid)
	{
		byte[] array = default(byte[]);
		uint num = eleXJHr6HI7<gXn1bNLbla19ctR8dpvi>("chronal_game_delegation_peer")(array, (uint)array.Length);
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void iU6XJR9FBC5(object name)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					byte[] array = (System.Text.Encoding.UTF8).GetBytes((string)name);
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
					{
						num2 = 5;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 1:
							break;
						}
						eleXJHr6HI7<gXn1bNLbla19ctR8dpvi>("chronal_close_game_delegation")(array, (uint)array.Length);
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num2 = 0;
						}
					}
				}
				catch (global::System.Exception)
				{
					int num4 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 0:
							return;
						}
						if (num5 != 988)
						{
							return;
						}
						num4 = num5;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool dSEkk0ZdC69EwTkLONoN()
	{
		return auBE9NZdQMb15TtGWxCV == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ELfn2xXJd7Ivm97I82xx vFjMuSZd4jMLxCZeuxQu()
	{
		return (ELfn2xXJd7Ivm97I82xx)auBE9NZdQMb15TtGWxCV;
	}
}

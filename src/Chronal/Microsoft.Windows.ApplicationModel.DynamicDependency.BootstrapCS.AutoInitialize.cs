using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Microsoft.Windows.ApplicationModel.DynamicDependency.BootstrapCS;

internal class AutoInitialize
{
	private static AutoInitialize O5RPMTLv8GJ6HpMNClV9;

	internal static int Options
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return 8;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void AccessWindowsAppSDK()
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0097: Expected I4, but got O
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_00ab->IL0010: Incompatible stack types: I4 vs O
		//IL_00b6->IL0010: Incompatible stack types: I4 vs O
		//IL_0080->IL0010: Incompatible stack types: I4 vs O
		//IL_008b->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj4 = default(object);
		object obj6 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 1:
				{
					object obj3 = "";
					object obj5 = Options;
					obj6 = 0;
					int hresult;
					if (Bootstrap.TryInitialize(131074u, (string)obj3, (PackageVersion)obj4, (Bootstrap.InitializeOptions)(int)obj5, out hresult))
					{
						return;
					}
					obj6 = hresult;
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 != 0)
					{
						obj2 = 5;
					}
					break;
				}
				case 0:
					global::System.Environment.Exit((int)obj6);
					obj2 = 2;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a2042ba402cd4aaf989f075337c5eaf7 == 0)
					{
						obj2 = 2;
					}
					break;
				case 2:
					return;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public AutoInitialize()
	{
		//IL_004c: Expected I4, but got O
		//IL_0031->IL0043: Incompatible stack types: I4 vs O
		//IL_003c->IL0043: Incompatible stack types: I4 vs O
		object obj = 0;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b6e1b24306c5435497967d798ce571fb == 0)
		{
			obj = 2;
		}
		object obj2 = default(object);
		while (true)
		{
			switch ((int)obj)
			{
			case 0:
				return;
			}
			if ((nint)obj2 == 988)
			{
				obj = obj2;
				continue;
			}
			return;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lcIOHNLvyEG24sdWVR5Y()
	{
		return O5RPMTLv8GJ6HpMNClV9 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static AutoInitialize L1uhPxLvW5rWqRK2th8u()
	{
		return O5RPMTLv8GJ6HpMNClV9;
	}
}

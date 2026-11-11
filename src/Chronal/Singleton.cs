using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Microsoft.WindowsAppSDK.Runtime.Packages;

internal class Singleton
{
	internal const string PackageFamilyName = "MicrosoftCorporationII.WinAppRuntime.Singleton_8wekyb3d8bbwe";

	private static Singleton N9Ks7XL3zgGxy4wuZ1es;

	[MethodImpl((MethodImplOptions)8)]
	public Singleton()
	{
		//IL_004c: Expected I4, but got O
		//IL_0031->IL0043: Incompatible stack types: I4 vs O
		//IL_003c->IL0043: Incompatible stack types: I4 vs O
		object obj = 0;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6d6b99fc4578413f8bc3bdf9db0e7260 == 0)
		{
			obj = 4;
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
	internal static bool JCEThLLvbfLNxQCOvDre()
	{
		return N9Ks7XL3zgGxy4wuZ1es == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Singleton hDXMgLLvXlqQVfs8tNZy()
	{
		return N9Ks7XL3zgGxy4wuZ1es;
	}
}

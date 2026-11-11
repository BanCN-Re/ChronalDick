using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.Windows.ApplicationModel.DynamicDependency.BootstrapCS;
using qS8vkpL43FlTMgcj0rgs;

namespace Microsoft.Windows.ApplicationModel.WindowsAppRuntime.Common;

internal class AutoInitialize
{
	private static AutoInitialize t82cqrLvSeqxTJ58vWi3;

	[MethodImpl((MethodImplOptions)8)]
	[ModuleInitializer]
	internal static void InitializeWindowsAppSDK()
	{
		Microsoft.Windows.ApplicationModel.DynamicDependency.BootstrapCS.AutoInitialize.AccessWindowsAppSDK();
	}

	[MethodImpl((MethodImplOptions)8)]
	public AutoInitialize()
	{
		//IL_004c: Expected I4, but got O
		//IL_0031->IL0043: Incompatible stack types: I4 vs O
		//IL_003c->IL0043: Incompatible stack types: I4 vs O
		object obj = 5;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e3c72d365c184d8193f0594ab3fd4d1f == 0)
		{
			obj = 0;
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
	internal static bool iMX1P8Lvc6qV0QQCHoQI()
	{
		return t82cqrLvSeqxTJ58vWi3 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static AutoInitialize ImMCSILv0WmNsoNPap3A()
	{
		return t82cqrLvSeqxTJ58vWi3;
	}
}

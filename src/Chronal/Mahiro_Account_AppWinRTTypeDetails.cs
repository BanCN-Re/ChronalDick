using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ABI.Microsoft.UI.Xaml;
using ABI.Microsoft.UI.Xaml.Markup;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace WinRT.ChronalVtableClasses;

internal sealed class Mahiro_Account_AppWinRTTypeDetails : IWinRTExposedTypeDetails
{
	[MethodImpl((MethodImplOptions)8)]
	public unsafe System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry[] GetExposedInterfaces()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		return (System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry[])(object)new System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry[2]
		{
			new System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry
			{
				IID = IApplicationOverridesMethods.IID,
				Vtable = IApplicationOverridesMethods.AbiToProjectionVftablePtr
			},
			new System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry
			{
				IID = IXamlMetadataProviderMethods.IID,
				Vtable = IXamlMetadataProviderMethods.AbiToProjectionVftablePtr
			}
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	public Mahiro_Account_AppWinRTTypeDetails()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

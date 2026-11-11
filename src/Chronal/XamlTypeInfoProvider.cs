using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BdZQbJfN4H4AgIYemOL6;
using By1SFsLobKQOZCdh5qRg;
using CGTgWZfPLqikrZ4Zv8WL;
using CommunityToolkit.WinUI;
using CommunityToolkit.WinUI.Controls;
using CommunityToolkit.WinUI.Controls.SettingsControlsRns.CommunityToolkit_WinUI_Controls_SettingsControls_XamlTypeInfo;
using CommunityToolkit.WinUI.Media;
using D5dq98Zj0UIlWLL7BDu;
using EBJLMifNn8QeuhMRSx7U;
using EGjGpPfNQ5sRCSMK7KqW;
using IU7UTPfFQa3t5mwomQTu;
using Mahiro_Account.Features.McpStudio.Views;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Controls.Java;
using Mahiro_Account.UI.Controls.Toolbox;
using Mahiro_Account.UI.Shell;
using Mahiro_Account.Views.Pages;
using Mahiro_Account.Views.Pages.Bedrock;
using Mahiro_Account.Views.Pages.Java;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Composition;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.XamlTypeInfo;
using N9UVEvf6UHvBucn1bopm;
using P0graHf67FHLhLQyDEVV;
using P4nQc8LxjCxnxuINJP5;
using U4i16dfxBhWhZfMZrtVY;
using UchfG8fTzhAHMiok6Yk0;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization.NumberFormatting;
using Windows.UI;
using b7C8sgfNUlsIIZiFPiE3;
using bVyVYtfFgCItGPihJweI;
using c2D37HfsFbaPpJo3F98A;
using fZGimHf0suVRPkaXFQcr;
using kq2pipfTwPkE4qWLSUgF;
using pZg6QPfag7jmC8rKUG4i;
using qS8vkpL43FlTMgcj0rgs;
using qUVWohfFWy6g8p9LphlU;
using rEWmcPfNAhtZSJjsJvk3;
using sIIqaHfsvUMJoArTBa4b;
using uj1PrqjB4rcHFMlFGdp;

namespace Mahiro_Account.Chronal_XamlTypeInfo;

[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
[DebuggerNonUserCode]
internal class XamlTypeInfoProvider
{
	private Dictionary<string, IXamlType> _xamlTypeCacheByName;

	private Dictionary<global::System.Type, IXamlType> _xamlTypeCacheByType;

	private Dictionary<string, IXamlMember> _xamlMembers;

	private string[] _typeNameTable;

	private global::System.Type[] _typeTable;

	private List<IXamlMetadataProvider> _otherProviders;

	private List<IXamlMetadataProvider> OtherProviders
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			if (_otherProviders == null)
			{
				List<IXamlMetadataProvider> val = new List<IXamlMetadataProvider>();
				IXamlMetadataProvider val2 = (IXamlMetadataProvider)new XamlControlsXamlMetaDataProvider();
				val.Add(val2);
				val2 = (IXamlMetadataProvider)new XamlMetaDataProvider();
				val.Add(val2);
				_otherProviders = val;
			}
			return _otherProviders;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public IXamlType GetXamlTypeByType(global::System.Type type)
	{
		IXamlType val = default(IXamlType);
		lock (_xamlTypeCacheByType)
		{
			if (_xamlTypeCacheByType.TryGetValue(type, out val))
			{
				return val;
			}
			int num = LookupTypeIndexByType(type);
			if (num != -1)
			{
				val = CreateXamlType(num);
			}
			XamlUserType xamlUserType = val as XamlUserType;
			if (val == null || (xamlUserType != null && xamlUserType.IsReturnTypeStub && !xamlUserType.IsLocalType))
			{
				IXamlType val2 = CheckOtherMetadataProvidersForType(type);
				if (val2 != null && (val2.IsConstructible || val == null))
				{
					val = val2;
				}
			}
			if (val != null)
			{
				_xamlTypeCacheByName.Add(val.FullName, val);
				_xamlTypeCacheByType.Add(val.UnderlyingType, val);
			}
		}
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	public IXamlType GetXamlTypeByName(string typeName)
	{
		if (string.IsNullOrEmpty(typeName))
		{
			return null;
		}
		IXamlType val = default(IXamlType);
		lock (_xamlTypeCacheByType)
		{
			if (_xamlTypeCacheByName.TryGetValue(typeName, out val))
			{
				return val;
			}
			int num = LookupTypeIndexByName(typeName);
			if (num != -1)
			{
				val = CreateXamlType(num);
			}
			XamlUserType xamlUserType = val as XamlUserType;
			if (val == null || (xamlUserType != null && xamlUserType.IsReturnTypeStub && !xamlUserType.IsLocalType))
			{
				IXamlType val2 = CheckOtherMetadataProvidersForName(typeName);
				if (val2 != null && (val2.IsConstructible || val == null))
				{
					val = val2;
				}
			}
			if (val != null)
			{
				_xamlTypeCacheByName.Add(val.FullName, val);
				_xamlTypeCacheByType.Add(val.UnderlyingType, val);
			}
		}
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	public IXamlMember GetMemberByLongName(string longMemberName)
	{
		if (string.IsNullOrEmpty(longMemberName))
		{
			return null;
		}
		IXamlMember val = default(IXamlMember);
		lock (_xamlMembers)
		{
			if (_xamlMembers.TryGetValue(longMemberName, out val))
			{
				return val;
			}
			val = CreateXamlMember(longMemberName);
			if (val != null)
			{
				_xamlMembers.Add(longMemberName, val);
			}
		}
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void InitTypeTables()
	{
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_1129: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Unknown result type (might be due to invalid IL or missing references)
		//IL_1157: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1216: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_125e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_132c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1344: Unknown result type (might be due to invalid IL or missing references)
		//IL_135c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_138c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1404: Unknown result type (might be due to invalid IL or missing references)
		//IL_141c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1447: Unknown result type (might be due to invalid IL or missing references)
		//IL_145f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1507: Unknown result type (might be due to invalid IL or missing references)
		//IL_151f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1537: Unknown result type (might be due to invalid IL or missing references)
		//IL_154f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1567: Unknown result type (might be due to invalid IL or missing references)
		//IL_157f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1597: Unknown result type (might be due to invalid IL or missing references)
		//IL_15af: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15df: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1627: Unknown result type (might be due to invalid IL or missing references)
		//IL_163f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_166f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1687: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_170d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1725: Unknown result type (might be due to invalid IL or missing references)
		//IL_173d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1755: Unknown result type (might be due to invalid IL or missing references)
		//IL_1793: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1801: Unknown result type (might be due to invalid IL or missing references)
		//IL_1819: Unknown result type (might be due to invalid IL or missing references)
		//IL_1831: Unknown result type (might be due to invalid IL or missing references)
		//IL_1849: Unknown result type (might be due to invalid IL or missing references)
		//IL_1861: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879: Unknown result type (might be due to invalid IL or missing references)
		//IL_1891: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1917: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1947: Unknown result type (might be due to invalid IL or missing references)
		//IL_195f: Unknown result type (might be due to invalid IL or missing references)
		//IL_199d: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2008: Unknown result type (might be due to invalid IL or missing references)
		//IL_2023: Unknown result type (might be due to invalid IL or missing references)
		//IL_203e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2059: Unknown result type (might be due to invalid IL or missing references)
		//IL_2074: Unknown result type (might be due to invalid IL or missing references)
		//IL_208f: Unknown result type (might be due to invalid IL or missing references)
		//IL_20aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2116: Unknown result type (might be due to invalid IL or missing references)
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_214c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2167: Unknown result type (might be due to invalid IL or missing references)
		//IL_2182: Unknown result type (might be due to invalid IL or missing references)
		//IL_219d: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2209: Unknown result type (might be due to invalid IL or missing references)
		//IL_2224: Unknown result type (might be due to invalid IL or missing references)
		//IL_223f: Unknown result type (might be due to invalid IL or missing references)
		//IL_225a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2275: Unknown result type (might be due to invalid IL or missing references)
		//IL_2290: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2343: Unknown result type (might be due to invalid IL or missing references)
		//IL_235e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2379: Unknown result type (might be due to invalid IL or missing references)
		//IL_2394: Unknown result type (might be due to invalid IL or missing references)
		//IL_23af: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2400: Unknown result type (might be due to invalid IL or missing references)
		//IL_2447: Unknown result type (might be due to invalid IL or missing references)
		//IL_2478: Unknown result type (might be due to invalid IL or missing references)
		//IL_2493: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_252b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2546: Unknown result type (might be due to invalid IL or missing references)
		//IL_2561: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_260a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2625: Unknown result type (might be due to invalid IL or missing references)
		//IL_2640: Unknown result type (might be due to invalid IL or missing references)
		//IL_265b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2676: Unknown result type (might be due to invalid IL or missing references)
		//IL_2691: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_270e: Unknown result type (might be due to invalid IL or missing references)
		//IL_273f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2786: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2803: Unknown result type (might be due to invalid IL or missing references)
		//IL_281e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2839: Unknown result type (might be due to invalid IL or missing references)
		//IL_2854: Unknown result type (might be due to invalid IL or missing references)
		//IL_286f: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2918: Unknown result type (might be due to invalid IL or missing references)
		//IL_2933: Unknown result type (might be due to invalid IL or missing references)
		//IL_294e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2969: Unknown result type (might be due to invalid IL or missing references)
		//IL_2984: Unknown result type (might be due to invalid IL or missing references)
		//IL_299f: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad9: Unknown result type (might be due to invalid IL or missing references)
		_typeNameTable = new string[272];
		_typeNameTable[0] = "Microsoft.UI.Xaml.Controls.XamlControlsResources";
		_typeNameTable[1] = "Microsoft.UI.Xaml.ResourceDictionary";
		_typeNameTable[2] = "Object";
		_typeNameTable[3] = "Boolean";
		_typeNameTable[4] = "Mahiro_Account.UI.Shell.PageHeader";
		_typeNameTable[5] = "Microsoft.UI.Xaml.Controls.UserControl";
		_typeNameTable[6] = "String";
		_typeNameTable[7] = "Microsoft.UI.Xaml.Visibility";
		_typeNameTable[8] = "Microsoft.UI.Xaml.Controls.ProgressRing";
		_typeNameTable[9] = "Microsoft.UI.Xaml.Controls.Control";
		_typeNameTable[10] = "Double";
		_typeNameTable[11] = "Microsoft.UI.Xaml.Controls.ProgressRingTemplateSettings";
		_typeNameTable[12] = "Microsoft.UI.Xaml.DependencyObject";
		_typeNameTable[13] = "Mahiro_Account.UI.Controls.SmsVerificationView";
		_typeNameTable[14] = "Microsoft.UI.Xaml.Controls.InfoBar";
		_typeNameTable[15] = "Microsoft.UI.Xaml.Controls.InfoBarSeverity";
		_typeNameTable[16] = "System.Enum";
		_typeNameTable[17] = "System.ValueType";
		_typeNameTable[18] = "Microsoft.UI.Xaml.Controls.Primitives.ButtonBase";
		_typeNameTable[19] = "System.Windows.Input.ICommand";
		_typeNameTable[20] = "Microsoft.UI.Xaml.Style";
		_typeNameTable[21] = "Microsoft.UI.Xaml.DataTemplate";
		_typeNameTable[22] = "Microsoft.UI.Xaml.Controls.IconSource";
		_typeNameTable[23] = "Microsoft.UI.Xaml.Controls.InfoBarTemplateSettings";
		_typeNameTable[24] = "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryView";
		_typeNameTable[25] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel>";
		_typeNameTable[26] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel>";
		_typeNameTable[27] = "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel";
		_typeNameTable[28] = "Int64";
		_typeNameTable[29] = "Microsoft.UI.Xaml.Media.Imaging.BitmapImage";
		_typeNameTable[30] = "P4nQc8LxjCxnxuINJP5.BpOjxVLPwPUO93lZkbW";
		_typeNameTable[31] = "Microsoft.UI.Xaml.Controls.Page";
		_typeNameTable[32] = "Microsoft.UI.Xaml.Controls.ProgressBar";
		_typeNameTable[33] = "Microsoft.UI.Xaml.Controls.Primitives.RangeBase";
		_typeNameTable[34] = "Microsoft.UI.Xaml.Controls.ProgressBarTemplateSettings";
		_typeNameTable[35] = "uj1PrqjB4rcHFMlFGdp.iv7VBsjI8muRaeK8cVn";
		_typeNameTable[36] = "D5dq98Zj0UIlWLL7BDu.BFW7DwZLAOwBnfcMB57";
		_typeNameTable[37] = "Microsoft.UI.Xaml.Controls.TabView";
		_typeNameTable[38] = "System.Collections.Generic.IList`1<Object>";
		_typeNameTable[39] = "Microsoft.UI.Xaml.Controls.TabViewWidthMode";
		_typeNameTable[40] = "Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode";
		_typeNameTable[41] = "Int32";
		_typeNameTable[42] = "Microsoft.UI.Xaml.Controls.DataTemplateSelector";
		_typeNameTable[43] = "Microsoft.UI.Xaml.Controls.TabViewItem";
		_typeNameTable[44] = "Microsoft.UI.Xaml.Controls.ListViewItem";
		_typeNameTable[45] = "Microsoft.UI.Xaml.Controls.ContentControl";
		_typeNameTable[46] = "Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings";
		_typeNameTable[47] = "Microsoft.UI.Xaml.Controls.Expander";
		_typeNameTable[48] = "Microsoft.UI.Xaml.Controls.ExpandDirection";
		_typeNameTable[49] = "Microsoft.UI.Xaml.Controls.ExpanderTemplateSettings";
		_typeNameTable[50] = "Mahiro_Account.Features.McpStudio.Views.McpStudioPage";
		_typeNameTable[51] = "Mahiro_Account.UI.Shell.ShellView";
		_typeNameTable[52] = "Microsoft.UI.Xaml.XamlRoot";
		_typeNameTable[53] = "Mahiro_Account.MainWindow";
		_typeNameTable[54] = "Microsoft.UI.Xaml.Window";
		_typeNameTable[55] = "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailDialog";
		_typeNameTable[56] = "Microsoft.UI.Xaml.Controls.ContentDialog";
		_typeNameTable[57] = "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailViewModel";
		_typeNameTable[58] = "Microsoft.UI.Xaml.Controls.WebView2";
		_typeNameTable[59] = "Microsoft.UI.Xaml.FrameworkElement";
		_typeNameTable[60] = "Windows.UI.Color";
		_typeNameTable[61] = "Microsoft.Web.WebView2.Core.CoreWebView2";
		_typeNameTable[62] = "System.Uri";
		_typeNameTable[63] = "Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage";
		_typeNameTable[64] = "Microsoft.UI.Xaml.Media.Stretch";
		_typeNameTable[65] = "Mahiro_Account.UI.Controls.Bedrock.BedrockFourDimensionalViewer";
		_typeNameTable[66] = "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceList";
		_typeNameTable[67] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel>";
		_typeNameTable[68] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel>";
		_typeNameTable[69] = "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel";
		_typeNameTable[70] = "Mahiro_Account.Models.Bedrock.BedrockInstanceInfo";
		_typeNameTable[71] = "Mahiro_Account.Services.Bedrock.Relay.BedrockRelaySnapshot";
		_typeNameTable[72] = "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyBrowser";
		_typeNameTable[73] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel>";
		_typeNameTable[74] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel>";
		_typeNameTable[75] = "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel";
		_typeNameTable[76] = "Mahiro_Account.Models.Bedrock.BedrockLocalLobbyRoom";
		_typeNameTable[77] = "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackBrowser";
		_typeNameTable[78] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel>";
		_typeNameTable[79] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel>";
		_typeNameTable[80] = "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel";
		_typeNameTable[81] = "Mahiro_Account.Models.Bedrock.BedrockMaterialPack";
		_typeNameTable[82] = "CommunityToolkit.WinUI.Controls.SettingsExpander";
		_typeNameTable[83] = "Microsoft.UI.Xaml.Controls.IconElement";
		_typeNameTable[84] = "Microsoft.UI.Xaml.Controls.StyleSelector";
		_typeNameTable[85] = "Microsoft.UI.Xaml.UIElement";
		_typeNameTable[86] = "CommunityToolkit.WinUI.Controls.SettingsCard";
		_typeNameTable[87] = "CommunityToolkit.WinUI.Controls.ContentAlignment";
		_typeNameTable[88] = "Mahiro_Account.UI.Controls.Bedrock.BedrockProxySettingsView";
		_typeNameTable[89] = "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser";
		_typeNameTable[90] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel>";
		_typeNameTable[91] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel>";
		_typeNameTable[92] = "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel";
		_typeNameTable[93] = "Mahiro_Account.Models.Bedrock.BedrockRentalRoom";
		_typeNameTable[94] = "Mahiro_Account.Services.Bedrock.Relay.BedrockRelayBindScope";
		_typeNameTable[95] = "Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser";
		_typeNameTable[96] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel>";
		_typeNameTable[97] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel>";
		_typeNameTable[98] = "Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel";
		_typeNameTable[99] = "Mahiro_Account.Models.Bedrock.BedrockServer";
		_typeNameTable[100] = "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinViewer";
		_typeNameTable[101] = "Microsoft.UI.Xaml.Controls.SelectorBar";
		_typeNameTable[102] = "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.SelectorBarItem>";
		_typeNameTable[103] = "Microsoft.UI.Xaml.Controls.SelectorBarItem";
		_typeNameTable[104] = "Microsoft.UI.Xaml.Controls.ItemContainer";
		_typeNameTable[105] = "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinBrowser";
		_typeNameTable[106] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel>";
		_typeNameTable[107] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel>";
		_typeNameTable[108] = "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel";
		_typeNameTable[109] = "Mahiro_Account.Models.Bedrock.BedrockAppearanceKind";
		_typeNameTable[110] = "Mahiro_Account.Models.Bedrock.BedrockFreeSkin";
		_typeNameTable[111] = "Mahiro_Account.Models.Bedrock.BedrockFourDimensionalSkin";
		_typeNameTable[112] = "Mahiro_Account.Models.Bedrock.BedrockFourDimensionalPart";
		_typeNameTable[113] = "Mahiro_Account.UI.Controls.Bedrock.JavaPackConversionBenefitsDialog";
		_typeNameTable[114] = "Mahiro_Account.UI.Controls.Java.JavaRuntimeProfilePanel";
		_typeNameTable[115] = "Mahiro_Account.UI.Controls.PaymentBannerCarousel";
		_typeNameTable[116] = "Mahiro_Account.UI.Controls.PaymentBannerEditor";
		_typeNameTable[117] = "Mahiro_Account.UI.Controls.RecentPaymentOrdersPanel";
		_typeNameTable[118] = "Mahiro_Account.UI.Controls.ShutdownUploadOverlay";
		_typeNameTable[119] = "Mahiro_Account.UI.Controls.Toolbox.BedrockToolsView";
		_typeNameTable[120] = "Microsoft.UI.Xaml.Controls.ItemsRepeater";
		_typeNameTable[121] = "Microsoft.UI.Xaml.Controls.Layout";
		_typeNameTable[122] = "Microsoft.UI.Xaml.Media.Brush";
		_typeNameTable[123] = "Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider";
		_typeNameTable[124] = "Microsoft.UI.Xaml.Controls.ItemsSourceView";
		_typeNameTable[125] = "Microsoft.UI.Xaml.Controls.UniformGridLayout";
		_typeNameTable[126] = "Microsoft.UI.Xaml.Controls.VirtualizingLayout";
		_typeNameTable[127] = "Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification";
		_typeNameTable[128] = "Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch";
		_typeNameTable[129] = "Microsoft.UI.Xaml.Controls.Orientation";
		_typeNameTable[130] = "Microsoft.UI.Xaml.Controls.IndexBasedLayoutOrientation";
		_typeNameTable[131] = "Mahiro_Account.UI.Controls.Toolbox.HwidSpoofToolsView";
		_typeNameTable[132] = "Mahiro_Account.UI.Controls.UserRefundDetailView";
		_typeNameTable[133] = "Mahiro_Account.UI.Controls.UserRefundRequestDialog";
		_typeNameTable[134] = "Mahiro_Account.UI.Controls.UserRefundRequestsView";
		_typeNameTable[135] = "Mahiro_Account.UI.Shell.AppWatermark";
		_typeNameTable[136] = "Microsoft.UI.Xaml.Media.RadialGradientBrush";
		_typeNameTable[137] = "Microsoft.UI.Xaml.Media.XamlCompositionBrushBase";
		_typeNameTable[138] = "Windows.Foundation.Collections.IObservableVector`1<Microsoft.UI.Xaml.Media.GradientStop>";
		_typeNameTable[139] = "Microsoft.UI.Xaml.Media.GradientStop";
		_typeNameTable[140] = "Windows.Foundation.Point";
		_typeNameTable[141] = "Microsoft.UI.Composition.CompositionColorSpace";
		_typeNameTable[142] = "Microsoft.UI.Xaml.Media.BrushMappingMode";
		_typeNameTable[143] = "Microsoft.UI.Xaml.Media.GradientSpreadMethod";
		_typeNameTable[144] = "Mahiro_Account.UI.Shell.AuthView";
		_typeNameTable[145] = "Mahiro_Account.UI.Shell.InfoBarHost";
		_typeNameTable[146] = "Microsoft.UI.Xaml.Controls.PersonPicture";
		_typeNameTable[147] = "Microsoft.UI.Xaml.Media.ImageSource";
		_typeNameTable[148] = "Windows.ApplicationModel.Contacts.Contact";
		_typeNameTable[149] = "Microsoft.UI.Xaml.Controls.PersonPictureTemplateSettings";
		_typeNameTable[150] = "Mahiro_Account.UI.Shell.NavigationUserFooter";
		_typeNameTable[151] = "Mahiro_Account.UI.Shell.PagerBar";
		_typeNameTable[152] = "Microsoft.UI.Xaml.Thickness";
		_typeNameTable[153] = "Microsoft.UI.Xaml.Controls.TitleBar";
		_typeNameTable[154] = "Microsoft.UI.Xaml.Controls.TitleBarTemplateSettings";
		_typeNameTable[155] = "System.Nullable`1<Boolean>";
		_typeNameTable[156] = "Microsoft.UI.Xaml.Controls.NavigationView";
		_typeNameTable[157] = "Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible";
		_typeNameTable[158] = "Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode";
		_typeNameTable[159] = "Microsoft.UI.Xaml.Controls.AutoSuggestBox";
		_typeNameTable[160] = "Microsoft.UI.Xaml.Controls.NavigationViewDisplayMode";
		_typeNameTable[161] = "Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode";
		_typeNameTable[162] = "Microsoft.UI.Xaml.Controls.NavigationViewSelectionFollowsFocus";
		_typeNameTable[163] = "Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled";
		_typeNameTable[164] = "Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings";
		_typeNameTable[165] = "Microsoft.UI.Xaml.Controls.NavigationViewItem";
		_typeNameTable[166] = "Microsoft.UI.Xaml.Controls.NavigationViewItemBase";
		_typeNameTable[167] = "Microsoft.UI.Xaml.Controls.InfoBadge";
		_typeNameTable[168] = "Microsoft.UI.Xaml.Controls.NavigationViewItemHeader";
		_typeNameTable[169] = "Microsoft.UI.Xaml.Controls.ImageIconSource";
		_typeNameTable[170] = "Microsoft.UI.Xaml.CornerRadius";
		_typeNameTable[171] = "CommunityToolkit.WinUI.Media.AttachedCardShadow";
		_typeNameTable[172] = "CommunityToolkit.WinUI.AttachedShadowBase";
		_typeNameTable[173] = "CommunityToolkit.WinUI.Media.InnerContentClipMode";
		_typeNameTable[174] = "Byte";
		_typeNameTable[175] = "Mahiro_Account.Views.Pages.AboutPage";
		_typeNameTable[176] = "Mahiro_Account.Views.Pages.AccountPage";
		_typeNameTable[177] = "Mahiro_Account.Views.Pages.BalanceHistoryPage";
		_typeNameTable[178] = "Microsoft.UI.Xaml.Controls.NumberBox";
		_typeNameTable[179] = "Windows.Globalization.NumberFormatting.INumberFormatter2";
		_typeNameTable[180] = "Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase";
		_typeNameTable[181] = "Microsoft.UI.Xaml.Media.SolidColorBrush";
		_typeNameTable[182] = "Microsoft.UI.Xaml.Controls.NumberBoxSpinButtonPlacementMode";
		_typeNameTable[183] = "Microsoft.UI.Xaml.TextReadingOrder";
		_typeNameTable[184] = "Microsoft.UI.Xaml.Controls.NumberBoxValidationMode";
		_typeNameTable[185] = "Mahiro_Account.Views.Pages.BalancePage";
		_typeNameTable[186] = "Mahiro_Account.Views.Pages.Bedrock.BedrockAccountPage";
		_typeNameTable[187] = "Mahiro_Account.Views.Pages.Bedrock.BedrockInstancesPage";
		_typeNameTable[188] = "Mahiro_Account.Views.Pages.Bedrock.BedrockLocalMultiplayerPage";
		_typeNameTable[189] = "Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPackConverterPage";
		_typeNameTable[190] = "Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPacksPage";
		_typeNameTable[191] = "Mahiro_Account.Views.Pages.Bedrock.BedrockOnlineLobbyPage";
		_typeNameTable[192] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom>";
		_typeNameTable[193] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom>";
		_typeNameTable[194] = "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom";
		_typeNameTable[195] = "Mahiro_Account.Views.Pages.Bedrock.BedrockRentalRoomsPage";
		_typeNameTable[196] = "Mahiro_Account.Views.Pages.Bedrock.BedrockServersPage";
		_typeNameTable[197] = "Mahiro_Account.Views.Pages.Bedrock.BedrockSkinsPage";
		_typeNameTable[198] = "Mahiro_Account.Views.Pages.Bedrock.BedrockVersionManagementPage";
		_typeNameTable[199] = "Mahiro_Account.Views.Pages.Bedrock.BedrockWorldsPage";
		_typeNameTable[200] = "Mahiro_Account.Views.Pages.DealerPage";
		_typeNameTable[201] = "Mahiro_Account.Views.Pages.HomePage";
		_typeNameTable[202] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Views.Pages.TimelineEntry>";
		_typeNameTable[203] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Views.Pages.TimelineEntry>";
		_typeNameTable[204] = "Mahiro_Account.Views.Pages.TimelineEntry";
		_typeNameTable[205] = "System.Collections.Generic.List`1<Mahiro_Account.Views.Pages.TimelineNote>";
		_typeNameTable[206] = "Mahiro_Account.Views.Pages.TimelineNote";
		_typeNameTable[207] = "Mahiro_Account.Views.Pages.HookLoginPage";
		_typeNameTable[208] = "Mahiro_Account.Views.Pages.InvitationPage";
		_typeNameTable[209] = "Mahiro_Account.Views.Pages.Java.JavaAccountPage";
		_typeNameTable[210] = "Mahiro_Account.Views.Pages.Java.JavaCompatibilityInstancesPage";
		_typeNameTable[211] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.JavaInstanceInfo>";
		_typeNameTable[212] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.JavaInstanceInfo>";
		_typeNameTable[213] = "Mahiro_Account.Models.Java.JavaInstanceInfo";
		_typeNameTable[214] = "System.DateTimeOffset";
		_typeNameTable[215] = "Mahiro_Account.Models.Java.JavaInstanceState";
		_typeNameTable[216] = "System.Nullable`1<Int32>";
		_typeNameTable[217] = "System.Collections.Generic.IReadOnlyList`1<String>";
		_typeNameTable[218] = "Mahiro_Account.Models.Java.JavaCrashReport";
		_typeNameTable[219] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot>";
		_typeNameTable[220] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot>";
		_typeNameTable[221] = "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot";
		_typeNameTable[222] = "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceState";
		_typeNameTable[223] = "Mahiro_Account.Models.Java.Proxy.JavaProxyEndpoint";
		_typeNameTable[224] = "Mahiro_Account.Models.Java.Proxy.JavaProxyTrafficSnapshot";
		_typeNameTable[225] = "Mahiro_Account.Models.Java.Proxy.JavaProxyDisconnectReason";
		_typeNameTable[226] = "Mahiro_Account.Views.Pages.Java.JavaCompatibilityToolsPage";
		_typeNameTable[227] = "Mahiro_Account.Views.Pages.Java.JavaHookEntryPage";
		_typeNameTable[228] = "Mahiro_Account.Views.Pages.Java.JavaInstancesPage";
		_typeNameTable[229] = "Mahiro_Account.Views.Pages.Java.JavaServersPage";
		_typeNameTable[230] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.JavaServer>";
		_typeNameTable[231] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.JavaServer>";
		_typeNameTable[232] = "Mahiro_Account.Models.Java.JavaServer";
		_typeNameTable[233] = "System.Collections.Generic.IReadOnlyList`1<Mahiro_Account.Models.Java.JavaMinecraftVersion>";
		_typeNameTable[234] = "Mahiro_Account.Views.Pages.Java.JavaSkinsPage";
		_typeNameTable[235] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel>";
		_typeNameTable[236] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel>";
		_typeNameTable[237] = "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel";
		_typeNameTable[238] = "Mahiro_Account.Models.Java.JavaSkin";
		_typeNameTable[239] = "Mahiro_Account.Views.Pages.Java.JavaVersionManagementPage";
		_typeNameTable[240] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.JavaVersionInstallationInfo>";
		_typeNameTable[241] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.JavaVersionInstallationInfo>";
		_typeNameTable[242] = "Mahiro_Account.Models.Java.JavaVersionInstallationInfo";
		_typeNameTable[243] = "Mahiro_Account.Models.Java.JavaMinecraftVersion";
		_typeNameTable[244] = "Mahiro_Account.Models.Java.JavaRuntimeProfile";
		_typeNameTable[245] = "Mahiro_Account.Views.Pages.MediaPage";
		_typeNameTable[246] = "Mahiro_Account.Views.Pages.Pay4399Page";
		_typeNameTable[247] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Pay4399AccountRecord>";
		_typeNameTable[248] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Pay4399AccountRecord>";
		_typeNameTable[249] = "Mahiro_Account.Models.Pay4399AccountRecord";
		_typeNameTable[250] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Pay4399PendingAccountRecord>";
		_typeNameTable[251] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Pay4399PendingAccountRecord>";
		_typeNameTable[252] = "Mahiro_Account.Models.Pay4399PendingAccountRecord";
		_typeNameTable[253] = "System.Decimal";
		_typeNameTable[254] = "Mahiro_Account.Views.Pages.PaymentCenterOrdersPage";
		_typeNameTable[255] = "Mahiro_Account.Views.Pages.PaymentCenterPage";
		_typeNameTable[256] = "Mahiro_Account.Views.Pages.PaymentCenterRefundsPage";
		_typeNameTable[257] = "Mahiro_Account.Views.Pages.PaymentOrdersPage";
		_typeNameTable[258] = "Mahiro_Account.Views.Pages.ProductDetailPage";
		_typeNameTable[259] = "Mahiro_Account.UI.Motion";
		_typeNameTable[260] = "CommunityToolkit.WinUI.Effects";
		_typeNameTable[261] = "Mahiro_Account.Views.Pages.ProductPage";
		_typeNameTable[262] = "Mahiro_Account.Views.Pages.QrLoginPage";
		_typeNameTable[263] = "Mahiro_Account.Views.Pages.RefundHistoryPage";
		_typeNameTable[264] = "Mahiro_Account.Views.Pages.ServiceSubscriptionsPage";
		_typeNameTable[265] = "Mahiro_Account.Views.Pages.ToolboxPage";
		_typeNameTable[266] = "Mahiro_Account.Views.Pages.X19LoginPage";
		_typeNameTable[267] = "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.X19AccountRecord>";
		_typeNameTable[268] = "System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.X19AccountRecord>";
		_typeNameTable[269] = "Mahiro_Account.Models.X19AccountRecord";
		_typeNameTable[270] = "Microsoft.UI.Xaml.Controls.TreeViewNode";
		_typeNameTable[271] = "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.TreeViewNode>";
		_typeTable = new global::System.Type[272];
		_typeTable[0] = typeof(global::Microsoft.UI.Xaml.Controls.XamlControlsResources);
		_typeTable[1] = typeof(global::Microsoft.UI.Xaml.ResourceDictionary);
		_typeTable[2] = typeof(global::System.Object);
		_typeTable[3] = typeof(global::System.Boolean);
		_typeTable[4] = typeof(global::Mahiro_Account.UI.Shell.PageHeader);
		_typeTable[5] = typeof(global::Microsoft.UI.Xaml.Controls.UserControl);
		_typeTable[6] = typeof(global::System.String);
		_typeTable[7] = typeof(global::Microsoft.UI.Xaml.Visibility);
		_typeTable[8] = typeof(global::Microsoft.UI.Xaml.Controls.ProgressRing);
		_typeTable[9] = typeof(global::Microsoft.UI.Xaml.Controls.Control);
		_typeTable[10] = typeof(global::System.Double);
		_typeTable[11] = typeof(global::Microsoft.UI.Xaml.Controls.ProgressRingTemplateSettings);
		_typeTable[12] = typeof(global::Microsoft.UI.Xaml.DependencyObject);
		_typeTable[13] = typeof(global::Mahiro_Account.UI.Controls.SmsVerificationView);
		_typeTable[14] = typeof(global::Microsoft.UI.Xaml.Controls.InfoBar);
		_typeTable[15] = typeof(global::Microsoft.UI.Xaml.Controls.InfoBarSeverity);
		_typeTable[16] = typeof(global::System.Enum);
		_typeTable[17] = typeof(global::System.ValueType);
		_typeTable[18] = typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ButtonBase);
		_typeTable[19] = typeof(global::System.Windows.Input.ICommand);
		_typeTable[20] = typeof(global::Microsoft.UI.Xaml.Style);
		_typeTable[21] = typeof(global::Microsoft.UI.Xaml.DataTemplate);
		_typeTable[22] = typeof(global::Microsoft.UI.Xaml.Controls.IconSource);
		_typeTable[23] = typeof(global::Microsoft.UI.Xaml.Controls.InfoBarTemplateSettings);
		_typeTable[24] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryView);
		_typeTable[25] = typeof(ObservableCollection<BedrockAccountHistoryItemViewModel>);
		_typeTable[26] = typeof(Collection<BedrockAccountHistoryItemViewModel>);
		_typeTable[27] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel);
		_typeTable[28] = typeof(global::System.Int64);
		_typeTable[29] = typeof(global::Microsoft.UI.Xaml.Media.Imaging.BitmapImage);
		_typeTable[30] = typeof(global::P4nQc8LxjCxnxuINJP5.BpOjxVLPwPUO93lZkbW);
		_typeTable[31] = typeof(global::Microsoft.UI.Xaml.Controls.Page);
		_typeTable[32] = typeof(global::Microsoft.UI.Xaml.Controls.ProgressBar);
		_typeTable[33] = typeof(global::Microsoft.UI.Xaml.Controls.Primitives.RangeBase);
		_typeTable[34] = typeof(global::Microsoft.UI.Xaml.Controls.ProgressBarTemplateSettings);
		_typeTable[35] = typeof(global::uj1PrqjB4rcHFMlFGdp.iv7VBsjI8muRaeK8cVn);
		_typeTable[36] = typeof(global::D5dq98Zj0UIlWLL7BDu.BFW7DwZLAOwBnfcMB57);
		_typeTable[37] = typeof(global::Microsoft.UI.Xaml.Controls.TabView);
		_typeTable[38] = typeof(global::System.Collections.Generic.IList<object>);
		_typeTable[39] = typeof(global::Microsoft.UI.Xaml.Controls.TabViewWidthMode);
		_typeTable[40] = typeof(global::Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode);
		_typeTable[41] = typeof(global::System.Int32);
		_typeTable[42] = typeof(global::Microsoft.UI.Xaml.Controls.DataTemplateSelector);
		_typeTable[43] = typeof(global::Microsoft.UI.Xaml.Controls.TabViewItem);
		_typeTable[44] = typeof(global::Microsoft.UI.Xaml.Controls.ListViewItem);
		_typeTable[45] = typeof(global::Microsoft.UI.Xaml.Controls.ContentControl);
		_typeTable[46] = typeof(global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings);
		_typeTable[47] = typeof(global::Microsoft.UI.Xaml.Controls.Expander);
		_typeTable[48] = typeof(global::Microsoft.UI.Xaml.Controls.ExpandDirection);
		_typeTable[49] = typeof(global::Microsoft.UI.Xaml.Controls.ExpanderTemplateSettings);
		_typeTable[50] = typeof(global::Mahiro_Account.Features.McpStudio.Views.McpStudioPage);
		_typeTable[51] = typeof(global::Mahiro_Account.UI.Shell.ShellView);
		_typeTable[52] = typeof(global::Microsoft.UI.Xaml.XamlRoot);
		_typeTable[53] = typeof(global::Mahiro_Account.MainWindow);
		_typeTable[54] = typeof(global::Microsoft.UI.Xaml.Window);
		_typeTable[55] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailDialog);
		_typeTable[56] = typeof(global::Microsoft.UI.Xaml.Controls.ContentDialog);
		_typeTable[57] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailViewModel);
		_typeTable[58] = typeof(global::Microsoft.UI.Xaml.Controls.WebView2);
		_typeTable[59] = typeof(global::Microsoft.UI.Xaml.FrameworkElement);
		_typeTable[60] = typeof(global::Windows.UI.Color);
		_typeTable[61] = typeof(global::Microsoft.Web.WebView2.Core.CoreWebView2);
		_typeTable[62] = typeof(global::System.Uri);
		_typeTable[63] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage);
		_typeTable[64] = typeof(global::Microsoft.UI.Xaml.Media.Stretch);
		_typeTable[65] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockFourDimensionalViewer);
		_typeTable[66] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceList);
		_typeTable[67] = typeof(ObservableCollection<BedrockInstanceCardViewModel>);
		_typeTable[68] = typeof(Collection<BedrockInstanceCardViewModel>);
		_typeTable[69] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel);
		_typeTable[70] = typeof(global::i6TlJMfuChv2AjPXr7O8.zG6ueUfuQUk6CEmxLYji);
		_typeTable[71] = typeof(global::nyJeB7f0q9CPYw2lLbou.MFIPycf02g29tSkCEJDk);
		_typeTable[72] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyBrowser);
		_typeTable[73] = typeof(ObservableCollection<BedrockLocalLobbyRoomCardViewModel>);
		_typeTable[74] = typeof(Collection<BedrockLocalLobbyRoomCardViewModel>);
		_typeTable[75] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel);
		_typeTable[76] = typeof(global::zCVMnbfabiR2jSY2xUjH.cwSYjVfuzDOvn8hKeZih);
		_typeTable[77] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackBrowser);
		_typeTable[78] = typeof(ObservableCollection<BedrockMaterialPackViewModel>);
		_typeTable[79] = typeof(Collection<BedrockMaterialPackViewModel>);
		_typeTable[80] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel);
		_typeTable[81] = typeof(global::nW2Sekfay3BSEMMb8toe.WQh695fa8bRtqyh4inIH);
		_typeTable[82] = typeof(global::CommunityToolkit.WinUI.Controls.SettingsExpander);
		_typeTable[83] = typeof(global::Microsoft.UI.Xaml.Controls.IconElement);
		_typeTable[84] = typeof(global::Microsoft.UI.Xaml.Controls.StyleSelector);
		_typeTable[85] = typeof(global::Microsoft.UI.Xaml.UIElement);
		_typeTable[86] = typeof(global::CommunityToolkit.WinUI.Controls.SettingsCard);
		_typeTable[87] = typeof(global::CommunityToolkit.WinUI.Controls.ContentAlignment);
		_typeTable[88] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockProxySettingsView);
		_typeTable[89] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser);
		_typeTable[90] = typeof(ObservableCollection<BedrockRentalRoomCardViewModel>);
		_typeTable[91] = typeof(Collection<BedrockRentalRoomCardViewModel>);
		_typeTable[92] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel);
		_typeTable[93] = typeof(global::yun8CRfanLkaBpPLfVrd.DAoPoufaie63jNVdbNug);
		_typeTable[94] = typeof(global::fZGimHf0suVRPkaXFQcr.mpVm6bf0F2Qxo2jn2O2u);
		_typeTable[95] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser);
		_typeTable[96] = typeof(ObservableCollection<BedrockServerCardViewModel>);
		_typeTable[97] = typeof(Collection<BedrockServerCardViewModel>);
		_typeTable[98] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel);
		_typeTable[99] = typeof(global::ROZe5Gf1WgRr9IZ64gbr.wjHCLDf1ydVEraHow39U);
		_typeTable[100] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockSkinViewer);
		_typeTable[101] = typeof(global::Microsoft.UI.Xaml.Controls.SelectorBar);
		_typeTable[102] = typeof(global::System.Collections.Generic.IList<SelectorBarItem>);
		_typeTable[103] = typeof(global::Microsoft.UI.Xaml.Controls.SelectorBarItem);
		_typeTable[104] = typeof(global::Microsoft.UI.Xaml.Controls.ItemContainer);
		_typeTable[105] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockSkinBrowser);
		_typeTable[106] = typeof(ObservableCollection<BedrockSkinCardViewModel>);
		_typeTable[107] = typeof(Collection<BedrockSkinCardViewModel>);
		_typeTable[108] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel);
		_typeTable[109] = typeof(global::EBJLMifNn8QeuhMRSx7U.p1aif0fNieMbuxR5AlNF);
		_typeTable[110] = typeof(global::ajau5tfpTXRk8mjlQPRa.ejKX8wfpsw8ins4MWI7J);
		_typeTable[111] = typeof(global::VE4SD3fpOtryqPu1jwJE.dZU6g2fptC4VZ350fMxJ);
		_typeTable[112] = typeof(global::xsbjKUfp9um80Gf8YymA.m4wFTFfpZW4pcAqQZC1k);
		_typeTable[113] = typeof(global::Mahiro_Account.UI.Controls.Bedrock.JavaPackConversionBenefitsDialog);
		_typeTable[114] = typeof(global::Mahiro_Account.UI.Controls.Java.JavaRuntimeProfilePanel);
		_typeTable[115] = typeof(global::Mahiro_Account.UI.Controls.PaymentBannerCarousel);
		_typeTable[116] = typeof(global::Mahiro_Account.UI.Controls.PaymentBannerEditor);
		_typeTable[117] = typeof(global::Mahiro_Account.UI.Controls.RecentPaymentOrdersPanel);
		_typeTable[118] = typeof(global::Mahiro_Account.UI.Controls.ShutdownUploadOverlay);
		_typeTable[119] = typeof(global::Mahiro_Account.UI.Controls.Toolbox.BedrockToolsView);
		_typeTable[120] = typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater);
		_typeTable[121] = typeof(global::Microsoft.UI.Xaml.Controls.Layout);
		_typeTable[122] = typeof(global::Microsoft.UI.Xaml.Media.Brush);
		_typeTable[123] = typeof(global::Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider);
		_typeTable[124] = typeof(global::Microsoft.UI.Xaml.Controls.ItemsSourceView);
		_typeTable[125] = typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout);
		_typeTable[126] = typeof(global::Microsoft.UI.Xaml.Controls.VirtualizingLayout);
		_typeTable[127] = typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification);
		_typeTable[128] = typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch);
		_typeTable[129] = typeof(global::Microsoft.UI.Xaml.Controls.Orientation);
		_typeTable[130] = typeof(global::Microsoft.UI.Xaml.Controls.IndexBasedLayoutOrientation);
		_typeTable[131] = typeof(global::Mahiro_Account.UI.Controls.Toolbox.HwidSpoofToolsView);
		_typeTable[132] = typeof(global::Mahiro_Account.UI.Controls.UserRefundDetailView);
		_typeTable[133] = typeof(global::Mahiro_Account.UI.Controls.UserRefundRequestDialog);
		_typeTable[134] = typeof(global::Mahiro_Account.UI.Controls.UserRefundRequestsView);
		_typeTable[135] = typeof(global::Mahiro_Account.UI.Shell.AppWatermark);
		_typeTable[136] = typeof(global::Microsoft.UI.Xaml.Media.RadialGradientBrush);
		_typeTable[137] = typeof(global::Microsoft.UI.Xaml.Media.XamlCompositionBrushBase);
		_typeTable[138] = typeof(IObservableVector<GradientStop>);
		_typeTable[139] = typeof(global::Microsoft.UI.Xaml.Media.GradientStop);
		_typeTable[140] = typeof(global::Windows.Foundation.Point);
		_typeTable[141] = typeof(global::Microsoft.UI.Composition.CompositionColorSpace);
		_typeTable[142] = typeof(global::Microsoft.UI.Xaml.Media.BrushMappingMode);
		_typeTable[143] = typeof(global::Microsoft.UI.Xaml.Media.GradientSpreadMethod);
		_typeTable[144] = typeof(global::Mahiro_Account.UI.Shell.AuthView);
		_typeTable[145] = typeof(global::Mahiro_Account.UI.Shell.InfoBarHost);
		_typeTable[146] = typeof(global::Microsoft.UI.Xaml.Controls.PersonPicture);
		_typeTable[147] = typeof(global::Microsoft.UI.Xaml.Media.ImageSource);
		_typeTable[148] = typeof(global::Windows.ApplicationModel.Contacts.Contact);
		_typeTable[149] = typeof(global::Microsoft.UI.Xaml.Controls.PersonPictureTemplateSettings);
		_typeTable[150] = typeof(global::Mahiro_Account.UI.Shell.NavigationUserFooter);
		_typeTable[151] = typeof(global::Mahiro_Account.UI.Shell.PagerBar);
		_typeTable[152] = typeof(global::Microsoft.UI.Xaml.Thickness);
		_typeTable[153] = typeof(global::Microsoft.UI.Xaml.Controls.TitleBar);
		_typeTable[154] = typeof(global::Microsoft.UI.Xaml.Controls.TitleBarTemplateSettings);
		_typeTable[155] = typeof(bool?);
		_typeTable[156] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationView);
		_typeTable[157] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible);
		_typeTable[158] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode);
		_typeTable[159] = typeof(global::Microsoft.UI.Xaml.Controls.AutoSuggestBox);
		_typeTable[160] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewDisplayMode);
		_typeTable[161] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode);
		_typeTable[162] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewSelectionFollowsFocus);
		_typeTable[163] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled);
		_typeTable[164] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings);
		_typeTable[165] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewItem);
		_typeTable[166] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewItemBase);
		_typeTable[167] = typeof(global::Microsoft.UI.Xaml.Controls.InfoBadge);
		_typeTable[168] = typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewItemHeader);
		_typeTable[169] = typeof(global::Microsoft.UI.Xaml.Controls.ImageIconSource);
		_typeTable[170] = typeof(global::Microsoft.UI.Xaml.CornerRadius);
		_typeTable[171] = typeof(global::CommunityToolkit.WinUI.Media.AttachedCardShadow);
		_typeTable[172] = typeof(global::CommunityToolkit.WinUI.AttachedShadowBase);
		_typeTable[173] = typeof(global::CommunityToolkit.WinUI.Media.InnerContentClipMode);
		_typeTable[174] = typeof(global::System.Byte);
		_typeTable[175] = typeof(global::Mahiro_Account.Views.Pages.AboutPage);
		_typeTable[176] = typeof(global::Mahiro_Account.Views.Pages.AccountPage);
		_typeTable[177] = typeof(global::Mahiro_Account.Views.Pages.BalanceHistoryPage);
		_typeTable[178] = typeof(global::Microsoft.UI.Xaml.Controls.NumberBox);
		_typeTable[179] = typeof(global::Windows.Globalization.NumberFormatting.INumberFormatter2);
		_typeTable[180] = typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase);
		_typeTable[181] = typeof(global::Microsoft.UI.Xaml.Media.SolidColorBrush);
		_typeTable[182] = typeof(global::Microsoft.UI.Xaml.Controls.NumberBoxSpinButtonPlacementMode);
		_typeTable[183] = typeof(global::Microsoft.UI.Xaml.TextReadingOrder);
		_typeTable[184] = typeof(global::Microsoft.UI.Xaml.Controls.NumberBoxValidationMode);
		_typeTable[185] = typeof(global::Mahiro_Account.Views.Pages.BalancePage);
		_typeTable[186] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockAccountPage);
		_typeTable[187] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockInstancesPage);
		_typeTable[188] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockLocalMultiplayerPage);
		_typeTable[189] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPackConverterPage);
		_typeTable[190] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPacksPage);
		_typeTable[191] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockOnlineLobbyPage);
		_typeTable[192] = typeof(ObservableCollection<en9Zr5faBGr6cyEG7MZ5>);
		_typeTable[193] = typeof(Collection<en9Zr5faBGr6cyEG7MZ5>);
		_typeTable[194] = typeof(global::pZg6QPfag7jmC8rKUG4i.en9Zr5faBGr6cyEG7MZ5);
		_typeTable[195] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockRentalRoomsPage);
		_typeTable[196] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockServersPage);
		_typeTable[197] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockSkinsPage);
		_typeTable[198] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockVersionManagementPage);
		_typeTable[199] = typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockWorldsPage);
		_typeTable[200] = typeof(global::Mahiro_Account.Views.Pages.DealerPage);
		_typeTable[201] = typeof(global::Mahiro_Account.Views.Pages.HomePage);
		_typeTable[202] = typeof(ObservableCollection<TimelineEntry>);
		_typeTable[203] = typeof(Collection<TimelineEntry>);
		_typeTable[204] = typeof(global::Mahiro_Account.Views.Pages.TimelineEntry);
		_typeTable[205] = typeof(List<TimelineNote>);
		_typeTable[206] = typeof(global::Mahiro_Account.Views.Pages.TimelineNote);
		_typeTable[207] = typeof(global::Mahiro_Account.Views.Pages.HookLoginPage);
		_typeTable[208] = typeof(global::Mahiro_Account.Views.Pages.InvitationPage);
		_typeTable[209] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaAccountPage);
		_typeTable[210] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaCompatibilityInstancesPage);
		_typeTable[211] = typeof(ObservableCollection<rIp8CZfFJ2ofCfwfl3J2>);
		_typeTable[212] = typeof(Collection<rIp8CZfFJ2ofCfwfl3J2>);
		_typeTable[213] = typeof(global::IU7UTPfFQa3t5mwomQTu.rIp8CZfFJ2ofCfwfl3J2);
		_typeTable[214] = typeof(global::System.DateTimeOffset);
		_typeTable[215] = typeof(global::qUVWohfFWy6g8p9LphlU.ehKrWCfFyUBmIViVuUtd);
		_typeTable[216] = typeof(int?);
		_typeTable[217] = typeof(global::System.Collections.Generic.IReadOnlyList<string>);
		_typeTable[218] = typeof(global::U4i16dfxBhWhZfMZrtVY.wY9sp7fxIKIZJMsRVskD);
		_typeTable[219] = typeof(ObservableCollection<bq7k3qfN7qMnvLJMNOZa>);
		_typeTable[220] = typeof(Collection<bq7k3qfN7qMnvLJMNOZa>);
		_typeTable[221] = typeof(global::rEWmcPfNAhtZSJjsJvk3.bq7k3qfN7qMnvLJMNOZa);
		_typeTable[222] = typeof(global::EGjGpPfNQ5sRCSMK7KqW.n1qKx2fNJL9msKD7ZGJu);
		_typeTable[223] = typeof(global::UchfG8fTzhAHMiok6Yk0.tevrq6fTnmxdv0004lXm);
		_typeTable[224] = typeof(global::b7C8sgfNUlsIIZiFPiE3.I8UL5cfNhu2cgReqF3g8);
		_typeTable[225] = typeof(global::BdZQbJfN4H4AgIYemOL6.f3JeIyfNCcv94eShPUIb);
		_typeTable[226] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaCompatibilityToolsPage);
		_typeTable[227] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaHookEntryPage);
		_typeTable[228] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaInstancesPage);
		_typeTable[229] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaServersPage);
		_typeTable[230] = typeof(ObservableCollection<YlErsbfs35V4xTUvrlXK>);
		_typeTable[231] = typeof(Collection<YlErsbfs35V4xTUvrlXK>);
		_typeTable[232] = typeof(global::sIIqaHfsvUMJoArTBa4b.YlErsbfs35V4xTUvrlXK);
		_typeTable[233] = typeof(global::System.Collections.Generic.IReadOnlyList<ys1lxxfFBPhowwZS5N6T>);
		_typeTable[234] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaSkinsPage);
		_typeTable[235] = typeof(ObservableCollection<JavaSkinCardViewModel>);
		_typeTable[236] = typeof(Collection<JavaSkinCardViewModel>);
		_typeTable[237] = typeof(global::Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel);
		_typeTable[238] = typeof(global::kTag3lfTQlMnWtlhqJue.gcmmptfTJGk6dCBYHIl7);
		_typeTable[239] = typeof(global::Mahiro_Account.Views.Pages.Java.JavaVersionManagementPage);
		_typeTable[240] = typeof(ObservableCollection<WkLnWrfTRJdhyRBYcOwg>);
		_typeTable[241] = typeof(Collection<WkLnWrfTRJdhyRBYcOwg>);
		_typeTable[242] = typeof(global::kq2pipfTwPkE4qWLSUgF.WkLnWrfTRJdhyRBYcOwg);
		_typeTable[243] = typeof(global::bVyVYtfFgCItGPihJweI.ys1lxxfFBPhowwZS5N6T);
		_typeTable[244] = typeof(global::c2D37HfsFbaPpJo3F98A.uKGDFFfsxYJUyNmtk1xA);
		_typeTable[245] = typeof(global::Mahiro_Account.Views.Pages.MediaPage);
		_typeTable[246] = typeof(global::Mahiro_Account.Views.Pages.Pay4399Page);
		_typeTable[247] = typeof(ObservableCollection<aMuqLcf6hnKdBTwYqLWe>);
		_typeTable[248] = typeof(Collection<aMuqLcf6hnKdBTwYqLWe>);
		_typeTable[249] = typeof(global::N9UVEvf6UHvBucn1bopm.aMuqLcf6hnKdBTwYqLWe);
		_typeTable[250] = typeof(ObservableCollection<pDLYXIf6mU1JnHirkJgm>);
		_typeTable[251] = typeof(Collection<pDLYXIf6mU1JnHirkJgm>);
		_typeTable[252] = typeof(global::P0graHf67FHLhLQyDEVV.pDLYXIf6mU1JnHirkJgm);
		_typeTable[253] = typeof(global::System.Decimal);
		_typeTable[254] = typeof(global::Mahiro_Account.Views.Pages.PaymentCenterOrdersPage);
		_typeTable[255] = typeof(global::Mahiro_Account.Views.Pages.PaymentCenterPage);
		_typeTable[256] = typeof(global::Mahiro_Account.Views.Pages.PaymentCenterRefundsPage);
		_typeTable[257] = typeof(global::Mahiro_Account.Views.Pages.PaymentOrdersPage);
		_typeTable[258] = typeof(global::Mahiro_Account.Views.Pages.ProductDetailPage);
		_typeTable[259] = typeof(global::Mahiro_Account.UI.Motion);
		_typeTable[260] = typeof(global::CommunityToolkit.WinUI.Effects);
		_typeTable[261] = typeof(global::Mahiro_Account.Views.Pages.ProductPage);
		_typeTable[262] = typeof(global::Mahiro_Account.Views.Pages.QrLoginPage);
		_typeTable[263] = typeof(global::Mahiro_Account.Views.Pages.RefundHistoryPage);
		_typeTable[264] = typeof(global::Mahiro_Account.Views.Pages.ServiceSubscriptionsPage);
		_typeTable[265] = typeof(global::Mahiro_Account.Views.Pages.ToolboxPage);
		_typeTable[266] = typeof(global::Mahiro_Account.Views.Pages.X19LoginPage);
		_typeTable[267] = typeof(ObservableCollection<G87XFJfPfhylQ4RC1HmY>);
		_typeTable[268] = typeof(Collection<G87XFJfPfhylQ4RC1HmY>);
		_typeTable[269] = typeof(global::CGTgWZfPLqikrZ4Zv8WL.G87XFJfPfhylQ4RC1HmY);
		_typeTable[270] = typeof(global::Microsoft.UI.Xaml.Controls.TreeViewNode);
		_typeTable[271] = typeof(global::System.Collections.Generic.IList<TreeViewNode>);
	}

	[MethodImpl((MethodImplOptions)8)]
	private int LookupTypeIndexByName(string typeName)
	{
		if (_typeNameTable == null)
		{
			InitTypeTables();
		}
		for (int i = 0; i < _typeNameTable.Length; i++)
		{
			if (string.CompareOrdinal(_typeNameTable[i], typeName) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private int LookupTypeIndexByType(global::System.Type type)
	{
		if (_typeTable == null)
		{
			InitTypeTables();
		}
		for (int i = 0; i < _typeTable.Length; i++)
		{
			if (type == _typeTable[i])
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_0_XamlControlsResources()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new XamlControlsResources();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_4_PageHeader()
	{
		return (object)new PageHeader();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_8_ProgressRing()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new ProgressRing();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_13_SmsVerificationView()
	{
		return (object)new SmsVerificationView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_14_InfoBar()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new InfoBar();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_23_InfoBarTemplateSettings()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new InfoBarTemplateSettings();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_24_BedrockAccountHistoryView()
	{
		return (object)new BedrockAccountHistoryView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_25_ObservableCollection()
	{
		return new ObservableCollection<BedrockAccountHistoryItemViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_26_Collection()
	{
		return new Collection<BedrockAccountHistoryItemViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_30_ClassicAccountPage()
	{
		return (object)new BpOjxVLPwPUO93lZkbW();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_32_ProgressBar()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new ProgressBar();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_35_ClassicDownloadsPage()
	{
		return (object)new iv7VBsjI8muRaeK8cVn();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_36_ClassicLaunchPage()
	{
		return (object)new BFW7DwZLAOwBnfcMB57();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_37_TabView()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new TabView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_43_TabViewItem()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new TabViewItem();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_46_TabViewItemTemplateSettings()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new TabViewItemTemplateSettings();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_47_Expander()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new Expander();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_50_McpStudioPage()
	{
		return (object)new McpStudioPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_51_ShellView()
	{
		return (object)new ShellView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_53_MainWindow()
	{
		return (object)new MainWindow();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_58_WebView2()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new WebView2();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_63_BedrockNetworkImage()
	{
		return (object)new BedrockNetworkImage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_65_BedrockFourDimensionalViewer()
	{
		return (object)new BedrockFourDimensionalViewer();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_66_BedrockInstanceList()
	{
		return (object)new BedrockInstanceList();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_67_ObservableCollection()
	{
		return new ObservableCollection<BedrockInstanceCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_68_Collection()
	{
		return new Collection<BedrockInstanceCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_72_BedrockLocalLobbyBrowser()
	{
		return (object)new BedrockLocalLobbyBrowser();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_73_ObservableCollection()
	{
		return new ObservableCollection<BedrockLocalLobbyRoomCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_74_Collection()
	{
		return new Collection<BedrockLocalLobbyRoomCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_77_BedrockMaterialPackBrowser()
	{
		return (object)new BedrockMaterialPackBrowser();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_78_ObservableCollection()
	{
		return new ObservableCollection<BedrockMaterialPackViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_79_Collection()
	{
		return new Collection<BedrockMaterialPackViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_82_SettingsExpander()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new SettingsExpander();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_86_SettingsCard()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new SettingsCard();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_88_BedrockProxySettingsView()
	{
		return (object)new BedrockProxySettingsView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_89_BedrockRentalRoomBrowser()
	{
		return (object)new BedrockRentalRoomBrowser();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_90_ObservableCollection()
	{
		return new ObservableCollection<BedrockRentalRoomCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_91_Collection()
	{
		return new Collection<BedrockRentalRoomCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_95_BedrockServerBrowser()
	{
		return (object)new BedrockServerBrowser();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_96_ObservableCollection()
	{
		return new ObservableCollection<BedrockServerCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_97_Collection()
	{
		return new Collection<BedrockServerCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_100_BedrockSkinViewer()
	{
		return (object)new BedrockSkinViewer();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_101_SelectorBar()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new SelectorBar();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_103_SelectorBarItem()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new SelectorBarItem();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_104_ItemContainer()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new ItemContainer();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_105_BedrockSkinBrowser()
	{
		return (object)new BedrockSkinBrowser();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_106_ObservableCollection()
	{
		return new ObservableCollection<BedrockSkinCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_107_Collection()
	{
		return new Collection<BedrockSkinCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_113_JavaPackConversionBenefitsDialog()
	{
		return (object)new JavaPackConversionBenefitsDialog();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_114_JavaRuntimeProfilePanel()
	{
		return (object)new JavaRuntimeProfilePanel();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_115_PaymentBannerCarousel()
	{
		return (object)new PaymentBannerCarousel();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_116_PaymentBannerEditor()
	{
		return (object)new PaymentBannerEditor();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_117_RecentPaymentOrdersPanel()
	{
		return (object)new RecentPaymentOrdersPanel();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_118_ShutdownUploadOverlay()
	{
		return (object)new ShutdownUploadOverlay();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_119_BedrockToolsView()
	{
		return (object)new BedrockToolsView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_120_ItemsRepeater()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new ItemsRepeater();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_123_ItemCollectionTransitionProvider()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new ItemCollectionTransitionProvider();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_125_UniformGridLayout()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new UniformGridLayout();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_126_VirtualizingLayout()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new VirtualizingLayout();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_131_HwidSpoofToolsView()
	{
		return (object)new HwidSpoofToolsView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_132_UserRefundDetailView()
	{
		return (object)new UserRefundDetailView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_134_UserRefundRequestsView()
	{
		return (object)new UserRefundRequestsView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_135_AppWatermark()
	{
		return (object)new AppWatermark();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_136_RadialGradientBrush()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new RadialGradientBrush();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_144_AuthView()
	{
		return (object)new AuthView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_145_InfoBarHost()
	{
		return (object)new InfoBarHost();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_146_PersonPicture()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new PersonPicture();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_148_Contact()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new Contact();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_150_NavigationUserFooter()
	{
		return (object)new NavigationUserFooter();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_151_PagerBar()
	{
		return (object)new PagerBar();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_153_TitleBar()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new TitleBar();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_154_TitleBarTemplateSettings()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new TitleBarTemplateSettings();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_156_NavigationView()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new NavigationView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_164_NavigationViewTemplateSettings()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new NavigationViewTemplateSettings();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_165_NavigationViewItem()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new NavigationViewItem();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_167_InfoBadge()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new InfoBadge();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_168_NavigationViewItemHeader()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new NavigationViewItemHeader();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_169_ImageIconSource()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new ImageIconSource();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_171_AttachedCardShadow()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new AttachedCardShadow();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_175_AboutPage()
	{
		return (object)new AboutPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_176_AccountPage()
	{
		return (object)new AccountPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_177_BalanceHistoryPage()
	{
		return (object)new BalanceHistoryPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_178_NumberBox()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new NumberBox();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_185_BalancePage()
	{
		return (object)new BalancePage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_186_BedrockAccountPage()
	{
		return (object)new BedrockAccountPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_187_BedrockInstancesPage()
	{
		return (object)new BedrockInstancesPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_188_BedrockLocalMultiplayerPage()
	{
		return (object)new BedrockLocalMultiplayerPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_189_BedrockMaterialPackConverterPage()
	{
		return (object)new BedrockMaterialPackConverterPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_190_BedrockMaterialPacksPage()
	{
		return (object)new BedrockMaterialPacksPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_191_BedrockOnlineLobbyPage()
	{
		return (object)new BedrockOnlineLobbyPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_192_ObservableCollection()
	{
		return new ObservableCollection<en9Zr5faBGr6cyEG7MZ5>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_193_Collection()
	{
		return new Collection<en9Zr5faBGr6cyEG7MZ5>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_194_BedrockOnlineLobbyRoom()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new en9Zr5faBGr6cyEG7MZ5();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_195_BedrockRentalRoomsPage()
	{
		return (object)new BedrockRentalRoomsPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_196_BedrockServersPage()
	{
		return (object)new BedrockServersPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_197_BedrockSkinsPage()
	{
		return (object)new BedrockSkinsPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_198_BedrockVersionManagementPage()
	{
		return (object)new BedrockVersionManagementPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_199_BedrockWorldsPage()
	{
		return (object)new BedrockWorldsPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_200_DealerPage()
	{
		return (object)new DealerPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_201_HomePage()
	{
		return (object)new HomePage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_202_ObservableCollection()
	{
		return new ObservableCollection<TimelineEntry>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_203_Collection()
	{
		return new Collection<TimelineEntry>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_204_TimelineEntry()
	{
		return (object)new TimelineEntry();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_205_List()
	{
		return new List<TimelineNote>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_206_TimelineNote()
	{
		return (object)new TimelineNote();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_207_HookLoginPage()
	{
		return (object)new HookLoginPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_208_InvitationPage()
	{
		return (object)new InvitationPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_209_JavaAccountPage()
	{
		return (object)new JavaAccountPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_210_JavaCompatibilityInstancesPage()
	{
		return (object)new JavaCompatibilityInstancesPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_211_ObservableCollection()
	{
		return new ObservableCollection<rIp8CZfFJ2ofCfwfl3J2>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_212_Collection()
	{
		return new Collection<rIp8CZfFJ2ofCfwfl3J2>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_213_JavaInstanceInfo()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new rIp8CZfFJ2ofCfwfl3J2();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_219_ObservableCollection()
	{
		return new ObservableCollection<bq7k3qfN7qMnvLJMNOZa>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_220_Collection()
	{
		return new Collection<bq7k3qfN7qMnvLJMNOZa>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_226_JavaCompatibilityToolsPage()
	{
		return (object)new JavaCompatibilityToolsPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_227_JavaHookEntryPage()
	{
		return (object)new JavaHookEntryPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_228_JavaInstancesPage()
	{
		return (object)new JavaInstancesPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_229_JavaServersPage()
	{
		return (object)new JavaServersPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_230_ObservableCollection()
	{
		return new ObservableCollection<YlErsbfs35V4xTUvrlXK>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_231_Collection()
	{
		return new Collection<YlErsbfs35V4xTUvrlXK>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_232_JavaServer()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new YlErsbfs35V4xTUvrlXK();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_234_JavaSkinsPage()
	{
		return (object)new JavaSkinsPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_235_ObservableCollection()
	{
		return new ObservableCollection<JavaSkinCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_236_Collection()
	{
		return new Collection<JavaSkinCardViewModel>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_239_JavaVersionManagementPage()
	{
		return (object)new JavaVersionManagementPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_240_ObservableCollection()
	{
		return new ObservableCollection<WkLnWrfTRJdhyRBYcOwg>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_241_Collection()
	{
		return new Collection<WkLnWrfTRJdhyRBYcOwg>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_242_JavaVersionInstallationInfo()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new WkLnWrfTRJdhyRBYcOwg();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_245_MediaPage()
	{
		return (object)new MediaPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_246_Pay4399Page()
	{
		return (object)new Pay4399Page();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_247_ObservableCollection()
	{
		return new ObservableCollection<aMuqLcf6hnKdBTwYqLWe>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_248_Collection()
	{
		return new Collection<aMuqLcf6hnKdBTwYqLWe>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_249_Pay4399AccountRecord()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new aMuqLcf6hnKdBTwYqLWe();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_250_ObservableCollection()
	{
		return new ObservableCollection<pDLYXIf6mU1JnHirkJgm>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_251_Collection()
	{
		return new Collection<pDLYXIf6mU1JnHirkJgm>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_252_Pay4399PendingAccountRecord()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new pDLYXIf6mU1JnHirkJgm();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_254_PaymentCenterOrdersPage()
	{
		return (object)new PaymentCenterOrdersPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_255_PaymentCenterPage()
	{
		return (object)new PaymentCenterPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_256_PaymentCenterRefundsPage()
	{
		return (object)new PaymentCenterRefundsPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_257_PaymentOrdersPage()
	{
		return (object)new PaymentOrdersPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_258_ProductDetailPage()
	{
		return (object)new ProductDetailPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_261_ProductPage()
	{
		return (object)new ProductPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_262_QrLoginPage()
	{
		return (object)new QrLoginPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_263_RefundHistoryPage()
	{
		return (object)new RefundHistoryPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_264_ServiceSubscriptionsPage()
	{
		return (object)new ServiceSubscriptionsPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_265_ToolboxPage()
	{
		return (object)new ToolboxPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_266_X19LoginPage()
	{
		return (object)new X19LoginPage();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_267_ObservableCollection()
	{
		return new ObservableCollection<G87XFJfPfhylQ4RC1HmY>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_268_Collection()
	{
		return new Collection<G87XFJfPfhylQ4RC1HmY>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_269_X19AccountRecord()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new G87XFJfPfhylQ4RC1HmY();
	}

	[MethodImpl((MethodImplOptions)8)]
	private object Activate_270_TreeViewNode()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return (object)new TreeViewNode();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_0_XamlControlsResources()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.XamlControlsResources).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_4_PageHeader()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Shell.PageHeader).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_8_ProgressRing()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ProgressRing).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_11_ProgressRingTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ProgressRingTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_13_SmsVerificationView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.SmsVerificationView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_14_InfoBar()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.InfoBar).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_15_InfoBarSeverity()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.InfoBarSeverity).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_16_Enum()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Enum).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_17_ValueType()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.ValueType).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_19_ICommand()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Windows.Input.ICommand).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_23_InfoBarTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.InfoBarTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_24_BedrockAccountHistoryView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_25_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<BedrockAccountHistoryItemViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_26_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<BedrockAccountHistoryItemViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_27_BedrockAccountHistoryItemViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_30_ClassicAccountPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::P4nQc8LxjCxnxuINJP5.BpOjxVLPwPUO93lZkbW).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_32_ProgressBar()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ProgressBar).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_34_ProgressBarTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ProgressBarTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_35_ClassicDownloadsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::uj1PrqjB4rcHFMlFGdp.iv7VBsjI8muRaeK8cVn).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_36_ClassicLaunchPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::D5dq98Zj0UIlWLL7BDu.BFW7DwZLAOwBnfcMB57).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_37_TabView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TabView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_38_IList()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Collections.Generic.IList<object>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_39_TabViewWidthMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TabViewWidthMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_40_TabViewCloseButtonOverlayMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_43_TabViewItem()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TabViewItem).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_46_TabViewItemTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_47_Expander()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.Expander).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_48_ExpandDirection()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ExpandDirection).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_49_ExpanderTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ExpanderTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_50_McpStudioPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Features.McpStudio.Views.McpStudioPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_51_ShellView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Shell.ShellView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_53_MainWindow()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.MainWindow).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_55_BedrockAccountProfileDetailDialog()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailDialog).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_57_BedrockAccountProfileDetailViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_58_WebView2()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.WebView2).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_60_Color()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Windows.UI.Color).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_61_CoreWebView2()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.Web.WebView2.Core.CoreWebView2).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_62_Uri()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Uri).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_63_BedrockNetworkImage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_65_BedrockFourDimensionalViewer()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockFourDimensionalViewer).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_66_BedrockInstanceList()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceList).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_67_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<BedrockInstanceCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_68_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<BedrockInstanceCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_69_BedrockInstanceCardViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_70_BedrockInstanceInfo()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::i6TlJMfuChv2AjPXr7O8.zG6ueUfuQUk6CEmxLYji).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_71_BedrockRelaySnapshot()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::nyJeB7f0q9CPYw2lLbou.MFIPycf02g29tSkCEJDk).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_72_BedrockLocalLobbyBrowser()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyBrowser).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_73_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<BedrockLocalLobbyRoomCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_74_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<BedrockLocalLobbyRoomCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_75_BedrockLocalLobbyRoomCardViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_76_BedrockLocalLobbyRoom()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::zCVMnbfabiR2jSY2xUjH.cwSYjVfuzDOvn8hKeZih).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_77_BedrockMaterialPackBrowser()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackBrowser).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_78_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<BedrockMaterialPackViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_79_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<BedrockMaterialPackViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_80_BedrockMaterialPackViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_81_BedrockMaterialPack()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::nW2Sekfay3BSEMMb8toe.WQh695fa8bRtqyh4inIH).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_82_SettingsExpander()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CommunityToolkit.WinUI.Controls.SettingsExpander).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_86_SettingsCard()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CommunityToolkit.WinUI.Controls.SettingsCard).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_87_ContentAlignment()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CommunityToolkit.WinUI.Controls.ContentAlignment).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_88_BedrockProxySettingsView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockProxySettingsView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_89_BedrockRentalRoomBrowser()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_90_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<BedrockRentalRoomCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_91_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<BedrockRentalRoomCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_92_BedrockRentalRoomCardViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_93_BedrockRentalRoom()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::yun8CRfanLkaBpPLfVrd.DAoPoufaie63jNVdbNug).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_94_BedrockRelayBindScope()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::fZGimHf0suVRPkaXFQcr.mpVm6bf0F2Qxo2jn2O2u).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_95_BedrockServerBrowser()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_96_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<BedrockServerCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_97_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<BedrockServerCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_98_BedrockServerCardViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_99_BedrockServer()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::ROZe5Gf1WgRr9IZ64gbr.wjHCLDf1ydVEraHow39U).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_100_BedrockSkinViewer()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockSkinViewer).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_101_SelectorBar()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.SelectorBar).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_102_IList()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Collections.Generic.IList<SelectorBarItem>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_103_SelectorBarItem()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.SelectorBarItem).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_104_ItemContainer()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ItemContainer).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_105_BedrockSkinBrowser()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockSkinBrowser).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_106_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<BedrockSkinCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_107_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<BedrockSkinCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_108_BedrockSkinCardViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_109_BedrockAppearanceKind()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::EBJLMifNn8QeuhMRSx7U.p1aif0fNieMbuxR5AlNF).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_110_BedrockFreeSkin()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::ajau5tfpTXRk8mjlQPRa.ejKX8wfpsw8ins4MWI7J).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_111_BedrockFourDimensionalSkin()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::VE4SD3fpOtryqPu1jwJE.dZU6g2fptC4VZ350fMxJ).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_112_BedrockFourDimensionalPart()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::xsbjKUfp9um80Gf8YymA.m4wFTFfpZW4pcAqQZC1k).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_113_JavaPackConversionBenefitsDialog()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Bedrock.JavaPackConversionBenefitsDialog).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_114_JavaRuntimeProfilePanel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Java.JavaRuntimeProfilePanel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_115_PaymentBannerCarousel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.PaymentBannerCarousel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_116_PaymentBannerEditor()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.PaymentBannerEditor).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_117_RecentPaymentOrdersPanel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.RecentPaymentOrdersPanel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_118_ShutdownUploadOverlay()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.ShutdownUploadOverlay).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_119_BedrockToolsView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Toolbox.BedrockToolsView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_120_ItemsRepeater()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ItemsRepeater).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_121_Layout()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.Layout).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_123_ItemCollectionTransitionProvider()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_124_ItemsSourceView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ItemsSourceView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_125_UniformGridLayout()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayout).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_126_VirtualizingLayout()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.VirtualizingLayout).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_127_UniformGridLayoutItemsJustification()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_128_UniformGridLayoutItemsStretch()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_130_IndexBasedLayoutOrientation()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.IndexBasedLayoutOrientation).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_131_HwidSpoofToolsView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Toolbox.HwidSpoofToolsView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_132_UserRefundDetailView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.UserRefundDetailView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_133_UserRefundRequestDialog()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.UserRefundRequestDialog).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_134_UserRefundRequestsView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.UserRefundRequestsView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_135_AppWatermark()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Shell.AppWatermark).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_136_RadialGradientBrush()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Media.RadialGradientBrush).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_138_IObservableVector()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(IObservableVector<GradientStop>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_141_CompositionColorSpace()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Composition.CompositionColorSpace).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_144_AuthView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Shell.AuthView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_145_InfoBarHost()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Shell.InfoBarHost).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_146_PersonPicture()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.PersonPicture).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_148_Contact()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Windows.ApplicationModel.Contacts.Contact).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_149_PersonPictureTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.PersonPictureTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_150_NavigationUserFooter()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Shell.NavigationUserFooter).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_151_PagerBar()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Shell.PagerBar).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_152_Thickness()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Thickness).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_153_TitleBar()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TitleBar).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_154_TitleBarTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TitleBarTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_155_Nullable()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(bool?).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_156_NavigationView()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationView).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_157_NavigationViewBackButtonVisible()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_158_NavigationViewPaneDisplayMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_160_NavigationViewDisplayMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewDisplayMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_161_NavigationViewOverflowLabelMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_162_NavigationViewSelectionFollowsFocus()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewSelectionFollowsFocus).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_163_NavigationViewShoulderNavigationEnabled()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_164_NavigationViewTemplateSettings()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_165_NavigationViewItem()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewItem).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_166_NavigationViewItemBase()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewItemBase).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_167_InfoBadge()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.InfoBadge).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_168_NavigationViewItemHeader()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NavigationViewItemHeader).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_169_ImageIconSource()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.ImageIconSource).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_170_CornerRadius()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.CornerRadius).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_171_AttachedCardShadow()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CommunityToolkit.WinUI.Media.AttachedCardShadow).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_172_AttachedShadowBase()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CommunityToolkit.WinUI.AttachedShadowBase).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_173_InnerContentClipMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CommunityToolkit.WinUI.Media.InnerContentClipMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_174_Byte()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Byte).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_175_AboutPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.AboutPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_176_AccountPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.AccountPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_177_BalanceHistoryPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.BalanceHistoryPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_178_NumberBox()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NumberBox).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_179_INumberFormatter2()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Windows.Globalization.NumberFormatting.INumberFormatter2).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_182_NumberBoxSpinButtonPlacementMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NumberBoxSpinButtonPlacementMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_184_NumberBoxValidationMode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.NumberBoxValidationMode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_185_BalancePage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.BalancePage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_186_BedrockAccountPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockAccountPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_187_BedrockInstancesPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockInstancesPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_188_BedrockLocalMultiplayerPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockLocalMultiplayerPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_189_BedrockMaterialPackConverterPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPackConverterPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_190_BedrockMaterialPacksPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPacksPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_191_BedrockOnlineLobbyPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockOnlineLobbyPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_192_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<en9Zr5faBGr6cyEG7MZ5>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_193_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<en9Zr5faBGr6cyEG7MZ5>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_194_BedrockOnlineLobbyRoom()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::pZg6QPfag7jmC8rKUG4i.en9Zr5faBGr6cyEG7MZ5).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_195_BedrockRentalRoomsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockRentalRoomsPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_196_BedrockServersPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockServersPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_197_BedrockSkinsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockSkinsPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_198_BedrockVersionManagementPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockVersionManagementPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_199_BedrockWorldsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockWorldsPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_200_DealerPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.DealerPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_201_HomePage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.HomePage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_202_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<TimelineEntry>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_203_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<TimelineEntry>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_204_TimelineEntry()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.TimelineEntry).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_205_List()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(List<TimelineNote>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_206_TimelineNote()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.TimelineNote).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_207_HookLoginPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.HookLoginPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_208_InvitationPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.InvitationPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_209_JavaAccountPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaAccountPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_210_JavaCompatibilityInstancesPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaCompatibilityInstancesPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_211_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<rIp8CZfFJ2ofCfwfl3J2>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_212_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<rIp8CZfFJ2ofCfwfl3J2>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_213_JavaInstanceInfo()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::IU7UTPfFQa3t5mwomQTu.rIp8CZfFJ2ofCfwfl3J2).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_214_DateTimeOffset()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.DateTimeOffset).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_215_JavaInstanceState()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::qUVWohfFWy6g8p9LphlU.ehKrWCfFyUBmIViVuUtd).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_216_Nullable()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(int?).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_217_IReadOnlyList()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Collections.Generic.IReadOnlyList<string>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_218_JavaCrashReport()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::U4i16dfxBhWhZfMZrtVY.wY9sp7fxIKIZJMsRVskD).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_219_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<bq7k3qfN7qMnvLJMNOZa>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_220_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<bq7k3qfN7qMnvLJMNOZa>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_221_JavaProxyInstanceSnapshot()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::rEWmcPfNAhtZSJjsJvk3.bq7k3qfN7qMnvLJMNOZa).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_222_JavaProxyInstanceState()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::EGjGpPfNQ5sRCSMK7KqW.n1qKx2fNJL9msKD7ZGJu).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_223_JavaProxyEndpoint()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::UchfG8fTzhAHMiok6Yk0.tevrq6fTnmxdv0004lXm).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_224_JavaProxyTrafficSnapshot()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::b7C8sgfNUlsIIZiFPiE3.I8UL5cfNhu2cgReqF3g8).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_225_JavaProxyDisconnectReason()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::BdZQbJfN4H4AgIYemOL6.f3JeIyfNCcv94eShPUIb).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_226_JavaCompatibilityToolsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaCompatibilityToolsPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_227_JavaHookEntryPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaHookEntryPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_228_JavaInstancesPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaInstancesPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_229_JavaServersPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaServersPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_230_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<YlErsbfs35V4xTUvrlXK>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_231_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<YlErsbfs35V4xTUvrlXK>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_232_JavaServer()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::sIIqaHfsvUMJoArTBa4b.YlErsbfs35V4xTUvrlXK).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_233_IReadOnlyList()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Collections.Generic.IReadOnlyList<ys1lxxfFBPhowwZS5N6T>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_234_JavaSkinsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaSkinsPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_235_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<JavaSkinCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_236_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<JavaSkinCardViewModel>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_237_JavaSkinCardViewModel()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_238_JavaSkin()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::kTag3lfTQlMnWtlhqJue.gcmmptfTJGk6dCBYHIl7).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_239_JavaVersionManagementPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Java.JavaVersionManagementPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_240_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<WkLnWrfTRJdhyRBYcOwg>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_241_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<WkLnWrfTRJdhyRBYcOwg>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_242_JavaVersionInstallationInfo()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::kq2pipfTwPkE4qWLSUgF.WkLnWrfTRJdhyRBYcOwg).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_243_JavaMinecraftVersion()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::bVyVYtfFgCItGPihJweI.ys1lxxfFBPhowwZS5N6T).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_244_JavaRuntimeProfile()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::c2D37HfsFbaPpJo3F98A.uKGDFFfsxYJUyNmtk1xA).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_245_MediaPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.MediaPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_246_Pay4399Page()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.Pay4399Page).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_247_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<aMuqLcf6hnKdBTwYqLWe>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_248_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<aMuqLcf6hnKdBTwYqLWe>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_249_Pay4399AccountRecord()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::N9UVEvf6UHvBucn1bopm.aMuqLcf6hnKdBTwYqLWe).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_250_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<pDLYXIf6mU1JnHirkJgm>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_251_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<pDLYXIf6mU1JnHirkJgm>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_252_Pay4399PendingAccountRecord()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::P0graHf67FHLhLQyDEVV.pDLYXIf6mU1JnHirkJgm).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_253_Decimal()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Decimal).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_254_PaymentCenterOrdersPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.PaymentCenterOrdersPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_255_PaymentCenterPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.PaymentCenterPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_256_PaymentCenterRefundsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.PaymentCenterRefundsPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_257_PaymentOrdersPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.PaymentOrdersPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_258_ProductDetailPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.ProductDetailPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_259_Motion()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.UI.Motion).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_260_Effects()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CommunityToolkit.WinUI.Effects).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_261_ProductPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.ProductPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_262_QrLoginPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.QrLoginPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_263_RefundHistoryPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.RefundHistoryPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_264_ServiceSubscriptionsPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.ServiceSubscriptionsPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_265_ToolboxPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.ToolboxPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_266_X19LoginPage()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Mahiro_Account.Views.Pages.X19LoginPage).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_267_ObservableCollection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(ObservableCollection<G87XFJfPfhylQ4RC1HmY>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_268_Collection()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(Collection<G87XFJfPfhylQ4RC1HmY>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_269_X19AccountRecord()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::CGTgWZfPLqikrZ4Zv8WL.G87XFJfPfhylQ4RC1HmY).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_270_TreeViewNode()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::Microsoft.UI.Xaml.Controls.TreeViewNode).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StaticInitializer_271_IList()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.RunClassConstructor(typeof(global::System.Collections.Generic.IList<TreeViewNode>).TypeHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void MapAdd_0_XamlControlsResources(object instance, object key, object item)
	{
		((IDictionary<object, object>)instance).Add(key, item);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_25_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockAccountHistoryItemViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockAccountHistoryItemViewModel>)instance;
		BedrockAccountHistoryItemViewModel bedrockAccountHistoryItemViewModel = (BedrockAccountHistoryItemViewModel)item;
		obj.Add(bedrockAccountHistoryItemViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_26_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockAccountHistoryItemViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockAccountHistoryItemViewModel>)instance;
		BedrockAccountHistoryItemViewModel bedrockAccountHistoryItemViewModel = (BedrockAccountHistoryItemViewModel)item;
		obj.Add(bedrockAccountHistoryItemViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_38_IList(object instance, object item)
	{
		((global::System.Collections.Generic.ICollection<object>)instance).Add(item);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_67_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockInstanceCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockInstanceCardViewModel>)instance;
		BedrockInstanceCardViewModel bedrockInstanceCardViewModel = (BedrockInstanceCardViewModel)item;
		obj.Add(bedrockInstanceCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_68_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockInstanceCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockInstanceCardViewModel>)instance;
		BedrockInstanceCardViewModel bedrockInstanceCardViewModel = (BedrockInstanceCardViewModel)item;
		obj.Add(bedrockInstanceCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_73_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockLocalLobbyRoomCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockLocalLobbyRoomCardViewModel>)instance;
		BedrockLocalLobbyRoomCardViewModel bedrockLocalLobbyRoomCardViewModel = (BedrockLocalLobbyRoomCardViewModel)item;
		obj.Add(bedrockLocalLobbyRoomCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_74_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockLocalLobbyRoomCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockLocalLobbyRoomCardViewModel>)instance;
		BedrockLocalLobbyRoomCardViewModel bedrockLocalLobbyRoomCardViewModel = (BedrockLocalLobbyRoomCardViewModel)item;
		obj.Add(bedrockLocalLobbyRoomCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_78_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockMaterialPackViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockMaterialPackViewModel>)instance;
		BedrockMaterialPackViewModel bedrockMaterialPackViewModel = (BedrockMaterialPackViewModel)item;
		obj.Add(bedrockMaterialPackViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_79_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockMaterialPackViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockMaterialPackViewModel>)instance;
		BedrockMaterialPackViewModel bedrockMaterialPackViewModel = (BedrockMaterialPackViewModel)item;
		obj.Add(bedrockMaterialPackViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_90_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockRentalRoomCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockRentalRoomCardViewModel>)instance;
		BedrockRentalRoomCardViewModel bedrockRentalRoomCardViewModel = (BedrockRentalRoomCardViewModel)item;
		obj.Add(bedrockRentalRoomCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_91_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockRentalRoomCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockRentalRoomCardViewModel>)instance;
		BedrockRentalRoomCardViewModel bedrockRentalRoomCardViewModel = (BedrockRentalRoomCardViewModel)item;
		obj.Add(bedrockRentalRoomCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_96_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockServerCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockServerCardViewModel>)instance;
		BedrockServerCardViewModel bedrockServerCardViewModel = (BedrockServerCardViewModel)item;
		obj.Add(bedrockServerCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_97_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockServerCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockServerCardViewModel>)instance;
		BedrockServerCardViewModel bedrockServerCardViewModel = (BedrockServerCardViewModel)item;
		obj.Add(bedrockServerCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_102_IList(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<SelectorBarItem> obj = (global::System.Collections.Generic.ICollection<SelectorBarItem>)instance;
		SelectorBarItem val = (SelectorBarItem)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_106_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockSkinCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockSkinCardViewModel>)instance;
		BedrockSkinCardViewModel bedrockSkinCardViewModel = (BedrockSkinCardViewModel)item;
		obj.Add(bedrockSkinCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_107_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<BedrockSkinCardViewModel> obj = (global::System.Collections.Generic.ICollection<BedrockSkinCardViewModel>)instance;
		BedrockSkinCardViewModel bedrockSkinCardViewModel = (BedrockSkinCardViewModel)item;
		obj.Add(bedrockSkinCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_138_IObservableVector(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<GradientStop> obj = (global::System.Collections.Generic.ICollection<GradientStop>)instance;
		GradientStop val = (GradientStop)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_192_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<en9Zr5faBGr6cyEG7MZ5> obj = (global::System.Collections.Generic.ICollection<en9Zr5faBGr6cyEG7MZ5>)instance;
		en9Zr5faBGr6cyEG7MZ5 val = (en9Zr5faBGr6cyEG7MZ5)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_193_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<en9Zr5faBGr6cyEG7MZ5> obj = (global::System.Collections.Generic.ICollection<en9Zr5faBGr6cyEG7MZ5>)instance;
		en9Zr5faBGr6cyEG7MZ5 val = (en9Zr5faBGr6cyEG7MZ5)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_202_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<TimelineEntry> obj = (global::System.Collections.Generic.ICollection<TimelineEntry>)instance;
		TimelineEntry timelineEntry = (TimelineEntry)item;
		obj.Add(timelineEntry);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_203_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<TimelineEntry> obj = (global::System.Collections.Generic.ICollection<TimelineEntry>)instance;
		TimelineEntry timelineEntry = (TimelineEntry)item;
		obj.Add(timelineEntry);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_205_List(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<TimelineNote> obj = (global::System.Collections.Generic.ICollection<TimelineNote>)instance;
		TimelineNote timelineNote = (TimelineNote)item;
		obj.Add(timelineNote);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_211_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<rIp8CZfFJ2ofCfwfl3J2> obj = (global::System.Collections.Generic.ICollection<rIp8CZfFJ2ofCfwfl3J2>)instance;
		rIp8CZfFJ2ofCfwfl3J2 val = (rIp8CZfFJ2ofCfwfl3J2)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_212_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<rIp8CZfFJ2ofCfwfl3J2> obj = (global::System.Collections.Generic.ICollection<rIp8CZfFJ2ofCfwfl3J2>)instance;
		rIp8CZfFJ2ofCfwfl3J2 val = (rIp8CZfFJ2ofCfwfl3J2)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_219_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<bq7k3qfN7qMnvLJMNOZa> obj = (global::System.Collections.Generic.ICollection<bq7k3qfN7qMnvLJMNOZa>)instance;
		bq7k3qfN7qMnvLJMNOZa val = (bq7k3qfN7qMnvLJMNOZa)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_220_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<bq7k3qfN7qMnvLJMNOZa> obj = (global::System.Collections.Generic.ICollection<bq7k3qfN7qMnvLJMNOZa>)instance;
		bq7k3qfN7qMnvLJMNOZa val = (bq7k3qfN7qMnvLJMNOZa)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_230_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<YlErsbfs35V4xTUvrlXK> obj = (global::System.Collections.Generic.ICollection<YlErsbfs35V4xTUvrlXK>)instance;
		YlErsbfs35V4xTUvrlXK val = (YlErsbfs35V4xTUvrlXK)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_231_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<YlErsbfs35V4xTUvrlXK> obj = (global::System.Collections.Generic.ICollection<YlErsbfs35V4xTUvrlXK>)instance;
		YlErsbfs35V4xTUvrlXK val = (YlErsbfs35V4xTUvrlXK)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_235_ObservableCollection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<JavaSkinCardViewModel> obj = (global::System.Collections.Generic.ICollection<JavaSkinCardViewModel>)instance;
		JavaSkinCardViewModel javaSkinCardViewModel = (JavaSkinCardViewModel)item;
		obj.Add(javaSkinCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_236_Collection(object instance, object item)
	{
		global::System.Collections.Generic.ICollection<JavaSkinCardViewModel> obj = (global::System.Collections.Generic.ICollection<JavaSkinCardViewModel>)instance;
		JavaSkinCardViewModel javaSkinCardViewModel = (JavaSkinCardViewModel)item;
		obj.Add(javaSkinCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_240_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<WkLnWrfTRJdhyRBYcOwg> obj = (global::System.Collections.Generic.ICollection<WkLnWrfTRJdhyRBYcOwg>)instance;
		WkLnWrfTRJdhyRBYcOwg val = (WkLnWrfTRJdhyRBYcOwg)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_241_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<WkLnWrfTRJdhyRBYcOwg> obj = (global::System.Collections.Generic.ICollection<WkLnWrfTRJdhyRBYcOwg>)instance;
		WkLnWrfTRJdhyRBYcOwg val = (WkLnWrfTRJdhyRBYcOwg)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_247_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<aMuqLcf6hnKdBTwYqLWe> obj = (global::System.Collections.Generic.ICollection<aMuqLcf6hnKdBTwYqLWe>)instance;
		aMuqLcf6hnKdBTwYqLWe val = (aMuqLcf6hnKdBTwYqLWe)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_248_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<aMuqLcf6hnKdBTwYqLWe> obj = (global::System.Collections.Generic.ICollection<aMuqLcf6hnKdBTwYqLWe>)instance;
		aMuqLcf6hnKdBTwYqLWe val = (aMuqLcf6hnKdBTwYqLWe)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_250_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<pDLYXIf6mU1JnHirkJgm> obj = (global::System.Collections.Generic.ICollection<pDLYXIf6mU1JnHirkJgm>)instance;
		pDLYXIf6mU1JnHirkJgm val = (pDLYXIf6mU1JnHirkJgm)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_251_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<pDLYXIf6mU1JnHirkJgm> obj = (global::System.Collections.Generic.ICollection<pDLYXIf6mU1JnHirkJgm>)instance;
		pDLYXIf6mU1JnHirkJgm val = (pDLYXIf6mU1JnHirkJgm)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_267_ObservableCollection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<G87XFJfPfhylQ4RC1HmY> obj = (global::System.Collections.Generic.ICollection<G87XFJfPfhylQ4RC1HmY>)instance;
		G87XFJfPfhylQ4RC1HmY val = (G87XFJfPfhylQ4RC1HmY)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_268_Collection(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<G87XFJfPfhylQ4RC1HmY> obj = (global::System.Collections.Generic.ICollection<G87XFJfPfhylQ4RC1HmY>)instance;
		G87XFJfPfhylQ4RC1HmY val = (G87XFJfPfhylQ4RC1HmY)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VectorAdd_271_IList(object instance, object item)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		global::System.Collections.Generic.ICollection<TreeViewNode> obj = (global::System.Collections.Generic.ICollection<TreeViewNode>)instance;
		TreeViewNode val = (TreeViewNode)item;
		obj.Add(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private IXamlType CreateXamlType(int typeIndex)
	{
		XamlSystemBaseType result = null;
		string fullName = _typeNameTable[typeIndex];
		global::System.Type type = _typeTable[typeIndex];
		switch (typeIndex)
		{
		case 0:
		{
			object xamlUserType210 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.ResourceDictionary"));
			((XamlUserType)xamlUserType210).Activator = Activate_0_XamlControlsResources;
			((XamlUserType)xamlUserType210).StaticInitializer = StaticInitializer_0_XamlControlsResources;
			((XamlUserType)xamlUserType210).DictionaryAdd = MapAdd_0_XamlControlsResources;
			((XamlUserType)xamlUserType210).AddMemberName("UseCompactResources");
			result = (XamlSystemBaseType)xamlUserType210;
			break;
		}
		case 1:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 2:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 3:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 4:
		{
			object xamlUserType209 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType209).Activator = Activate_4_PageHeader;
			((XamlUserType)xamlUserType209).StaticInitializer = StaticInitializer_4_PageHeader;
			((XamlUserType)xamlUserType209).AddMemberName("Title");
			((XamlUserType)xamlUserType209).AddMemberName("Subtitle");
			((XamlUserType)xamlUserType209).AddMemberName("Actions");
			((XamlUserType)xamlUserType209).AddMemberName("HasSubtitle");
			((XamlUserType)xamlUserType209).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType209;
			break;
		}
		case 5:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 6:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 7:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 8:
		{
			object xamlUserType208 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType208).Activator = Activate_8_ProgressRing;
			((XamlUserType)xamlUserType208).StaticInitializer = StaticInitializer_8_ProgressRing;
			((XamlUserType)xamlUserType208).AddMemberName("IsActive");
			((XamlUserType)xamlUserType208).AddMemberName("IsIndeterminate");
			((XamlUserType)xamlUserType208).AddMemberName("Maximum");
			((XamlUserType)xamlUserType208).AddMemberName("Minimum");
			((XamlUserType)xamlUserType208).AddMemberName("TemplateSettings");
			((XamlUserType)xamlUserType208).AddMemberName("Value");
			result = (XamlSystemBaseType)xamlUserType208;
			break;
		}
		case 9:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 10:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 11:
		{
			object xamlUserType207 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType207).StaticInitializer = StaticInitializer_11_ProgressRingTemplateSettings;
			((XamlUserType)xamlUserType207).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType207;
			break;
		}
		case 12:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 13:
		{
			object xamlUserType206 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType206).Activator = Activate_13_SmsVerificationView;
			((XamlUserType)xamlUserType206).StaticInitializer = StaticInitializer_13_SmsVerificationView;
			((XamlUserType)xamlUserType206).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType206;
			break;
		}
		case 14:
		{
			object xamlUserType205 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType205).Activator = Activate_14_InfoBar;
			((XamlUserType)xamlUserType205).StaticInitializer = StaticInitializer_14_InfoBar;
			((XamlUserType)xamlUserType205).SetContentPropertyName("Microsoft.UI.Xaml.Controls.InfoBar.Content");
			((XamlUserType)xamlUserType205).AddMemberName("Content");
			((XamlUserType)xamlUserType205).AddMemberName("IsOpen");
			((XamlUserType)xamlUserType205).AddMemberName("IsClosable");
			((XamlUserType)xamlUserType205).AddMemberName("Severity");
			((XamlUserType)xamlUserType205).AddMemberName("Title");
			((XamlUserType)xamlUserType205).AddMemberName("Message");
			((XamlUserType)xamlUserType205).AddMemberName("ActionButton");
			((XamlUserType)xamlUserType205).AddMemberName("CloseButtonCommand");
			((XamlUserType)xamlUserType205).AddMemberName("CloseButtonCommandParameter");
			((XamlUserType)xamlUserType205).AddMemberName("CloseButtonStyle");
			((XamlUserType)xamlUserType205).AddMemberName("ContentTemplate");
			((XamlUserType)xamlUserType205).AddMemberName("IconSource");
			((XamlUserType)xamlUserType205).AddMemberName("IsIconVisible");
			((XamlUserType)xamlUserType205).AddMemberName("TemplateSettings");
			result = (XamlSystemBaseType)xamlUserType205;
			break;
		}
		case 15:
		{
			object xamlUserType204 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType204).StaticInitializer = StaticInitializer_15_InfoBarSeverity;
			((XamlUserType)xamlUserType204).AddEnumValue("Informational", (object)(InfoBarSeverity)0);
			((XamlUserType)xamlUserType204).AddEnumValue("Success", (object)(InfoBarSeverity)1);
			((XamlUserType)xamlUserType204).AddEnumValue("Warning", (object)(InfoBarSeverity)2);
			((XamlUserType)xamlUserType204).AddEnumValue("Error", (object)(InfoBarSeverity)3);
			result = (XamlSystemBaseType)xamlUserType204;
			break;
		}
		case 16:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"))
			{
				StaticInitializer = StaticInitializer_16_Enum
			};
			break;
		case 17:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				StaticInitializer = StaticInitializer_17_ValueType
			};
			break;
		case 18:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 19:
		{
			object xamlUserType203 = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType203).StaticInitializer = StaticInitializer_19_ICommand;
			((XamlUserType)xamlUserType203).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType203;
			break;
		}
		case 20:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 21:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 22:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 23:
		{
			object xamlUserType202 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType202).StaticInitializer = StaticInitializer_23_InfoBarTemplateSettings;
			((XamlUserType)xamlUserType202).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType202;
			break;
		}
		case 24:
		{
			object xamlUserType201 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType201).Activator = Activate_24_BedrockAccountHistoryView;
			((XamlUserType)xamlUserType201).StaticInitializer = StaticInitializer_24_BedrockAccountHistoryView;
			((XamlUserType)xamlUserType201).AddMemberName("Accounts");
			((XamlUserType)xamlUserType201).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType201;
			break;
		}
		case 25:
		{
			object xamlUserType200 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel>"));
			((XamlUserType)xamlUserType200).StaticInitializer = StaticInitializer_25_ObservableCollection;
			((XamlUserType)xamlUserType200).CollectionAdd = VectorAdd_25_ObservableCollection;
			((XamlUserType)xamlUserType200).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType200;
			break;
		}
		case 26:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_26_Collection,
				StaticInitializer = StaticInitializer_26_Collection,
				CollectionAdd = VectorAdd_26_Collection
			};
			break;
		case 27:
		{
			object xamlUserType199 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType199).StaticInitializer = StaticInitializer_27_BedrockAccountHistoryItemViewModel;
			((XamlUserType)xamlUserType199).AddMemberName("Id");
			((XamlUserType)xamlUserType199).AddMemberName("GameUserId");
			((XamlUserType)xamlUserType199).AddMemberName("DisplayName");
			((XamlUserType)xamlUserType199).AddMemberName("AccountDisplayText");
			((XamlUserType)xamlUserType199).AddMemberName("SavedAtValueText");
			((XamlUserType)xamlUserType199).AddMemberName("IsDetailsEnabled");
			((XamlUserType)xamlUserType199).AddMemberName("AvatarSource");
			((XamlUserType)xamlUserType199).AddMemberName("FrameSource");
			((XamlUserType)xamlUserType199).AddMemberName("FrameVisibility");
			((XamlUserType)xamlUserType199).AddMemberName("GrowthVisibility");
			((XamlUserType)xamlUserType199).AddMemberName("MissingGrowthVisibility");
			((XamlUserType)xamlUserType199).AddMemberName("VipVisibility");
			((XamlUserType)xamlUserType199).AddMemberName("SecondaryText");
			((XamlUserType)xamlUserType199).AddMemberName("LevelText");
			((XamlUserType)xamlUserType199).AddMemberName("VipText");
			((XamlUserType)xamlUserType199).AddMemberName("ExperienceText");
			((XamlUserType)xamlUserType199).AddMemberName("ExperienceMaximum");
			((XamlUserType)xamlUserType199).AddMemberName("ExperienceValue");
			((XamlUserType)xamlUserType199).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType199;
			break;
		}
		case 28:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 29:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 30:
		{
			object xamlUserType198 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType198).Activator = Activate_30_ClassicAccountPage;
			((XamlUserType)xamlUserType198).StaticInitializer = StaticInitializer_30_ClassicAccountPage;
			((XamlUserType)xamlUserType198).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType198;
			break;
		}
		case 31:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 32:
		{
			object xamlUserType197 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Primitives.RangeBase"));
			((XamlUserType)xamlUserType197).Activator = Activate_32_ProgressBar;
			((XamlUserType)xamlUserType197).StaticInitializer = StaticInitializer_32_ProgressBar;
			((XamlUserType)xamlUserType197).AddMemberName("IsIndeterminate");
			((XamlUserType)xamlUserType197).AddMemberName("ShowError");
			((XamlUserType)xamlUserType197).AddMemberName("ShowPaused");
			((XamlUserType)xamlUserType197).AddMemberName("TemplateSettings");
			result = (XamlSystemBaseType)xamlUserType197;
			break;
		}
		case 33:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 34:
		{
			object xamlUserType196 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType196).StaticInitializer = StaticInitializer_34_ProgressBarTemplateSettings;
			((XamlUserType)xamlUserType196).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType196;
			break;
		}
		case 35:
		{
			object xamlUserType195 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType195).Activator = Activate_35_ClassicDownloadsPage;
			((XamlUserType)xamlUserType195).StaticInitializer = StaticInitializer_35_ClassicDownloadsPage;
			((XamlUserType)xamlUserType195).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType195;
			break;
		}
		case 36:
		{
			object xamlUserType194 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType194).Activator = Activate_36_ClassicLaunchPage;
			((XamlUserType)xamlUserType194).StaticInitializer = StaticInitializer_36_ClassicLaunchPage;
			((XamlUserType)xamlUserType194).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType194;
			break;
		}
		case 37:
		{
			object xamlUserType193 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType193).Activator = Activate_37_TabView;
			((XamlUserType)xamlUserType193).StaticInitializer = StaticInitializer_37_TabView;
			((XamlUserType)xamlUserType193).SetContentPropertyName("Microsoft.UI.Xaml.Controls.TabView.TabItems");
			((XamlUserType)xamlUserType193).AddMemberName("TabItems");
			((XamlUserType)xamlUserType193).AddMemberName("IsAddTabButtonVisible");
			((XamlUserType)xamlUserType193).AddMemberName("CanDragTabs");
			((XamlUserType)xamlUserType193).AddMemberName("CanReorderTabs");
			((XamlUserType)xamlUserType193).AddMemberName("TabWidthMode");
			((XamlUserType)xamlUserType193).AddMemberName("AddTabButtonCommand");
			((XamlUserType)xamlUserType193).AddMemberName("AddTabButtonCommandParameter");
			((XamlUserType)xamlUserType193).AddMemberName("AllowDropTabs");
			((XamlUserType)xamlUserType193).AddMemberName("CanTearOutTabs");
			((XamlUserType)xamlUserType193).AddMemberName("CloseButtonOverlayMode");
			((XamlUserType)xamlUserType193).AddMemberName("SelectedIndex");
			((XamlUserType)xamlUserType193).AddMemberName("SelectedItem");
			((XamlUserType)xamlUserType193).AddMemberName("TabItemTemplate");
			((XamlUserType)xamlUserType193).AddMemberName("TabItemTemplateSelector");
			((XamlUserType)xamlUserType193).AddMemberName("TabItemsSource");
			((XamlUserType)xamlUserType193).AddMemberName("TabStripFooter");
			((XamlUserType)xamlUserType193).AddMemberName("TabStripFooterTemplate");
			((XamlUserType)xamlUserType193).AddMemberName("TabStripHeader");
			((XamlUserType)xamlUserType193).AddMemberName("TabStripHeaderTemplate");
			result = (XamlSystemBaseType)xamlUserType193;
			break;
		}
		case 38:
		{
			object xamlUserType192 = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType192).StaticInitializer = StaticInitializer_38_IList;
			((XamlUserType)xamlUserType192).CollectionAdd = VectorAdd_38_IList;
			((XamlUserType)xamlUserType192).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType192;
			break;
		}
		case 39:
		{
			object xamlUserType191 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType191).StaticInitializer = StaticInitializer_39_TabViewWidthMode;
			((XamlUserType)xamlUserType191).AddEnumValue("Equal", (object)(TabViewWidthMode)0);
			((XamlUserType)xamlUserType191).AddEnumValue("SizeToContent", (object)(TabViewWidthMode)1);
			((XamlUserType)xamlUserType191).AddEnumValue("Compact", (object)(TabViewWidthMode)2);
			result = (XamlSystemBaseType)xamlUserType191;
			break;
		}
		case 40:
		{
			object xamlUserType190 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType190).StaticInitializer = StaticInitializer_40_TabViewCloseButtonOverlayMode;
			((XamlUserType)xamlUserType190).AddEnumValue("Auto", (object)(TabViewCloseButtonOverlayMode)0);
			((XamlUserType)xamlUserType190).AddEnumValue("OnPointerOver", (object)(TabViewCloseButtonOverlayMode)1);
			((XamlUserType)xamlUserType190).AddEnumValue("Always", (object)(TabViewCloseButtonOverlayMode)2);
			result = (XamlSystemBaseType)xamlUserType190;
			break;
		}
		case 41:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 42:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 43:
		{
			object xamlUserType189 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ListViewItem"));
			((XamlUserType)xamlUserType189).Activator = Activate_43_TabViewItem;
			((XamlUserType)xamlUserType189).StaticInitializer = StaticInitializer_43_TabViewItem;
			((XamlUserType)xamlUserType189).AddMemberName("Header");
			((XamlUserType)xamlUserType189).AddMemberName("IsClosable");
			((XamlUserType)xamlUserType189).AddMemberName("IconSource");
			((XamlUserType)xamlUserType189).AddMemberName("HeaderTemplate");
			((XamlUserType)xamlUserType189).AddMemberName("TabViewTemplateSettings");
			result = (XamlSystemBaseType)xamlUserType189;
			break;
		}
		case 44:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 45:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 46:
		{
			object xamlUserType188 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType188).StaticInitializer = StaticInitializer_46_TabViewItemTemplateSettings;
			((XamlUserType)xamlUserType188).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType188;
			break;
		}
		case 47:
		{
			object xamlUserType187 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ContentControl"));
			((XamlUserType)xamlUserType187).Activator = Activate_47_Expander;
			((XamlUserType)xamlUserType187).StaticInitializer = StaticInitializer_47_Expander;
			((XamlUserType)xamlUserType187).AddMemberName("Header");
			((XamlUserType)xamlUserType187).AddMemberName("ExpandDirection");
			((XamlUserType)xamlUserType187).AddMemberName("HeaderTemplate");
			((XamlUserType)xamlUserType187).AddMemberName("HeaderTemplateSelector");
			((XamlUserType)xamlUserType187).AddMemberName("IsExpanded");
			((XamlUserType)xamlUserType187).AddMemberName("TemplateSettings");
			result = (XamlSystemBaseType)xamlUserType187;
			break;
		}
		case 48:
		{
			object xamlUserType186 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType186).StaticInitializer = StaticInitializer_48_ExpandDirection;
			((XamlUserType)xamlUserType186).AddEnumValue("Down", (object)(ExpandDirection)0);
			((XamlUserType)xamlUserType186).AddEnumValue("Up", (object)(ExpandDirection)1);
			result = (XamlSystemBaseType)xamlUserType186;
			break;
		}
		case 49:
		{
			object xamlUserType185 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType185).StaticInitializer = StaticInitializer_49_ExpanderTemplateSettings;
			((XamlUserType)xamlUserType185).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType185;
			break;
		}
		case 50:
		{
			object xamlUserType184 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType184).Activator = Activate_50_McpStudioPage;
			((XamlUserType)xamlUserType184).StaticInitializer = StaticInitializer_50_McpStudioPage;
			((XamlUserType)xamlUserType184).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType184;
			break;
		}
		case 51:
		{
			object xamlUserType183 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType183).Activator = Activate_51_ShellView;
			((XamlUserType)xamlUserType183).StaticInitializer = StaticInitializer_51_ShellView;
			((XamlUserType)xamlUserType183).AddMemberName("ShellXamlRoot");
			((XamlUserType)xamlUserType183).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType183;
			break;
		}
		case 52:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 53:
		{
			object xamlUserType182 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Window"));
			((XamlUserType)xamlUserType182).Activator = Activate_53_MainWindow;
			((XamlUserType)xamlUserType182).StaticInitializer = StaticInitializer_53_MainWindow;
			((XamlUserType)xamlUserType182).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType182;
			break;
		}
		case 54:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 55:
		{
			object xamlUserType181 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ContentDialog"));
			((XamlUserType)xamlUserType181).StaticInitializer = StaticInitializer_55_BedrockAccountProfileDetailDialog;
			((XamlUserType)xamlUserType181).AddMemberName("ViewModel");
			((XamlUserType)xamlUserType181).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType181;
			break;
		}
		case 56:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 57:
		{
			object xamlUserType180 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType180).StaticInitializer = StaticInitializer_57_BedrockAccountProfileDetailViewModel;
			((XamlUserType)xamlUserType180).SetIsReturnTypeStub();
			((XamlUserType)xamlUserType180).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType180;
			break;
		}
		case 58:
		{
			object xamlUserType179 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.FrameworkElement"));
			((XamlUserType)xamlUserType179).Activator = Activate_58_WebView2;
			((XamlUserType)xamlUserType179).StaticInitializer = StaticInitializer_58_WebView2;
			((XamlUserType)xamlUserType179).AddMemberName("DefaultBackgroundColor");
			((XamlUserType)xamlUserType179).AddMemberName("CanGoBack");
			((XamlUserType)xamlUserType179).AddMemberName("CanGoForward");
			((XamlUserType)xamlUserType179).AddMemberName("CoreWebView2");
			((XamlUserType)xamlUserType179).AddMemberName("Source");
			result = (XamlSystemBaseType)xamlUserType179;
			break;
		}
		case 59:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 60:
		{
			object xamlUserType178 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType178).StaticInitializer = StaticInitializer_60_Color;
			((XamlUserType)xamlUserType178).AddMemberName("A");
			((XamlUserType)xamlUserType178).AddMemberName("R");
			((XamlUserType)xamlUserType178).AddMemberName("G");
			((XamlUserType)xamlUserType178).AddMemberName("B");
			result = (XamlSystemBaseType)xamlUserType178;
			break;
		}
		case 61:
		{
			object xamlUserType177 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType177).StaticInitializer = StaticInitializer_61_CoreWebView2;
			((XamlUserType)xamlUserType177).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType177;
			break;
		}
		case 62:
		{
			object xamlUserType176 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType176).StaticInitializer = StaticInitializer_62_Uri;
			((XamlUserType)xamlUserType176).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType176;
			break;
		}
		case 63:
		{
			object xamlUserType175 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType175).Activator = Activate_63_BedrockNetworkImage;
			((XamlUserType)xamlUserType175).StaticInitializer = StaticInitializer_63_BedrockNetworkImage;
			((XamlUserType)xamlUserType175).AddMemberName("ImageStretch");
			((XamlUserType)xamlUserType175).AddMemberName("ImageUrl");
			((XamlUserType)xamlUserType175).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType175;
			break;
		}
		case 64:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 65:
		{
			object xamlUserType174 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType174).Activator = Activate_65_BedrockFourDimensionalViewer;
			((XamlUserType)xamlUserType174).StaticInitializer = StaticInitializer_65_BedrockFourDimensionalViewer;
			((XamlUserType)xamlUserType174).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType174;
			break;
		}
		case 66:
		{
			object xamlUserType173 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType173).Activator = Activate_66_BedrockInstanceList;
			((XamlUserType)xamlUserType173).StaticInitializer = StaticInitializer_66_BedrockInstanceList;
			((XamlUserType)xamlUserType173).AddMemberName("Instances");
			((XamlUserType)xamlUserType173).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType173;
			break;
		}
		case 67:
		{
			object xamlUserType172 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel>"));
			((XamlUserType)xamlUserType172).StaticInitializer = StaticInitializer_67_ObservableCollection;
			((XamlUserType)xamlUserType172).CollectionAdd = VectorAdd_67_ObservableCollection;
			((XamlUserType)xamlUserType172).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType172;
			break;
		}
		case 68:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_68_Collection,
				StaticInitializer = StaticInitializer_68_Collection,
				CollectionAdd = VectorAdd_68_Collection
			};
			break;
		case 69:
		{
			object xamlUserType171 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType171).StaticInitializer = StaticInitializer_69_BedrockInstanceCardViewModel;
			((XamlUserType)xamlUserType171).AddMemberName("Instance");
			((XamlUserType)xamlUserType171).AddMemberName("Relay");
			((XamlUserType)xamlUserType171).AddMemberName("ProcessId");
			((XamlUserType)xamlUserType171).AddMemberName("Title");
			((XamlUserType)xamlUserType171).AddMemberName("KindText");
			((XamlUserType)xamlUserType171).AddMemberName("CoverUrl");
			((XamlUserType)xamlUserType171).AddMemberName("StatusText");
			((XamlUserType)xamlUserType171).AddMemberName("StartedText");
			((XamlUserType)xamlUserType171).AddMemberName("StartedTimeText");
			((XamlUserType)xamlUserType171).AddMemberName("AccountText");
			((XamlUserType)xamlUserType171).AddMemberName("DetailText");
			((XamlUserType)xamlUserType171).AddMemberName("ProcessText");
			((XamlUserType)xamlUserType171).AddMemberName("ProcessIdText");
			((XamlUserType)xamlUserType171).AddMemberName("ClientVersionText");
			((XamlUserType)xamlUserType171).AddMemberName("ProcessLabelText");
			((XamlUserType)xamlUserType171).AddMemberName("ClientLabelText");
			((XamlUserType)xamlUserType171).AddMemberName("OpenActionText");
			((XamlUserType)xamlUserType171).AddMemberName("CloseActionText");
			((XamlUserType)xamlUserType171).AddMemberName("OpenPath");
			((XamlUserType)xamlUserType171).AddMemberName("CanOpenFolder");
			((XamlUserType)xamlUserType171).AddMemberName("CanClose");
			((XamlUserType)xamlUserType171).AddMemberName("OverlayVisibility");
			((XamlUserType)xamlUserType171).AddMemberName("CanLoadOverlay");
			((XamlUserType)xamlUserType171).AddMemberName("OverlayProgressVisibility");
			((XamlUserType)xamlUserType171).AddMemberName("OverlayActionText");
			((XamlUserType)xamlUserType171).AddMemberName("OverlayStatusText");
			((XamlUserType)xamlUserType171).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType171;
			break;
		}
		case 70:
		{
			object xamlUserType170 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType170).StaticInitializer = StaticInitializer_70_BedrockInstanceInfo;
			((XamlUserType)xamlUserType170).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType170;
			break;
		}
		case 71:
		{
			object xamlUserType169 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType169).StaticInitializer = StaticInitializer_71_BedrockRelaySnapshot;
			((XamlUserType)xamlUserType169).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType169;
			break;
		}
		case 72:
		{
			object xamlUserType168 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType168).Activator = Activate_72_BedrockLocalLobbyBrowser;
			((XamlUserType)xamlUserType168).StaticInitializer = StaticInitializer_72_BedrockLocalLobbyBrowser;
			((XamlUserType)xamlUserType168).AddMemberName("Rooms");
			((XamlUserType)xamlUserType168).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType168;
			break;
		}
		case 73:
		{
			object xamlUserType167 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel>"));
			((XamlUserType)xamlUserType167).StaticInitializer = StaticInitializer_73_ObservableCollection;
			((XamlUserType)xamlUserType167).CollectionAdd = VectorAdd_73_ObservableCollection;
			((XamlUserType)xamlUserType167).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType167;
			break;
		}
		case 74:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_74_Collection,
				StaticInitializer = StaticInitializer_74_Collection,
				CollectionAdd = VectorAdd_74_Collection
			};
			break;
		case 75:
		{
			object xamlUserType166 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType166).StaticInitializer = StaticInitializer_75_BedrockLocalLobbyRoomCardViewModel;
			((XamlUserType)xamlUserType166).AddMemberName("Room");
			((XamlUserType)xamlUserType166).AddMemberName("Name");
			((XamlUserType)xamlUserType166).AddMemberName("Description");
			((XamlUserType)xamlUserType166).AddMemberName("CoverUrl");
			((XamlUserType)xamlUserType166).AddMemberName("PlayerText");
			((XamlUserType)xamlUserType166).AddMemberName("CategoryText");
			((XamlUserType)xamlUserType166).AddMemberName("VersionText");
			((XamlUserType)xamlUserType166).AddMemberName("StatusText");
			((XamlUserType)xamlUserType166).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType166;
			break;
		}
		case 76:
		{
			object xamlUserType165 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType165).StaticInitializer = StaticInitializer_76_BedrockLocalLobbyRoom;
			((XamlUserType)xamlUserType165).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType165;
			break;
		}
		case 77:
		{
			object xamlUserType164 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType164).Activator = Activate_77_BedrockMaterialPackBrowser;
			((XamlUserType)xamlUserType164).StaticInitializer = StaticInitializer_77_BedrockMaterialPackBrowser;
			((XamlUserType)xamlUserType164).AddMemberName("Packs");
			((XamlUserType)xamlUserType164).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType164;
			break;
		}
		case 78:
		{
			object xamlUserType163 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel>"));
			((XamlUserType)xamlUserType163).StaticInitializer = StaticInitializer_78_ObservableCollection;
			((XamlUserType)xamlUserType163).CollectionAdd = VectorAdd_78_ObservableCollection;
			((XamlUserType)xamlUserType163).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType163;
			break;
		}
		case 79:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_79_Collection,
				StaticInitializer = StaticInitializer_79_Collection,
				CollectionAdd = VectorAdd_79_Collection
			};
			break;
		case 80:
		{
			object xamlUserType162 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType162).StaticInitializer = StaticInitializer_80_BedrockMaterialPackViewModel;
			((XamlUserType)xamlUserType162).AddMemberName("Pack");
			((XamlUserType)xamlUserType162).AddMemberName("Id");
			((XamlUserType)xamlUserType162).AddMemberName("Name");
			((XamlUserType)xamlUserType162).AddMemberName("Description");
			((XamlUserType)xamlUserType162).AddMemberName("MetadataText");
			((XamlUserType)xamlUserType162).AddMemberName("ExclusionText");
			((XamlUserType)xamlUserType162).AddMemberName("IconSource");
			((XamlUserType)xamlUserType162).AddMemberName("IconVisibility");
			((XamlUserType)xamlUserType162).AddMemberName("PlaceholderVisibility");
			((XamlUserType)xamlUserType162).AddMemberName("IsEnabled");
			((XamlUserType)xamlUserType162).AddMemberName("EnabledStateText");
			((XamlUserType)xamlUserType162).AddMemberName("AllowFontOverride");
			((XamlUserType)xamlUserType162).AddMemberName("EnableActionText");
			((XamlUserType)xamlUserType162).AddMemberName("FontProtectionText");
			((XamlUserType)xamlUserType162).AddMemberName("FontProtectionStateText");
			((XamlUserType)xamlUserType162).AddMemberName("FontProtectionToolTip");
			((XamlUserType)xamlUserType162).AddMemberName("EnableToolTip");
			((XamlUserType)xamlUserType162).AddMemberName("CanDelete");
			((XamlUserType)xamlUserType162).AddMemberName("DeleteVisibility");
			((XamlUserType)xamlUserType162).AddMemberName("CanMoveUp");
			((XamlUserType)xamlUserType162).AddMemberName("CanMoveDown");
			((XamlUserType)xamlUserType162).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType162;
			break;
		}
		case 81:
		{
			object xamlUserType161 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType161).StaticInitializer = StaticInitializer_81_BedrockMaterialPack;
			((XamlUserType)xamlUserType161).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType161;
			break;
		}
		case 82:
		{
			object xamlUserType160 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType160).Activator = Activate_82_SettingsExpander;
			((XamlUserType)xamlUserType160).StaticInitializer = StaticInitializer_82_SettingsExpander;
			((XamlUserType)xamlUserType160).SetContentPropertyName("CommunityToolkit.WinUI.Controls.SettingsExpander.Content");
			((XamlUserType)xamlUserType160).AddMemberName("Content");
			((XamlUserType)xamlUserType160).AddMemberName("Header");
			((XamlUserType)xamlUserType160).AddMemberName("Description");
			((XamlUserType)xamlUserType160).AddMemberName("IsExpanded");
			((XamlUserType)xamlUserType160).AddMemberName("HeaderIcon");
			((XamlUserType)xamlUserType160).AddMemberName("Items");
			((XamlUserType)xamlUserType160).AddMemberName("ItemsSource");
			((XamlUserType)xamlUserType160).AddMemberName("ItemTemplate");
			((XamlUserType)xamlUserType160).AddMemberName("ItemContainerStyleSelector");
			((XamlUserType)xamlUserType160).AddMemberName("ItemsHeader");
			((XamlUserType)xamlUserType160).AddMemberName("ItemsFooter");
			result = (XamlSystemBaseType)xamlUserType160;
			break;
		}
		case 83:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 84:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 85:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 86:
		{
			object xamlUserType159 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Primitives.ButtonBase"));
			((XamlUserType)xamlUserType159).Activator = Activate_86_SettingsCard;
			((XamlUserType)xamlUserType159).StaticInitializer = StaticInitializer_86_SettingsCard;
			((XamlUserType)xamlUserType159).AddMemberName("Header");
			((XamlUserType)xamlUserType159).AddMemberName("Description");
			((XamlUserType)xamlUserType159).AddMemberName("HeaderIcon");
			((XamlUserType)xamlUserType159).AddMemberName("ActionIcon");
			((XamlUserType)xamlUserType159).AddMemberName("ActionIconToolTip");
			((XamlUserType)xamlUserType159).AddMemberName("IsClickEnabled");
			((XamlUserType)xamlUserType159).AddMemberName("ContentAlignment");
			((XamlUserType)xamlUserType159).AddMemberName("IsActionIconVisible");
			result = (XamlSystemBaseType)xamlUserType159;
			break;
		}
		case 87:
		{
			object xamlUserType158 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType158).StaticInitializer = StaticInitializer_87_ContentAlignment;
			((XamlUserType)xamlUserType158).AddEnumValue("Right", (object)(ContentAlignment)0);
			((XamlUserType)xamlUserType158).AddEnumValue("Left", (object)(ContentAlignment)1);
			((XamlUserType)xamlUserType158).AddEnumValue("Vertical", (object)(ContentAlignment)2);
			result = (XamlSystemBaseType)xamlUserType158;
			break;
		}
		case 88:
		{
			object xamlUserType157 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType157).Activator = Activate_88_BedrockProxySettingsView;
			((XamlUserType)xamlUserType157).StaticInitializer = StaticInitializer_88_BedrockProxySettingsView;
			((XamlUserType)xamlUserType157).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType157;
			break;
		}
		case 89:
		{
			object xamlUserType156 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType156).Activator = Activate_89_BedrockRentalRoomBrowser;
			((XamlUserType)xamlUserType156).StaticInitializer = StaticInitializer_89_BedrockRentalRoomBrowser;
			((XamlUserType)xamlUserType156).AddMemberName("Rooms");
			((XamlUserType)xamlUserType156).AddMemberName("RelayBindScope");
			((XamlUserType)xamlUserType156).AddMemberName("RelayFrontendProtocol");
			((XamlUserType)xamlUserType156).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType156;
			break;
		}
		case 90:
		{
			object xamlUserType155 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel>"));
			((XamlUserType)xamlUserType155).StaticInitializer = StaticInitializer_90_ObservableCollection;
			((XamlUserType)xamlUserType155).CollectionAdd = VectorAdd_90_ObservableCollection;
			((XamlUserType)xamlUserType155).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType155;
			break;
		}
		case 91:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_91_Collection,
				StaticInitializer = StaticInitializer_91_Collection,
				CollectionAdd = VectorAdd_91_Collection
			};
			break;
		case 92:
		{
			object xamlUserType154 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType154).StaticInitializer = StaticInitializer_92_BedrockRentalRoomCardViewModel;
			((XamlUserType)xamlUserType154).AddMemberName("Room");
			((XamlUserType)xamlUserType154).AddMemberName("Name");
			((XamlUserType)xamlUserType154).AddMemberName("RoomNumberText");
			((XamlUserType)xamlUserType154).AddMemberName("SummaryText");
			((XamlUserType)xamlUserType154).AddMemberName("PlayerText");
			((XamlUserType)xamlUserType154).AddMemberName("PopularityText");
			((XamlUserType)xamlUserType154).AddMemberName("LevelText");
			((XamlUserType)xamlUserType154).AddMemberName("PasswordText");
			((XamlUserType)xamlUserType154).AddMemberName("PasswordShortText");
			((XamlUserType)xamlUserType154).AddMemberName("LevelShortText");
			((XamlUserType)xamlUserType154).AddMemberName("StatusText");
			((XamlUserType)xamlUserType154).AddMemberName("VersionText");
			((XamlUserType)xamlUserType154).AddMemberName("CoverUrl");
			((XamlUserType)xamlUserType154).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType154;
			break;
		}
		case 93:
		{
			object xamlUserType153 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType153).StaticInitializer = StaticInitializer_93_BedrockRentalRoom;
			((XamlUserType)xamlUserType153).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType153;
			break;
		}
		case 94:
		{
			object xamlUserType152 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType152).StaticInitializer = StaticInitializer_94_BedrockRelayBindScope;
			((XamlUserType)xamlUserType152).AddEnumValue("Localhost", (object)(mpVm6bf0F2Qxo2jn2O2u)0);
			((XamlUserType)xamlUserType152).AddEnumValue("Lan", (object)(mpVm6bf0F2Qxo2jn2O2u)1);
			result = (XamlSystemBaseType)xamlUserType152;
			break;
		}
		case 95:
		{
			object xamlUserType151 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType151).Activator = Activate_95_BedrockServerBrowser;
			((XamlUserType)xamlUserType151).StaticInitializer = StaticInitializer_95_BedrockServerBrowser;
			((XamlUserType)xamlUserType151).AddMemberName("Servers");
			((XamlUserType)xamlUserType151).AddMemberName("RelayBindScope");
			((XamlUserType)xamlUserType151).AddMemberName("RelayFrontendProtocol");
			((XamlUserType)xamlUserType151).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType151;
			break;
		}
		case 96:
		{
			object xamlUserType150 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel>"));
			((XamlUserType)xamlUserType150).StaticInitializer = StaticInitializer_96_ObservableCollection;
			((XamlUserType)xamlUserType150).CollectionAdd = VectorAdd_96_ObservableCollection;
			((XamlUserType)xamlUserType150).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType150;
			break;
		}
		case 97:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_97_Collection,
				StaticInitializer = StaticInitializer_97_Collection,
				CollectionAdd = VectorAdd_97_Collection
			};
			break;
		case 98:
		{
			object xamlUserType149 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType149).StaticInitializer = StaticInitializer_98_BedrockServerCardViewModel;
			((XamlUserType)xamlUserType149).AddMemberName("Server");
			((XamlUserType)xamlUserType149).AddMemberName("Name");
			((XamlUserType)xamlUserType149).AddMemberName("Summary");
			((XamlUserType)xamlUserType149).AddMemberName("OnlineText");
			((XamlUserType)xamlUserType149).AddMemberName("CoverUrl");
			((XamlUserType)xamlUserType149).AddMemberName("PlatformText");
			((XamlUserType)xamlUserType149).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType149;
			break;
		}
		case 99:
		{
			object xamlUserType148 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType148).StaticInitializer = StaticInitializer_99_BedrockServer;
			((XamlUserType)xamlUserType148).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType148;
			break;
		}
		case 100:
		{
			object xamlUserType147 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType147).Activator = Activate_100_BedrockSkinViewer;
			((XamlUserType)xamlUserType147).StaticInitializer = StaticInitializer_100_BedrockSkinViewer;
			((XamlUserType)xamlUserType147).AddMemberName("AutoRotateEnabled");
			((XamlUserType)xamlUserType147).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType147;
			break;
		}
		case 101:
		{
			object xamlUserType146 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType146).Activator = Activate_101_SelectorBar;
			((XamlUserType)xamlUserType146).StaticInitializer = StaticInitializer_101_SelectorBar;
			((XamlUserType)xamlUserType146).SetContentPropertyName("Microsoft.UI.Xaml.Controls.SelectorBar.Items");
			((XamlUserType)xamlUserType146).AddMemberName("Items");
			((XamlUserType)xamlUserType146).AddMemberName("SelectedItem");
			result = (XamlSystemBaseType)xamlUserType146;
			break;
		}
		case 102:
		{
			object xamlUserType145 = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType145).StaticInitializer = StaticInitializer_102_IList;
			((XamlUserType)xamlUserType145).CollectionAdd = VectorAdd_102_IList;
			((XamlUserType)xamlUserType145).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType145;
			break;
		}
		case 103:
		{
			object xamlUserType144 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemContainer"));
			((XamlUserType)xamlUserType144).Activator = Activate_103_SelectorBarItem;
			((XamlUserType)xamlUserType144).StaticInitializer = StaticInitializer_103_SelectorBarItem;
			((XamlUserType)xamlUserType144).SetContentPropertyName("Microsoft.UI.Xaml.Controls.ItemContainer.Child");
			((XamlUserType)xamlUserType144).AddMemberName("Text");
			((XamlUserType)xamlUserType144).AddMemberName("Icon");
			result = (XamlSystemBaseType)xamlUserType144;
			break;
		}
		case 104:
		{
			object xamlUserType143 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType143).Activator = Activate_104_ItemContainer;
			((XamlUserType)xamlUserType143).StaticInitializer = StaticInitializer_104_ItemContainer;
			((XamlUserType)xamlUserType143).SetContentPropertyName("Microsoft.UI.Xaml.Controls.ItemContainer.Child");
			((XamlUserType)xamlUserType143).AddMemberName("Child");
			((XamlUserType)xamlUserType143).AddMemberName("IsSelected");
			result = (XamlSystemBaseType)xamlUserType143;
			break;
		}
		case 105:
		{
			object xamlUserType142 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType142).Activator = Activate_105_BedrockSkinBrowser;
			((XamlUserType)xamlUserType142).StaticInitializer = StaticInitializer_105_BedrockSkinBrowser;
			((XamlUserType)xamlUserType142).AddMemberName("Skins");
			((XamlUserType)xamlUserType142).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType142;
			break;
		}
		case 106:
		{
			object xamlUserType141 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel>"));
			((XamlUserType)xamlUserType141).StaticInitializer = StaticInitializer_106_ObservableCollection;
			((XamlUserType)xamlUserType141).CollectionAdd = VectorAdd_106_ObservableCollection;
			((XamlUserType)xamlUserType141).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType141;
			break;
		}
		case 107:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_107_Collection,
				StaticInitializer = StaticInitializer_107_Collection,
				CollectionAdd = VectorAdd_107_Collection
			};
			break;
		case 108:
		{
			object xamlUserType140 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType140).StaticInitializer = StaticInitializer_108_BedrockSkinCardViewModel;
			((XamlUserType)xamlUserType140).AddMemberName("Kind");
			((XamlUserType)xamlUserType140).AddMemberName("TwoDimensionalSkin");
			((XamlUserType)xamlUserType140).AddMemberName("FourDimensionalSkin");
			((XamlUserType)xamlUserType140).AddMemberName("FourDimensionalPart");
			((XamlUserType)xamlUserType140).AddMemberName("Id");
			((XamlUserType)xamlUserType140).AddMemberName("Name");
			((XamlUserType)xamlUserType140).AddMemberName("Developer");
			((XamlUserType)xamlUserType140).AddMemberName("Summary");
			((XamlUserType)xamlUserType140).AddMemberName("CoverUrl");
			((XamlUserType)xamlUserType140).AddMemberName("MetricsText");
			((XamlUserType)xamlUserType140).AddMemberName("ResourceStatusText");
			((XamlUserType)xamlUserType140).AddMemberName("IsApplied");
			((XamlUserType)xamlUserType140).AddMemberName("AppliedVisibility");
			((XamlUserType)xamlUserType140).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType140;
			break;
		}
		case 109:
		{
			object xamlUserType139 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType139).StaticInitializer = StaticInitializer_109_BedrockAppearanceKind;
			((XamlUserType)xamlUserType139).AddEnumValue("FreeTwoDimensionalSkin", (object)(p1aif0fNieMbuxR5AlNF)0);
			((XamlUserType)xamlUserType139).AddEnumValue("OwnedTwoDimensionalSkin", (object)(p1aif0fNieMbuxR5AlNF)1);
			((XamlUserType)xamlUserType139).AddEnumValue("FourDimensionalSkin", (object)(p1aif0fNieMbuxR5AlNF)2);
			((XamlUserType)xamlUserType139).AddEnumValue("FourDimensionalPart", (object)(p1aif0fNieMbuxR5AlNF)3);
			result = (XamlSystemBaseType)xamlUserType139;
			break;
		}
		case 110:
		{
			object xamlUserType138 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType138).StaticInitializer = StaticInitializer_110_BedrockFreeSkin;
			((XamlUserType)xamlUserType138).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType138;
			break;
		}
		case 111:
		{
			object xamlUserType137 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType137).StaticInitializer = StaticInitializer_111_BedrockFourDimensionalSkin;
			((XamlUserType)xamlUserType137).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType137;
			break;
		}
		case 112:
		{
			object xamlUserType136 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType136).StaticInitializer = StaticInitializer_112_BedrockFourDimensionalPart;
			((XamlUserType)xamlUserType136).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType136;
			break;
		}
		case 113:
		{
			object xamlUserType135 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ContentDialog"));
			((XamlUserType)xamlUserType135).Activator = Activate_113_JavaPackConversionBenefitsDialog;
			((XamlUserType)xamlUserType135).StaticInitializer = StaticInitializer_113_JavaPackConversionBenefitsDialog;
			((XamlUserType)xamlUserType135).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType135;
			break;
		}
		case 114:
		{
			object xamlUserType134 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType134).Activator = Activate_114_JavaRuntimeProfilePanel;
			((XamlUserType)xamlUserType134).StaticInitializer = StaticInitializer_114_JavaRuntimeProfilePanel;
			((XamlUserType)xamlUserType134).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType134;
			break;
		}
		case 115:
		{
			object xamlUserType133 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType133).Activator = Activate_115_PaymentBannerCarousel;
			((XamlUserType)xamlUserType133).StaticInitializer = StaticInitializer_115_PaymentBannerCarousel;
			((XamlUserType)xamlUserType133).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType133;
			break;
		}
		case 116:
		{
			object xamlUserType132 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType132).Activator = Activate_116_PaymentBannerEditor;
			((XamlUserType)xamlUserType132).StaticInitializer = StaticInitializer_116_PaymentBannerEditor;
			((XamlUserType)xamlUserType132).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType132;
			break;
		}
		case 117:
		{
			object xamlUserType131 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType131).Activator = Activate_117_RecentPaymentOrdersPanel;
			((XamlUserType)xamlUserType131).StaticInitializer = StaticInitializer_117_RecentPaymentOrdersPanel;
			((XamlUserType)xamlUserType131).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType131;
			break;
		}
		case 118:
		{
			object xamlUserType130 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType130).Activator = Activate_118_ShutdownUploadOverlay;
			((XamlUserType)xamlUserType130).StaticInitializer = StaticInitializer_118_ShutdownUploadOverlay;
			((XamlUserType)xamlUserType130).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType130;
			break;
		}
		case 119:
		{
			object xamlUserType129 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType129).Activator = Activate_119_BedrockToolsView;
			((XamlUserType)xamlUserType129).StaticInitializer = StaticInitializer_119_BedrockToolsView;
			((XamlUserType)xamlUserType129).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType129;
			break;
		}
		case 120:
		{
			object xamlUserType128 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.FrameworkElement"));
			((XamlUserType)xamlUserType128).Activator = Activate_120_ItemsRepeater;
			((XamlUserType)xamlUserType128).StaticInitializer = StaticInitializer_120_ItemsRepeater;
			((XamlUserType)xamlUserType128).SetContentPropertyName("Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate");
			((XamlUserType)xamlUserType128).AddMemberName("ItemTemplate");
			((XamlUserType)xamlUserType128).AddMemberName("Layout");
			((XamlUserType)xamlUserType128).AddMemberName("Background");
			((XamlUserType)xamlUserType128).AddMemberName("HorizontalCacheLength");
			((XamlUserType)xamlUserType128).AddMemberName("ItemTransitionProvider");
			((XamlUserType)xamlUserType128).AddMemberName("ItemsSource");
			((XamlUserType)xamlUserType128).AddMemberName("ItemsSourceView");
			((XamlUserType)xamlUserType128).AddMemberName("VerticalCacheLength");
			result = (XamlSystemBaseType)xamlUserType128;
			break;
		}
		case 121:
		{
			object xamlUserType127 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType127).StaticInitializer = StaticInitializer_121_Layout;
			((XamlUserType)xamlUserType127).AddMemberName("IndexBasedLayoutOrientation");
			result = (XamlSystemBaseType)xamlUserType127;
			break;
		}
		case 122:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 123:
		{
			object xamlUserType126 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType126).StaticInitializer = StaticInitializer_123_ItemCollectionTransitionProvider;
			((XamlUserType)xamlUserType126).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType126;
			break;
		}
		case 124:
		{
			object xamlUserType125 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType125).StaticInitializer = StaticInitializer_124_ItemsSourceView;
			((XamlUserType)xamlUserType125).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType125;
			break;
		}
		case 125:
		{
			object xamlUserType124 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.VirtualizingLayout"));
			((XamlUserType)xamlUserType124).Activator = Activate_125_UniformGridLayout;
			((XamlUserType)xamlUserType124).StaticInitializer = StaticInitializer_125_UniformGridLayout;
			((XamlUserType)xamlUserType124).AddMemberName("MinItemWidth");
			((XamlUserType)xamlUserType124).AddMemberName("MinItemHeight");
			((XamlUserType)xamlUserType124).AddMemberName("MinRowSpacing");
			((XamlUserType)xamlUserType124).AddMemberName("MinColumnSpacing");
			((XamlUserType)xamlUserType124).AddMemberName("ItemsJustification");
			((XamlUserType)xamlUserType124).AddMemberName("ItemsStretch");
			((XamlUserType)xamlUserType124).AddMemberName("MaximumRowsOrColumns");
			((XamlUserType)xamlUserType124).AddMemberName("Orientation");
			result = (XamlSystemBaseType)xamlUserType124;
			break;
		}
		case 126:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Layout"))
			{
				Activator = Activate_126_VirtualizingLayout,
				StaticInitializer = StaticInitializer_126_VirtualizingLayout
			};
			break;
		case 127:
		{
			object xamlUserType123 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType123).StaticInitializer = StaticInitializer_127_UniformGridLayoutItemsJustification;
			((XamlUserType)xamlUserType123).AddEnumValue("Start", (object)(UniformGridLayoutItemsJustification)0);
			((XamlUserType)xamlUserType123).AddEnumValue("Center", (object)(UniformGridLayoutItemsJustification)1);
			((XamlUserType)xamlUserType123).AddEnumValue("End", (object)(UniformGridLayoutItemsJustification)2);
			((XamlUserType)xamlUserType123).AddEnumValue("SpaceAround", (object)(UniformGridLayoutItemsJustification)3);
			((XamlUserType)xamlUserType123).AddEnumValue("SpaceBetween", (object)(UniformGridLayoutItemsJustification)4);
			((XamlUserType)xamlUserType123).AddEnumValue("SpaceEvenly", (object)(UniformGridLayoutItemsJustification)5);
			result = (XamlSystemBaseType)xamlUserType123;
			break;
		}
		case 128:
		{
			object xamlUserType122 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType122).StaticInitializer = StaticInitializer_128_UniformGridLayoutItemsStretch;
			((XamlUserType)xamlUserType122).AddEnumValue("None", (object)(UniformGridLayoutItemsStretch)0);
			((XamlUserType)xamlUserType122).AddEnumValue("Fill", (object)(UniformGridLayoutItemsStretch)1);
			((XamlUserType)xamlUserType122).AddEnumValue("Uniform", (object)(UniformGridLayoutItemsStretch)2);
			result = (XamlSystemBaseType)xamlUserType122;
			break;
		}
		case 129:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 130:
		{
			object xamlUserType121 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType121).StaticInitializer = StaticInitializer_130_IndexBasedLayoutOrientation;
			((XamlUserType)xamlUserType121).AddEnumValue("None", (object)(IndexBasedLayoutOrientation)0);
			((XamlUserType)xamlUserType121).AddEnumValue("TopToBottom", (object)(IndexBasedLayoutOrientation)1);
			((XamlUserType)xamlUserType121).AddEnumValue("LeftToRight", (object)(IndexBasedLayoutOrientation)2);
			result = (XamlSystemBaseType)xamlUserType121;
			break;
		}
		case 131:
		{
			object xamlUserType120 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType120).Activator = Activate_131_HwidSpoofToolsView;
			((XamlUserType)xamlUserType120).StaticInitializer = StaticInitializer_131_HwidSpoofToolsView;
			((XamlUserType)xamlUserType120).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType120;
			break;
		}
		case 132:
		{
			object xamlUserType119 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType119).Activator = Activate_132_UserRefundDetailView;
			((XamlUserType)xamlUserType119).StaticInitializer = StaticInitializer_132_UserRefundDetailView;
			((XamlUserType)xamlUserType119).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType119;
			break;
		}
		case 133:
		{
			object xamlUserType118 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ContentDialog"));
			((XamlUserType)xamlUserType118).StaticInitializer = StaticInitializer_133_UserRefundRequestDialog;
			((XamlUserType)xamlUserType118).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType118;
			break;
		}
		case 134:
		{
			object xamlUserType117 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType117).Activator = Activate_134_UserRefundRequestsView;
			((XamlUserType)xamlUserType117).StaticInitializer = StaticInitializer_134_UserRefundRequestsView;
			((XamlUserType)xamlUserType117).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType117;
			break;
		}
		case 135:
		{
			object xamlUserType116 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType116).Activator = Activate_135_AppWatermark;
			((XamlUserType)xamlUserType116).StaticInitializer = StaticInitializer_135_AppWatermark;
			((XamlUserType)xamlUserType116).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType116;
			break;
		}
		case 136:
		{
			object xamlUserType115 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Media.XamlCompositionBrushBase"));
			((XamlUserType)xamlUserType115).Activator = Activate_136_RadialGradientBrush;
			((XamlUserType)xamlUserType115).StaticInitializer = StaticInitializer_136_RadialGradientBrush;
			((XamlUserType)xamlUserType115).SetContentPropertyName("Microsoft.UI.Xaml.Media.RadialGradientBrush.GradientStops");
			((XamlUserType)xamlUserType115).AddMemberName("GradientStops");
			((XamlUserType)xamlUserType115).AddMemberName("Center");
			((XamlUserType)xamlUserType115).AddMemberName("GradientOrigin");
			((XamlUserType)xamlUserType115).AddMemberName("InterpolationSpace");
			((XamlUserType)xamlUserType115).AddMemberName("MappingMode");
			((XamlUserType)xamlUserType115).AddMemberName("RadiusX");
			((XamlUserType)xamlUserType115).AddMemberName("RadiusY");
			((XamlUserType)xamlUserType115).AddMemberName("SpreadMethod");
			result = (XamlSystemBaseType)xamlUserType115;
			break;
		}
		case 137:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 138:
		{
			object xamlUserType114 = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType114).StaticInitializer = StaticInitializer_138_IObservableVector;
			((XamlUserType)xamlUserType114).CollectionAdd = VectorAdd_138_IObservableVector;
			((XamlUserType)xamlUserType114).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType114;
			break;
		}
		case 139:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 140:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 141:
		{
			object xamlUserType113 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType113).StaticInitializer = StaticInitializer_141_CompositionColorSpace;
			((XamlUserType)xamlUserType113).AddEnumValue("Auto", (object)(CompositionColorSpace)0);
			((XamlUserType)xamlUserType113).AddEnumValue("Hsl", (object)(CompositionColorSpace)1);
			((XamlUserType)xamlUserType113).AddEnumValue("Rgb", (object)(CompositionColorSpace)2);
			((XamlUserType)xamlUserType113).AddEnumValue("HslLinear", (object)(CompositionColorSpace)3);
			((XamlUserType)xamlUserType113).AddEnumValue("RgbLinear", (object)(CompositionColorSpace)4);
			result = (XamlSystemBaseType)xamlUserType113;
			break;
		}
		case 142:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 143:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 144:
		{
			object xamlUserType112 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType112).Activator = Activate_144_AuthView;
			((XamlUserType)xamlUserType112).StaticInitializer = StaticInitializer_144_AuthView;
			((XamlUserType)xamlUserType112).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType112;
			break;
		}
		case 145:
		{
			object xamlUserType111 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType111).Activator = Activate_145_InfoBarHost;
			((XamlUserType)xamlUserType111).StaticInitializer = StaticInitializer_145_InfoBarHost;
			((XamlUserType)xamlUserType111).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType111;
			break;
		}
		case 146:
		{
			object xamlUserType110 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType110).Activator = Activate_146_PersonPicture;
			((XamlUserType)xamlUserType110).StaticInitializer = StaticInitializer_146_PersonPicture;
			((XamlUserType)xamlUserType110).AddMemberName("BadgeGlyph");
			((XamlUserType)xamlUserType110).AddMemberName("BadgeImageSource");
			((XamlUserType)xamlUserType110).AddMemberName("BadgeNumber");
			((XamlUserType)xamlUserType110).AddMemberName("BadgeText");
			((XamlUserType)xamlUserType110).AddMemberName("Contact");
			((XamlUserType)xamlUserType110).AddMemberName("DisplayName");
			((XamlUserType)xamlUserType110).AddMemberName("Initials");
			((XamlUserType)xamlUserType110).AddMemberName("IsGroup");
			((XamlUserType)xamlUserType110).AddMemberName("PreferSmallImage");
			((XamlUserType)xamlUserType110).AddMemberName("ProfilePicture");
			((XamlUserType)xamlUserType110).AddMemberName("TemplateSettings");
			result = (XamlSystemBaseType)xamlUserType110;
			break;
		}
		case 147:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 148:
		{
			object xamlUserType109 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType109).StaticInitializer = StaticInitializer_148_Contact;
			((XamlUserType)xamlUserType109).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType109;
			break;
		}
		case 149:
		{
			object xamlUserType108 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType108).StaticInitializer = StaticInitializer_149_PersonPictureTemplateSettings;
			((XamlUserType)xamlUserType108).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType108;
			break;
		}
		case 150:
		{
			object xamlUserType107 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType107).Activator = Activate_150_NavigationUserFooter;
			((XamlUserType)xamlUserType107).StaticInitializer = StaticInitializer_150_NavigationUserFooter;
			((XamlUserType)xamlUserType107).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType107;
			break;
		}
		case 151:
		{
			object xamlUserType106 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UserControl"));
			((XamlUserType)xamlUserType106).Activator = Activate_151_PagerBar;
			((XamlUserType)xamlUserType106).StaticInitializer = StaticInitializer_151_PagerBar;
			((XamlUserType)xamlUserType106).AddMemberName("PageSizeVisibility");
			((XamlUserType)xamlUserType106).AddMemberName("PageSize");
			((XamlUserType)xamlUserType106).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType106;
			break;
		}
		case 152:
		{
			object xamlUserType105 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType105).StaticInitializer = StaticInitializer_152_Thickness;
			((XamlUserType)xamlUserType105).AddMemberName("Left");
			((XamlUserType)xamlUserType105).AddMemberName("Top");
			((XamlUserType)xamlUserType105).AddMemberName("Right");
			((XamlUserType)xamlUserType105).AddMemberName("Bottom");
			result = (XamlSystemBaseType)xamlUserType105;
			break;
		}
		case 153:
		{
			object xamlUserType104 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType104).Activator = Activate_153_TitleBar;
			((XamlUserType)xamlUserType104).StaticInitializer = StaticInitializer_153_TitleBar;
			((XamlUserType)xamlUserType104).SetContentPropertyName("Microsoft.UI.Xaml.Controls.TitleBar.Content");
			((XamlUserType)xamlUserType104).AddMemberName("Content");
			((XamlUserType)xamlUserType104).AddMemberName("Title");
			((XamlUserType)xamlUserType104).AddMemberName("IsBackButtonVisible");
			((XamlUserType)xamlUserType104).AddMemberName("IsPaneToggleButtonVisible");
			((XamlUserType)xamlUserType104).AddMemberName("IconSource");
			((XamlUserType)xamlUserType104).AddMemberName("RightHeader");
			((XamlUserType)xamlUserType104).AddMemberName("AutoRefreshDragRegions");
			((XamlUserType)xamlUserType104).AddMemberName("IsBackButtonEnabled");
			((XamlUserType)xamlUserType104).AddMemberName("LeftHeader");
			((XamlUserType)xamlUserType104).AddMemberName("Subtitle");
			((XamlUserType)xamlUserType104).AddMemberName("TemplateSettings");
			((XamlUserType)xamlUserType104).AddMemberName("IsDragRegion");
			result = (XamlSystemBaseType)xamlUserType104;
			break;
		}
		case 154:
		{
			object xamlUserType103 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType103).StaticInitializer = StaticInitializer_154_TitleBarTemplateSettings;
			((XamlUserType)xamlUserType103).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType103;
			break;
		}
		case 155:
		{
			object xamlUserType102 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType102).SetBoxedType(GetXamlTypeByName("Boolean"));
			((XamlUserType)xamlUserType102).BoxInstance = ((XamlUserType)xamlUserType102).BoxType<bool>;
			((XamlUserType)xamlUserType102).StaticInitializer = StaticInitializer_155_Nullable;
			((XamlUserType)xamlUserType102).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType102;
			break;
		}
		case 156:
		{
			object xamlUserType101 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ContentControl"));
			((XamlUserType)xamlUserType101).Activator = Activate_156_NavigationView;
			((XamlUserType)xamlUserType101).StaticInitializer = StaticInitializer_156_NavigationView;
			((XamlUserType)xamlUserType101).AddMemberName("CompactPaneLength");
			((XamlUserType)xamlUserType101).AddMemberName("IsBackButtonVisible");
			((XamlUserType)xamlUserType101).AddMemberName("IsPaneOpen");
			((XamlUserType)xamlUserType101).AddMemberName("IsPaneToggleButtonVisible");
			((XamlUserType)xamlUserType101).AddMemberName("IsSettingsVisible");
			((XamlUserType)xamlUserType101).AddMemberName("OpenPaneLength");
			((XamlUserType)xamlUserType101).AddMemberName("PaneDisplayMode");
			((XamlUserType)xamlUserType101).AddMemberName("MenuItems");
			((XamlUserType)xamlUserType101).AddMemberName("PaneFooter");
			((XamlUserType)xamlUserType101).AddMemberName("AlwaysShowHeader");
			((XamlUserType)xamlUserType101).AddMemberName("AutoSuggestBox");
			((XamlUserType)xamlUserType101).AddMemberName("CompactModeThresholdWidth");
			((XamlUserType)xamlUserType101).AddMemberName("ContentOverlay");
			((XamlUserType)xamlUserType101).AddMemberName("DisplayMode");
			((XamlUserType)xamlUserType101).AddMemberName("ExpandedModeThresholdWidth");
			((XamlUserType)xamlUserType101).AddMemberName("FooterMenuItems");
			((XamlUserType)xamlUserType101).AddMemberName("FooterMenuItemsSource");
			((XamlUserType)xamlUserType101).AddMemberName("Header");
			((XamlUserType)xamlUserType101).AddMemberName("HeaderTemplate");
			((XamlUserType)xamlUserType101).AddMemberName("IsBackEnabled");
			((XamlUserType)xamlUserType101).AddMemberName("IsPaneVisible");
			((XamlUserType)xamlUserType101).AddMemberName("IsTitleBarAutoPaddingEnabled");
			((XamlUserType)xamlUserType101).AddMemberName("MenuItemContainerStyle");
			((XamlUserType)xamlUserType101).AddMemberName("MenuItemContainerStyleSelector");
			((XamlUserType)xamlUserType101).AddMemberName("MenuItemTemplate");
			((XamlUserType)xamlUserType101).AddMemberName("MenuItemTemplateSelector");
			((XamlUserType)xamlUserType101).AddMemberName("MenuItemsSource");
			((XamlUserType)xamlUserType101).AddMemberName("OverflowLabelMode");
			((XamlUserType)xamlUserType101).AddMemberName("PaneCustomContent");
			((XamlUserType)xamlUserType101).AddMemberName("PaneHeader");
			((XamlUserType)xamlUserType101).AddMemberName("PaneTitle");
			((XamlUserType)xamlUserType101).AddMemberName("PaneToggleButtonStyle");
			((XamlUserType)xamlUserType101).AddMemberName("SelectedItem");
			((XamlUserType)xamlUserType101).AddMemberName("SelectionFollowsFocus");
			((XamlUserType)xamlUserType101).AddMemberName("SettingsItem");
			((XamlUserType)xamlUserType101).AddMemberName("ShoulderNavigationEnabled");
			((XamlUserType)xamlUserType101).AddMemberName("TemplateSettings");
			result = (XamlSystemBaseType)xamlUserType101;
			break;
		}
		case 157:
		{
			object xamlUserType100 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType100).StaticInitializer = StaticInitializer_157_NavigationViewBackButtonVisible;
			((XamlUserType)xamlUserType100).AddEnumValue("Collapsed", (object)(NavigationViewBackButtonVisible)0);
			((XamlUserType)xamlUserType100).AddEnumValue("Visible", (object)(NavigationViewBackButtonVisible)1);
			((XamlUserType)xamlUserType100).AddEnumValue("Auto", (object)(NavigationViewBackButtonVisible)2);
			result = (XamlSystemBaseType)xamlUserType100;
			break;
		}
		case 158:
		{
			object xamlUserType99 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType99).StaticInitializer = StaticInitializer_158_NavigationViewPaneDisplayMode;
			((XamlUserType)xamlUserType99).AddEnumValue("Auto", (object)(NavigationViewPaneDisplayMode)0);
			((XamlUserType)xamlUserType99).AddEnumValue("Left", (object)(NavigationViewPaneDisplayMode)1);
			((XamlUserType)xamlUserType99).AddEnumValue("Top", (object)(NavigationViewPaneDisplayMode)2);
			((XamlUserType)xamlUserType99).AddEnumValue("LeftCompact", (object)(NavigationViewPaneDisplayMode)3);
			((XamlUserType)xamlUserType99).AddEnumValue("LeftMinimal", (object)(NavigationViewPaneDisplayMode)4);
			result = (XamlSystemBaseType)xamlUserType99;
			break;
		}
		case 159:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 160:
		{
			object xamlUserType98 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType98).StaticInitializer = StaticInitializer_160_NavigationViewDisplayMode;
			((XamlUserType)xamlUserType98).AddEnumValue("Minimal", (object)(NavigationViewDisplayMode)0);
			((XamlUserType)xamlUserType98).AddEnumValue("Compact", (object)(NavigationViewDisplayMode)1);
			((XamlUserType)xamlUserType98).AddEnumValue("Expanded", (object)(NavigationViewDisplayMode)2);
			result = (XamlSystemBaseType)xamlUserType98;
			break;
		}
		case 161:
		{
			object xamlUserType97 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType97).StaticInitializer = StaticInitializer_161_NavigationViewOverflowLabelMode;
			((XamlUserType)xamlUserType97).AddEnumValue("MoreLabel", (object)(NavigationViewOverflowLabelMode)0);
			((XamlUserType)xamlUserType97).AddEnumValue("NoLabel", (object)(NavigationViewOverflowLabelMode)1);
			result = (XamlSystemBaseType)xamlUserType97;
			break;
		}
		case 162:
		{
			object xamlUserType96 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType96).StaticInitializer = StaticInitializer_162_NavigationViewSelectionFollowsFocus;
			((XamlUserType)xamlUserType96).AddEnumValue("Disabled", (object)(NavigationViewSelectionFollowsFocus)0);
			((XamlUserType)xamlUserType96).AddEnumValue("Enabled", (object)(NavigationViewSelectionFollowsFocus)1);
			result = (XamlSystemBaseType)xamlUserType96;
			break;
		}
		case 163:
		{
			object xamlUserType95 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType95).StaticInitializer = StaticInitializer_163_NavigationViewShoulderNavigationEnabled;
			((XamlUserType)xamlUserType95).AddEnumValue("WhenSelectionFollowsFocus", (object)(NavigationViewShoulderNavigationEnabled)0);
			((XamlUserType)xamlUserType95).AddEnumValue("Always", (object)(NavigationViewShoulderNavigationEnabled)1);
			((XamlUserType)xamlUserType95).AddEnumValue("Never", (object)(NavigationViewShoulderNavigationEnabled)2);
			result = (XamlSystemBaseType)xamlUserType95;
			break;
		}
		case 164:
		{
			object xamlUserType94 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType94).StaticInitializer = StaticInitializer_164_NavigationViewTemplateSettings;
			((XamlUserType)xamlUserType94).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType94;
			break;
		}
		case 165:
		{
			object xamlUserType93 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItemBase"));
			((XamlUserType)xamlUserType93).Activator = Activate_165_NavigationViewItem;
			((XamlUserType)xamlUserType93).StaticInitializer = StaticInitializer_165_NavigationViewItem;
			((XamlUserType)xamlUserType93).AddMemberName("Icon");
			((XamlUserType)xamlUserType93).AddMemberName("SelectsOnInvoked");
			((XamlUserType)xamlUserType93).AddMemberName("MenuItems");
			((XamlUserType)xamlUserType93).AddMemberName("CompactPaneLength");
			((XamlUserType)xamlUserType93).AddMemberName("HasUnrealizedChildren");
			((XamlUserType)xamlUserType93).AddMemberName("InfoBadge");
			((XamlUserType)xamlUserType93).AddMemberName("IsChildSelected");
			((XamlUserType)xamlUserType93).AddMemberName("IsExpanded");
			((XamlUserType)xamlUserType93).AddMemberName("MenuItemsSource");
			result = (XamlSystemBaseType)xamlUserType93;
			break;
		}
		case 166:
		{
			object xamlUserType92 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ContentControl"));
			((XamlUserType)xamlUserType92).StaticInitializer = StaticInitializer_166_NavigationViewItemBase;
			((XamlUserType)xamlUserType92).AddMemberName("IsSelected");
			result = (XamlSystemBaseType)xamlUserType92;
			break;
		}
		case 167:
		{
			object xamlUserType91 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType91).StaticInitializer = StaticInitializer_167_InfoBadge;
			((XamlUserType)xamlUserType91).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType91;
			break;
		}
		case 168:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItemBase"))
			{
				Activator = Activate_168_NavigationViewItemHeader,
				StaticInitializer = StaticInitializer_168_NavigationViewItemHeader
			};
			break;
		case 169:
		{
			object xamlUserType90 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.IconSource"));
			((XamlUserType)xamlUserType90).Activator = Activate_169_ImageIconSource;
			((XamlUserType)xamlUserType90).StaticInitializer = StaticInitializer_169_ImageIconSource;
			((XamlUserType)xamlUserType90).AddMemberName("ImageSource");
			result = (XamlSystemBaseType)xamlUserType90;
			break;
		}
		case 170:
		{
			object xamlUserType89 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType89).StaticInitializer = StaticInitializer_170_CornerRadius;
			((XamlUserType)xamlUserType89).AddMemberName("TopLeft");
			((XamlUserType)xamlUserType89).AddMemberName("TopRight");
			((XamlUserType)xamlUserType89).AddMemberName("BottomRight");
			((XamlUserType)xamlUserType89).AddMemberName("BottomLeft");
			result = (XamlSystemBaseType)xamlUserType89;
			break;
		}
		case 171:
		{
			object xamlUserType88 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("CommunityToolkit.WinUI.AttachedShadowBase"));
			((XamlUserType)xamlUserType88).Activator = Activate_171_AttachedCardShadow;
			((XamlUserType)xamlUserType88).StaticInitializer = StaticInitializer_171_AttachedCardShadow;
			((XamlUserType)xamlUserType88).AddMemberName("CornerRadius");
			((XamlUserType)xamlUserType88).AddMemberName("InnerContentClipMode");
			result = (XamlSystemBaseType)xamlUserType88;
			break;
		}
		case 172:
		{
			object xamlUserType87 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType87).StaticInitializer = StaticInitializer_172_AttachedShadowBase;
			((XamlUserType)xamlUserType87).AddMemberName("BlurRadius");
			((XamlUserType)xamlUserType87).AddMemberName("Opacity");
			((XamlUserType)xamlUserType87).AddMemberName("Offset");
			((XamlUserType)xamlUserType87).AddMemberName("Color");
			result = (XamlSystemBaseType)xamlUserType87;
			break;
		}
		case 173:
		{
			object xamlUserType86 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType86).StaticInitializer = StaticInitializer_173_InnerContentClipMode;
			((XamlUserType)xamlUserType86).AddEnumValue("None", (object)(InnerContentClipMode)0);
			((XamlUserType)xamlUserType86).AddEnumValue("CompositionMaskBrush", (object)(InnerContentClipMode)1);
			((XamlUserType)xamlUserType86).AddEnumValue("CompositionGeometricClip", (object)(InnerContentClipMode)2);
			result = (XamlSystemBaseType)xamlUserType86;
			break;
		}
		case 174:
		{
			object xamlUserType85 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType85).StaticInitializer = StaticInitializer_174_Byte;
			((XamlUserType)xamlUserType85).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType85;
			break;
		}
		case 175:
		{
			object xamlUserType84 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType84).Activator = Activate_175_AboutPage;
			((XamlUserType)xamlUserType84).StaticInitializer = StaticInitializer_175_AboutPage;
			((XamlUserType)xamlUserType84).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType84;
			break;
		}
		case 176:
		{
			object xamlUserType83 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType83).Activator = Activate_176_AccountPage;
			((XamlUserType)xamlUserType83).StaticInitializer = StaticInitializer_176_AccountPage;
			((XamlUserType)xamlUserType83).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType83;
			break;
		}
		case 177:
		{
			object xamlUserType82 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType82).Activator = Activate_177_BalanceHistoryPage;
			((XamlUserType)xamlUserType82).StaticInitializer = StaticInitializer_177_BalanceHistoryPage;
			((XamlUserType)xamlUserType82).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType82;
			break;
		}
		case 178:
		{
			object xamlUserType81 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Control"));
			((XamlUserType)xamlUserType81).Activator = Activate_178_NumberBox;
			((XamlUserType)xamlUserType81).StaticInitializer = StaticInitializer_178_NumberBox;
			((XamlUserType)xamlUserType81).AddMemberName("Header");
			((XamlUserType)xamlUserType81).AddMemberName("Maximum");
			((XamlUserType)xamlUserType81).AddMemberName("Minimum");
			((XamlUserType)xamlUserType81).AddMemberName("SmallChange");
			((XamlUserType)xamlUserType81).AddMemberName("AcceptsExpression");
			((XamlUserType)xamlUserType81).AddMemberName("Description");
			((XamlUserType)xamlUserType81).AddMemberName("HeaderTemplate");
			((XamlUserType)xamlUserType81).AddMemberName("IsWrapEnabled");
			((XamlUserType)xamlUserType81).AddMemberName("LargeChange");
			((XamlUserType)xamlUserType81).AddMemberName("NumberFormatter");
			((XamlUserType)xamlUserType81).AddMemberName("PlaceholderText");
			((XamlUserType)xamlUserType81).AddMemberName("PreventKeyboardDisplayOnProgrammaticFocus");
			((XamlUserType)xamlUserType81).AddMemberName("SelectionFlyout");
			((XamlUserType)xamlUserType81).AddMemberName("SelectionHighlightColor");
			((XamlUserType)xamlUserType81).AddMemberName("SpinButtonPlacementMode");
			((XamlUserType)xamlUserType81).AddMemberName("Text");
			((XamlUserType)xamlUserType81).AddMemberName("TextReadingOrder");
			((XamlUserType)xamlUserType81).AddMemberName("ValidationMode");
			((XamlUserType)xamlUserType81).AddMemberName("Value");
			result = (XamlSystemBaseType)xamlUserType81;
			break;
		}
		case 179:
		{
			object xamlUserType80 = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType80).StaticInitializer = StaticInitializer_179_INumberFormatter2;
			((XamlUserType)xamlUserType80).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType80;
			break;
		}
		case 180:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 181:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 182:
		{
			object xamlUserType79 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType79).StaticInitializer = StaticInitializer_182_NumberBoxSpinButtonPlacementMode;
			((XamlUserType)xamlUserType79).AddEnumValue("Hidden", (object)(NumberBoxSpinButtonPlacementMode)0);
			((XamlUserType)xamlUserType79).AddEnumValue("Compact", (object)(NumberBoxSpinButtonPlacementMode)1);
			((XamlUserType)xamlUserType79).AddEnumValue("Inline", (object)(NumberBoxSpinButtonPlacementMode)2);
			result = (XamlSystemBaseType)xamlUserType79;
			break;
		}
		case 183:
			result = (XamlSystemBaseType)new XamlSystemBaseType(fullName, type);
			break;
		case 184:
		{
			object xamlUserType78 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType78).StaticInitializer = StaticInitializer_184_NumberBoxValidationMode;
			((XamlUserType)xamlUserType78).AddEnumValue("InvalidInputOverwritten", (object)(NumberBoxValidationMode)0);
			((XamlUserType)xamlUserType78).AddEnumValue("Disabled", (object)(NumberBoxValidationMode)1);
			result = (XamlSystemBaseType)xamlUserType78;
			break;
		}
		case 185:
		{
			object xamlUserType77 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType77).Activator = Activate_185_BalancePage;
			((XamlUserType)xamlUserType77).StaticInitializer = StaticInitializer_185_BalancePage;
			((XamlUserType)xamlUserType77).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType77;
			break;
		}
		case 186:
		{
			object xamlUserType76 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType76).Activator = Activate_186_BedrockAccountPage;
			((XamlUserType)xamlUserType76).StaticInitializer = StaticInitializer_186_BedrockAccountPage;
			((XamlUserType)xamlUserType76).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType76;
			break;
		}
		case 187:
		{
			object xamlUserType75 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType75).Activator = Activate_187_BedrockInstancesPage;
			((XamlUserType)xamlUserType75).StaticInitializer = StaticInitializer_187_BedrockInstancesPage;
			((XamlUserType)xamlUserType75).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType75;
			break;
		}
		case 188:
		{
			object xamlUserType74 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType74).Activator = Activate_188_BedrockLocalMultiplayerPage;
			((XamlUserType)xamlUserType74).StaticInitializer = StaticInitializer_188_BedrockLocalMultiplayerPage;
			((XamlUserType)xamlUserType74).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType74;
			break;
		}
		case 189:
		{
			object xamlUserType73 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType73).Activator = Activate_189_BedrockMaterialPackConverterPage;
			((XamlUserType)xamlUserType73).StaticInitializer = StaticInitializer_189_BedrockMaterialPackConverterPage;
			((XamlUserType)xamlUserType73).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType73;
			break;
		}
		case 190:
		{
			object xamlUserType72 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType72).Activator = Activate_190_BedrockMaterialPacksPage;
			((XamlUserType)xamlUserType72).StaticInitializer = StaticInitializer_190_BedrockMaterialPacksPage;
			((XamlUserType)xamlUserType72).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType72;
			break;
		}
		case 191:
		{
			object xamlUserType71 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType71).Activator = Activate_191_BedrockOnlineLobbyPage;
			((XamlUserType)xamlUserType71).StaticInitializer = StaticInitializer_191_BedrockOnlineLobbyPage;
			((XamlUserType)xamlUserType71).AddMemberName("Rooms");
			((XamlUserType)xamlUserType71).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType71;
			break;
		}
		case 192:
		{
			object xamlUserType70 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom>"));
			((XamlUserType)xamlUserType70).StaticInitializer = StaticInitializer_192_ObservableCollection;
			((XamlUserType)xamlUserType70).CollectionAdd = VectorAdd_192_ObservableCollection;
			((XamlUserType)xamlUserType70).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType70;
			break;
		}
		case 193:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_193_Collection,
				StaticInitializer = StaticInitializer_193_Collection,
				CollectionAdd = VectorAdd_193_Collection
			};
			break;
		case 194:
		{
			object xamlUserType69 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType69).Activator = Activate_194_BedrockOnlineLobbyRoom;
			((XamlUserType)xamlUserType69).StaticInitializer = StaticInitializer_194_BedrockOnlineLobbyRoom;
			((XamlUserType)xamlUserType69).AddMemberName("RoomId");
			((XamlUserType)xamlUserType69).AddMemberName("Name");
			((XamlUserType)xamlUserType69).AddMemberName("Description");
			((XamlUserType)xamlUserType69).AddMemberName("ResourceId");
			((XamlUserType)xamlUserType69).AddMemberName("OwnerId");
			((XamlUserType)xamlUserType69).AddMemberName("Version");
			((XamlUserType)xamlUserType69).AddMemberName("PlayerCount");
			((XamlUserType)xamlUserType69).AddMemberName("Capacity");
			((XamlUserType)xamlUserType69).AddMemberName("HasPassword");
			((XamlUserType)xamlUserType69).AddMemberName("PlayerText");
			((XamlUserType)xamlUserType69).AddMemberName("VersionText");
			result = (XamlSystemBaseType)xamlUserType69;
			break;
		}
		case 195:
		{
			object xamlUserType68 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType68).Activator = Activate_195_BedrockRentalRoomsPage;
			((XamlUserType)xamlUserType68).StaticInitializer = StaticInitializer_195_BedrockRentalRoomsPage;
			((XamlUserType)xamlUserType68).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType68;
			break;
		}
		case 196:
		{
			object xamlUserType67 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType67).Activator = Activate_196_BedrockServersPage;
			((XamlUserType)xamlUserType67).StaticInitializer = StaticInitializer_196_BedrockServersPage;
			((XamlUserType)xamlUserType67).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType67;
			break;
		}
		case 197:
		{
			object xamlUserType66 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType66).Activator = Activate_197_BedrockSkinsPage;
			((XamlUserType)xamlUserType66).StaticInitializer = StaticInitializer_197_BedrockSkinsPage;
			((XamlUserType)xamlUserType66).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType66;
			break;
		}
		case 198:
		{
			object xamlUserType65 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType65).Activator = Activate_198_BedrockVersionManagementPage;
			((XamlUserType)xamlUserType65).StaticInitializer = StaticInitializer_198_BedrockVersionManagementPage;
			((XamlUserType)xamlUserType65).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType65;
			break;
		}
		case 199:
		{
			object xamlUserType64 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType64).Activator = Activate_199_BedrockWorldsPage;
			((XamlUserType)xamlUserType64).StaticInitializer = StaticInitializer_199_BedrockWorldsPage;
			((XamlUserType)xamlUserType64).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType64;
			break;
		}
		case 200:
		{
			object xamlUserType63 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType63).Activator = Activate_200_DealerPage;
			((XamlUserType)xamlUserType63).StaticInitializer = StaticInitializer_200_DealerPage;
			((XamlUserType)xamlUserType63).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType63;
			break;
		}
		case 201:
		{
			object xamlUserType62 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType62).Activator = Activate_201_HomePage;
			((XamlUserType)xamlUserType62).StaticInitializer = StaticInitializer_201_HomePage;
			((XamlUserType)xamlUserType62).AddMemberName("HomeTimelineList");
			((XamlUserType)xamlUserType62).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType62;
			break;
		}
		case 202:
		{
			object xamlUserType61 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Views.Pages.TimelineEntry>"));
			((XamlUserType)xamlUserType61).StaticInitializer = StaticInitializer_202_ObservableCollection;
			((XamlUserType)xamlUserType61).CollectionAdd = VectorAdd_202_ObservableCollection;
			((XamlUserType)xamlUserType61).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType61;
			break;
		}
		case 203:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_203_Collection,
				StaticInitializer = StaticInitializer_203_Collection,
				CollectionAdd = VectorAdd_203_Collection
			};
			break;
		case 204:
		{
			object xamlUserType60 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType60).Activator = Activate_204_TimelineEntry;
			((XamlUserType)xamlUserType60).StaticInitializer = StaticInitializer_204_TimelineEntry;
			((XamlUserType)xamlUserType60).AddMemberName("VersionText");
			((XamlUserType)xamlUserType60).AddMemberName("DateText");
			((XamlUserType)xamlUserType60).AddMemberName("IsLatest");
			((XamlUserType)xamlUserType60).AddMemberName("LatestBadgeVisibility");
			((XamlUserType)xamlUserType60).AddMemberName("Notes");
			((XamlUserType)xamlUserType60).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType60;
			break;
		}
		case 205:
		{
			object xamlUserType59 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType59).StaticInitializer = StaticInitializer_205_List;
			((XamlUserType)xamlUserType59).CollectionAdd = VectorAdd_205_List;
			((XamlUserType)xamlUserType59).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType59;
			break;
		}
		case 206:
		{
			object xamlUserType58 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType58).Activator = Activate_206_TimelineNote;
			((XamlUserType)xamlUserType58).StaticInitializer = StaticInitializer_206_TimelineNote;
			((XamlUserType)xamlUserType58).AddMemberName("TagText");
			((XamlUserType)xamlUserType58).AddMemberName("TagColor");
			((XamlUserType)xamlUserType58).AddMemberName("TagBackground");
			((XamlUserType)xamlUserType58).AddMemberName("IconGlyph");
			((XamlUserType)xamlUserType58).AddMemberName("Content");
			((XamlUserType)xamlUserType58).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType58;
			break;
		}
		case 207:
		{
			object xamlUserType57 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType57).Activator = Activate_207_HookLoginPage;
			((XamlUserType)xamlUserType57).StaticInitializer = StaticInitializer_207_HookLoginPage;
			((XamlUserType)xamlUserType57).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType57;
			break;
		}
		case 208:
		{
			object xamlUserType56 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType56).Activator = Activate_208_InvitationPage;
			((XamlUserType)xamlUserType56).StaticInitializer = StaticInitializer_208_InvitationPage;
			((XamlUserType)xamlUserType56).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType56;
			break;
		}
		case 209:
		{
			object xamlUserType55 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType55).Activator = Activate_209_JavaAccountPage;
			((XamlUserType)xamlUserType55).StaticInitializer = StaticInitializer_209_JavaAccountPage;
			((XamlUserType)xamlUserType55).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType55;
			break;
		}
		case 210:
		{
			object xamlUserType54 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType54).Activator = Activate_210_JavaCompatibilityInstancesPage;
			((XamlUserType)xamlUserType54).StaticInitializer = StaticInitializer_210_JavaCompatibilityInstancesPage;
			((XamlUserType)xamlUserType54).AddMemberName("ManagedInstances");
			((XamlUserType)xamlUserType54).AddMemberName("ProxyInstances");
			((XamlUserType)xamlUserType54).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType54;
			break;
		}
		case 211:
		{
			object xamlUserType53 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.JavaInstanceInfo>"));
			((XamlUserType)xamlUserType53).StaticInitializer = StaticInitializer_211_ObservableCollection;
			((XamlUserType)xamlUserType53).CollectionAdd = VectorAdd_211_ObservableCollection;
			((XamlUserType)xamlUserType53).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType53;
			break;
		}
		case 212:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_212_Collection,
				StaticInitializer = StaticInitializer_212_Collection,
				CollectionAdd = VectorAdd_212_Collection
			};
			break;
		case 213:
		{
			object xamlUserType52 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType52).Activator = Activate_213_JavaInstanceInfo;
			((XamlUserType)xamlUserType52).StaticInitializer = StaticInitializer_213_JavaInstanceInfo;
			((XamlUserType)xamlUserType52).AddMemberName("Id");
			((XamlUserType)xamlUserType52).AddMemberName("ServerId");
			((XamlUserType)xamlUserType52).AddMemberName("ServerName");
			((XamlUserType)xamlUserType52).AddMemberName("RoleId");
			((XamlUserType)xamlUserType52).AddMemberName("RoleName");
			((XamlUserType)xamlUserType52).AddMemberName("Version");
			((XamlUserType)xamlUserType52).AddMemberName("ExecutorPath");
			((XamlUserType)xamlUserType52).AddMemberName("WorkingDirectory");
			((XamlUserType)xamlUserType52).AddMemberName("ProcessId");
			((XamlUserType)xamlUserType52).AddMemberName("StartedAt");
			((XamlUserType)xamlUserType52).AddMemberName("State");
			((XamlUserType)xamlUserType52).AddMemberName("ExitCode");
			((XamlUserType)xamlUserType52).AddMemberName("AuthPort");
			((XamlUserType)xamlUserType52).AddMemberName("RpcPort");
			((XamlUserType)xamlUserType52).AddMemberName("RecentLogs");
			((XamlUserType)xamlUserType52).AddMemberName("ServerImageUrl");
			((XamlUserType)xamlUserType52).AddMemberName("CrashReport");
			((XamlUserType)xamlUserType52).AddMemberName("IsRunning");
			((XamlUserType)xamlUserType52).AddMemberName("CanStop");
			((XamlUserType)xamlUserType52).AddMemberName("CanRestart");
			((XamlUserType)xamlUserType52).AddMemberName("StatusText");
			((XamlUserType)xamlUserType52).AddMemberName("ExecutorName");
			((XamlUserType)xamlUserType52).AddMemberName("ProcessIdText");
			((XamlUserType)xamlUserType52).AddMemberName("StartedAtText");
			((XamlUserType)xamlUserType52).AddMemberName("PortText");
			((XamlUserType)xamlUserType52).AddMemberName("RecentLogText");
			((XamlUserType)xamlUserType52).AddMemberName("HasCrashReport");
			((XamlUserType)xamlUserType52).AddMemberName("HasRawCrashArtifact");
			((XamlUserType)xamlUserType52).AddMemberName("CrashSummaryText");
			((XamlUserType)xamlUserType52).AddMemberName("CrashFindingText");
			((XamlUserType)xamlUserType52).AddMemberName("CrashArtifactPathText");
			((XamlUserType)xamlUserType52).AddMemberName("PrimaryCrashArtifactPath");
			((XamlUserType)xamlUserType52).AddMemberName("InstanceKindText");
			((XamlUserType)xamlUserType52).AddMemberName("DetailText");
			result = (XamlSystemBaseType)xamlUserType52;
			break;
		}
		case 214:
		{
			object xamlUserType51 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType51).StaticInitializer = StaticInitializer_214_DateTimeOffset;
			((XamlUserType)xamlUserType51).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType51;
			break;
		}
		case 215:
		{
			object xamlUserType50 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType50).StaticInitializer = StaticInitializer_215_JavaInstanceState;
			((XamlUserType)xamlUserType50).AddEnumValue("Preparing", (object)(ehKrWCfFyUBmIViVuUtd)0);
			((XamlUserType)xamlUserType50).AddEnumValue("Starting", (object)(ehKrWCfFyUBmIViVuUtd)1);
			((XamlUserType)xamlUserType50).AddEnumValue("Running", (object)(ehKrWCfFyUBmIViVuUtd)2);
			((XamlUserType)xamlUserType50).AddEnumValue("Disconnected", (object)(ehKrWCfFyUBmIViVuUtd)3);
			((XamlUserType)xamlUserType50).AddEnumValue("Reconnecting", (object)(ehKrWCfFyUBmIViVuUtd)4);
			((XamlUserType)xamlUserType50).AddEnumValue("Stopping", (object)(ehKrWCfFyUBmIViVuUtd)5);
			((XamlUserType)xamlUserType50).AddEnumValue("Exited", (object)(ehKrWCfFyUBmIViVuUtd)6);
			((XamlUserType)xamlUserType50).AddEnumValue("Failed", (object)(ehKrWCfFyUBmIViVuUtd)7);
			result = (XamlSystemBaseType)xamlUserType50;
			break;
		}
		case 216:
		{
			object xamlUserType49 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType49).SetBoxedType(GetXamlTypeByName("Int32"));
			((XamlUserType)xamlUserType49).BoxInstance = ((XamlUserType)xamlUserType49).BoxType<int>;
			((XamlUserType)xamlUserType49).StaticInitializer = StaticInitializer_216_Nullable;
			((XamlUserType)xamlUserType49).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType49;
			break;
		}
		case 217:
		{
			object xamlUserType48 = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType48).StaticInitializer = StaticInitializer_217_IReadOnlyList;
			((XamlUserType)xamlUserType48).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType48;
			break;
		}
		case 218:
		{
			object xamlUserType47 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType47).StaticInitializer = StaticInitializer_218_JavaCrashReport;
			((XamlUserType)xamlUserType47).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType47;
			break;
		}
		case 219:
		{
			object xamlUserType46 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot>"));
			((XamlUserType)xamlUserType46).StaticInitializer = StaticInitializer_219_ObservableCollection;
			((XamlUserType)xamlUserType46).CollectionAdd = VectorAdd_219_ObservableCollection;
			((XamlUserType)xamlUserType46).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType46;
			break;
		}
		case 220:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_220_Collection,
				StaticInitializer = StaticInitializer_220_Collection,
				CollectionAdd = VectorAdd_220_Collection
			};
			break;
		case 221:
		{
			object xamlUserType45 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType45).StaticInitializer = StaticInitializer_221_JavaProxyInstanceSnapshot;
			((XamlUserType)xamlUserType45).AddMemberName("Id");
			((XamlUserType)xamlUserType45).AddMemberName("State");
			((XamlUserType)xamlUserType45).AddMemberName("LocalEndpoint");
			((XamlUserType)xamlUserType45).AddMemberName("RemoteEndpoint");
			((XamlUserType)xamlUserType45).AddMemberName("ProtocolVersion");
			((XamlUserType)xamlUserType45).AddMemberName("ActiveConnections");
			((XamlUserType)xamlUserType45).AddMemberName("Traffic");
			((XamlUserType)xamlUserType45).AddMemberName("LastDisconnectReason");
			((XamlUserType)xamlUserType45).AddMemberName("LastDisconnectDetail");
			((XamlUserType)xamlUserType45).AddMemberName("StartedAt");
			((XamlUserType)xamlUserType45).AddMemberName("AccountId");
			((XamlUserType)xamlUserType45).AddMemberName("ServerId");
			((XamlUserType)xamlUserType45).AddMemberName("ServerName");
			((XamlUserType)xamlUserType45).AddMemberName("RoleId");
			((XamlUserType)xamlUserType45).AddMemberName("RoleName");
			((XamlUserType)xamlUserType45).AddMemberName("VersionName");
			((XamlUserType)xamlUserType45).AddMemberName("AccountDisplayText");
			((XamlUserType)xamlUserType45).AddMemberName("LocalAddressText");
			((XamlUserType)xamlUserType45).AddMemberName("StateText");
			((XamlUserType)xamlUserType45).AddMemberName("ServerRoleText");
			((XamlUserType)xamlUserType45).AddMemberName("StartedAtText");
			((XamlUserType)xamlUserType45).AddMemberName("TrafficText");
			((XamlUserType)xamlUserType45).AddMemberName("DisconnectText");
			((XamlUserType)xamlUserType45).AddMemberName("CanStop");
			((XamlUserType)xamlUserType45).AddMemberName("CanRetry");
			result = (XamlSystemBaseType)xamlUserType45;
			break;
		}
		case 222:
		{
			object xamlUserType44 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType44).StaticInitializer = StaticInitializer_222_JavaProxyInstanceState;
			((XamlUserType)xamlUserType44).AddEnumValue("Starting", (object)(n1qKx2fNJL9msKD7ZGJu)0);
			((XamlUserType)xamlUserType44).AddEnumValue("Listening", (object)(n1qKx2fNJL9msKD7ZGJu)1);
			((XamlUserType)xamlUserType44).AddEnumValue("Running", (object)(n1qKx2fNJL9msKD7ZGJu)2);
			((XamlUserType)xamlUserType44).AddEnumValue("Preparing", (object)(n1qKx2fNJL9msKD7ZGJu)3);
			((XamlUserType)xamlUserType44).AddEnumValue("WaitingForClient", (object)(n1qKx2fNJL9msKD7ZGJu)4);
			((XamlUserType)xamlUserType44).AddEnumValue("ClientConnected", (object)(n1qKx2fNJL9msKD7ZGJu)5);
			((XamlUserType)xamlUserType44).AddEnumValue("Authenticating", (object)(n1qKx2fNJL9msKD7ZGJu)6);
			((XamlUserType)xamlUserType44).AddEnumValue("RawForwarding", (object)(n1qKx2fNJL9msKD7ZGJu)7);
			((XamlUserType)xamlUserType44).AddEnumValue("Forwarding", (object)(n1qKx2fNJL9msKD7ZGJu)8);
			((XamlUserType)xamlUserType44).AddEnumValue("Transferring", (object)(n1qKx2fNJL9msKD7ZGJu)9);
			((XamlUserType)xamlUserType44).AddEnumValue("Stopping", (object)(n1qKx2fNJL9msKD7ZGJu)10);
			((XamlUserType)xamlUserType44).AddEnumValue("Stopped", (object)(n1qKx2fNJL9msKD7ZGJu)11);
			((XamlUserType)xamlUserType44).AddEnumValue("Failed", (object)(n1qKx2fNJL9msKD7ZGJu)12);
			result = (XamlSystemBaseType)xamlUserType44;
			break;
		}
		case 223:
		{
			object xamlUserType43 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType43).StaticInitializer = StaticInitializer_223_JavaProxyEndpoint;
			((XamlUserType)xamlUserType43).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType43;
			break;
		}
		case 224:
		{
			object xamlUserType42 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType42).StaticInitializer = StaticInitializer_224_JavaProxyTrafficSnapshot;
			((XamlUserType)xamlUserType42).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType42;
			break;
		}
		case 225:
		{
			object xamlUserType41 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			((XamlUserType)xamlUserType41).StaticInitializer = StaticInitializer_225_JavaProxyDisconnectReason;
			((XamlUserType)xamlUserType41).AddEnumValue("None", (object)(f3JeIyfNCcv94eShPUIb)0);
			((XamlUserType)xamlUserType41).AddEnumValue("LocalClosed", (object)(f3JeIyfNCcv94eShPUIb)1);
			((XamlUserType)xamlUserType41).AddEnumValue("RemoteClosed", (object)(f3JeIyfNCcv94eShPUIb)2);
			((XamlUserType)xamlUserType41).AddEnumValue("Canceled", (object)(f3JeIyfNCcv94eShPUIb)3);
			((XamlUserType)xamlUserType41).AddEnumValue("NetworkError", (object)(f3JeIyfNCcv94eShPUIb)4);
			((XamlUserType)xamlUserType41).AddEnumValue("ProtocolError", (object)(f3JeIyfNCcv94eShPUIb)5);
			((XamlUserType)xamlUserType41).AddEnumValue("AuthenticationFailed", (object)(f3JeIyfNCcv94eShPUIb)6);
			((XamlUserType)xamlUserType41).AddEnumValue("ConnectionAuthorizationFailed", (object)(f3JeIyfNCcv94eShPUIb)7);
			((XamlUserType)xamlUserType41).AddEnumValue("IdentityMismatch", (object)(f3JeIyfNCcv94eShPUIb)8);
			((XamlUserType)xamlUserType41).AddEnumValue("ConnectionLimitReached", (object)(f3JeIyfNCcv94eShPUIb)9);
			((XamlUserType)xamlUserType41).AddEnumValue("TimedOut", (object)(f3JeIyfNCcv94eShPUIb)10);
			((XamlUserType)xamlUserType41).AddEnumValue("SocksAuthenticationFailed", (object)(f3JeIyfNCcv94eShPUIb)11);
			((XamlUserType)xamlUserType41).AddEnumValue("TransferRequested", (object)(f3JeIyfNCcv94eShPUIb)12);
			((XamlUserType)xamlUserType41).AddEnumValue("InternalError", (object)(f3JeIyfNCcv94eShPUIb)13);
			result = (XamlSystemBaseType)xamlUserType41;
			break;
		}
		case 226:
		{
			object xamlUserType40 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType40).Activator = Activate_226_JavaCompatibilityToolsPage;
			((XamlUserType)xamlUserType40).StaticInitializer = StaticInitializer_226_JavaCompatibilityToolsPage;
			((XamlUserType)xamlUserType40).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType40;
			break;
		}
		case 227:
		{
			object xamlUserType39 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType39).Activator = Activate_227_JavaHookEntryPage;
			((XamlUserType)xamlUserType39).StaticInitializer = StaticInitializer_227_JavaHookEntryPage;
			((XamlUserType)xamlUserType39).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType39;
			break;
		}
		case 228:
		{
			object xamlUserType38 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType38).Activator = Activate_228_JavaInstancesPage;
			((XamlUserType)xamlUserType38).StaticInitializer = StaticInitializer_228_JavaInstancesPage;
			((XamlUserType)xamlUserType38).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType38;
			break;
		}
		case 229:
		{
			object xamlUserType37 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType37).Activator = Activate_229_JavaServersPage;
			((XamlUserType)xamlUserType37).StaticInitializer = StaticInitializer_229_JavaServersPage;
			((XamlUserType)xamlUserType37).AddMemberName("Servers");
			((XamlUserType)xamlUserType37).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType37;
			break;
		}
		case 230:
		{
			object xamlUserType36 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.JavaServer>"));
			((XamlUserType)xamlUserType36).StaticInitializer = StaticInitializer_230_ObservableCollection;
			((XamlUserType)xamlUserType36).CollectionAdd = VectorAdd_230_ObservableCollection;
			((XamlUserType)xamlUserType36).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType36;
			break;
		}
		case 231:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_231_Collection,
				StaticInitializer = StaticInitializer_231_Collection,
				CollectionAdd = VectorAdd_231_Collection
			};
			break;
		case 232:
		{
			object xamlUserType35 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType35).Activator = Activate_232_JavaServer;
			((XamlUserType)xamlUserType35).StaticInitializer = StaticInitializer_232_JavaServer;
			((XamlUserType)xamlUserType35).AddMemberName("Id");
			((XamlUserType)xamlUserType35).AddMemberName("DetailEntityId");
			((XamlUserType)xamlUserType35).AddMemberName("CatalogItemId");
			((XamlUserType)xamlUserType35).AddMemberName("ServerAddress");
			((XamlUserType)xamlUserType35).AddMemberName("ServerPort");
			((XamlUserType)xamlUserType35).AddMemberName("Name");
			((XamlUserType)xamlUserType35).AddMemberName("Summary");
			((XamlUserType)xamlUserType35).AddMemberName("Description");
			((XamlUserType)xamlUserType35).AddMemberName("OnlineCount");
			((XamlUserType)xamlUserType35).AddMemberName("MaximumPlayers");
			((XamlUserType)xamlUserType35).AddMemberName("ImageUrl");
			((XamlUserType)xamlUserType35).AddMemberName("Author");
			((XamlUserType)xamlUserType35).AddMemberName("Versions");
			((XamlUserType)xamlUserType35).AddMemberName("OnlineText");
			((XamlUserType)xamlUserType35).AddMemberName("VersionText");
			((XamlUserType)xamlUserType35).AddMemberName("OnlineDisplayText");
			result = (XamlSystemBaseType)xamlUserType35;
			break;
		}
		case 233:
		{
			object xamlUserType34 = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType34).StaticInitializer = StaticInitializer_233_IReadOnlyList;
			((XamlUserType)xamlUserType34).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType34;
			break;
		}
		case 234:
		{
			object xamlUserType33 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType33).Activator = Activate_234_JavaSkinsPage;
			((XamlUserType)xamlUserType33).StaticInitializer = StaticInitializer_234_JavaSkinsPage;
			((XamlUserType)xamlUserType33).AddMemberName("Skins");
			((XamlUserType)xamlUserType33).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType33;
			break;
		}
		case 235:
		{
			object xamlUserType32 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel>"));
			((XamlUserType)xamlUserType32).StaticInitializer = StaticInitializer_235_ObservableCollection;
			((XamlUserType)xamlUserType32).CollectionAdd = VectorAdd_235_ObservableCollection;
			((XamlUserType)xamlUserType32).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType32;
			break;
		}
		case 236:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_236_Collection,
				StaticInitializer = StaticInitializer_236_Collection,
				CollectionAdd = VectorAdd_236_Collection
			};
			break;
		case 237:
		{
			object xamlUserType31 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType31).StaticInitializer = StaticInitializer_237_JavaSkinCardViewModel;
			((XamlUserType)xamlUserType31).AddMemberName("Skin");
			((XamlUserType)xamlUserType31).AddMemberName("Name");
			((XamlUserType)xamlUserType31).AddMemberName("Developer");
			((XamlUserType)xamlUserType31).AddMemberName("Summary");
			((XamlUserType)xamlUserType31).AddMemberName("CoverUrl");
			((XamlUserType)xamlUserType31).AddMemberName("MetricsText");
			((XamlUserType)xamlUserType31).AddMemberName("OwnershipText");
			((XamlUserType)xamlUserType31).AddMemberName("IsApplied");
			((XamlUserType)xamlUserType31).AddMemberName("AppliedVisibility");
			((XamlUserType)xamlUserType31).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType31;
			break;
		}
		case 238:
		{
			object xamlUserType30 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType30).StaticInitializer = StaticInitializer_238_JavaSkin;
			((XamlUserType)xamlUserType30).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType30;
			break;
		}
		case 239:
		{
			object xamlUserType29 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType29).Activator = Activate_239_JavaVersionManagementPage;
			((XamlUserType)xamlUserType29).StaticInitializer = StaticInitializer_239_JavaVersionManagementPage;
			((XamlUserType)xamlUserType29).AddMemberName("Installations");
			((XamlUserType)xamlUserType29).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType29;
			break;
		}
		case 240:
		{
			object xamlUserType28 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Java.JavaVersionInstallationInfo>"));
			((XamlUserType)xamlUserType28).StaticInitializer = StaticInitializer_240_ObservableCollection;
			((XamlUserType)xamlUserType28).CollectionAdd = VectorAdd_240_ObservableCollection;
			((XamlUserType)xamlUserType28).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType28;
			break;
		}
		case 241:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_241_Collection,
				StaticInitializer = StaticInitializer_241_Collection,
				CollectionAdd = VectorAdd_241_Collection
			};
			break;
		case 242:
		{
			object xamlUserType27 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType27).Activator = Activate_242_JavaVersionInstallationInfo;
			((XamlUserType)xamlUserType27).StaticInitializer = StaticInitializer_242_JavaVersionInstallationInfo;
			((XamlUserType)xamlUserType27).AddMemberName("Version");
			((XamlUserType)xamlUserType27).AddMemberName("ClientInstalled");
			((XamlUserType)xamlUserType27).AddMemberName("Runtime");
			((XamlUserType)xamlUserType27).AddMemberName("RuntimeInstalled");
			((XamlUserType)xamlUserType27).AddMemberName("InstallationPath");
			((XamlUserType)xamlUserType27).AddMemberName("IsReady");
			((XamlUserType)xamlUserType27).AddMemberName("StatusText");
			((XamlUserType)xamlUserType27).AddMemberName("ClientStateText");
			((XamlUserType)xamlUserType27).AddMemberName("RuntimeStateText");
			((XamlUserType)xamlUserType27).AddMemberName("ActionText");
			((XamlUserType)xamlUserType27).AddMemberName("RuntimeText");
			result = (XamlSystemBaseType)xamlUserType27;
			break;
		}
		case 243:
		{
			object xamlUserType26 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType26).StaticInitializer = StaticInitializer_243_JavaMinecraftVersion;
			((XamlUserType)xamlUserType26).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType26;
			break;
		}
		case 244:
		{
			object xamlUserType25 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType25).StaticInitializer = StaticInitializer_244_JavaRuntimeProfile;
			((XamlUserType)xamlUserType25).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType25;
			break;
		}
		case 245:
		{
			object xamlUserType24 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType24).Activator = Activate_245_MediaPage;
			((XamlUserType)xamlUserType24).StaticInitializer = StaticInitializer_245_MediaPage;
			((XamlUserType)xamlUserType24).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType24;
			break;
		}
		case 246:
		{
			object xamlUserType23 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType23).Activator = Activate_246_Pay4399Page;
			((XamlUserType)xamlUserType23).StaticInitializer = StaticInitializer_246_Pay4399Page;
			((XamlUserType)xamlUserType23).AddMemberName("GeneratedAccountHistory");
			((XamlUserType)xamlUserType23).AddMemberName("PendingAccountHistory");
			((XamlUserType)xamlUserType23).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType23;
			break;
		}
		case 247:
		{
			object xamlUserType22 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Pay4399AccountRecord>"));
			((XamlUserType)xamlUserType22).StaticInitializer = StaticInitializer_247_ObservableCollection;
			((XamlUserType)xamlUserType22).CollectionAdd = VectorAdd_247_ObservableCollection;
			((XamlUserType)xamlUserType22).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType22;
			break;
		}
		case 248:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_248_Collection,
				StaticInitializer = StaticInitializer_248_Collection,
				CollectionAdd = VectorAdd_248_Collection
			};
			break;
		case 249:
		{
			object xamlUserType21 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType21).Activator = Activate_249_Pay4399AccountRecord;
			((XamlUserType)xamlUserType21).StaticInitializer = StaticInitializer_249_Pay4399AccountRecord;
			((XamlUserType)xamlUserType21).AddMemberName("Id");
			((XamlUserType)xamlUserType21).AddMemberName("Username");
			((XamlUserType)xamlUserType21).AddMemberName("Password");
			((XamlUserType)xamlUserType21).AddMemberName("SauthJson");
			((XamlUserType)xamlUserType21).AddMemberName("Source");
			((XamlUserType)xamlUserType21).AddMemberName("CreatedAt");
			((XamlUserType)xamlUserType21).AddMemberName("UpdatedAt");
			((XamlUserType)xamlUserType21).AddMemberName("HasSauth");
			((XamlUserType)xamlUserType21).AddMemberName("UsernameText");
			((XamlUserType)xamlUserType21).AddMemberName("PasswordText");
			((XamlUserType)xamlUserType21).AddMemberName("AccountText");
			((XamlUserType)xamlUserType21).AddMemberName("SauthStateText");
			((XamlUserType)xamlUserType21).AddMemberName("SourceText");
			((XamlUserType)xamlUserType21).AddMemberName("SavedAtText");
			result = (XamlSystemBaseType)xamlUserType21;
			break;
		}
		case 250:
		{
			object xamlUserType20 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.Pay4399PendingAccountRecord>"));
			((XamlUserType)xamlUserType20).StaticInitializer = StaticInitializer_250_ObservableCollection;
			((XamlUserType)xamlUserType20).CollectionAdd = VectorAdd_250_ObservableCollection;
			((XamlUserType)xamlUserType20).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType20;
			break;
		}
		case 251:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_251_Collection,
				StaticInitializer = StaticInitializer_251_Collection,
				CollectionAdd = VectorAdd_251_Collection
			};
			break;
		case 252:
		{
			object xamlUserType19 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType19).Activator = Activate_252_Pay4399PendingAccountRecord;
			((XamlUserType)xamlUserType19).StaticInitializer = StaticInitializer_252_Pay4399PendingAccountRecord;
			((XamlUserType)xamlUserType19).AddMemberName("CredentialHash");
			((XamlUserType)xamlUserType19).AddMemberName("Channel");
			((XamlUserType)xamlUserType19).AddMemberName("OperationId");
			((XamlUserType)xamlUserType19).AddMemberName("Status");
			((XamlUserType)xamlUserType19).AddMemberName("ExpectedPrice");
			((XamlUserType)xamlUserType19).AddMemberName("Message");
			((XamlUserType)xamlUserType19).AddMemberName("CreatedAt");
			((XamlUserType)xamlUserType19).AddMemberName("StatusText");
			((XamlUserType)xamlUserType19).AddMemberName("CreatedAtText");
			result = (XamlSystemBaseType)xamlUserType19;
			break;
		}
		case 253:
		{
			object xamlUserType18 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			((XamlUserType)xamlUserType18).StaticInitializer = StaticInitializer_253_Decimal;
			((XamlUserType)xamlUserType18).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType18;
			break;
		}
		case 254:
		{
			object xamlUserType17 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType17).Activator = Activate_254_PaymentCenterOrdersPage;
			((XamlUserType)xamlUserType17).StaticInitializer = StaticInitializer_254_PaymentCenterOrdersPage;
			((XamlUserType)xamlUserType17).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType17;
			break;
		}
		case 255:
		{
			object xamlUserType16 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType16).Activator = Activate_255_PaymentCenterPage;
			((XamlUserType)xamlUserType16).StaticInitializer = StaticInitializer_255_PaymentCenterPage;
			((XamlUserType)xamlUserType16).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType16;
			break;
		}
		case 256:
		{
			object xamlUserType15 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType15).Activator = Activate_256_PaymentCenterRefundsPage;
			((XamlUserType)xamlUserType15).StaticInitializer = StaticInitializer_256_PaymentCenterRefundsPage;
			((XamlUserType)xamlUserType15).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType15;
			break;
		}
		case 257:
		{
			object xamlUserType14 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType14).Activator = Activate_257_PaymentOrdersPage;
			((XamlUserType)xamlUserType14).StaticInitializer = StaticInitializer_257_PaymentOrdersPage;
			((XamlUserType)xamlUserType14).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType14;
			break;
		}
		case 258:
		{
			object xamlUserType13 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType13).Activator = Activate_258_ProductDetailPage;
			((XamlUserType)xamlUserType13).StaticInitializer = StaticInitializer_258_ProductDetailPage;
			((XamlUserType)xamlUserType13).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType13;
			break;
		}
		case 259:
		{
			object xamlUserType12 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType12).StaticInitializer = StaticInitializer_259_Motion;
			((XamlUserType)xamlUserType12).AddMemberName("Lift");
			((XamlUserType)xamlUserType12).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType12;
			break;
		}
		case 260:
		{
			object xamlUserType11 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType11).StaticInitializer = StaticInitializer_260_Effects;
			((XamlUserType)xamlUserType11).AddMemberName("Shadow");
			result = (XamlSystemBaseType)xamlUserType11;
			break;
		}
		case 261:
		{
			object xamlUserType10 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType10).Activator = Activate_261_ProductPage;
			((XamlUserType)xamlUserType10).StaticInitializer = StaticInitializer_261_ProductPage;
			((XamlUserType)xamlUserType10).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType10;
			break;
		}
		case 262:
		{
			object xamlUserType9 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType9).Activator = Activate_262_QrLoginPage;
			((XamlUserType)xamlUserType9).StaticInitializer = StaticInitializer_262_QrLoginPage;
			((XamlUserType)xamlUserType9).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType9;
			break;
		}
		case 263:
		{
			object xamlUserType8 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType8).Activator = Activate_263_RefundHistoryPage;
			((XamlUserType)xamlUserType8).StaticInitializer = StaticInitializer_263_RefundHistoryPage;
			((XamlUserType)xamlUserType8).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType8;
			break;
		}
		case 264:
		{
			object xamlUserType7 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType7).Activator = Activate_264_ServiceSubscriptionsPage;
			((XamlUserType)xamlUserType7).StaticInitializer = StaticInitializer_264_ServiceSubscriptionsPage;
			((XamlUserType)xamlUserType7).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType7;
			break;
		}
		case 265:
		{
			object xamlUserType6 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType6).Activator = Activate_265_ToolboxPage;
			((XamlUserType)xamlUserType6).StaticInitializer = StaticInitializer_265_ToolboxPage;
			((XamlUserType)xamlUserType6).AddMemberName("AccountSwitchInstances");
			((XamlUserType)xamlUserType6).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType6;
			break;
		}
		case 266:
		{
			object xamlUserType5 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Page"));
			((XamlUserType)xamlUserType5).Activator = Activate_266_X19LoginPage;
			((XamlUserType)xamlUserType5).StaticInitializer = StaticInitializer_266_X19LoginPage;
			((XamlUserType)xamlUserType5).AddMemberName("GeneratedAccountHistory");
			((XamlUserType)xamlUserType5).SetIsLocalType();
			result = (XamlSystemBaseType)xamlUserType5;
			break;
		}
		case 267:
		{
			object xamlUserType4 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Mahiro_Account.Models.X19AccountRecord>"));
			((XamlUserType)xamlUserType4).StaticInitializer = StaticInitializer_267_ObservableCollection;
			((XamlUserType)xamlUserType4).CollectionAdd = VectorAdd_267_ObservableCollection;
			((XamlUserType)xamlUserType4).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType4;
			break;
		}
		case 268:
			result = (XamlSystemBaseType)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"))
			{
				Activator = Activate_268_Collection,
				StaticInitializer = StaticInitializer_268_Collection,
				CollectionAdd = VectorAdd_268_Collection
			};
			break;
		case 269:
		{
			object xamlUserType3 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			((XamlUserType)xamlUserType3).Activator = Activate_269_X19AccountRecord;
			((XamlUserType)xamlUserType3).StaticInitializer = StaticInitializer_269_X19AccountRecord;
			((XamlUserType)xamlUserType3).AddMemberName("Id");
			((XamlUserType)xamlUserType3).AddMemberName("Account");
			((XamlUserType)xamlUserType3).AddMemberName("Password");
			((XamlUserType)xamlUserType3).AddMemberName("SauthJson");
			((XamlUserType)xamlUserType3).AddMemberName("LoginMode");
			((XamlUserType)xamlUserType3).AddMemberName("CreatedAt");
			((XamlUserType)xamlUserType3).AddMemberName("UpdatedAt");
			((XamlUserType)xamlUserType3).AddMemberName("HasSauth");
			((XamlUserType)xamlUserType3).AddMemberName("AccountDisplayText");
			((XamlUserType)xamlUserType3).AddMemberName("CopyText");
			((XamlUserType)xamlUserType3).AddMemberName("SauthStateText");
			((XamlUserType)xamlUserType3).AddMemberName("LoginModeText");
			((XamlUserType)xamlUserType3).AddMemberName("SavedAtText");
			result = (XamlSystemBaseType)xamlUserType3;
			break;
		}
		case 270:
		{
			object xamlUserType2 = (object)new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			((XamlUserType)xamlUserType2).Activator = Activate_270_TreeViewNode;
			((XamlUserType)xamlUserType2).StaticInitializer = StaticInitializer_270_TreeViewNode;
			((XamlUserType)xamlUserType2).AddMemberName("Children");
			((XamlUserType)xamlUserType2).AddMemberName("Content");
			((XamlUserType)xamlUserType2).AddMemberName("Depth");
			((XamlUserType)xamlUserType2).AddMemberName("HasChildren");
			((XamlUserType)xamlUserType2).AddMemberName("HasUnrealizedChildren");
			((XamlUserType)xamlUserType2).AddMemberName("IsExpanded");
			((XamlUserType)xamlUserType2).AddMemberName("Parent");
			((XamlUserType)xamlUserType2).SetIsBindable();
			result = (XamlSystemBaseType)xamlUserType2;
			break;
		}
		case 271:
		{
			object xamlUserType = (object)new XamlUserType(this, fullName, type, (IXamlType)null);
			((XamlUserType)xamlUserType).StaticInitializer = StaticInitializer_271_IList;
			((XamlUserType)xamlUserType).CollectionAdd = VectorAdd_271_IList;
			((XamlUserType)xamlUserType).SetIsReturnTypeStub();
			result = (XamlSystemBaseType)xamlUserType;
			break;
		}
		}
		return (IXamlType)(object)result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private IXamlType CheckOtherMetadataProvidersForName(string typeName)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		IXamlType val = null;
		IXamlType result = null;
		var enumerator = OtherProviders.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				val = enumerator.Current.GetXamlType(typeName);
				if (val != null)
				{
					if (val.IsConstructible)
					{
						return val;
					}
					result = val;
				}
			}
			return result;
		}
		finally
		{
			((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private IXamlType CheckOtherMetadataProvidersForType(global::System.Type type)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		IXamlType val = null;
		IXamlType result = null;
		var enumerator = OtherProviders.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				val = enumerator.Current.GetXamlType(type);
				if (val != null)
				{
					if (val.IsConstructible)
					{
						return val;
					}
					result = val;
				}
			}
			return result;
		}
		finally
		{
			((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_0_XamlControlsResources_UseCompactResources(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((XamlControlsResources)instance).UseCompactResources;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_0_XamlControlsResources_UseCompactResources(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((XamlControlsResources)instance).UseCompactResources = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_1_PageHeader_Title(object instance)
	{
		return ((PageHeader)instance).Title;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_1_PageHeader_Title(object instance, object Value)
	{
		((PageHeader)instance).Title = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_2_PageHeader_Subtitle(object instance)
	{
		return ((PageHeader)instance).Subtitle;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_2_PageHeader_Subtitle(object instance, object Value)
	{
		((PageHeader)instance).Subtitle = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_3_PageHeader_Actions(object instance)
	{
		return ((PageHeader)instance).Actions;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_3_PageHeader_Actions(object instance, object Value)
	{
		((PageHeader)instance).Actions = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_4_PageHeader_HasSubtitle(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((PageHeader)instance).HasSubtitle;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_5_ProgressRing_IsActive(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressRing)instance).IsActive;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_5_ProgressRing_IsActive(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressRing)instance).IsActive = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_6_ProgressRing_IsIndeterminate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressRing)instance).IsIndeterminate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_6_ProgressRing_IsIndeterminate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressRing)instance).IsIndeterminate = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_7_ProgressRing_Maximum(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressRing)instance).Maximum;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_7_ProgressRing_Maximum(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressRing)instance).Maximum = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_8_ProgressRing_Minimum(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressRing)instance).Minimum;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_8_ProgressRing_Minimum(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressRing)instance).Minimum = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_9_ProgressRing_TemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressRing)instance).TemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_10_ProgressRing_Value(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressRing)instance).Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_10_ProgressRing_Value(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressRing)instance).Value = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_11_InfoBar_Content(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).Content;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_11_InfoBar_Content(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).Content = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_12_InfoBar_IsOpen(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).IsOpen;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_12_InfoBar_IsOpen(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).IsOpen = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_13_InfoBar_IsClosable(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).IsClosable;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_13_InfoBar_IsClosable(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).IsClosable = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_14_InfoBar_Severity(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).Severity;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_14_InfoBar_Severity(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).Severity = (InfoBarSeverity)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_15_InfoBar_Title(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).Title;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_15_InfoBar_Title(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).Title = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_16_InfoBar_Message(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).Message;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_16_InfoBar_Message(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).Message = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_17_InfoBar_ActionButton(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).ActionButton;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_17_InfoBar_ActionButton(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((InfoBar)instance).ActionButton = (ButtonBase)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_18_InfoBar_CloseButtonCommand(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).CloseButtonCommand;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_18_InfoBar_CloseButtonCommand(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((InfoBar)instance).CloseButtonCommand = (ICommand)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_19_InfoBar_CloseButtonCommandParameter(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).CloseButtonCommandParameter;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_19_InfoBar_CloseButtonCommandParameter(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).CloseButtonCommandParameter = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_20_InfoBar_CloseButtonStyle(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).CloseButtonStyle;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_20_InfoBar_CloseButtonStyle(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((InfoBar)instance).CloseButtonStyle = (Style)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_21_InfoBar_ContentTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).ContentTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_21_InfoBar_ContentTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((InfoBar)instance).ContentTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_22_InfoBar_IconSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).IconSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_22_InfoBar_IconSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((InfoBar)instance).IconSource = (IconSource)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_23_InfoBar_IsIconVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).IsIconVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_23_InfoBar_IsIconVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((InfoBar)instance).IsIconVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_24_InfoBar_TemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((InfoBar)instance).TemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_25_BedrockAccountHistoryView_Accounts(object instance)
	{
		return ((BedrockAccountHistoryView)instance).Accounts;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_26_BedrockAccountHistoryItemViewModel_Id(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_27_BedrockAccountHistoryItemViewModel_GameUserId(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).GameUserId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_28_BedrockAccountHistoryItemViewModel_DisplayName(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).DisplayName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_29_BedrockAccountHistoryItemViewModel_AccountDisplayText(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).AccountDisplayText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_30_BedrockAccountHistoryItemViewModel_SavedAtValueText(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).SavedAtValueText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_31_BedrockAccountHistoryItemViewModel_IsDetailsEnabled(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).IsDetailsEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_32_BedrockAccountHistoryItemViewModel_AvatarSource(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).AvatarSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_33_BedrockAccountHistoryItemViewModel_FrameSource(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).FrameSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_34_BedrockAccountHistoryItemViewModel_FrameVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockAccountHistoryItemViewModel)instance).FrameVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_35_BedrockAccountHistoryItemViewModel_GrowthVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockAccountHistoryItemViewModel)instance).GrowthVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_36_BedrockAccountHistoryItemViewModel_MissingGrowthVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockAccountHistoryItemViewModel)instance).MissingGrowthVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_37_BedrockAccountHistoryItemViewModel_VipVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockAccountHistoryItemViewModel)instance).VipVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_38_BedrockAccountHistoryItemViewModel_SecondaryText(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).SecondaryText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_39_BedrockAccountHistoryItemViewModel_LevelText(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).LevelText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_40_BedrockAccountHistoryItemViewModel_VipText(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).VipText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_41_BedrockAccountHistoryItemViewModel_ExperienceText(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).ExperienceText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_42_BedrockAccountHistoryItemViewModel_ExperienceMaximum(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).ExperienceMaximum;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_43_BedrockAccountHistoryItemViewModel_ExperienceValue(object instance)
	{
		return ((BedrockAccountHistoryItemViewModel)instance).ExperienceValue;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_44_ProgressBar_IsIndeterminate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressBar)instance).IsIndeterminate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_44_ProgressBar_IsIndeterminate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressBar)instance).IsIndeterminate = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_45_ProgressBar_ShowError(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressBar)instance).ShowError;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_45_ProgressBar_ShowError(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressBar)instance).ShowError = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_46_ProgressBar_ShowPaused(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressBar)instance).ShowPaused;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_46_ProgressBar_ShowPaused(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ProgressBar)instance).ShowPaused = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_47_ProgressBar_TemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ProgressBar)instance).TemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_48_TabView_TabItems(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabItems;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_49_TabView_IsAddTabButtonVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).IsAddTabButtonVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_49_TabView_IsAddTabButtonVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).IsAddTabButtonVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_50_TabView_CanDragTabs(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).CanDragTabs;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_50_TabView_CanDragTabs(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).CanDragTabs = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_51_TabView_CanReorderTabs(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).CanReorderTabs;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_51_TabView_CanReorderTabs(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).CanReorderTabs = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_52_TabView_TabWidthMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabWidthMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_52_TabView_TabWidthMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).TabWidthMode = (TabViewWidthMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_53_TabView_AddTabButtonCommand(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).AddTabButtonCommand;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_53_TabView_AddTabButtonCommand(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TabView)instance).AddTabButtonCommand = (ICommand)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_54_TabView_AddTabButtonCommandParameter(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).AddTabButtonCommandParameter;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_54_TabView_AddTabButtonCommandParameter(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).AddTabButtonCommandParameter = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_55_TabView_AllowDropTabs(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).AllowDropTabs;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_55_TabView_AllowDropTabs(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).AllowDropTabs = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_56_TabView_CanTearOutTabs(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).CanTearOutTabs;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_56_TabView_CanTearOutTabs(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).CanTearOutTabs = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_57_TabView_CloseButtonOverlayMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).CloseButtonOverlayMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_57_TabView_CloseButtonOverlayMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).CloseButtonOverlayMode = (TabViewCloseButtonOverlayMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_58_TabView_SelectedIndex(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).SelectedIndex;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_58_TabView_SelectedIndex(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).SelectedIndex = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_59_TabView_SelectedItem(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).SelectedItem;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_59_TabView_SelectedItem(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).SelectedItem = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_60_TabView_TabItemTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabItemTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_60_TabView_TabItemTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TabView)instance).TabItemTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_61_TabView_TabItemTemplateSelector(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabItemTemplateSelector;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_61_TabView_TabItemTemplateSelector(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TabView)instance).TabItemTemplateSelector = (DataTemplateSelector)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_62_TabView_TabItemsSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabItemsSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_62_TabView_TabItemsSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).TabItemsSource = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_63_TabView_TabStripFooter(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabStripFooter;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_63_TabView_TabStripFooter(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).TabStripFooter = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_64_TabView_TabStripFooterTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabStripFooterTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_64_TabView_TabStripFooterTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TabView)instance).TabStripFooterTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_65_TabView_TabStripHeader(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabStripHeader;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_65_TabView_TabStripHeader(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabView)instance).TabStripHeader = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_66_TabView_TabStripHeaderTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabView)instance).TabStripHeaderTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_66_TabView_TabStripHeaderTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TabView)instance).TabStripHeaderTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_67_TabViewItem_Header(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabViewItem)instance).Header;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_67_TabViewItem_Header(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabViewItem)instance).Header = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_68_TabViewItem_IsClosable(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabViewItem)instance).IsClosable;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_68_TabViewItem_IsClosable(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TabViewItem)instance).IsClosable = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_69_TabViewItem_IconSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabViewItem)instance).IconSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_69_TabViewItem_IconSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TabViewItem)instance).IconSource = (IconSource)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_70_TabViewItem_HeaderTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabViewItem)instance).HeaderTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_70_TabViewItem_HeaderTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TabViewItem)instance).HeaderTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_71_TabViewItem_TabViewTemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TabViewItem)instance).TabViewTemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_72_Expander_Header(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((Expander)instance).Header;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_72_Expander_Header(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Expander)instance).Header = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_73_Expander_ExpandDirection(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((Expander)instance).ExpandDirection;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_73_Expander_ExpandDirection(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((Expander)instance).ExpandDirection = (ExpandDirection)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_74_Expander_HeaderTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((Expander)instance).HeaderTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_74_Expander_HeaderTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((Expander)instance).HeaderTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_75_Expander_HeaderTemplateSelector(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((Expander)instance).HeaderTemplateSelector;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_75_Expander_HeaderTemplateSelector(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((Expander)instance).HeaderTemplateSelector = (DataTemplateSelector)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_76_Expander_IsExpanded(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((Expander)instance).IsExpanded;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_76_Expander_IsExpanded(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Expander)instance).IsExpanded = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_77_Expander_TemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((Expander)instance).TemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_78_ShellView_ShellXamlRoot(object instance)
	{
		return ((ShellView)instance).ShellXamlRoot;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_79_BedrockAccountProfileDetailDialog_ViewModel(object instance)
	{
		return ((BedrockAccountProfileDetailDialog)instance).ViewModel;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_80_WebView2_DefaultBackgroundColor(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((WebView2)instance).DefaultBackgroundColor;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_80_WebView2_DefaultBackgroundColor(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((WebView2)instance).DefaultBackgroundColor = (Color)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_81_WebView2_CanGoBack(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebView2)instance).CanGoBack;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_81_WebView2_CanGoBack(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WebView2)instance).CanGoBack = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_82_WebView2_CanGoForward(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebView2)instance).CanGoForward;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_82_WebView2_CanGoForward(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WebView2)instance).CanGoForward = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_83_WebView2_CoreWebView2(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebView2)instance).CoreWebView2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_84_WebView2_Source(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebView2)instance).Source;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_84_WebView2_Source(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((WebView2)instance).Source = (Uri)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_85_BedrockNetworkImage_ImageStretch(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockNetworkImage)instance).ImageStretch;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_85_BedrockNetworkImage_ImageStretch(object instance, object Value)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((BedrockNetworkImage)instance).ImageStretch = (Stretch)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_86_BedrockNetworkImage_ImageUrl(object instance)
	{
		return ((BedrockNetworkImage)instance).ImageUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_86_BedrockNetworkImage_ImageUrl(object instance, object Value)
	{
		((BedrockNetworkImage)instance).ImageUrl = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_87_BedrockInstanceList_Instances(object instance)
	{
		return ((BedrockInstanceList)instance).Instances;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_88_BedrockInstanceCardViewModel_Instance(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).Instance;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_89_BedrockInstanceCardViewModel_Relay(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).Relay;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_90_BedrockInstanceCardViewModel_ProcessId(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).ProcessId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_91_BedrockInstanceCardViewModel_Title(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).Title;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_92_BedrockInstanceCardViewModel_KindText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).KindText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_93_BedrockInstanceCardViewModel_CoverUrl(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).CoverUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_94_BedrockInstanceCardViewModel_StatusText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).StatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_95_BedrockInstanceCardViewModel_StartedText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).StartedText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_96_BedrockInstanceCardViewModel_StartedTimeText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).StartedTimeText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_97_BedrockInstanceCardViewModel_AccountText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).AccountText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_98_BedrockInstanceCardViewModel_DetailText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).DetailText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_99_BedrockInstanceCardViewModel_ProcessText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).ProcessText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_100_BedrockInstanceCardViewModel_ProcessIdText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).ProcessIdText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_101_BedrockInstanceCardViewModel_ClientVersionText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).ClientVersionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_102_BedrockInstanceCardViewModel_ProcessLabelText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).ProcessLabelText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_103_BedrockInstanceCardViewModel_ClientLabelText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).ClientLabelText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_104_BedrockInstanceCardViewModel_OpenActionText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).OpenActionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_105_BedrockInstanceCardViewModel_CloseActionText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).CloseActionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_106_BedrockInstanceCardViewModel_OpenPath(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).OpenPath;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_107_BedrockInstanceCardViewModel_CanOpenFolder(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).CanOpenFolder;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_108_BedrockInstanceCardViewModel_CanClose(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).CanClose;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_109_BedrockInstanceCardViewModel_OverlayVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockInstanceCardViewModel)instance).OverlayVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_110_BedrockInstanceCardViewModel_CanLoadOverlay(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).CanLoadOverlay;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_111_BedrockInstanceCardViewModel_OverlayProgressVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockInstanceCardViewModel)instance).OverlayProgressVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_112_BedrockInstanceCardViewModel_OverlayActionText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).OverlayActionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_113_BedrockInstanceCardViewModel_OverlayStatusText(object instance)
	{
		return ((BedrockInstanceCardViewModel)instance).OverlayStatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_114_BedrockLocalLobbyBrowser_Rooms(object instance)
	{
		return ((BedrockLocalLobbyBrowser)instance).Rooms;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_115_BedrockLocalLobbyRoomCardViewModel_Room(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).Room;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_116_BedrockLocalLobbyRoomCardViewModel_Name(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_117_BedrockLocalLobbyRoomCardViewModel_Description(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_118_BedrockLocalLobbyRoomCardViewModel_CoverUrl(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).CoverUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_119_BedrockLocalLobbyRoomCardViewModel_PlayerText(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).PlayerText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_120_BedrockLocalLobbyRoomCardViewModel_CategoryText(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).CategoryText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_121_BedrockLocalLobbyRoomCardViewModel_VersionText(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).VersionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_122_BedrockLocalLobbyRoomCardViewModel_StatusText(object instance)
	{
		return ((BedrockLocalLobbyRoomCardViewModel)instance).StatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_123_BedrockMaterialPackBrowser_Packs(object instance)
	{
		return ((BedrockMaterialPackBrowser)instance).Packs;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_124_BedrockMaterialPackViewModel_Pack(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).Pack;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_125_BedrockMaterialPackViewModel_Id(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_126_BedrockMaterialPackViewModel_Name(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_127_BedrockMaterialPackViewModel_Description(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_128_BedrockMaterialPackViewModel_MetadataText(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).MetadataText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_129_BedrockMaterialPackViewModel_ExclusionText(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).ExclusionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_130_BedrockMaterialPackViewModel_IconSource(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).IconSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_131_BedrockMaterialPackViewModel_IconVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockMaterialPackViewModel)instance).IconVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_132_BedrockMaterialPackViewModel_PlaceholderVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockMaterialPackViewModel)instance).PlaceholderVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_133_BedrockMaterialPackViewModel_IsEnabled(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).IsEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_134_BedrockMaterialPackViewModel_EnabledStateText(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).EnabledStateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_135_BedrockMaterialPackViewModel_AllowFontOverride(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).AllowFontOverride;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_136_BedrockMaterialPackViewModel_EnableActionText(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).EnableActionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_137_BedrockMaterialPackViewModel_FontProtectionText(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).FontProtectionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_138_BedrockMaterialPackViewModel_FontProtectionStateText(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).FontProtectionStateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_139_BedrockMaterialPackViewModel_FontProtectionToolTip(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).FontProtectionToolTip;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_140_BedrockMaterialPackViewModel_EnableToolTip(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).EnableToolTip;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_141_BedrockMaterialPackViewModel_CanDelete(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).CanDelete;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_142_BedrockMaterialPackViewModel_DeleteVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockMaterialPackViewModel)instance).DeleteVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_143_BedrockMaterialPackViewModel_CanMoveUp(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).CanMoveUp;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_144_BedrockMaterialPackViewModel_CanMoveDown(object instance)
	{
		return ((BedrockMaterialPackViewModel)instance).CanMoveDown;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_145_SettingsExpander_Content(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).Content;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_145_SettingsExpander_Content(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsExpander)instance).Content = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_146_SettingsExpander_Header(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).Header;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_146_SettingsExpander_Header(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsExpander)instance).Header = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_147_SettingsExpander_Description(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_147_SettingsExpander_Description(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsExpander)instance).Description = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_148_SettingsExpander_IsExpanded(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).IsExpanded;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_148_SettingsExpander_IsExpanded(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsExpander)instance).IsExpanded = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_149_SettingsExpander_HeaderIcon(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).HeaderIcon;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_149_SettingsExpander_HeaderIcon(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SettingsExpander)instance).HeaderIcon = (IconElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_150_SettingsExpander_Items(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).Items;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_150_SettingsExpander_Items(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsExpander)instance).Items = (global::System.Collections.Generic.IList<object>)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_151_SettingsExpander_ItemsSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).ItemsSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_151_SettingsExpander_ItemsSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsExpander)instance).ItemsSource = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_152_SettingsExpander_ItemTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).ItemTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_152_SettingsExpander_ItemTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsExpander)instance).ItemTemplate = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_153_SettingsExpander_ItemContainerStyleSelector(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).ItemContainerStyleSelector;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_153_SettingsExpander_ItemContainerStyleSelector(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SettingsExpander)instance).ItemContainerStyleSelector = (StyleSelector)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_154_SettingsExpander_ItemsHeader(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).ItemsHeader;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_154_SettingsExpander_ItemsHeader(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SettingsExpander)instance).ItemsHeader = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_155_SettingsExpander_ItemsFooter(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsExpander)instance).ItemsFooter;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_155_SettingsExpander_ItemsFooter(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SettingsExpander)instance).ItemsFooter = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_156_SettingsCard_Header(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).Header;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_156_SettingsCard_Header(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsCard)instance).Header = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_157_SettingsCard_Description(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_157_SettingsCard_Description(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsCard)instance).Description = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_158_SettingsCard_HeaderIcon(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).HeaderIcon;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_158_SettingsCard_HeaderIcon(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SettingsCard)instance).HeaderIcon = (IconElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_159_SettingsCard_ActionIcon(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).ActionIcon;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_159_SettingsCard_ActionIcon(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SettingsCard)instance).ActionIcon = (IconElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_160_SettingsCard_ActionIconToolTip(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).ActionIconToolTip;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_160_SettingsCard_ActionIconToolTip(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsCard)instance).ActionIconToolTip = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_161_SettingsCard_IsClickEnabled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).IsClickEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_161_SettingsCard_IsClickEnabled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsCard)instance).IsClickEnabled = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_162_SettingsCard_ContentAlignment(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).ContentAlignment;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_162_SettingsCard_ContentAlignment(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((SettingsCard)instance).ContentAlignment = (ContentAlignment)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_163_SettingsCard_IsActionIconVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SettingsCard)instance).IsActionIconVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_163_SettingsCard_IsActionIconVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SettingsCard)instance).IsActionIconVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_164_BedrockRentalRoomBrowser_Rooms(object instance)
	{
		return ((BedrockRentalRoomBrowser)instance).Rooms;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_165_BedrockRentalRoomCardViewModel_Room(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).Room;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_166_BedrockRentalRoomCardViewModel_Name(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_167_BedrockRentalRoomCardViewModel_RoomNumberText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).RoomNumberText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_168_BedrockRentalRoomCardViewModel_SummaryText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).SummaryText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_169_BedrockRentalRoomCardViewModel_PlayerText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).PlayerText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_170_BedrockRentalRoomCardViewModel_PopularityText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).PopularityText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_171_BedrockRentalRoomCardViewModel_LevelText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).LevelText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_172_BedrockRentalRoomCardViewModel_PasswordText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).PasswordText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_173_BedrockRentalRoomCardViewModel_PasswordShortText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).PasswordShortText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_174_BedrockRentalRoomCardViewModel_LevelShortText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).LevelShortText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_175_BedrockRentalRoomCardViewModel_StatusText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).StatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_176_BedrockRentalRoomCardViewModel_VersionText(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).VersionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_177_BedrockRentalRoomCardViewModel_CoverUrl(object instance)
	{
		return ((BedrockRentalRoomCardViewModel)instance).CoverUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_178_BedrockRentalRoomBrowser_RelayBindScope(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockRentalRoomBrowser)instance).RelayBindScope;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_179_BedrockRentalRoomBrowser_RelayFrontendProtocol(object instance)
	{
		return ((BedrockRentalRoomBrowser)instance).RelayFrontendProtocol;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_180_BedrockServerBrowser_Servers(object instance)
	{
		return ((BedrockServerBrowser)instance).Servers;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_181_BedrockServerCardViewModel_Server(object instance)
	{
		return ((BedrockServerCardViewModel)instance).Server;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_182_BedrockServerCardViewModel_Name(object instance)
	{
		return ((BedrockServerCardViewModel)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_183_BedrockServerCardViewModel_Summary(object instance)
	{
		return ((BedrockServerCardViewModel)instance).Summary;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_184_BedrockServerCardViewModel_OnlineText(object instance)
	{
		return ((BedrockServerCardViewModel)instance).OnlineText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_185_BedrockServerCardViewModel_CoverUrl(object instance)
	{
		return ((BedrockServerCardViewModel)instance).CoverUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_186_BedrockServerCardViewModel_PlatformText(object instance)
	{
		return ((BedrockServerCardViewModel)instance).PlatformText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_187_BedrockServerBrowser_RelayBindScope(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockServerBrowser)instance).RelayBindScope;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_188_BedrockServerBrowser_RelayFrontendProtocol(object instance)
	{
		return ((BedrockServerBrowser)instance).RelayFrontendProtocol;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_189_BedrockSkinViewer_AutoRotateEnabled(object instance)
	{
		return ((BedrockSkinViewer)instance).AutoRotateEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_190_SelectorBar_Items(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SelectorBar)instance).Items;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_191_ItemContainer_Child(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemContainer)instance).Child;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_191_ItemContainer_Child(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((ItemContainer)instance).Child = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_192_ItemContainer_IsSelected(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemContainer)instance).IsSelected;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_192_ItemContainer_IsSelected(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ItemContainer)instance).IsSelected = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_193_SelectorBarItem_Text(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SelectorBarItem)instance).Text;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_193_SelectorBarItem_Text(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((SelectorBarItem)instance).Text = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_194_SelectorBarItem_Icon(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SelectorBarItem)instance).Icon;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_194_SelectorBarItem_Icon(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SelectorBarItem)instance).Icon = (IconElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_195_SelectorBar_SelectedItem(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SelectorBar)instance).SelectedItem;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_195_SelectorBar_SelectedItem(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((SelectorBar)instance).SelectedItem = (SelectorBarItem)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_196_BedrockSkinBrowser_Skins(object instance)
	{
		return ((BedrockSkinBrowser)instance).Skins;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_197_BedrockSkinCardViewModel_Kind(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockSkinCardViewModel)instance).Kind;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_198_BedrockSkinCardViewModel_TwoDimensionalSkin(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).TwoDimensionalSkin;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_199_BedrockSkinCardViewModel_FourDimensionalSkin(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).FourDimensionalSkin;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_200_BedrockSkinCardViewModel_FourDimensionalPart(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).FourDimensionalPart;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_201_BedrockSkinCardViewModel_Id(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_202_BedrockSkinCardViewModel_Name(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_203_BedrockSkinCardViewModel_Developer(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).Developer;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_204_BedrockSkinCardViewModel_Summary(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).Summary;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_205_BedrockSkinCardViewModel_CoverUrl(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).CoverUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_206_BedrockSkinCardViewModel_MetricsText(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).MetricsText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_207_BedrockSkinCardViewModel_ResourceStatusText(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).ResourceStatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_207_BedrockSkinCardViewModel_ResourceStatusText(object instance, object Value)
	{
		((BedrockSkinCardViewModel)instance).ResourceStatusText = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_208_BedrockSkinCardViewModel_IsApplied(object instance)
	{
		return ((BedrockSkinCardViewModel)instance).IsApplied;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_208_BedrockSkinCardViewModel_IsApplied(object instance, object Value)
	{
		((BedrockSkinCardViewModel)instance).IsApplied = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_209_BedrockSkinCardViewModel_AppliedVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((BedrockSkinCardViewModel)instance).AppliedVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_210_ItemsRepeater_ItemTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).ItemTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_210_ItemsRepeater_ItemTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ItemsRepeater)instance).ItemTemplate = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_211_ItemsRepeater_Layout(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).Layout;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_211_ItemsRepeater_Layout(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((ItemsRepeater)instance).Layout = (Layout)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_212_ItemsRepeater_Background(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).Background;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_212_ItemsRepeater_Background(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((ItemsRepeater)instance).Background = (Brush)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_213_ItemsRepeater_HorizontalCacheLength(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).HorizontalCacheLength;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_213_ItemsRepeater_HorizontalCacheLength(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ItemsRepeater)instance).HorizontalCacheLength = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_214_ItemsRepeater_ItemTransitionProvider(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).ItemTransitionProvider;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_214_ItemsRepeater_ItemTransitionProvider(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((ItemsRepeater)instance).ItemTransitionProvider = (ItemCollectionTransitionProvider)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_215_ItemsRepeater_ItemsSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).ItemsSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_215_ItemsRepeater_ItemsSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ItemsRepeater)instance).ItemsSource = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_216_ItemsRepeater_ItemsSourceView(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).ItemsSourceView;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_217_ItemsRepeater_VerticalCacheLength(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemsRepeater)instance).VerticalCacheLength;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_217_ItemsRepeater_VerticalCacheLength(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ItemsRepeater)instance).VerticalCacheLength = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_218_UniformGridLayout_MinItemWidth(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).MinItemWidth;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_218_UniformGridLayout_MinItemWidth(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).MinItemWidth = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_219_UniformGridLayout_MinItemHeight(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).MinItemHeight;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_219_UniformGridLayout_MinItemHeight(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).MinItemHeight = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_220_UniformGridLayout_MinRowSpacing(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).MinRowSpacing;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_220_UniformGridLayout_MinRowSpacing(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).MinRowSpacing = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_221_UniformGridLayout_MinColumnSpacing(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).MinColumnSpacing;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_221_UniformGridLayout_MinColumnSpacing(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).MinColumnSpacing = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_222_UniformGridLayout_ItemsJustification(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).ItemsJustification;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_222_UniformGridLayout_ItemsJustification(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).ItemsJustification = (UniformGridLayoutItemsJustification)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_223_UniformGridLayout_ItemsStretch(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).ItemsStretch;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_223_UniformGridLayout_ItemsStretch(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).ItemsStretch = (UniformGridLayoutItemsStretch)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_224_UniformGridLayout_MaximumRowsOrColumns(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).MaximumRowsOrColumns;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_224_UniformGridLayout_MaximumRowsOrColumns(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).MaximumRowsOrColumns = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_225_UniformGridLayout_Orientation(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((UniformGridLayout)instance).Orientation;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_225_UniformGridLayout_Orientation(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((UniformGridLayout)instance).Orientation = (Orientation)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_226_Layout_IndexBasedLayoutOrientation(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((Layout)instance).IndexBasedLayoutOrientation;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_227_RadialGradientBrush_GradientStops(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).GradientStops;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_228_RadialGradientBrush_Center(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).Center;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_228_RadialGradientBrush_Center(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((RadialGradientBrush)instance).Center = (Point)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_229_RadialGradientBrush_GradientOrigin(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).GradientOrigin;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_229_RadialGradientBrush_GradientOrigin(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((RadialGradientBrush)instance).GradientOrigin = (Point)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_230_RadialGradientBrush_InterpolationSpace(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).InterpolationSpace;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_230_RadialGradientBrush_InterpolationSpace(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((RadialGradientBrush)instance).InterpolationSpace = (CompositionColorSpace)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_231_RadialGradientBrush_MappingMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).MappingMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_231_RadialGradientBrush_MappingMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((RadialGradientBrush)instance).MappingMode = (BrushMappingMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_232_RadialGradientBrush_RadiusX(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).RadiusX;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_232_RadialGradientBrush_RadiusX(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((RadialGradientBrush)instance).RadiusX = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_233_RadialGradientBrush_RadiusY(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).RadiusY;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_233_RadialGradientBrush_RadiusY(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((RadialGradientBrush)instance).RadiusY = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_234_RadialGradientBrush_SpreadMethod(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((RadialGradientBrush)instance).SpreadMethod;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_234_RadialGradientBrush_SpreadMethod(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((RadialGradientBrush)instance).SpreadMethod = (GradientSpreadMethod)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_235_PersonPicture_BadgeGlyph(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).BadgeGlyph;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_235_PersonPicture_BadgeGlyph(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PersonPicture)instance).BadgeGlyph = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_236_PersonPicture_BadgeImageSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).BadgeImageSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_236_PersonPicture_BadgeImageSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((PersonPicture)instance).BadgeImageSource = (ImageSource)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_237_PersonPicture_BadgeNumber(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).BadgeNumber;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_237_PersonPicture_BadgeNumber(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PersonPicture)instance).BadgeNumber = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_238_PersonPicture_BadgeText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).BadgeText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_238_PersonPicture_BadgeText(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PersonPicture)instance).BadgeText = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_239_PersonPicture_Contact(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).Contact;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_239_PersonPicture_Contact(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((PersonPicture)instance).Contact = (Contact)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_240_PersonPicture_DisplayName(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).DisplayName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_240_PersonPicture_DisplayName(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PersonPicture)instance).DisplayName = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_241_PersonPicture_Initials(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).Initials;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_241_PersonPicture_Initials(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PersonPicture)instance).Initials = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_242_PersonPicture_IsGroup(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).IsGroup;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_242_PersonPicture_IsGroup(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PersonPicture)instance).IsGroup = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_243_PersonPicture_PreferSmallImage(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).PreferSmallImage;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_243_PersonPicture_PreferSmallImage(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PersonPicture)instance).PreferSmallImage = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_244_PersonPicture_ProfilePicture(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).ProfilePicture;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_244_PersonPicture_ProfilePicture(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((PersonPicture)instance).ProfilePicture = (ImageSource)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_245_PersonPicture_TemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((PersonPicture)instance).TemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_246_PagerBar_PageSizeVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((PagerBar)instance).PageSizeVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_246_PagerBar_PageSizeVisibility(object instance, object Value)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((PagerBar)instance).PageSizeVisibility = (Visibility)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_247_PagerBar_PageSize(object instance)
	{
		return ((PagerBar)instance).PageSize;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_248_Thickness_Left(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		return val.Left;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_248_Thickness_Left(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		val.Left = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_249_Thickness_Top(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		return val.Top;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_249_Thickness_Top(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		val.Top = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_250_Thickness_Right(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		return val.Right;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_250_Thickness_Right(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		val.Right = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_251_Thickness_Bottom(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		return val.Bottom;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_251_Thickness_Bottom(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Thickness val = (Thickness)instance;
		val.Bottom = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_252_TitleBar_Content(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).Content;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_252_TitleBar_Content(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TitleBar)instance).Content = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_253_TitleBar_Title(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).Title;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_253_TitleBar_Title(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TitleBar)instance).Title = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_254_TitleBar_IsBackButtonVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).IsBackButtonVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_254_TitleBar_IsBackButtonVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TitleBar)instance).IsBackButtonVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_255_TitleBar_IsPaneToggleButtonVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).IsPaneToggleButtonVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_255_TitleBar_IsPaneToggleButtonVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TitleBar)instance).IsPaneToggleButtonVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_256_TitleBar_IconSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).IconSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_256_TitleBar_IconSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TitleBar)instance).IconSource = (IconSource)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_257_TitleBar_RightHeader(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).RightHeader;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_257_TitleBar_RightHeader(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TitleBar)instance).RightHeader = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_258_TitleBar_AutoRefreshDragRegions(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).AutoRefreshDragRegions;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_258_TitleBar_AutoRefreshDragRegions(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TitleBar)instance).AutoRefreshDragRegions = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_259_TitleBar_IsBackButtonEnabled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).IsBackButtonEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_259_TitleBar_IsBackButtonEnabled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TitleBar)instance).IsBackButtonEnabled = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_260_TitleBar_LeftHeader(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).LeftHeader;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_260_TitleBar_LeftHeader(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TitleBar)instance).LeftHeader = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_261_TitleBar_Subtitle(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).Subtitle;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_261_TitleBar_Subtitle(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TitleBar)instance).Subtitle = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_262_TitleBar_TemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TitleBar)instance).TemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_263_TitleBar_IsDragRegion(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		return TitleBar.GetIsDragRegion((UIElement)instance);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_263_TitleBar_IsDragRegion(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		TitleBar.SetIsDragRegion((UIElement)instance, (bool?)Value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_264_NavigationView_CompactPaneLength(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).CompactPaneLength;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_264_NavigationView_CompactPaneLength(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).CompactPaneLength = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_265_NavigationView_IsBackButtonVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).IsBackButtonVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_265_NavigationView_IsBackButtonVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).IsBackButtonVisible = (NavigationViewBackButtonVisible)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_266_NavigationView_IsPaneOpen(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).IsPaneOpen;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_266_NavigationView_IsPaneOpen(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).IsPaneOpen = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_267_NavigationView_IsPaneToggleButtonVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).IsPaneToggleButtonVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_267_NavigationView_IsPaneToggleButtonVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).IsPaneToggleButtonVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_268_NavigationView_IsSettingsVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).IsSettingsVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_268_NavigationView_IsSettingsVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).IsSettingsVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_269_NavigationView_OpenPaneLength(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).OpenPaneLength;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_269_NavigationView_OpenPaneLength(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).OpenPaneLength = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_270_NavigationView_PaneDisplayMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).PaneDisplayMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_270_NavigationView_PaneDisplayMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).PaneDisplayMode = (NavigationViewPaneDisplayMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_271_NavigationView_MenuItems(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).MenuItems;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_272_NavigationView_PaneFooter(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).PaneFooter;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_272_NavigationView_PaneFooter(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).PaneFooter = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_273_NavigationView_AlwaysShowHeader(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).AlwaysShowHeader;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_273_NavigationView_AlwaysShowHeader(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).AlwaysShowHeader = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_274_NavigationView_AutoSuggestBox(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).AutoSuggestBox;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_274_NavigationView_AutoSuggestBox(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).AutoSuggestBox = (AutoSuggestBox)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_275_NavigationView_CompactModeThresholdWidth(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).CompactModeThresholdWidth;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_275_NavigationView_CompactModeThresholdWidth(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).CompactModeThresholdWidth = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_276_NavigationView_ContentOverlay(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).ContentOverlay;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_276_NavigationView_ContentOverlay(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).ContentOverlay = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_277_NavigationView_DisplayMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).DisplayMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_278_NavigationView_ExpandedModeThresholdWidth(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).ExpandedModeThresholdWidth;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_278_NavigationView_ExpandedModeThresholdWidth(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).ExpandedModeThresholdWidth = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_279_NavigationView_FooterMenuItems(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).FooterMenuItems;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_280_NavigationView_FooterMenuItemsSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).FooterMenuItemsSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_280_NavigationView_FooterMenuItemsSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).FooterMenuItemsSource = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_281_NavigationView_Header(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).Header;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_281_NavigationView_Header(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).Header = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_282_NavigationView_HeaderTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).HeaderTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_282_NavigationView_HeaderTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).HeaderTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_283_NavigationView_IsBackEnabled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).IsBackEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_283_NavigationView_IsBackEnabled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).IsBackEnabled = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_284_NavigationView_IsPaneVisible(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).IsPaneVisible;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_284_NavigationView_IsPaneVisible(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).IsPaneVisible = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_285_NavigationView_IsTitleBarAutoPaddingEnabled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).IsTitleBarAutoPaddingEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_285_NavigationView_IsTitleBarAutoPaddingEnabled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).IsTitleBarAutoPaddingEnabled = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_286_NavigationView_MenuItemContainerStyle(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).MenuItemContainerStyle;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_286_NavigationView_MenuItemContainerStyle(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).MenuItemContainerStyle = (Style)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_287_NavigationView_MenuItemContainerStyleSelector(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).MenuItemContainerStyleSelector;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_287_NavigationView_MenuItemContainerStyleSelector(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).MenuItemContainerStyleSelector = (StyleSelector)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_288_NavigationView_MenuItemTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).MenuItemTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_288_NavigationView_MenuItemTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).MenuItemTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_289_NavigationView_MenuItemTemplateSelector(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).MenuItemTemplateSelector;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_289_NavigationView_MenuItemTemplateSelector(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).MenuItemTemplateSelector = (DataTemplateSelector)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_290_NavigationView_MenuItemsSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).MenuItemsSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_290_NavigationView_MenuItemsSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).MenuItemsSource = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_291_NavigationView_OverflowLabelMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).OverflowLabelMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_291_NavigationView_OverflowLabelMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).OverflowLabelMode = (NavigationViewOverflowLabelMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_292_NavigationView_PaneCustomContent(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).PaneCustomContent;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_292_NavigationView_PaneCustomContent(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).PaneCustomContent = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_293_NavigationView_PaneHeader(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).PaneHeader;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_293_NavigationView_PaneHeader(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).PaneHeader = (UIElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_294_NavigationView_PaneTitle(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).PaneTitle;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_294_NavigationView_PaneTitle(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).PaneTitle = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_295_NavigationView_PaneToggleButtonStyle(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).PaneToggleButtonStyle;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_295_NavigationView_PaneToggleButtonStyle(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationView)instance).PaneToggleButtonStyle = (Style)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_296_NavigationView_SelectedItem(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).SelectedItem;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_296_NavigationView_SelectedItem(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).SelectedItem = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_297_NavigationView_SelectionFollowsFocus(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).SelectionFollowsFocus;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_297_NavigationView_SelectionFollowsFocus(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).SelectionFollowsFocus = (NavigationViewSelectionFollowsFocus)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_298_NavigationView_SettingsItem(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).SettingsItem;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_299_NavigationView_ShoulderNavigationEnabled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).ShoulderNavigationEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_299_NavigationView_ShoulderNavigationEnabled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NavigationView)instance).ShoulderNavigationEnabled = (NavigationViewShoulderNavigationEnabled)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_300_NavigationView_TemplateSettings(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationView)instance).TemplateSettings;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_301_NavigationViewItem_Icon(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).Icon;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_301_NavigationViewItem_Icon(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationViewItem)instance).Icon = (IconElement)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_302_NavigationViewItem_SelectsOnInvoked(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).SelectsOnInvoked;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_302_NavigationViewItem_SelectsOnInvoked(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationViewItem)instance).SelectsOnInvoked = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_303_NavigationViewItem_MenuItems(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).MenuItems;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_304_NavigationViewItem_CompactPaneLength(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).CompactPaneLength;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_305_NavigationViewItem_HasUnrealizedChildren(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).HasUnrealizedChildren;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_305_NavigationViewItem_HasUnrealizedChildren(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationViewItem)instance).HasUnrealizedChildren = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_306_NavigationViewItem_InfoBadge(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).InfoBadge;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_306_NavigationViewItem_InfoBadge(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NavigationViewItem)instance).InfoBadge = (InfoBadge)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_307_NavigationViewItem_IsChildSelected(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).IsChildSelected;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_307_NavigationViewItem_IsChildSelected(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationViewItem)instance).IsChildSelected = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_308_NavigationViewItem_IsExpanded(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).IsExpanded;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_308_NavigationViewItem_IsExpanded(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationViewItem)instance).IsExpanded = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_309_NavigationViewItem_MenuItemsSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItem)instance).MenuItemsSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_309_NavigationViewItem_MenuItemsSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationViewItem)instance).MenuItemsSource = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_310_NavigationViewItemBase_IsSelected(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NavigationViewItemBase)instance).IsSelected;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_310_NavigationViewItemBase_IsSelected(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NavigationViewItemBase)instance).IsSelected = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_311_ImageIconSource_ImageSource(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ImageIconSource)instance).ImageSource;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_311_ImageIconSource_ImageSource(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((ImageIconSource)instance).ImageSource = (ImageSource)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_312_CornerRadius_TopLeft(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		return val.TopLeft;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_312_CornerRadius_TopLeft(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		val.TopLeft = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_313_CornerRadius_TopRight(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		return val.TopRight;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_313_CornerRadius_TopRight(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		val.TopRight = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_314_CornerRadius_BottomRight(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		return val.BottomRight;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_314_CornerRadius_BottomRight(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		val.BottomRight = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_315_CornerRadius_BottomLeft(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		return val.BottomLeft;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_315_CornerRadius_BottomLeft(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		CornerRadius val = (CornerRadius)instance;
		val.BottomLeft = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_316_AttachedShadowBase_BlurRadius(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((AttachedShadowBase)instance).BlurRadius;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_316_AttachedShadowBase_BlurRadius(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((AttachedShadowBase)instance).BlurRadius = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_317_AttachedCardShadow_CornerRadius(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((AttachedCardShadow)instance).CornerRadius;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_317_AttachedCardShadow_CornerRadius(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((AttachedCardShadow)instance).CornerRadius = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_318_AttachedShadowBase_Opacity(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((AttachedShadowBase)instance).Opacity;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_318_AttachedShadowBase_Opacity(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((AttachedShadowBase)instance).Opacity = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_319_AttachedShadowBase_Offset(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((AttachedShadowBase)instance).Offset;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_319_AttachedShadowBase_Offset(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((AttachedShadowBase)instance).Offset = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_320_AttachedCardShadow_InnerContentClipMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((AttachedCardShadow)instance).InnerContentClipMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_320_AttachedCardShadow_InnerContentClipMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((AttachedCardShadow)instance).InnerContentClipMode = (InnerContentClipMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_321_AttachedShadowBase_Color(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((AttachedShadowBase)instance).Color;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_321_AttachedShadowBase_Color(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((AttachedShadowBase)instance).Color = (Color)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_322_Color_A(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		return val.A;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_322_Color_A(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		val.A = (byte)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_323_Color_R(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		return val.R;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_323_Color_R(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		val.R = (byte)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_324_Color_G(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		return val.G;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_324_Color_G(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		val.G = (byte)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_325_Color_B(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		return val.B;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_325_Color_B(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Color val = (Color)instance;
		val.B = (byte)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_326_NumberBox_Header(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).Header;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_326_NumberBox_Header(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).Header = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_327_NumberBox_Maximum(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).Maximum;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_327_NumberBox_Maximum(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).Maximum = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_328_NumberBox_Minimum(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).Minimum;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_328_NumberBox_Minimum(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).Minimum = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_329_NumberBox_SmallChange(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).SmallChange;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_329_NumberBox_SmallChange(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).SmallChange = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_330_NumberBox_AcceptsExpression(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).AcceptsExpression;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_330_NumberBox_AcceptsExpression(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).AcceptsExpression = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_331_NumberBox_Description(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_331_NumberBox_Description(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).Description = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_332_NumberBox_HeaderTemplate(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).HeaderTemplate;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_332_NumberBox_HeaderTemplate(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NumberBox)instance).HeaderTemplate = (DataTemplate)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_333_NumberBox_IsWrapEnabled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).IsWrapEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_333_NumberBox_IsWrapEnabled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).IsWrapEnabled = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_334_NumberBox_LargeChange(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).LargeChange;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_334_NumberBox_LargeChange(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).LargeChange = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_335_NumberBox_NumberFormatter(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).NumberFormatter;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_335_NumberBox_NumberFormatter(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NumberBox)instance).NumberFormatter = (INumberFormatter2)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_336_NumberBox_PlaceholderText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).PlaceholderText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_336_NumberBox_PlaceholderText(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).PlaceholderText = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_337_NumberBox_PreventKeyboardDisplayOnProgrammaticFocus(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).PreventKeyboardDisplayOnProgrammaticFocus;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_337_NumberBox_PreventKeyboardDisplayOnProgrammaticFocus(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).PreventKeyboardDisplayOnProgrammaticFocus = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_338_NumberBox_SelectionFlyout(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).SelectionFlyout;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_338_NumberBox_SelectionFlyout(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NumberBox)instance).SelectionFlyout = (FlyoutBase)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_339_NumberBox_SelectionHighlightColor(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).SelectionHighlightColor;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_339_NumberBox_SelectionHighlightColor(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((NumberBox)instance).SelectionHighlightColor = (SolidColorBrush)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_340_NumberBox_SpinButtonPlacementMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).SpinButtonPlacementMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_340_NumberBox_SpinButtonPlacementMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).SpinButtonPlacementMode = (NumberBoxSpinButtonPlacementMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_341_NumberBox_Text(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).Text;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_341_NumberBox_Text(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).Text = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_342_NumberBox_TextReadingOrder(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).TextReadingOrder;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_342_NumberBox_TextReadingOrder(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).TextReadingOrder = (TextReadingOrder)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_343_NumberBox_ValidationMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).ValidationMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_343_NumberBox_ValidationMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).ValidationMode = (NumberBoxValidationMode)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_344_NumberBox_Value(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NumberBox)instance).Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_344_NumberBox_Value(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NumberBox)instance).Value = (double)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_345_BedrockOnlineLobbyPage_Rooms(object instance)
	{
		return ((BedrockOnlineLobbyPage)instance).Rooms;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_346_BedrockOnlineLobbyRoom_RoomId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).RoomId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_346_BedrockOnlineLobbyRoom_RoomId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).RoomId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_347_BedrockOnlineLobbyRoom_Name(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_347_BedrockOnlineLobbyRoom_Name(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).Name = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_348_BedrockOnlineLobbyRoom_Description(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_348_BedrockOnlineLobbyRoom_Description(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).Description = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_349_BedrockOnlineLobbyRoom_ResourceId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).ResourceId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_349_BedrockOnlineLobbyRoom_ResourceId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).ResourceId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_350_BedrockOnlineLobbyRoom_OwnerId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).OwnerId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_350_BedrockOnlineLobbyRoom_OwnerId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).OwnerId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_351_BedrockOnlineLobbyRoom_Version(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).Version;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_351_BedrockOnlineLobbyRoom_Version(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).Version = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_352_BedrockOnlineLobbyRoom_PlayerCount(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).PlayerCount;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_352_BedrockOnlineLobbyRoom_PlayerCount(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).PlayerCount = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_353_BedrockOnlineLobbyRoom_Capacity(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).Capacity;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_353_BedrockOnlineLobbyRoom_Capacity(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).Capacity = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_354_BedrockOnlineLobbyRoom_HasPassword(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).HasPassword;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_354_BedrockOnlineLobbyRoom_HasPassword(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((en9Zr5faBGr6cyEG7MZ5)instance).HasPassword = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_355_BedrockOnlineLobbyRoom_PlayerText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).PlayerText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_356_BedrockOnlineLobbyRoom_VersionText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((en9Zr5faBGr6cyEG7MZ5)instance).VersionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_357_HomePage_HomeTimelineList(object instance)
	{
		return ((HomePage)instance).HomeTimelineList;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_358_TimelineEntry_VersionText(object instance)
	{
		return ((TimelineEntry)instance).VersionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_358_TimelineEntry_VersionText(object instance, object Value)
	{
		((TimelineEntry)instance).VersionText = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_359_TimelineEntry_DateText(object instance)
	{
		return ((TimelineEntry)instance).DateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_359_TimelineEntry_DateText(object instance, object Value)
	{
		((TimelineEntry)instance).DateText = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_360_TimelineEntry_IsLatest(object instance)
	{
		return ((TimelineEntry)instance).IsLatest;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_360_TimelineEntry_IsLatest(object instance, object Value)
	{
		((TimelineEntry)instance).IsLatest = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_361_TimelineEntry_LatestBadgeVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((TimelineEntry)instance).LatestBadgeVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_362_TimelineEntry_Notes(object instance)
	{
		return ((TimelineEntry)instance).Notes;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_362_TimelineEntry_Notes(object instance, object Value)
	{
		((TimelineEntry)instance).Notes = (List<TimelineNote>)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_363_TimelineNote_TagText(object instance)
	{
		return ((TimelineNote)instance).TagText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_363_TimelineNote_TagText(object instance, object Value)
	{
		((TimelineNote)instance).TagText = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_364_TimelineNote_TagColor(object instance)
	{
		return ((TimelineNote)instance).TagColor;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_364_TimelineNote_TagColor(object instance, object Value)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TimelineNote)instance).TagColor = (Brush)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_365_TimelineNote_TagBackground(object instance)
	{
		return ((TimelineNote)instance).TagBackground;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_365_TimelineNote_TagBackground(object instance, object Value)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((TimelineNote)instance).TagBackground = (Brush)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_366_TimelineNote_IconGlyph(object instance)
	{
		return ((TimelineNote)instance).IconGlyph;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_366_TimelineNote_IconGlyph(object instance, object Value)
	{
		((TimelineNote)instance).IconGlyph = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_367_TimelineNote_Content(object instance)
	{
		return ((TimelineNote)instance).Content;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_367_TimelineNote_Content(object instance, object Value)
	{
		((TimelineNote)instance).Content = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_368_JavaCompatibilityInstancesPage_ManagedInstances(object instance)
	{
		return ((JavaCompatibilityInstancesPage)instance).ManagedInstances;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_369_JavaInstanceInfo_Id(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_369_JavaInstanceInfo_Id(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).Id = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_370_JavaInstanceInfo_ServerId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ServerId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_370_JavaInstanceInfo_ServerId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).ServerId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_371_JavaInstanceInfo_ServerName(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ServerName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_371_JavaInstanceInfo_ServerName(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).ServerName = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_372_JavaInstanceInfo_RoleId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).RoleId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_372_JavaInstanceInfo_RoleId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).RoleId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_373_JavaInstanceInfo_RoleName(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).RoleName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_373_JavaInstanceInfo_RoleName(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).RoleName = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_374_JavaInstanceInfo_Version(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).Version;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_374_JavaInstanceInfo_Version(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).Version = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_375_JavaInstanceInfo_ExecutorPath(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ExecutorPath;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_375_JavaInstanceInfo_ExecutorPath(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).ExecutorPath = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_376_JavaInstanceInfo_WorkingDirectory(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).WorkingDirectory;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_376_JavaInstanceInfo_WorkingDirectory(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).WorkingDirectory = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_377_JavaInstanceInfo_ProcessId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ProcessId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_377_JavaInstanceInfo_ProcessId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).ProcessId = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_378_JavaInstanceInfo_StartedAt(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).StartedAt;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_378_JavaInstanceInfo_StartedAt(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).StartedAt = (DateTimeOffset)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_379_JavaInstanceInfo_State(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).State;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_379_JavaInstanceInfo_State(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).State = (ehKrWCfFyUBmIViVuUtd)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_380_JavaInstanceInfo_ExitCode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ExitCode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_380_JavaInstanceInfo_ExitCode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).ExitCode = (int?)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_381_JavaInstanceInfo_AuthPort(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).AuthPort;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_381_JavaInstanceInfo_AuthPort(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).AuthPort = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_382_JavaInstanceInfo_RpcPort(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).RpcPort;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_382_JavaInstanceInfo_RpcPort(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).RpcPort = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_383_JavaInstanceInfo_RecentLogs(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).RecentLogs;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_383_JavaInstanceInfo_RecentLogs(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).RecentLogs = (global::System.Collections.Generic.IReadOnlyList<string>)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_384_JavaInstanceInfo_ServerImageUrl(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ServerImageUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_384_JavaInstanceInfo_ServerImageUrl(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((rIp8CZfFJ2ofCfwfl3J2)instance).ServerImageUrl = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_385_JavaInstanceInfo_CrashReport(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).CrashReport;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_385_JavaInstanceInfo_CrashReport(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((rIp8CZfFJ2ofCfwfl3J2)instance).CrashReport = (wY9sp7fxIKIZJMsRVskD)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_386_JavaInstanceInfo_IsRunning(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).IsRunning;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_387_JavaInstanceInfo_CanStop(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).CanStop;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_388_JavaInstanceInfo_CanRestart(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).CanRestart;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_389_JavaInstanceInfo_StatusText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).StatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_390_JavaInstanceInfo_ExecutorName(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ExecutorName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_391_JavaInstanceInfo_ProcessIdText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).ProcessIdText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_392_JavaInstanceInfo_StartedAtText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).StartedAtText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_393_JavaInstanceInfo_PortText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).PortText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_394_JavaInstanceInfo_RecentLogText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).RecentLogText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_395_JavaInstanceInfo_HasCrashReport(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).HasCrashReport;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_396_JavaInstanceInfo_HasRawCrashArtifact(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).HasRawCrashArtifact;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_397_JavaInstanceInfo_CrashSummaryText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).CrashSummaryText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_398_JavaInstanceInfo_CrashFindingText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).CrashFindingText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_399_JavaInstanceInfo_CrashArtifactPathText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).CrashArtifactPathText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_400_JavaInstanceInfo_PrimaryCrashArtifactPath(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).PrimaryCrashArtifactPath;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_401_JavaInstanceInfo_InstanceKindText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).InstanceKindText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_402_JavaInstanceInfo_DetailText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((rIp8CZfFJ2ofCfwfl3J2)instance).DetailText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_403_JavaCompatibilityInstancesPage_ProxyInstances(object instance)
	{
		return ((JavaCompatibilityInstancesPage)instance).ProxyInstances;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_404_JavaProxyInstanceSnapshot_Id(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_404_JavaProxyInstanceSnapshot_Id(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).Id = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_405_JavaProxyInstanceSnapshot_State(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).State;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_405_JavaProxyInstanceSnapshot_State(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).State = (n1qKx2fNJL9msKD7ZGJu)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_406_JavaProxyInstanceSnapshot_LocalEndpoint(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).LocalEndpoint;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_406_JavaProxyInstanceSnapshot_LocalEndpoint(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((bq7k3qfN7qMnvLJMNOZa)instance).LocalEndpoint = (tevrq6fTnmxdv0004lXm)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_407_JavaProxyInstanceSnapshot_RemoteEndpoint(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).RemoteEndpoint;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_407_JavaProxyInstanceSnapshot_RemoteEndpoint(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((bq7k3qfN7qMnvLJMNOZa)instance).RemoteEndpoint = (tevrq6fTnmxdv0004lXm)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_408_JavaProxyInstanceSnapshot_ProtocolVersion(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).ProtocolVersion;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_408_JavaProxyInstanceSnapshot_ProtocolVersion(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).ProtocolVersion = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_409_JavaProxyInstanceSnapshot_ActiveConnections(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).ActiveConnections;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_409_JavaProxyInstanceSnapshot_ActiveConnections(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).ActiveConnections = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_410_JavaProxyInstanceSnapshot_Traffic(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).Traffic;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_410_JavaProxyInstanceSnapshot_Traffic(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((bq7k3qfN7qMnvLJMNOZa)instance).Traffic = (I8UL5cfNhu2cgReqF3g8)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_411_JavaProxyInstanceSnapshot_LastDisconnectReason(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).LastDisconnectReason;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_411_JavaProxyInstanceSnapshot_LastDisconnectReason(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).LastDisconnectReason = (f3JeIyfNCcv94eShPUIb)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_412_JavaProxyInstanceSnapshot_LastDisconnectDetail(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).LastDisconnectDetail;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_412_JavaProxyInstanceSnapshot_LastDisconnectDetail(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).LastDisconnectDetail = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_413_JavaProxyInstanceSnapshot_StartedAt(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).StartedAt;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_413_JavaProxyInstanceSnapshot_StartedAt(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).StartedAt = (DateTimeOffset)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_414_JavaProxyInstanceSnapshot_AccountId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).AccountId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_414_JavaProxyInstanceSnapshot_AccountId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).AccountId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_415_JavaProxyInstanceSnapshot_ServerId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).ServerId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_415_JavaProxyInstanceSnapshot_ServerId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).ServerId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_416_JavaProxyInstanceSnapshot_ServerName(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).ServerName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_416_JavaProxyInstanceSnapshot_ServerName(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).ServerName = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_417_JavaProxyInstanceSnapshot_RoleId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).RoleId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_417_JavaProxyInstanceSnapshot_RoleId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).RoleId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_418_JavaProxyInstanceSnapshot_RoleName(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).RoleName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_418_JavaProxyInstanceSnapshot_RoleName(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).RoleName = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_419_JavaProxyInstanceSnapshot_VersionName(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).VersionName;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_419_JavaProxyInstanceSnapshot_VersionName(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((bq7k3qfN7qMnvLJMNOZa)instance).VersionName = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_420_JavaProxyInstanceSnapshot_AccountDisplayText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).AccountDisplayText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_421_JavaProxyInstanceSnapshot_LocalAddressText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).LocalAddressText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_422_JavaProxyInstanceSnapshot_StateText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).StateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_423_JavaProxyInstanceSnapshot_ServerRoleText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).ServerRoleText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_424_JavaProxyInstanceSnapshot_StartedAtText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).StartedAtText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_425_JavaProxyInstanceSnapshot_TrafficText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).TrafficText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_426_JavaProxyInstanceSnapshot_DisconnectText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).DisconnectText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_427_JavaProxyInstanceSnapshot_CanStop(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).CanStop;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_428_JavaProxyInstanceSnapshot_CanRetry(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((bq7k3qfN7qMnvLJMNOZa)instance).CanRetry;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_429_JavaServersPage_Servers(object instance)
	{
		return ((JavaServersPage)instance).Servers;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_430_JavaServer_Id(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_430_JavaServer_Id(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).Id = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_431_JavaServer_DetailEntityId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).DetailEntityId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_431_JavaServer_DetailEntityId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).DetailEntityId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_432_JavaServer_CatalogItemId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).CatalogItemId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_432_JavaServer_CatalogItemId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).CatalogItemId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_433_JavaServer_ServerAddress(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).ServerAddress;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_433_JavaServer_ServerAddress(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).ServerAddress = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_434_JavaServer_ServerPort(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).ServerPort;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_434_JavaServer_ServerPort(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).ServerPort = (int)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_435_JavaServer_Name(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_435_JavaServer_Name(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).Name = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_436_JavaServer_Summary(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).Summary;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_436_JavaServer_Summary(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).Summary = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_437_JavaServer_Description(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_437_JavaServer_Description(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).Description = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_438_JavaServer_OnlineCount(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).OnlineCount;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_438_JavaServer_OnlineCount(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).OnlineCount = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_439_JavaServer_MaximumPlayers(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).MaximumPlayers;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_439_JavaServer_MaximumPlayers(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).MaximumPlayers = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_440_JavaServer_ImageUrl(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).ImageUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_440_JavaServer_ImageUrl(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).ImageUrl = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_441_JavaServer_Author(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).Author;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_441_JavaServer_Author(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).Author = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_442_JavaServer_Versions(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).Versions;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_442_JavaServer_Versions(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((YlErsbfs35V4xTUvrlXK)instance).Versions = (global::System.Collections.Generic.IReadOnlyList<ys1lxxfFBPhowwZS5N6T>)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_443_JavaServer_OnlineText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).OnlineText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_444_JavaServer_VersionText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).VersionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_445_JavaServer_OnlineDisplayText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((YlErsbfs35V4xTUvrlXK)instance).OnlineDisplayText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_446_JavaSkinsPage_Skins(object instance)
	{
		return ((JavaSkinsPage)instance).Skins;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_447_JavaSkinCardViewModel_Skin(object instance)
	{
		return ((JavaSkinCardViewModel)instance).Skin;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_448_JavaSkinCardViewModel_Name(object instance)
	{
		return ((JavaSkinCardViewModel)instance).Name;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_449_JavaSkinCardViewModel_Developer(object instance)
	{
		return ((JavaSkinCardViewModel)instance).Developer;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_450_JavaSkinCardViewModel_Summary(object instance)
	{
		return ((JavaSkinCardViewModel)instance).Summary;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_451_JavaSkinCardViewModel_CoverUrl(object instance)
	{
		return ((JavaSkinCardViewModel)instance).CoverUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_452_JavaSkinCardViewModel_MetricsText(object instance)
	{
		return ((JavaSkinCardViewModel)instance).MetricsText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_453_JavaSkinCardViewModel_OwnershipText(object instance)
	{
		return ((JavaSkinCardViewModel)instance).OwnershipText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_454_JavaSkinCardViewModel_IsApplied(object instance)
	{
		return ((JavaSkinCardViewModel)instance).IsApplied;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_454_JavaSkinCardViewModel_IsApplied(object instance, object Value)
	{
		((JavaSkinCardViewModel)instance).IsApplied = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_455_JavaSkinCardViewModel_AppliedVisibility(object instance)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((JavaSkinCardViewModel)instance).AppliedVisibility;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_456_JavaVersionManagementPage_Installations(object instance)
	{
		return ((JavaVersionManagementPage)instance).Installations;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_457_JavaVersionInstallationInfo_Version(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).Version;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_457_JavaVersionInstallationInfo_Version(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((WkLnWrfTRJdhyRBYcOwg)instance).Version = (ys1lxxfFBPhowwZS5N6T)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_458_JavaVersionInstallationInfo_ClientInstalled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).ClientInstalled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_458_JavaVersionInstallationInfo_ClientInstalled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WkLnWrfTRJdhyRBYcOwg)instance).ClientInstalled = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_459_JavaVersionInstallationInfo_Runtime(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).Runtime;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_459_JavaVersionInstallationInfo_Runtime(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		((WkLnWrfTRJdhyRBYcOwg)instance).Runtime = (uKGDFFfsxYJUyNmtk1xA)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_460_JavaVersionInstallationInfo_RuntimeInstalled(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).RuntimeInstalled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_460_JavaVersionInstallationInfo_RuntimeInstalled(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WkLnWrfTRJdhyRBYcOwg)instance).RuntimeInstalled = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_461_JavaVersionInstallationInfo_InstallationPath(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).InstallationPath;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_461_JavaVersionInstallationInfo_InstallationPath(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((WkLnWrfTRJdhyRBYcOwg)instance).InstallationPath = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_462_JavaVersionInstallationInfo_IsReady(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).IsReady;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_463_JavaVersionInstallationInfo_StatusText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).StatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_464_JavaVersionInstallationInfo_ClientStateText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).ClientStateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_465_JavaVersionInstallationInfo_RuntimeStateText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).RuntimeStateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_466_JavaVersionInstallationInfo_ActionText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).ActionText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_467_JavaVersionInstallationInfo_RuntimeText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WkLnWrfTRJdhyRBYcOwg)instance).RuntimeText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_468_Pay4399Page_GeneratedAccountHistory(object instance)
	{
		return ((Pay4399Page)instance).GeneratedAccountHistory;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_469_Pay4399AccountRecord_Id(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_469_Pay4399AccountRecord_Id(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((aMuqLcf6hnKdBTwYqLWe)instance).Id = (long)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_470_Pay4399AccountRecord_Username(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).Username;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_470_Pay4399AccountRecord_Username(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((aMuqLcf6hnKdBTwYqLWe)instance).Username = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_471_Pay4399AccountRecord_Password(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).Password;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_471_Pay4399AccountRecord_Password(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((aMuqLcf6hnKdBTwYqLWe)instance).Password = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_472_Pay4399AccountRecord_SauthJson(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).SauthJson;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_472_Pay4399AccountRecord_SauthJson(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((aMuqLcf6hnKdBTwYqLWe)instance).SauthJson = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_473_Pay4399AccountRecord_Source(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).Source;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_473_Pay4399AccountRecord_Source(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((aMuqLcf6hnKdBTwYqLWe)instance).Source = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_474_Pay4399AccountRecord_CreatedAt(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).CreatedAt;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_474_Pay4399AccountRecord_CreatedAt(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((aMuqLcf6hnKdBTwYqLWe)instance).CreatedAt = (DateTimeOffset)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_475_Pay4399AccountRecord_UpdatedAt(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).UpdatedAt;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_475_Pay4399AccountRecord_UpdatedAt(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((aMuqLcf6hnKdBTwYqLWe)instance).UpdatedAt = (DateTimeOffset)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_476_Pay4399AccountRecord_HasSauth(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).HasSauth;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_477_Pay4399AccountRecord_UsernameText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).UsernameText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_478_Pay4399AccountRecord_PasswordText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).PasswordText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_479_Pay4399AccountRecord_AccountText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).AccountText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_480_Pay4399AccountRecord_SauthStateText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).SauthStateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_481_Pay4399AccountRecord_SourceText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).SourceText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_482_Pay4399AccountRecord_SavedAtText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((aMuqLcf6hnKdBTwYqLWe)instance).SavedAtText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_483_Pay4399Page_PendingAccountHistory(object instance)
	{
		return ((Pay4399Page)instance).PendingAccountHistory;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_484_Pay4399PendingAccountRecord_CredentialHash(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).CredentialHash;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_484_Pay4399PendingAccountRecord_CredentialHash(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((pDLYXIf6mU1JnHirkJgm)instance).CredentialHash = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_485_Pay4399PendingAccountRecord_Channel(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).Channel;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_485_Pay4399PendingAccountRecord_Channel(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((pDLYXIf6mU1JnHirkJgm)instance).Channel = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_486_Pay4399PendingAccountRecord_OperationId(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).OperationId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_486_Pay4399PendingAccountRecord_OperationId(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((pDLYXIf6mU1JnHirkJgm)instance).OperationId = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_487_Pay4399PendingAccountRecord_Status(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).Status;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_487_Pay4399PendingAccountRecord_Status(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((pDLYXIf6mU1JnHirkJgm)instance).Status = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_488_Pay4399PendingAccountRecord_ExpectedPrice(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).ExpectedPrice;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_488_Pay4399PendingAccountRecord_ExpectedPrice(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((pDLYXIf6mU1JnHirkJgm)instance).ExpectedPrice = (decimal)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_489_Pay4399PendingAccountRecord_Message(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).Message;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_489_Pay4399PendingAccountRecord_Message(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((pDLYXIf6mU1JnHirkJgm)instance).Message = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_490_Pay4399PendingAccountRecord_CreatedAt(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).CreatedAt;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_490_Pay4399PendingAccountRecord_CreatedAt(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((pDLYXIf6mU1JnHirkJgm)instance).CreatedAt = (DateTimeOffset)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_491_Pay4399PendingAccountRecord_StatusText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).StatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_492_Pay4399PendingAccountRecord_CreatedAtText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((pDLYXIf6mU1JnHirkJgm)instance).CreatedAtText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_493_Motion_Lift(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		return Motion.GetLift((DependencyObject)instance);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_493_Motion_Lift(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		Motion.SetLift((DependencyObject)instance, (bool)Value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_494_Effects_Shadow(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		return Effects.GetShadow((FrameworkElement)instance);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_494_Effects_Shadow(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0014: Expected O, but got Unknown
		Effects.SetShadow((FrameworkElement)instance, (AttachedShadowBase)Value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_495_ToolboxPage_AccountSwitchInstances(object instance)
	{
		return ((ToolboxPage)instance).AccountSwitchInstances;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_496_X19LoginPage_GeneratedAccountHistory(object instance)
	{
		return ((X19LoginPage)instance).GeneratedAccountHistory;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_497_X19AccountRecord_Id(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_497_X19AccountRecord_Id(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((G87XFJfPfhylQ4RC1HmY)instance).Id = (long)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_498_X19AccountRecord_Account(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).Account;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_498_X19AccountRecord_Account(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((G87XFJfPfhylQ4RC1HmY)instance).Account = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_499_X19AccountRecord_Password(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).Password;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_499_X19AccountRecord_Password(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((G87XFJfPfhylQ4RC1HmY)instance).Password = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_500_X19AccountRecord_SauthJson(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).SauthJson;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_500_X19AccountRecord_SauthJson(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((G87XFJfPfhylQ4RC1HmY)instance).SauthJson = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_501_X19AccountRecord_LoginMode(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).LoginMode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_501_X19AccountRecord_LoginMode(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((G87XFJfPfhylQ4RC1HmY)instance).LoginMode = (string)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_502_X19AccountRecord_CreatedAt(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).CreatedAt;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_502_X19AccountRecord_CreatedAt(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((G87XFJfPfhylQ4RC1HmY)instance).CreatedAt = (DateTimeOffset)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_503_X19AccountRecord_UpdatedAt(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).UpdatedAt;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_503_X19AccountRecord_UpdatedAt(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		((G87XFJfPfhylQ4RC1HmY)instance).UpdatedAt = (DateTimeOffset)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_504_X19AccountRecord_HasSauth(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).HasSauth;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_505_X19AccountRecord_AccountDisplayText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).AccountDisplayText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_506_X19AccountRecord_CopyText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).CopyText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_507_X19AccountRecord_SauthStateText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).SauthStateText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_508_X19AccountRecord_LoginModeText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).LoginModeText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_509_X19AccountRecord_SavedAtText(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((G87XFJfPfhylQ4RC1HmY)instance).SavedAtText;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_510_TreeViewNode_Children(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TreeViewNode)instance).Children;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_511_TreeViewNode_Content(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TreeViewNode)instance).Content;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_511_TreeViewNode_Content(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TreeViewNode)instance).Content = Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_512_TreeViewNode_Depth(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TreeViewNode)instance).Depth;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_513_TreeViewNode_HasChildren(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TreeViewNode)instance).HasChildren;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_514_TreeViewNode_HasUnrealizedChildren(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TreeViewNode)instance).HasUnrealizedChildren;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_514_TreeViewNode_HasUnrealizedChildren(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TreeViewNode)instance).HasUnrealizedChildren = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_515_TreeViewNode_IsExpanded(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TreeViewNode)instance).IsExpanded;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void set_515_TreeViewNode_IsExpanded(object instance, object Value)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((TreeViewNode)instance).IsExpanded = (bool)Value;
	}

	[MethodImpl((MethodImplOptions)8)]
	private object get_516_TreeViewNode_Parent(object instance)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((TreeViewNode)instance).Parent;
	}

	[MethodImpl((MethodImplOptions)8)]
	private IXamlMember CreateXamlMember(string longMemberName)
	{
		XamlMember xamlMember = null;
		switch (_PrivateImplementationDetails_.ComputeStringHash(longMemberName))
		{
		case 1099259445u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.XamlControlsResources.UseCompactResources")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.XamlControlsResources");
				xamlMember = (XamlMember)new XamlMember(this, "UseCompactResources", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_0_XamlControlsResources_UseCompactResources;
				xamlMember.Setter = set_0_XamlControlsResources_UseCompactResources;
			}
			break;
		case 1539137127u:
			if (longMemberName == "Mahiro_Account.UI.Shell.PageHeader.Title")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Shell.PageHeader");
				xamlMember = (XamlMember)new XamlMember(this, "Title", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_1_PageHeader_Title;
				xamlMember.Setter = set_1_PageHeader_Title;
			}
			break;
		case 1589788947u:
			if (longMemberName == "Mahiro_Account.UI.Shell.PageHeader.Subtitle")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Shell.PageHeader");
				xamlMember = (XamlMember)new XamlMember(this, "Subtitle", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_2_PageHeader_Subtitle;
				xamlMember.Setter = set_2_PageHeader_Subtitle;
			}
			break;
		case 2509987698u:
			if (longMemberName == "Mahiro_Account.UI.Shell.PageHeader.Actions")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Shell.PageHeader");
				xamlMember = (XamlMember)new XamlMember(this, "Actions", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_3_PageHeader_Actions;
				xamlMember.Setter = set_3_PageHeader_Actions;
			}
			break;
		case 3867119265u:
			if (longMemberName == "Mahiro_Account.UI.Shell.PageHeader.HasSubtitle")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Shell.PageHeader");
				xamlMember = (XamlMember)new XamlMember(this, "HasSubtitle", "Microsoft.UI.Xaml.Visibility");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_4_PageHeader_HasSubtitle;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2079365972u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressRing.IsActive")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressRing");
				xamlMember = (XamlMember)new XamlMember(this, "IsActive", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_5_ProgressRing_IsActive;
				xamlMember.Setter = set_5_ProgressRing_IsActive;
			}
			break;
		case 1308092141u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressRing.IsIndeterminate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressRing");
				xamlMember = (XamlMember)new XamlMember(this, "IsIndeterminate", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_6_ProgressRing_IsIndeterminate;
				xamlMember.Setter = set_6_ProgressRing_IsIndeterminate;
			}
			break;
		case 2996456728u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressRing.Maximum")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressRing");
				xamlMember = (XamlMember)new XamlMember(this, "Maximum", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_7_ProgressRing_Maximum;
				xamlMember.Setter = set_7_ProgressRing_Maximum;
			}
			break;
		case 3521679762u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressRing.Minimum")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressRing");
				xamlMember = (XamlMember)new XamlMember(this, "Minimum", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_8_ProgressRing_Minimum;
				xamlMember.Setter = set_8_ProgressRing_Minimum;
			}
			break;
		case 718673373u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressRing.TemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressRing");
				xamlMember = (XamlMember)new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.ProgressRingTemplateSettings");
				xamlMember.Getter = get_9_ProgressRing_TemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4253274911u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressRing.Value")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressRing");
				xamlMember = (XamlMember)new XamlMember(this, "Value", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_10_ProgressRing_Value;
				xamlMember.Setter = set_10_ProgressRing_Value;
			}
			break;
		case 259577377u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.Content")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "Content", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_11_InfoBar_Content;
				xamlMember.Setter = set_11_InfoBar_Content;
			}
			break;
		case 1917150844u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.IsOpen")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsOpen", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_12_InfoBar_IsOpen;
				xamlMember.Setter = set_12_InfoBar_IsOpen;
			}
			break;
		case 1614996693u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.IsClosable")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsClosable", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_13_InfoBar_IsClosable;
				xamlMember.Setter = set_13_InfoBar_IsClosable;
			}
			break;
		case 4075667259u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.Severity")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "Severity", "Microsoft.UI.Xaml.Controls.InfoBarSeverity");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_14_InfoBar_Severity;
				xamlMember.Setter = set_14_InfoBar_Severity;
			}
			break;
		case 2410179010u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.Title")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "Title", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_15_InfoBar_Title;
				xamlMember.Setter = set_15_InfoBar_Title;
			}
			break;
		case 4017774803u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.Message")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "Message", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_16_InfoBar_Message;
				xamlMember.Setter = set_16_InfoBar_Message;
			}
			break;
		case 285502422u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.ActionButton")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "ActionButton", "Microsoft.UI.Xaml.Controls.Primitives.ButtonBase");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_17_InfoBar_ActionButton;
				xamlMember.Setter = set_17_InfoBar_ActionButton;
			}
			break;
		case 3325682773u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.CloseButtonCommand")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "CloseButtonCommand", "System.Windows.Input.ICommand");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_18_InfoBar_CloseButtonCommand;
				xamlMember.Setter = set_18_InfoBar_CloseButtonCommand;
			}
			break;
		case 1320817504u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.CloseButtonCommandParameter")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "CloseButtonCommandParameter", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_19_InfoBar_CloseButtonCommandParameter;
				xamlMember.Setter = set_19_InfoBar_CloseButtonCommandParameter;
			}
			break;
		case 3049238609u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.CloseButtonStyle")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "CloseButtonStyle", "Microsoft.UI.Xaml.Style");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_20_InfoBar_CloseButtonStyle;
				xamlMember.Setter = set_20_InfoBar_CloseButtonStyle;
			}
			break;
		case 292161639u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.ContentTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "ContentTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_21_InfoBar_ContentTemplate;
				xamlMember.Setter = set_21_InfoBar_ContentTemplate;
			}
			break;
		case 2635645416u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.IconSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "IconSource", "Microsoft.UI.Xaml.Controls.IconSource");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_22_InfoBar_IconSource;
				xamlMember.Setter = set_22_InfoBar_IconSource;
			}
			break;
		case 2809514409u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.IsIconVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsIconVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_23_InfoBar_IsIconVisible;
				xamlMember.Setter = set_23_InfoBar_IsIconVisible;
			}
			break;
		case 1026520971u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.InfoBar.TemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.InfoBar");
				xamlMember = (XamlMember)new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.InfoBarTemplateSettings");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_24_InfoBar_TemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 239564791u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryView.Accounts")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryView");
				xamlMember = (XamlMember)new XamlMember(this, "Accounts", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel>");
				xamlMember.Getter = get_25_BedrockAccountHistoryView_Accounts;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2125130484u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "Int64");
				xamlMember.Getter = get_26_BedrockAccountHistoryItemViewModel_Id;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1313430709u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.GameUserId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "GameUserId", "String");
				xamlMember.Getter = get_27_BedrockAccountHistoryItemViewModel_GameUserId;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 385454930u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.DisplayName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "DisplayName", "String");
				xamlMember.Getter = get_28_BedrockAccountHistoryItemViewModel_DisplayName;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2403363469u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.AccountDisplayText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "AccountDisplayText", "String");
				xamlMember.Getter = get_29_BedrockAccountHistoryItemViewModel_AccountDisplayText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1362732369u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.SavedAtValueText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "SavedAtValueText", "String");
				xamlMember.Getter = get_30_BedrockAccountHistoryItemViewModel_SavedAtValueText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 260750466u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.IsDetailsEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "IsDetailsEnabled", "Boolean");
				xamlMember.Getter = get_31_BedrockAccountHistoryItemViewModel_IsDetailsEnabled;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2712516885u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.AvatarSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "AvatarSource", "Microsoft.UI.Xaml.Media.Imaging.BitmapImage");
				xamlMember.Getter = get_32_BedrockAccountHistoryItemViewModel_AvatarSource;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 615168047u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.FrameSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "FrameSource", "Microsoft.UI.Xaml.Media.Imaging.BitmapImage");
				xamlMember.Getter = get_33_BedrockAccountHistoryItemViewModel_FrameSource;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 99109242u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.FrameVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "FrameVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_34_BedrockAccountHistoryItemViewModel_FrameVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3252522922u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.GrowthVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "GrowthVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_35_BedrockAccountHistoryItemViewModel_GrowthVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4230035992u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.MissingGrowthVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "MissingGrowthVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_36_BedrockAccountHistoryItemViewModel_MissingGrowthVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 630746624u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.VipVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "VipVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_37_BedrockAccountHistoryItemViewModel_VipVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2683833342u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.SecondaryText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "SecondaryText", "String");
				xamlMember.Getter = get_38_BedrockAccountHistoryItemViewModel_SecondaryText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 291936138u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.LevelText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "LevelText", "String");
				xamlMember.Getter = get_39_BedrockAccountHistoryItemViewModel_LevelText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 266841995u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.VipText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "VipText", "String");
				xamlMember.Getter = get_40_BedrockAccountHistoryItemViewModel_VipText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1641228134u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.ExperienceText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ExperienceText", "String");
				xamlMember.Getter = get_41_BedrockAccountHistoryItemViewModel_ExperienceText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1813752761u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.ExperienceMaximum")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ExperienceMaximum", "Double");
				xamlMember.Getter = get_42_BedrockAccountHistoryItemViewModel_ExperienceMaximum;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 518755330u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel.ExperienceValue")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountHistoryItemViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ExperienceValue", "Double");
				xamlMember.Getter = get_43_BedrockAccountHistoryItemViewModel_ExperienceValue;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3775961786u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressBar.IsIndeterminate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsIndeterminate", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_44_ProgressBar_IsIndeterminate;
				xamlMember.Setter = set_44_ProgressBar_IsIndeterminate;
			}
			break;
		case 1192526712u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressBar.ShowError")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressBar");
				xamlMember = (XamlMember)new XamlMember(this, "ShowError", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_45_ProgressBar_ShowError;
				xamlMember.Setter = set_45_ProgressBar_ShowError;
			}
			break;
		case 667437156u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressBar.ShowPaused")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressBar");
				xamlMember = (XamlMember)new XamlMember(this, "ShowPaused", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_46_ProgressBar_ShowPaused;
				xamlMember.Setter = set_46_ProgressBar_ShowPaused;
			}
			break;
		case 1204063892u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ProgressBar.TemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ProgressBar");
				xamlMember = (XamlMember)new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.ProgressBarTemplateSettings");
				xamlMember.Getter = get_47_ProgressBar_TemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1540478228u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabItems")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabItems", "System.Collections.Generic.IList`1<Object>");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_48_TabView_TabItems;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 714911315u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.IsAddTabButtonVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "IsAddTabButtonVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_49_TabView_IsAddTabButtonVisible;
				xamlMember.Setter = set_49_TabView_IsAddTabButtonVisible;
			}
			break;
		case 1396642407u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.CanDragTabs")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "CanDragTabs", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_50_TabView_CanDragTabs;
				xamlMember.Setter = set_50_TabView_CanDragTabs;
			}
			break;
		case 3559240256u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.CanReorderTabs")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "CanReorderTabs", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_51_TabView_CanReorderTabs;
				xamlMember.Setter = set_51_TabView_CanReorderTabs;
			}
			break;
		case 3527035631u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabWidthMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabWidthMode", "Microsoft.UI.Xaml.Controls.TabViewWidthMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_52_TabView_TabWidthMode;
				xamlMember.Setter = set_52_TabView_TabWidthMode;
			}
			break;
		case 2272844332u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommand")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "AddTabButtonCommand", "System.Windows.Input.ICommand");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_53_TabView_AddTabButtonCommand;
				xamlMember.Setter = set_53_TabView_AddTabButtonCommand;
			}
			break;
		case 2655400403u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.AddTabButtonCommandParameter")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "AddTabButtonCommandParameter", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_54_TabView_AddTabButtonCommandParameter;
				xamlMember.Setter = set_54_TabView_AddTabButtonCommandParameter;
			}
			break;
		case 1878459947u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.AllowDropTabs")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "AllowDropTabs", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_55_TabView_AllowDropTabs;
				xamlMember.Setter = set_55_TabView_AllowDropTabs;
			}
			break;
		case 4139795855u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.CanTearOutTabs")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "CanTearOutTabs", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_56_TabView_CanTearOutTabs;
				xamlMember.Setter = set_56_TabView_CanTearOutTabs;
			}
			break;
		case 3112007290u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.CloseButtonOverlayMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "CloseButtonOverlayMode", "Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_57_TabView_CloseButtonOverlayMode;
				xamlMember.Setter = set_57_TabView_CloseButtonOverlayMode;
			}
			break;
		case 857932020u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.SelectedIndex")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "SelectedIndex", "Int32");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_58_TabView_SelectedIndex;
				xamlMember.Setter = set_58_TabView_SelectedIndex;
			}
			break;
		case 3042979463u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.SelectedItem")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "SelectedItem", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_59_TabView_SelectedItem;
				xamlMember.Setter = set_59_TabView_SelectedItem;
			}
			break;
		case 3296229517u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabItemTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabItemTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_60_TabView_TabItemTemplate;
				xamlMember.Setter = set_60_TabView_TabItemTemplate;
			}
			break;
		case 1198497188u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabItemTemplateSelector")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabItemTemplateSelector", "Microsoft.UI.Xaml.Controls.DataTemplateSelector");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_61_TabView_TabItemTemplateSelector;
				xamlMember.Setter = set_61_TabView_TabItemTemplateSelector;
			}
			break;
		case 508445841u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabItemsSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabItemsSource", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_62_TabView_TabItemsSource;
				xamlMember.Setter = set_62_TabView_TabItemsSource;
			}
			break;
		case 681753617u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabStripFooter")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabStripFooter", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_63_TabView_TabStripFooter;
				xamlMember.Setter = set_63_TabView_TabStripFooter;
			}
			break;
		case 1197753207u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabStripFooterTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabStripFooterTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_64_TabView_TabStripFooterTemplate;
				xamlMember.Setter = set_64_TabView_TabStripFooterTemplate;
			}
			break;
		case 3706344199u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabStripHeader")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabStripHeader", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_65_TabView_TabStripHeader;
				xamlMember.Setter = set_65_TabView_TabStripHeader;
			}
			break;
		case 2073014565u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabView.TabStripHeaderTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabView");
				xamlMember = (XamlMember)new XamlMember(this, "TabStripHeaderTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_66_TabView_TabStripHeaderTemplate;
				xamlMember.Setter = set_66_TabView_TabStripHeaderTemplate;
			}
			break;
		case 3279942229u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabViewItem.Header")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "Header", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_67_TabViewItem_Header;
				xamlMember.Setter = set_67_TabViewItem_Header;
			}
			break;
		case 3423073393u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabViewItem.IsClosable")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "IsClosable", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_68_TabViewItem_IsClosable;
				xamlMember.Setter = set_68_TabViewItem_IsClosable;
			}
			break;
		case 2414189916u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabViewItem.IconSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "IconSource", "Microsoft.UI.Xaml.Controls.IconSource");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_69_TabViewItem_IconSource;
				xamlMember.Setter = set_69_TabViewItem_IconSource;
			}
			break;
		case 3025576731u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabViewItem.HeaderTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "HeaderTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_70_TabViewItem_HeaderTemplate;
				xamlMember.Setter = set_70_TabViewItem_HeaderTemplate;
			}
			break;
		case 1456906417u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TabViewItem.TabViewTemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TabViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "TabViewTemplateSettings", "Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_71_TabViewItem_TabViewTemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3788917041u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.Expander.Header")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Expander");
				xamlMember = (XamlMember)new XamlMember(this, "Header", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_72_Expander_Header;
				xamlMember.Setter = set_72_Expander_Header;
			}
			break;
		case 122492885u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.Expander.ExpandDirection")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Expander");
				xamlMember = (XamlMember)new XamlMember(this, "ExpandDirection", "Microsoft.UI.Xaml.Controls.ExpandDirection");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_73_Expander_ExpandDirection;
				xamlMember.Setter = set_73_Expander_ExpandDirection;
			}
			break;
		case 3783043671u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.Expander.HeaderTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Expander");
				xamlMember = (XamlMember)new XamlMember(this, "HeaderTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_74_Expander_HeaderTemplate;
				xamlMember.Setter = set_74_Expander_HeaderTemplate;
			}
			break;
		case 3593139694u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.Expander.HeaderTemplateSelector")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Expander");
				xamlMember = (XamlMember)new XamlMember(this, "HeaderTemplateSelector", "Microsoft.UI.Xaml.Controls.DataTemplateSelector");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_75_Expander_HeaderTemplateSelector;
				xamlMember.Setter = set_75_Expander_HeaderTemplateSelector;
			}
			break;
		case 285157005u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.Expander.IsExpanded")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Expander");
				xamlMember = (XamlMember)new XamlMember(this, "IsExpanded", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_76_Expander_IsExpanded;
				xamlMember.Setter = set_76_Expander_IsExpanded;
			}
			break;
		case 3886372395u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.Expander.TemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Expander");
				xamlMember = (XamlMember)new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.ExpanderTemplateSettings");
				xamlMember.Getter = get_77_Expander_TemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 954566658u:
			if (longMemberName == "Mahiro_Account.UI.Shell.ShellView.ShellXamlRoot")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Shell.ShellView");
				xamlMember = (XamlMember)new XamlMember(this, "ShellXamlRoot", "Microsoft.UI.Xaml.XamlRoot");
				xamlMember.Getter = get_78_ShellView_ShellXamlRoot;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2834491970u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailDialog.ViewModel")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailDialog");
				xamlMember = (XamlMember)new XamlMember(this, "ViewModel", "Mahiro_Account.UI.Controls.Bedrock.BedrockAccountProfileDetailViewModel");
				xamlMember.Getter = get_79_BedrockAccountProfileDetailDialog_ViewModel;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 969106412u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.WebView2.DefaultBackgroundColor")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.WebView2");
				xamlMember = (XamlMember)new XamlMember(this, "DefaultBackgroundColor", "Windows.UI.Color");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_80_WebView2_DefaultBackgroundColor;
				xamlMember.Setter = set_80_WebView2_DefaultBackgroundColor;
			}
			break;
		case 1924933279u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.WebView2.CanGoBack")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.WebView2");
				xamlMember = (XamlMember)new XamlMember(this, "CanGoBack", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_81_WebView2_CanGoBack;
				xamlMember.Setter = set_81_WebView2_CanGoBack;
			}
			break;
		case 2894096249u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.WebView2.CanGoForward")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.WebView2");
				xamlMember = (XamlMember)new XamlMember(this, "CanGoForward", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_82_WebView2_CanGoForward;
				xamlMember.Setter = set_82_WebView2_CanGoForward;
			}
			break;
		case 546950340u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.WebView2.CoreWebView2")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.WebView2");
				xamlMember = (XamlMember)new XamlMember(this, "CoreWebView2", "Microsoft.Web.WebView2.Core.CoreWebView2");
				xamlMember.Getter = get_83_WebView2_CoreWebView2;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3304172001u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.WebView2.Source")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.WebView2");
				xamlMember = (XamlMember)new XamlMember(this, "Source", "System.Uri");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_84_WebView2_Source;
				xamlMember.Setter = set_84_WebView2_Source;
			}
			break;
		case 343507892u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage.ImageStretch")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage");
				xamlMember = (XamlMember)new XamlMember(this, "ImageStretch", "Microsoft.UI.Xaml.Media.Stretch");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_85_BedrockNetworkImage_ImageStretch;
				xamlMember.Setter = set_85_BedrockNetworkImage_ImageStretch;
			}
			break;
		case 3483132272u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage.ImageUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage");
				xamlMember = (XamlMember)new XamlMember(this, "ImageUrl", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_86_BedrockNetworkImage_ImageUrl;
				xamlMember.Setter = set_86_BedrockNetworkImage_ImageUrl;
			}
			break;
		case 2312015314u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceList.Instances")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceList");
				xamlMember = (XamlMember)new XamlMember(this, "Instances", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel>");
				xamlMember.Getter = get_87_BedrockInstanceList_Instances;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2089023849u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.Instance")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Instance", "Mahiro_Account.Models.Bedrock.BedrockInstanceInfo");
				xamlMember.Getter = get_88_BedrockInstanceCardViewModel_Instance;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 608601671u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.Relay")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Relay", "Mahiro_Account.Services.Bedrock.Relay.BedrockRelaySnapshot");
				xamlMember.Getter = get_89_BedrockInstanceCardViewModel_Relay;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1721171198u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.ProcessId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ProcessId", "Int32");
				xamlMember.Getter = get_90_BedrockInstanceCardViewModel_ProcessId;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1820281144u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.Title")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Title", "String");
				xamlMember.Getter = get_91_BedrockInstanceCardViewModel_Title;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1087165575u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.KindText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "KindText", "String");
				xamlMember.Getter = get_92_BedrockInstanceCardViewModel_KindText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1248177846u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.CoverUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CoverUrl", "String");
				xamlMember.Getter = get_93_BedrockInstanceCardViewModel_CoverUrl;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 566951383u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.StatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "StatusText", "String");
				xamlMember.Getter = get_94_BedrockInstanceCardViewModel_StatusText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4219419448u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.StartedText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "StartedText", "String");
				xamlMember.Getter = get_95_BedrockInstanceCardViewModel_StartedText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4144138621u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.StartedTimeText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "StartedTimeText", "String");
				xamlMember.Getter = get_96_BedrockInstanceCardViewModel_StartedTimeText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 321946962u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.AccountText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "AccountText", "String");
				xamlMember.Getter = get_97_BedrockInstanceCardViewModel_AccountText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 783123816u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.DetailText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "DetailText", "String");
				xamlMember.Getter = get_98_BedrockInstanceCardViewModel_DetailText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 233577332u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.ProcessText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ProcessText", "String");
				xamlMember.Getter = get_99_BedrockInstanceCardViewModel_ProcessText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 63376061u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.ProcessIdText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ProcessIdText", "String");
				xamlMember.Getter = get_100_BedrockInstanceCardViewModel_ProcessIdText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1722654584u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.ClientVersionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ClientVersionText", "String");
				xamlMember.Getter = get_101_BedrockInstanceCardViewModel_ClientVersionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2496839980u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.ProcessLabelText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ProcessLabelText", "String");
				xamlMember.Getter = get_102_BedrockInstanceCardViewModel_ProcessLabelText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 698664990u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.ClientLabelText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ClientLabelText", "String");
				xamlMember.Getter = get_103_BedrockInstanceCardViewModel_ClientLabelText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 304384707u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.OpenActionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OpenActionText", "String");
				xamlMember.Getter = get_104_BedrockInstanceCardViewModel_OpenActionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 859815087u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.CloseActionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CloseActionText", "String");
				xamlMember.Getter = get_105_BedrockInstanceCardViewModel_CloseActionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1922570549u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.OpenPath")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OpenPath", "String");
				xamlMember.Getter = get_106_BedrockInstanceCardViewModel_OpenPath;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2698925120u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.CanOpenFolder")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CanOpenFolder", "Boolean");
				xamlMember.Getter = get_107_BedrockInstanceCardViewModel_CanOpenFolder;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1697644904u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.CanClose")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CanClose", "Boolean");
				xamlMember.Getter = get_108_BedrockInstanceCardViewModel_CanClose;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2184253430u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.OverlayVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OverlayVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_109_BedrockInstanceCardViewModel_OverlayVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1137466952u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.CanLoadOverlay")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CanLoadOverlay", "Boolean");
				xamlMember.Getter = get_110_BedrockInstanceCardViewModel_CanLoadOverlay;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 379590161u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.OverlayProgressVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OverlayProgressVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_111_BedrockInstanceCardViewModel_OverlayProgressVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3959247627u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.OverlayActionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OverlayActionText", "String");
				xamlMember.Getter = get_112_BedrockInstanceCardViewModel_OverlayActionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 813085391u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel.OverlayStatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OverlayStatusText", "String");
				xamlMember.Getter = get_113_BedrockInstanceCardViewModel_OverlayStatusText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1940499792u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyBrowser.Rooms")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "Rooms", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel>");
				xamlMember.Getter = get_114_BedrockLocalLobbyBrowser_Rooms;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1185215448u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.Room")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Room", "Mahiro_Account.Models.Bedrock.BedrockLocalLobbyRoom");
				xamlMember.Getter = get_115_BedrockLocalLobbyRoomCardViewModel_Room;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2785478204u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_116_BedrockLocalLobbyRoomCardViewModel_Name;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 587710067u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.Description")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Description", "String");
				xamlMember.Getter = get_117_BedrockLocalLobbyRoomCardViewModel_Description;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 385123895u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.CoverUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CoverUrl", "String");
				xamlMember.Getter = get_118_BedrockLocalLobbyRoomCardViewModel_CoverUrl;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2616964349u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.PlayerText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "PlayerText", "String");
				xamlMember.Getter = get_119_BedrockLocalLobbyRoomCardViewModel_PlayerText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3223282612u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.CategoryText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CategoryText", "String");
				xamlMember.Getter = get_120_BedrockLocalLobbyRoomCardViewModel_CategoryText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1325188498u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.VersionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "VersionText", "String");
				xamlMember.Getter = get_121_BedrockLocalLobbyRoomCardViewModel_VersionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2096056810u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel.StatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockLocalLobbyRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "StatusText", "String");
				xamlMember.Getter = get_122_BedrockLocalLobbyRoomCardViewModel_StatusText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2990825537u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackBrowser.Packs")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "Packs", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel>");
				xamlMember.Getter = get_123_BedrockMaterialPackBrowser_Packs;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3451367946u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.Pack")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Pack", "Mahiro_Account.Models.Bedrock.BedrockMaterialPack");
				xamlMember.Getter = get_124_BedrockMaterialPackViewModel_Pack;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2706897954u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "String");
				xamlMember.Getter = get_125_BedrockMaterialPackViewModel_Id;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1632203500u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_126_BedrockMaterialPackViewModel_Name;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1672956995u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.Description")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Description", "String");
				xamlMember.Getter = get_127_BedrockMaterialPackViewModel_Description;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1525258713u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.MetadataText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "MetadataText", "String");
				xamlMember.Getter = get_128_BedrockMaterialPackViewModel_MetadataText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1830876418u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.ExclusionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ExclusionText", "String");
				xamlMember.Getter = get_129_BedrockMaterialPackViewModel_ExclusionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2354472979u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.IconSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "IconSource", "Microsoft.UI.Xaml.Media.Imaging.BitmapImage");
				xamlMember.Getter = get_130_BedrockMaterialPackViewModel_IconSource;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3750932110u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.IconVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "IconVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_131_BedrockMaterialPackViewModel_IconVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3911157064u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.PlaceholderVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "PlaceholderVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_132_BedrockMaterialPackViewModel_PlaceholderVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 887527880u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.IsEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "IsEnabled", "Boolean");
				xamlMember.Getter = get_133_BedrockMaterialPackViewModel_IsEnabled;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1268011850u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.EnabledStateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "EnabledStateText", "String");
				xamlMember.Getter = get_134_BedrockMaterialPackViewModel_EnabledStateText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 224230477u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.AllowFontOverride")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "AllowFontOverride", "Boolean");
				xamlMember.Getter = get_135_BedrockMaterialPackViewModel_AllowFontOverride;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 771761801u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.EnableActionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "EnableActionText", "String");
				xamlMember.Getter = get_136_BedrockMaterialPackViewModel_EnableActionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3595464302u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.FontProtectionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "FontProtectionText", "String");
				xamlMember.Getter = get_137_BedrockMaterialPackViewModel_FontProtectionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3883496757u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.FontProtectionStateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "FontProtectionStateText", "String");
				xamlMember.Getter = get_138_BedrockMaterialPackViewModel_FontProtectionStateText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1961081440u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.FontProtectionToolTip")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "FontProtectionToolTip", "String");
				xamlMember.Getter = get_139_BedrockMaterialPackViewModel_FontProtectionToolTip;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2909086035u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.EnableToolTip")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "EnableToolTip", "String");
				xamlMember.Getter = get_140_BedrockMaterialPackViewModel_EnableToolTip;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2798914208u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.CanDelete")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CanDelete", "Boolean");
				xamlMember.Getter = get_141_BedrockMaterialPackViewModel_CanDelete;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2041297600u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.DeleteVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "DeleteVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_142_BedrockMaterialPackViewModel_DeleteVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4067819367u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.CanMoveUp")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CanMoveUp", "Boolean");
				xamlMember.Getter = get_143_BedrockMaterialPackViewModel_CanMoveUp;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2066441634u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel.CanMoveDown")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockMaterialPackViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CanMoveDown", "Boolean");
				xamlMember.Getter = get_144_BedrockMaterialPackViewModel_CanMoveDown;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2748838945u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.Content")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "Content", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_145_SettingsExpander_Content;
				xamlMember.Setter = set_145_SettingsExpander_Content;
			}
			break;
		case 420736081u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.Header")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "Header", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_146_SettingsExpander_Header;
				xamlMember.Setter = set_146_SettingsExpander_Header;
			}
			break;
		case 2233579358u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.Description")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "Description", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_147_SettingsExpander_Description;
				xamlMember.Setter = set_147_SettingsExpander_Description;
			}
			break;
		case 4119235437u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.IsExpanded")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "IsExpanded", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_148_SettingsExpander_IsExpanded;
				xamlMember.Setter = set_148_SettingsExpander_IsExpanded;
			}
			break;
		case 3453561340u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.HeaderIcon")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "HeaderIcon", "Microsoft.UI.Xaml.Controls.IconElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_149_SettingsExpander_HeaderIcon;
				xamlMember.Setter = set_149_SettingsExpander_HeaderIcon;
			}
			break;
		case 481844616u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.Items")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "Items", "System.Collections.Generic.IList`1<Object>");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_150_SettingsExpander_Items;
				xamlMember.Setter = set_150_SettingsExpander_Items;
			}
			break;
		case 787191933u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.ItemsSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "ItemsSource", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_151_SettingsExpander_ItemsSource;
				xamlMember.Setter = set_151_SettingsExpander_ItemsSource;
			}
			break;
		case 2843309337u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.ItemTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "ItemTemplate", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_152_SettingsExpander_ItemTemplate;
				xamlMember.Setter = set_152_SettingsExpander_ItemTemplate;
			}
			break;
		case 1633050746u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.ItemContainerStyleSelector")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "ItemContainerStyleSelector", "Microsoft.UI.Xaml.Controls.StyleSelector");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_153_SettingsExpander_ItemContainerStyleSelector;
				xamlMember.Setter = set_153_SettingsExpander_ItemContainerStyleSelector;
			}
			break;
		case 2310174445u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.ItemsHeader")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "ItemsHeader", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_154_SettingsExpander_ItemsHeader;
				xamlMember.Setter = set_154_SettingsExpander_ItemsHeader;
			}
			break;
		case 2387877243u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsExpander.ItemsFooter")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsExpander");
				xamlMember = (XamlMember)new XamlMember(this, "ItemsFooter", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_155_SettingsExpander_ItemsFooter;
				xamlMember.Setter = set_155_SettingsExpander_ItemsFooter;
			}
			break;
		case 1327491514u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.Header")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "Header", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_156_SettingsCard_Header;
				xamlMember.Setter = set_156_SettingsCard_Header;
			}
			break;
		case 26869983u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.Description")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "Description", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_157_SettingsCard_Description;
				xamlMember.Setter = set_157_SettingsCard_Description;
			}
			break;
		case 2456814391u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.HeaderIcon")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "HeaderIcon", "Microsoft.UI.Xaml.Controls.IconElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_158_SettingsCard_HeaderIcon;
				xamlMember.Setter = set_158_SettingsCard_HeaderIcon;
			}
			break;
		case 2678211060u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.ActionIcon")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "ActionIcon", "Microsoft.UI.Xaml.Controls.IconElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_159_SettingsCard_ActionIcon;
				xamlMember.Setter = set_159_SettingsCard_ActionIcon;
			}
			break;
		case 184482959u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.ActionIconToolTip")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "ActionIconToolTip", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_160_SettingsCard_ActionIconToolTip;
				xamlMember.Setter = set_160_SettingsCard_ActionIconToolTip;
			}
			break;
		case 1074157866u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.IsClickEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "IsClickEnabled", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_161_SettingsCard_IsClickEnabled;
				xamlMember.Setter = set_161_SettingsCard_IsClickEnabled;
			}
			break;
		case 2056942417u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.ContentAlignment")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "ContentAlignment", "CommunityToolkit.WinUI.Controls.ContentAlignment");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_162_SettingsCard_ContentAlignment;
				xamlMember.Setter = set_162_SettingsCard_ContentAlignment;
			}
			break;
		case 2923018642u:
			if (longMemberName == "CommunityToolkit.WinUI.Controls.SettingsCard.IsActionIconVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Controls.SettingsCard");
				xamlMember = (XamlMember)new XamlMember(this, "IsActionIconVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_163_SettingsCard_IsActionIconVisible;
				xamlMember.Setter = set_163_SettingsCard_IsActionIconVisible;
			}
			break;
		case 3823970736u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser.Rooms")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "Rooms", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel>");
				xamlMember.Getter = get_164_BedrockRentalRoomBrowser_Rooms;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 626741611u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.Room")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Room", "Mahiro_Account.Models.Bedrock.BedrockRentalRoom");
				xamlMember.Getter = get_165_BedrockRentalRoomCardViewModel_Room;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4236793083u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_166_BedrockRentalRoomCardViewModel_Name;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2457126305u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.RoomNumberText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "RoomNumberText", "String");
				xamlMember.Getter = get_167_BedrockRentalRoomCardViewModel_RoomNumberText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 559202695u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.SummaryText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "SummaryText", "String");
				xamlMember.Getter = get_168_BedrockRentalRoomCardViewModel_SummaryText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3442306326u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.PlayerText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "PlayerText", "String");
				xamlMember.Getter = get_169_BedrockRentalRoomCardViewModel_PlayerText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1613730204u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.PopularityText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "PopularityText", "String");
				xamlMember.Getter = get_170_BedrockRentalRoomCardViewModel_PopularityText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 313628141u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.LevelText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "LevelText", "String");
				xamlMember.Getter = get_171_BedrockRentalRoomCardViewModel_LevelText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3023750338u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.PasswordText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "PasswordText", "String");
				xamlMember.Getter = get_172_BedrockRentalRoomCardViewModel_PasswordText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1800708890u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.PasswordShortText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "PasswordShortText", "String");
				xamlMember.Getter = get_173_BedrockRentalRoomCardViewModel_PasswordShortText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1100530319u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.LevelShortText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "LevelShortText", "String");
				xamlMember.Getter = get_174_BedrockRentalRoomCardViewModel_LevelShortText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2158466417u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.StatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "StatusText", "String");
				xamlMember.Getter = get_175_BedrockRentalRoomCardViewModel_StatusText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2178878963u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.VersionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "VersionText", "String");
				xamlMember.Getter = get_176_BedrockRentalRoomCardViewModel_VersionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3190102324u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel.CoverUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CoverUrl", "String");
				xamlMember.Getter = get_177_BedrockRentalRoomCardViewModel_CoverUrl;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2901322310u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser.RelayBindScope")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "RelayBindScope", "Mahiro_Account.Services.Bedrock.Relay.BedrockRelayBindScope");
				xamlMember.Getter = get_178_BedrockRentalRoomBrowser_RelayBindScope;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2104456097u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser.RelayFrontendProtocol")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockRentalRoomBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "RelayFrontendProtocol", "Int32");
				xamlMember.Getter = get_179_BedrockRentalRoomBrowser_RelayFrontendProtocol;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3386535322u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser.Servers")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "Servers", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel>");
				xamlMember.Getter = get_180_BedrockServerBrowser_Servers;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3087214697u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel.Server")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Server", "Mahiro_Account.Models.Bedrock.BedrockServer");
				xamlMember.Getter = get_181_BedrockServerCardViewModel_Server;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2701379437u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_182_BedrockServerCardViewModel_Name;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1879519690u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel.Summary")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Summary", "String");
				xamlMember.Getter = get_183_BedrockServerCardViewModel_Summary;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3184602158u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel.OnlineText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OnlineText", "String");
				xamlMember.Getter = get_184_BedrockServerCardViewModel_OnlineText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 271047782u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel.CoverUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CoverUrl", "String");
				xamlMember.Getter = get_185_BedrockServerCardViewModel_CoverUrl;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3011402918u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel.PlatformText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "PlatformText", "String");
				xamlMember.Getter = get_186_BedrockServerCardViewModel_PlatformText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1172849648u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser.RelayBindScope")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "RelayBindScope", "Mahiro_Account.Services.Bedrock.Relay.BedrockRelayBindScope");
				xamlMember.Getter = get_187_BedrockServerBrowser_RelayBindScope;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1221264755u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser.RelayFrontendProtocol")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockServerBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "RelayFrontendProtocol", "Int32");
				xamlMember.Getter = get_188_BedrockServerBrowser_RelayFrontendProtocol;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3163901175u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinViewer.AutoRotateEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinViewer");
				xamlMember = (XamlMember)new XamlMember(this, "AutoRotateEnabled", "Boolean");
				xamlMember.Getter = get_189_BedrockSkinViewer_AutoRotateEnabled;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2480466983u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.SelectorBar.Items")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.SelectorBar");
				xamlMember = (XamlMember)new XamlMember(this, "Items", "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.SelectorBarItem>");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_190_SelectorBar_Items;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3607071017u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemContainer.Child")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemContainer");
				xamlMember = (XamlMember)new XamlMember(this, "Child", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_191_ItemContainer_Child;
				xamlMember.Setter = set_191_ItemContainer_Child;
			}
			break;
		case 2576643512u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemContainer.IsSelected")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemContainer");
				xamlMember = (XamlMember)new XamlMember(this, "IsSelected", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_192_ItemContainer_IsSelected;
				xamlMember.Setter = set_192_ItemContainer_IsSelected;
			}
			break;
		case 2854641803u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.SelectorBarItem.Text")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.SelectorBarItem");
				xamlMember = (XamlMember)new XamlMember(this, "Text", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_193_SelectorBarItem_Text;
				xamlMember.Setter = set_193_SelectorBarItem_Text;
			}
			break;
		case 1529772701u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.SelectorBarItem.Icon")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.SelectorBarItem");
				xamlMember = (XamlMember)new XamlMember(this, "Icon", "Microsoft.UI.Xaml.Controls.IconElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_194_SelectorBarItem_Icon;
				xamlMember.Setter = set_194_SelectorBarItem_Icon;
			}
			break;
		case 1325379299u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.SelectorBar.SelectedItem")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.SelectorBar");
				xamlMember = (XamlMember)new XamlMember(this, "SelectedItem", "Microsoft.UI.Xaml.Controls.SelectorBarItem");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_195_SelectorBar_SelectedItem;
				xamlMember.Setter = set_195_SelectorBar_SelectedItem;
			}
			break;
		case 1820824414u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinBrowser.Skins")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinBrowser");
				xamlMember = (XamlMember)new XamlMember(this, "Skins", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel>");
				xamlMember.Getter = get_196_BedrockSkinBrowser_Skins;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 11958682u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.Kind")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Kind", "Mahiro_Account.Models.Bedrock.BedrockAppearanceKind");
				xamlMember.Getter = get_197_BedrockSkinCardViewModel_Kind;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3081276558u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.TwoDimensionalSkin")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "TwoDimensionalSkin", "Mahiro_Account.Models.Bedrock.BedrockFreeSkin");
				xamlMember.Getter = get_198_BedrockSkinCardViewModel_TwoDimensionalSkin;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4191112424u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.FourDimensionalSkin")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "FourDimensionalSkin", "Mahiro_Account.Models.Bedrock.BedrockFourDimensionalSkin");
				xamlMember.Getter = get_199_BedrockSkinCardViewModel_FourDimensionalSkin;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 113683972u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.FourDimensionalPart")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "FourDimensionalPart", "Mahiro_Account.Models.Bedrock.BedrockFourDimensionalPart");
				xamlMember.Getter = get_200_BedrockSkinCardViewModel_FourDimensionalPart;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2503866997u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "String");
				xamlMember.Getter = get_201_BedrockSkinCardViewModel_Id;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3228063659u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_202_BedrockSkinCardViewModel_Name;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1663306842u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.Developer")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Developer", "String");
				xamlMember.Getter = get_203_BedrockSkinCardViewModel_Developer;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3061017312u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.Summary")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Summary", "String");
				xamlMember.Getter = get_204_BedrockSkinCardViewModel_Summary;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 123855460u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.CoverUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CoverUrl", "String");
				xamlMember.Getter = get_205_BedrockSkinCardViewModel_CoverUrl;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1460207094u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.MetricsText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "MetricsText", "String");
				xamlMember.Getter = get_206_BedrockSkinCardViewModel_MetricsText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2307577797u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.ResourceStatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "ResourceStatusText", "String");
				xamlMember.Getter = get_207_BedrockSkinCardViewModel_ResourceStatusText;
				xamlMember.Setter = set_207_BedrockSkinCardViewModel_ResourceStatusText;
			}
			break;
		case 1957815445u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.IsApplied")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "IsApplied", "Boolean");
				xamlMember.Getter = get_208_BedrockSkinCardViewModel_IsApplied;
				xamlMember.Setter = set_208_BedrockSkinCardViewModel_IsApplied;
			}
			break;
		case 1352325997u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel.AppliedVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Bedrock.BedrockSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "AppliedVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_209_BedrockSkinCardViewModel_AppliedVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2206404214u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "ItemTemplate", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_210_ItemsRepeater_ItemTemplate;
				xamlMember.Setter = set_210_ItemsRepeater_ItemTemplate;
			}
			break;
		case 3565427393u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.Layout")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "Layout", "Microsoft.UI.Xaml.Controls.Layout");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_211_ItemsRepeater_Layout;
				xamlMember.Setter = set_211_ItemsRepeater_Layout;
			}
			break;
		case 1359485463u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.Background")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "Background", "Microsoft.UI.Xaml.Media.Brush");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_212_ItemsRepeater_Background;
				xamlMember.Setter = set_212_ItemsRepeater_Background;
			}
			break;
		case 1426219223u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.HorizontalCacheLength")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "HorizontalCacheLength", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_213_ItemsRepeater_HorizontalCacheLength;
				xamlMember.Setter = set_213_ItemsRepeater_HorizontalCacheLength;
			}
			break;
		case 1152159046u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTransitionProvider")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "ItemTransitionProvider", "Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_214_ItemsRepeater_ItemTransitionProvider;
				xamlMember.Setter = set_214_ItemsRepeater_ItemTransitionProvider;
			}
			break;
		case 1571500176u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "ItemsSource", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_215_ItemsRepeater_ItemsSource;
				xamlMember.Setter = set_215_ItemsRepeater_ItemsSource;
			}
			break;
		case 2400328257u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSourceView")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "ItemsSourceView", "Microsoft.UI.Xaml.Controls.ItemsSourceView");
				xamlMember.Getter = get_216_ItemsRepeater_ItemsSourceView;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1548358381u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ItemsRepeater.VerticalCacheLength")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ItemsRepeater");
				xamlMember = (XamlMember)new XamlMember(this, "VerticalCacheLength", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_217_ItemsRepeater_VerticalCacheLength;
				xamlMember.Setter = set_217_ItemsRepeater_VerticalCacheLength;
			}
			break;
		case 3438419736u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemWidth")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "MinItemWidth", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_218_UniformGridLayout_MinItemWidth;
				xamlMember.Setter = set_218_UniformGridLayout_MinItemWidth;
			}
			break;
		case 328647855u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.MinItemHeight")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "MinItemHeight", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_219_UniformGridLayout_MinItemHeight;
				xamlMember.Setter = set_219_UniformGridLayout_MinItemHeight;
			}
			break;
		case 2386100386u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.MinRowSpacing")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "MinRowSpacing", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_220_UniformGridLayout_MinRowSpacing;
				xamlMember.Setter = set_220_UniformGridLayout_MinRowSpacing;
			}
			break;
		case 3167378178u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.MinColumnSpacing")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "MinColumnSpacing", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_221_UniformGridLayout_MinColumnSpacing;
				xamlMember.Setter = set_221_UniformGridLayout_MinColumnSpacing;
			}
			break;
		case 82164283u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsJustification")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "ItemsJustification", "Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsJustification");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_222_UniformGridLayout_ItemsJustification;
				xamlMember.Setter = set_222_UniformGridLayout_ItemsJustification;
			}
			break;
		case 484954040u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.ItemsStretch")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "ItemsStretch", "Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_223_UniformGridLayout_ItemsStretch;
				xamlMember.Setter = set_223_UniformGridLayout_ItemsStretch;
			}
			break;
		case 595646332u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.MaximumRowsOrColumns")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "MaximumRowsOrColumns", "Int32");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_224_UniformGridLayout_MaximumRowsOrColumns;
				xamlMember.Setter = set_224_UniformGridLayout_MaximumRowsOrColumns;
			}
			break;
		case 1829028557u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.UniformGridLayout.Orientation")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.UniformGridLayout");
				xamlMember = (XamlMember)new XamlMember(this, "Orientation", "Microsoft.UI.Xaml.Controls.Orientation");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_225_UniformGridLayout_Orientation;
				xamlMember.Setter = set_225_UniformGridLayout_Orientation;
			}
			break;
		case 826114032u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.Layout.IndexBasedLayoutOrientation")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.Layout");
				xamlMember = (XamlMember)new XamlMember(this, "IndexBasedLayoutOrientation", "Microsoft.UI.Xaml.Controls.IndexBasedLayoutOrientation");
				xamlMember.Getter = get_226_Layout_IndexBasedLayoutOrientation;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1601191885u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.GradientStops")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "GradientStops", "Windows.Foundation.Collections.IObservableVector`1<Microsoft.UI.Xaml.Media.GradientStop>");
				xamlMember.Getter = get_227_RadialGradientBrush_GradientStops;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4019611285u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.Center")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "Center", "Windows.Foundation.Point");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_228_RadialGradientBrush_Center;
				xamlMember.Setter = set_228_RadialGradientBrush_Center;
			}
			break;
		case 1084004686u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.GradientOrigin")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "GradientOrigin", "Windows.Foundation.Point");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_229_RadialGradientBrush_GradientOrigin;
				xamlMember.Setter = set_229_RadialGradientBrush_GradientOrigin;
			}
			break;
		case 1928795380u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.InterpolationSpace")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "InterpolationSpace", "Microsoft.UI.Composition.CompositionColorSpace");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_230_RadialGradientBrush_InterpolationSpace;
				xamlMember.Setter = set_230_RadialGradientBrush_InterpolationSpace;
			}
			break;
		case 173981953u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.MappingMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "MappingMode", "Microsoft.UI.Xaml.Media.BrushMappingMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_231_RadialGradientBrush_MappingMode;
				xamlMember.Setter = set_231_RadialGradientBrush_MappingMode;
			}
			break;
		case 2875187086u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.RadiusX")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "RadiusX", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_232_RadialGradientBrush_RadiusX;
				xamlMember.Setter = set_232_RadialGradientBrush_RadiusX;
			}
			break;
		case 2891964705u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.RadiusY")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "RadiusY", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_233_RadialGradientBrush_RadiusY;
				xamlMember.Setter = set_233_RadialGradientBrush_RadiusY;
			}
			break;
		case 4267045818u:
			if (longMemberName == "Microsoft.UI.Xaml.Media.RadialGradientBrush.SpreadMethod")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Media.RadialGradientBrush");
				xamlMember = (XamlMember)new XamlMember(this, "SpreadMethod", "Microsoft.UI.Xaml.Media.GradientSpreadMethod");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_234_RadialGradientBrush_SpreadMethod;
				xamlMember.Setter = set_234_RadialGradientBrush_SpreadMethod;
			}
			break;
		case 2143328791u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.BadgeGlyph")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "BadgeGlyph", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_235_PersonPicture_BadgeGlyph;
				xamlMember.Setter = set_235_PersonPicture_BadgeGlyph;
			}
			break;
		case 1526051961u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.BadgeImageSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "BadgeImageSource", "Microsoft.UI.Xaml.Media.ImageSource");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_236_PersonPicture_BadgeImageSource;
				xamlMember.Setter = set_236_PersonPicture_BadgeImageSource;
			}
			break;
		case 2250570326u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.BadgeNumber")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "BadgeNumber", "Int32");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_237_PersonPicture_BadgeNumber;
				xamlMember.Setter = set_237_PersonPicture_BadgeNumber;
			}
			break;
		case 3643905968u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.BadgeText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "BadgeText", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_238_PersonPicture_BadgeText;
				xamlMember.Setter = set_238_PersonPicture_BadgeText;
			}
			break;
		case 88763616u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.Contact")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "Contact", "Windows.ApplicationModel.Contacts.Contact");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_239_PersonPicture_Contact;
				xamlMember.Setter = set_239_PersonPicture_Contact;
			}
			break;
		case 2437289737u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.DisplayName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "DisplayName", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_240_PersonPicture_DisplayName;
				xamlMember.Setter = set_240_PersonPicture_DisplayName;
			}
			break;
		case 903785u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.Initials")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "Initials", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_241_PersonPicture_Initials;
				xamlMember.Setter = set_241_PersonPicture_Initials;
			}
			break;
		case 1859481415u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.IsGroup")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "IsGroup", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_242_PersonPicture_IsGroup;
				xamlMember.Setter = set_242_PersonPicture_IsGroup;
			}
			break;
		case 250228982u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.PreferSmallImage")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "PreferSmallImage", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_243_PersonPicture_PreferSmallImage;
				xamlMember.Setter = set_243_PersonPicture_PreferSmallImage;
			}
			break;
		case 3571931325u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.ProfilePicture")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "ProfilePicture", "Microsoft.UI.Xaml.Media.ImageSource");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_244_PersonPicture_ProfilePicture;
				xamlMember.Setter = set_244_PersonPicture_ProfilePicture;
			}
			break;
		case 844986579u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.PersonPicture.TemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.PersonPicture");
				xamlMember = (XamlMember)new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.PersonPictureTemplateSettings");
				xamlMember.Getter = get_245_PersonPicture_TemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 418739583u:
			if (longMemberName == "Mahiro_Account.UI.Shell.PagerBar.PageSizeVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Shell.PagerBar");
				xamlMember = (XamlMember)new XamlMember(this, "PageSizeVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_246_PagerBar_PageSizeVisibility;
				xamlMember.Setter = set_246_PagerBar_PageSizeVisibility;
			}
			break;
		case 2137463259u:
			if (longMemberName == "Mahiro_Account.UI.Shell.PagerBar.PageSize")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Shell.PagerBar");
				xamlMember = (XamlMember)new XamlMember(this, "PageSize", "Int32");
				xamlMember.Getter = get_247_PagerBar_PageSize;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2426532458u:
			if (longMemberName == "Microsoft.UI.Xaml.Thickness.Left")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Thickness");
				xamlMember = (XamlMember)new XamlMember(this, "Left", "Double");
				xamlMember.Getter = get_248_Thickness_Left;
				xamlMember.Setter = set_248_Thickness_Left;
			}
			break;
		case 45992714u:
			if (longMemberName == "Microsoft.UI.Xaml.Thickness.Top")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Thickness");
				xamlMember = (XamlMember)new XamlMember(this, "Top", "Double");
				xamlMember.Getter = get_249_Thickness_Top;
				xamlMember.Setter = set_249_Thickness_Top;
			}
			break;
		case 1734187319u:
			if (longMemberName == "Microsoft.UI.Xaml.Thickness.Right")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Thickness");
				xamlMember = (XamlMember)new XamlMember(this, "Right", "Double");
				xamlMember.Getter = get_250_Thickness_Right;
				xamlMember.Setter = set_250_Thickness_Right;
			}
			break;
		case 1888988764u:
			if (longMemberName == "Microsoft.UI.Xaml.Thickness.Bottom")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Thickness");
				xamlMember = (XamlMember)new XamlMember(this, "Bottom", "Double");
				xamlMember.Getter = get_251_Thickness_Bottom;
				xamlMember.Setter = set_251_Thickness_Bottom;
			}
			break;
		case 3201829237u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.Content")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "Content", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_252_TitleBar_Content;
				xamlMember.Setter = set_252_TitleBar_Content;
			}
			break;
		case 2808292550u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.Title")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "Title", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_253_TitleBar_Title;
				xamlMember.Setter = set_253_TitleBar_Title;
			}
			break;
		case 825307439u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.IsBackButtonVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsBackButtonVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_254_TitleBar_IsBackButtonVisible;
				xamlMember.Setter = set_254_TitleBar_IsBackButtonVisible;
			}
			break;
		case 3617314104u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.IsPaneToggleButtonVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsPaneToggleButtonVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_255_TitleBar_IsPaneToggleButtonVisible;
				xamlMember.Setter = set_255_TitleBar_IsPaneToggleButtonVisible;
			}
			break;
		case 3071017388u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.IconSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "IconSource", "Microsoft.UI.Xaml.Controls.IconSource");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_256_TitleBar_IconSource;
				xamlMember.Setter = set_256_TitleBar_IconSource;
			}
			break;
		case 3255897707u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.RightHeader")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "RightHeader", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_257_TitleBar_RightHeader;
				xamlMember.Setter = set_257_TitleBar_RightHeader;
			}
			break;
		case 327297809u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.AutoRefreshDragRegions")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "AutoRefreshDragRegions", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_258_TitleBar_AutoRefreshDragRegions;
				xamlMember.Setter = set_258_TitleBar_AutoRefreshDragRegions;
			}
			break;
		case 2735568496u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.IsBackButtonEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsBackButtonEnabled", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_259_TitleBar_IsBackButtonEnabled;
				xamlMember.Setter = set_259_TitleBar_IsBackButtonEnabled;
			}
			break;
		case 3920113812u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.LeftHeader")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "LeftHeader", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_260_TitleBar_LeftHeader;
				xamlMember.Setter = set_260_TitleBar_LeftHeader;
			}
			break;
		case 1175975188u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.Subtitle")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "Subtitle", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_261_TitleBar_Subtitle;
				xamlMember.Setter = set_261_TitleBar_Subtitle;
			}
			break;
		case 1539426943u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.TemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.TitleBarTemplateSettings");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_262_TitleBar_TemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3598423638u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TitleBar.IsDragRegion")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TitleBar");
				xamlMember = (XamlMember)new XamlMember(this, "IsDragRegion", "System.Nullable`1<Boolean>");
				xamlMember.SetTargetTypeName("Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.SetIsAttachable();
				xamlMember.Getter = get_263_TitleBar_IsDragRegion;
				xamlMember.Setter = set_263_TitleBar_IsDragRegion;
			}
			break;
		case 543210355u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.CompactPaneLength")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "CompactPaneLength", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_264_NavigationView_CompactPaneLength;
				xamlMember.Setter = set_264_NavigationView_CompactPaneLength;
			}
			break;
		case 4041684431u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.IsBackButtonVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "IsBackButtonVisible", "Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_265_NavigationView_IsBackButtonVisible;
				xamlMember.Setter = set_265_NavigationView_IsBackButtonVisible;
			}
			break;
		case 4282132574u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.IsPaneOpen")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "IsPaneOpen", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_266_NavigationView_IsPaneOpen;
				xamlMember.Setter = set_266_NavigationView_IsPaneOpen;
			}
			break;
		case 2867465368u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.IsPaneToggleButtonVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "IsPaneToggleButtonVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_267_NavigationView_IsPaneToggleButtonVisible;
				xamlMember.Setter = set_267_NavigationView_IsPaneToggleButtonVisible;
			}
			break;
		case 906176961u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.IsSettingsVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "IsSettingsVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_268_NavigationView_IsSettingsVisible;
				xamlMember.Setter = set_268_NavigationView_IsSettingsVisible;
			}
			break;
		case 2325703578u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.OpenPaneLength")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "OpenPaneLength", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_269_NavigationView_OpenPaneLength;
				xamlMember.Setter = set_269_NavigationView_OpenPaneLength;
			}
			break;
		case 4144300567u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.PaneDisplayMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "PaneDisplayMode", "Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_270_NavigationView_PaneDisplayMode;
				xamlMember.Setter = set_270_NavigationView_PaneDisplayMode;
			}
			break;
		case 2119147417u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.MenuItems")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItems", "System.Collections.Generic.IList`1<Object>");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_271_NavigationView_MenuItems;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 27531377u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.PaneFooter")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "PaneFooter", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_272_NavigationView_PaneFooter;
				xamlMember.Setter = set_272_NavigationView_PaneFooter;
			}
			break;
		case 1291516849u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.AlwaysShowHeader")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "AlwaysShowHeader", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_273_NavigationView_AlwaysShowHeader;
				xamlMember.Setter = set_273_NavigationView_AlwaysShowHeader;
			}
			break;
		case 493736884u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.AutoSuggestBox")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "AutoSuggestBox", "Microsoft.UI.Xaml.Controls.AutoSuggestBox");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_274_NavigationView_AutoSuggestBox;
				xamlMember.Setter = set_274_NavigationView_AutoSuggestBox;
			}
			break;
		case 2932389335u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.CompactModeThresholdWidth")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "CompactModeThresholdWidth", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_275_NavigationView_CompactModeThresholdWidth;
				xamlMember.Setter = set_275_NavigationView_CompactModeThresholdWidth;
			}
			break;
		case 2955487475u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.ContentOverlay")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "ContentOverlay", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_276_NavigationView_ContentOverlay;
				xamlMember.Setter = set_276_NavigationView_ContentOverlay;
			}
			break;
		case 3834453989u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.DisplayMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "DisplayMode", "Microsoft.UI.Xaml.Controls.NavigationViewDisplayMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_277_NavigationView_DisplayMode;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1378552587u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.ExpandedModeThresholdWidth")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "ExpandedModeThresholdWidth", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_278_NavigationView_ExpandedModeThresholdWidth;
				xamlMember.Setter = set_278_NavigationView_ExpandedModeThresholdWidth;
			}
			break;
		case 651889544u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItems")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "FooterMenuItems", "System.Collections.Generic.IList`1<Object>");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_279_NavigationView_FooterMenuItems;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1183372925u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItemsSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "FooterMenuItemsSource", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_280_NavigationView_FooterMenuItemsSource;
				xamlMember.Setter = set_280_NavigationView_FooterMenuItemsSource;
			}
			break;
		case 1777848837u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.Header")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "Header", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_281_NavigationView_Header;
				xamlMember.Setter = set_281_NavigationView_Header;
			}
			break;
		case 2305741675u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.HeaderTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "HeaderTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_282_NavigationView_HeaderTemplate;
				xamlMember.Setter = set_282_NavigationView_HeaderTemplate;
			}
			break;
		case 630967736u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.IsBackEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "IsBackEnabled", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_283_NavigationView_IsBackEnabled;
				xamlMember.Setter = set_283_NavigationView_IsBackEnabled;
			}
			break;
		case 2185578160u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.IsPaneVisible")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "IsPaneVisible", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_284_NavigationView_IsPaneVisible;
				xamlMember.Setter = set_284_NavigationView_IsPaneVisible;
			}
			break;
		case 1686499194u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.IsTitleBarAutoPaddingEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "IsTitleBarAutoPaddingEnabled", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_285_NavigationView_IsTitleBarAutoPaddingEnabled;
				xamlMember.Setter = set_285_NavigationView_IsTitleBarAutoPaddingEnabled;
			}
			break;
		case 2448656264u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemContainerStyle")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItemContainerStyle", "Microsoft.UI.Xaml.Style");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_286_NavigationView_MenuItemContainerStyle;
				xamlMember.Setter = set_286_NavigationView_MenuItemContainerStyle;
			}
			break;
		case 663719229u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemContainerStyleSelector")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItemContainerStyleSelector", "Microsoft.UI.Xaml.Controls.StyleSelector");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_287_NavigationView_MenuItemContainerStyleSelector;
				xamlMember.Setter = set_287_NavigationView_MenuItemContainerStyleSelector;
			}
			break;
		case 1381728154u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItemTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_288_NavigationView_MenuItemTemplate;
				xamlMember.Setter = set_288_NavigationView_MenuItemTemplate;
			}
			break;
		case 154859455u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplateSelector")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItemTemplateSelector", "Microsoft.UI.Xaml.Controls.DataTemplateSelector");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_289_NavigationView_MenuItemTemplateSelector;
				xamlMember.Setter = set_289_NavigationView_MenuItemTemplateSelector;
			}
			break;
		case 152079940u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemsSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItemsSource", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_290_NavigationView_MenuItemsSource;
				xamlMember.Setter = set_290_NavigationView_MenuItemsSource;
			}
			break;
		case 1334072703u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.OverflowLabelMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "OverflowLabelMode", "Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_291_NavigationView_OverflowLabelMode;
				xamlMember.Setter = set_291_NavigationView_OverflowLabelMode;
			}
			break;
		case 3204973754u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.PaneCustomContent")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "PaneCustomContent", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_292_NavigationView_PaneCustomContent;
				xamlMember.Setter = set_292_NavigationView_PaneCustomContent;
			}
			break;
		case 3052121959u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.PaneHeader")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "PaneHeader", "Microsoft.UI.Xaml.UIElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_293_NavigationView_PaneHeader;
				xamlMember.Setter = set_293_NavigationView_PaneHeader;
			}
			break;
		case 3828389904u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.PaneTitle")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "PaneTitle", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_294_NavigationView_PaneTitle;
				xamlMember.Setter = set_294_NavigationView_PaneTitle;
			}
			break;
		case 2453488067u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.PaneToggleButtonStyle")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "PaneToggleButtonStyle", "Microsoft.UI.Xaml.Style");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_295_NavigationView_PaneToggleButtonStyle;
				xamlMember.Setter = set_295_NavigationView_PaneToggleButtonStyle;
			}
			break;
		case 2990299698u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.SelectedItem")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "SelectedItem", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_296_NavigationView_SelectedItem;
				xamlMember.Setter = set_296_NavigationView_SelectedItem;
			}
			break;
		case 317942816u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.SelectionFollowsFocus")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "SelectionFollowsFocus", "Microsoft.UI.Xaml.Controls.NavigationViewSelectionFollowsFocus");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_297_NavigationView_SelectionFollowsFocus;
				xamlMember.Setter = set_297_NavigationView_SelectionFollowsFocus;
			}
			break;
		case 1402932606u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.SettingsItem")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "SettingsItem", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_298_NavigationView_SettingsItem;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4261084583u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.ShoulderNavigationEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "ShoulderNavigationEnabled", "Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_299_NavigationView_ShoulderNavigationEnabled;
				xamlMember.Setter = set_299_NavigationView_ShoulderNavigationEnabled;
			}
			break;
		case 4037243039u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationView.TemplateSettings")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
				xamlMember = (XamlMember)new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_300_NavigationView_TemplateSettings;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 281114820u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.Icon")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "Icon", "Microsoft.UI.Xaml.Controls.IconElement");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_301_NavigationViewItem_Icon;
				xamlMember.Setter = set_301_NavigationViewItem_Icon;
			}
			break;
		case 1285533489u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.SelectsOnInvoked")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "SelectsOnInvoked", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_302_NavigationViewItem_SelectsOnInvoked;
				xamlMember.Setter = set_302_NavigationViewItem_SelectsOnInvoked;
			}
			break;
		case 1562720810u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.MenuItems")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItems", "System.Collections.Generic.IList`1<Object>");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_303_NavigationViewItem_MenuItems;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3306292232u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.CompactPaneLength")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "CompactPaneLength", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_304_NavigationViewItem_CompactPaneLength;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1608180777u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.HasUnrealizedChildren")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "HasUnrealizedChildren", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_305_NavigationViewItem_HasUnrealizedChildren;
				xamlMember.Setter = set_305_NavigationViewItem_HasUnrealizedChildren;
			}
			break;
		case 1546742436u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.InfoBadge")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "InfoBadge", "Microsoft.UI.Xaml.Controls.InfoBadge");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_306_NavigationViewItem_InfoBadge;
				xamlMember.Setter = set_306_NavigationViewItem_InfoBadge;
			}
			break;
		case 438315640u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.IsChildSelected")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "IsChildSelected", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_307_NavigationViewItem_IsChildSelected;
				xamlMember.Setter = set_307_NavigationViewItem_IsChildSelected;
			}
			break;
		case 3886420980u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.IsExpanded")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "IsExpanded", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_308_NavigationViewItem_IsExpanded;
				xamlMember.Setter = set_308_NavigationViewItem_IsExpanded;
			}
			break;
		case 1526303479u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItem.MenuItemsSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItem");
				xamlMember = (XamlMember)new XamlMember(this, "MenuItemsSource", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_309_NavigationViewItem_MenuItemsSource;
				xamlMember.Setter = set_309_NavigationViewItem_MenuItemsSource;
			}
			break;
		case 958709079u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NavigationViewItemBase.IsSelected")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationViewItemBase");
				xamlMember = (XamlMember)new XamlMember(this, "IsSelected", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_310_NavigationViewItemBase_IsSelected;
				xamlMember.Setter = set_310_NavigationViewItemBase_IsSelected;
			}
			break;
		case 499912756u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.ImageIconSource.ImageSource")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ImageIconSource");
				xamlMember = (XamlMember)new XamlMember(this, "ImageSource", "Microsoft.UI.Xaml.Media.ImageSource");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_311_ImageIconSource_ImageSource;
				xamlMember.Setter = set_311_ImageIconSource_ImageSource;
			}
			break;
		case 3510198972u:
			if (longMemberName == "Microsoft.UI.Xaml.CornerRadius.TopLeft")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.CornerRadius");
				xamlMember = (XamlMember)new XamlMember(this, "TopLeft", "Double");
				xamlMember.Getter = get_312_CornerRadius_TopLeft;
				xamlMember.Setter = set_312_CornerRadius_TopLeft;
			}
			break;
		case 10720649u:
			if (longMemberName == "Microsoft.UI.Xaml.CornerRadius.TopRight")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.CornerRadius");
				xamlMember = (XamlMember)new XamlMember(this, "TopRight", "Double");
				xamlMember.Getter = get_313_CornerRadius_TopRight;
				xamlMember.Setter = set_313_CornerRadius_TopRight;
			}
			break;
		case 3383376077u:
			if (longMemberName == "Microsoft.UI.Xaml.CornerRadius.BottomRight")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.CornerRadius");
				xamlMember = (XamlMember)new XamlMember(this, "BottomRight", "Double");
				xamlMember.Getter = get_314_CornerRadius_BottomRight;
				xamlMember.Setter = set_314_CornerRadius_BottomRight;
			}
			break;
		case 2477507192u:
			if (longMemberName == "Microsoft.UI.Xaml.CornerRadius.BottomLeft")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.CornerRadius");
				xamlMember = (XamlMember)new XamlMember(this, "BottomLeft", "Double");
				xamlMember.Getter = get_315_CornerRadius_BottomLeft;
				xamlMember.Setter = set_315_CornerRadius_BottomLeft;
			}
			break;
		case 1500080982u:
			if (longMemberName == "CommunityToolkit.WinUI.AttachedShadowBase.BlurRadius")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.AttachedShadowBase");
				xamlMember = (XamlMember)new XamlMember(this, "BlurRadius", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_316_AttachedShadowBase_BlurRadius;
				xamlMember.Setter = set_316_AttachedShadowBase_BlurRadius;
			}
			break;
		case 4149910261u:
			if (longMemberName == "CommunityToolkit.WinUI.Media.AttachedCardShadow.CornerRadius")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Media.AttachedCardShadow");
				xamlMember = (XamlMember)new XamlMember(this, "CornerRadius", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_317_AttachedCardShadow_CornerRadius;
				xamlMember.Setter = set_317_AttachedCardShadow_CornerRadius;
			}
			break;
		case 1099239470u:
			if (longMemberName == "CommunityToolkit.WinUI.AttachedShadowBase.Opacity")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.AttachedShadowBase");
				xamlMember = (XamlMember)new XamlMember(this, "Opacity", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_318_AttachedShadowBase_Opacity;
				xamlMember.Setter = set_318_AttachedShadowBase_Opacity;
			}
			break;
		case 2355654498u:
			if (longMemberName == "CommunityToolkit.WinUI.AttachedShadowBase.Offset")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.AttachedShadowBase");
				xamlMember = (XamlMember)new XamlMember(this, "Offset", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_319_AttachedShadowBase_Offset;
				xamlMember.Setter = set_319_AttachedShadowBase_Offset;
			}
			break;
		case 1913968742u:
			if (longMemberName == "CommunityToolkit.WinUI.Media.AttachedCardShadow.InnerContentClipMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Media.AttachedCardShadow");
				xamlMember = (XamlMember)new XamlMember(this, "InnerContentClipMode", "CommunityToolkit.WinUI.Media.InnerContentClipMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_320_AttachedCardShadow_InnerContentClipMode;
				xamlMember.Setter = set_320_AttachedCardShadow_InnerContentClipMode;
			}
			break;
		case 3996868864u:
			if (longMemberName == "CommunityToolkit.WinUI.AttachedShadowBase.Color")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.AttachedShadowBase");
				xamlMember = (XamlMember)new XamlMember(this, "Color", "Windows.UI.Color");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_321_AttachedShadowBase_Color;
				xamlMember.Setter = set_321_AttachedShadowBase_Color;
			}
			break;
		case 149745702u:
			if (longMemberName == "Windows.UI.Color.A")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Windows.UI.Color");
				xamlMember = (XamlMember)new XamlMember(this, "A", "Byte");
				xamlMember.Getter = get_322_Color_A;
				xamlMember.Setter = set_322_Color_A;
			}
			break;
		case 401409987u:
			if (longMemberName == "Windows.UI.Color.R")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Windows.UI.Color");
				xamlMember = (XamlMember)new XamlMember(this, "R", "Byte");
				xamlMember.Getter = get_323_Color_R;
				xamlMember.Setter = set_323_Color_R;
			}
			break;
		case 183300940u:
			if (longMemberName == "Windows.UI.Color.G")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Windows.UI.Color");
				xamlMember = (XamlMember)new XamlMember(this, "G", "Byte");
				xamlMember.Getter = get_324_Color_G;
				xamlMember.Setter = set_324_Color_G;
			}
			break;
		case 132968083u:
			if (longMemberName == "Windows.UI.Color.B")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Windows.UI.Color");
				xamlMember = (XamlMember)new XamlMember(this, "B", "Byte");
				xamlMember.Getter = get_325_Color_B;
				xamlMember.Setter = set_325_Color_B;
			}
			break;
		case 1175357624u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.Header")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "Header", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_326_NumberBox_Header;
				xamlMember.Setter = set_326_NumberBox_Header;
			}
			break;
		case 2145615369u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.Maximum")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "Maximum", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_327_NumberBox_Maximum;
				xamlMember.Setter = set_327_NumberBox_Maximum;
			}
			break;
		case 4024711247u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.Minimum")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "Minimum", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_328_NumberBox_Minimum;
				xamlMember.Setter = set_328_NumberBox_Minimum;
			}
			break;
		case 2935237508u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.SmallChange")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "SmallChange", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_329_NumberBox_SmallChange;
				xamlMember.Setter = set_329_NumberBox_SmallChange;
			}
			break;
		case 127970724u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.AcceptsExpression")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "AcceptsExpression", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_330_NumberBox_AcceptsExpression;
				xamlMember.Setter = set_330_NumberBox_AcceptsExpression;
			}
			break;
		case 2013402209u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.Description")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "Description", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_331_NumberBox_Description;
				xamlMember.Setter = set_331_NumberBox_Description;
			}
			break;
		case 2310844450u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.HeaderTemplate")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "HeaderTemplate", "Microsoft.UI.Xaml.DataTemplate");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_332_NumberBox_HeaderTemplate;
				xamlMember.Setter = set_332_NumberBox_HeaderTemplate;
			}
			break;
		case 3348682262u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.IsWrapEnabled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "IsWrapEnabled", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_333_NumberBox_IsWrapEnabled;
				xamlMember.Setter = set_333_NumberBox_IsWrapEnabled;
			}
			break;
		case 623375884u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.LargeChange")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "LargeChange", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_334_NumberBox_LargeChange;
				xamlMember.Setter = set_334_NumberBox_LargeChange;
			}
			break;
		case 1762017342u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.NumberFormatter")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "NumberFormatter", "Windows.Globalization.NumberFormatting.INumberFormatter2");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_335_NumberBox_NumberFormatter;
				xamlMember.Setter = set_335_NumberBox_NumberFormatter;
			}
			break;
		case 2278264953u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.PlaceholderText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "PlaceholderText", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_336_NumberBox_PlaceholderText;
				xamlMember.Setter = set_336_NumberBox_PlaceholderText;
			}
			break;
		case 4254294227u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.PreventKeyboardDisplayOnProgrammaticFocus")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "PreventKeyboardDisplayOnProgrammaticFocus", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_337_NumberBox_PreventKeyboardDisplayOnProgrammaticFocus;
				xamlMember.Setter = set_337_NumberBox_PreventKeyboardDisplayOnProgrammaticFocus;
			}
			break;
		case 2767799118u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.SelectionFlyout")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "SelectionFlyout", "Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_338_NumberBox_SelectionFlyout;
				xamlMember.Setter = set_338_NumberBox_SelectionFlyout;
			}
			break;
		case 2794486766u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.SelectionHighlightColor")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "SelectionHighlightColor", "Microsoft.UI.Xaml.Media.SolidColorBrush");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_339_NumberBox_SelectionHighlightColor;
				xamlMember.Setter = set_339_NumberBox_SelectionHighlightColor;
			}
			break;
		case 1191114499u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.SpinButtonPlacementMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "SpinButtonPlacementMode", "Microsoft.UI.Xaml.Controls.NumberBoxSpinButtonPlacementMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_340_NumberBox_SpinButtonPlacementMode;
				xamlMember.Setter = set_340_NumberBox_SpinButtonPlacementMode;
			}
			break;
		case 2251905718u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.Text")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "Text", "String");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_341_NumberBox_Text;
				xamlMember.Setter = set_341_NumberBox_Text;
			}
			break;
		case 1939870778u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.TextReadingOrder")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "TextReadingOrder", "Microsoft.UI.Xaml.TextReadingOrder");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_342_NumberBox_TextReadingOrder;
				xamlMember.Setter = set_342_NumberBox_TextReadingOrder;
			}
			break;
		case 1195866681u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.ValidationMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "ValidationMode", "Microsoft.UI.Xaml.Controls.NumberBoxValidationMode");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_343_NumberBox_ValidationMode;
				xamlMember.Setter = set_343_NumberBox_ValidationMode;
			}
			break;
		case 2372730002u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.NumberBox.Value")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NumberBox");
				xamlMember = (XamlMember)new XamlMember(this, "Value", "Double");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_344_NumberBox_Value;
				xamlMember.Setter = set_344_NumberBox_Value;
			}
			break;
		case 351323923u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Bedrock.BedrockOnlineLobbyPage.Rooms")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Bedrock.BedrockOnlineLobbyPage");
				xamlMember = (XamlMember)new XamlMember(this, "Rooms", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom>");
				xamlMember.Getter = get_345_BedrockOnlineLobbyPage_Rooms;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3328888591u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.RoomId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "RoomId", "String");
				xamlMember.Getter = get_346_BedrockOnlineLobbyRoom_RoomId;
				xamlMember.Setter = set_346_BedrockOnlineLobbyRoom_RoomId;
			}
			break;
		case 287408670u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_347_BedrockOnlineLobbyRoom_Name;
				xamlMember.Setter = set_347_BedrockOnlineLobbyRoom_Name;
			}
			break;
		case 2243396529u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.Description")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "Description", "String");
				xamlMember.Getter = get_348_BedrockOnlineLobbyRoom_Description;
				xamlMember.Setter = set_348_BedrockOnlineLobbyRoom_Description;
			}
			break;
		case 3574901320u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.ResourceId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "ResourceId", "String");
				xamlMember.Getter = get_349_BedrockOnlineLobbyRoom_ResourceId;
				xamlMember.Setter = set_349_BedrockOnlineLobbyRoom_ResourceId;
			}
			break;
		case 204999217u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.OwnerId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "OwnerId", "String");
				xamlMember.Getter = get_350_BedrockOnlineLobbyRoom_OwnerId;
				xamlMember.Setter = set_350_BedrockOnlineLobbyRoom_OwnerId;
			}
			break;
		case 2815186511u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.Version")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "Version", "String");
				xamlMember.Getter = get_351_BedrockOnlineLobbyRoom_Version;
				xamlMember.Setter = set_351_BedrockOnlineLobbyRoom_Version;
			}
			break;
		case 2800966935u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.PlayerCount")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "PlayerCount", "Int32");
				xamlMember.Getter = get_352_BedrockOnlineLobbyRoom_PlayerCount;
				xamlMember.Setter = set_352_BedrockOnlineLobbyRoom_PlayerCount;
			}
			break;
		case 1877028353u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.Capacity")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "Capacity", "Int32");
				xamlMember.Getter = get_353_BedrockOnlineLobbyRoom_Capacity;
				xamlMember.Setter = set_353_BedrockOnlineLobbyRoom_Capacity;
			}
			break;
		case 2327516122u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.HasPassword")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "HasPassword", "Boolean");
				xamlMember.Getter = get_354_BedrockOnlineLobbyRoom_HasPassword;
				xamlMember.Setter = set_354_BedrockOnlineLobbyRoom_HasPassword;
			}
			break;
		case 3222831775u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.PlayerText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "PlayerText", "String");
				xamlMember.Getter = get_355_BedrockOnlineLobbyRoom_PlayerText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2026039320u:
			if (longMemberName == "Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom.VersionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Bedrock.BedrockOnlineLobbyRoom");
				xamlMember = (XamlMember)new XamlMember(this, "VersionText", "String");
				xamlMember.Getter = get_356_BedrockOnlineLobbyRoom_VersionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3714746873u:
			if (longMemberName == "Mahiro_Account.Views.Pages.HomePage.HomeTimelineList")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.HomePage");
				xamlMember = (XamlMember)new XamlMember(this, "HomeTimelineList", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Views.Pages.TimelineEntry>");
				xamlMember.Getter = get_357_HomePage_HomeTimelineList;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 735931295u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineEntry.VersionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineEntry");
				xamlMember = (XamlMember)new XamlMember(this, "VersionText", "String");
				xamlMember.Getter = get_358_TimelineEntry_VersionText;
				xamlMember.Setter = set_358_TimelineEntry_VersionText;
			}
			break;
		case 4166745847u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineEntry.DateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineEntry");
				xamlMember = (XamlMember)new XamlMember(this, "DateText", "String");
				xamlMember.Getter = get_359_TimelineEntry_DateText;
				xamlMember.Setter = set_359_TimelineEntry_DateText;
			}
			break;
		case 3378434471u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineEntry.IsLatest")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineEntry");
				xamlMember = (XamlMember)new XamlMember(this, "IsLatest", "Boolean");
				xamlMember.Getter = get_360_TimelineEntry_IsLatest;
				xamlMember.Setter = set_360_TimelineEntry_IsLatest;
			}
			break;
		case 136697838u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineEntry.LatestBadgeVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineEntry");
				xamlMember = (XamlMember)new XamlMember(this, "LatestBadgeVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_361_TimelineEntry_LatestBadgeVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2816776409u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineEntry.Notes")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineEntry");
				xamlMember = (XamlMember)new XamlMember(this, "Notes", "System.Collections.Generic.List`1<Mahiro_Account.Views.Pages.TimelineNote>");
				xamlMember.Getter = get_362_TimelineEntry_Notes;
				xamlMember.Setter = set_362_TimelineEntry_Notes;
			}
			break;
		case 1641612415u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineNote.TagText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineNote");
				xamlMember = (XamlMember)new XamlMember(this, "TagText", "String");
				xamlMember.Getter = get_363_TimelineNote_TagText;
				xamlMember.Setter = set_363_TimelineNote_TagText;
			}
			break;
		case 3155027887u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineNote.TagColor")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineNote");
				xamlMember = (XamlMember)new XamlMember(this, "TagColor", "Microsoft.UI.Xaml.Media.Brush");
				xamlMember.Getter = get_364_TimelineNote_TagColor;
				xamlMember.Setter = set_364_TimelineNote_TagColor;
			}
			break;
		case 1267958924u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineNote.TagBackground")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineNote");
				xamlMember = (XamlMember)new XamlMember(this, "TagBackground", "Microsoft.UI.Xaml.Media.Brush");
				xamlMember.Getter = get_365_TimelineNote_TagBackground;
				xamlMember.Setter = set_365_TimelineNote_TagBackground;
			}
			break;
		case 3877768017u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineNote.IconGlyph")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineNote");
				xamlMember = (XamlMember)new XamlMember(this, "IconGlyph", "String");
				xamlMember.Getter = get_366_TimelineNote_IconGlyph;
				xamlMember.Setter = set_366_TimelineNote_IconGlyph;
			}
			break;
		case 2785640685u:
			if (longMemberName == "Mahiro_Account.Views.Pages.TimelineNote.Content")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.TimelineNote");
				xamlMember = (XamlMember)new XamlMember(this, "Content", "String");
				xamlMember.Getter = get_367_TimelineNote_Content;
				xamlMember.Setter = set_367_TimelineNote_Content;
			}
			break;
		case 2302010371u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Java.JavaCompatibilityInstancesPage.ManagedInstances")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Java.JavaCompatibilityInstancesPage");
				xamlMember = (XamlMember)new XamlMember(this, "ManagedInstances", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.JavaInstanceInfo>");
				xamlMember.Getter = get_368_JavaCompatibilityInstancesPage_ManagedInstances;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1376656913u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "String");
				xamlMember.Getter = get_369_JavaInstanceInfo_Id;
				xamlMember.Setter = set_369_JavaInstanceInfo_Id;
			}
			break;
		case 740704178u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ServerId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ServerId", "String");
				xamlMember.Getter = get_370_JavaInstanceInfo_ServerId;
				xamlMember.Setter = set_370_JavaInstanceInfo_ServerId;
			}
			break;
		case 1583160956u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ServerName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ServerName", "String");
				xamlMember.Getter = get_371_JavaInstanceInfo_ServerName;
				xamlMember.Setter = set_371_JavaInstanceInfo_ServerName;
			}
			break;
		case 3467786793u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.RoleId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RoleId", "String");
				xamlMember.Getter = get_372_JavaInstanceInfo_RoleId;
				xamlMember.Setter = set_372_JavaInstanceInfo_RoleId;
			}
			break;
		case 240545503u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.RoleName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RoleName", "String");
				xamlMember.Getter = get_373_JavaInstanceInfo_RoleName;
				xamlMember.Setter = set_373_JavaInstanceInfo_RoleName;
			}
			break;
		case 2464425232u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.Version")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "Version", "String");
				xamlMember.Getter = get_374_JavaInstanceInfo_Version;
				xamlMember.Setter = set_374_JavaInstanceInfo_Version;
			}
			break;
		case 1582442298u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ExecutorPath")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ExecutorPath", "String");
				xamlMember.Getter = get_375_JavaInstanceInfo_ExecutorPath;
				xamlMember.Setter = set_375_JavaInstanceInfo_ExecutorPath;
			}
			break;
		case 2979218926u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.WorkingDirectory")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "WorkingDirectory", "String");
				xamlMember.Getter = get_376_JavaInstanceInfo_WorkingDirectory;
				xamlMember.Setter = set_376_JavaInstanceInfo_WorkingDirectory;
			}
			break;
		case 3895623140u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ProcessId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ProcessId", "Int32");
				xamlMember.Getter = get_377_JavaInstanceInfo_ProcessId;
				xamlMember.Setter = set_377_JavaInstanceInfo_ProcessId;
			}
			break;
		case 1042889836u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.StartedAt")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "StartedAt", "System.DateTimeOffset");
				xamlMember.Getter = get_378_JavaInstanceInfo_StartedAt;
				xamlMember.Setter = set_378_JavaInstanceInfo_StartedAt;
			}
			break;
		case 4017243137u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.State")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "State", "Mahiro_Account.Models.Java.JavaInstanceState");
				xamlMember.Getter = get_379_JavaInstanceInfo_State;
				xamlMember.Setter = set_379_JavaInstanceInfo_State;
			}
			break;
		case 63691465u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ExitCode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ExitCode", "System.Nullable`1<Int32>");
				xamlMember.Getter = get_380_JavaInstanceInfo_ExitCode;
				xamlMember.Setter = set_380_JavaInstanceInfo_ExitCode;
			}
			break;
		case 2014591109u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.AuthPort")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "AuthPort", "Int32");
				xamlMember.Getter = get_381_JavaInstanceInfo_AuthPort;
				xamlMember.Setter = set_381_JavaInstanceInfo_AuthPort;
			}
			break;
		case 1666898224u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.RpcPort")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RpcPort", "Int32");
				xamlMember.Getter = get_382_JavaInstanceInfo_RpcPort;
				xamlMember.Setter = set_382_JavaInstanceInfo_RpcPort;
			}
			break;
		case 1537601708u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.RecentLogs")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RecentLogs", "System.Collections.Generic.IReadOnlyList`1<String>");
				xamlMember.Getter = get_383_JavaInstanceInfo_RecentLogs;
				xamlMember.Setter = set_383_JavaInstanceInfo_RecentLogs;
			}
			break;
		case 1505089213u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ServerImageUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ServerImageUrl", "String");
				xamlMember.Getter = get_384_JavaInstanceInfo_ServerImageUrl;
				xamlMember.Setter = set_384_JavaInstanceInfo_ServerImageUrl;
			}
			break;
		case 262812057u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.CrashReport")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "CrashReport", "Mahiro_Account.Models.Java.JavaCrashReport");
				xamlMember.Getter = get_385_JavaInstanceInfo_CrashReport;
				xamlMember.Setter = set_385_JavaInstanceInfo_CrashReport;
			}
			break;
		case 76448147u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.IsRunning")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "IsRunning", "Boolean");
				xamlMember.Getter = get_386_JavaInstanceInfo_IsRunning;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1325511414u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.CanStop")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "CanStop", "Boolean");
				xamlMember.Getter = get_387_JavaInstanceInfo_CanStop;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2367003457u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.CanRestart")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "CanRestart", "Boolean");
				xamlMember.Getter = get_388_JavaInstanceInfo_CanRestart;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3312092597u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.StatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "StatusText", "String");
				xamlMember.Getter = get_389_JavaInstanceInfo_StatusText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1638171098u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ExecutorName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ExecutorName", "String");
				xamlMember.Getter = get_390_JavaInstanceInfo_ExecutorName;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3220164371u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.ProcessIdText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ProcessIdText", "String");
				xamlMember.Getter = get_391_JavaInstanceInfo_ProcessIdText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2478954891u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.StartedAtText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "StartedAtText", "String");
				xamlMember.Getter = get_392_JavaInstanceInfo_StartedAtText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 764404144u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.PortText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "PortText", "String");
				xamlMember.Getter = get_393_JavaInstanceInfo_PortText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 48294032u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.RecentLogText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RecentLogText", "String");
				xamlMember.Getter = get_394_JavaInstanceInfo_RecentLogText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3044949433u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.HasCrashReport")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "HasCrashReport", "Boolean");
				xamlMember.Getter = get_395_JavaInstanceInfo_HasCrashReport;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4195617667u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.HasRawCrashArtifact")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "HasRawCrashArtifact", "Boolean");
				xamlMember.Getter = get_396_JavaInstanceInfo_HasRawCrashArtifact;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 840603954u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.CrashSummaryText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "CrashSummaryText", "String");
				xamlMember.Getter = get_397_JavaInstanceInfo_CrashSummaryText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1351188299u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.CrashFindingText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "CrashFindingText", "String");
				xamlMember.Getter = get_398_JavaInstanceInfo_CrashFindingText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3857129113u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.CrashArtifactPathText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "CrashArtifactPathText", "String");
				xamlMember.Getter = get_399_JavaInstanceInfo_CrashArtifactPathText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1491713420u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.PrimaryCrashArtifactPath")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "PrimaryCrashArtifactPath", "String");
				xamlMember.Getter = get_400_JavaInstanceInfo_PrimaryCrashArtifactPath;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1467931478u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.InstanceKindText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "InstanceKindText", "String");
				xamlMember.Getter = get_401_JavaInstanceInfo_InstanceKindText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 333143670u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaInstanceInfo.DetailText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaInstanceInfo");
				xamlMember = (XamlMember)new XamlMember(this, "DetailText", "String");
				xamlMember.Getter = get_402_JavaInstanceInfo_DetailText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2789866140u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Java.JavaCompatibilityInstancesPage.ProxyInstances")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Java.JavaCompatibilityInstancesPage");
				xamlMember = (XamlMember)new XamlMember(this, "ProxyInstances", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot>");
				xamlMember.Getter = get_403_JavaCompatibilityInstancesPage_ProxyInstances;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 652377105u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "String");
				xamlMember.Getter = get_404_JavaProxyInstanceSnapshot_Id;
				xamlMember.Setter = set_404_JavaProxyInstanceSnapshot_Id;
			}
			break;
		case 996396545u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.State")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "State", "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceState");
				xamlMember.Getter = get_405_JavaProxyInstanceSnapshot_State;
				xamlMember.Setter = set_405_JavaProxyInstanceSnapshot_State;
			}
			break;
		case 629287050u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.LocalEndpoint")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "LocalEndpoint", "Mahiro_Account.Models.Java.Proxy.JavaProxyEndpoint");
				xamlMember.Getter = get_406_JavaProxyInstanceSnapshot_LocalEndpoint;
				xamlMember.Setter = set_406_JavaProxyInstanceSnapshot_LocalEndpoint;
			}
			break;
		case 3938759615u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.RemoteEndpoint")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "RemoteEndpoint", "Mahiro_Account.Models.Java.Proxy.JavaProxyEndpoint");
				xamlMember.Getter = get_407_JavaProxyInstanceSnapshot_RemoteEndpoint;
				xamlMember.Setter = set_407_JavaProxyInstanceSnapshot_RemoteEndpoint;
			}
			break;
		case 2717020212u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.ProtocolVersion")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "ProtocolVersion", "Int32");
				xamlMember.Getter = get_408_JavaProxyInstanceSnapshot_ProtocolVersion;
				xamlMember.Setter = set_408_JavaProxyInstanceSnapshot_ProtocolVersion;
			}
			break;
		case 2608213499u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.ActiveConnections")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "ActiveConnections", "Int32");
				xamlMember.Getter = get_409_JavaProxyInstanceSnapshot_ActiveConnections;
				xamlMember.Setter = set_409_JavaProxyInstanceSnapshot_ActiveConnections;
			}
			break;
		case 616659029u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.Traffic")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "Traffic", "Mahiro_Account.Models.Java.Proxy.JavaProxyTrafficSnapshot");
				xamlMember.Getter = get_410_JavaProxyInstanceSnapshot_Traffic;
				xamlMember.Setter = set_410_JavaProxyInstanceSnapshot_Traffic;
			}
			break;
		case 3995215074u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.LastDisconnectReason")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "LastDisconnectReason", "Mahiro_Account.Models.Java.Proxy.JavaProxyDisconnectReason");
				xamlMember.Getter = get_411_JavaProxyInstanceSnapshot_LastDisconnectReason;
				xamlMember.Setter = set_411_JavaProxyInstanceSnapshot_LastDisconnectReason;
			}
			break;
		case 1545718087u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.LastDisconnectDetail")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "LastDisconnectDetail", "String");
				xamlMember.Getter = get_412_JavaProxyInstanceSnapshot_LastDisconnectDetail;
				xamlMember.Setter = set_412_JavaProxyInstanceSnapshot_LastDisconnectDetail;
			}
			break;
		case 1915315820u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.StartedAt")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "StartedAt", "System.DateTimeOffset");
				xamlMember.Getter = get_413_JavaProxyInstanceSnapshot_StartedAt;
				xamlMember.Setter = set_413_JavaProxyInstanceSnapshot_StartedAt;
			}
			break;
		case 4238768062u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.AccountId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "AccountId", "String");
				xamlMember.Getter = get_414_JavaProxyInstanceSnapshot_AccountId;
				xamlMember.Setter = set_414_JavaProxyInstanceSnapshot_AccountId;
			}
			break;
		case 1265085874u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.ServerId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "ServerId", "String");
				xamlMember.Getter = get_415_JavaProxyInstanceSnapshot_ServerId;
				xamlMember.Setter = set_415_JavaProxyInstanceSnapshot_ServerId;
			}
			break;
		case 983514236u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.ServerName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "ServerName", "String");
				xamlMember.Getter = get_416_JavaProxyInstanceSnapshot_ServerName;
				xamlMember.Setter = set_416_JavaProxyInstanceSnapshot_ServerName;
			}
			break;
		case 1542354985u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.RoleId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "RoleId", "String");
				xamlMember.Getter = get_417_JavaProxyInstanceSnapshot_RoleId;
				xamlMember.Setter = set_417_JavaProxyInstanceSnapshot_RoleId;
			}
			break;
		case 764927199u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.RoleName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "RoleName", "String");
				xamlMember.Getter = get_418_JavaProxyInstanceSnapshot_RoleName;
				xamlMember.Setter = set_418_JavaProxyInstanceSnapshot_RoleName;
			}
			break;
		case 1459817139u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.VersionName")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "VersionName", "String");
				xamlMember.Getter = get_419_JavaProxyInstanceSnapshot_VersionName;
				xamlMember.Setter = set_419_JavaProxyInstanceSnapshot_VersionName;
			}
			break;
		case 69162692u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.AccountDisplayText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "AccountDisplayText", "String");
				xamlMember.Getter = get_420_JavaProxyInstanceSnapshot_AccountDisplayText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 129003982u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.LocalAddressText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "LocalAddressText", "String");
				xamlMember.Getter = get_421_JavaProxyInstanceSnapshot_LocalAddressText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1969137298u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.StateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "StateText", "String");
				xamlMember.Getter = get_422_JavaProxyInstanceSnapshot_StateText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4151892220u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.ServerRoleText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "ServerRoleText", "String");
				xamlMember.Getter = get_423_JavaProxyInstanceSnapshot_ServerRoleText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1243259787u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.StartedAtText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "StartedAtText", "String");
				xamlMember.Getter = get_424_JavaProxyInstanceSnapshot_StartedAtText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 212900430u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.TrafficText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "TrafficText", "String");
				xamlMember.Getter = get_425_JavaProxyInstanceSnapshot_TrafficText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3427796805u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.DisconnectText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "DisconnectText", "String");
				xamlMember.Getter = get_426_JavaProxyInstanceSnapshot_DisconnectText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2765573366u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.CanStop")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "CanStop", "Boolean");
				xamlMember.Getter = get_427_JavaProxyInstanceSnapshot_CanStop;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2794446340u:
			if (longMemberName == "Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot.CanRetry")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.Proxy.JavaProxyInstanceSnapshot");
				xamlMember = (XamlMember)new XamlMember(this, "CanRetry", "Boolean");
				xamlMember.Getter = get_428_JavaProxyInstanceSnapshot_CanRetry;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2230053562u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Java.JavaServersPage.Servers")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Java.JavaServersPage");
				xamlMember = (XamlMember)new XamlMember(this, "Servers", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.JavaServer>");
				xamlMember.Getter = get_429_JavaServersPage_Servers;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1332776393u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "String");
				xamlMember.Getter = get_430_JavaServer_Id;
				xamlMember.Setter = set_430_JavaServer_Id;
			}
			break;
		case 3314313991u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.DetailEntityId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "DetailEntityId", "String");
				xamlMember.Getter = get_431_JavaServer_DetailEntityId;
				xamlMember.Setter = set_431_JavaServer_DetailEntityId;
			}
			break;
		case 2503312593u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.CatalogItemId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "CatalogItemId", "String");
				xamlMember.Getter = get_432_JavaServer_CatalogItemId;
				xamlMember.Setter = set_432_JavaServer_CatalogItemId;
			}
			break;
		case 201703701u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.ServerAddress")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "ServerAddress", "String");
				xamlMember.Getter = get_433_JavaServer_ServerAddress;
				xamlMember.Setter = set_433_JavaServer_ServerAddress;
			}
			break;
		case 2838677120u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.ServerPort")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "ServerPort", "Int32");
				xamlMember.Getter = get_434_JavaServer_ServerPort;
				xamlMember.Setter = set_434_JavaServer_ServerPort;
			}
			break;
		case 496425599u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_435_JavaServer_Name;
				xamlMember.Setter = set_435_JavaServer_Name;
			}
			break;
		case 3532161484u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.Summary")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "Summary", "String");
				xamlMember.Getter = get_436_JavaServer_Summary;
				xamlMember.Setter = set_436_JavaServer_Summary;
			}
			break;
		case 2348189006u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.Description")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "Description", "String");
				xamlMember.Getter = get_437_JavaServer_Description;
				xamlMember.Setter = set_437_JavaServer_Description;
			}
			break;
		case 183321190u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.OnlineCount")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "OnlineCount", "String");
				xamlMember.Getter = get_438_JavaServer_OnlineCount;
				xamlMember.Setter = set_438_JavaServer_OnlineCount;
			}
			break;
		case 335411664u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.MaximumPlayers")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "MaximumPlayers", "String");
				xamlMember.Getter = get_439_JavaServer_MaximumPlayers;
				xamlMember.Setter = set_439_JavaServer_MaximumPlayers;
			}
			break;
		case 3046975682u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.ImageUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "ImageUrl", "String");
				xamlMember.Getter = get_440_JavaServer_ImageUrl;
				xamlMember.Setter = set_440_JavaServer_ImageUrl;
			}
			break;
		case 3199283551u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.Author")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "Author", "String");
				xamlMember.Getter = get_441_JavaServer_Author;
				xamlMember.Setter = set_441_JavaServer_Author;
			}
			break;
		case 3875088081u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.Versions")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "Versions", "System.Collections.Generic.IReadOnlyList`1<Mahiro_Account.Models.Java.JavaMinecraftVersion>");
				xamlMember.Getter = get_442_JavaServer_Versions;
				xamlMember.Setter = set_442_JavaServer_Versions;
			}
			break;
		case 2827264424u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.OnlineText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "OnlineText", "String");
				xamlMember.Getter = get_443_JavaServer_OnlineText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2114986047u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.VersionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "VersionText", "String");
				xamlMember.Getter = get_444_JavaServer_VersionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3385013760u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaServer.OnlineDisplayText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaServer");
				xamlMember = (XamlMember)new XamlMember(this, "OnlineDisplayText", "String");
				xamlMember.Getter = get_445_JavaServer_OnlineDisplayText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 158354890u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Java.JavaSkinsPage.Skins")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Java.JavaSkinsPage");
				xamlMember = (XamlMember)new XamlMember(this, "Skins", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel>");
				xamlMember.Getter = get_446_JavaSkinsPage_Skins;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1497287465u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.Skin")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Skin", "Mahiro_Account.Models.Java.JavaSkin");
				xamlMember.Getter = get_447_JavaSkinCardViewModel_Skin;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3618724163u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.Name")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Name", "String");
				xamlMember.Getter = get_448_JavaSkinCardViewModel_Name;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3141391682u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.Developer")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Developer", "String");
				xamlMember.Getter = get_449_JavaSkinCardViewModel_Developer;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2830563800u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.Summary")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "Summary", "String");
				xamlMember.Getter = get_450_JavaSkinCardViewModel_Summary;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1066318780u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.CoverUrl")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "CoverUrl", "String");
				xamlMember.Getter = get_451_JavaSkinCardViewModel_CoverUrl;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 918854990u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.MetricsText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "MetricsText", "String");
				xamlMember.Getter = get_452_JavaSkinCardViewModel_MetricsText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4149667382u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.OwnershipText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "OwnershipText", "String");
				xamlMember.Getter = get_453_JavaSkinCardViewModel_OwnershipText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2610848877u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.IsApplied")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "IsApplied", "Boolean");
				xamlMember.Getter = get_454_JavaSkinCardViewModel_IsApplied;
				xamlMember.Setter = set_454_JavaSkinCardViewModel_IsApplied;
			}
			break;
		case 2731906677u:
			if (longMemberName == "Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel.AppliedVisibility")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Controls.Java.JavaSkinCardViewModel");
				xamlMember = (XamlMember)new XamlMember(this, "AppliedVisibility", "Microsoft.UI.Xaml.Visibility");
				xamlMember.Getter = get_455_JavaSkinCardViewModel_AppliedVisibility;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2048538160u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Java.JavaVersionManagementPage.Installations")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Java.JavaVersionManagementPage");
				xamlMember = (XamlMember)new XamlMember(this, "Installations", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Java.JavaVersionInstallationInfo>");
				xamlMember.Getter = get_456_JavaVersionManagementPage_Installations;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1399910385u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.Version")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "Version", "Mahiro_Account.Models.Java.JavaMinecraftVersion");
				xamlMember.Getter = get_457_JavaVersionInstallationInfo_Version;
				xamlMember.Setter = set_457_JavaVersionInstallationInfo_Version;
			}
			break;
		case 1096590978u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.ClientInstalled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ClientInstalled", "Boolean");
				xamlMember.Getter = get_458_JavaVersionInstallationInfo_ClientInstalled;
				xamlMember.Setter = set_458_JavaVersionInstallationInfo_ClientInstalled;
			}
			break;
		case 1863332385u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.Runtime")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "Runtime", "Mahiro_Account.Models.Java.JavaRuntimeProfile");
				xamlMember.Getter = get_459_JavaVersionInstallationInfo_Runtime;
				xamlMember.Setter = set_459_JavaVersionInstallationInfo_Runtime;
			}
			break;
		case 2204746213u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.RuntimeInstalled")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RuntimeInstalled", "Boolean");
				xamlMember.Getter = get_460_JavaVersionInstallationInfo_RuntimeInstalled;
				xamlMember.Setter = set_460_JavaVersionInstallationInfo_RuntimeInstalled;
			}
			break;
		case 1622212784u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.InstallationPath")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "InstallationPath", "String");
				xamlMember.Getter = get_461_JavaVersionInstallationInfo_InstallationPath;
				xamlMember.Setter = set_461_JavaVersionInstallationInfo_InstallationPath;
			}
			break;
		case 2649998682u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.IsReady")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "IsReady", "Boolean");
				xamlMember.Getter = get_462_JavaVersionInstallationInfo_IsReady;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 578461722u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.StatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "StatusText", "String");
				xamlMember.Getter = get_463_JavaVersionInstallationInfo_StatusText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1980085390u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.ClientStateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ClientStateText", "String");
				xamlMember.Getter = get_464_JavaVersionInstallationInfo_ClientStateText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3404516761u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.RuntimeStateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RuntimeStateText", "String");
				xamlMember.Getter = get_465_JavaVersionInstallationInfo_RuntimeStateText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 967881230u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.ActionText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "ActionText", "String");
				xamlMember.Getter = get_466_JavaVersionInstallationInfo_ActionText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4257546866u:
			if (longMemberName == "Mahiro_Account.Models.Java.JavaVersionInstallationInfo.RuntimeText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Java.JavaVersionInstallationInfo");
				xamlMember = (XamlMember)new XamlMember(this, "RuntimeText", "String");
				xamlMember.Getter = get_467_JavaVersionInstallationInfo_RuntimeText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2948515739u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Pay4399Page.GeneratedAccountHistory")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Pay4399Page");
				xamlMember = (XamlMember)new XamlMember(this, "GeneratedAccountHistory", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Pay4399AccountRecord>");
				xamlMember.Getter = get_468_Pay4399Page_GeneratedAccountHistory;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1959713175u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "Int64");
				xamlMember.Getter = get_469_Pay4399AccountRecord_Id;
				xamlMember.Setter = set_469_Pay4399AccountRecord_Id;
			}
			break;
		case 501355038u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.Username")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Username", "String");
				xamlMember.Getter = get_470_Pay4399AccountRecord_Username;
				xamlMember.Setter = set_470_Pay4399AccountRecord_Username;
			}
			break;
		case 1677124855u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.Password")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Password", "String");
				xamlMember.Getter = get_471_Pay4399AccountRecord_Password;
				xamlMember.Setter = set_471_Pay4399AccountRecord_Password;
			}
			break;
		case 993970707u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.SauthJson")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "SauthJson", "String");
				xamlMember.Getter = get_472_Pay4399AccountRecord_SauthJson;
				xamlMember.Setter = set_472_Pay4399AccountRecord_SauthJson;
			}
			break;
		case 3150405799u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.Source")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Source", "String");
				xamlMember.Getter = get_473_Pay4399AccountRecord_Source;
				xamlMember.Setter = set_473_Pay4399AccountRecord_Source;
			}
			break;
		case 1255047227u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.CreatedAt")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "CreatedAt", "System.DateTimeOffset");
				xamlMember.Getter = get_474_Pay4399AccountRecord_CreatedAt;
				xamlMember.Setter = set_474_Pay4399AccountRecord_CreatedAt;
			}
			break;
		case 3618948792u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.UpdatedAt")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "UpdatedAt", "System.DateTimeOffset");
				xamlMember.Getter = get_475_Pay4399AccountRecord_UpdatedAt;
				xamlMember.Setter = set_475_Pay4399AccountRecord_UpdatedAt;
			}
			break;
		case 2493261741u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.HasSauth")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "HasSauth", "Boolean");
				xamlMember.Getter = get_476_Pay4399AccountRecord_HasSauth;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4113354269u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.UsernameText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "UsernameText", "String");
				xamlMember.Getter = get_477_Pay4399AccountRecord_UsernameText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2971689200u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.PasswordText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "PasswordText", "String");
				xamlMember.Getter = get_478_Pay4399AccountRecord_PasswordText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2109959822u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.AccountText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "AccountText", "String");
				xamlMember.Getter = get_479_Pay4399AccountRecord_AccountText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3717861141u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.SauthStateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "SauthStateText", "String");
				xamlMember.Getter = get_480_Pay4399AccountRecord_SauthStateText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1396574016u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.SourceText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "SourceText", "String");
				xamlMember.Getter = get_481_Pay4399AccountRecord_SourceText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3106728611u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399AccountRecord.SavedAtText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "SavedAtText", "String");
				xamlMember.Getter = get_482_Pay4399AccountRecord_SavedAtText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1444974529u:
			if (longMemberName == "Mahiro_Account.Views.Pages.Pay4399Page.PendingAccountHistory")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.Pay4399Page");
				xamlMember = (XamlMember)new XamlMember(this, "PendingAccountHistory", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.Pay4399PendingAccountRecord>");
				xamlMember.Getter = get_483_Pay4399Page_PendingAccountHistory;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1806700148u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.CredentialHash")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "CredentialHash", "String");
				xamlMember.Getter = get_484_Pay4399PendingAccountRecord_CredentialHash;
				xamlMember.Setter = set_484_Pay4399PendingAccountRecord_CredentialHash;
			}
			break;
		case 3381819208u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.Channel")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Channel", "String");
				xamlMember.Getter = get_485_Pay4399PendingAccountRecord_Channel;
				xamlMember.Setter = set_485_Pay4399PendingAccountRecord_Channel;
			}
			break;
		case 3520709615u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.OperationId")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "OperationId", "String");
				xamlMember.Getter = get_486_Pay4399PendingAccountRecord_OperationId;
				xamlMember.Setter = set_486_Pay4399PendingAccountRecord_OperationId;
			}
			break;
		case 3742966051u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.Status")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Status", "String");
				xamlMember.Getter = get_487_Pay4399PendingAccountRecord_Status;
				xamlMember.Setter = set_487_Pay4399PendingAccountRecord_Status;
			}
			break;
		case 33998018u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.ExpectedPrice")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "ExpectedPrice", "System.Decimal");
				xamlMember.Getter = get_488_Pay4399PendingAccountRecord_ExpectedPrice;
				xamlMember.Setter = set_488_Pay4399PendingAccountRecord_ExpectedPrice;
			}
			break;
		case 3173258840u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.Message")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Message", "String");
				xamlMember.Getter = get_489_Pay4399PendingAccountRecord_Message;
				xamlMember.Setter = set_489_Pay4399PendingAccountRecord_Message;
			}
			break;
		case 1867251354u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.CreatedAt")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "CreatedAt", "System.DateTimeOffset");
				xamlMember.Getter = get_490_Pay4399PendingAccountRecord_CreatedAt;
				xamlMember.Setter = set_490_Pay4399PendingAccountRecord_CreatedAt;
			}
			break;
		case 4259171236u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.StatusText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "StatusText", "String");
				xamlMember.Getter = get_491_Pay4399PendingAccountRecord_StatusText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2611610033u:
			if (longMemberName == "Mahiro_Account.Models.Pay4399PendingAccountRecord.CreatedAtText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.Pay4399PendingAccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "CreatedAtText", "String");
				xamlMember.Getter = get_492_Pay4399PendingAccountRecord_CreatedAtText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3458480378u:
			if (longMemberName == "Mahiro_Account.UI.Motion.Lift")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.UI.Motion");
				xamlMember = (XamlMember)new XamlMember(this, "Lift", "Boolean");
				xamlMember.SetTargetTypeName("Microsoft.UI.Xaml.DependencyObject");
				xamlMember.SetIsAttachable();
				xamlMember.Getter = get_493_Motion_Lift;
				xamlMember.Setter = set_493_Motion_Lift;
			}
			break;
		case 3513725016u:
			if (longMemberName == "CommunityToolkit.WinUI.Effects.Shadow")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("CommunityToolkit.WinUI.Effects");
				xamlMember = (XamlMember)new XamlMember(this, "Shadow", "CommunityToolkit.WinUI.AttachedShadowBase");
				xamlMember.SetTargetTypeName("Microsoft.UI.Xaml.FrameworkElement");
				xamlMember.SetIsAttachable();
				xamlMember.Getter = get_494_Effects_Shadow;
				xamlMember.Setter = set_494_Effects_Shadow;
			}
			break;
		case 3824145094u:
			if (longMemberName == "Mahiro_Account.Views.Pages.ToolboxPage.AccountSwitchInstances")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.ToolboxPage");
				xamlMember = (XamlMember)new XamlMember(this, "AccountSwitchInstances", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.UI.Controls.Bedrock.BedrockInstanceCardViewModel>");
				xamlMember.Getter = get_495_ToolboxPage_AccountSwitchInstances;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3599869471u:
			if (longMemberName == "Mahiro_Account.Views.Pages.X19LoginPage.GeneratedAccountHistory")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Views.Pages.X19LoginPage");
				xamlMember = (XamlMember)new XamlMember(this, "GeneratedAccountHistory", "System.Collections.ObjectModel.ObservableCollection`1<Mahiro_Account.Models.X19AccountRecord>");
				xamlMember.Getter = get_496_X19LoginPage_GeneratedAccountHistory;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 921854400u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.Id")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Id", "Int64");
				xamlMember.Getter = get_497_X19AccountRecord_Id;
				xamlMember.Setter = set_497_X19AccountRecord_Id;
			}
			break;
		case 3598543292u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.Account")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Account", "String");
				xamlMember.Getter = get_498_X19AccountRecord_Account;
				xamlMember.Setter = set_498_X19AccountRecord_Account;
			}
			break;
		case 2545463544u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.Password")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "Password", "String");
				xamlMember.Getter = get_499_X19AccountRecord_Password;
				xamlMember.Setter = set_499_X19AccountRecord_Password;
			}
			break;
		case 704526346u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.SauthJson")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "SauthJson", "String");
				xamlMember.Getter = get_500_X19AccountRecord_SauthJson;
				xamlMember.Setter = set_500_X19AccountRecord_SauthJson;
			}
			break;
		case 3941394009u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.LoginMode")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "LoginMode", "String");
				xamlMember.Getter = get_501_X19AccountRecord_LoginMode;
				xamlMember.Setter = set_501_X19AccountRecord_LoginMode;
			}
			break;
		case 3500274478u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.CreatedAt")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "CreatedAt", "System.DateTimeOffset");
				xamlMember.Getter = get_502_X19AccountRecord_CreatedAt;
				xamlMember.Setter = set_502_X19AccountRecord_CreatedAt;
			}
			break;
		case 3846951253u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.UpdatedAt")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "UpdatedAt", "System.DateTimeOffset");
				xamlMember.Getter = get_503_X19AccountRecord_UpdatedAt;
				xamlMember.Setter = set_503_X19AccountRecord_UpdatedAt;
			}
			break;
		case 166042334u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.HasSauth")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "HasSauth", "Boolean");
				xamlMember.Getter = get_504_X19AccountRecord_HasSauth;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 563020009u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.AccountDisplayText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "AccountDisplayText", "String");
				xamlMember.Getter = get_505_X19AccountRecord_AccountDisplayText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1202147155u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.CopyText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "CopyText", "String");
				xamlMember.Getter = get_506_X19AccountRecord_CopyText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 2968976278u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.SauthStateText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "SauthStateText", "String");
				xamlMember.Getter = get_507_X19AccountRecord_SauthStateText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1932272954u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.LoginModeText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "LoginModeText", "String");
				xamlMember.Getter = get_508_X19AccountRecord_LoginModeText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 1872011842u:
			if (longMemberName == "Mahiro_Account.Models.X19AccountRecord.SavedAtText")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Mahiro_Account.Models.X19AccountRecord");
				xamlMember = (XamlMember)new XamlMember(this, "SavedAtText", "String");
				xamlMember.Getter = get_509_X19AccountRecord_SavedAtText;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 408793825u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TreeViewNode.Children")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember = (XamlMember)new XamlMember(this, "Children", "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.TreeViewNode>");
				xamlMember.Getter = get_510_TreeViewNode_Children;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4086418391u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TreeViewNode.Content")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember = (XamlMember)new XamlMember(this, "Content", "Object");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_511_TreeViewNode_Content;
				xamlMember.Setter = set_511_TreeViewNode_Content;
			}
			break;
		case 421736079u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TreeViewNode.Depth")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember = (XamlMember)new XamlMember(this, "Depth", "Int32");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_512_TreeViewNode_Depth;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 3809511617u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TreeViewNode.HasChildren")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember = (XamlMember)new XamlMember(this, "HasChildren", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_513_TreeViewNode_HasChildren;
				xamlMember.SetIsReadOnly();
			}
			break;
		case 4006239676u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TreeViewNode.HasUnrealizedChildren")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember = (XamlMember)new XamlMember(this, "HasUnrealizedChildren", "Boolean");
				xamlMember.Getter = get_514_TreeViewNode_HasUnrealizedChildren;
				xamlMember.Setter = set_514_TreeViewNode_HasUnrealizedChildren;
			}
			break;
		case 1538275247u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TreeViewNode.IsExpanded")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember = (XamlMember)new XamlMember(this, "IsExpanded", "Boolean");
				xamlMember.SetIsDependencyProperty();
				xamlMember.Getter = get_515_TreeViewNode_IsExpanded;
				xamlMember.Setter = set_515_TreeViewNode_IsExpanded;
			}
			break;
		case 2986178102u:
			if (longMemberName == "Microsoft.UI.Xaml.Controls.TreeViewNode.Parent")
			{
				_ = (XamlUserType)(object)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember = (XamlMember)new XamlMember(this, "Parent", "Microsoft.UI.Xaml.Controls.TreeViewNode");
				xamlMember.Getter = get_516_TreeViewNode_Parent;
				xamlMember.SetIsReadOnly();
			}
			break;
		}
		return (IXamlMember)(object)xamlMember;
	}

	[MethodImpl((MethodImplOptions)8)]
	public XamlTypeInfoProvider()
	{
		_xamlTypeCacheByName = new Dictionary<string, IXamlType>();
		_xamlTypeCacheByType = new Dictionary<global::System.Type, IXamlType>();
		_xamlMembers = new Dictionary<string, IXamlMember>();
	}
}

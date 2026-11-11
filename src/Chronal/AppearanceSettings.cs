using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using Windows.Storage;
using qS8vkpL43FlTMgcj0rgs;
using qcIZ8lAjAHfMaUh5fOa;

namespace Mahiro_Account.UI;

internal static class AppearanceSettings
{
	private const string ThemeSettingKey = "appearance.theme";

	private const string BackdropSettingKey = "appearance.background";

	private const string AutoHideSidebarSettingKey = "appearance.bedrock.autoHideSidebar";

	[CompilerGenerated]
	private static EventHandler? m_Changed;

	[field: CompilerGenerated]
	private static ElementTheme _Theme_k__BackingField;

	internal static ElementTheme Theme
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set;
	}

	[field: CompilerGenerated]
	private static AppBackdropKind _Backdrop_k__BackingField;

	internal static AppBackdropKind Backdrop
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set;
	}

	internal static bool IsDarkTheme
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Invalid comparison between Unknown and I4
			return (int)Theme != 1;
		}
	}

	[field: CompilerGenerated]
	internal static bool AutoHideSidebarForBedrock
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set;
	}

	internal static EventHandler Changed;

	[MethodImpl((MethodImplOptions)8)]
	internal static void Load()
	{
		Theme = (ElementTheme)(string.Equals(ReadSetting("appearance.theme", "dark"), "light", (StringComparison)4) ? 1 : 2);
		string text = ReadSetting("appearance.background", "mica");
		AppBackdropKind backdrop = ((text == "solid") ? AppBackdropKind.Solid : ((text == "acrylic") ? AppBackdropKind.Acrylic : AppBackdropKind.Mica));
		Backdrop = backdrop;
		AutoHideSidebarForBedrock = !string.Equals(ReadSetting("appearance.bedrock.autoHideSidebar", "false"), "false", (StringComparison)4);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Update(ElementTheme theme, AppBackdropKind backdrop)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		if (Theme != theme || Backdrop != backdrop)
		{
			Theme = (ElementTheme)(((int)theme == 1) ? 1 : 2);
			Backdrop = backdrop;
			WriteSetting("appearance.theme", ((int)Theme == 1) ? "light" : "dark");
			WriteSetting("appearance.background", Backdrop switch
			{
				AppBackdropKind.Solid => "solid", 
				AppBackdropKind.Acrylic => "acrylic", 
				_ => "mica", 
			});
			RaiseChanged();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void SetAutoHideSidebarForBedrock(bool autoHide)
	{
		if (AutoHideSidebarForBedrock != autoHide)
		{
			AutoHideSidebarForBedrock = autoHide;
			WriteSetting("appearance.bedrock.autoHideSidebar", autoHide ? "true" : "false");
			RaiseChanged();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void RaiseChanged()
	{
		try
		{
			EventHandler? changed = AppearanceSettings.Changed;
			if (changed != null)
			{
				changed.Invoke((object)null, EventArgs.Empty);
			}
		}
		catch
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ReadSetting(string key, string fallback)
	{
		string text = hJOXb0ALfS6Dke4PZFZ.iIGAZT9dtF(key, "");
		if (!string.IsNullOrWhiteSpace(text))
		{
			return text;
		}
		try
		{
			object obj = default(object);
			if (((IDictionary<string, object>)(object)ApplicationData.Current.LocalSettings.Values).TryGetValue(key, out obj) && obj is string text2 && !string.IsNullOrWhiteSpace(text2))
			{
				hJOXb0ALfS6Dke4PZFZ.LMvA9PbbUQ(key, text2);
				return text2;
			}
		}
		catch
		{
		}
		return fallback;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void WriteSetting(string key, string value)
	{
		hJOXb0ALfS6Dke4PZFZ.LMvA9PbbUQ(key, value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_Theme_k__BackingField = (ElementTheme)2;
		_Backdrop_k__BackingField = AppBackdropKind.Mica;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using EiAPRwJSDFvNotiSTTX;
using I1npyuftmG7beRglXwqb;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using T4XKlEftW1rbu7TvQmXH;
using VFQxICfth84Lkoc3ch2l;
using Vlsi7UfO9ch6W4RxaQqv;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.UI;
using dEVUOofwpSJjAgLAYiLV;
using pDFcXyfOjGiubvpRL0gO;
using qS8vkpL43FlTMgcj0rgs;
using uZIjVkftPkXCwLlroLeD;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class HomePage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IHomePage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IHomePage_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private static class XamlBindingSetters
	{
		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(ItemsControl obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.ItemsSource = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(TextBlock obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Text = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(UIElement obj, Visibility value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Visibility = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_Border_Background(Border obj, Brush value, string targetNullValue)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			if (value == (Brush)null && targetNullValue != null)
			{
				value = (Brush)XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), (object)targetNullValue);
			}
			obj.Background = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_FontIcon_Glyph(FontIcon obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Glyph = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_IconElement_Foreground(IconElement obj, Brush value, string targetNullValue)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			if (value == (Brush)null && targetNullValue != null)
			{
				value = (Brush)XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), (object)targetNullValue);
			}
			obj.Foreground = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Foreground(TextBlock obj, Brush value, string targetNullValue)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			if (value == (Brush)null && targetNullValue != null)
			{
				value = (Brush)XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.Brush), (object)targetNullValue);
			}
			obj.Foreground = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class HomePage_obj4_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IHomePage_Bindings
	{
		private xbVf4FftyKLP9yqO5mWE dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj4;

		private TextBlock obj5;

		private TextBlock obj6;

		private TextBlock obj7;

		[MethodImpl((MethodImplOptions)8)]
		public HomePage_obj4_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			switch (connectionId)
			{
			case 4:
				obj4 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 5:
				obj5 = CastExtensions.As<TextBlock>(target);
				break;
			case 6:
				obj6 = CastExtensions.As<TextBlock>(target);
				break;
			case 7:
				obj7 = CastExtensions.As<TextBlock>(target);
				break;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DataContextChangedHandler(FrameworkElement sender, DataContextChangedEventArgs args)
		{
			if (SetDataRoot(args.NewValue))
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool ProcessBinding(uint phase)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			throw new NotImplementedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public int ProcessBindings(ContainerContentChangingEventArgs args)
		{
			int nextPhase = -1;
			ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
			return nextPhase;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ResetTemplate()
		{
			Recycle();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ProcessBindings(object item, int itemIndex, int phase, out int nextPhase)
		{
			nextPhase = -1;
			removedDataContextHandler = true;
			object target = obj4.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<xbVf4FftyKLP9yqO5mWE>(item), 1 << phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Recycle()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Initialize()
		{
			if (!initialized)
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Update()
		{
			Update_(dataRoot, -2147483648);
			initialized = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void StopTracking()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			throw new ArgumentException("No unloadable elements to disconnect.");
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool SetDataRoot(object newDataRoot)
		{
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<xbVf4FftyKLP9yqO5mWE>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(xbVf4FftyKLP9yqO5mWE obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_StockText(obj.StockText, phase);
				Update_DisplayName(obj.DisplayName, phase);
				Update_PriceText(obj.PriceText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StockText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj5, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DisplayName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PriceText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj7, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class HomePage_obj15_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IHomePage_Bindings
	{
		private TimelineNote dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj15;

		private Border obj16;

		private TextBlock obj17;

		private FontIcon obj18;

		private TextBlock obj19;

		[MethodImpl((MethodImplOptions)8)]
		public HomePage_obj15_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			switch (connectionId)
			{
			case 15:
				obj15 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 16:
				obj16 = CastExtensions.As<Border>(target);
				break;
			case 17:
				obj17 = CastExtensions.As<TextBlock>(target);
				break;
			case 18:
				obj18 = CastExtensions.As<FontIcon>(target);
				break;
			case 19:
				obj19 = CastExtensions.As<TextBlock>(target);
				break;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DataContextChangedHandler(FrameworkElement sender, DataContextChangedEventArgs args)
		{
			if (SetDataRoot(args.NewValue))
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool ProcessBinding(uint phase)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			throw new NotImplementedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public int ProcessBindings(ContainerContentChangingEventArgs args)
		{
			int nextPhase = -1;
			ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
			return nextPhase;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ResetTemplate()
		{
			Recycle();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ProcessBindings(object item, int itemIndex, int phase, out int nextPhase)
		{
			nextPhase = -1;
			removedDataContextHandler = true;
			object target = obj15.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<TimelineNote>(item), 1 << phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Recycle()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Initialize()
		{
			if (!initialized)
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Update()
		{
			Update_(dataRoot, -2147483648);
			initialized = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void StopTracking()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			throw new ArgumentException("No unloadable elements to disconnect.");
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool SetDataRoot(object newDataRoot)
		{
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<TimelineNote>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(TimelineNote obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_TagBackground(obj.TagBackground, phase);
				Update_Content(obj.Content, phase);
				Update_IconGlyph(obj.IconGlyph, phase);
				Update_TagColor(obj.TagColor, phase);
				Update_TagText(obj.TagText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TagBackground(Brush obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Border_Background(obj16, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Content(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IconGlyph(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_FontIcon_Glyph(obj18, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TagColor(Brush obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_IconElement_Foreground((IconElement)(object)obj18, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Foreground(obj19, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TagText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj19, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class HomePage_obj12_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IHomePage_Bindings
	{
		private TimelineEntry dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj12;

		private ItemsControl obj13;

		private TextBlock obj20;

		private Border obj21;

		private TextBlock obj22;

		[MethodImpl((MethodImplOptions)8)]
		public HomePage_obj12_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 12:
				obj12 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 13:
				obj13 = CastExtensions.As<ItemsControl>(target);
				break;
			case 20:
				obj20 = CastExtensions.As<TextBlock>(target);
				break;
			case 21:
				obj21 = CastExtensions.As<Border>(target);
				break;
			case 22:
				obj22 = CastExtensions.As<TextBlock>(target);
				break;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DataContextChangedHandler(FrameworkElement sender, DataContextChangedEventArgs args)
		{
			if (SetDataRoot(args.NewValue))
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool ProcessBinding(uint phase)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			throw new NotImplementedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public int ProcessBindings(ContainerContentChangingEventArgs args)
		{
			int nextPhase = -1;
			ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
			return nextPhase;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ResetTemplate()
		{
			Recycle();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ProcessBindings(object item, int itemIndex, int phase, out int nextPhase)
		{
			nextPhase = -1;
			removedDataContextHandler = true;
			object target = obj12.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<TimelineEntry>(item), 1 << phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Recycle()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Initialize()
		{
			if (!initialized)
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Update()
		{
			Update_(dataRoot, -2147483648);
			initialized = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void StopTracking()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			throw new ArgumentException("No unloadable elements to disconnect.");
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool SetDataRoot(object newDataRoot)
		{
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<TimelineEntry>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(TimelineEntry obj, int phase)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Notes(obj.Notes, phase);
				Update_VersionText(obj.VersionText, phase);
				Update_LatestBadgeVisibility(obj.LatestBadgeVisibility, phase);
				Update_DateText(obj.DateText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Notes(List<TimelineNote> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_VersionText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj20, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_LatestBadgeVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj21, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DateText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class HomePage_obj1_Bindings : IComponentConnector, IHomePage_Bindings
	{
		private HomePage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ItemsControl obj10;

		[MethodImpl((MethodImplOptions)8)]
		public HomePage_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 10)
			{
				obj10 = CastExtensions.As<ItemsControl>(target);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Initialize()
		{
			if (!initialized)
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Update()
		{
			Update_(dataRoot, -2147483648);
			initialized = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void StopTracking()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			throw new ArgumentException("No unloadable elements to disconnect.");
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool SetDataRoot(object newDataRoot)
		{
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<HomePage>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Activated(object obj, WindowActivatedEventArgs data)
		{
			Initialize();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Loading(FrameworkElement src, object data)
		{
			Initialize();
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(HomePage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_HomeTimelineList(obj.HomeTimelineList, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_HomeTimelineList(ObservableCollection<TimelineEntry> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __RedeemAsync_b__13_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public HomePage __4__this;

		private P6TqvfftoXnVc010rQKn _result_5__2;

		private TaskAwaiter<P6TqvfftoXnVc010rQKn> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HomePage homePage = __4__this;
			try
			{
				TaskAwaiter<P6TqvfftoXnVc010rQKn> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<P6TqvfftoXnVc010rQKn>);
					num = (__1__state = -1);
					goto IL_00a8;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0120;
				}
				string text = homePage.HomeCardCodeBox.Text.Trim();
				if (!string.IsNullOrWhiteSpace(text))
				{
					_u__ = AppShell.Api.Wyt0BGHWsr(text).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<P6TqvfftoXnVc010rQKn>, __RedeemAsync_b__13_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_00a8;
				}
				AppShell.Warning("请输入卡密");
				goto end_IL_0011;
				IL_0120:
				_u__2.GetResult();
				if (string.Equals(_result_5__2.CardType, "service", (StringComparison)5))
				{
					AppShell.Success($"{_result_5__2.Message}，{_result_5__2.ServiceName ?? _result_5__2.ServiceCode ?? "目标服务"}增加 {_result_5__2.DurationDays.GetValueOrDefault()} 天");
				}
				else
				{
					AppShell.Success($"{_result_5__2.Message}，额度 +{_result_5__2.BalanceAdded.ToString("0.##", (IFormatProvider)(object)CultureInfo.InvariantCulture)}，当前余额 {_result_5__2.Balance.ToString("0.##", (IFormatProvider)(object)CultureInfo.InvariantCulture)}");
				}
				goto end_IL_0011;
				IL_00a8:
				P6TqvfftoXnVc010rQKn result = _u__.GetResult();
				_result_5__2 = result;
				homePage.HomeCardCodeBox.Text = string.Empty;
				_u__2 = AppShell.RefreshSummaryAsync().GetAwaiter();
				if (!_u__2.IsCompleted)
				{
					num = (__1__state = 1);
					__u__2 = _u__2;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __RedeemAsync_b__13_0_d>(ref _u__2, ref this);
					return;
				}
				goto IL_0120;
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_result_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_result_5__2 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private static class __O_6
	{
		public static Func<global::System.Threading.Tasks.Task> _0___RefreshSummaryAsync;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass5_0_2
	{
		public HomePage __4__this;

		public PJWRpXfOZeOHKi4Pca4V response;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass5_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _LoadChangelogAsync_b__0()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			bool isDarkTheme = AppShell.IsDarkTheme;
			Color val = (isDarkTheme ? ColorHelper.FromArgb((byte)255, (byte)108, (byte)203, (byte)95) : ColorHelper.FromArgb((byte)255, (byte)16, (byte)124, (byte)16));
			Color val2 = (isDarkTheme ? ColorHelper.FromArgb((byte)255, (byte)96, (byte)205, (byte)255) : ColorHelper.FromArgb((byte)255, (byte)0, (byte)120, (byte)212));
			Color val3 = (isDarkTheme ? ColorHelper.FromArgb((byte)255, (byte)255, (byte)153, (byte)164) : ColorHelper.FromArgb((byte)255, (byte)209, (byte)52, (byte)56));
			Color val4 = (isDarkTheme ? ColorHelper.FromArgb((byte)255, (byte)170, (byte)170, (byte)170) : ColorHelper.FromArgb((byte)255, (byte)97, (byte)97, (byte)97));
			SolidColorBrush val5 = new SolidColorBrush(val);
			SolidColorBrush val6 = new SolidColorBrush(val2);
			SolidColorBrush val7 = new SolidColorBrush(val3);
			SolidColorBrush val8 = new SolidColorBrush(val4);
			byte num = (byte)(isDarkTheme ? 35 : 25);
			SolidColorBrush val9 = new SolidColorBrush(ColorHelper.FromArgb(num, val.R, val.G, val.B));
			SolidColorBrush val10 = new SolidColorBrush(ColorHelper.FromArgb(num, val2.R, val2.G, val2.B));
			SolidColorBrush val11 = new SolidColorBrush(ColorHelper.FromArgb(num, val3.R, val3.G, val3.B));
			SolidColorBrush val12 = new SolidColorBrush(ColorHelper.FromArgb(num, val4.R, val4.G, val4.B));
			for (int i = 0; i < response.Entries.Count; i++)
			{
				d2iiUHfOLr9ZvQq4WHMC val13 = response.Entries[i];
				TimelineEntry timelineEntry = (TimelineEntry)new TimelineEntry
				{
					VersionText = val13.VersionText,
					DateText = val13.DateText,
					IsLatest = (i == 0)
				};
				var enumerator = val13.Notes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string text = (enumerator.Current ?? string.Empty).Trim();
						if (text.StartsWith("- "))
						{
							text = text.Substring(2).Trim();
						}
						string tagText = "其他";
						SolidColorBrush tagColor = val8;
						SolidColorBrush tagBackground = val12;
						string iconGlyph = "\ue946";
						if (text.StartsWith("新增") || text.StartsWith("支持") || text.StartsWith("增加") || text.StartsWith("添加") || text.StartsWith("接入") || text.StartsWith("集成") || text.StartsWith("全新") || text.StartsWith("适配") || text.StartsWith("引入") || text.StartsWith("实装") || text.StartsWith("内置") || text.StartsWith("实现"))
						{
							tagText = "新增";
							tagColor = val6;
							tagBackground = val10;
							iconGlyph = "\ue710";
						}
						else if (text.StartsWith("优化") || text.StartsWith("重写") || text.StartsWith("升级") || text.StartsWith("美化") || text.StartsWith("改进") || text.StartsWith("完善") || text.StartsWith("提升") || text.StartsWith("调整") || text.StartsWith("更改") || text.StartsWith("修改") || text.StartsWith("更新") || text.StartsWith("重构") || text.StartsWith("精简") || text.StartsWith("降低") || text.StartsWith("提高") || text.StartsWith("将"))
						{
							tagText = "优化";
							tagColor = val5;
							tagBackground = val9;
							iconGlyph = "\ue713";
						}
						else if (text.StartsWith("修复") || text.StartsWith("修正") || text.StartsWith("解决") || text.StartsWith("拦截") || text.StartsWith("处理") || text.StartsWith("防止") || text.StartsWith("规避") || text.StartsWith("补全"))
						{
							tagText = "修复";
							tagColor = val7;
							tagBackground = val11;
							iconGlyph = "\ue90f";
						}
						timelineEntry.Notes.Add((TimelineNote)new TimelineNote
						{
							TagText = tagText,
							TagColor = (Brush)(object)tagColor,
							TagBackground = (Brush)(object)tagBackground,
							IconGlyph = iconGlyph,
							Content = text
						});
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				((Collection<TimelineEntry>)(object)__4__this.HomeTimelineList).Add(timelineEntry);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _HomeCardCodeBox_KeyDown_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public KeyRoutedEventArgs e;

		public HomePage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HomePage homePage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_008c;
				}
				if ((int)e.Key == 13)
				{
					e.Handled = true;
					_u__ = homePage.RedeemAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HomeCardCodeBox_KeyDown_d__12>(ref _u__, ref this);
						return;
					}
					goto IL_008c;
				}
				goto end_IL_0011;
				IL_008c:
				_u__.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _HomeRedeemButton_Click_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HomePage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HomePage homePage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = homePage.RedeemAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HomeRedeemButton_Click_d__11>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadChangelogAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public HomePage __4__this;

		private __c__DisplayClass5_0_2 __8__1;

		private TaskAwaiter<PJWRpXfOZeOHKi4Pca4V> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			int num = __1__state;
			HomePage homePage = __4__this;
			try
			{
				if (num != 0)
				{
					__8__1 = (__c__DisplayClass5_0_2)new __c__DisplayClass5_0_2();
					__8__1.__4__this = __4__this;
				}
				try
				{
					TaskAwaiter<PJWRpXfOZeOHKi4Pca4V> _u__ = default;
					if (num != 0)
					{
						_u__ = homePage._changelogService.xTXJcGhP0T(default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PJWRpXfOZeOHKi4Pca4V>, _LoadChangelogAsync_d__5>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<PJWRpXfOZeOHKi4Pca4V>);
						num = (__1__state = -1);
					}
					PJWRpXfOZeOHKi4Pca4V result = _u__.GetResult();
					__8__1.response = result;
					PJWRpXfOZeOHKi4Pca4V obj = __8__1.response;
					if (((obj != null) ? obj.Entries : null) != null)
					{
						((DependencyObject)homePage).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(__8__1._LoadChangelogAsync_b__0));
					}
				}
				catch (global::System.Exception)
				{
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RedeemAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public HomePage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HomePage __8_locals1 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__RedeemAsync_b__13_0_d _RedeemAsync_b__13_0_d = default(__RedeemAsync_b__13_0_d);
						_RedeemAsync_b__13_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_RedeemAsync_b__13_0_d.__4__this = __8_locals1;
						_RedeemAsync_b__13_0_d.__1__state = -1;
						_RedeemAsync_b__13_0_d.__t__builder.Start<__RedeemAsync_b__13_0_d>(ref _RedeemAsync_b__13_0_d);
						return _RedeemAsync_b__13_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RedeemAsync_d__13>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshButton_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync(AppShell.RefreshSummaryAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__10>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private readonly qJZUC0JY3okUVxPyXoP _changelogService;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView HomeStockList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border HomeMachineDetailsCard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border HomeChangelogCard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeCpuText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeDiskText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeBiosText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeBoardText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox HomeCardCodeBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeBedrockStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeBedrockExpiryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeMachineCountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeLastVerifiedText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private FontIcon HomeMachineStatusIcon;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeMachineStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeBalanceText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeUsernameText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeUserIdText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HomeRoleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IHomePage_Bindings Bindings;

	[CompilerGenerated]
	private ObservableCollection<TimelineEntry> _HomeTimelineList_k__BackingField;
	public ObservableCollection<TimelineEntry> HomeTimelineList
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _HomeTimelineList_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public HomePage()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		_changelogService = new qJZUC0JY3okUVxPyXoP();
		_HomeTimelineList_k__BackingField = new ObservableCollection<TimelineEntry>();
		InitializeComponent();
		((ItemsControl)HomeStockList).ItemsSource = AppShell.Products;
		AppShell.SummaryRefreshed += OnSummaryRefreshed;
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			AppShell.SummaryRefreshed -= OnSummaryRefreshed;
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		});
		yg9HVZft43Yd2k4O7qX5 latestSummary = AppShell.LatestSummary;
		if (latestSummary != null)
		{
			UpdateHome(latestSummary);
		}
		LoadChangelogAsync();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadChangelogAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadChangelogAsync_d__5 loadChangelogAsync_d__ = default(_LoadChangelogAsync_d__5);
		loadChangelogAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadChangelogAsync_d__.__4__this = this;
		loadChangelogAsync_d__.__1__state = -1;
		loadChangelogAsync_d__.__t__builder.Start<_LoadChangelogAsync_d__5>(ref loadChangelogAsync_d__);
		return loadChangelogAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSummaryRefreshed(object? sender, yg9HVZft43Yd2k4O7qX5 summary)
	{
		UpdateHome(summary);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		HomeCardCodeBox.Text = string.Empty;
		HomeUsernameText.Text = "-";
		HomeUserIdText.Text = string.Empty;
		HomeRoleText.Text = string.Empty;
		Motion.CountTo(HomeBalanceText, 0m, "¥ ", "0.00", animate: false);
		HomeMachineStatusText.Text = "-";
		HomeMachineCountText.Text = string.Empty;
		HomeLastVerifiedText.Text = string.Empty;
		HomeBedrockStatusText.Text = "未订阅";
		HomeBedrockExpiryText.Text = "点击进入服务订阅";
		((UIElement)HomeMachineDetailsCard).Visibility = (Visibility)1;
		((UIElement)HomeChangelogCard).Visibility = (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateHome(yg9HVZft43Yd2k4O7qX5 summary)
	{
		HomeUsernameText.Text = summary.User.Username;
		HomeUserIdText.Text = "ID " + summary.User.Id.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture);
		HomeRoleText.Text = summary.User.PrimaryRoleText;
		Motion.CountTo(HomeBalanceText, summary.User.Balance);
		bool flag = string.Equals(summary.MachineStatus, "verified", (StringComparison)4);
		HomeMachineStatusText.Text = (flag ? "当前设备已验证" : "当前设备未绑定");
		HomeMachineStatusIcon.Glyph = (flag ? "" : "");
		object val = HomeMachineStatusIcon;
		object obj = Application.Current.Resources[(object)(flag ? "SystemFillColorSuccessBrush" : "SystemFillColorCautionBrush")];
		((IconElement)val).Foreground = (Brush)((obj is Brush) ? obj : null);
		HomeMachineCountText.Text = $"已绑定机器 {summary.MachineCount}";
		HomeLastVerifiedText.Text = (summary.LastVerifiedAt.HasValue ? $"最近验证 {summary.LastVerifiedAt.Value.ToLocalTime():yyyy-MM-dd HH:mm}" : "最近验证 -");
		cIFpEPfwMuX4GIUav4ts bedrockLaunch = summary.ServiceSubscriptions.BedrockLaunch;
		HomeBedrockStatusText.Text = bedrockLaunch.StatusText;
		HomeBedrockExpiryText.Text = bedrockLaunch.SummaryText;
		((UIElement)HomeMachineDetailsCard).Visibility = ((!summary.User.IsAdmin) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)HomeChangelogCard).Visibility = (Visibility)0;
		YJedpPfteqmnSkZaVSTj machine = summary.Machine;
		Dictionary<string, string> machine2 = ((machine != null) ? machine.Machine : null) ?? AppShell.Machine.Payload;
		HomeCpuText.Text = UiHelpers.GetMachineValue(machine2, "cpu");
		HomeDiskText.Text = UiHelpers.GetMachineValue(machine2, "disk");
		HomeBiosText.Text = UiHelpers.GetMachineValue(machine2, "bios");
		HomeBoardText.Text = UiHelpers.GetMachineValue(machine2, "boardUuid");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BedrockSubscriptionCard_Tapped(object sender, TappedRoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("services"));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__10 refreshButton_Click_d__ = default(_RefreshButton_Click_d__10);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__10>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void HomeRedeemButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HomeRedeemButton_Click_d__11 homeRedeemButton_Click_d__ = default(_HomeRedeemButton_Click_d__11);
		homeRedeemButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		homeRedeemButton_Click_d__.__4__this = this;
		homeRedeemButton_Click_d__.__1__state = -1;
		homeRedeemButton_Click_d__.__t__builder.Start<_HomeRedeemButton_Click_d__11>(ref homeRedeemButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void HomeCardCodeBox_KeyDown(object sender, KeyRoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HomeCardCodeBox_KeyDown_d__12 homeCardCodeBox_KeyDown_d__ = default(_HomeCardCodeBox_KeyDown_d__12);
		homeCardCodeBox_KeyDown_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		homeCardCodeBox_KeyDown_d__.__4__this = this;
		homeCardCodeBox_KeyDown_d__.e = e;
		homeCardCodeBox_KeyDown_d__.__1__state = -1;
		homeCardCodeBox_KeyDown_d__.__t__builder.Start<_HomeCardCodeBox_KeyDown_d__12>(ref homeCardCodeBox_KeyDown_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RedeemAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RedeemAsync_d__13 redeemAsync_d__ = default(_RedeemAsync_d__13);
		redeemAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		redeemAsync_d__.__4__this = this;
		redeemAsync_d__.__1__state = -1;
		redeemAsync_d__.__t__builder.Start<_RedeemAsync_d__13>(ref redeemAsync_d__);
		return redeemAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri val = new Uri("ms-appx:///Views/Pages/HomePage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			HomeStockList = CastExtensions.As<ListView>(target);
			break;
		case 8:
			HomeMachineDetailsCard = CastExtensions.As<Border>(target);
			break;
		case 9:
			HomeChangelogCard = CastExtensions.As<Border>(target);
			break;
		case 23:
			HomeCpuText = CastExtensions.As<TextBlock>(target);
			break;
		case 24:
			HomeDiskText = CastExtensions.As<TextBlock>(target);
			break;
		case 25:
			HomeBiosText = CastExtensions.As<TextBlock>(target);
			break;
		case 26:
			HomeBoardText = CastExtensions.As<TextBlock>(target);
			break;
		case 27:
			HomeCardCodeBox = CastExtensions.As<TextBox>(target);
			((UIElement)HomeCardCodeBox).KeyDown += new KeyEventHandler(HomeCardCodeBox_KeyDown);
			break;
		case 28:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(HomeRedeemButton_Click);
			break;
		case 29:
			((UIElement)CastExtensions.As<Border>(target)).Tapped += new TappedEventHandler(BedrockSubscriptionCard_Tapped);
			break;
		case 30:
			HomeBedrockStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 31:
			HomeBedrockExpiryText = CastExtensions.As<TextBlock>(target);
			break;
		case 32:
			HomeMachineCountText = CastExtensions.As<TextBlock>(target);
			break;
		case 33:
			HomeLastVerifiedText = CastExtensions.As<TextBlock>(target);
			break;
		case 34:
			HomeMachineStatusIcon = CastExtensions.As<FontIcon>(target);
			break;
		case 35:
			HomeMachineStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 36:
			HomeBalanceText = CastExtensions.As<TextBlock>(target);
			break;
		case 37:
			HomeUsernameText = CastExtensions.As<TextBlock>(target);
			break;
		case 38:
			HomeUserIdText = CastExtensions.As<TextBlock>(target);
			break;
		case 39:
			HomeRoleText = CastExtensions.As<TextBlock>(target);
			break;
		case 40:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 1:
		{
			Page val4 = (Page)target;
			HomePage_obj1_Bindings homePage_obj1_Bindings = (HomePage_obj1_Bindings)new HomePage_obj1_Bindings();
			result = (IComponentConnector)(object)homePage_obj1_Bindings;
			homePage_obj1_Bindings.SetDataRoot(this);
			Bindings = homePage_obj1_Bindings;
			((FrameworkElement)val4).Loading += homePage_obj1_Bindings.Loading;
			break;
		}
		case 4:
		{
			Grid val3 = (Grid)target;
			HomePage_obj4_Bindings homePage_obj4_Bindings = (HomePage_obj4_Bindings)new HomePage_obj4_Bindings();
			result = (IComponentConnector)(object)homePage_obj4_Bindings;
			homePage_obj4_Bindings.SetDataRoot(((FrameworkElement)val3).DataContext);
			((FrameworkElement)val3).DataContextChanged += homePage_obj4_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val3, (IDataTemplateExtension)(object)homePage_obj4_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val3, (IDataTemplateComponent)(object)homePage_obj4_Bindings);
			break;
		}
		case 12:
		{
			Border val2 = (Border)target;
			HomePage_obj12_Bindings homePage_obj12_Bindings = (HomePage_obj12_Bindings)new HomePage_obj12_Bindings();
			result = (IComponentConnector)(object)homePage_obj12_Bindings;
			homePage_obj12_Bindings.SetDataRoot(((FrameworkElement)val2).DataContext);
			((FrameworkElement)val2).DataContextChanged += homePage_obj12_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val2, (IDataTemplateExtension)(object)homePage_obj12_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val2, (IDataTemplateComponent)(object)homePage_obj12_Bindings);
			break;
		}
		case 15:
		{
			Grid val = (Grid)target;
			HomePage_obj15_Bindings homePage_obj15_Bindings = (HomePage_obj15_Bindings)new HomePage_obj15_Bindings();
			result = (IComponentConnector)(object)homePage_obj15_Bindings;
			homePage_obj15_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += homePage_obj15_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)homePage_obj15_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)homePage_obj15_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__4_0(object _, RoutedEventArgs _2)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		AppShell.SummaryRefreshed -= OnSummaryRefreshed;
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _RedeemAsync_b__13_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__RedeemAsync_b__13_0_d _RedeemAsync_b__13_0_d = default(__RedeemAsync_b__13_0_d);
		_RedeemAsync_b__13_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_RedeemAsync_b__13_0_d.__4__this = this;
		_RedeemAsync_b__13_0_d.__1__state = -1;
		_RedeemAsync_b__13_0_d.__t__builder.Start<__RedeemAsync_b__13_0_d>(ref _RedeemAsync_b__13_0_d);
		return _RedeemAsync_b__13_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

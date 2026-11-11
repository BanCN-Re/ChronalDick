using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.Windows.Storage.Pickers;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using nW2Sekfay3BSEMMb8toe;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockMaterialPackBrowser : UserControl, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockMaterialPackBrowser_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockMaterialPackBrowser_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
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
		public static void Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(Control obj, bool value)
		{
			obj.IsEnabled = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_FrameworkElement_Tag(FrameworkElement obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.Tag = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(UIElement obj, Visibility value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Visibility = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_ContentControl_Content(ContentControl obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.Content = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip(DependencyObject obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			ToolTipService.SetToolTip(obj, value);
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
		public static void Set_Microsoft_UI_Xaml_Controls_Image_Source(Image obj, ImageSource value, string targetNullValue)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			if (value == (ImageSource)null && targetNullValue != null)
			{
				value = (ImageSource)XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Media.ImageSource), (object)targetNullValue);
			}
			obj.Source = value;
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
	private class BedrockMaterialPackBrowser_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockMaterialPackBrowser_Bindings
	{
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		private class BedrockMaterialPackBrowser_obj5_BindingsTracking
		{
			private WeakReference<BedrockMaterialPackBrowser_obj5_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public BedrockMaterialPackBrowser_obj5_BindingsTracking(BedrockMaterialPackBrowser_obj5_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<BedrockMaterialPackBrowser_obj5_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public BedrockMaterialPackBrowser_obj5_Bindings TryGetBindingObject()
			{
				BedrockMaterialPackBrowser_obj5_Bindings bedrockMaterialPackBrowser_obj5_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out bedrockMaterialPackBrowser_obj5_Bindings);
					if (bedrockMaterialPackBrowser_obj5_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return bedrockMaterialPackBrowser_obj5_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
				UpdateChildListeners_(null);
			}

			[MethodImpl((MethodImplOptions)8)]
			public void PropertyChanged_(object sender, PropertyChangedEventArgs e)
			{
				BedrockMaterialPackBrowser_obj5_Bindings bedrockMaterialPackBrowser_obj5_Bindings = TryGetBindingObject();
				if (bedrockMaterialPackBrowser_obj5_Bindings == null)
				{
					return;
				}
				string propertyName = e.PropertyName;
				BedrockMaterialPackViewModel bedrockMaterialPackViewModel = sender as BedrockMaterialPackViewModel;
				if (string.IsNullOrEmpty(propertyName))
				{
					if (bedrockMaterialPackViewModel != null)
					{
						bedrockMaterialPackBrowser_obj5_Bindings.Update_CanMoveUp(bedrockMaterialPackViewModel.CanMoveUp, 1073741824);
						bedrockMaterialPackBrowser_obj5_Bindings.Update_CanMoveDown(bedrockMaterialPackViewModel.CanMoveDown, 1073741824);
						bedrockMaterialPackBrowser_obj5_Bindings.Update_EnableActionText(bedrockMaterialPackViewModel.EnableActionText, 1073741824);
						bedrockMaterialPackBrowser_obj5_Bindings.Update_EnableToolTip(bedrockMaterialPackViewModel.EnableToolTip, 1073741824);
						bedrockMaterialPackBrowser_obj5_Bindings.Update_FontProtectionText(bedrockMaterialPackViewModel.FontProtectionText, 1073741824);
						bedrockMaterialPackBrowser_obj5_Bindings.Update_FontProtectionToolTip(bedrockMaterialPackViewModel.FontProtectionToolTip, 1073741824);
						bedrockMaterialPackBrowser_obj5_Bindings.Update_MetadataText(bedrockMaterialPackViewModel.MetadataText, 1073741824);
					}
				}
				else
				{
					if (propertyName == null)
					{
						return;
					}
					switch (propertyName.Length)
					{
					case 9:
						if (propertyName == "CanMoveUp" && bedrockMaterialPackViewModel != null)
						{
							bedrockMaterialPackBrowser_obj5_Bindings.Update_CanMoveUp(bedrockMaterialPackViewModel.CanMoveUp, 1073741824);
						}
						break;
					case 11:
						if (propertyName == "CanMoveDown" && bedrockMaterialPackViewModel != null)
						{
							bedrockMaterialPackBrowser_obj5_Bindings.Update_CanMoveDown(bedrockMaterialPackViewModel.CanMoveDown, 1073741824);
						}
						break;
					case 16:
						if (propertyName == "EnableActionText" && bedrockMaterialPackViewModel != null)
						{
							bedrockMaterialPackBrowser_obj5_Bindings.Update_EnableActionText(bedrockMaterialPackViewModel.EnableActionText, 1073741824);
						}
						break;
					case 13:
						if (propertyName == "EnableToolTip" && bedrockMaterialPackViewModel != null)
						{
							bedrockMaterialPackBrowser_obj5_Bindings.Update_EnableToolTip(bedrockMaterialPackViewModel.EnableToolTip, 1073741824);
						}
						break;
					case 18:
						if (propertyName == "FontProtectionText" && bedrockMaterialPackViewModel != null)
						{
							bedrockMaterialPackBrowser_obj5_Bindings.Update_FontProtectionText(bedrockMaterialPackViewModel.FontProtectionText, 1073741824);
						}
						break;
					case 21:
						if (propertyName == "FontProtectionToolTip" && bedrockMaterialPackViewModel != null)
						{
							bedrockMaterialPackBrowser_obj5_Bindings.Update_FontProtectionToolTip(bedrockMaterialPackViewModel.FontProtectionToolTip, 1073741824);
						}
						break;
					case 12:
						if (propertyName == "MetadataText" && bedrockMaterialPackViewModel != null)
						{
							bedrockMaterialPackBrowser_obj5_Bindings.Update_MetadataText(bedrockMaterialPackViewModel.MetadataText, 1073741824);
						}
						break;
					case 10:
					case 14:
					case 15:
					case 17:
					case 19:
					case 20:
						break;
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_(BedrockMaterialPackViewModel obj)
			{
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				BedrockMaterialPackBrowser_obj5_Bindings bedrockMaterialPackBrowser_obj5_Bindings = TryGetBindingObject();
				if (bedrockMaterialPackBrowser_obj5_Bindings != null)
				{
					if (bedrockMaterialPackBrowser_obj5_Bindings.dataRoot != null)
					{
						((INotifyPropertyChanged)bedrockMaterialPackBrowser_obj5_Bindings.dataRoot).PropertyChanged -= new PropertyChangedEventHandler(PropertyChanged_);
					}
					if (obj != null)
					{
						bedrockMaterialPackBrowser_obj5_Bindings.dataRoot = obj;
						((INotifyPropertyChanged)obj).PropertyChanged += new PropertyChangedEventHandler(PropertyChanged_);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private BedrockMaterialPackViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private Button obj6;

		private Button obj7;

		private Button obj8;

		private Button obj9;

		private Button obj10;

		private Button obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private TextBlock obj14;

		private FontIcon obj15;

		private Image obj16;

		private BedrockMaterialPackBrowser_obj5_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockMaterialPackBrowser_obj5_Bindings()
		{
			bindingsTracking = (BedrockMaterialPackBrowser_obj5_BindingsTracking)new BedrockMaterialPackBrowser_obj5_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			switch (connectionId)
			{
			case 5:
				obj5 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 6:
				obj6 = CastExtensions.As<Button>(target);
				break;
			case 7:
				obj7 = CastExtensions.As<Button>(target);
				break;
			case 8:
				obj8 = CastExtensions.As<Button>(target);
				break;
			case 9:
				obj9 = CastExtensions.As<Button>(target);
				break;
			case 10:
				obj10 = CastExtensions.As<Button>(target);
				break;
			case 11:
				obj11 = CastExtensions.As<Button>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<TextBlock>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<TextBlock>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<FontIcon>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<Image>(target);
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
			object target = obj5.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BedrockMaterialPackViewModel>(item), 1 << phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Recycle()
		{
			bindingsTracking.ReleaseAllListeners();
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
			bindingsTracking.ReleaseAllListeners();
			initialized = false;
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
			bindingsTracking.ReleaseAllListeners();
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<BedrockMaterialPackViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockMaterialPackViewModel obj, int phase)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			bindingsTracking.UpdateChildListeners_(obj);
			if (obj != null)
			{
				if ((phase & -1073741823) != 0)
				{
					Update_CanMoveUp(obj.CanMoveUp, phase);
				}
				if ((phase & -2147483647) != 0)
				{
					Update_Id(obj.Id, phase);
				}
				if ((phase & -1073741823) != 0)
				{
					Update_CanMoveDown(obj.CanMoveDown, phase);
				}
				if ((phase & -2147483647) != 0)
				{
					Update_DeleteVisibility(obj.DeleteVisibility, phase);
				}
				if ((phase & -1073741823) != 0)
				{
					Update_EnableActionText(obj.EnableActionText, phase);
					Update_EnableToolTip(obj.EnableToolTip, phase);
					Update_FontProtectionText(obj.FontProtectionText, phase);
					Update_FontProtectionToolTip(obj.FontProtectionToolTip, phase);
				}
				if ((phase & -2147483647) != 0)
				{
					Update_Name(obj.Name, phase);
				}
				if ((phase & -1073741823) != 0)
				{
					Update_MetadataText(obj.MetadataText, phase);
				}
				if ((phase & -2147483647) != 0)
				{
					Update_Description(obj.Description, phase);
					Update_PlaceholderVisibility(obj.PlaceholderVisibility, phase);
					Update_IconSource(obj.IconSource, phase);
					Update_IconVisibility(obj.IconVisibility, phase);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CanMoveUp(bool obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj6, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Id(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj6, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj7, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj8, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj9, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj10, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CanMoveDown(bool obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj7, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DeleteVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj9, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_EnableActionText(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentControl_Content((ContentControl)(object)obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_EnableToolTip(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_FontProtectionText(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentControl_Content((ContentControl)(object)obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_FontProtectionToolTip(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_MetadataText(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Description(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj14, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PlaceholderVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj15, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IconSource(BitmapImage obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(obj16, (ImageSource)(object)obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IconVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj16, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	private class BedrockMaterialPackBrowser_obj1_Bindings : IComponentConnector, IBedrockMaterialPackBrowser_Bindings
	{
		private BedrockMaterialPackBrowser dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ListView obj2;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockMaterialPackBrowser_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 2)
			{
				obj2 = CastExtensions.As<ListView>(target);
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
				dataRoot = CastExtensions.As<BedrockMaterialPackBrowser>(newDataRoot);
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
		private void Update_(BedrockMaterialPackBrowser obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -2147483647) != 0)
			{
				Update_Packs(obj.Packs, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Packs(ObservableCollection<BedrockMaterialPackViewModel> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj2, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __OnMaterialPacksChanged_b__27_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0081;
				}
				if (bedrockMaterialPackBrowser._operationCancellation == null)
				{
					bedrockMaterialPackBrowser._loaded = false;
					_u__ = bedrockMaterialPackBrowser.LoadAsync(force: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnMaterialPacksChanged_b__27_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_0081;
				}
				goto end_IL_0011;
				IL_0081:
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

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_6
	{
		public static readonly __c_6 __9;

		public static Func<WQh695fa8bRtqyh4inIH, int> __9__12_0;

		public static Func<WQh695fa8bRtqyh4inIH, string> __9__12_1;

		public static Func<BedrockMaterialPackViewModel, bool> __9__12_2;

		[MethodImpl((MethodImplOptions)8)]
		static __c_6()
		{
			__9 = (__c_6)new __c_6();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_6()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int _UpdateList_b__12_0(WQh695fa8bRtqyh4inIH item)
		{
			return item.Priority;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _UpdateList_b__12_1(WQh695fa8bRtqyh4inIH pack)
		{
			return pack.Id;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _UpdateList_b__12_2(BedrockMaterialPackViewModel item)
		{
			return item.IsEnabled;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass14_0
	{
		public BedrockMaterialPackBrowser __4__this;

		public string path;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass14_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<WQh695fa8bRtqyh4inIH> _ImportArchiveButton_Click_b__0(CancellationToken token)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.XPFX5Nqtu34(path, token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass15_0
	{
		public BedrockMaterialPackBrowser __4__this;

		public string path;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass15_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<WQh695fa8bRtqyh4inIH> _ImportFolderButton_Click_b__0(CancellationToken token)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.s1OX5MdaVEo(path, token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass18_0_1
	{
		public string packId;

		public BedrockMaterialPackBrowser __4__this;

		public BedrockMaterialPackViewModel current;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _EnabledButton_Click_b__0(BedrockMaterialPackViewModel item)
		{
			return item.Id.Equals(packId, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _EnabledButton_Click_b__1(CancellationToken token)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.AXaX5aPOuFt(packId, !current.IsEnabled, token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass19_0_1
	{
		public string packId;

		public BedrockMaterialPackBrowser __4__this;

		public BedrockMaterialPackViewModel current;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass19_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _FontOverrideButton_Click_b__0(BedrockMaterialPackViewModel item)
		{
			return item.Id.Equals(packId, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _FontOverrideButton_Click_b__1(CancellationToken token)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.ESbX51MIwio(packId, !current.AllowFontOverride, token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass22_0
	{
		public BedrockMaterialPackBrowser __4__this;

		public string packId;

		public int offset;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass22_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _MoveAsync_b__0(CancellationToken token)
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.DuLX53aWJ4Y(packId, offset, token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass23_0_1
	{
		public string packId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass23_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ExportButton_Click_b__0(BedrockMaterialPackViewModel item)
		{
			return item.Id.Equals(packId, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass24_0
	{
		public string packId;

		public BedrockMaterialPackBrowser __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass24_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _DeleteButton_Click_b__0(BedrockMaterialPackViewModel item)
		{
			return item.Id.Equals(packId, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _DeleteButton_Click_b__1(CancellationToken token)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.KawX5vmPlFt(packId, token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass26_0
	{
		public char[] invalid;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass26_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SanitizeFileName_b__0(char character)
		{
			return !Enumerable.Contains<char>((global::System.Collections.Generic.IEnumerable<char>)invalid, character);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _DeleteButton_Click_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public object sender;

		private __c__DisplayClass24_0 __8__1;

		private Control _element_5__2;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_013e;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_01c0;
				}
				__8__1 = (__c__DisplayClass24_0)new __c__DisplayClass24_0();
				__8__1.__4__this = __4__this;
				if (bedrockMaterialPackBrowser._service != null)
				{
					ref Control reference = ref _element_5__2;
					object obj = sender;
					reference = (Control)((obj is Control) ? obj : null);
					if (_element_5__2 != null)
					{
						object tag = ((FrameworkElement)_element_5__2).Tag;
						__8__1.packId = tag as string;
						if (__8__1.packId != null)
						{
							BedrockMaterialPackViewModel bedrockMaterialPackViewModel = Enumerable.FirstOrDefault<BedrockMaterialPackViewModel>((global::System.Collections.Generic.IEnumerable<BedrockMaterialPackViewModel>)bedrockMaterialPackBrowser.Packs, (Func<BedrockMaterialPackViewModel, bool>)__8__1._DeleteButton_Click_b__0);
							if (bedrockMaterialPackViewModel != null && bedrockMaterialPackViewModel.CanDelete)
							{
								_u__ = AppShell.ConfirmAsync("删除材质包", "确定删除“" + bedrockMaterialPackViewModel.Name + "”吗？此操作会移除 Chronal 保存的材质文件。").GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _DeleteButton_Click_d__24>(ref _u__, ref this);
									return;
								}
								goto IL_013e;
							}
						}
					}
				}
				goto end_IL_0011;
				IL_01c0:
				_u__2.GetResult();
				goto end_IL_0011;
				IL_013e:
				if (_u__.GetResult())
				{
					_u__2 = bedrockMaterialPackBrowser.RunChangeAsync(_element_5__2, __8__1._DeleteButton_Click_b__1).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _DeleteButton_Click_d__24>(ref _u__2, ref this);
						return;
					}
					goto IL_01c0;
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				_element_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			_element_5__2 = null;
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
	private struct _EnabledButton_Click_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_010a;
				}
				__c__DisplayClass18_0_1 _c__DisplayClass18_0_ = (__c__DisplayClass18_0_1)new __c__DisplayClass18_0_1
				{
					__4__this = __4__this
				};
				if (!bedrockMaterialPackBrowser._synchronizing && bedrockMaterialPackBrowser._service != null)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						_c__DisplayClass18_0_.packId = tag as string;
						if (_c__DisplayClass18_0_.packId != null)
						{
							_c__DisplayClass18_0_.current = Enumerable.FirstOrDefault<BedrockMaterialPackViewModel>((global::System.Collections.Generic.IEnumerable<BedrockMaterialPackViewModel>)bedrockMaterialPackBrowser.Packs, (Func<BedrockMaterialPackViewModel, bool>)_c__DisplayClass18_0_._EnabledButton_Click_b__0);
							if (_c__DisplayClass18_0_.current != null)
							{
								_u__ = bedrockMaterialPackBrowser.RunChangeAsync((Control)(object)val, _c__DisplayClass18_0_._EnabledButton_Click_b__1).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EnabledButton_Click_d__18>(ref _u__, ref this);
									return;
								}
								goto IL_010a;
							}
						}
					}
				}
				goto end_IL_0011;
				IL_010a:
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
	private struct _ExportButton_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public object sender;

		private __c__DisplayClass23_0_1 __8__1;

		private BedrockMaterialPackViewModel _pack_5__2;

		private CancellationTokenSource _cancellation_5__3;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
					goto IL_013f;
				}
				if (num == 1)
				{
					goto IL_015e;
				}
				__8__1 = (__c__DisplayClass23_0_1)new __c__DisplayClass23_0_1();
				if (bedrockMaterialPackBrowser._service != null && bedrockMaterialPackBrowser._operationCancellation == null)
				{
					object obj = sender;
					Control val = (Control)((obj is Control) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						__8__1.packId = tag as string;
						if (__8__1.packId != null)
						{
							_pack_5__2 = Enumerable.FirstOrDefault<BedrockMaterialPackViewModel>((global::System.Collections.Generic.IEnumerable<BedrockMaterialPackViewModel>)bedrockMaterialPackBrowser.Packs, (Func<BedrockMaterialPackViewModel, bool>)__8__1._ExportButton_Click_b__0);
							if (_pack_5__2 != null)
							{
								_u__ = DesktopFilePicker.PickSaveFileAsync(AppShell.WindowHandle, (PickerLocationId)3, SanitizeFileName(_pack_5__2.Name), new global::__z__ReadOnlySingleElementList_1<DesktopFileTypeChoice>((DesktopFileTypeChoice)new DesktopFileTypeChoice("Minecraft 材质包", (global::System.Collections.Generic.IReadOnlyList<string>)new global::__z__ReadOnlySingleElementList_1<string>(".mcpack"))), "导出材质包").GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ExportButton_Click_d__23>(ref _u__, ref this);
									return;
								}
								goto IL_013f;
							}
						}
					}
				}
				goto end_IL_0011;
				IL_015e:
				string result = default(string);
				try
				{
					if (num != 1)
					{
						bedrockMaterialPackBrowser._operationCancellation = _cancellation_5__3;
						bedrockMaterialPackBrowser.SetBusy(isBusy: true, "正在导出材质包：" + _pack_5__2.Name);
					}
					try
					{
						TaskAwaiter _u__2 = default;
						if (num != 1)
						{
							_u__2 = bedrockMaterialPackBrowser._service.qwRX5ECVgaM(__8__1.packId, result, _cancellation_5__3.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ExportButton_Click_d__23>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
						}
						_u__2.GetResult();
						AppShell.Success("已导出材质包：" + _pack_5__2.Name);
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception exception)
					{
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ExportButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockMaterialPackBrowser.xaml.cs", 303));
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockMaterialPackBrowser._operationCancellation == _cancellation_5__3)
							{
								bedrockMaterialPackBrowser._operationCancellation = null;
							}
							bedrockMaterialPackBrowser.SetBusy(isBusy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__3 != null)
					{
						((global::System.IDisposable)_cancellation_5__3).Dispose();
					}
				}
				goto end_IL_0011;
				IL_013f:
				result = _u__.GetResult();
				if (result != null)
				{
					_cancellation_5__3 = new CancellationTokenSource();
					goto IL_015e;
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__8__1 = null;
				_pack_5__2 = null;
				_cancellation_5__3 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			_pack_5__2 = null;
			_cancellation_5__3 = null;
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
	private struct _FontOverrideButton_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_010a;
				}
				__c__DisplayClass19_0_1 _c__DisplayClass19_0_ = (__c__DisplayClass19_0_1)new __c__DisplayClass19_0_1
				{
					__4__this = __4__this
				};
				if (!bedrockMaterialPackBrowser._synchronizing && bedrockMaterialPackBrowser._service != null)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						_c__DisplayClass19_0_.packId = tag as string;
						if (_c__DisplayClass19_0_.packId != null)
						{
							_c__DisplayClass19_0_.current = Enumerable.FirstOrDefault<BedrockMaterialPackViewModel>((global::System.Collections.Generic.IEnumerable<BedrockMaterialPackViewModel>)bedrockMaterialPackBrowser.Packs, (Func<BedrockMaterialPackViewModel, bool>)_c__DisplayClass19_0_._FontOverrideButton_Click_b__0);
							if (_c__DisplayClass19_0_.current != null)
							{
								_u__ = bedrockMaterialPackBrowser.RunChangeAsync((Control)(object)val, _c__DisplayClass19_0_._FontOverrideButton_Click_b__1).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _FontOverrideButton_Click_d__19>(ref _u__, ref this);
									return;
								}
								goto IL_010a;
							}
						}
					}
				}
				goto end_IL_0011;
				IL_010a:
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
	private struct _ImportArchiveButton_Click_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		private __c__DisplayClass14_0 __8__1;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
					goto IL_00e1;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0175;
				}
				__8__1 = (__c__DisplayClass14_0)new __c__DisplayClass14_0();
				__8__1.__4__this = __4__this;
				if (bedrockMaterialPackBrowser._service != null && bedrockMaterialPackBrowser._operationCancellation == null)
				{
					_u__ = DesktopFilePicker.PickOpenFileAsync(AppShell.WindowHandle, (PickerLocationId)3, new global::__z__ReadOnlyArray_1<string>(new string[4] { ".mcpack", ".zip", ".rar", ".7z" }), "导入材质包文件").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ImportArchiveButton_Click_d__14>(ref _u__, ref this);
						return;
					}
					goto IL_00e1;
				}
				goto end_IL_0011;
				IL_00e1:
				string result = _u__.GetResult();
				__8__1.path = result;
				if (__8__1.path != null)
				{
					_u__2 = bedrockMaterialPackBrowser.ImportAsync(__8__1._ImportArchiveButton_Click_b__0).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ImportArchiveButton_Click_d__14>(ref _u__2, ref this);
						return;
					}
					goto IL_0175;
				}
				goto end_IL_0011;
				IL_0175:
				_u__2.GetResult();
				end_IL_0011:;
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
	private struct _ImportAsync_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public Func<CancellationToken, global::System.Threading.Tasks.Task<WQh695fa8bRtqyh4inIH>> import;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter<WQh695fa8bRtqyh4inIH> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				if ((uint)num > 1u)
				{
					_cancellation_5__2 = new CancellationTokenSource();
				}
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_01a8;
						}
						bedrockMaterialPackBrowser._operationCancellation = _cancellation_5__2;
						bedrockMaterialPackBrowser.SetBusy(isBusy: true, "正在导入并校验材质包");
					}
					try
					{
						TaskAwaiter<WQh695fa8bRtqyh4inIH> _u__2 = default;
						if (num != 0)
						{
							_u__2 = import.Invoke(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<WQh695fa8bRtqyh4inIH>, _ImportAsync_d__16>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<WQh695fa8bRtqyh4inIH>);
							num = (__1__state = -1);
						}
						WQh695fa8bRtqyh4inIH result = _u__2.GetResult();
						bedrockMaterialPackBrowser._loaded = false;
						AppShell.Success("已导入材质包：" + result.Name);
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception exception)
					{
						bedrockMaterialPackBrowser.StatusText.Text = AppShell.GetExceptionDisplayMessage(exception, "ImportAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockMaterialPackBrowser.xaml.cs", 200);
						AppShell.Error(bedrockMaterialPackBrowser.StatusText.Text);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockMaterialPackBrowser._operationCancellation == _cancellation_5__2)
							{
								bedrockMaterialPackBrowser._operationCancellation = null;
							}
							bedrockMaterialPackBrowser.SetBusy(isBusy: false);
						}
					}
					_u__ = bedrockMaterialPackBrowser.LoadAsync(force: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ImportAsync_d__16>(ref _u__, ref this);
						return;
					}
					goto IL_01a8;
					IL_01a8:
					_u__.GetResult();
				}
				finally
				{
					if (num < 0 && _cancellation_5__2 != null)
					{
						((global::System.IDisposable)_cancellation_5__2).Dispose();
					}
				}
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
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
	private struct _ImportFolderButton_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		private __c__DisplayClass15_0 __8__1;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
					goto IL_00b6;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_014a;
				}
				__8__1 = (__c__DisplayClass15_0)new __c__DisplayClass15_0();
				__8__1.__4__this = __4__this;
				if (bedrockMaterialPackBrowser._service != null && bedrockMaterialPackBrowser._operationCancellation == null)
				{
					_u__ = DesktopFilePicker.PickFolderAsync(AppShell.WindowHandle, (PickerLocationId)3, "导入材质包文件夹").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ImportFolderButton_Click_d__15>(ref _u__, ref this);
						return;
					}
					goto IL_00b6;
				}
				goto end_IL_0011;
				IL_00b6:
				string result = _u__.GetResult();
				__8__1.path = result;
				if (__8__1.path != null)
				{
					_u__2 = bedrockMaterialPackBrowser.ImportAsync(__8__1._ImportFolderButton_Click_b__0).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ImportFolderButton_Click_d__15>(ref _u__2, ref this);
						return;
					}
					goto IL_014a;
				}
				goto end_IL_0011;
				IL_014a:
				_u__2.GetResult();
				end_IL_0011:;
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
	private struct _LoadAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public bool force;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0054;
				}
				if (bedrockMaterialPackBrowser._service != null && (!bedrockMaterialPackBrowser._loaded || force) && bedrockMaterialPackBrowser._operationCancellation == null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0054;
				}
				goto end_IL_0011;
				IL_0054:
				try
				{
					if (num != 0)
					{
						bedrockMaterialPackBrowser._operationCancellation = _cancellation_5__2;
						bedrockMaterialPackBrowser.SetBusy(isBusy: true, "正在读取材质包");
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>> _u__;
						if (num != 0)
						{
							_u__ = bedrockMaterialPackBrowser._service.u3HX5Ttsxq1(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>>, _LoadAsync_d__11>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>>);
							num = (__1__state = -1);
						}
						global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH> result = _u__.GetResult();
						if (!_cancellation_5__2.IsCancellationRequested)
						{
							bedrockMaterialPackBrowser.UpdateList(result);
							bedrockMaterialPackBrowser._loaded = true;
						}
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception exception)
					{
						bedrockMaterialPackBrowser.StatusText.Text = AppShell.GetExceptionDisplayMessage(exception, "LoadAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockMaterialPackBrowser.xaml.cs", 77);
						AppShell.Error(bedrockMaterialPackBrowser.StatusText.Text);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockMaterialPackBrowser._operationCancellation == _cancellation_5__2)
							{
								bedrockMaterialPackBrowser._operationCancellation = null;
							}
							bedrockMaterialPackBrowser.SetBusy(isBusy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__2 != null)
					{
						((global::System.IDisposable)_cancellation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
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
	private struct _MoveAsync_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public int offset;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00de;
				}
				__c__DisplayClass22_0 _c__DisplayClass22_ = (__c__DisplayClass22_0)new __c__DisplayClass22_0
				{
					__4__this = __4__this,
					offset = offset
				};
				if (bedrockMaterialPackBrowser._service != null)
				{
					object obj = sender;
					Control val = (Control)((obj is Control) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						_c__DisplayClass22_.packId = tag as string;
						if (_c__DisplayClass22_.packId != null)
						{
							_u__ = bedrockMaterialPackBrowser.RunChangeAsync(val, _c__DisplayClass22_._MoveAsync_b__0).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _MoveAsync_d__22>(ref _u__, ref this);
								return;
							}
							goto IL_00de;
						}
					}
				}
				goto end_IL_0011;
				IL_00de:
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
	private struct _MoveDownButton_Click_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockMaterialPackBrowser.MoveAsync(sender, 1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _MoveDownButton_Click_d__21>(ref _u__, ref this);
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
	private struct _MoveUpButton_Click_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockMaterialPackBrowser.MoveAsync(sender, -1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _MoveUpButton_Click_d__20>(ref _u__, ref this);
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
	private struct _RefreshButton_Click_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					bedrockMaterialPackBrowser._loaded = false;
					_u__ = bedrockMaterialPackBrowser.LoadAsync(force: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__17>(ref _u__, ref this);
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
	private struct _RunChangeAsync_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockMaterialPackBrowser __4__this;

		public Control initiator;

		public Func<CancellationToken, global::System.Threading.Tasks.Task> change;

		private CancellationTokenSource _cancellation_5__2;

		private bool _wasEnabled_5__3;

		private TaskAwaiter __u__1;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockMaterialPackBrowser bedrockMaterialPackBrowser = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_003f;
				}
				if (bedrockMaterialPackBrowser._operationCancellation == null && bedrockMaterialPackBrowser._service != null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_003f;
				}
				goto end_IL_0011;
				IL_003f:
				try
				{
					if ((uint)num > 1u)
					{
						bedrockMaterialPackBrowser._operationCancellation = _cancellation_5__2;
						_wasEnabled_5__3 = initiator.IsEnabled;
						initiator.IsEnabled = false;
						bedrockMaterialPackBrowser.SetBusy(isBusy: true, "正在保存设置", lockList: false);
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>> _u__;
						TaskAwaiter _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>>);
								num = (__1__state = -1);
								goto IL_0162;
							}
							_u__2 = change.Invoke(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunChangeAsync_d__25>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter);
							num = (__1__state = -1);
						}
						_u__2.GetResult();
						_u__ = bedrockMaterialPackBrowser._service.u3HX5Ttsxq1(_cancellation_5__2.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH>>, _RunChangeAsync_d__25>(ref _u__, ref this);
							return;
						}
						goto IL_0162;
						IL_0162:
						global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH> result = _u__.GetResult();
						if (!_cancellation_5__2.IsCancellationRequested)
						{
							bedrockMaterialPackBrowser.UpdateList(result);
							bedrockMaterialPackBrowser._loaded = true;
						}
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception exception)
					{
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "RunChangeAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockMaterialPackBrowser.xaml.cs", 364));
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockMaterialPackBrowser._operationCancellation == _cancellation_5__2)
							{
								bedrockMaterialPackBrowser._operationCancellation = null;
							}
							initiator.IsEnabled = _wasEnabled_5__3;
							bedrockMaterialPackBrowser.SetBusy(isBusy: false, null, lockList: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__2 != null)
					{
						((global::System.IDisposable)_cancellation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
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

	private da18CdX55laNMRKtM3p0? _service;

	private CancellationTokenSource? _operationCancellation;

	private bool _synchronizing;

	private bool _loaded;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView PackList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ImportArchiveButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ImportFolderButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockMaterialPackBrowser_Bindings Bindings;

	[CompilerGenerated]
	private ObservableCollection<BedrockMaterialPackViewModel> _Packs_k__BackingField;
	public ObservableCollection<BedrockMaterialPackViewModel> Packs
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Packs_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockMaterialPackBrowser()
	{
		_Packs_k__BackingField = new ObservableCollection<BedrockMaterialPackViewModel>();
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Attach(da18CdX55laNMRKtM3p0 service)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)service, "service");
		if (_service != null)
		{
			_service.MaterialPacksChanged -= new EventHandler(OnMaterialPacksChanged);
		}
		_service = service;
		_service.MaterialPacksChanged += new EventHandler(OnMaterialPacksChanged);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetOperationRunning(bool isRunning)
	{
		if (_operationCancellation == null)
		{
			SetBusy(isRunning, isRunning ? "客户端操作进行中" : null);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task LoadAsync(bool force = false)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__11 loadAsync_d__ = default(_LoadAsync_d__11);
		loadAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__.__4__this = this;
		loadAsync_d__.force = force;
		loadAsync_d__.__1__state = -1;
		loadAsync_d__.__t__builder.Start<_LoadAsync_d__11>(ref loadAsync_d__);
		return loadAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateList(global::System.Collections.Generic.IReadOnlyList<WQh695fa8bRtqyh4inIH> packs)
	{
		_synchronizing = true;
		try
		{
			WQh695fa8bRtqyh4inIH[] array = Enumerable.ToArray<WQh695fa8bRtqyh4inIH>((global::System.Collections.Generic.IEnumerable<WQh695fa8bRtqyh4inIH>)Enumerable.OrderBy<WQh695fa8bRtqyh4inIH, int>((global::System.Collections.Generic.IEnumerable<WQh695fa8bRtqyh4inIH>)packs, (Func<WQh695fa8bRtqyh4inIH, int>)([MethodImpl((MethodImplOptions)8)] (WQh695fa8bRtqyh4inIH item) => item.Priority)));
			HashSet<string> val = Enumerable.ToHashSet<string>(Enumerable.Select<WQh695fa8bRtqyh4inIH, string>((global::System.Collections.Generic.IEnumerable<WQh695fa8bRtqyh4inIH>)array, (Func<WQh695fa8bRtqyh4inIH, string>)([MethodImpl((MethodImplOptions)8)] (WQh695fa8bRtqyh4inIH pack) => pack.Id)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
			for (int num = ((Collection<BedrockMaterialPackViewModel>)(object)Packs).Count - 1; num >= 0; num--)
			{
				if (!val.Contains(((Collection<BedrockMaterialPackViewModel>)(object)Packs)[num].Id))
				{
					((Collection<BedrockMaterialPackViewModel>)(object)Packs).RemoveAt(num);
				}
			}
			for (int num2 = 0; num2 < array.Length; num2++)
			{
				WQh695fa8bRtqyh4inIH val2 = array[num2];
				int num3 = FindPackIndex(val2.Id);
				if (num3 < 0)
				{
					((Collection<BedrockMaterialPackViewModel>)(object)Packs).Insert(num2, (BedrockMaterialPackViewModel)new BedrockMaterialPackViewModel(val2));
					continue;
				}
				((Collection<BedrockMaterialPackViewModel>)(object)Packs)[num3].Replace(val2);
				if (num3 != num2)
				{
					Packs.Move(num3, num2);
				}
			}
			for (int num4 = 0; num4 < ((Collection<BedrockMaterialPackViewModel>)(object)Packs).Count; num4++)
			{
				((Collection<BedrockMaterialPackViewModel>)(object)Packs)[num4].SetPosition(num4, ((Collection<BedrockMaterialPackViewModel>)(object)Packs).Count);
			}
			((UIElement)EmptyPanel).Visibility = (((((Collection<BedrockMaterialPackViewModel>)(object)Packs).Count != 0)) ? Visibility.Visible : Visibility.Collapsed);
			int num5 = Enumerable.Count<BedrockMaterialPackViewModel>((global::System.Collections.Generic.IEnumerable<BedrockMaterialPackViewModel>)Packs, (Func<BedrockMaterialPackViewModel, bool>)([MethodImpl((MethodImplOptions)8)] (BedrockMaterialPackViewModel item) => item.IsEnabled));
			StatusText.Text = ((((Collection<BedrockMaterialPackViewModel>)(object)Packs).Count == 0) ? "尚未导入材质包" : $"共 {((Collection<BedrockMaterialPackViewModel>)(object)Packs).Count} 个材质包，已启用 {num5} 个");
		}
		finally
		{
			_synchronizing = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private int FindPackIndex(string packId)
	{
		for (int i = 0; i < ((Collection<BedrockMaterialPackViewModel>)(object)Packs).Count; i++)
		{
			if (((Collection<BedrockMaterialPackViewModel>)(object)Packs)[i].Id.Equals(packId, (StringComparison)5))
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ImportArchiveButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ImportArchiveButton_Click_d__14 importArchiveButton_Click_d__ = default(_ImportArchiveButton_Click_d__14);
		importArchiveButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		importArchiveButton_Click_d__.__4__this = this;
		importArchiveButton_Click_d__.__1__state = -1;
		importArchiveButton_Click_d__.__t__builder.Start<_ImportArchiveButton_Click_d__14>(ref importArchiveButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ImportFolderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ImportFolderButton_Click_d__15 importFolderButton_Click_d__ = default(_ImportFolderButton_Click_d__15);
		importFolderButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		importFolderButton_Click_d__.__4__this = this;
		importFolderButton_Click_d__.__1__state = -1;
		importFolderButton_Click_d__.__t__builder.Start<_ImportFolderButton_Click_d__15>(ref importFolderButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ImportAsync(Func<CancellationToken, global::System.Threading.Tasks.Task<WQh695fa8bRtqyh4inIH>> import)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ImportAsync_d__16 importAsync_d__ = default(_ImportAsync_d__16);
		importAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		importAsync_d__.__4__this = this;
		importAsync_d__.import = import;
		importAsync_d__.__1__state = -1;
		importAsync_d__.__t__builder.Start<_ImportAsync_d__16>(ref importAsync_d__);
		return importAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__17 refreshButton_Click_d__ = default(_RefreshButton_Click_d__17);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__17>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void EnabledButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_EnabledButton_Click_d__18 enabledButton_Click_d__ = default(_EnabledButton_Click_d__18);
		enabledButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		enabledButton_Click_d__.__4__this = this;
		enabledButton_Click_d__.sender = sender;
		enabledButton_Click_d__.__1__state = -1;
		enabledButton_Click_d__.__t__builder.Start<_EnabledButton_Click_d__18>(ref enabledButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void FontOverrideButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_FontOverrideButton_Click_d__19 fontOverrideButton_Click_d__ = default(_FontOverrideButton_Click_d__19);
		fontOverrideButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		fontOverrideButton_Click_d__.__4__this = this;
		fontOverrideButton_Click_d__.sender = sender;
		fontOverrideButton_Click_d__.__1__state = -1;
		fontOverrideButton_Click_d__.__t__builder.Start<_FontOverrideButton_Click_d__19>(ref fontOverrideButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void MoveUpButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_MoveUpButton_Click_d__20 moveUpButton_Click_d__ = default(_MoveUpButton_Click_d__20);
		moveUpButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		moveUpButton_Click_d__.__4__this = this;
		moveUpButton_Click_d__.sender = sender;
		moveUpButton_Click_d__.__1__state = -1;
		moveUpButton_Click_d__.__t__builder.Start<_MoveUpButton_Click_d__20>(ref moveUpButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void MoveDownButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_MoveDownButton_Click_d__21 moveDownButton_Click_d__ = default(_MoveDownButton_Click_d__21);
		moveDownButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		moveDownButton_Click_d__.__4__this = this;
		moveDownButton_Click_d__.sender = sender;
		moveDownButton_Click_d__.__1__state = -1;
		moveDownButton_Click_d__.__t__builder.Start<_MoveDownButton_Click_d__21>(ref moveDownButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task MoveAsync(object sender, int offset)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_MoveAsync_d__22 moveAsync_d__ = default(_MoveAsync_d__22);
		moveAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		moveAsync_d__.__4__this = this;
		moveAsync_d__.sender = sender;
		moveAsync_d__.offset = offset;
		moveAsync_d__.__1__state = -1;
		moveAsync_d__.__t__builder.Start<_MoveAsync_d__22>(ref moveAsync_d__);
		return moveAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ExportButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ExportButton_Click_d__23 exportButton_Click_d__ = default(_ExportButton_Click_d__23);
		exportButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		exportButton_Click_d__.__4__this = this;
		exportButton_Click_d__.sender = sender;
		exportButton_Click_d__.__1__state = -1;
		exportButton_Click_d__.__t__builder.Start<_ExportButton_Click_d__23>(ref exportButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DeleteButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DeleteButton_Click_d__24 deleteButton_Click_d__ = default(_DeleteButton_Click_d__24);
		deleteButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		deleteButton_Click_d__.__4__this = this;
		deleteButton_Click_d__.sender = sender;
		deleteButton_Click_d__.__1__state = -1;
		deleteButton_Click_d__.__t__builder.Start<_DeleteButton_Click_d__24>(ref deleteButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunChangeAsync(Control initiator, Func<CancellationToken, global::System.Threading.Tasks.Task> change)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunChangeAsync_d__25 runChangeAsync_d__ = default(_RunChangeAsync_d__25);
		runChangeAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runChangeAsync_d__.__4__this = this;
		runChangeAsync_d__.initiator = initiator;
		runChangeAsync_d__.change = change;
		runChangeAsync_d__.__1__state = -1;
		runChangeAsync_d__.__t__builder.Start<_RunChangeAsync_d__25>(ref runChangeAsync_d__);
		return runChangeAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string SanitizeFileName(string name)
	{
		__c__DisplayClass26_0 __8_locals2 = (__c__DisplayClass26_0)new __c__DisplayClass26_0();
		__8_locals2.invalid = Path.GetInvalidFileNameChars();
		string text = new string(Enumerable.ToArray<char>(Enumerable.Where<char>((global::System.Collections.Generic.IEnumerable<char>)name, (Func<char, bool>)([MethodImpl((MethodImplOptions)8)] (char character) => !Enumerable.Contains<char>((global::System.Collections.Generic.IEnumerable<char>)__8_locals2.invalid, character))))).Trim();
		if (!string.IsNullOrWhiteSpace(text))
		{
			return text;
		}
		return "material-pack";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnMaterialPacksChanged(object? sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		if (_operationCancellation != null)
		{
			_loaded = false;
			return;
		}
		((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] () =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__OnMaterialPacksChanged_b__27_0_d _OnMaterialPacksChanged_b__27_0_d = default(__OnMaterialPacksChanged_b__27_0_d);
			_OnMaterialPacksChanged_b__27_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_OnMaterialPacksChanged_b__27_0_d.__4__this = this;
			_OnMaterialPacksChanged_b__27_0_d.__1__state = -1;
			_OnMaterialPacksChanged_b__27_0_d.__t__builder.Start<__OnMaterialPacksChanged_b__27_0_d>(ref _OnMaterialPacksChanged_b__27_0_d);
		}));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetBusy(bool isBusy, string? status = null, bool lockList = true)
	{
		((Control)ImportArchiveButton).IsEnabled = !isBusy;
		((Control)ImportFolderButton).IsEnabled = !isBusy;
		((Control)RefreshButton).IsEnabled = !isBusy;
		if (lockList)
		{
			((Control)PackList).IsEnabled = !isBusy;
		}
		if (!string.IsNullOrWhiteSpace(status))
		{
			StatusText.Text = status;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			if (_service != null)
			{
				_service.MaterialPacksChanged -= new EventHandler(OnMaterialPacksChanged);
			}
			CancellationTokenSource? operationCancellation = _operationCancellation;
			if (operationCancellation != null)
			{
				operationCancellation.Cancel();
			}
			CancellationTokenSource? operationCancellation2 = _operationCancellation;
			if (operationCancellation2 != null)
			{
				operationCancellation2.Dispose();
			}
		}
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockMaterialPackBrowser.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			PackList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 6:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(MoveUpButton_Click);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(MoveDownButton_Click);
			break;
		case 8:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ExportButton_Click);
			break;
		case 9:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DeleteButton_Click);
			break;
		case 10:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(EnabledButton_Click);
			break;
		case 11:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(FontOverrideButton_Click);
			break;
		case 17:
			ImportArchiveButton = CastExtensions.As<Button>(target);
			((ButtonBase)ImportArchiveButton).Click += new RoutedEventHandler(ImportArchiveButton_Click);
			break;
		case 18:
			ImportFolderButton = CastExtensions.As<Button>(target);
			((ButtonBase)ImportFolderButton).Click += new RoutedEventHandler(ImportFolderButton_Click);
			break;
		case 19:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 20:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 1:
		{
			UserControl val2 = (UserControl)target;
			BedrockMaterialPackBrowser_obj1_Bindings bedrockMaterialPackBrowser_obj1_Bindings = (BedrockMaterialPackBrowser_obj1_Bindings)new BedrockMaterialPackBrowser_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockMaterialPackBrowser_obj1_Bindings;
			bedrockMaterialPackBrowser_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockMaterialPackBrowser_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockMaterialPackBrowser_obj1_Bindings.Loading;
			break;
		}
		case 5:
		{
			Border val = (Border)target;
			BedrockMaterialPackBrowser_obj5_Bindings bedrockMaterialPackBrowser_obj5_Bindings = (BedrockMaterialPackBrowser_obj5_Bindings)new BedrockMaterialPackBrowser_obj5_Bindings();
			result = (IComponentConnector)(object)bedrockMaterialPackBrowser_obj5_Bindings;
			bedrockMaterialPackBrowser_obj5_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockMaterialPackBrowser_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockMaterialPackBrowser_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockMaterialPackBrowser_obj5_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void _OnMaterialPacksChanged_b__27_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__OnMaterialPacksChanged_b__27_0_d _OnMaterialPacksChanged_b__27_0_d = default(__OnMaterialPacksChanged_b__27_0_d);
		_OnMaterialPacksChanged_b__27_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		_OnMaterialPacksChanged_b__27_0_d.__4__this = this;
		_OnMaterialPacksChanged_b__27_0_d.__1__state = -1;
		_OnMaterialPacksChanged_b__27_0_d.__t__builder.Start<__OnMaterialPacksChanged_b__27_0_d>(ref _OnMaterialPacksChanged_b__27_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

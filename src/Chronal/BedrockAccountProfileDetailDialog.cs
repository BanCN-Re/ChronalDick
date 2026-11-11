using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using WinRT;
using WinRT.ChronalVtableClasses;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_UserRefundRequestDialogWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockAccountProfileDetailDialog : ContentDialog, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockAccountProfileDetailDialog_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockAccountProfileDetailDialog_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_ContentDialog_Title(ContentDialog obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.Title = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(UIElement obj, Visibility value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Visibility = value;
		}

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
		public static void Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(Control obj, bool value)
		{
			obj.IsEnabled = value;
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

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class BedrockAccountProfileDetailDialog_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockAccountProfileDetailDialog_Bindings
	{
		private BedrockProfileStatisticViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private TextBlock obj6;

		private TextBlock obj7;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockAccountProfileDetailDialog_obj5_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			switch (connectionId)
			{
			case 5:
				obj5 = new WeakReference((object)CastExtensions.As<Grid>(target));
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
			object target = obj5.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BedrockProfileStatisticViewModel>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<BedrockProfileStatisticViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockProfileStatisticViewModel obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Label(obj.Label, phase);
				Update_Value(obj.Value, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Label(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Value(string obj, int phase)
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
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	private class BedrockAccountProfileDetailDialog_obj1_Bindings : IComponentConnector, IBedrockAccountProfileDetailDialog_Bindings
	{
		private BedrockAccountProfileDetailDialog dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private WeakReference obj1;

		private TextBlock obj2;

		private ItemsControl obj3;

		private TextBlock obj8;

		private TextBlock obj9;

		private TextBlock obj10;

		private TextBlock obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private Button obj14;

		private TextBlock obj15;

		private Image obj16;

		private TextBlock obj17;

		private Image obj18;

		private TextBlock obj19;

		private TextBlock obj20;

		private TextBlock obj21;

		private TextBlock obj22;

		private Image obj23;

		private Image obj24;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockAccountProfileDetailDialog_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected O, but got Unknown
			switch (connectionId)
			{
			case 1:
				obj1 = new WeakReference((object)CastExtensions.As<ContentDialog>(target));
				break;
			case 2:
				obj2 = CastExtensions.As<TextBlock>(target);
				break;
			case 3:
				obj3 = CastExtensions.As<ItemsControl>(target);
				break;
			case 8:
				obj8 = CastExtensions.As<TextBlock>(target);
				break;
			case 9:
				obj9 = CastExtensions.As<TextBlock>(target);
				break;
			case 10:
				obj10 = CastExtensions.As<TextBlock>(target);
				break;
			case 11:
				obj11 = CastExtensions.As<TextBlock>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<TextBlock>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<Button>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<TextBlock>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<Image>(target);
				break;
			case 17:
				obj17 = CastExtensions.As<TextBlock>(target);
				break;
			case 18:
				obj18 = CastExtensions.As<Image>(target);
				break;
			case 19:
				obj19 = CastExtensions.As<TextBlock>(target);
				break;
			case 20:
				obj20 = CastExtensions.As<TextBlock>(target);
				break;
			case 21:
				obj21 = CastExtensions.As<TextBlock>(target);
				break;
			case 22:
				obj22 = CastExtensions.As<TextBlock>(target);
				break;
			case 23:
				obj23 = CastExtensions.As<Image>(target);
				break;
			case 24:
				obj24 = CastExtensions.As<Image>(target);
				break;
			case 4:
			case 5:
			case 6:
			case 7:
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
				dataRoot = CastExtensions.As<BedrockAccountProfileDetailDialog>(newDataRoot);
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
		private void Update_(BedrockAccountProfileDetailDialog obj, int phase)
		{
			if ((ContentDialog)(object)obj != (ContentDialog)null && (phase & -2147483647) != 0)
			{
				Update_ViewModel(obj.ViewModel, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel(BedrockAccountProfileDetailViewModel obj, int phase)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_ViewModel_TitleText(obj.TitleText, phase);
				Update_ViewModel_MissingStatisticsVisibility(obj.MissingStatisticsVisibility, phase);
				Update_ViewModel_Statistics(obj.Statistics, phase);
				Update_ViewModel_StatisticsVisibility(obj.StatisticsVisibility, phase);
				Update_ViewModel_SignatureText(obj.SignatureText, phase);
				Update_ViewModel_TagsText(obj.TagsText, phase);
				Update_ViewModel_DeveloperVerificationText(obj.DeveloperVerificationText, phase);
				Update_ViewModel_FriendStatusText(obj.FriendStatusText, phase);
				Update_ViewModel_HomepageVisibilityText(obj.HomepageVisibilityText, phase);
				Update_ViewModel_MaskedLocationText(obj.MaskedLocationText, phase);
				Update_ViewModel_CanRevealLocation(obj.CanRevealLocation, phase);
				Update_ViewModel_VisitCardBackgroundText(obj.VisitCardBackgroundText, phase);
				Update_ViewModel_VisitCardBackgroundSource(obj.VisitCardBackgroundSource, phase);
				Update_ViewModel_VisitCardBackgroundImageVisibility(obj.VisitCardBackgroundImageVisibility, phase);
				Update_ViewModel_HomepageBackgroundText(obj.HomepageBackgroundText, phase);
				Update_ViewModel_HomepageBackgroundSource(obj.HomepageBackgroundSource, phase);
				Update_ViewModel_HomepageBackgroundImageVisibility(obj.HomepageBackgroundImageVisibility, phase);
				Update_ViewModel_DisplayName(obj.DisplayName, phase);
				Update_ViewModel_UserIdText(obj.UserIdText, phase);
				Update_ViewModel_GrowthText(obj.GrowthText, phase);
				Update_ViewModel_VipText(obj.VipText, phase);
				Update_ViewModel_FrameSource(obj.FrameSource, phase);
				Update_ViewModel_FrameVisibility(obj.FrameVisibility, phase);
				Update_ViewModel_AvatarSource(obj.AvatarSource, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_TitleText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0 && default(ContentDialog) != (ContentDialog)null)
			{
				object target = obj1.Target;
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentDialog_Title((ContentDialog)((target is ContentDialog) ? target : null), obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_MissingStatisticsVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj2, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_Statistics(global::System.Collections.Generic.IReadOnlyList<BedrockProfileStatisticViewModel> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(obj3, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_StatisticsVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj3, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_SignatureText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_TagsText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_DeveloperVerificationText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_FriendStatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_HomepageVisibilityText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_MaskedLocationText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_CanRevealLocation(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj14, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_VisitCardBackgroundText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj15, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_VisitCardBackgroundSource(BitmapImage obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(obj16, (ImageSource)(object)obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_VisitCardBackgroundImageVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj16, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_HomepageBackgroundText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_HomepageBackgroundSource(BitmapImage obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(obj18, (ImageSource)(object)obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_HomepageBackgroundImageVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj18, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_DisplayName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj19, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_UserIdText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj20, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_GrowthText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj21, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_VipText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_FrameSource(BitmapImage obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(obj23, (ImageSource)(object)obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_FrameVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj23, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ViewModel_AvatarSource(BitmapImage obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(obj24, (ImageSource)(object)obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private bool _locationRevealed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LocationText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ToggleLocationButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockAccountProfileDetailDialog_Bindings Bindings;

	[CompilerGenerated]
	private readonly BedrockAccountProfileDetailViewModel _ViewModel_k__BackingField;

	public BedrockAccountProfileDetailViewModel ViewModel
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ViewModel_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal BedrockAccountProfileDetailDialog(BedrockAccountHistoryItemViewModel account)
	{
		ArgumentNullException.ThrowIfNull((object)account, "account");
		_ViewModel_k__BackingField = (BedrockAccountProfileDetailViewModel)new BedrockAccountProfileDetailViewModel(account.Model);
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToggleLocationButton_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			_locationRevealed = !_locationRevealed;
			LocationText.Text = (_locationRevealed ? ViewModel.FullLocationText : ViewModel.MaskedLocationText);
			((ContentControl)ToggleLocationButton).Content = (_locationRevealed ? "隐藏" : "显示");
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ToggleLocationButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockAccountProfileDetailDialog.xaml.cs", 32));
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockAccountProfileDetailDialog.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		switch (connectionId)
		{
		case 13:
			LocationText = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			ToggleLocationButton = CastExtensions.As<Button>(target);
			((ButtonBase)ToggleLocationButton).Click += new RoutedEventHandler(ToggleLocationButton_Click);
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
			ContentDialog val2 = (ContentDialog)target;
			BedrockAccountProfileDetailDialog_obj1_Bindings bedrockAccountProfileDetailDialog_obj1_Bindings = (BedrockAccountProfileDetailDialog_obj1_Bindings)new BedrockAccountProfileDetailDialog_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockAccountProfileDetailDialog_obj1_Bindings;
			bedrockAccountProfileDetailDialog_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockAccountProfileDetailDialog_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockAccountProfileDetailDialog_obj1_Bindings.Loading;
			break;
		}
		case 5:
		{
			Grid val = (Grid)target;
			BedrockAccountProfileDetailDialog_obj5_Bindings bedrockAccountProfileDetailDialog_obj5_Bindings = (BedrockAccountProfileDetailDialog_obj5_Bindings)new BedrockAccountProfileDetailDialog_obj5_Bindings();
			result = (IComponentConnector)(object)bedrockAccountProfileDetailDialog_obj5_Bindings;
			bedrockAccountProfileDetailDialog_obj5_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockAccountProfileDetailDialog_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockAccountProfileDetailDialog_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockAccountProfileDetailDialog_obj5_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using L2DEuZfNT3YqTRfLBYFR;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using WinRT;
using WinRT.ChronalVtableClasses;
using e8MkG5fN2cxfOewkP8a7;
using krYsZbfNFb7hi3LZTnl3;
using oT8CDAfNv4ynntxXIrqs;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockAccountHistoryView : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockAccountHistoryView_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockAccountHistoryView_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(TextBlock obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Text = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(ButtonBase obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.CommandParameter = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(Control obj, bool value)
		{
			obj.IsEnabled = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(UIElement obj, Visibility value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Visibility = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_Primitives_RangeBase_Maximum(RangeBase obj, double value)
		{
			obj.Maximum = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_Primitives_RangeBase_Value(RangeBase obj, double value)
		{
			obj.Value = value;
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
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	private class BedrockAccountHistoryView_obj7_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockAccountHistoryView_Bindings
	{
		private BedrockAccountHistoryItemViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj7;

		private TextBlock obj8;

		private TextBlock obj9;

		private TextBlock obj10;

		private Button obj11;

		private Button obj12;

		private Button obj13;

		private StackPanel obj14;

		private TextBlock obj15;

		private ProgressBar obj16;

		private TextBlock obj17;

		private Border obj18;

		private TextBlock obj19;

		private TextBlock obj20;

		private TextBlock obj21;

		private TextBlock obj22;

		private Image obj23;

		private Image obj24;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockAccountHistoryView_obj7_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			switch (connectionId)
			{
			case 7:
				obj7 = new WeakReference((object)CastExtensions.As<Grid>(target));
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
				obj11 = CastExtensions.As<Button>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<Button>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<Button>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<StackPanel>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<TextBlock>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<ProgressBar>(target);
				break;
			case 17:
				obj17 = CastExtensions.As<TextBlock>(target);
				break;
			case 18:
				obj18 = CastExtensions.As<Border>(target);
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
			object target = obj7.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BedrockAccountHistoryItemViewModel>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<BedrockAccountHistoryItemViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockAccountHistoryItemViewModel obj, int phase)
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_AccountDisplayText(obj.AccountDisplayText, phase);
				Update_GameUserId(obj.GameUserId, phase);
				Update_SavedAtValueText(obj.SavedAtValueText, phase);
				Update_Id(obj.Id, phase);
				Update_IsDetailsEnabled(obj.IsDetailsEnabled, phase);
				Update_GrowthVisibility(obj.GrowthVisibility, phase);
				Update_MissingGrowthVisibility(obj.MissingGrowthVisibility, phase);
				Update_ExperienceMaximum(obj.ExperienceMaximum, phase);
				Update_ExperienceValue(obj.ExperienceValue, phase);
				Update_ExperienceText(obj.ExperienceText, phase);
				Update_VipVisibility(obj.VipVisibility, phase);
				Update_VipText(obj.VipText, phase);
				Update_LevelText(obj.LevelText, phase);
				Update_DisplayName(obj.DisplayName, phase);
				Update_SecondaryText(obj.SecondaryText, phase);
				Update_FrameSource(obj.FrameSource, phase);
				Update_FrameVisibility(obj.FrameVisibility, phase);
				Update_AvatarSource(obj.AvatarSource, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AccountDisplayText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_GameUserId(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_SavedAtValueText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Id(long obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj11, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj12, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IsDetailsEnabled(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj11, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_GrowthVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj14, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_MissingGrowthVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj15, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ExperienceMaximum(double obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_RangeBase_Maximum((RangeBase)(object)obj16, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ExperienceValue(double obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_RangeBase_Value((RangeBase)(object)obj16, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ExperienceText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_VipVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj18, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_VipText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj19, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_LevelText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj20, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DisplayName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj21, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_SecondaryText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj22, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_FrameSource(BitmapImage obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Image_Source(obj23, (ImageSource)(object)obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_FrameVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj23, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AvatarSource(BitmapImage obj, int phase)
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

	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class BedrockAccountHistoryView_obj1_Bindings : IComponentConnector, IBedrockAccountHistoryView_Bindings
	{
		private BedrockAccountHistoryView dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ListView obj2;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockAccountHistoryView_obj1_Bindings()
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
				dataRoot = CastExtensions.As<BedrockAccountHistoryView>(newDataRoot);
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
		private void Update_(BedrockAccountHistoryView obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -2147483647) != 0)
			{
				Update_Accounts(obj.Accounts, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Accounts(ObservableCollection<BedrockAccountHistoryItemViewModel> obj, int phase)
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

	[CompilerGenerated]
	private sealed class __c__DisplayClass17_0_1
	{
		public long recordId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass17_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _DetailsButton_Click_b__0(BedrockAccountHistoryItemViewModel item)
		{
			return item.Id == recordId;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass18_0_2
	{
		public long recordId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _DeleteButton_Click_b__0(BedrockAccountHistoryItemViewModel item)
		{
			return item.Id == recordId;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ClearAllButton_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockAccountHistoryView __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter<FVuSj3fNE4vonuR2pT1I> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountHistoryView bedrockAccountHistoryView = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00dc;
				}
				if (num == 1)
				{
					goto IL_0121;
				}
				int count = ((Collection<BedrockAccountHistoryItemViewModel>)(object)bedrockAccountHistoryView.Accounts).Count;
				if (count != 0 && !bedrockAccountHistoryView._isLoading && !bedrockAccountHistoryView._isOperationRunning)
				{
					_u__ = AppShell.ConfirmAsync("清空全部历史账号", $"将永久删除当前保存的 {count} 个历史账号及其已保存 SAuth，此操作无法撤销。", "全部清空").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ClearAllButton_Click_d__15>(ref _u__, ref this);
						return;
					}
					goto IL_00dc;
				}
				goto end_IL_0011;
				IL_0121:
				try
				{
					TaskAwaiter<FVuSj3fNE4vonuR2pT1I> _u__2 = default;
					if (num != 1)
					{
						_u__2 = AppShell.Api.Pj40IyFc2R().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<FVuSj3fNE4vonuR2pT1I>, _ClearAllButton_Click_d__15>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<FVuSj3fNE4vonuR2pT1I>);
						num = (__1__state = -1);
					}
					FVuSj3fNE4vonuR2pT1I result = _u__2.GetResult();
					if (!result.Ok)
					{
						throw new InvalidOperationException("服务端未确认历史账号清空结果");
					}
					bedrockAccountHistoryView.Clear();
					AppShell.Success($"已清空 {result.DeletedCount} 个历史账号");
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ClearAllButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockAccountHistoryView.xaml.cs", 148));
				}
				finally
				{
					if (num < 0)
					{
						bedrockAccountHistoryView._isLoading = false;
						bedrockAccountHistoryView.LoadingRing.IsActive = false;
						((UIElement)bedrockAccountHistoryView.LoadingRing).Visibility = (Visibility)1;
						bedrockAccountHistoryView.UpdateState();
					}
				}
				goto end_IL_0011;
				IL_00dc:
				if (_u__.GetResult())
				{
					bedrockAccountHistoryView._isLoading = true;
					bedrockAccountHistoryView._loadEpoch++;
					bedrockAccountHistoryView.LoadingRing.IsActive = true;
					((UIElement)bedrockAccountHistoryView.LoadingRing).Visibility = (Visibility)0;
					bedrockAccountHistoryView.UpdateState();
					goto IL_0121;
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__t__builder.SetException(exception2);
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
	private struct _DeleteButton_Click_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public BedrockAccountHistoryView __4__this;

		private __c__DisplayClass18_0_2 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter<TM0BIwfN3eaZW7xq1kmA> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountHistoryView bedrockAccountHistoryView = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_010b;
				}
				if (num == 1)
				{
					goto IL_011d;
				}
				__8__1 = (__c__DisplayClass18_0_2)new __c__DisplayClass18_0_2();
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object commandParameter = ((ButtonBase)val).CommandParameter;
					if (commandParameter is long)
					{
						__8__1.recordId = (long)commandParameter;
						BedrockAccountHistoryItemViewModel bedrockAccountHistoryItemViewModel = Enumerable.FirstOrDefault<BedrockAccountHistoryItemViewModel>((global::System.Collections.Generic.IEnumerable<BedrockAccountHistoryItemViewModel>)bedrockAccountHistoryView.Accounts, (Func<BedrockAccountHistoryItemViewModel, bool>)__8__1._DeleteButton_Click_b__0);
						if (bedrockAccountHistoryItemViewModel != null)
						{
							_u__ = AppShell.ConfirmAsync("删除历史账号", "确定删除 " + bedrockAccountHistoryItemViewModel.DisplayName + " 的历史记录和已保存 SAuth？").GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _DeleteButton_Click_d__18>(ref _u__, ref this);
								return;
							}
							goto IL_010b;
						}
					}
				}
				goto end_IL_0011;
				IL_011d:
				try
				{
					TaskAwaiter<TM0BIwfN3eaZW7xq1kmA> _u__2 = default;
					if (num != 1)
					{
						_u__2 = AppShell.Api.MCk0AJXLuI(__8__1.recordId).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TM0BIwfN3eaZW7xq1kmA>, _DeleteButton_Click_d__18>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<TM0BIwfN3eaZW7xq1kmA>);
						num = (__1__state = -1);
					}
					_u__2.GetResult();
					for (int num2 = ((Collection<BedrockAccountHistoryItemViewModel>)(object)bedrockAccountHistoryView.Accounts).Count - 1; num2 >= 0; num2--)
					{
						if (((Collection<BedrockAccountHistoryItemViewModel>)(object)bedrockAccountHistoryView.Accounts)[num2].Id == __8__1.recordId)
						{
							((Collection<BedrockAccountHistoryItemViewModel>)(object)bedrockAccountHistoryView.Accounts).RemoveAt(num2);
						}
					}
					bedrockAccountHistoryView.UpdateState();
					AppShell.Success("历史账号已删除");
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "DeleteButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockAccountHistoryView.xaml.cs", 231));
				}
				goto end_IL_0011;
				IL_010b:
				if (_u__.GetResult())
				{
					goto IL_011d;
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception2);
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
	private struct _DetailsButton_Click_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public BedrockAccountHistoryView __4__this;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountHistoryView bedrockAccountHistoryView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00a1;
				}
				__c__DisplayClass17_0_1 _c__DisplayClass17_0_ = (__c__DisplayClass17_0_1)new __c__DisplayClass17_0_1();
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				BedrockAccountHistoryItemViewModel bedrockAccountHistoryItemViewModel = default(BedrockAccountHistoryItemViewModel);
				if (val != null)
				{
					object commandParameter = ((ButtonBase)val).CommandParameter;
					if (commandParameter is long)
					{
						_c__DisplayClass17_0_.recordId = (long)commandParameter;
						bedrockAccountHistoryItemViewModel = Enumerable.FirstOrDefault<BedrockAccountHistoryItemViewModel>((global::System.Collections.Generic.IEnumerable<BedrockAccountHistoryItemViewModel>)bedrockAccountHistoryView.Accounts, (Func<BedrockAccountHistoryItemViewModel, bool>)_c__DisplayClass17_0_._DetailsButton_Click_b__0);
						if (((bedrockAccountHistoryItemViewModel != null) ? bedrockAccountHistoryItemViewModel.Model.Profile : null) != null)
						{
							goto IL_00a1;
						}
						AppShell.Warning("该历史账号尚未保存角色详情，请重新建立一次会话");
					}
				}
				goto end_IL_0011;
				IL_00a1:
					bedrockAccountHistoryItemViewModel = default;
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						object bedrockAccountProfileDetailDialog = (object)new BedrockAccountProfileDetailDialog(bedrockAccountHistoryItemViewModel);
						((UIElement)bedrockAccountProfileDetailDialog).XamlRoot = ((UIElement)bedrockAccountHistoryView).XamlRoot;
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(((ContentDialog)bedrockAccountProfileDetailDialog).ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _DetailsButton_Click_d__17>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "DetailsButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockAccountHistoryView.xaml.cs", 190));
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__t__builder.SetException(exception2);
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
	private struct _LoadAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockAccountHistoryView __4__this;

		private int _epoch_5__2;

		private TaskAwaiter<QMHkqHfNsSYLQ7K8Ejet> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockAccountHistoryView bedrockAccountHistoryView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0081;
				}
				if (!bedrockAccountHistoryView._isLoading && !bedrockAccountHistoryView._isOperationRunning)
				{
					_epoch_5__2 = ++bedrockAccountHistoryView._loadEpoch;
					bedrockAccountHistoryView._isLoading = true;
					bedrockAccountHistoryView.LoadingRing.IsActive = true;
					((UIElement)bedrockAccountHistoryView.LoadingRing).Visibility = (Visibility)0;
					((UIElement)bedrockAccountHistoryView.EmptyPanel).Visibility = (Visibility)1;
					((Control)bedrockAccountHistoryView.AccountList).IsEnabled = false;
					goto IL_0081;
				}
				goto end_IL_0011;
				IL_0081:
				try
				{
					TaskAwaiter<QMHkqHfNsSYLQ7K8Ejet> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.oYG0oUvyKm().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QMHkqHfNsSYLQ7K8Ejet>, _LoadAsync_d__10>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<QMHkqHfNsSYLQ7K8Ejet>);
						num = (__1__state = -1);
					}
					QMHkqHfNsSYLQ7K8Ejet result = _u__.GetResult();
					if (_epoch_5__2 == bedrockAccountHistoryView._loadEpoch)
					{
						((Collection<BedrockAccountHistoryItemViewModel>)(object)bedrockAccountHistoryView.Accounts).Clear();
						var enumerator = result.Accounts.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								GYf3CQfNxVcknhl8gDAn current = enumerator.Current;
								((Collection<BedrockAccountHistoryItemViewModel>)(object)bedrockAccountHistoryView.Accounts).Add((BedrockAccountHistoryItemViewModel)new BedrockAccountHistoryItemViewModel(current));
							}
						}
						finally
						{
							if (num < 0)
							{
								((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
						bedrockAccountHistoryView.EmptyTitleText.Text = "还没有历史账号";
					}
				}
				catch (global::System.Exception exception)
				{
					if (_epoch_5__2 == bedrockAccountHistoryView._loadEpoch)
					{
						bedrockAccountHistoryView.EmptyTitleText.Text = "历史账号加载失败";
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "LoadAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockAccountHistoryView.xaml.cs", 71));
					}
				}
				finally
				{
					if (num < 0)
					{
						bedrockAccountHistoryView._isLoading = false;
						bedrockAccountHistoryView.LoadingRing.IsActive = false;
						((UIElement)bedrockAccountHistoryView.LoadingRing).Visibility = (Visibility)1;
						((Control)bedrockAccountHistoryView.AccountList).IsEnabled = true;
						bedrockAccountHistoryView.UpdateState();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__t__builder.SetException(exception2);
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
	private struct _RefreshButton_Click_d__14_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockAccountHistoryView __4__this;

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
			BedrockAccountHistoryView bedrockAccountHistoryView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockAccountHistoryView.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__14_1>(ref _u__, ref this);
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

	private bool _isLoading;

	private bool _isOperationRunning;

	private int _loadEpoch;

	[CompilerGenerated]
	private EventHandler<BedrockAccountLoginRequestedEventArgs>? m_LoginRequested;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView AccountList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoadingRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ClearAllButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AccountCountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockAccountHistoryView_Bindings Bindings;

	[field: CompilerGenerated]
	public ObservableCollection<BedrockAccountHistoryItemViewModel> Accounts
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public EventHandler<BedrockAccountLoginRequestedEventArgs>? LoginRequested;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockAccountHistoryView()
	{
		Accounts = new ObservableCollection<BedrockAccountHistoryItemViewModel>();
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task LoadAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__10 loadAsync_d__ = default(_LoadAsync_d__10);
		loadAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__.__4__this = this;
		loadAsync_d__.__1__state = -1;
		loadAsync_d__.__t__builder.Start<_LoadAsync_d__10>(ref loadAsync_d__);
		return loadAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Upsert(GYf3CQfNxVcknhl8gDAn account)
	{
		ArgumentNullException.ThrowIfNull((object)account, "account");
		_loadEpoch++;
		for (int num = ((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).Count - 1; num >= 0; num--)
		{
			BedrockAccountHistoryItemViewModel bedrockAccountHistoryItemViewModel = ((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts)[num];
			if (bedrockAccountHistoryItemViewModel.Id == account.Id || string.Equals(bedrockAccountHistoryItemViewModel.GameUserId, account.GameUserId, (StringComparison)4))
			{
				((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).RemoveAt(num);
			}
		}
		((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).Insert(0, (BedrockAccountHistoryItemViewModel)new BedrockAccountHistoryItemViewModel(account));
		UpdateState();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetOperationRunning(bool isRunning)
	{
		_isOperationRunning = isRunning;
		UpdateState();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		_loadEpoch++;
		((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).Clear();
		UpdateState();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__14_1 refreshButton_Click_d__14_ = default(_RefreshButton_Click_d__14_1);
		refreshButton_Click_d__14_.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__14_.__4__this = this;
		refreshButton_Click_d__14_.__1__state = -1;
		refreshButton_Click_d__14_.__t__builder.Start<_RefreshButton_Click_d__14_1>(ref refreshButton_Click_d__14_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ClearAllButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ClearAllButton_Click_d__15 clearAllButton_Click_d__ = default(_ClearAllButton_Click_d__15);
		clearAllButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		clearAllButton_Click_d__.__4__this = this;
		clearAllButton_Click_d__.__1__state = -1;
		clearAllButton_Click_d__.__t__builder.Start<_ClearAllButton_Click_d__15>(ref clearAllButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LoginButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null && ((ButtonBase)val).CommandParameter is long recordId)
		{
			this.LoginRequested?.Invoke((object)this, (BedrockAccountLoginRequestedEventArgs)new BedrockAccountLoginRequestedEventArgs(recordId));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DetailsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DetailsButton_Click_d__17 detailsButton_Click_d__ = default(_DetailsButton_Click_d__17);
		detailsButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		detailsButton_Click_d__.__4__this = this;
		detailsButton_Click_d__.sender = sender;
		detailsButton_Click_d__.__1__state = -1;
		detailsButton_Click_d__.__t__builder.Start<_DetailsButton_Click_d__17>(ref detailsButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DeleteButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DeleteButton_Click_d__18 deleteButton_Click_d__ = default(_DeleteButton_Click_d__18);
		deleteButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		deleteButton_Click_d__.__4__this = this;
		deleteButton_Click_d__.sender = sender;
		deleteButton_Click_d__.__1__state = -1;
		deleteButton_Click_d__.__t__builder.Start<_DeleteButton_Click_d__18>(ref deleteButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateState()
	{
		AccountCountText.Text = $"{((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).Count} 个账号";
		((UIElement)AccountList).Visibility = ((((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).Count <= 0) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)EmptyPanel).Visibility = (((_isLoading || ((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).Count != 0)) ? Visibility.Visible : Visibility.Collapsed);
		((Control)AccountList).IsEnabled = !_isLoading && !_isOperationRunning;
		((Control)ClearAllButton).IsEnabled = ((Collection<BedrockAccountHistoryItemViewModel>)(object)Accounts).Count > 0 && !_isLoading && !_isOperationRunning;
		((Control)RefreshButton).IsEnabled = !_isLoading && !_isOperationRunning;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockAccountHistoryView.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			AccountList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			LoadingRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 5:
			EmptyTitleText = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DetailsButton_Click);
			break;
		case 12:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(LoginButton_Click);
			break;
		case 13:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DeleteButton_Click);
			break;
		case 25:
			ClearAllButton = CastExtensions.As<Button>(target);
			((ButtonBase)ClearAllButton).Click += new RoutedEventHandler(ClearAllButton_Click);
			break;
		case 26:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 27:
			AccountCountText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
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
			BedrockAccountHistoryView_obj1_Bindings bedrockAccountHistoryView_obj1_Bindings = (BedrockAccountHistoryView_obj1_Bindings)new BedrockAccountHistoryView_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockAccountHistoryView_obj1_Bindings;
			bedrockAccountHistoryView_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockAccountHistoryView_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockAccountHistoryView_obj1_Bindings.Loading;
			break;
		}
		case 7:
		{
			Grid val = (Grid)target;
			BedrockAccountHistoryView_obj7_Bindings bedrockAccountHistoryView_obj7_Bindings = (BedrockAccountHistoryView_obj7_Bindings)new BedrockAccountHistoryView_obj7_Bindings();
			result = (IComponentConnector)(object)bedrockAccountHistoryView_obj7_Bindings;
			bedrockAccountHistoryView_obj7_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockAccountHistoryView_obj7_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockAccountHistoryView_obj7_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockAccountHistoryView_obj7_Bindings);
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

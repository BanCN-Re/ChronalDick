using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using OQZwpbfRHr9DWudhZEpR;
using WinRT;
using WinRT.ChronalVtableClasses;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class PaymentBannerEditor : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IPaymentBannerEditor_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IPaymentBannerEditor_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_TextBox_Text(TextBox obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Text = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(ToggleButton obj, bool? value, string targetNullValue)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			if (!value.HasValue && targetNullValue != null)
			{
				value = (bool)XamlBindingHelper.ConvertValue(typeof(global::System.Boolean), (object)targetNullValue);
			}
			obj.IsChecked = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	private class PaymentBannerEditor_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IPaymentBannerEditor_Bindings
	{
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		private class PaymentBannerEditor_obj5_BindingsTracking
		{
			private WeakReference<PaymentBannerEditor_obj5_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public PaymentBannerEditor_obj5_BindingsTracking(PaymentBannerEditor_obj5_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<PaymentBannerEditor_obj5_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public PaymentBannerEditor_obj5_Bindings TryGetBindingObject()
			{
				PaymentBannerEditor_obj5_Bindings paymentBannerEditor_obj5_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out paymentBannerEditor_obj5_Bindings);
					if (paymentBannerEditor_obj5_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return paymentBannerEditor_obj5_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
			}

			[MethodImpl((MethodImplOptions)8)]
			public void RegisterTwoWayListener_6(TextBox sourceObject)
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected O, but got Unknown
				((UIElement)sourceObject).LostFocus += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object sender, RoutedEventArgs e) =>
				{
					TryGetBindingObject()?.UpdateTwoWay_6_Text();
				});
			}

			[MethodImpl((MethodImplOptions)8)]
			public void RegisterTwoWayListener_7(TextBox sourceObject)
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected O, but got Unknown
				((UIElement)sourceObject).LostFocus += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object sender, RoutedEventArgs e) =>
				{
					TryGetBindingObject()?.UpdateTwoWay_7_Text();
				});
			}

			[MethodImpl((MethodImplOptions)8)]
			public void RegisterTwoWayListener_8(TextBox sourceObject)
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected O, but got Unknown
				((UIElement)sourceObject).LostFocus += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object sender, RoutedEventArgs e) =>
				{
					TryGetBindingObject()?.UpdateTwoWay_8_Text();
				});
			}

			[MethodImpl((MethodImplOptions)8)]
			public void RegisterTwoWayListener_9(TextBox sourceObject)
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected O, but got Unknown
				((UIElement)sourceObject).LostFocus += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object sender, RoutedEventArgs e) =>
				{
					TryGetBindingObject()?.UpdateTwoWay_9_Text();
				});
			}

			[MethodImpl((MethodImplOptions)8)]
			public void RegisterTwoWayListener_10(TextBox sourceObject)
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected O, but got Unknown
				((UIElement)sourceObject).LostFocus += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object sender, RoutedEventArgs e) =>
				{
					TryGetBindingObject()?.UpdateTwoWay_10_Text();
				});
			}

			[MethodImpl((MethodImplOptions)8)]
			public void RegisterTwoWayListener_11(CheckBox sourceObject)
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Expected O, but got Unknown
				((DependencyObject)sourceObject).RegisterPropertyChangedCallback(ToggleButton.IsCheckedProperty, (DependencyPropertyChangedCallback)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (DependencyObject sender, DependencyProperty prop) =>
				{
					TryGetBindingObject()?.UpdateTwoWay_11_IsChecked();
				}));
			}

			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private void _RegisterTwoWayListener_6_b__4_0(object sender, RoutedEventArgs e)
			{
				TryGetBindingObject()?.UpdateTwoWay_6_Text();
			}

			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private void _RegisterTwoWayListener_7_b__5_0(object sender, RoutedEventArgs e)
			{
				TryGetBindingObject()?.UpdateTwoWay_7_Text();
			}

			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private void _RegisterTwoWayListener_8_b__6_0(object sender, RoutedEventArgs e)
			{
				TryGetBindingObject()?.UpdateTwoWay_8_Text();
			}

			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private void _RegisterTwoWayListener_9_b__7_0(object sender, RoutedEventArgs e)
			{
				TryGetBindingObject()?.UpdateTwoWay_9_Text();
			}

			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private void _RegisterTwoWayListener_10_b__8_0(object sender, RoutedEventArgs e)
			{
				TryGetBindingObject()?.UpdateTwoWay_10_Text();
			}

			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private void _RegisterTwoWayListener_11_b__9_0(DependencyObject sender, DependencyProperty prop)
			{
				TryGetBindingObject()?.UpdateTwoWay_11_IsChecked();
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private eBH6YIfRKKYmAtWXaPLA dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private TextBox obj6;

		private TextBox obj7;

		private TextBox obj8;

		private TextBox obj9;

		private TextBox obj10;

		private CheckBox obj11;

		private PaymentBannerEditor_obj5_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public PaymentBannerEditor_obj5_Bindings()
		{
			bindingsTracking = (PaymentBannerEditor_obj5_BindingsTracking)new PaymentBannerEditor_obj5_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			switch (connectionId)
			{
			case 5:
				obj5 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 6:
				obj6 = CastExtensions.As<TextBox>(target);
				bindingsTracking.RegisterTwoWayListener_6(obj6);
				break;
			case 7:
				obj7 = CastExtensions.As<TextBox>(target);
				bindingsTracking.RegisterTwoWayListener_7(obj7);
				break;
			case 8:
				obj8 = CastExtensions.As<TextBox>(target);
				bindingsTracking.RegisterTwoWayListener_8(obj8);
				break;
			case 9:
				obj9 = CastExtensions.As<TextBox>(target);
				bindingsTracking.RegisterTwoWayListener_9(obj9);
				break;
			case 10:
				obj10 = CastExtensions.As<TextBox>(target);
				bindingsTracking.RegisterTwoWayListener_10(obj10);
				break;
			case 11:
				obj11 = CastExtensions.As<CheckBox>(target);
				bindingsTracking.RegisterTwoWayListener_11(obj11);
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
			nextPhase = default;
			removedDataContextHandler = true;
			object target = obj5.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<eBH6YIfRKKYmAtWXaPLA>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<eBH6YIfRKKYmAtWXaPLA>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(eBH6YIfRKKYmAtWXaPLA obj, int phase)
		{
			if (obj != null && (phase & -1073741823) != 0)
			{
				Update_Description(obj.Description, phase);
				Update_ImageUrl(obj.ImageUrl, phase);
				Update_LinkUrl(obj.LinkUrl, phase);
				Update_Title(obj.Title, phase);
				Update_ActionText(obj.ActionText, phase);
				Update_Enabled(obj.Enabled, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Description(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ImageUrl(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(obj7, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_LinkUrl(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Title(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ActionText(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Enabled(bool obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked((ToggleButton)(object)obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void UpdateTwoWay_6_Text()
		{
			if (initialized && dataRoot != null)
			{
				dataRoot.Description = obj6.Text;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void UpdateTwoWay_7_Text()
		{
			if (initialized && dataRoot != null)
			{
				dataRoot.ImageUrl = obj7.Text;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void UpdateTwoWay_8_Text()
		{
			if (initialized && dataRoot != null)
			{
				dataRoot.LinkUrl = obj8.Text;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void UpdateTwoWay_9_Text()
		{
			if (initialized && dataRoot != null)
			{
				dataRoot.Title = obj9.Text;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void UpdateTwoWay_10_Text()
		{
			if (initialized && dataRoot != null)
			{
				dataRoot.ActionText = obj10.Text;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void UpdateTwoWay_11_IsChecked()
		{
			if (initialized && dataRoot != null)
			{
				dataRoot.Enabled = ((ToggleButton)obj11).IsChecked.Value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private const int MaximumBannerCount = 8;

	private readonly ObservableCollection<eBH6YIfRKKYmAtWXaPLA> _items;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border EmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView BannerList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BannerCountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IPaymentBannerEditor_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public PaymentBannerEditor()
	{
		_items = new ObservableCollection<eBH6YIfRKKYmAtWXaPLA>();
		InitializeComponent();
		((ItemsControl)BannerList).ItemsSource = _items;
		UpdateState();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetItems(global::System.Collections.Generic.IEnumerable<eBH6YIfRKKYmAtWXaPLA>? items)
	{
		((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Clear();
		global::System.Collections.Generic.IEnumerator<eBH6YIfRKKYmAtWXaPLA> enumerator = Enumerable.Take<eBH6YIfRKKYmAtWXaPLA>(items ?? global::System.Array.Empty<eBH6YIfRKKYmAtWXaPLA>(), 8).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				eBH6YIfRKKYmAtWXaPLA current = enumerator.Current;
				((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Add(current.slefRtgPed6());
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		UpdateState();
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Collections.Generic.IReadOnlyList<eBH6YIfRKKYmAtWXaPLA> GetItems()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		List<eBH6YIfRKKYmAtWXaPLA> val = new List<eBH6YIfRKKYmAtWXaPLA>(((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Count);
		for (int i = 0; i < ((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Count; i++)
		{
			eBH6YIfRKKYmAtWXaPLA val2 = ((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items)[i];
			string text = val2.Title.Trim();
			if (text.Length == 0)
			{
				throw new InvalidOperationException($"请填写第 {i + 1} 条横幅的标题");
			}
			if (text.Length > 80 || val2.Description.Trim().Length > 240 || val2.ActionText.Trim().Length > 24)
			{
				throw new InvalidOperationException($"第 {i + 1} 条横幅的文字长度超出限制");
			}
			ValidateOptionalHttpUrl(val2.ImageUrl, i, "图片地址");
			ValidateOptionalHttpUrl(val2.LinkUrl, i, "跳转地址");
			val.Add(new eBH6YIfRKKYmAtWXaPLA
			{
				Title = text,
				Description = val2.Description.Trim(),
				ImageUrl = val2.ImageUrl.Trim(),
				LinkUrl = val2.LinkUrl.Trim(),
				ActionText = val2.ActionText.Trim(),
				Enabled = val2.Enabled
			});
		}
		return (global::System.Collections.Generic.IReadOnlyList<eBH6YIfRKKYmAtWXaPLA>)val;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AddBannerButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		if (((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Count >= 8)
		{
			AppShell.Warning($"最多添加 {8} 条横幅");
		}
		else
		{
			((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Add(new eBH6YIfRKKYmAtWXaPLA
			{
				Title = "新横幅",
				ActionText = "查看详情",
				Enabled = true
			});
			UpdateState();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void DeleteBannerButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null)
		{
			object dataContext = ((FrameworkElement)val).DataContext;
			eBH6YIfRKKYmAtWXaPLA val2 = (eBH6YIfRKKYmAtWXaPLA)((dataContext is eBH6YIfRKKYmAtWXaPLA) ? dataContext : null);
			if (val2 != null)
			{
				((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Remove(val2);
				UpdateState();
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void MoveUpButton_Click(object sender, RoutedEventArgs e)
	{
		MoveItem(sender, -1);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void MoveDownButton_Click(object sender, RoutedEventArgs e)
	{
		MoveItem(sender, 1);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void MoveItem(object sender, int delta)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val == null)
		{
			return;
		}
		object dataContext = ((FrameworkElement)val).DataContext;
		eBH6YIfRKKYmAtWXaPLA val2 = (eBH6YIfRKKYmAtWXaPLA)((dataContext is eBH6YIfRKKYmAtWXaPLA) ? dataContext : null);
		if (val2 != null)
		{
			int num = ((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).IndexOf(val2);
			int num2 = num + delta;
			if (num >= 0 && num2 >= 0 && num2 < ((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Count)
			{
				_items.Move(num, num2);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateState()
	{
		BannerCountText.Text = $"{((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Count} / {8}";
		((UIElement)EmptyState).Visibility = (((((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Count != 0) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)BannerList).Visibility = ((((Collection<eBH6YIfRKKYmAtWXaPLA>)(object)_items).Count == 0) ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ValidateOptionalHttpUrl(string value, int index, string fieldName)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		string text = value.Trim();
		Uri val = default(Uri);
		if (text.Length == 0 || (text.Length <= 2048 && Uri.TryCreate(text, (UriKind)1, out val) && (!(val.Scheme != Uri.UriSchemeHttp) || !(val.Scheme != Uri.UriSchemeHttps))))
		{
			return;
		}
		throw new InvalidOperationException($"第 {index + 1} 条横幅的{fieldName}必须是 HTTP 或 HTTPS 地址");
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
			Uri val = new Uri("ms-appx:///UI/Controls/PaymentBannerEditor.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			EmptyState = CastExtensions.As<Border>(target);
			break;
		case 3:
			BannerList = CastExtensions.As<ListView>(target);
			break;
		case 12:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(MoveUpButton_Click);
			break;
		case 13:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(MoveDownButton_Click);
			break;
		case 14:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DeleteBannerButton_Click);
			break;
		case 15:
			BannerCountText = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(AddBannerButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		IComponentConnector result = null;
		if (connectionId == 5)
		{
			Border val = (Border)target;
			PaymentBannerEditor_obj5_Bindings paymentBannerEditor_obj5_Bindings = (PaymentBannerEditor_obj5_Bindings)new PaymentBannerEditor_obj5_Bindings();
			result = (IComponentConnector)(object)paymentBannerEditor_obj5_Bindings;
			paymentBannerEditor_obj5_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += paymentBannerEditor_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)paymentBannerEditor_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)paymentBannerEditor_obj5_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

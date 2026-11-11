using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.ChronalVtableClasses;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Shell;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class PagerBar : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IPagerBar_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IPagerBar_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(UIElement obj, Visibility value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Visibility = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class PagerBar_obj1_Bindings : IComponentConnector, IPagerBar_Bindings
	{
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		private class PagerBar_obj1_BindingsTracking
		{
			private WeakReference<PagerBar_obj1_Bindings> weakRefToBindingObj;

			private long tokenDPC_PageSizeVisibility;

			[MethodImpl((MethodImplOptions)8)]
			public PagerBar_obj1_BindingsTracking(PagerBar_obj1_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<PagerBar_obj1_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public PagerBar_obj1_Bindings TryGetBindingObject()
			{
				PagerBar_obj1_Bindings pagerBar_obj1_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out pagerBar_obj1_Bindings);
					if (pagerBar_obj1_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return pagerBar_obj1_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
				UpdateChildListeners_(null);
			}

			[MethodImpl((MethodImplOptions)8)]
			public void DependencyPropertyChanged_PageSizeVisibility(DependencyObject sender, DependencyProperty prop)
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				PagerBar_obj1_Bindings pagerBar_obj1_Bindings = TryGetBindingObject();
				if (pagerBar_obj1_Bindings != null)
				{
					PagerBar pagerBar = sender as PagerBar;
					if ((UserControl)(object)pagerBar != (UserControl)null)
					{
						pagerBar_obj1_Bindings.Update_PageSizeVisibility(pagerBar.PageSizeVisibility, 1073741824);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_(PagerBar obj)
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Expected O, but got Unknown
				PagerBar_obj1_Bindings pagerBar_obj1_Bindings = TryGetBindingObject();
				if (pagerBar_obj1_Bindings != null)
				{
					if ((UserControl)(object)pagerBar_obj1_Bindings.dataRoot != (UserControl)null)
					{
						((DependencyObject)pagerBar_obj1_Bindings.dataRoot).UnregisterPropertyChangedCallback(PageSizeVisibilityProperty, tokenDPC_PageSizeVisibility);
					}
					if ((UserControl)(object)obj != (UserControl)null)
					{
						pagerBar_obj1_Bindings.dataRoot = obj;
						tokenDPC_PageSizeVisibility = ((DependencyObject)obj).RegisterPropertyChangedCallback(PageSizeVisibilityProperty, new DependencyPropertyChangedCallback(DependencyPropertyChanged_PageSizeVisibility));
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private PagerBar dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private StackPanel obj3;

		private PagerBar_obj1_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public PagerBar_obj1_Bindings()
		{
			bindingsTracking = (PagerBar_obj1_BindingsTracking)new PagerBar_obj1_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 3)
			{
				obj3 = CastExtensions.As<StackPanel>(target);
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
				dataRoot = CastExtensions.As<PagerBar>(newDataRoot);
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
		private void Update_(PagerBar obj, int phase)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			bindingsTracking.UpdateChildListeners_(obj);
			if ((UserControl)(object)obj != (UserControl)null && (phase & -1073741823) != 0)
			{
				Update_PageSizeVisibility(obj.PageSizeVisibility, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PageSizeVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj3, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass19_0_4
	{
		public int pageSize;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass19_0_4()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SelectPageSize_b__0(ComboBoxItem item)
		{
			return UiHelpers.ParseInt(((FrameworkElement)item).Tag?.ToString() ?? string.Empty, -1) == pageSize;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	public static readonly DependencyProperty PageSizeVisibilityProperty;

	private bool _suppressPageSizeEvent;

	[CompilerGenerated]
	private EventHandler? m_PreviousRequested;

	[CompilerGenerated]
	private EventHandler? m_NextRequested;

	[CompilerGenerated]
	private EventHandler<int>? m_PageSizeChanged;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SummaryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button PreviousButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PageText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button NextButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox PageSizeCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IPagerBar_Bindings Bindings;

	public Visibility PageSizeVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)((DependencyObject)this).GetValue(PageSizeVisibilityProperty);
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			((DependencyObject)this).SetValue(PageSizeVisibilityProperty, (object)value);
		}
	}

	public int PageSize
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			object selectedItem = ((Selector)PageSizeCombo).SelectedItem;
			object obj = ((selectedItem is ComboBoxItem) ? selectedItem : null);
			return UiHelpers.ParseInt(((obj == null) ? null : ((FrameworkElement)obj).Tag?.ToString()) ?? "50", 50);
		}
	}

	public EventHandler PreviousRequested;

	public EventHandler NextRequested;

	public EventHandler<int>? PageSizeChanged;

	[MethodImpl((MethodImplOptions)8)]
	public PagerBar()
	{
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetState(int page, int totalPages, int total)
	{
		int num = Math.Max(totalPages, 1);
		int num2 = Math.Clamp(page, 1, num);
		PageText.Text = $"{num2} / {num}";
		SummaryText.Text = ((total > 0) ? ("共 " + total.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture) + " 条") : "暂无数据");
		((Control)PreviousButton).IsEnabled = num2 > 1;
		((Control)NextButton).IsEnabled = num2 < num;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetSummary(string text)
	{
		SummaryText.Text = text;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SelectPageSize(int pageSize)
	{
		__c__DisplayClass19_0_4 __8_locals2 = (__c__DisplayClass19_0_4)new __c__DisplayClass19_0_4();
		__8_locals2.pageSize = pageSize;
		ComboBoxItem val = Enumerable.FirstOrDefault<ComboBoxItem>(Enumerable.OfType<ComboBoxItem>((global::System.Collections.IEnumerable)((ItemsControl)PageSizeCombo).Items), (Func<ComboBoxItem, bool>)([MethodImpl((MethodImplOptions)8)] (ComboBoxItem item) => UiHelpers.ParseInt(((FrameworkElement)item).Tag?.ToString() ?? string.Empty, -1) == __8_locals2.pageSize));
		if (val != null && val != ((Selector)PageSizeCombo).SelectedItem)
		{
			_suppressPageSizeEvent = true;
			((Selector)PageSizeCombo).SelectedItem = val;
			_suppressPageSizeEvent = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PreviousButton_Click(object sender, RoutedEventArgs e)
	{
		EventHandler? obj = this.PreviousRequested;
		if (obj != null)
		{
			obj.Invoke((object)this, EventArgs.Empty);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void NextButton_Click(object sender, RoutedEventArgs e)
	{
		EventHandler? obj = this.NextRequested;
		if (obj != null)
		{
			obj.Invoke((object)this, EventArgs.Empty);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PageSizeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (!_suppressPageSizeEvent)
		{
			this.PageSizeChanged?.Invoke((object)this, PageSize);
		}
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
			Uri val = new Uri("ms-appx:///UI/Shell/PagerBar.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			SummaryText = CastExtensions.As<TextBlock>(target);
			break;
		case 4:
			PreviousButton = CastExtensions.As<Button>(target);
			((ButtonBase)PreviousButton).Click += new RoutedEventHandler(PreviousButton_Click);
			break;
		case 5:
			PageText = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			NextButton = CastExtensions.As<Button>(target);
			((ButtonBase)NextButton).Click += new RoutedEventHandler(NextButton_Click);
			break;
		case 7:
			PageSizeCombo = CastExtensions.As<ComboBox>(target);
			((Selector)PageSizeCombo).SelectionChanged += new SelectionChangedEventHandler(PageSizeCombo_SelectionChanged);
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
		IComponentConnector result = null;
		if (connectionId == 1)
		{
			UserControl val = (UserControl)target;
			PagerBar_obj1_Bindings pagerBar_obj1_Bindings = (PagerBar_obj1_Bindings)new PagerBar_obj1_Bindings();
			result = (IComponentConnector)(object)pagerBar_obj1_Bindings;
			pagerBar_obj1_Bindings.SetDataRoot(this);
			Bindings = pagerBar_obj1_Bindings;
			((FrameworkElement)val).Loading += pagerBar_obj1_Bindings.Loading;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	static PagerBar()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		PageSizeVisibilityProperty = DependencyProperty.Register("PageSizeVisibility", typeof(global::Microsoft.UI.Xaml.Visibility), typeof(global::Mahiro_Account.UI.Shell.PagerBar), new PropertyMetadata((object)(Visibility)1));
	}
}

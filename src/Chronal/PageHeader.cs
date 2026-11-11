using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
public sealed class PageHeader : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IPageHeader_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IPageHeader_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(ContentPresenter obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.Content = value;
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
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class PageHeader_obj1_Bindings : IComponentConnector, IPageHeader_Bindings
	{
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		private class PageHeader_obj1_BindingsTracking
		{
			private WeakReference<PageHeader_obj1_Bindings> weakRefToBindingObj;

			private long tokenDPC_Actions;

			private long tokenDPC_Title;

			private long tokenDPC_Subtitle;

			private long tokenDPC_HasSubtitle;

			[MethodImpl((MethodImplOptions)8)]
			public PageHeader_obj1_BindingsTracking(PageHeader_obj1_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<PageHeader_obj1_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public PageHeader_obj1_Bindings TryGetBindingObject()
			{
				PageHeader_obj1_Bindings pageHeader_obj1_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out pageHeader_obj1_Bindings);
					if (pageHeader_obj1_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return pageHeader_obj1_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
				UpdateChildListeners_(null);
			}

			[MethodImpl((MethodImplOptions)8)]
			public void DependencyPropertyChanged_Actions(DependencyObject sender, DependencyProperty prop)
			{
				PageHeader_obj1_Bindings pageHeader_obj1_Bindings = TryGetBindingObject();
				if (pageHeader_obj1_Bindings != null)
				{
					PageHeader pageHeader = sender as PageHeader;
					if ((UserControl)(object)pageHeader != (UserControl)null)
					{
						pageHeader_obj1_Bindings.Update_Actions(pageHeader.Actions, 1073741824);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void DependencyPropertyChanged_Title(DependencyObject sender, DependencyProperty prop)
			{
				PageHeader_obj1_Bindings pageHeader_obj1_Bindings = TryGetBindingObject();
				if (pageHeader_obj1_Bindings != null)
				{
					PageHeader pageHeader = sender as PageHeader;
					if ((UserControl)(object)pageHeader != (UserControl)null)
					{
						pageHeader_obj1_Bindings.Update_Title(pageHeader.Title, 1073741824);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void DependencyPropertyChanged_Subtitle(DependencyObject sender, DependencyProperty prop)
			{
				PageHeader_obj1_Bindings pageHeader_obj1_Bindings = TryGetBindingObject();
				if (pageHeader_obj1_Bindings != null)
				{
					PageHeader pageHeader = sender as PageHeader;
					if ((UserControl)(object)pageHeader != (UserControl)null)
					{
						pageHeader_obj1_Bindings.Update_Subtitle(pageHeader.Subtitle, 1073741824);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void DependencyPropertyChanged_HasSubtitle(DependencyObject sender, DependencyProperty prop)
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				PageHeader_obj1_Bindings pageHeader_obj1_Bindings = TryGetBindingObject();
				if (pageHeader_obj1_Bindings != null)
				{
					PageHeader pageHeader = sender as PageHeader;
					if ((UserControl)(object)pageHeader != (UserControl)null)
					{
						pageHeader_obj1_Bindings.Update_HasSubtitle(pageHeader.HasSubtitle, 1073741824);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_(PageHeader obj)
			{
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected O, but got Unknown
				//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Expected O, but got Unknown
				//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00de: Expected O, but got Unknown
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Expected O, but got Unknown
				PageHeader_obj1_Bindings pageHeader_obj1_Bindings = TryGetBindingObject();
				if (pageHeader_obj1_Bindings != null)
				{
					if ((UserControl)(object)pageHeader_obj1_Bindings.dataRoot != (UserControl)null)
					{
						((DependencyObject)pageHeader_obj1_Bindings.dataRoot).UnregisterPropertyChangedCallback(ActionsProperty, tokenDPC_Actions);
						((DependencyObject)pageHeader_obj1_Bindings.dataRoot).UnregisterPropertyChangedCallback(TitleProperty, tokenDPC_Title);
						((DependencyObject)pageHeader_obj1_Bindings.dataRoot).UnregisterPropertyChangedCallback(SubtitleProperty, tokenDPC_Subtitle);
						((DependencyObject)pageHeader_obj1_Bindings.dataRoot).UnregisterPropertyChangedCallback(HasSubtitleProperty, tokenDPC_HasSubtitle);
					}
					if ((UserControl)(object)obj != (UserControl)null)
					{
						pageHeader_obj1_Bindings.dataRoot = obj;
						tokenDPC_Actions = ((DependencyObject)obj).RegisterPropertyChangedCallback(ActionsProperty, new DependencyPropertyChangedCallback(DependencyPropertyChanged_Actions));
						tokenDPC_Title = ((DependencyObject)obj).RegisterPropertyChangedCallback(TitleProperty, new DependencyPropertyChangedCallback(DependencyPropertyChanged_Title));
						tokenDPC_Subtitle = ((DependencyObject)obj).RegisterPropertyChangedCallback(SubtitleProperty, new DependencyPropertyChangedCallback(DependencyPropertyChanged_Subtitle));
						tokenDPC_HasSubtitle = ((DependencyObject)obj).RegisterPropertyChangedCallback(HasSubtitleProperty, new DependencyPropertyChangedCallback(DependencyPropertyChanged_HasSubtitle));
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private PageHeader dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ContentPresenter obj2;

		private TextBlock obj3;

		private TextBlock obj4;

		private PageHeader_obj1_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public PageHeader_obj1_Bindings()
		{
			bindingsTracking = (PageHeader_obj1_BindingsTracking)new PageHeader_obj1_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				obj2 = CastExtensions.As<ContentPresenter>(target);
				break;
			case 3:
				obj3 = CastExtensions.As<TextBlock>(target);
				break;
			case 4:
				obj4 = CastExtensions.As<TextBlock>(target);
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
				dataRoot = CastExtensions.As<PageHeader>(newDataRoot);
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
		private void Update_(PageHeader obj, int phase)
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			bindingsTracking.UpdateChildListeners_(obj);
			if ((UserControl)(object)obj != (UserControl)null && (phase & -1073741823) != 0)
			{
				Update_Actions(obj.Actions, phase);
				Update_Title(obj.Title, phase);
				Update_Subtitle(obj.Subtitle, phase);
				Update_HasSubtitle(obj.HasSubtitle, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Actions(object obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentPresenter_Content(obj2, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Title(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj3, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Subtitle(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj4, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_HasSubtitle(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj4, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	public static readonly DependencyProperty TitleProperty;

	public static readonly DependencyProperty SubtitleProperty;

	public static readonly DependencyProperty ActionsProperty;

	public static readonly DependencyProperty HasSubtitleProperty;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IPageHeader_Bindings Bindings;

	public string Title
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (string)((DependencyObject)this).GetValue(TitleProperty);
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			((DependencyObject)this).SetValue(TitleProperty, (object)value);
		}
	}

	public string Subtitle
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (string)((DependencyObject)this).GetValue(SubtitleProperty);
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			((DependencyObject)this).SetValue(SubtitleProperty, (object)value);
		}
	}

	public object? Actions
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((DependencyObject)this).GetValue(ActionsProperty);
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			((DependencyObject)this).SetValue(ActionsProperty, value);
		}
	}

	public Visibility HasSubtitle
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			return (Visibility)((DependencyObject)this).GetValue(HasSubtitleProperty);
		}
		[MethodImpl((MethodImplOptions)8)]
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			((DependencyObject)this).SetValue(HasSubtitleProperty, (object)value);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public PageHeader()
	{
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnSubtitleChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
	{
		if (sender is PageHeader pageHeader)
		{
			pageHeader.HasSubtitle = ((string.IsNullOrWhiteSpace(args.NewValue as string) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
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
			Uri val = new Uri("ms-appx:///UI/Shell/PageHeader.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
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
			PageHeader_obj1_Bindings pageHeader_obj1_Bindings = (PageHeader_obj1_Bindings)new PageHeader_obj1_Bindings();
			result = (IComponentConnector)(object)pageHeader_obj1_Bindings;
			pageHeader_obj1_Bindings.SetDataRoot(this);
			Bindings = pageHeader_obj1_Bindings;
			((FrameworkElement)val).Loading += pageHeader_obj1_Bindings.Loading;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	static PageHeader()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		TitleProperty = DependencyProperty.Register("Title", typeof(global::System.String), typeof(global::Mahiro_Account.UI.Shell.PageHeader), new PropertyMetadata((object)string.Empty));
		SubtitleProperty = DependencyProperty.Register("Subtitle", typeof(global::System.String), typeof(global::Mahiro_Account.UI.Shell.PageHeader), new PropertyMetadata((object)string.Empty, new PropertyChangedCallback(OnSubtitleChanged)));
		ActionsProperty = DependencyProperty.Register("Actions", typeof(global::System.Object), typeof(global::Mahiro_Account.UI.Shell.PageHeader), new PropertyMetadata((object)null));
		HasSubtitleProperty = DependencyProperty.Register("HasSubtitle", typeof(global::Microsoft.UI.Xaml.Visibility), typeof(global::Mahiro_Account.UI.Shell.PageHeader), new PropertyMetadata((object)(Visibility)1));
	}
}

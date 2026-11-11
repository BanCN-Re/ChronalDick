using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
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
public sealed class InfoBarHost : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IInfoBarHost_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IInfoBarHost_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_InfoBar_Message(InfoBar obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Message = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_InfoBar_Severity(InfoBar obj, InfoBarSeverity value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Severity = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_InfoBar_Title(InfoBar obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Title = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[DebuggerNonUserCode]
	private class InfoBarHost_obj4_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IInfoBarHost_Bindings
	{
		private NotificationItem dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj4;

		[MethodImpl((MethodImplOptions)8)]
		public InfoBarHost_obj4_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			if (connectionId == 4)
			{
				obj4 = new WeakReference((object)CastExtensions.As<InfoBar>(target));
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
			nextPhase = default(int);
			removedDataContextHandler = true;
			object target = obj4.Target;
			InfoBar val = (InfoBar)((target is InfoBar) ? target : null);
			if (val != (InfoBar)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<NotificationItem>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<NotificationItem>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(NotificationItem obj, int phase)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Message(obj.Message, phase);
				Update_Severity(obj.Severity, phase);
				Update_Title(obj.Title, phase);
			}
			if ((phase & -2147483647) != 0 && default(InfoBar) != (InfoBar)null)
			{
				object target = obj4.Target;
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)((target is InfoBar) ? target : null), obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Message(string obj, int phase)
		{
			if ((phase & -2147483647) != 0 && default(InfoBar) != (InfoBar)null)
			{
				object target = obj4.Target;
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_InfoBar_Message((InfoBar)((target is InfoBar) ? target : null), obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Severity(InfoBarSeverity obj, int phase)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0 && default(InfoBar) != (InfoBar)null)
			{
				object target = obj4.Target;
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_InfoBar_Severity((InfoBar)((target is InfoBar) ? target : null), obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Title(string obj, int phase)
		{
			if ((phase & -2147483647) != 0 && default(InfoBar) != (InfoBar)null)
			{
				object target = obj4.Target;
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_InfoBar_Title((InfoBar)((target is InfoBar) ? target : null), obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass4_0_2
	{
		public InfoBarHost __4__this;

		public NotificationItem item;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass4_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _Post_b__0(DispatcherQueueTimer _, object _2)
		{
			__4__this.Remove(item);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private const int MaxVisibleNotifications = 4;

	private readonly ObservableCollection<NotificationItem> _notifications;

	private readonly Dictionary<NotificationItem, DispatcherQueueTimer> _dismissTimers;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ItemsControl NotificationList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IInfoBarHost_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public InfoBarHost()
	{
		_notifications = new ObservableCollection<NotificationItem>();
		_dismissTimers = new Dictionary<NotificationItem, DispatcherQueueTimer>();
		InitializeComponent();
		NotificationList.ItemsSource = _notifications;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Post(InfoBarSeverity severity, string message, string? title = null)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass4_0_2 __8_locals6 = (__c__DisplayClass4_0_2)new __c__DisplayClass4_0_2();
		__8_locals6.__4__this = this;
		if (string.IsNullOrWhiteSpace(message))
		{
			return;
		}
		string text = title?.Trim() ?? string.Empty;
		string text2 = message.Trim();
		global::System.Collections.Generic.IEnumerator<NotificationItem> enumerator = ((Collection<NotificationItem>)(object)_notifications).GetEnumerator();
		try
		{
			DispatcherQueueTimer val = default(DispatcherQueueTimer);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				NotificationItem current = enumerator.Current;
				if (current.Severity == severity && string.Equals(current.Title, text, (StringComparison)4) && string.Equals(current.Message, text2, (StringComparison)4))
				{
					if (_dismissTimers.TryGetValue(current, out val))
					{
						val.Stop();
						val.Start();
					}
					return;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		__8_locals6.item = (NotificationItem)new NotificationItem
		{
			Severity = severity,
			Title = text,
			Message = text2
		};
		((Collection<NotificationItem>)(object)_notifications).Insert(0, __8_locals6.item);
		while (((Collection<NotificationItem>)(object)_notifications).Count > 4)
		{
			ObservableCollection<NotificationItem> notifications = _notifications;
			Remove(((Collection<NotificationItem>)(object)notifications)[((Collection<NotificationItem>)(object)notifications).Count - 1]);
		}
		DispatcherQueueTimer val2 = ((DependencyObject)this).DispatcherQueue.CreateTimer();
		val2.Interval = NotificationAutoDismiss.GetDelay(severity);
		val2.IsRepeating = false;
		val2.Tick += [MethodImpl((MethodImplOptions)8)] (DispatcherQueueTimer _, object _) =>
		{
			__8_locals6.__4__this.Remove(__8_locals6.item);
		};
		_dismissTimers.Add(__8_locals6.item, val2);
		val2.Start();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Clear()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		var enumerator = _dismissTimers.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.Stop();
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
		}
		_dismissTimers.Clear();
		((Collection<NotificationItem>)(object)_notifications).Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Remove(NotificationItem item)
	{
		DispatcherQueueTimer val = default(DispatcherQueueTimer);
		if (_dismissTimers.Remove(item, out val))
		{
			val.Stop();
		}
		((Collection<NotificationItem>)(object)_notifications).Remove(item);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void NotificationInfoBar_CloseButtonClick(InfoBar sender, object args)
	{
		if (((FrameworkElement)sender).Tag is NotificationItem item)
		{
			Remove(item);
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
			Uri val = new Uri("ms-appx:///UI/Shell/InfoBarHost.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 2:
			NotificationList = CastExtensions.As<ItemsControl>(target);
			break;
		case 4:
			CastExtensions.As<InfoBar>(target).CloseButtonClick += NotificationInfoBar_CloseButtonClick;
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
		if (connectionId == 4)
		{
			InfoBar val = (InfoBar)target;
			InfoBarHost_obj4_Bindings infoBarHost_obj4_Bindings = (InfoBarHost_obj4_Bindings)new InfoBarHost_obj4_Bindings();
			result = (IComponentConnector)(object)infoBarHost_obj4_Bindings;
			infoBarHost_obj4_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += infoBarHost_obj4_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)infoBarHost_obj4_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)infoBarHost_obj4_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

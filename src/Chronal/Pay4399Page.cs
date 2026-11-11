using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using D4SUYbmq8poOlKYw6Ed;
using Dljbvyf6okInd3dFyAWX;
using ERJ416fPgD8mIlLPsat4;
using FNdWjWfRjjc3TlRnXJMg;
using FmPQGBUV0sfTHbetdiK;
using JvgQTDcbARdEdTAk7GE;
using Mahiro_Account.Services;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using N9UVEvf6UHvBucn1bopm;
using P0graHf67FHLhLQyDEVV;
using P2V4KgyAeYeGiSUWA6W;
using PrEnTAUtUqHsjSK87ES;
using RyDfSXfPyKj0ty7cSIxY;
using SIu19shjDQqN0kRiC7P;
using SSyRkNf6vV59nmjGNXQA;
using VVXeQZBz2af992hF0ij;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Storage.Streams;
using XfjuwR7xarspTS10AN4;
using fkHktHfRbKFnPBhtf9XJ;
using gcSlXZf6dlKLfOb6FSrw;
using idCxPgfRfyKXUZCthDO5;
using kbFLiOfR9A59QBQRw7Jb;
using np5Om2Bi4Ftd23gm8lR;
using qS8vkpL43FlTMgcj0rgs;
using qjwtaGf6I0O7cJtkgpQ1;
using qugITIf6FhO1ji6dZ5ya;
using rsq4n3UgA8K542GL74j;
using todNS07L1BTskuVuFU3;
using tx6etqf618HGqJwUt7tD;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class Pay4399Page : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IPay4399Page_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IPay4399Page_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class Pay4399Page_obj20_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IPay4399Page_Bindings
	{
		private aMuqLcf6hnKdBTwYqLWe dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj20;

		private TextBlock obj23;

		private TextBlock obj24;

		private TextBlock obj25;

		private TextBlock obj26;

		private TextBlock obj27;

		[MethodImpl((MethodImplOptions)8)]
		public Pay4399Page_obj20_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			switch (connectionId)
			{
			case 20:
				obj20 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 23:
				obj23 = CastExtensions.As<TextBlock>(target);
				break;
			case 24:
				obj24 = CastExtensions.As<TextBlock>(target);
				break;
			case 25:
				obj25 = CastExtensions.As<TextBlock>(target);
				break;
			case 26:
				obj26 = CastExtensions.As<TextBlock>(target);
				break;
			case 27:
				obj27 = CastExtensions.As<TextBlock>(target);
				break;
			case 21:
			case 22:
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
			object target = obj20.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<aMuqLcf6hnKdBTwYqLWe>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<aMuqLcf6hnKdBTwYqLWe>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(aMuqLcf6hnKdBTwYqLWe obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Password(obj.Password, phase);
				Update_SauthStateText(obj.SauthStateText, phase);
				Update_SourceText(obj.SourceText, phase);
				Update_Username(obj.Username, phase);
				Update_SavedAtText(obj.SavedAtText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Password(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj23, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_SauthStateText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj24, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_SourceText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj25, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Username(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj26, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_SavedAtText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj27, obj, null);
			}
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
	private class Pay4399Page_obj30_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IPay4399Page_Bindings
	{
		private pDLYXIf6mU1JnHirkJgm dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj30;

		private TextBlock obj33;

		private TextBlock obj34;

		private TextBlock obj35;

		[MethodImpl((MethodImplOptions)8)]
		public Pay4399Page_obj30_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			switch (connectionId)
			{
			case 30:
				obj30 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 33:
				obj33 = CastExtensions.As<TextBlock>(target);
				break;
			case 34:
				obj34 = CastExtensions.As<TextBlock>(target);
				break;
			case 35:
				obj35 = CastExtensions.As<TextBlock>(target);
				break;
			case 31:
			case 32:
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
			object target = obj30.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<pDLYXIf6mU1JnHirkJgm>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<pDLYXIf6mU1JnHirkJgm>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(pDLYXIf6mU1JnHirkJgm obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_StatusText(obj.StatusText, phase);
				Update_Message(obj.Message, phase);
				Update_CreatedAtText(obj.CreatedAtText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj33, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Message(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj34, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CreatedAtText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj35, obj, null);
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
	private class Pay4399Page_obj1_Bindings : IComponentConnector, IPay4399Page_Bindings
	{
		private Pay4399Page dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ListView obj17;

		private ListView obj28;

		[MethodImpl((MethodImplOptions)8)]
		public Pay4399Page_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 17:
				obj17 = CastExtensions.As<ListView>(target);
				break;
			case 28:
				obj28 = CastExtensions.As<ListView>(target);
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
				dataRoot = CastExtensions.As<Pay4399Page>(newDataRoot);
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
		private void Update_(Pay4399Page obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_GeneratedAccountHistory(obj.GeneratedAccountHistory, phase);
				Update_PendingAccountHistory(obj.PendingAccountHistory, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_GeneratedAccountHistory(ObservableCollection<aMuqLcf6hnKdBTwYqLWe> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PendingAccountHistory(ObservableCollection<pDLYXIf6mU1JnHirkJgm> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj28, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __OnNavigatedTo_b__58_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00ea;
					}
					_u__ = pay4399Page.RestorePendingRegistrationAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__58_0_d>(ref _u__, ref this);
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
				_u__ = global::System.Threading.Tasks.Task.WhenAll(new global::System.Threading.Tasks.Task[2]
				{
					pay4399Page.RefreshAutoRegisterPriceAsync(),
					pay4399Page.RefreshGeneratedAccountHistoryAsync()
				}).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__58_0_d>(ref _u__, ref this);
					return;
				}
				goto IL_00ea;
				IL_00ea:
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
	private struct __Pay4399ClearAccountHistoryButton_Click_b__80_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private TaskAwaiter<EfHHbAf6lkWTXBF13mFF> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter<EfHHbAf6lkWTXBF13mFF> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.a6b04yrJZb().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<EfHHbAf6lkWTXBF13mFF>, __Pay4399ClearAccountHistoryButton_Click_b__80_0_d>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<EfHHbAf6lkWTXBF13mFF>);
					num = (__1__state = -1);
				}
				_u__.GetResult();
				((Collection<aMuqLcf6hnKdBTwYqLWe>)(object)pay4399Page.GeneratedAccountHistory).Clear();
				pay4399Page.UpdateAccountHistoryState();
				pay4399Page.ResetResult();
				AppShell.Success("账号记录已清空");
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

	[CompilerGenerated]
	private sealed class __c__DisplayClass19_0_3
	{
		[StructLayout((LayoutKind)3)]
		private struct __Pay4399RetryChargeButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass19_0_3 __4__this;

			private TaskAwaiter<aCJGY4f6x3vPUWPvvKiU> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass19_0_3 _c__DisplayClass19_0_ = __4__this;
				try
				{
					TaskAwaiter<aCJGY4f6x3vPUWPvvKiU> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.ycq0SyURwo().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aCJGY4f6x3vPUWPvvKiU>, __Pay4399RetryChargeButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<aCJGY4f6x3vPUWPvvKiU>);
						num = (__1__state = -1);
					}
					aCJGY4f6x3vPUWPvvKiU result = _u__.GetResult();
					_c__DisplayClass19_0_.config = result;
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
		private struct __Pay4399RetryChargeButton_Click_b__1_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass19_0_3 __4__this;

			private TaskAwaiter<bool> __u__1;

			private TaskAwaiter<D24rFZf63PEFimGmt3St> __u__2;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__3;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0206: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_01de: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass19_0_3 _c__DisplayClass19_0_ = __4__this;
				try
				{
					bool flag;
					TaskAwaiter<bool> _u__3 = default;
					TaskAwaiter<D24rFZf63PEFimGmt3St> _u__2 = default;
					TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__ = default;
					D24rFZf63PEFimGmt3St result;
					t30hHHfP8gMStFdbd6rB pendingLocalAuthentication;
					switch (num)
					{
					default:
						flag = !_c__DisplayClass19_0_.__4__this._pendingAccountCreated;
						if (flag)
						{
							_u__3 = AppShell.ConfirmAsync("确认注册结果", "上次注册结果未确认。仅在你已确认账号创建成功后继续结算；本次不会重新注册。", "确认已注册").GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __Pay4399RetryChargeButton_Click_b__1_d>(ref _u__3, ref this);
								return;
							}
							goto IL_00a0;
						}
						goto IL_00ab;
					case 0:
						_u__3 = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_00a0;
					case 1:
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<D24rFZf63PEFimGmt3St>);
						num = (__1__state = -1);
						goto IL_0137;
					case 2:
						{
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
							num = (__1__state = -1);
							break;
						}
						IL_00ab:
						if (!flag)
						{
							_c__DisplayClass19_0_.__4__this.RequireRegistrationSession();
							_c__DisplayClass19_0_.__4__this._pendingAccountCreated = true;
							_u__2 = _c__DisplayClass19_0_.__4__this.SettlePendingRegistrationAsync(_c__DisplayClass19_0_.config.Price).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<D24rFZf63PEFimGmt3St>, __Pay4399RetryChargeButton_Click_b__1_d>(ref _u__2, ref this);
								return;
							}
							goto IL_0137;
						}
						goto end_IL_0011;
						IL_0137:
						result = _u__2.GetResult();
						if (result.Charged)
						{
							_u__ = _c__DisplayClass19_0_.__4__this.CompleteDeliveredAccountAsync(result, _c__DisplayClass19_0_.identity, _c__DisplayClass19_0_.__4__this._pendingLocalAuthentication).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__3 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __Pay4399RetryChargeButton_Click_b__1_d>(ref _u__, ref this);
								return;
							}
							break;
						}
						pendingLocalAuthentication = _c__DisplayClass19_0_.__4__this._pendingLocalAuthentication;
						_c__DisplayClass19_0_.result = (t30hHHfP8gMStFdbd6rB)((pendingLocalAuthentication != null && IsUpsmsVerification(pendingLocalAuthentication)) ? ((object)pendingLocalAuthentication) : ((object)BuildChargePendingResult(_c__DisplayClass19_0_.__4__this._pendingLocalAuthentication, result.Message)));
						_c__DisplayClass19_0_.__4__this.ShowChargeRetryPanel(result.Message);
						goto end_IL_0011;
						IL_00a0:
						flag = !_u__3.GetResult();
						goto IL_00ab;
					}
					t30hHHfP8gMStFdbd6rB result2 = _u__.GetResult();
					_c__DisplayClass19_0_.result = result2;
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

		public Pay4399Page __4__this;

		public aCJGY4f6x3vPUWPvvKiU config;

		public t30hHHfP8gMStFdbd6rB result;

		public nNU9JoUBxAhVHRZ6PhH identity;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass19_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _Pay4399RetryChargeButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__Pay4399RetryChargeButton_Click_b__0_d _Pay4399RetryChargeButton_Click_b__0_d = default(__Pay4399RetryChargeButton_Click_b__0_d);
			_Pay4399RetryChargeButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_Pay4399RetryChargeButton_Click_b__0_d.__4__this = this;
			_Pay4399RetryChargeButton_Click_b__0_d.__1__state = -1;
			_Pay4399RetryChargeButton_Click_b__0_d.__t__builder.Start<__Pay4399RetryChargeButton_Click_b__0_d>(ref _Pay4399RetryChargeButton_Click_b__0_d);
			return _Pay4399RetryChargeButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _Pay4399RetryChargeButton_Click_b__1()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__Pay4399RetryChargeButton_Click_b__1_d _Pay4399RetryChargeButton_Click_b__1_d = default(__Pay4399RetryChargeButton_Click_b__1_d);
			_Pay4399RetryChargeButton_Click_b__1_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_Pay4399RetryChargeButton_Click_b__1_d.__4__this = this;
			_Pay4399RetryChargeButton_Click_b__1_d.__1__state = -1;
			_Pay4399RetryChargeButton_Click_b__1_d.__t__builder.Start<__Pay4399RetryChargeButton_Click_b__1_d>(ref _Pay4399RetryChargeButton_Click_b__1_d);
			return _Pay4399RetryChargeButton_Click_b__1_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass21_0_2
	{
		[StructLayout((LayoutKind)3)]
		private struct __CancelPendingRetrievalAsync_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass21_0_2 __4__this;

			private TaskAwaiter<MeC44Rf6zbACPcITLIde> __u__1;

			private TaskAwaiter __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_015b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_0254: Unknown result type (might be due to invalid IL or missing references)
				//IL_0259: Unknown result type (might be due to invalid IL or missing references)
				//IL_0261: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_021c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0221: Unknown result type (might be due to invalid IL or missing references)
				//IL_0239: Unknown result type (might be due to invalid IL or missing references)
				//IL_023b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0123: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass21_0_2 _c__DisplayClass21_0_ = __4__this;
				try
				{
					TaskAwaiter<MeC44Rf6zbACPcITLIde> _u__2 = default;
					TaskAwaiter _u__ = default;
					MeC44Rf6zbACPcITLIde result;
					switch (num)
					{
					default:
						_u__2 = AppShell.Api.nyh0yGcYfD(_c__DisplayClass21_0_.operationId).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MeC44Rf6zbACPcITLIde>, __CancelPendingRetrievalAsync_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_0087;
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<MeC44Rf6zbACPcITLIde>);
						num = (__1__state = -1);
						goto IL_0087;
					case 1:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0177;
					case 2:
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0177:
						_u__.GetResult();
						goto IL_017e;
						IL_0087:
						result = _u__2.GetResult();
						if (AppShell.Api.q3TchNx7iU(_c__DisplayClass21_0_.identity))
						{
							if (result.Cancelled)
							{
								_c__DisplayClass21_0_.cancelled = true;
								if (_c__DisplayClass21_0_.__4__this._pendingChargeOperationId == _c__DisplayClass21_0_.operationId)
								{
									Vo4fPIy7BiQdhKR0A4E registrationSession = _c__DisplayClass21_0_.__4__this._registrationSession;
									if (registrationSession != null && AppShell.Api.q3TchNx7iU(registrationSession))
									{
										_u__ = _c__DisplayClass21_0_.__4__this._pendingRegistrationStore.EI7mzxqGaK(registrationSession.UserId, _c__DisplayClass21_0_.operationId).GetAwaiter();
										if (!_u__.IsCompleted)
										{
											num = (__1__state = 1);
											__u__2 = _u__;
											__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __CancelPendingRetrievalAsync_b__0_d>(ref _u__, ref this);
											return;
										}
										goto IL_0177;
									}
								}
								goto IL_017e;
							}
							AppShell.Warning("取消取号未完成，请稍后重试");
						}
						goto end_IL_0011;
						IL_017e:
						if (AppShell.Api.q3TchNx7iU(_c__DisplayClass21_0_.identity))
						{
							if (string.Equals(_c__DisplayClass21_0_.__4__this._pendingChargeOperationId, _c__DisplayClass21_0_.operationId, (StringComparison)4))
							{
								_c__DisplayClass21_0_.__4__this._pendingChargeOperationId = null;
								_c__DisplayClass21_0_.__4__this._pendingLocalCredentials = null;
								_c__DisplayClass21_0_.__4__this._pendingLocalIdentity = null;
								_c__DisplayClass21_0_.__4__this._pendingLocalAuthentication = null;
								_c__DisplayClass21_0_.__4__this._pendingExpectedPrice = default(decimal);
								((UIElement)_c__DisplayClass21_0_.__4__this.Pay4399ChargeRetryPanel).Visibility = (Visibility)1;
								_c__DisplayClass21_0_.__4__this.ResetResult();
							}
							_u__ = _c__DisplayClass21_0_.__4__this.RefreshGeneratedAccountHistoryAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __CancelPendingRetrievalAsync_b__0_d>(ref _u__, ref this);
								return;
							}
							break;
						}
						goto end_IL_0011;
					}
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

		public string operationId;

		public Pay4399Page __4__this;

		public Vo4fPIy7BiQdhKR0A4E identity;

		public bool cancelled;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass21_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _CancelPendingRetrievalAsync_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__CancelPendingRetrievalAsync_b__0_d _CancelPendingRetrievalAsync_b__0_d = default(__CancelPendingRetrievalAsync_b__0_d);
			_CancelPendingRetrievalAsync_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_CancelPendingRetrievalAsync_b__0_d.__4__this = this;
			_CancelPendingRetrievalAsync_b__0_d.__1__state = -1;
			_CancelPendingRetrievalAsync_b__0_d.__t__builder.Start<__CancelPendingRetrievalAsync_b__0_d>(ref _CancelPendingRetrievalAsync_b__0_d);
			return _CancelPendingRetrievalAsync_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass35_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __Pay4399SmsVerificationRetryRequested_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass35_0_1 __4__this;

			private t30hHHfP8gMStFdbd6rB _result_5__2;

			private global::System.IDisposable __7__wrap2;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__1;

			private TaskAwaiter __u__2;

			private TaskAwaiter<bool> __u__3;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01be: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03af: Unknown result type (might be due to invalid IL or missing references)
				//IL_042e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0433: Unknown result type (might be due to invalid IL or missing references)
				//IL_043b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_036a: Unknown result type (might be due to invalid IL or missing references)
				//IL_036f: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0387: Unknown result type (might be due to invalid IL or missing references)
				//IL_0389: Unknown result type (might be due to invalid IL or missing references)
				//IL_0413: Unknown result type (might be due to invalid IL or missing references)
				//IL_0415: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_017e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0196: Unknown result type (might be due to invalid IL or missing references)
				//IL_0198: Unknown result type (might be due to invalid IL or missing references)
				//IL_0274: Unknown result type (might be due to invalid IL or missing references)
				//IL_0279: Unknown result type (might be due to invalid IL or missing references)
				//IL_0291: Unknown result type (might be due to invalid IL or missing references)
				//IL_0293: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass35_0_1 _c__DisplayClass35_0_ = __4__this;
				try
				{
					TaskAwaiter _u__ = default;
					bool flag;
					TaskAwaiter<bool> _u__2 = default;
					switch (num)
					{
					default:
						__7__wrap2 = HpFsqcfPB2RknTNMlueF.erLfPleUYXa();
						goto case 0;
					case 0:
						try
						{
							TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__3 = default;
							if (num != 0)
							{
								_u__3 = _c__DisplayClass35_0_.__4__this._login4399Service.K1bURgNYIG(_c__DisplayClass35_0_.pending.PendingSauthJson, _c__DisplayClass35_0_.pending.AccountCreated, _c__DisplayClass35_0_.cancellation.Token).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __Pay4399SmsVerificationRetryRequested_b__0_d>(ref _u__3, ref this);
									return;
								}
							}
							else
							{
								_u__3 = __u__1;
								__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
								num = (__1__state = -1);
							}
							t30hHHfP8gMStFdbd6rB result = _u__3.GetResult();
							_result_5__2 = result;
						}
						finally
						{
							if (num < 0 && __7__wrap2 != null)
							{
								__7__wrap2.Dispose();
							}
						}
						__7__wrap2 = null;
						if (_c__DisplayClass35_0_.generation == _c__DisplayClass35_0_.__4__this._smsVerificationGeneration && AppShell.Api.q3TchNx7iU(_c__DisplayClass35_0_.identity))
						{
							if ((int)_result_5__2.Status == 0 && !string.IsNullOrWhiteSpace(_result_5__2.SauthJson))
							{
								if (_c__DisplayClass35_0_.__4__this._pendingChargeOperationId != null)
								{
									_c__DisplayClass35_0_.__4__this._pendingLocalAuthentication = _result_5__2;
									_u__ = _c__DisplayClass35_0_.__4__this.PersistPendingRegistrationAsync().GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 1);
										__u__2 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Pay4399SmsVerificationRetryRequested_b__0_d>(ref _u__, ref this);
										return;
									}
									goto IL_01cd;
								}
								flag = true;
								if (_c__DisplayClass35_0_.source != null && !string.IsNullOrWhiteSpace(_c__DisplayClass35_0_.username) && !string.IsNullOrEmpty(_c__DisplayClass35_0_.password))
								{
									_u__2 = SaveLocalSauthAsync(_c__DisplayClass35_0_.username, _c__DisplayClass35_0_.password, _result_5__2.SauthJson, _c__DisplayClass35_0_.source).GetAwaiter();
									if (!_u__2.IsCompleted)
									{
										num = (__1__state = 2);
										__u__3 = _u__2;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __Pay4399SmsVerificationRetryRequested_b__0_d>(ref _u__2, ref this);
										return;
									}
									goto IL_02c8;
								}
								goto IL_02d1;
							}
							_c__DisplayClass35_0_.__4__this._pendingLocalAuthentication = _result_5__2;
							if (_c__DisplayClass35_0_.__4__this._pendingChargeOperationId == null)
							{
								break;
							}
							_u__ = _c__DisplayClass35_0_.__4__this.PersistPendingRegistrationAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 4);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Pay4399SmsVerificationRetryRequested_b__0_d>(ref _u__, ref this);
								return;
							}
							goto IL_044a;
						}
						goto end_IL_0011;
					case 1:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_01cd;
					case 2:
						_u__2 = __u__3;
						__u__3 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_02c8;
					case 3:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_03be;
					case 4:
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_044a;
						}
						IL_044a:
						_u__.GetResult();
						break;
						IL_02d1:
						if (_c__DisplayClass35_0_.generation == _c__DisplayClass35_0_.__4__this._smsVerificationGeneration && AppShell.Api.q3TchNx7iU(_c__DisplayClass35_0_.identity))
						{
							t30hHHfP8gMStFdbd6rB val = t30hHHfP8gMStFdbd6rB.EfOfPWKFbjf(_result_5__2.SauthJson, flag ? "安全验证已通过，SAuth 已生成并通过认证" : "安全验证已通过；凭证同步失败，请先复制 SAuth 保存");
							val.AccountCreated = _c__DisplayClass35_0_.pending.AccountCreated;
							_c__DisplayClass35_0_.__4__this.ApplyResult(val);
							_c__DisplayClass35_0_.__4__this._pendingLocalAuthentication = null;
							if (_c__DisplayClass35_0_.source != null)
							{
								_u__ = _c__DisplayClass35_0_.__4__this.RefreshGeneratedAccountHistoryAsync().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 3);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Pay4399SmsVerificationRetryRequested_b__0_d>(ref _u__, ref this);
									return;
								}
								goto IL_03be;
							}
						}
						goto end_IL_0011;
						IL_01cd:
						_u__.GetResult();
						if (_c__DisplayClass35_0_.generation == _c__DisplayClass35_0_.__4__this._smsVerificationGeneration && AppShell.Api.q3TchNx7iU(_c__DisplayClass35_0_.identity))
						{
							_c__DisplayClass35_0_.__4__this.ApplyResult(BuildChargePendingResult(_result_5__2, "短信验证已通过；账号结算尚未确认，完成结算后才会导出 SAuth"));
						}
						goto end_IL_0011;
						IL_03be:
						_u__.GetResult();
						goto end_IL_0011;
						IL_02c8:
						flag = _u__2.GetResult();
						goto IL_02d1;
					}
					if (_c__DisplayClass35_0_.generation == _c__DisplayClass35_0_.__4__this._smsVerificationGeneration && AppShell.Api.q3TchNx7iU(_c__DisplayClass35_0_.identity))
					{
						_c__DisplayClass35_0_.__4__this.ApplyResult(_result_5__2);
					}
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

		public Pay4399Page __4__this;

		public t30hHHfP8gMStFdbd6rB pending;

		public CancellationTokenSource cancellation;

		public long generation;

		public Vo4fPIy7BiQdhKR0A4E identity;

		public string source;

		public string username;

		public string password;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass35_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _Pay4399SmsVerificationRetryRequested_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__Pay4399SmsVerificationRetryRequested_b__0_d _Pay4399SmsVerificationRetryRequested_b__0_d = default(__Pay4399SmsVerificationRetryRequested_b__0_d);
			_Pay4399SmsVerificationRetryRequested_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_Pay4399SmsVerificationRetryRequested_b__0_d.__4__this = this;
			_Pay4399SmsVerificationRetryRequested_b__0_d.__1__state = -1;
			_Pay4399SmsVerificationRetryRequested_b__0_d.__t__builder.Start<__Pay4399SmsVerificationRetryRequested_b__0_d>(ref _Pay4399SmsVerificationRetryRequested_b__0_d);
			return _Pay4399SmsVerificationRetryRequested_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass61_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __Pay4399LoginButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass61_0 __4__this;

			private global::System.IDisposable __7__wrap1;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__1;

			private aMuqLcf6hnKdBTwYqLWe _delivered_5__3;

			private TaskAwaiter<bool> __u__2;

			private TaskAwaiter __u__3;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02af: Unknown result type (might be due to invalid IL or missing references)
				//IL_0332: Unknown result type (might be due to invalid IL or missing references)
				//IL_0337: Unknown result type (might be due to invalid IL or missing references)
				//IL_033f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0173: Unknown result type (might be due to invalid IL or missing references)
				//IL_0178: Unknown result type (might be due to invalid IL or missing references)
				//IL_017f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Invalid comparison between Unknown and I4
				//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0317: Unknown result type (might be due to invalid IL or missing references)
				//IL_0319: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0133: Unknown result type (might be due to invalid IL or missing references)
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_015a: Unknown result type (might be due to invalid IL or missing references)
				//IL_026a: Unknown result type (might be due to invalid IL or missing references)
				//IL_026f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0287: Unknown result type (might be due to invalid IL or missing references)
				//IL_0289: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass61_0 _c__DisplayClass61_ = __4__this;
				try
				{
					bool flag;
					TaskAwaiter<bool> _u__2 = default;
					TaskAwaiter _u__ = default;
					switch (num)
					{
					default:
						__7__wrap1 = HpFsqcfPB2RknTNMlueF.erLfPleUYXa();
						goto case 0;
					case 0:
					case 1:
						try
						{
							TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__3 = default;
							if (num != 0)
							{
								if (num == 1)
								{
									_u__3 = __u__1;
									__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
									num = (__1__state = -1);
									goto IL_018e;
								}
								_u__3 = _c__DisplayClass61_.__4__this._login4399Service.LoginAsync(_c__DisplayClass61_.username, _c__DisplayClass61_.password, _c__DisplayClass61_.channel, (nNU9JoUBxAhVHRZ6PhH)null, (Func<string, CancellationToken, global::System.Threading.Tasks.Task<string>>)_c__DisplayClass61_.__4__this.ShowCaptchaDialogAsync, _c__DisplayClass61_.__4__this._registrationCancellation.Token).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __Pay4399LoginButton_Click_b__0_d>(ref _u__3, ref this);
									return;
								}
							}
							else
							{
								_u__3 = __u__1;
								__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
								num = (__1__state = -1);
							}
							t30hHHfP8gMStFdbd6rB result = _u__3.GetResult();
							_c__DisplayClass61_.result = result;
							if (IsDesktop4399ComChannel(_c__DisplayClass61_.channel) && (int)_c__DisplayClass61_.result.Status == 2 && _c__DisplayClass61_.result.Message.StartsWith("该账号需要补充安全校验", (StringComparison)4))
							{
								_u__3 = _c__DisplayClass61_.__4__this.LoginWithIdentityApiAsync(_c__DisplayClass61_.username, _c__DisplayClass61_.password, _c__DisplayClass61_.channel).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 1);
									__u__1 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __Pay4399LoginButton_Click_b__0_d>(ref _u__3, ref this);
									return;
								}
								goto IL_018e;
							}
							goto end_IL_0033;
							IL_018e:
							result = _u__3.GetResult();
							_c__DisplayClass61_.result = result;
							end_IL_0033:;
						}
						finally
						{
							if (num < 0 && __7__wrap1 != null)
							{
								__7__wrap1.Dispose();
							}
						}
						__7__wrap1 = null;
						_c__DisplayClass61_.__4__this.RequireRegistrationSession();
						if ((int)_c__DisplayClass61_.result.Status == 0 && !string.IsNullOrWhiteSpace(_c__DisplayClass61_.result.SauthJson))
						{
							_delivered_5__3 = Enumerable.FirstOrDefault<aMuqLcf6hnKdBTwYqLWe>((global::System.Collections.Generic.IEnumerable<aMuqLcf6hnKdBTwYqLWe>)_c__DisplayClass61_.__4__this.GeneratedAccountHistory, (Func<aMuqLcf6hnKdBTwYqLWe, bool>)_c__DisplayClass61_._Pay4399LoginButton_Click_b__1);
							flag = _delivered_5__3 != null;
							if (flag)
							{
								_u__2 = SaveLocalSauthAsync(_c__DisplayClass61_.username, _c__DisplayClass61_.password, _c__DisplayClass61_.result.SauthJson, _delivered_5__3.Source).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 2);
									__u__2 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __Pay4399LoginButton_Click_b__0_d>(ref _u__2, ref this);
									return;
								}
								goto IL_02be;
							}
							goto IL_02c7;
						}
						goto end_IL_0011;
					case 2:
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_02be;
					case 3:
						{
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_034e;
						}
						IL_02be:
						flag = _u__2.GetResult();
						goto IL_02c7;
						IL_034e:
						_u__.GetResult();
						break;
						IL_02c7:
						if (!flag)
						{
							break;
						}
						_c__DisplayClass61_.__4__this.RequireRegistrationSession();
						_delivered_5__3.SauthJson = _c__DisplayClass61_.result.SauthJson;
						_u__ = _c__DisplayClass61_.__4__this.RefreshGeneratedAccountHistoryAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 3);
							__u__3 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Pay4399LoginButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
						goto IL_034e;
					}
					_delivered_5__3 = null;
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

		public Pay4399Page __4__this;

		public string username;

		public string password;

		public UoSkTNhL6xanDKt2HZ9 channel;

		public t30hHHfP8gMStFdbd6rB result;

		public Func<aMuqLcf6hnKdBTwYqLWe, bool> __9__1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass61_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _Pay4399LoginButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__Pay4399LoginButton_Click_b__0_d _Pay4399LoginButton_Click_b__0_d = default(__Pay4399LoginButton_Click_b__0_d);
			_Pay4399LoginButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_Pay4399LoginButton_Click_b__0_d.__4__this = this;
			_Pay4399LoginButton_Click_b__0_d.__1__state = -1;
			_Pay4399LoginButton_Click_b__0_d.__t__builder.Start<__Pay4399LoginButton_Click_b__0_d>(ref _Pay4399LoginButton_Click_b__0_d);
			return _Pay4399LoginButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Pay4399LoginButton_Click_b__1(aMuqLcf6hnKdBTwYqLWe record)
		{
			if (string.Equals(record.Username, username, (StringComparison)5))
			{
				return string.Equals(record.Password, password, (StringComparison)4);
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass75_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __Pay4399RetryPendingAccountButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass75_0 __4__this;

			private aCJGY4f6x3vPUWPvvKiU _config_5__2;

			private TaskAwaiter<aCJGY4f6x3vPUWPvvKiU> __u__1;

			private TaskAwaiter<bool> __u__2;

			private TaskAwaiter<sl2dDUfRLEcUNZKNoBws> __u__3;

			private TaskAwaiter<D24rFZf63PEFimGmt3St> __u__4;

			private TaskAwaiter __u__5;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__6;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_018b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_023c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0241: Unknown result type (might be due to invalid IL or missing references)
				//IL_0249: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0379: Unknown result type (might be due to invalid IL or missing references)
				//IL_037e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0386: Unknown result type (might be due to invalid IL or missing references)
				//IL_041d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0422: Unknown result type (might be due to invalid IL or missing references)
				//IL_042a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0492: Unknown result type (might be due to invalid IL or missing references)
				//IL_0497: Unknown result type (might be due to invalid IL or missing references)
				//IL_049f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_045a: Unknown result type (might be due to invalid IL or missing references)
				//IL_045f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_029b: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0477: Unknown result type (might be due to invalid IL or missing references)
				//IL_0479: Unknown result type (might be due to invalid IL or missing references)
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_016d: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_0341: Unknown result type (might be due to invalid IL or missing references)
				//IL_0346: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_035e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0360: Unknown result type (might be due to invalid IL or missing references)
				//IL_0204: Unknown result type (might be due to invalid IL or missing references)
				//IL_0209: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_0221: Unknown result type (might be due to invalid IL or missing references)
				//IL_0223: Unknown result type (might be due to invalid IL or missing references)
				//IL_0402: Unknown result type (might be due to invalid IL or missing references)
				//IL_0404: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass75_0 _c__DisplayClass75_ = __4__this;
				try
				{
					TaskAwaiter<aCJGY4f6x3vPUWPvvKiU> _u__6 = default;
					TaskAwaiter<bool> _u__5 = default;
					TaskAwaiter<sl2dDUfRLEcUNZKNoBws> _u__4 = default;
					TaskAwaiter<D24rFZf63PEFimGmt3St> _u__3 = default;
					TaskAwaiter _u__ = default;
					TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__2 = default;
					t30hHHfP8gMStFdbd6rB result;
					aCJGY4f6x3vPUWPvvKiU result2;
					bool flag;
					D24rFZf63PEFimGmt3St val;
					D24rFZf63PEFimGmt3St val2;
					nNU9JoUBxAhVHRZ6PhH identity;
					sl2dDUfRLEcUNZKNoBws result3;
					switch (num)
					{
					default:
						_c__DisplayClass75_.__4__this.RequireRegistrationSession();
						_u__6 = AppShell.Api.ycq0SyURwo().GetAwaiter();
						if (!_u__6.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__6;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aCJGY4f6x3vPUWPvvKiU>, __Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _u__6, ref this);
							return;
						}
						goto IL_009c;
					case 0:
						_u__6 = __u__1;
						__u__1 = default(TaskAwaiter<aCJGY4f6x3vPUWPvvKiU>);
						num = (__1__state = -1);
						goto IL_009c;
					case 1:
						_u__5 = __u__2;
						__u__2 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_01a2;
					case 2:
						_u__4 = __u__3;
						__u__3 = default(TaskAwaiter<sl2dDUfRLEcUNZKNoBws>);
						num = (__1__state = -1);
						goto IL_0258;
					case 3:
						_u__3 = __u__4;
						__u__4 = default(TaskAwaiter<D24rFZf63PEFimGmt3St>);
						num = (__1__state = -1);
						goto IL_02ef;
					case 4:
						_u__ = __u__5;
						__u__5 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0395;
					case 5:
						_u__2 = __u__6;
						__u__6 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
						num = (__1__state = -1);
						goto IL_0439;
					case 6:
						{
							_u__ = __u__5;
							__u__5 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0439:
						result = _u__2.GetResult();
						_c__DisplayClass75_.__4__this.ApplyResult(result);
						_u__ = _c__DisplayClass75_.__4__this.RefreshGeneratedAccountHistoryAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 6);
							__u__5 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
						break;
						IL_009c:
						result2 = _u__6.GetResult();
						_config_5__2 = result2;
						_c__DisplayClass75_.__4__this.RequireRegistrationSession();
						flag = _config_5__2.Price != _c__DisplayClass75_.pending.ExpectedPrice;
						if (flag)
						{
							_u__5 = AppShell.ConfirmAsync("确认新价格", $"自动注册价格已由 {_c__DisplayClass75_.pending.ExpectedPrice:0.##} 变为 {_config_5__2.Price:0.##} 余额，按新价格取回吗？", "继续取回").GetAwaiter();
							if (!_u__5.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__5;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _u__5, ref this);
								return;
							}
							goto IL_01a2;
						}
						goto IL_01ae;
						IL_02f8:
						val = val2;
						_c__DisplayClass75_.__4__this.RequireRegistrationSession();
						LogSettlementState(_c__DisplayClass75_.pending.OperationId, "history-retry", val);
						if (!val.Charged)
						{
							AppShell.Warning(val.Message);
							_u__ = _c__DisplayClass75_.__4__this.RefreshGeneratedAccountHistoryAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 4);
								__u__5 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _u__, ref this);
								return;
							}
							goto IL_0395;
						}
						identity = (string.Equals(_c__DisplayClass75_.__4__this._pendingChargeOperationId, _c__DisplayClass75_.pending.OperationId, (StringComparison)4) ? _c__DisplayClass75_.__4__this._pendingLocalIdentity : null);
						_u__2 = _c__DisplayClass75_.__4__this.CompleteDeliveredAccountAsync(val, identity).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 5);
							__u__6 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_0439;
						IL_02ef:
						val2 = _u__3.GetResult();
						goto IL_02f8;
						IL_01a2:
						flag = !_u__5.GetResult();
						goto IL_01ae;
						IL_01ae:
						if (!flag)
						{
							UoSkTNhL6xanDKt2HZ9 val3 = default(UoSkTNhL6xanDKt2HZ9);
							_u__4 = _c__DisplayClass75_.__4__this.AuthorizeRegistrationAsync(_c__DisplayClass75_.pending.OperationId, _c__DisplayClass75_.pending.CredentialHash, (UoSkTNhL6xanDKt2HZ9)((!global::System.Enum.TryParse<UoSkTNhL6xanDKt2HZ9>(_c__DisplayClass75_.pending.Channel, out val3)) ? 2 : ((int)val3)), _config_5__2.Price).GetAwaiter();
							if (!_u__4.IsCompleted)
							{
								num = (__1__state = 2);
								__u__3 = _u__4;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sl2dDUfRLEcUNZKNoBws>, __Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _u__4, ref this);
								return;
							}
							goto IL_0258;
						}
						goto end_IL_0011;
						IL_0258:
						result3 = _u__4.GetResult();
						if (((D24rFZf63PEFimGmt3St)result3).Charged)
						{
							val2 = (D24rFZf63PEFimGmt3St)(object)result3;
							goto IL_02f8;
						}
						_u__3 = AppShell.Api.Quv08sOr8V(_c__DisplayClass75_.pending.OperationId, _config_5__2.Price, (nNU9JoUBxAhVHRZ6PhH)null, (string)null, result3.AuthorizationToken).GetAwaiter();
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 3);
							__u__4 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<D24rFZf63PEFimGmt3St>, __Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _u__3, ref this);
							return;
						}
						goto IL_02ef;
						IL_0395:
						_u__.GetResult();
						goto end_IL_0011;
					}
					_u__.GetResult();
					end_IL_0011:;
				}
				catch (global::System.Exception exception)
				{
					__1__state = -2;
					_config_5__2 = null;
					__t__builder.SetException(exception);
					return;
				}
				__1__state = -2;
				_config_5__2 = null;
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

		public Pay4399Page __4__this;

		public pDLYXIf6mU1JnHirkJgm pending;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass75_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _Pay4399RetryPendingAccountButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__Pay4399RetryPendingAccountButton_Click_b__0_d _Pay4399RetryPendingAccountButton_Click_b__0_d = default(__Pay4399RetryPendingAccountButton_Click_b__0_d);
			_Pay4399RetryPendingAccountButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_Pay4399RetryPendingAccountButton_Click_b__0_d.__4__this = this;
			_Pay4399RetryPendingAccountButton_Click_b__0_d.__1__state = -1;
			_Pay4399RetryPendingAccountButton_Click_b__0_d.__t__builder.Start<__Pay4399RetryPendingAccountButton_Click_b__0_d>(ref _Pay4399RetryPendingAccountButton_Click_b__0_d);
			return _Pay4399RetryPendingAccountButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass88_0
	{
		[StructLayout((LayoutKind)3)]
		internal struct __ShowCaptchaDialogAsync_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public __c__DisplayClass88_0 __4__this;

			private TaskCompletionSource<string?> __7__wrap1;

			private TaskAwaiter<string?> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass88_0 _c__DisplayClass88_ = __4__this;
				try
				{
					try
					{
						TaskAwaiter<string> _u__ = default;
						if (num != 0)
						{
							__7__wrap1 = _c__DisplayClass88_.completion;
							_u__ = _c__DisplayClass88_.__4__this.ShowCaptchaDialogCoreAsync(_c__DisplayClass88_.base64Image).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, __ShowCaptchaDialogAsync_b__0_d>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<string>);
							num = (__1__state = -1);
						}
						string result = _u__.GetResult();
						__7__wrap1.TrySetResult(result);
						__7__wrap1 = null;
					}
					catch (global::System.Exception)
					{
						_c__DisplayClass88_.completion.TrySetResult((string)null);
					}
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

		public TaskCompletionSource<string?> completion;

		public Pay4399Page __4__this;

		public string base64Image;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass88_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowCaptchaDialogAsync_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowCaptchaDialogAsync_b__0_d _ShowCaptchaDialogAsync_b__0_d = default(__ShowCaptchaDialogAsync_b__0_d);
			_ShowCaptchaDialogAsync_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowCaptchaDialogAsync_b__0_d.__4__this = this;
			_ShowCaptchaDialogAsync_b__0_d.__1__state = -1;
			_ShowCaptchaDialogAsync_b__0_d.__t__builder.Start<__ShowCaptchaDialogAsync_b__0_d>(ref _ShowCaptchaDialogAsync_b__0_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass89_0
	{
		public bool submittedByEnter;

		public ContentDialog dialog;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass89_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowCaptchaDialogCoreAsync_b__0(object _, KeyRoutedEventArgs args)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)args.Key == 13)
			{
				submittedByEnter = true;
				dialog.Hide();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CancelPendingRetrievalAsync_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string operationId;

		public Pay4399Page __4__this;

		private __c__DisplayClass21_0_2 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0068;
				}
				__8__1 = (__c__DisplayClass21_0_2)new __c__DisplayClass21_0_2();
				__8__1.operationId = operationId;
				__8__1.__4__this = __4__this;
				if (!pay4399Page._registrationRunning && !pay4399Page._smsVerificationRunning)
				{
					pay4399Page._registrationRunning = true;
					goto IL_0068;
				}
				goto end_IL_0011;
				IL_0068:
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<bool> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_017f;
						}
						pay4399Page.BeginRegistrationSession();
						__8__1.identity = AppShell.Api.E55c4UCxKQ();
						_u__2 = AppShell.ConfirmAsync("取消取号", "该账号已在 4399 注册。取消只会放弃本次取回，不会注销 4399 账号；本次不扣费，取消后也无法再重试取回。确定取消吗？", "确认取消").GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _CancelPendingRetrievalAsync_d__21>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
					}
					if (_u__2.GetResult())
					{
						__8__1.cancelled = false;
						pay4399Page.RequireRegistrationSession();
						_u__ = AppShell.RunAsync(__8__1._CancelPendingRetrievalAsync_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CancelPendingRetrievalAsync_d__21>(ref _u__, ref this);
							return;
						}
						goto IL_017f;
					}
					goto end_IL_0068;
					IL_017f:
					_u__.GetResult();
					if (__8__1.cancelled)
					{
						AppShell.Success("已取消取号，本次未扣费");
					}
					end_IL_0068:;
				}
				catch (OperationCanceledException)
				{
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "CancelPendingRetrievalAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Pay4399Page.Registration.cs", 225));
				}
				finally
				{
					if (num < 0)
					{
						pay4399Page._registrationRunning = false;
					}
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
	private struct _OnNavigatedTo_d__58 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		public NavigationEventArgs e;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page __8_locals2 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					__8_locals2.__n__0(e);
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__OnNavigatedTo_b__58_0_d _OnNavigatedTo_b__58_0_d = default(__OnNavigatedTo_b__58_0_d);
						_OnNavigatedTo_b__58_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_OnNavigatedTo_b__58_0_d.__4__this = __8_locals2;
						_OnNavigatedTo_b__58_0_d.__1__state = -1;
						_OnNavigatedTo_b__58_0_d.__t__builder.Start<__OnNavigatedTo_b__58_0_d>(ref _OnNavigatedTo_b__58_0_d);
						return _OnNavigatedTo_b__58_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__58>(ref _u__, ref this);
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
	private struct _Pay4399CancelChargeButton_Click_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public Pay4399Page __4__this;

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
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0084;
				}
				if (!string.IsNullOrWhiteSpace(pay4399Page._pendingChargeOperationId))
				{
					_u__ = pay4399Page.CancelPendingRetrievalAsync(pay4399Page._pendingChargeOperationId).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399CancelChargeButton_Click_d__20>(ref _u__, ref this);
						return;
					}
					goto IL_0084;
				}
				goto end_IL_0011;
				IL_0084:
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
	private struct _Pay4399CancelPendingAccountButton_Click_d__76 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public Pay4399Page __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_009b;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object dataContext = ((FrameworkElement)val).DataContext;
					pDLYXIf6mU1JnHirkJgm val2 = (pDLYXIf6mU1JnHirkJgm)((dataContext is pDLYXIf6mU1JnHirkJgm) ? dataContext : null);
					if (val2 != null)
					{
						_u__ = pay4399Page.CancelPendingRetrievalAsync(val2.OperationId).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399CancelPendingAccountButton_Click_d__76>(ref _u__, ref this);
							return;
						}
						goto IL_009b;
					}
				}
				goto end_IL_0011;
				IL_009b:
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
	private struct _Pay4399ClearAccountHistoryButton_Click_d__80 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page __8_locals2 = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_0098;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_010b;
				}
				if (((Collection<aMuqLcf6hnKdBTwYqLWe>)(object)__8_locals2.GeneratedAccountHistory).Count != 0)
				{
					_u__ = AppShell.ConfirmAsync("清空账号记录", "将删除全部已交付的 4399 账号、密码和 SAUTH；待取回账号不受影响。", "清空").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _Pay4399ClearAccountHistoryButton_Click_d__80>(ref _u__, ref this);
						return;
					}
					goto IL_0098;
				}
				goto end_IL_0011;
				IL_010b:
				_u__2.GetResult();
				goto end_IL_0011;
				IL_0098:
				if (_u__.GetResult())
				{
					_u__2 = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__Pay4399ClearAccountHistoryButton_Click_b__80_0_d _Pay4399ClearAccountHistoryButton_Click_b__80_0_d = default(__Pay4399ClearAccountHistoryButton_Click_b__80_0_d);
						_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__4__this = __8_locals2;
						_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__1__state = -1;
						_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__t__builder.Start<__Pay4399ClearAccountHistoryButton_Click_b__80_0_d>(ref _Pay4399ClearAccountHistoryButton_Click_b__80_0_d);
						return _Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399ClearAccountHistoryButton_Click_d__80>(ref _u__2, ref this);
						return;
					}
					goto IL_010b;
				}
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
	private struct _Pay4399LoginButton_Click_d__61 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private __c__DisplayClass61_0 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Invalid comparison between Unknown and I4
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0056;
				}
				__8__1 = (__c__DisplayClass61_0)new __c__DisplayClass61_0();
				__8__1.__4__this = __4__this;
				if (!pay4399Page._registrationRunning && !pay4399Page._smsVerificationRunning)
				{
					pay4399Page._registrationRunning = true;
					goto IL_0056;
				}
				goto end_IL_0011;
				IL_0056:
				try
				{
					TaskAwaiter _u__ = default;
					if (num == 0)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0190;
					}
					pay4399Page.BeginRegistrationSession();
					if (pay4399Page._pendingChargeOperationId != null)
					{
						AppShell.Warning("请先完成待结算账号的取回，再开始新的登录");
					}
					else if (pay4399Page._pendingSmsVerification != null)
					{
						AppShell.Warning("请先完成当前上行短信验证，再开始新的登录");
					}
					else
					{
						__8__1.username = pay4399Page.Pay4399UsernameBox.Text.Trim();
						__8__1.password = pay4399Page.Pay4399PasswordBox.Password;
						__8__1.channel = pay4399Page.GetSelectedChannel();
						if (!string.IsNullOrWhiteSpace(__8__1.username) && !string.IsNullOrEmpty(__8__1.password))
						{
							pay4399Page.ResetResult();
							pay4399Page.ResetCaptchaRecognition();
							__8__1.result = null;
							_u__ = AppShell.RunAsync(__8__1._Pay4399LoginButton_Click_b__0).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399LoginButton_Click_d__61>(ref _u__, ref this);
								return;
							}
							goto IL_0190;
						}
						AppShell.Error("请输入 4399 账号和密码");
					}
					goto end_IL_0056;
					IL_0190:
					_u__.GetResult();
					pay4399Page.RequireRegistrationSession();
					t30hHHfP8gMStFdbd6rB obj = __8__1.result;
					if (obj != null && (int)obj.Status == 0 && !string.IsNullOrWhiteSpace(__8__1.result.SauthJson))
					{
						__8__1.result = t30hHHfP8gMStFdbd6rB.EfOfPWKFbjf(__8__1.result.SauthJson, __8__1.result.Message);
					}
					pay4399Page.ApplyResult(__8__1.result);
					end_IL_0056:;
				}
				catch (OperationCanceledException)
				{
				}
				catch (global::System.Exception exception)
				{
					if (AppShell.Api.q3TchNx7iU(pay4399Page._registrationSession))
					{
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "Pay4399LoginButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Pay4399Page.xaml.cs", 165));
					}
				}
				finally
				{
					if (num < 0)
					{
						pay4399Page._registrationRunning = false;
					}
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
	private struct _Pay4399RetryChargeButton_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private __c__DisplayClass19_0_3 __8__1;

		private TaskAwaiter __u__1;

		private TaskAwaiter<bool> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				if ((uint)num <= 3u)
				{
					goto IL_0057;
				}
				__8__1 = (__c__DisplayClass19_0_3)new __c__DisplayClass19_0_3();
				__8__1.__4__this = __4__this;
				if (!pay4399Page._registrationRunning && !pay4399Page._smsVerificationRunning)
				{
					pay4399Page._registrationRunning = true;
					goto IL_0057;
				}
				goto end_IL_0011;
				IL_0057:
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<bool> _u__2 = default;
					bool flag;
					switch (num)
					{
					default:
					{
						pay4399Page.BeginRegistrationSession();
						Login4399GeneratedCredentials? pendingLocalCredentials = pay4399Page._pendingLocalCredentials;
						__8__1.identity = pay4399Page._pendingLocalIdentity;
						string pendingChargeOperationId = pay4399Page._pendingChargeOperationId;
						if ((object)pendingLocalCredentials != null && !string.IsNullOrEmpty(pendingChargeOperationId))
						{
							__8__1.config = null;
							_u__ = AppShell.RunAsync(__8__1._Pay4399RetryChargeButton_Click_b__0).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399RetryChargeButton_Click_d__19>(ref _u__, ref this);
								return;
							}
							goto IL_0119;
						}
						goto end_IL_0057;
					}
					case 0:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0119;
					case 1:
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_0225;
					case 2:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_02b0;
					case 3:
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0225:
						flag = !_u__2.GetResult();
						goto IL_0231;
						IL_0231:
						if (!flag)
						{
							__8__1.result = null;
							_u__ = AppShell.RunAsync(__8__1._Pay4399RetryChargeButton_Click_b__1).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399RetryChargeButton_Click_d__19>(ref _u__, ref this);
								return;
							}
							goto IL_02b0;
						}
						goto end_IL_0057;
						IL_02b0:
						_u__.GetResult();
						if (AppShell.Api.q3TchNx7iU(pay4399Page._registrationSession))
						{
							pay4399Page.ApplyResult(__8__1.result);
							_u__ = AppShell.RunAsync(pay4399Page.RefreshGeneratedAccountHistoryAsync).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 3);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399RetryChargeButton_Click_d__19>(ref _u__, ref this);
								return;
							}
							break;
						}
						goto end_IL_0057;
						IL_0119:
						_u__.GetResult();
						pay4399Page.RequireRegistrationSession();
						if (__8__1.config != null)
						{
							flag = __8__1.config.Price != pay4399Page._pendingExpectedPrice;
							if (flag)
							{
								_u__2 = AppShell.ConfirmAsync("确认新价格", $"自动注册价格已由 {pay4399Page._pendingExpectedPrice:0.##} 变为 {__8__1.config.Price:0.##} 余额，按新价格取回吗？", "继续取回").GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _Pay4399RetryChargeButton_Click_d__19>(ref _u__2, ref this);
									return;
								}
								goto IL_0225;
							}
							goto IL_0231;
						}
						goto end_IL_0057;
					}
					_u__.GetResult();
					end_IL_0057:;
				}
				catch (OperationCanceledException)
				{
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "Pay4399RetryChargeButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Pay4399Page.Registration.cs", 164));
				}
				finally
				{
					if (num < 0)
					{
						pay4399Page._registrationRunning = false;
					}
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
	private struct _Pay4399RetryPendingAccountButton_Click_d__75 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004c;
				}
				__c__DisplayClass75_0 _c__DisplayClass75_ = (__c__DisplayClass75_0)new __c__DisplayClass75_0
				{
					__4__this = __4__this
				};
				if (!pay4399Page._registrationRunning && !pay4399Page._smsVerificationRunning)
				{
					pay4399Page._registrationRunning = true;
					goto IL_004c;
				}
				goto end_IL_0011;
				IL_004c:
				try
				{
					TaskAwaiter _u__ = default;
					if (num == 0)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_014e;
					}
					pay4399Page.BeginRegistrationSession();
					if (pay4399Page._pendingChargeOperationId == null)
					{
						goto IL_00af;
					}
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val == null)
					{
						goto IL_00af;
					}
					object dataContext = ((FrameworkElement)val).DataContext;
					pDLYXIf6mU1JnHirkJgm val2 = (pDLYXIf6mU1JnHirkJgm)((dataContext is pDLYXIf6mU1JnHirkJgm) ? dataContext : null);
					if (val2 == null || !(val2.OperationId != pay4399Page._pendingChargeOperationId))
					{
						goto IL_00af;
					}
					AppShell.Warning("请先完成当前待结算操作。");
					goto end_IL_004c;
					IL_00af:
						_c__DisplayClass75_ = default;
					object obj2 = sender;
					val = (Button)((obj2 is Button) ? obj2 : null);
					if (val != null)
					{
						object dataContext2 = ((FrameworkElement)val).DataContext;
						_c__DisplayClass75_.pending = (pDLYXIf6mU1JnHirkJgm)((dataContext2 is pDLYXIf6mU1JnHirkJgm) ? dataContext2 : null);
						if (_c__DisplayClass75_.pending != null)
						{
							_u__ = AppShell.RunAsync(_c__DisplayClass75_._Pay4399RetryPendingAccountButton_Click_b__0).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399RetryPendingAccountButton_Click_d__75>(ref _u__, ref this);
								return;
							}
							goto IL_014e;
						}
					}
					goto end_IL_004c;
					IL_014e:
					_u__.GetResult();
					end_IL_004c:;
				}
				catch (OperationCanceledException)
				{
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "Pay4399RetryPendingAccountButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Pay4399Page.xaml.cs", 397));
				}
				finally
				{
					if (num < 0)
					{
						pay4399Page._registrationRunning = false;
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
	private struct _Pay4399SmsVerificationRetryRequested_d__35 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private __c__DisplayClass35_0_1 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0103;
				}
				__8__1 = (__c__DisplayClass35_0_1)new __c__DisplayClass35_0_1();
				__8__1.__4__this = __4__this;
				__8__1.pending = pay4399Page._pendingSmsVerification;
				if (!pay4399Page._registrationRunning && !pay4399Page._smsVerificationRunning && __8__1.pending != null && IsUpsmsVerification(__8__1.pending))
				{
					__8__1.generation = pay4399Page._smsVerificationGeneration;
					__8__1.identity = AppShell.Api.E55c4UCxKQ();
					if (__8__1.identity != null)
					{
						__8__1.username = pay4399Page._pendingSmsUsername;
						__8__1.password = pay4399Page._pendingSmsPassword;
						__8__1.source = pay4399Page._pendingSmsAccountSource;
						__8__1.cancellation = new CancellationTokenSource();
						goto IL_0103;
					}
				}
				goto end_IL_0011;
				IL_0103:
				try
				{
					if (num != 0)
					{
						pay4399Page._smsVerificationCancellation = __8__1.cancellation;
						pay4399Page._smsVerificationRunning = true;
						pay4399Page.Pay4399SmsVerificationPanel.SetOperationRunning(running: true);
						pay4399Page.Pay4399StatusText.Text = "正在复查上行短信验证";
					}
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = AppShell.RunAsync(__8__1._Pay4399SmsVerificationRetryRequested_b__0).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Pay4399SmsVerificationRetryRequested_d__35>(ref _u__, ref this);
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
					catch (global::System.Exception ex)
					{
						if (AppShell.Api.q3TchNx7iU(__8__1.identity))
						{
							gX17swyO7x0JWQxdaD1.U3iyRWfbJV("Pay4399", "上行短信验证复查异常: errorType=" + ((MemberInfo)ex.GetType()).Name, ex);
							AppShell.Error("短信验证复查失败，请确认短信已发送后重试");
						}
					}
					finally
					{
						if (num < 0)
						{
							if (pay4399Page._smsVerificationCancellation == __8__1.cancellation)
							{
								pay4399Page._smsVerificationCancellation = null;
							}
							pay4399Page._smsVerificationRunning = false;
							pay4399Page.Pay4399SmsVerificationPanel.SetOperationRunning(running: false);
						}
					}
				}
				finally
				{
					if (num < 0 && __8__1.cancellation != null)
					{
						((global::System.IDisposable)__8__1.cancellation).Dispose();
					}
				}
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
	private struct _PersistPendingRegistrationAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_011d;
				}
				pay4399Page.RequireRegistrationSession();
				Login4399GeneratedCredentials pendingLocalCredentials = pay4399Page._pendingLocalCredentials;
				if ((object)pendingLocalCredentials != null && pay4399Page._pendingChargeOperationId != null)
				{
					_u__ = pay4399Page._pendingRegistrationStore.Fiimik4e3A(new MfGcM9fRZdaoDdtW4LPn
					{
						UserId = pay4399Page._registrationSession.UserId,
						MachineHash = pay4399Page._registrationSession.MachineHash,
						OperationId = pay4399Page._pendingChargeOperationId,
						Username = pendingLocalCredentials.Username,
						Password = pendingLocalCredentials.Password,
						Channel = pay4399Page._pendingLocalChannel,
						ExpectedPrice = pay4399Page._pendingExpectedPrice,
						AccountCreated = pay4399Page._pendingAccountCreated,
						Identity = pay4399Page._pendingLocalIdentity,
						Authentication = pay4399Page._pendingLocalAuthentication
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PersistPendingRegistrationAsync_d__9>(ref _u__, ref this);
						return;
					}
					goto IL_011d;
				}
				goto end_IL_0011;
				IL_011d:
				_u__.GetResult();
				pay4399Page.RequireRegistrationSession();
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
	private struct _RefreshAutoRegisterPriceAsync_d__62 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private Vo4fPIy7BiQdhKR0A4E _identity_5__2;

		private TaskAwaiter<aCJGY4f6x3vPUWPvvKiU> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter<aCJGY4f6x3vPUWPvvKiU> _u__ = default;
				if (num != 0)
				{
					_identity_5__2 = AppShell.Api.E55c4UCxKQ();
					_u__ = AppShell.Api.ycq0SyURwo().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aCJGY4f6x3vPUWPvvKiU>, _RefreshAutoRegisterPriceAsync_d__62>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<aCJGY4f6x3vPUWPvvKiU>);
					num = (__1__state = -1);
				}
				aCJGY4f6x3vPUWPvvKiU result = _u__.GetResult();
				if (AppShell.Api.q3TchNx7iU(_identity_5__2))
				{
					pay4399Page.ApplyAutoRegisterPrice(result.Price);
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_identity_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_identity_5__2 = null;
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
	private struct _RefreshGeneratedAccountHistoryAsync_d__73 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private Vo4fPIy7BiQdhKR0A4E _identity_5__2;

		private TaskAwaiter<JyJsm5f6rQRkgIZ5dbQv> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter<JyJsm5f6rQRkgIZ5dbQv> _u__ = default;
				if (num != 0)
				{
					_identity_5__2 = AppShell.Api.E55c4UCxKQ();
					_u__ = AppShell.Api.RVE0Q1BJmx().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<JyJsm5f6rQRkgIZ5dbQv>, _RefreshGeneratedAccountHistoryAsync_d__73>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<JyJsm5f6rQRkgIZ5dbQv>);
					num = (__1__state = -1);
				}
				JyJsm5f6rQRkgIZ5dbQv result = _u__.GetResult();
				if (AppShell.Api.q3TchNx7iU(_identity_5__2))
				{
					((Collection<aMuqLcf6hnKdBTwYqLWe>)(object)pay4399Page.GeneratedAccountHistory).Clear();
					var enumerator = result.Accounts.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							aMuqLcf6hnKdBTwYqLWe current = enumerator.Current;
							((Collection<aMuqLcf6hnKdBTwYqLWe>)(object)pay4399Page.GeneratedAccountHistory).Add(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					((Collection<pDLYXIf6mU1JnHirkJgm>)(object)pay4399Page.PendingAccountHistory).Clear();
					var enumerator2 = result.PendingAccounts.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							pDLYXIf6mU1JnHirkJgm current2 = enumerator2.Current;
							((Collection<pDLYXIf6mU1JnHirkJgm>)(object)pay4399Page.PendingAccountHistory).Add(current2);
						}
					}
					finally
					{
						if (num < 0)
						{
							((global::System.IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
						}
					}
					pay4399Page.UpdateAccountHistoryState();
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_identity_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_identity_5__2 = null;
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
	private struct _RestorePendingRegistrationAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Pay4399Page __4__this;

		private Vo4fPIy7BiQdhKR0A4E _identity_5__2;

		private TaskAwaiter<MfGcM9fRZdaoDdtW4LPn?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			Pay4399Page pay4399Page = __4__this;
			try
			{
				TaskAwaiter<MfGcM9fRZdaoDdtW4LPn> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<MfGcM9fRZdaoDdtW4LPn>);
					num = (__1__state = -1);
					goto IL_00c4;
				}
				if (!pay4399Page._registrationRunning && pay4399Page._pendingChargeOperationId == null)
				{
					_identity_5__2 = AppShell.Api.E55c4UCxKQ();
					if (_identity_5__2 != null)
					{
						_u__ = pay4399Page._pendingRegistrationStore.FgYmnnbQeA(_identity_5__2.UserId, _identity_5__2.MachineHash).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MfGcM9fRZdaoDdtW4LPn>, _RestorePendingRegistrationAsync_d__10>(ref _u__, ref this);
							return;
						}
						goto IL_00c4;
					}
				}
				goto end_IL_0011;
				IL_00c4:
				MfGcM9fRZdaoDdtW4LPn result = _u__.GetResult();
				if (!pay4399Page._registrationRunning && pay4399Page._pendingChargeOperationId == null && AppShell.Api.q3TchNx7iU(_identity_5__2) && result != null)
				{
					pay4399Page.BeginRegistrationSession();
					pay4399Page._pendingChargeOperationId = result.OperationId;
					pay4399Page._pendingLocalCredentials = (Login4399GeneratedCredentials?)new Login4399GeneratedCredentials(result.Username, result.Password);
					pay4399Page._pendingLocalChannel = result.Channel;
					pay4399Page._pendingExpectedPrice = result.ExpectedPrice;
					pay4399Page._pendingLocalIdentity = result.Identity;
					pay4399Page._pendingLocalAuthentication = result.Authentication;
					pay4399Page._pendingAccountCreated = result.AccountCreated;
					pay4399Page.ShowChargeRetryPanel(result.AccountCreated ? "已恢复待结算账号，点击重试取号完成结算。" : "上次本地注册结果未确认，请先确认注册结果再重试取号；不会自动重新注册。");
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_identity_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_identity_5__2 = null;
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

	private readonly lskjRmm2JeVZWsE0GiI _pendingRegistrationStore;

	private Vo4fPIy7BiQdhKR0A4E? _registrationSession;

	private CancellationTokenSource? _registrationCancellation;

	private string? _registrationAuthorizationToken;

	private bool _registrationRunning;

	private bool _pendingAccountCreated;

	private t30hHHfP8gMStFdbd6rB? _pendingSmsVerification;

	private string? _pendingSmsUsername;

	private string? _pendingSmsPassword;

	private string? _pendingSmsAccountSource;

	private bool _smsVerificationRunning;

	private long _smsVerificationGeneration;

	private CancellationTokenSource? _smsVerificationCancellation;

	private const int MaxAutomaticCaptchaAttempts = 3;

	private const int MaxManualCaptchaAttempts = 2;

	private readonly y9aNRQUHZQ5lu0018x9 _login4399Service;

	private readonly CaptchaOcrService _captchaOcrService;

	private readonly LqCNIN7faHo3aBdfb2m _personIdentityApiClient;

	private int _automaticCaptchaAttemptsRemaining;

	private int _manualCaptchaAttemptsRemaining;

	private int _captchaAttemptLimitReached;

	private string _lastSauthWrapper;

	private string? _pendingChargeOperationId;

	private Login4399GeneratedCredentials? _pendingLocalCredentials;

	private nNU9JoUBxAhVHRZ6PhH? _pendingLocalIdentity;

	private t30hHHfP8gMStFdbd6rB? _pendingLocalAuthentication;

	private UoSkTNhL6xanDKt2HZ9 _pendingLocalChannel;

	private decimal _pendingExpectedPrice;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition AccountFormColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactConversion;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideConversion;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border AccountInputPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border SauthResultPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SmsVerificationView Pay4399SmsVerificationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox Pay4399ResultBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button Pay4399CopyResultButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox Pay4399SauthFormatComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBar ModeSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel AccountFormPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel AccountHistoryPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Pay4399StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel Pay4399PendingHistoryPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView Pay4399AccountHistoryList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border Pay4399AccountHistoryEmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button Pay4399ClearAccountHistoryButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Pay4399AccountHistoryCountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox Pay4399UsernameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox Pay4399PasswordBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox Pay4399ChannelComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel LoginModePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel RegisterModePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button Pay4399AutoRegisterButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Pay4399AutoRegisterPriceText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel Pay4399ChargeRetryPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel Pay4399GeneratedAccountPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox Pay4399GeneratedAccountBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button Pay4399CopyGeneratedAccountButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Pay4399ChargeRetryReasonText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button Pay4399RetryChargeButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button Pay4399LoginButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBarItem ModeLoginItem;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBarItem ModeRegisterItem;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBarItem ModeHistoryItem;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IPay4399Page_Bindings Bindings;

	[field: CompilerGenerated]
	private ObservableCollection<aMuqLcf6hnKdBTwYqLWe> _GeneratedAccountHistory_k__BackingField;
	public ObservableCollection<aMuqLcf6hnKdBTwYqLWe> GeneratedAccountHistory
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	private ObservableCollection<pDLYXIf6mU1JnHirkJgm> _PendingAccountHistory_k__BackingField;
	public ObservableCollection<pDLYXIf6mU1JnHirkJgm> PendingAccountHistory
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RequireRegistrationSession()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (AppShell.Api.q3TchNx7iU(_registrationSession))
		{
			CancellationTokenSource? registrationCancellation = _registrationCancellation;
			if (registrationCancellation == null || !registrationCancellation.IsCancellationRequested)
			{
				return;
			}
		}
		throw new OperationCanceledException("登录状态已改变，已停止原注册操作。");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BeginRegistrationSession()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		CancellationTokenSource? registrationCancellation = _registrationCancellation;
		if (registrationCancellation != null)
		{
			registrationCancellation.Cancel();
		}
		CancellationTokenSource? registrationCancellation2 = _registrationCancellation;
		if (registrationCancellation2 != null)
		{
			registrationCancellation2.Dispose();
		}
		_registrationCancellation = new CancellationTokenSource();
		_registrationSession = AppShell.Api.E55c4UCxKQ() ?? throw new InvalidOperationException("请先登录 Chronal。");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<sl2dDUfRLEcUNZKNoBws> AuthorizeRegistrationAsync(string operationId, string credentialHash, UoSkTNhL6xanDKt2HZ9 channel, decimal price)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		RequireRegistrationSession();
		sl2dDUfRLEcUNZKNoBws val = await AppShell.Api.WKr8swcjXE(new FmlYAFfRXFYUFYH54AEo
		{
			OperationId = operationId,
			CredentialHash = credentialHash,
			Channel = ((object)(channel)/*cast due to .constrained prefix*/).ToString(),
			ExpectedPrice = price
		}, _registrationCancellation.Token);
		RequireRegistrationSession();
		_registrationAuthorizationToken = val.AuthorizationToken;
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task PersistPendingRegistrationAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PersistPendingRegistrationAsync_d__9 persistPendingRegistrationAsync_d__ = default(_PersistPendingRegistrationAsync_d__9);
		persistPendingRegistrationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		persistPendingRegistrationAsync_d__.__4__this = this;
		persistPendingRegistrationAsync_d__.__1__state = -1;
		persistPendingRegistrationAsync_d__.__t__builder.Start<_PersistPendingRegistrationAsync_d__9>(ref persistPendingRegistrationAsync_d__);
		return persistPendingRegistrationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RestorePendingRegistrationAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RestorePendingRegistrationAsync_d__10 restorePendingRegistrationAsync_d__ = default(_RestorePendingRegistrationAsync_d__10);
		restorePendingRegistrationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		restorePendingRegistrationAsync_d__.__4__this = this;
		restorePendingRegistrationAsync_d__.__1__state = -1;
		restorePendingRegistrationAsync_d__.__t__builder.Start<_RestorePendingRegistrationAsync_d__10>(ref restorePendingRegistrationAsync_d__);
		return restorePendingRegistrationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<D24rFZf63PEFimGmt3St> SettlePendingRegistrationAsync(decimal price)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		RequireRegistrationSession();
		Login4399GeneratedCredentials login4399GeneratedCredentials = _pendingLocalCredentials ?? throw new InvalidOperationException("待结算凭据不存在。");
		string operationId = _pendingChargeOperationId ?? throw new InvalidOperationException("待结算操作不存在。");
		sl2dDUfRLEcUNZKNoBws val = await AuthorizeRegistrationAsync(operationId, v5OiSQSzC8GipXkQ3VG.qhp8FJsZcZ(login4399GeneratedCredentials.Username, login4399GeneratedCredentials.Password), _pendingLocalChannel, price);
		if (((D24rFZf63PEFimGmt3St)val).Charged)
		{
			return (D24rFZf63PEFimGmt3St)(object)val;
		}
		_pendingExpectedPrice = price;
		await PersistPendingRegistrationAsync();
		return await FinalizeAutoRegisterAsync(new Jv4EMLf6aYXWrIFaB4Ra
		{
			OperationId = operationId,
			ExpectedPrice = price,
			AuthorizationToken = _registrationAuthorizationToken,
			Username = login4399GeneratedCredentials.Username,
			Password = login4399GeneratedCredentials.Password
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void LogSettlementState(string operationId, string stage, D24rFZf63PEFimGmt3St response)
	{
		string text = response.Message ?? string.Empty;
		gX17swyO7x0JWQxdaD1.IdOy6I4Chb("Pay4399", $"服务端结算状态: operationId={operationId}, stage={stage}, charged={response.Charged}, needClientLogin={response.NeedClientLogin}, needCaptcha={response.NeedCaptcha}, needRealName={response.NeedRealName}, abnormalLogin={text.Contains("login abnormally", (StringComparison)5)}, smsInstruction={text.Contains("上行短信", (StringComparison)4)}, messageChars={text.Length}");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> AuthenticateGeneratedAccountAsync(Login4399GeneratedCredentials credentials, nNU9JoUBxAhVHRZ6PhH identity, UoSkTNhL6xanDKt2HZ9 channel)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		ResetCaptchaRecognition();
		try
		{
			t30hHHfP8gMStFdbd6rB val;
			using (HpFsqcfPB2RknTNMlueF.erLfPleUYXa())
			{
				val = await _login4399Service.LoginAsync(credentials.Username, credentials.Password, channel, identity, (Func<string, CancellationToken, global::System.Threading.Tasks.Task<string>>)ShowCaptchaDialogAsync, _registrationCancellation.Token);
			}
			val.AccountCreated = true;
			RequireRegistrationSession();
			if (IsUpsmsVerification(val))
			{
				gX17swyO7x0JWQxdaD1.IdOy6I4Chb("Pay4399", "新注册账号需要上行短信验证，暂存原 SAuth 等待用户完成验证");
			}
			return val;
		}
		catch (global::System.Exception ex)
		{
			gX17swyO7x0JWQxdaD1.U3iyRWfbJV("Pay4399", "新注册账号本地 SAuth 生成异常: errorType=" + ((MemberInfo)ex.GetType()).Name, ex);
			t30hHHfP8gMStFdbd6rB obj = t30hHHfP8gMStFdbd6rB.Fail("账号已注册，本地 SAuth 暂未完成；扣费确认后可重试登录");
			obj.AccountCreated = true;
			return obj;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static t30hHHfP8gMStFdbd6rB BuildChargePendingResult(t30hHHfP8gMStFdbd6rB? authentication, string reason)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (authentication != null && IsUpsmsVerification(authentication))
		{
			t30hHHfP8gMStFdbd6rB obj = t30hHHfP8gMStFdbd6rB.DjBfPQdn12i(authentication.Ticket ?? string.Empty, authentication.VerifyUrl, authentication.UpsmsContent, authentication.UpsmsNumber, authentication.UpsmsBackupNumber, authentication.Message + "；" + reason, authentication.PendingSauthJson);
			obj.AccountCreated = true;
			return obj;
		}
		t30hHHfP8gMStFdbd6rB obj2 = t30hHHfP8gMStFdbd6rB.Fail((authentication != null && (int)authentication.Status == 0) ? ("注册操作已保存，结算确认前不展示账号或 SAuth，本地 SAuth 已生成；" + reason + "。结算确认前暂不导出 SAuth。") : $"{"注册操作已保存，结算确认前不展示账号或 SAuth"}；{((authentication != null) ? authentication.Message : null) ?? "本地 SAuth 尚未完成"}；{reason}");
		obj2.AccountCreated = true;
		return obj2;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> CompleteDeliveredAccountAsync(D24rFZf63PEFimGmt3St delivery, nNU9JoUBxAhVHRZ6PhH? identity, t30hHHfP8gMStFdbd6rB? prevalidatedAuthentication = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!delivery.Charged || string.IsNullOrWhiteSpace(delivery.Username) || string.IsNullOrEmpty(delivery.Password))
		{
			return ShowChargeRetryPanel("结算响应缺少已交付账号，请用相同操作编号重试取回");
		}
		RequireRegistrationSession();
		Vo4fPIy7BiQdhKR0A4E registrationSession = _registrationSession;
		Login4399GeneratedCredentials pendingLocalCredentials = _pendingLocalCredentials;
		if ((object)pendingLocalCredentials != null && (!string.Equals(pendingLocalCredentials.Username, delivery.Username, (StringComparison)5) || pendingLocalCredentials.Password != delivery.Password || _pendingChargeOperationId != delivery.OperationId))
		{
			throw new InvalidOperationException("结算响应与待结算账号不匹配。");
		}
		if (_pendingChargeOperationId == delivery.OperationId)
		{
			await _pendingRegistrationStore.EI7mzxqGaK(registrationSession.UserId, delivery.OperationId);
			RequireRegistrationSession();
		}
		if (string.Equals(_pendingChargeOperationId, delivery.OperationId, (StringComparison)4))
		{
			_pendingChargeOperationId = null;
			_pendingExpectedPrice = default(decimal);
			((UIElement)Pay4399ChargeRetryPanel).Visibility = (Visibility)1;
		}
		AppShell.NotifyBalanceChanged(delivery.Balance);
		ShowGeneratedCredentials((Login4399GeneratedCredentials)new Login4399GeneratedCredentials(delivery.Username, delivery.Password));
		ResetResult();
		ResetCaptchaRecognition();
		Pay4399StatusText.Text = "账号已结算，正在生成本地 SAuth";
		gX17swyO7x0JWQxdaD1.IdOy6I4Chb("Pay4399", $"账号结算交付完成，检查客户端 SAuth: operationId={delivery.OperationId}, alreadyProcessed={delivery.AlreadyProcessed}, source=client");
		try
		{
			Login4399GeneratedCredentials pendingLocalCredentials2 = _pendingLocalCredentials;
			bool flag = (object)pendingLocalCredentials2 != null && string.Equals(pendingLocalCredentials2.Username, delivery.Username, (StringComparison)5) && string.Equals(pendingLocalCredentials2.Password, delivery.Password, (StringComparison)4);
			t30hHHfP8gMStFdbd6rB val = prevalidatedAuthentication ?? (flag ? _pendingLocalAuthentication : null);
			UoSkTNhL6xanDKt2HZ9 val2 = (flag ? _pendingLocalChannel : GetSelectedChannel());
			if (!IsDesktop4399ComChannel(val2))
			{
				val2 = (UoSkTNhL6xanDKt2HZ9)1;
			}
			if (val == null)
			{
				using (HpFsqcfPB2RknTNMlueF.erLfPleUYXa())
				{
					val = await _login4399Service.LoginAsync(delivery.Username, delivery.Password, val2, identity, (Func<string, CancellationToken, global::System.Threading.Tasks.Task<string>>)ShowCaptchaDialogAsync, default(CancellationToken));
				}
			}
			RequireRegistrationSession();
			if (IsUpsmsVerification(val))
			{
				gX17swyO7x0JWQxdaD1.IdOy6I4Chb("Pay4399", "已交付账号等待上行短信验证，重试不重复结算: operationId=" + delivery.OperationId);
				val.AccountCreated = true;
				_pendingLocalAuthentication = val;
				return val;
			}
			if ((int)val.Status != 0 || string.IsNullOrWhiteSpace(val.SauthJson))
			{
				gX17swyO7x0JWQxdaD1.U3iyRWfbJV("Pay4399", "已交付账号本地 SAuth 生成失败，保留账号且不重复结算: operationId=" + delivery.OperationId, (global::System.Exception)null);
				t30hHHfP8gMStFdbd6rB obj = t30hHHfP8gMStFdbd6rB.Fail("账号已扣费取回，本地 SAuth 生成失败：" + val.Message + "。账号保留在账号记录中，可使用转登录重试，不会再次扣费。");
				obj.AccountCreated = true;
				return obj;
			}
			bool flag2 = await SaveLocalSauthAsync(delivery.Username, delivery.Password, val.SauthJson);
			RequireRegistrationSession();
			t30hHHfP8gMStFdbd6rB obj2 = t30hHHfP8gMStFdbd6rB.EfOfPWKFbjf(val.SauthJson, flag2 ? "账号已结算，SAuth 已在客户端生成" : "账号已结算，SAuth 已在客户端生成；凭证同步失败，请先复制保存");
			obj2.AccountCreated = true;
			_pendingLocalAuthentication = null;
			_pendingLocalCredentials = null;
			_pendingLocalIdentity = null;
			return obj2;
		}
		catch (global::System.Exception ex)
		{
			RequireRegistrationSession();
			gX17swyO7x0JWQxdaD1.U3iyRWfbJV("Pay4399", "已交付账号本地登录异常: operationId=" + delivery.OperationId + ", errorType=" + ((MemberInfo)ex.GetType()).Name, ex);
			t30hHHfP8gMStFdbd6rB obj3 = t30hHHfP8gMStFdbd6rB.Fail("账号已扣费取回，本地登录暂未完成；账号保留在账号记录中，可使用转登录重试，不会再次扣费。");
			obj3.AccountCreated = true;
			return obj3;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static async global::System.Threading.Tasks.Task<bool> SaveLocalSauthAsync(string username, string password, string sauthJson, string source = "register")
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			await AppShell.Api.pH70CUy0On(new vetpDof6Apv9N4XX4t4B
			{
				Username = username,
				Password = password,
				SauthJson = sauthJson,
				Source = source
			});
			return true;
		}
		catch (global::System.Exception ex)
		{
			gX17swyO7x0JWQxdaD1.U3iyRWfbJV("Pay4399", "客户端 SAuth 同步失败，已交付账号仍保留: errorType=" + ((MemberInfo)ex.GetType()).Name, ex);
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399AutoRegisterButton_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			AppShell.Warning("请访问4399get.com / 4399.chronal.my\n可以使用Chronal原账号密码登录此账号获取服务");
		}
		catch (global::System.Exception)
		{
			AppShell.Error("请访问4399get.com / 4399.chronal.my\n可以使用Chronal原账号密码登录此账号获取服务");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> AutoRegisterLocallyAsync(aCJGY4f6x3vPUWPvvKiU config, UoSkTNhL6xanDKt2HZ9 channel)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		RequireRegistrationSession();
		for (int i = 0; i < 5; i++)
		{
			Login4399GeneratedCredentials login4399GeneratedCredentials = Login4399CredentialGenerator.Generate(config.UsernamePrefix, config.PasswordPrefix);
			string text = ((object)Guid.NewGuid()/*cast due to .constrained prefix*/).ToString();
			await AuthorizeRegistrationAsync(text, v5OiSQSzC8GipXkQ3VG.qhp8FJsZcZ(login4399GeneratedCredentials.Username, login4399GeneratedCredentials.Password), channel, config.Price);
			_pendingChargeOperationId = text;
			_pendingLocalCredentials = login4399GeneratedCredentials;
			_pendingLocalChannel = channel;
			_pendingExpectedPrice = config.Price;
			_pendingAccountCreated = false;
			await PersistPendingRegistrationAsync();
			t30hHHfP8gMStFdbd6rB item;
			nNU9JoUBxAhVHRZ6PhH item2;
			using (HpFsqcfPB2RknTNMlueF.erLfPleUYXa())
			{
				ValueTuple<t30hHHfP8gMStFdbd6rB, nNU9JoUBxAhVHRZ6PhH> val = await RegisterAsync(login4399GeneratedCredentials.Username, login4399GeneratedCredentials.Password);
				item = val.Item1;
				item2 = val.Item2;
			}
			RequireRegistrationSession();
			if (!IsRejectedUsernameMessage(item.Message))
			{
				if ((int)item.Status != 0 || !item.AccountCreated)
				{
					_pendingAccountCreated = item.AccountCreated;
					_pendingLocalIdentity = item2;
					await PersistPendingRegistrationAsync();
					if (item.AccountCreated)
					{
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("Pay4399", "4399 注册状态异常，未提交服务端扣费", (global::System.Exception)null);
					}
					string reason = (item.AccountCreated ? "账号已注册，后续本地流程未完成；待结算记录已保留，请重试取号。" : "本地注册结果未确认，待结算记录已保留，请确认账号状态后重试取号。");
					ShowChargeRetryPanel(reason);
					return BuildChargePendingResult(null, reason);
				}
				_pendingLocalIdentity = item2;
				_pendingAccountCreated = true;
				await PersistPendingRegistrationAsync();
				Pay4399StatusText.Text = "4399 账号注册成功，正在本地生成凭据并等待服务端结算";
				gX17swyO7x0JWQxdaD1.IdOy6I4Chb("Pay4399", $"本地注册结果: operationId={_pendingChargeOperationId}, accountCreated={item.AccountCreated}, status={item.Status}");
				t30hHHfP8gMStFdbd6rB val2 = await AuthenticateGeneratedAccountAsync(login4399GeneratedCredentials, item2, channel);
				RequireRegistrationSession();
				_pendingLocalAuthentication = val2;
				await PersistPendingRegistrationAsync();
				D24rFZf63PEFimGmt3St val3;
				try
				{
					val3 = await SettlePendingRegistrationAsync(config.Price);
				}
				catch (global::System.Exception)
				{
					RequireRegistrationSession();
					ShowChargeRetryPanel("注册已完成，服务端扣费结果尚未确认，请重试取回");
					return BuildChargePendingResult(val2, "注册已完成，服务端扣费结果尚未确认，请重试取回");
				}
				if (!val3.Charged)
				{
					ShowChargeRetryPanel(val3.Message);
					return BuildChargePendingResult(val2, val3.Message);
				}
				return await CompleteDeliveredAccountAsync(val3, item2, val2);
			}
			await AppShell.Api.nyh0yGcYfD(text);
			RequireRegistrationSession();
			await _pendingRegistrationStore.EI7mzxqGaK(_registrationSession.UserId, text);
			RequireRegistrationSession();
			ResetGeneratedCredentials();
		}
		return t30hHHfP8gMStFdbd6rB.Fail("自动生成的用户名连续被占用，请重新自动注册");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Pay4399RetryChargeButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Pay4399RetryChargeButton_Click_d__19 pay4399RetryChargeButton_Click_d__ = default(_Pay4399RetryChargeButton_Click_d__19);
		pay4399RetryChargeButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		pay4399RetryChargeButton_Click_d__.__4__this = this;
		pay4399RetryChargeButton_Click_d__.__1__state = -1;
		pay4399RetryChargeButton_Click_d__.__t__builder.Start<_Pay4399RetryChargeButton_Click_d__19>(ref pay4399RetryChargeButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Pay4399CancelChargeButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Pay4399CancelChargeButton_Click_d__20 pay4399CancelChargeButton_Click_d__ = default(_Pay4399CancelChargeButton_Click_d__20);
		pay4399CancelChargeButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		pay4399CancelChargeButton_Click_d__.__4__this = this;
		pay4399CancelChargeButton_Click_d__.__1__state = -1;
		pay4399CancelChargeButton_Click_d__.__t__builder.Start<_Pay4399CancelChargeButton_Click_d__20>(ref pay4399CancelChargeButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task CancelPendingRetrievalAsync(string operationId)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CancelPendingRetrievalAsync_d__21 cancelPendingRetrievalAsync_d__ = default(_CancelPendingRetrievalAsync_d__21);
		cancelPendingRetrievalAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		cancelPendingRetrievalAsync_d__.__4__this = this;
		cancelPendingRetrievalAsync_d__.operationId = operationId;
		cancelPendingRetrievalAsync_d__.__1__state = -1;
		cancelPendingRetrievalAsync_d__.__t__builder.Start<_CancelPendingRetrievalAsync_d__21>(ref cancelPendingRetrievalAsync_d__);
		return cancelPendingRetrievalAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private t30hHHfP8gMStFdbd6rB ShowChargeRetryPanel(string reason)
	{
		string text = (string.IsNullOrWhiteSpace(reason) ? "结算尚未确认，请重试取号；扣费成功后才会展示账号和 SAuth。" : reason);
		Pay4399ChargeRetryReasonText.Text = text;
		((UIElement)Pay4399ChargeRetryPanel).Visibility = (Visibility)0;
		t30hHHfP8gMStFdbd6rB obj = t30hHHfP8gMStFdbd6rB.Fail(text);
		obj.AccountCreated = true;
		return obj;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<D24rFZf63PEFimGmt3St> FinalizeAutoRegisterAsync(Jv4EMLf6aYXWrIFaB4Ra request)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			RequireRegistrationSession();
			gX17swyO7x0JWQxdaD1.IdOy6I4Chb("Pay4399", "上传本地注册账号并结算: operationId=" + request.OperationId + ", mode=" + request.SettlementMode);
			D24rFZf63PEFimGmt3St val = await AppShell.Api.B1700B3TPr(request);
			RequireRegistrationSession();
			LogSettlementState(request.OperationId, "received", val);
			return val;
		}
		catch (global::System.Exception ex)
		{
			RequireRegistrationSession();
			gX17swyO7x0JWQxdaD1.U3iyRWfbJV("Pay4399", $"结算请求异常，使用相同操作编号重试: operationId={request.OperationId}, errorType={((MemberInfo)ex.GetType()).Name}", ex);
			await global::System.Threading.Tasks.Task.Delay(300, _registrationCancellation.Token);
			RequireRegistrationSession();
			D24rFZf63PEFimGmt3St val2 = await AppShell.Api.B1700B3TPr(request);
			RequireRegistrationSession();
			LogSettlementState(request.OperationId, "retried", val2);
			return val2;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsUpsmsVerification(t30hHHfP8gMStFdbd6rB result)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)result.Status == 1 && !result.CanSms && !string.IsNullOrWhiteSpace(result.UpsmsContent) && !string.IsNullOrWhiteSpace(result.UpsmsNumber))
		{
			return !string.IsNullOrWhiteSpace(result.PendingSauthJson);
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowSmsVerification(t30hHHfP8gMStFdbd6rB result)
	{
		_pendingSmsVerification = result;
		_pendingSmsUsername = Pay4399UsernameBox.Text.Trim();
		_pendingSmsPassword = Pay4399PasswordBox.Password;
		aMuqLcf6hnKdBTwYqLWe val = Enumerable.FirstOrDefault<aMuqLcf6hnKdBTwYqLWe>((global::System.Collections.Generic.IEnumerable<aMuqLcf6hnKdBTwYqLWe>)GeneratedAccountHistory, (Func<aMuqLcf6hnKdBTwYqLWe, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (aMuqLcf6hnKdBTwYqLWe record) => string.Equals(record.Username, _pendingSmsUsername, (StringComparison)5) && string.Equals(record.Password, _pendingSmsPassword, (StringComparison)4)));
		_pendingSmsAccountSource = ((val != null) ? val.Source : null) ?? (result.AccountCreated ? "register" : null);
		_lastSauthWrapper = string.Empty;
		ApplySauthExportMode();
		Pay4399StatusText.Text = ((!result.AccountCreated) ? "等待上行短信安全验证，完成后点击下方重试登录。" : ((_pendingChargeOperationId == null) ? "账号已取回，等待上行短信验证；重试登录不会再次扣费。" : "账号等待结算与短信验证，结算确认前不会展示账号或 SAuth。"));
		Pay4399SmsVerificationPanel.Show(result.UpsmsContent, result.UpsmsNumber, result.UpsmsBackupNumber, "请使用任意手机号发送下方短信，完成后点击重试登录。验证成功前不会输出 SAuth。若再次触发验证，请等待 10 秒后重试；已取回的账号不会再次扣费。");
		AppShell.Warning("需要上行短信安全验证，请按页面提示完成");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearSmsVerification()
	{
		_smsVerificationGeneration++;
		CancellationTokenSource? smsVerificationCancellation = _smsVerificationCancellation;
		if (smsVerificationCancellation != null)
		{
			smsVerificationCancellation.Cancel();
		}
		_pendingSmsVerification = null;
		_pendingSmsUsername = null;
		_pendingSmsPassword = null;
		_pendingSmsAccountSource = null;
		Pay4399SmsVerificationPanel?.Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399SmsVerificationCancelRequested(object? sender, EventArgs e)
	{
		if (_pendingSmsVerification != null)
		{
			bool accountCreated = _pendingSmsVerification.AccountCreated;
			t30hHHfP8gMStFdbd6rB pendingLocalAuthentication = _pendingLocalAuthentication;
			if (pendingLocalAuthentication != null && IsUpsmsVerification(pendingLocalAuthentication))
			{
				_pendingLocalAuthentication = null;
			}
			ResetResult();
			Pay4399StatusText.Text = (accountCreated ? "已取消上行短信验证，账号和结算状态保留，可稍后重新登录。" : "已取消上行短信验证，可重新生成登录凭证。");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Pay4399SmsVerificationRetryRequested(object? sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Pay4399SmsVerificationRetryRequested_d__35 pay4399SmsVerificationRetryRequested_d__ = default(_Pay4399SmsVerificationRetryRequested_d__35);
		pay4399SmsVerificationRetryRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		pay4399SmsVerificationRetryRequested_d__.__4__this = this;
		pay4399SmsVerificationRetryRequested_d__.__1__state = -1;
		pay4399SmsVerificationRetryRequested_d__.__t__builder.Start<_Pay4399SmsVerificationRetryRequested_d__35>(ref pay4399SmsVerificationRetryRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	public Pay4399Page()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		_pendingRegistrationStore = new lskjRmm2JeVZWsE0GiI((string)null);
		_login4399Service = new y9aNRQUHZQ5lu0018x9();
		_captchaOcrService = (CaptchaOcrService)new CaptchaOcrService();
		_personIdentityApiClient = new LqCNIN7faHo3aBdfb2m();
		_lastSauthWrapper = string.Empty;
		_pendingLocalChannel = (UoSkTNhL6xanDKt2HZ9)2;
		_GeneratedAccountHistory_k__BackingField = new ObservableCollection<aMuqLcf6hnKdBTwYqLWe>();
		_PendingAccountHistory_k__BackingField = new ObservableCollection<pDLYXIf6mU1JnHirkJgm>();
		InitializeComponent();
		AppShell.RegisterDisposable((global::System.IDisposable)_login4399Service);
		AppShell.RegisterDisposable(_captchaOcrService);
		AppShell.RegisterDisposable((global::System.IDisposable)_personIdentityApiClient);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__58 onNavigatedTo_d__ = default(_OnNavigatedTo_d__58);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__58>(ref onNavigatedTo_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		CancellationTokenSource? registrationCancellation = _registrationCancellation;
		if (registrationCancellation != null)
		{
			registrationCancellation.Cancel();
		}
		_registrationSession = null;
		_registrationAuthorizationToken = null;
		ResetResult();
		ResetGeneratedCredentials();
		((Collection<aMuqLcf6hnKdBTwYqLWe>)(object)GeneratedAccountHistory).Clear();
		((Collection<pDLYXIf6mU1JnHirkJgm>)(object)PendingAccountHistory).Clear();
		UpdateAccountHistoryState();
		Pay4399UsernameBox.Text = string.Empty;
		Pay4399PasswordBox.Password = string.Empty;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ModeSelector_SelectionChanged(SelectorBar sender, SelectorBarSelectionChangedEventArgs args)
	{
		bool flag = sender.SelectedItem == ModeLoginItem;
		bool flag2 = sender.SelectedItem == ModeRegisterItem;
		bool flag3 = sender.SelectedItem == ModeHistoryItem;
		((UIElement)AccountFormPanel).Visibility = (flag3 ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)LoginModePanel).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)RegisterModePanel).Visibility = ((!flag2) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)AccountHistoryPanel).Visibility = ((!flag3) ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Pay4399LoginButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Pay4399LoginButton_Click_d__61 pay4399LoginButton_Click_d__ = default(_Pay4399LoginButton_Click_d__61);
		pay4399LoginButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		pay4399LoginButton_Click_d__.__4__this = this;
		pay4399LoginButton_Click_d__.__1__state = -1;
		pay4399LoginButton_Click_d__.__t__builder.Start<_Pay4399LoginButton_Click_d__61>(ref pay4399LoginButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshAutoRegisterPriceAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshAutoRegisterPriceAsync_d__62 refreshAutoRegisterPriceAsync_d__ = default(_RefreshAutoRegisterPriceAsync_d__62);
		refreshAutoRegisterPriceAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshAutoRegisterPriceAsync_d__.__4__this = this;
		refreshAutoRegisterPriceAsync_d__.__1__state = -1;
		refreshAutoRegisterPriceAsync_d__.__t__builder.Start<_RefreshAutoRegisterPriceAsync_d__62>(ref refreshAutoRegisterPriceAsync_d__);
		return refreshAutoRegisterPriceAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyAutoRegisterPrice(decimal price)
	{
		Pay4399AutoRegisterPriceText.Text = ((price <= 0m) ? "自动注册价格：免费" : ("自动注册价格：" + price.ToString("0.##", (IFormatProvider)(object)CultureInfo.InvariantCulture) + " 余额"));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<ValueTuple<t30hHHfP8gMStFdbd6rB, nNU9JoUBxAhVHRZ6PhH>> RegisterAsync(string username, string password)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		RequireRegistrationSession();
		P3whup7PCw0Z180p1CW val = new P3whup7PCw0Z180p1CW((Func<CancellationToken, global::System.Threading.Tasks.Task<nNU9JoUBxAhVHRZ6PhH>>)_personIdentityApiClient.qkt7jcNNqG);
		nNU9JoUBxAhVHRZ6PhH val2 = await val.HF57Fd3vhx(default(CancellationToken));
		RequireRegistrationSession();
		nNU9JoUBxAhVHRZ6PhH val3 = val2;
		t30hHHfP8gMStFdbd6rB val4 = await _login4399Service.JmnU5eI4Pd(username, password, val2, (Func<string, CancellationToken, global::System.Threading.Tasks.Task<string>>)ShowCaptchaDialogAsync, _registrationCancellation.Token);
		RequireRegistrationSession();
		bool flag = val4.AccountCreated;
		if (flag || (int)val4.Status != 2 || !gWSHg1UkPML7xtmFg3Q.zZlUStfIS6(val4.Message))
		{
			return new ValueTuple<t30hHHfP8gMStFdbd6rB, nNU9JoUBxAhVHRZ6PhH>(val4, val2);
		}
		for (int i = 1; i < 10; i++)
		{
			val2 = await val.HF57Fd3vhx(default(CancellationToken));
			RequireRegistrationSession();
			val4 = await _login4399Service.JmnU5eI4Pd(username, password, val2, (Func<string, CancellationToken, global::System.Threading.Tasks.Task<string>>)ShowCaptchaDialogAsync, _registrationCancellation.Token);
			RequireRegistrationSession();
			flag |= val4.AccountCreated;
			if (flag || !gWSHg1UkPML7xtmFg3Q.zZlUStfIS6(val4.Message))
			{
				return new ValueTuple<t30hHHfP8gMStFdbd6rB, nNU9JoUBxAhVHRZ6PhH>(val4, val2);
			}
		}
		t30hHHfP8gMStFdbd6rB obj = t30hHHfP8gMStFdbd6rB.Fail("pp 提供的 px 连续被 4399 拒绝，请稍后重试");
		obj.AccountCreated = flag;
		return new ValueTuple<t30hHHfP8gMStFdbd6rB, nNU9JoUBxAhVHRZ6PhH>(obj, val3);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> LoginWithIdentityApiAsync(string username, string password, UoSkTNhL6xanDKt2HZ9 channel)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		P3whup7PCw0Z180p1CW val = new P3whup7PCw0Z180p1CW((Func<CancellationToken, global::System.Threading.Tasks.Task<nNU9JoUBxAhVHRZ6PhH>>)_personIdentityApiClient.qkt7jcNNqG);
		for (int i = 0; i < 10; i++)
		{
			RequireRegistrationSession();
			nNU9JoUBxAhVHRZ6PhH val2 = await val.HF57Fd3vhx(default(CancellationToken));
			RequireRegistrationSession();
			t30hHHfP8gMStFdbd6rB val3 = await _login4399Service.LoginAsync(username, password, channel, val2, (Func<string, CancellationToken, global::System.Threading.Tasks.Task<string>>)ShowCaptchaDialogAsync, _registrationCancellation.Token);
			RequireRegistrationSession();
			if (!gWSHg1UkPML7xtmFg3Q.zZlUStfIS6(val3.Message))
			{
				return val3;
			}
		}
		return t30hHHfP8gMStFdbd6rB.Fail("pp 提供的 px 连续被 4399 拒绝，请稍后重试");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsRejectedUsernameMessage(string message)
	{
		if (!message.Contains("用户名已存在", (StringComparison)4) && !message.Contains("用户名已经被注册", (StringComparison)4) && !message.Contains("账号已存在", (StringComparison)4) && !message.Contains("帐号已存在", (StringComparison)4))
		{
			return message.Contains("用户已存在", (StringComparison)4);
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private UoSkTNhL6xanDKt2HZ9 GetSelectedChannel()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		return (UoSkTNhL6xanDKt2HZ9)(((Selector)Pay4399ChannelComboBox).SelectedIndex switch
		{
			1 => 1, 
			2 => 2, 
			_ => 0, 
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsDesktop4399ComChannel(UoSkTNhL6xanDKt2HZ9 channel)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)channel - 1 <= 1)
		{
			return true;
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetResult()
	{
		ClearSmsVerification();
		_lastSauthWrapper = string.Empty;
		Pay4399ResultBox.Text = string.Empty;
		((Control)Pay4399CopyResultButton).IsEnabled = false;
		Pay4399StatusText.Text = string.Empty;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetCaptchaRecognition()
	{
		Volatile.Write(ref _automaticCaptchaAttemptsRemaining, 3);
		Volatile.Write(ref _manualCaptchaAttemptsRemaining, 2);
		Volatile.Write(ref _captchaAttemptLimitReached, 0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetGeneratedCredentials()
	{
		_pendingChargeOperationId = null;
		_pendingLocalCredentials = null;
		_pendingLocalIdentity = null;
		_pendingLocalAuthentication = null;
		_pendingExpectedPrice = default(decimal);
		_pendingAccountCreated = false;
		_registrationAuthorizationToken = null;
		Pay4399GeneratedAccountBox.Text = string.Empty;
		((UIElement)Pay4399GeneratedAccountPanel).Visibility = (Visibility)1;
		((Control)Pay4399CopyGeneratedAccountButton).IsEnabled = false;
		((UIElement)Pay4399ChargeRetryPanel).Visibility = (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowGeneratedCredentials(Login4399GeneratedCredentials credentials)
	{
		Pay4399UsernameBox.Text = credentials.Username;
		Pay4399PasswordBox.Password = credentials.Password;
		Pay4399GeneratedAccountBox.Text = $"用户名：{credentials.Username}{Environment.NewLine}密码：{credentials.Password}";
		((UIElement)Pay4399GeneratedAccountPanel).Visibility = (Visibility)0;
		((Control)Pay4399CopyGeneratedAccountButton).IsEnabled = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshGeneratedAccountHistoryAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshGeneratedAccountHistoryAsync_d__73 refreshGeneratedAccountHistoryAsync_d__ = default(_RefreshGeneratedAccountHistoryAsync_d__73);
		refreshGeneratedAccountHistoryAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshGeneratedAccountHistoryAsync_d__.__4__this = this;
		refreshGeneratedAccountHistoryAsync_d__.__1__state = -1;
		refreshGeneratedAccountHistoryAsync_d__.__t__builder.Start<_RefreshGeneratedAccountHistoryAsync_d__73>(ref refreshGeneratedAccountHistoryAsync_d__);
		return refreshGeneratedAccountHistoryAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateAccountHistoryState()
	{
		if (Pay4399AccountHistoryList != null && Pay4399AccountHistoryEmptyState != null && Pay4399ClearAccountHistoryButton != null && Pay4399AccountHistoryCountText != null)
		{
			bool flag = ((Collection<aMuqLcf6hnKdBTwYqLWe>)(object)GeneratedAccountHistory).Count > 0;
			Pay4399AccountHistoryCountText.Text = $"{((Collection<aMuqLcf6hnKdBTwYqLWe>)(object)GeneratedAccountHistory).Count + ((Collection<pDLYXIf6mU1JnHirkJgm>)(object)PendingAccountHistory).Count} 条";
			((UIElement)Pay4399AccountHistoryList).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
			((UIElement)Pay4399AccountHistoryEmptyState).Visibility = ((flag || ((Collection<pDLYXIf6mU1JnHirkJgm>)(object)PendingAccountHistory).Count > 0) ? Visibility.Visible : Visibility.Collapsed);
			((UIElement)Pay4399PendingHistoryPanel).Visibility = ((((Collection<pDLYXIf6mU1JnHirkJgm>)(object)PendingAccountHistory).Count <= 0) ? Visibility.Visible : Visibility.Collapsed);
			((Control)Pay4399ClearAccountHistoryButton).IsEnabled = flag;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Pay4399RetryPendingAccountButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Pay4399RetryPendingAccountButton_Click_d__75 pay4399RetryPendingAccountButton_Click_d__ = default(_Pay4399RetryPendingAccountButton_Click_d__75);
		pay4399RetryPendingAccountButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		pay4399RetryPendingAccountButton_Click_d__.__4__this = this;
		pay4399RetryPendingAccountButton_Click_d__.sender = sender;
		pay4399RetryPendingAccountButton_Click_d__.__1__state = -1;
		pay4399RetryPendingAccountButton_Click_d__.__t__builder.Start<_Pay4399RetryPendingAccountButton_Click_d__75>(ref pay4399RetryPendingAccountButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Pay4399CancelPendingAccountButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Pay4399CancelPendingAccountButton_Click_d__76 pay4399CancelPendingAccountButton_Click_d__ = default(_Pay4399CancelPendingAccountButton_Click_d__76);
		pay4399CancelPendingAccountButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		pay4399CancelPendingAccountButton_Click_d__.__4__this = this;
		pay4399CancelPendingAccountButton_Click_d__.sender = sender;
		pay4399CancelPendingAccountButton_Click_d__.__1__state = -1;
		pay4399CancelPendingAccountButton_Click_d__.__t__builder.Start<_Pay4399CancelPendingAccountButton_Click_d__76>(ref pay4399CancelPendingAccountButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399AccountHistoryList_ItemClick(object sender, ItemClickEventArgs e)
	{
		object clickedItem = e.ClickedItem;
		aMuqLcf6hnKdBTwYqLWe val = (aMuqLcf6hnKdBTwYqLWe)((clickedItem is aMuqLcf6hnKdBTwYqLWe) ? clickedItem : null);
		if (val != null)
		{
			ClearSmsVerification();
			ShowGeneratedCredentials((Login4399GeneratedCredentials)new Login4399GeneratedCredentials(val.Username, val.Password));
			((Selector)Pay4399ChannelComboBox).SelectedIndex = 2;
			_lastSauthWrapper = val.SauthJson;
			ApplySauthExportMode();
			if (val.HasSauth)
			{
				AppShell.Success("已载入 " + val.Username + " 的 SAUTH");
			}
			else
			{
				AppShell.Warning(val.Username + " 未生成 SAUTH");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399LoadSavedSauthButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val == null)
		{
			return;
		}
		object dataContext = ((FrameworkElement)val).DataContext;
		aMuqLcf6hnKdBTwYqLWe val2 = (aMuqLcf6hnKdBTwYqLWe)((dataContext is aMuqLcf6hnKdBTwYqLWe) ? dataContext : null);
		if (val2 != null)
		{
			ClearSmsVerification();
			ShowGeneratedCredentials((Login4399GeneratedCredentials)new Login4399GeneratedCredentials(val2.Username, val2.Password));
			((Selector)Pay4399ChannelComboBox).SelectedIndex = 2;
			_lastSauthWrapper = val2.SauthJson;
			ApplySauthExportMode();
			if (val2.HasSauth)
			{
				AppShell.Success("已载入 " + val2.Username + " 的 SAUTH");
			}
			else
			{
				AppShell.Warning(val2.Username + " 未生成 SAUTH");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399CopySavedAccountButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null)
		{
			object dataContext = ((FrameworkElement)val).DataContext;
			aMuqLcf6hnKdBTwYqLWe val2 = (aMuqLcf6hnKdBTwYqLWe)((dataContext is aMuqLcf6hnKdBTwYqLWe) ? dataContext : null);
			if (val2 != null)
			{
				UiHelpers.CopyToClipboard(val2.AccountText);
				AppShell.Success("账号和密码已复制");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Pay4399ClearAccountHistoryButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Pay4399ClearAccountHistoryButton_Click_d__80 pay4399ClearAccountHistoryButton_Click_d__ = default(_Pay4399ClearAccountHistoryButton_Click_d__80);
		pay4399ClearAccountHistoryButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		pay4399ClearAccountHistoryButton_Click_d__.__4__this = this;
		pay4399ClearAccountHistoryButton_Click_d__.__1__state = -1;
		pay4399ClearAccountHistoryButton_Click_d__.__t__builder.Start<_Pay4399ClearAccountHistoryButton_Click_d__80>(ref pay4399ClearAccountHistoryButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyResult(t30hHHfP8gMStFdbd6rB? result)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (result == null)
		{
			return;
		}
		if (IsUpsmsVerification(result))
		{
			ShowSmsVerification(result);
			return;
		}
		if ((int)result.Status == 2 && !result.AccountCreated && Volatile.Read(ref _captchaAttemptLimitReached) != 0)
		{
			result = t30hHHfP8gMStFdbd6rB.Fail("验证码连续错误，已停止本次操作，请重新开始");
		}
		else if ((int)result.Status == 2 && !result.AccountCreated && ContainsSensitiveIdentityWording(result.Message))
		{
			result = t30hHHfP8gMStFdbd6rB.Fail("安全校验未通过，系统已停止本次操作");
		}
		ClearSmsVerification();
		Pay4399StatusText.Text = result.Message;
		if ((int)result.Status == 0)
		{
			_lastSauthWrapper = result.SauthJson ?? string.Empty;
			ApplySauthExportMode();
			AppShell.Success(result.Message);
		}
		else
		{
			_lastSauthWrapper = string.Empty;
			ApplySauthExportMode();
			AppShell.Error(result.Message);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399SauthFormatComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		ApplySauthExportMode();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplySauthExportMode()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (Pay4399ResultBox != null && Pay4399CopyResultButton != null && Pay4399SauthFormatComboBox != null)
		{
			VABxm6BGrZyWaKQBOgg val = ((((Selector)Pay4399SauthFormatComboBox).SelectedIndex == 1) ? (VABxm6BGrZyWaKQBOgg)1 : (VABxm6BGrZyWaKQBOgg)0);
			Pay4399ResultBox.Text = HOSbEfBnqnkA3P6cNbO.dRtgb4gEnG(_lastSauthWrapper, val);
			((Control)Pay4399CopyResultButton).IsEnabled = !string.IsNullOrWhiteSpace(Pay4399ResultBox.Text);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ContainsSensitiveIdentityWording(string? message)
	{
		if (string.IsNullOrWhiteSpace(message))
		{
			return false;
		}
		if (!gWSHg1UkPML7xtmFg3Q.zZlUStfIS6(message) && !message.Contains("实名认证", (StringComparison)4) && !message.Contains("身份证", (StringComparison)4))
		{
			return message.Contains("姓名和", (StringComparison)4);
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399CopyResultButton_Click(object sender, RoutedEventArgs e)
	{
		string text = Pay4399ResultBox.Text;
		if (!string.IsNullOrEmpty(text))
		{
			UiHelpers.CopyToClipboard(text);
			AppShell.Success("SAuth 已复制，请到基岩版启动页面粘贴");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399GoToBedrockButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("bedrock_account"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Pay4399CopyGeneratedAccountButton_Click(object sender, RoutedEventArgs e)
	{
		string text = Pay4399GeneratedAccountBox.Text;
		if (!string.IsNullOrWhiteSpace(text))
		{
			UiHelpers.CopyToClipboard(text);
			AppShell.Success("自动生成的账号和密码已复制");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<string?> ShowCaptchaDialogAsync(string base64Image, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass88_0 __8_locals7 = (__c__DisplayClass88_0)new __c__DisplayClass88_0();
		__8_locals7.__4__this = this;
		__8_locals7.base64Image = base64Image;
		if (Interlocked.Decrement(ref _automaticCaptchaAttemptsRemaining) >= 0)
		{
			try
			{
				string text = await _captchaOcrService.TryRecognizeAsync(__8_locals7.base64Image, cancellationToken);
				if (!string.IsNullOrWhiteSpace(text))
				{
					return text;
				}
				return "\u0001";
			}
			catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
			{
				return null;
			}
			catch (global::System.Exception)
			{
				return "\u0001";
			}
		}
		if (Interlocked.Decrement(ref _manualCaptchaAttemptsRemaining) < 0)
		{
			Volatile.Write(ref _captchaAttemptLimitReached, 1);
			return null;
		}
		__8_locals7.completion = new TaskCompletionSource<string>();
		if (!((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] () =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__c__DisplayClass88_0.__ShowCaptchaDialogAsync_b__0_d _ShowCaptchaDialogAsync_b__0_d = default(__c__DisplayClass88_0.__ShowCaptchaDialogAsync_b__0_d);
			_ShowCaptchaDialogAsync_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowCaptchaDialogAsync_b__0_d.__4__this = __8_locals7;
			_ShowCaptchaDialogAsync_b__0_d.__1__state = -1;
			_ShowCaptchaDialogAsync_b__0_d.__t__builder.Start<__c__DisplayClass88_0.__ShowCaptchaDialogAsync_b__0_d>(ref _ShowCaptchaDialogAsync_b__0_d);
		})))
		{
			__8_locals7.completion.TrySetResult((string)null);
		}
		return await __8_locals7.completion.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<string?> ShowCaptchaDialogCoreAsync(string base64Image, bool serverVerification = false)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass89_0 __8_locals6 = (__c__DisplayClass89_0)new __c__DisplayClass89_0();
		Image val = new Image
		{
			Stretch = (Stretch)0,
			HorizontalAlignment = (HorizontalAlignment)1,
			MinHeight = 44.0
		};
		try
		{
			byte[] array = Convert.FromBase64String(base64Image);
			BitmapImage val2 = new BitmapImage();
			InMemoryRandomAccessStream val3 = new InMemoryRandomAccessStream();
			try
			{
				TaskAwaiter<uint> val4 = WindowsRuntimeSystemExtensions.GetAwaiter<uint, uint>(val3.WriteAsync(WindowsRuntimeBufferExtensions.AsBuffer(array)));
				if (!val4.IsCompleted)
				{
					val4.GetResult();
					TaskAwaiter<uint> val5 = default(TaskAwaiter<uint>);
					val4 = val5;
				}
				val4.GetResult();
				val3.Seek(0uL);
				TaskAwaiter val6 = WindowsRuntimeSystemExtensions.GetAwaiter(((BitmapSource)val2).SetSourceAsync((IRandomAccessStream)(object)val3));
				if (!val6.IsCompleted)
				{
					val6.GetResult();
					TaskAwaiter val7 = default(TaskAwaiter);
					val6 = val7;
				}
				val6.GetResult();
				val.Source = (ImageSource)(object)val2;
			}
			finally
			{
				((global::System.IDisposable)val3)?.Dispose();
			}
		}
		catch
		{
		}
		TextBox val8 = new TextBox
		{
			PlaceholderText = "输入图中字符",
			Margin = new Thickness(0.0, 12.0, 0.0, 0.0)
		};
		StackPanel val9 = new StackPanel
		{
			Spacing = 8.0
		};
		((Panel)val9).Children.Add((UIElement)new TextBlock
		{
			Text = (serverVerification ? "请手动输入服务端核验所需的图形验证码（区分大小写）；扣费成功前不会展示账号或 SAUTH。" : "请输入下方图形验证码（区分大小写）"),
			TextWrapping = (TextWrapping)2
		});
		((Panel)val9).Children.Add((UIElement)(object)val);
		((Panel)val9).Children.Add((UIElement)(object)val8);
		((Panel)val9).Children.Add((UIElement)new TextBlock
		{
			Text = (serverVerification ? "看不清可取消，稍后在账号记录中点击“重试取号”换一张。" : "看不清可取消后重新点击“生成登录凭证”换一张。"),
			FontSize = 12.0,
			Foreground = default(Brush),
			TextWrapping = (TextWrapping)2
		});
		__8_locals6.dialog = new ContentDialog
		{
			XamlRoot = AppShell.XamlRoot,
			RequestedTheme = AppShell.RequestedTheme,
			Title = "4399 图形验证码",
			Content = val9,
			PrimaryButtonText = "确定",
			CloseButtonText = "取消",
			DefaultButton = (ContentDialogButton)1
		};
		__8_locals6.submittedByEnter = false;
		((UIElement)val8).KeyDown += (KeyEventHandler)([MethodImpl((MethodImplOptions)8)] (object _, KeyRoutedEventArgs args) =>
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)args.Key == 13)
			{
				__8_locals6.submittedByEnter = true;
				__8_locals6.dialog.Hide();
			}
		});
		TaskAwaiter<ContentDialogResult> val10 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(__8_locals6.dialog.ShowAsync());
		if (!val10.IsCompleted)
		{
			val10.GetResult();
			TaskAwaiter<ContentDialogResult> val11 = default(TaskAwaiter<ContentDialogResult>);
			val10 = val11;
		}
		return (!(((int)val10.GetResult() == 1) | __8_locals6.submittedByEnter)) ? null : val8.Text?.Trim();
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
			Uri val = new Uri("ms-appx:///Views/Pages/Pay4399Page.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			AccountFormColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 3:
			CompactConversion = CastExtensions.As<VisualState>(target);
			break;
		case 4:
			WideConversion = CastExtensions.As<VisualState>(target);
			break;
		case 5:
			AccountInputPanel = CastExtensions.As<Border>(target);
			break;
		case 6:
			SauthResultPanel = CastExtensions.As<Border>(target);
			break;
		case 7:
			Pay4399SmsVerificationPanel = CastExtensions.As<SmsVerificationView>(target);
			Pay4399SmsVerificationPanel.RetryRequested += new EventHandler(Pay4399SmsVerificationRetryRequested);
			Pay4399SmsVerificationPanel.CancelRequested += new EventHandler(Pay4399SmsVerificationCancelRequested);
			break;
		case 8:
			Pay4399ResultBox = CastExtensions.As<TextBox>(target);
			break;
		case 9:
			Pay4399CopyResultButton = CastExtensions.As<Button>(target);
			((ButtonBase)Pay4399CopyResultButton).Click += new RoutedEventHandler(Pay4399CopyResultButton_Click);
			break;
		case 10:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(Pay4399GoToBedrockButton_Click);
			break;
		case 11:
			Pay4399SauthFormatComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)Pay4399SauthFormatComboBox).SelectionChanged += new SelectionChangedEventHandler(Pay4399SauthFormatComboBox_SelectionChanged);
			break;
		case 12:
			ModeSelector = CastExtensions.As<SelectorBar>(target);
			ModeSelector.SelectionChanged += ModeSelector_SelectionChanged;
			break;
		case 13:
			AccountFormPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 14:
			AccountHistoryPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 15:
			Pay4399StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			Pay4399PendingHistoryPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 17:
			Pay4399AccountHistoryList = CastExtensions.As<ListView>(target);
			((ListViewBase)Pay4399AccountHistoryList).ItemClick += new ItemClickEventHandler(Pay4399AccountHistoryList_ItemClick);
			break;
		case 18:
			Pay4399AccountHistoryEmptyState = CastExtensions.As<Border>(target);
			break;
		case 21:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(Pay4399LoadSavedSauthButton_Click);
			break;
		case 22:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(Pay4399CopySavedAccountButton_Click);
			break;
		case 31:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(Pay4399RetryPendingAccountButton_Click);
			break;
		case 32:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(Pay4399CancelPendingAccountButton_Click);
			break;
		case 36:
			Pay4399ClearAccountHistoryButton = CastExtensions.As<Button>(target);
			((ButtonBase)Pay4399ClearAccountHistoryButton).Click += new RoutedEventHandler(Pay4399ClearAccountHistoryButton_Click);
			break;
		case 37:
			Pay4399AccountHistoryCountText = CastExtensions.As<TextBlock>(target);
			break;
		case 38:
			Pay4399UsernameBox = CastExtensions.As<TextBox>(target);
			break;
		case 39:
			Pay4399PasswordBox = CastExtensions.As<PasswordBox>(target);
			break;
		case 40:
			Pay4399ChannelComboBox = CastExtensions.As<ComboBox>(target);
			break;
		case 41:
			LoginModePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 42:
			RegisterModePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 43:
			Pay4399AutoRegisterButton = CastExtensions.As<Button>(target);
			((ButtonBase)Pay4399AutoRegisterButton).Click += new RoutedEventHandler(Pay4399AutoRegisterButton_Click);
			break;
		case 44:
			Pay4399AutoRegisterPriceText = CastExtensions.As<TextBlock>(target);
			break;
		case 45:
			Pay4399ChargeRetryPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 46:
			Pay4399GeneratedAccountPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 47:
			Pay4399GeneratedAccountBox = CastExtensions.As<TextBox>(target);
			break;
		case 48:
			Pay4399CopyGeneratedAccountButton = CastExtensions.As<Button>(target);
			((ButtonBase)Pay4399CopyGeneratedAccountButton).Click += new RoutedEventHandler(Pay4399CopyGeneratedAccountButton_Click);
			break;
		case 49:
			Pay4399ChargeRetryReasonText = CastExtensions.As<TextBlock>(target);
			break;
		case 50:
			Pay4399RetryChargeButton = CastExtensions.As<Button>(target);
			((ButtonBase)Pay4399RetryChargeButton).Click += new RoutedEventHandler(Pay4399RetryChargeButton_Click);
			break;
		case 51:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(Pay4399CancelChargeButton_Click);
			break;
		case 52:
			Pay4399LoginButton = CastExtensions.As<Button>(target);
			((ButtonBase)Pay4399LoginButton).Click += new RoutedEventHandler(Pay4399LoginButton_Click);
			break;
		case 53:
			ModeLoginItem = CastExtensions.As<SelectorBarItem>(target);
			break;
		case 54:
			ModeRegisterItem = CastExtensions.As<SelectorBarItem>(target);
			break;
		case 55:
			ModeHistoryItem = CastExtensions.As<SelectorBarItem>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 1:
		{
			Page val3 = (Page)target;
			Pay4399Page_obj1_Bindings pay4399Page_obj1_Bindings = (Pay4399Page_obj1_Bindings)new Pay4399Page_obj1_Bindings();
			result = (IComponentConnector)(object)pay4399Page_obj1_Bindings;
			pay4399Page_obj1_Bindings.SetDataRoot(this);
			Bindings = pay4399Page_obj1_Bindings;
			((FrameworkElement)val3).Loading += pay4399Page_obj1_Bindings.Loading;
			break;
		}
		case 20:
		{
			Border val2 = (Border)target;
			Pay4399Page_obj20_Bindings pay4399Page_obj20_Bindings = (Pay4399Page_obj20_Bindings)new Pay4399Page_obj20_Bindings();
			result = (IComponentConnector)(object)pay4399Page_obj20_Bindings;
			pay4399Page_obj20_Bindings.SetDataRoot(((FrameworkElement)val2).DataContext);
			((FrameworkElement)val2).DataContextChanged += pay4399Page_obj20_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val2, (IDataTemplateExtension)(object)pay4399Page_obj20_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val2, (IDataTemplateComponent)(object)pay4399Page_obj20_Bindings);
			break;
		}
		case 30:
		{
			Border val = (Border)target;
			Pay4399Page_obj30_Bindings pay4399Page_obj30_Bindings = (Pay4399Page_obj30_Bindings)new Pay4399Page_obj30_Bindings();
			result = (IComponentConnector)(object)pay4399Page_obj30_Bindings;
			pay4399Page_obj30_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += pay4399Page_obj30_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)pay4399Page_obj30_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)pay4399Page_obj30_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool _ShowSmsVerification_b__32_0(aMuqLcf6hnKdBTwYqLWe record)
	{
		if (string.Equals(record.Username, _pendingSmsUsername, (StringComparison)5))
		{
			return string.Equals(record.Password, _pendingSmsPassword, (StringComparison)4);
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task _OnNavigatedTo_b__58_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__OnNavigatedTo_b__58_0_d _OnNavigatedTo_b__58_0_d = default(__OnNavigatedTo_b__58_0_d);
		_OnNavigatedTo_b__58_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_OnNavigatedTo_b__58_0_d.__4__this = this;
		_OnNavigatedTo_b__58_0_d.__1__state = -1;
		_OnNavigatedTo_b__58_0_d.__t__builder.Start<__OnNavigatedTo_b__58_0_d>(ref _OnNavigatedTo_b__58_0_d);
		return _OnNavigatedTo_b__58_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	[CompilerGenerated]
	private void __n__0(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task _Pay4399ClearAccountHistoryButton_Click_b__80_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__Pay4399ClearAccountHistoryButton_Click_b__80_0_d _Pay4399ClearAccountHistoryButton_Click_b__80_0_d = default(__Pay4399ClearAccountHistoryButton_Click_b__80_0_d);
		_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__4__this = this;
		_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__1__state = -1;
		_Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__t__builder.Start<__Pay4399ClearAccountHistoryButton_Click_b__80_0_d>(ref _Pay4399ClearAccountHistoryButton_Click_b__80_0_d);
		return _Pay4399ClearAccountHistoryButton_Click_b__80_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

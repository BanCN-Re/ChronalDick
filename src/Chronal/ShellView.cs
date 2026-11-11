using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using D5dq98Zj0UIlWLL7BDu;
using EiAPRwJSDFvNotiSTTX;
using FXwhkifOd0mJIMiQqRWJ;
using FdRq9UOmyfvNjvAvu1J;
using IITNt9fOI0u8kv2kH33A;
using Kdrp2DfOFHxQXR4eMElu;
using LOsmddfHHCO6PJqaCy1r;
using LlvQkpftcKTPAsaRP0ff;
using MQoh6BfOCL7YieMsY4S3;
using Mahiro_Account.UI.Controls;
using Mahiro_Account.UI.Navigation;
using Mahiro_Account.Views;
using Mahiro_Account.Views.Pages;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Ol8hyIfHgsLDrIem3kJe;
using P2V4KgyAeYeGiSUWA6W;
using P4nQc8LxjCxnxuINJP5;
using S8n61mJsaMJuqrvF5R7;
using SP7UkQfHOy3ShdqnaNNY;
using T4XKlEftW1rbu7TvQmXH;
using VFQxICfth84Lkoc3ch2l;
using Vlsi7UfO9ch6W4RxaQqv;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using bUfedyCg1PBqhqIkB8r;
using fJI2ftf5SouLKttbv85L;
using fNKXZaCVx11wUEBS5ms;
using hhPZv9fHdwZMlTH2T8IH;
using jayVXsfeU04hSNk3ePPo;
using pDFcXyfOjGiubvpRL0gO;
using qS8vkpL43FlTMgcj0rgs;
using rt6nJFOgpDacgmTF8Ih;
using uAMBGBfHIb0BxGpRnPAq;
using uj1PrqjB4rcHFMlFGdp;
using yk0qylfOoLyWUHolY5pj;
using zDw8FCfOEDpLHSbKqHHt;

namespace Mahiro_Account.UI.Shell;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class ShellView : UserControl, IShellHost, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IShellView_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IShellView_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_TitleBar_IsBackButtonVisible(TitleBar obj, bool value)
		{
			obj.IsBackButtonVisible = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	private class ShellView_obj1_Bindings : IComponentConnector, IShellView_Bindings
	{
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		private class ShellView_obj1_BindingsTracking
		{
			private WeakReference<ShellView_obj1_Bindings> weakRefToBindingObj;

			private Frame cache_ContentFrame;

			private long tokenDPC_ContentFrame_CanGoBack;

			[MethodImpl((MethodImplOptions)8)]
			public ShellView_obj1_BindingsTracking(ShellView_obj1_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<ShellView_obj1_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public ShellView_obj1_Bindings TryGetBindingObject()
			{
				ShellView_obj1_Bindings shellView_obj1_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out shellView_obj1_Bindings);
					if (shellView_obj1_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return shellView_obj1_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
				UpdateChildListeners_ContentFrame(null);
			}

			[MethodImpl((MethodImplOptions)8)]
			public void DependencyPropertyChanged_ContentFrame_CanGoBack(DependencyObject sender, DependencyProperty prop)
			{
				ShellView_obj1_Bindings shellView_obj1_Bindings = TryGetBindingObject();
				if (shellView_obj1_Bindings != null)
				{
					Frame val = (Frame)(object)((sender is Frame) ? sender : null);
					if (val != (Frame)null)
					{
						shellView_obj1_Bindings.Update_ContentFrame_CanGoBack(val.CanGoBack, 1073741824);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_ContentFrame(Frame obj)
			{
				//IL_0063: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Expected O, but got Unknown
				if (obj != cache_ContentFrame)
				{
					if (cache_ContentFrame != (Frame)null)
					{
						((DependencyObject)cache_ContentFrame).UnregisterPropertyChangedCallback(Frame.CanGoBackProperty, tokenDPC_ContentFrame_CanGoBack);
						cache_ContentFrame = null;
					}
					if (obj != (Frame)null)
					{
						cache_ContentFrame = obj;
						tokenDPC_ContentFrame_CanGoBack = ((DependencyObject)obj).RegisterPropertyChangedCallback(Frame.CanGoBackProperty, new DependencyPropertyChangedCallback(DependencyPropertyChanged_ContentFrame_CanGoBack));
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private ShellView dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private TitleBar obj24;

		private ShellView_obj1_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public ShellView_obj1_Bindings()
		{
			bindingsTracking = (ShellView_obj1_BindingsTracking)new ShellView_obj1_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 24)
			{
				obj24 = CastExtensions.As<TitleBar>(target);
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
				dataRoot = CastExtensions.As<ShellView>(newDataRoot);
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
		private void Update_(ShellView obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -1073741823) != 0)
			{
				Update_ContentFrame(obj.ContentFrame, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ContentFrame(Frame obj, int phase)
		{
			bindingsTracking.UpdateChildListeners_ContentFrame(obj);
			if (obj != (Frame)null && (phase & -1073741823) != 0)
			{
				Update_ContentFrame_CanGoBack(obj.CanGoBack, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ContentFrame_CanGoBack(bool obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TitleBar_IsBackButtonVisible(obj24, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __OnLogoutRequested_b__51_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ShellView __4__this;

		private TaskAwaiter __u__1;

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
			ShellView shellView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.d6nc7VjD3W().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnLogoutRequested_b__51_0_d>(ref _u__, ref this);
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
				shellView.EnterAuthenticationState(null);
				AppShell.Info("已退出");
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
	private struct __OnRefreshRequested_b__48_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ShellView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
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
						goto IL_00d2;
					}
					_u__ = AppShell.RefreshSummaryAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnRefreshRequested_b__48_0_d>(ref _u__, ref this);
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
				_u__ = shellView.RefreshCurrentPageAsync().GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnRefreshRequested_b__48_0_d>(ref _u__, ref this);
					return;
				}
				goto IL_00d2;
				IL_00d2:
				_u__.GetResult();
				AppShell.Info("数据已刷新");
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
	private static class __O_7
	{
		public static Func<global::System.Threading.Tasks.Task> _0___RefreshSummaryAsync;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_23
	{
		public static __c_23 __9;

		public static Func<wmdNEbfHAbSdfRGI5xOQ, bool> __9__0_0;

		public static Func<wmdNEbfHAbSdfRGI5xOQ, int> __9__0_1;

		public static Func<wmdNEbfHAbSdfRGI5xOQ, DateTimeOffset> __9__0_2;

		public static Func<wmdNEbfHAbSdfRGI5xOQ, long> __9__0_3;

		public static Func<wmdNEbfHAbSdfRGI5xOQ, bool> __9__0_4;

		public static TypedEventHandler<ContentDialog, ContentDialogClosingEventArgs> __9__0_5;

		public static Func<wmdNEbfHAbSdfRGI5xOQ, Tds4VefHlk4juYavZRe7> __9__0_6;

		public static Func<PageStackEntry, bool> __9__47_0;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			__9 = (__c_23)new __c_23();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_23()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ShowLoginAnnouncementsAsync_b__0_0(wmdNEbfHAbSdfRGI5xOQ item)
		{
			return item.IsMandatory;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int _ShowLoginAnnouncementsAsync_b__0_1(wmdNEbfHAbSdfRGI5xOQ item)
		{
			return item.Priority;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset _ShowLoginAnnouncementsAsync_b__0_2(wmdNEbfHAbSdfRGI5xOQ item)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			return (DateTimeOffset)(((object)item.StartsAt) ?? item.CreatedAt);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal long _ShowLoginAnnouncementsAsync_b__0_3(wmdNEbfHAbSdfRGI5xOQ item)
		{
			return item.Id;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ShowLoginAnnouncementsAsync_b__0_4(wmdNEbfHAbSdfRGI5xOQ item)
		{
			return item.IsMandatory;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowLoginAnnouncementsAsync_b__0_5(ContentDialog _, ContentDialogClosingEventArgs args)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Invalid comparison between Unknown and I4
			if ((int)args.Result != 1)
			{
				args.Cancel = true;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal Tds4VefHlk4juYavZRe7 _ShowLoginAnnouncementsAsync_b__0_6(wmdNEbfHAbSdfRGI5xOQ item)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			return new Tds4VefHlk4juYavZRe7
			{
				Id = item.Id,
				Revision = item.Revision
			};
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _UpdateJavaNavigation_b__47_0(PageStackEntry entry)
		{
			return NavigationRegistry.IsJavaPage(entry.SourcePageType);
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_6
	{
		[StructLayout((LayoutKind)3)]
		public struct __ShowEmailBindingDialogAsync_b__6_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public __c__DisplayClass8_0_6 __4__this;

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
				__c__DisplayClass8_0_6 _c__DisplayClass8_0_ = __4__this;
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__SendVerificationAsync_5().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ShowEmailBindingDialogAsync_b__6_d>(ref _u__, ref this);
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
		public struct __ShowEmailBindingDialogAsync_b__7_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public ContentDialogButtonClickEventArgs args;

			public __c__DisplayClass8_0_6 __4__this;

			private ContentDialogButtonClickDeferral _deferral_5__2;

			private TaskAwaiter<tR6PgnfOrMtDaK70FTsD> __u__1;

			private TaskAwaiter<EyIZsdfOl4aMc0KMHmOg> __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0243: Expected O, but got Unknown
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0154: Unknown result type (might be due to invalid IL or missing references)
				//IL_0159: Unknown result type (might be due to invalid IL or missing references)
				//IL_0161: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0121: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass8_0_6 _c__DisplayClass8_0_ = __4__this;
				try
				{
					if ((uint)num > 1u)
					{
						_deferral_5__2 = args.GetDeferral();
						args.Cancel = true;
					}
					Fx92Odf5YJhjb4F5o23y val = default(Fx92Odf5YJhjb4F5o23y);
					try
					{
						TaskAwaiter<tR6PgnfOrMtDaK70FTsD> _u__ = default;
						if (num == 0)
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<tR6PgnfOrMtDaK70FTsD>);
							num = (__1__state = -1);
							goto IL_00a9;
						}
						TaskAwaiter<EyIZsdfOl4aMc0KMHmOg> _u__2 = default;
						if (num == 1)
						{
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter<EyIZsdfOl4aMc0KMHmOg>);
							num = (__1__state = -1);
							goto IL_0170;
						}
						if (_c__DisplayClass8_0_.isLink)
						{
							_u__ = AppShell.Api.Vh0cHLpAgq().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tR6PgnfOrMtDaK70FTsD>, __ShowEmailBindingDialogAsync_b__7_d>(ref _u__, ref this);
								return;
							}
							goto IL_00a9;
						}
						string text = _c__DisplayClass8_0_.codeBox.Text.Trim();
						if (text.Length != 0)
						{
							_u__2 = AppShell.Api.NgicOYuf4n(text, (string)null).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<EyIZsdfOl4aMc0KMHmOg>, __ShowEmailBindingDialogAsync_b__7_d>(ref _u__2, ref this);
								return;
							}
							goto IL_0170;
						}
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "请输入邮件里的验证码");
						goto end_IL_0036;
						IL_00a9:
						if (_u__.GetResult().EmailVerified)
						{
							_c__DisplayClass8_0_.verified = true;
							args.Cancel = false;
						}
						else
						{
							_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)2, "还没有检测到验证完成，请先在浏览器里打开邮件中的验证链接");
						}
						goto end_IL_0036;
						IL_0170:
						if (_u__2.GetResult().Ok)
						{
							_c__DisplayClass8_0_.verified = true;
							args.Cancel = false;
						}
						else
						{
							_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "验证码不正确，请重新输入");
						}
						end_IL_0036:;
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj2 = ((obj is Fx92Odf5YJhjb4F5o23y) ? obj : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
						if (obj2 == null)
						{
							result = 0;
						}
						else
						{
							val = (Fx92Odf5YJhjb4F5o23y)obj2;
							result = (val.IsRateLimited ? 1 : 0);
						}
						return (byte)result != 0;
					}).Invoke())
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 425);
						int num2 = ((val.RetryAfterSeconds > 0) ? val.RetryAfterSeconds : 60);
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)2, $"尝试过于频繁，请 {num2} 秒后再试");
					}
					catch (Fx92Odf5YJhjb4F5o23y val2)
					{
						Fx92Odf5YJhjb4F5o23y val3 = val2;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 431);
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, ((global::System.Exception)(object)val3).Message);
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, AppShell.GetExceptionDisplayMessage(exception, "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 436));
					}
					finally
					{
						if (num < 0)
						{
							_deferral_5__2.Complete();
						}
					}
				}
				catch (global::System.Exception exception2)
				{
					__1__state = -2;
					_deferral_5__2 = null;
					__t__builder.SetException(exception2);
					return;
				}
				__1__state = -2;
				_deferral_5__2 = null;
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
		private struct __ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass8_0_6 __4__this;

			private string _email_5__2;

			private TaskAwaiter<RL6qyqfOAMmyV1y9o5am> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_022a: Expected O, but got Unknown
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass8_0_6 _c__DisplayClass8_0_ = __4__this;
				try
				{
					if (num == 0)
					{
						goto IL_0071;
					}
					_email_5__2 = _c__DisplayClass8_0_.emailBox.Text.Trim();
					if (!IsValidEmail(_email_5__2))
					{
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "请输入有效的邮箱地址");
					}
					else if (!_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__WarnAboutTypo_4(_email_5__2))
					{
						((Control)_c__DisplayClass8_0_.sendButton).IsEnabled = false;
						goto IL_0071;
					}
					goto end_IL_0011;
					IL_0071:
					Fx92Odf5YJhjb4F5o23y val = default(Fx92Odf5YJhjb4F5o23y);
					try
					{
						TaskAwaiter<RL6qyqfOAMmyV1y9o5am> _u__ = default;
						if (num != 0)
						{
							_u__ = AppShell.Api.CG6ctJm6mh(_email_5__2).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<RL6qyqfOAMmyV1y9o5am>, __ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<RL6qyqfOAMmyV1y9o5am>);
							num = (__1__state = -1);
						}
						RL6qyqfOAMmyV1y9o5am result = _u__.GetResult();
						bool flag = nkelP9fOQIfs4dM8xou1.i2tfO4KYbqq(result.Method) | _c__DisplayClass8_0_.isLink;
						((Control)_c__DisplayClass8_0_.codeBox).IsEnabled = !flag;
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__StartCooldown_2((result.ResendAfterSeconds > 0) ? result.ResendAfterSeconds : 60);
						string text = FormatTtl(result.TtlMinutes);
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)1, flag ? ("验证链接已发送到 " + _email_5__2 + text + "。请到浏览器中打开链接完成验证。") : ("验证码已发送到 " + _email_5__2 + text + "。"));
						if (!flag)
						{
							((UIElement)_c__DisplayClass8_0_.codeBox).Focus((FocusState)3);
						}
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj2 = ((obj is Fx92Odf5YJhjb4F5o23y) ? obj : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
						if (obj2 == null)
						{
							result2 = 0;
						}
						else
						{
							val = (Fx92Odf5YJhjb4F5o23y)obj2;
							result2 = (val.IsRateLimited ? 1 : 0);
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 360);
						int num2 = ((val.RetryAfterSeconds > 0) ? val.RetryAfterSeconds : 60);
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__StartCooldown_2(num2);
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)2, $"发送过于频繁，请 {num2} 秒后再试");
					}
					catch (Fx92Odf5YJhjb4F5o23y val2)
					{
						Fx92Odf5YJhjb4F5o23y val3 = val2;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 367);
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__StopCooldown_1();
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, ((global::System.Exception)(object)val3).Message);
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__StopCooldown_1();
						_c__DisplayClass8_0_._ShowEmailBindingDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, AppShell.GetExceptionDisplayMessage(exception, "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 374));
					}
					end_IL_0011:;
				}
				catch (global::System.Exception exception2)
				{
					__1__state = -2;
					_email_5__2 = null;
					__t__builder.SetException(exception2);
					return;
				}
				__1__state = -2;
				_email_5__2 = null;
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

		public InfoBar messageBar;

		public int remainingSeconds;

		public DispatcherQueueTimer resendTimer;

		public Button sendButton;

		public string sendButtonText;

		public string typoConfirmedFor;

		public TextBox emailBox;

		public bool isLink;

		public TextBox codeBox;

		public bool verified;

		public bool mandatory;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_6()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowEmailBindingDialogAsync_g__ShowMessage_0(InfoBarSeverity severity, string message)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			messageBar.ActionButton = null;
			messageBar.Severity = severity;
			messageBar.Message = message;
			NotificationAutoDismiss.Show(messageBar);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowEmailBindingDialogAsync_g__StopCooldown_1()
		{
			remainingSeconds = 0;
			DispatcherQueueTimer obj = resendTimer;
			if (obj != null)
			{
				obj.Stop();
			}
			((ContentControl)sendButton).Content = sendButtonText;
			((Control)sendButton).IsEnabled = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowEmailBindingDialogAsync_g__StartCooldown_2(int seconds)
		{
			int num = Math.Clamp(seconds, 1, 3600);
			if (resendTimer == null)
			{
				((Control)sendButton).IsEnabled = true;
				return;
			}
			remainingSeconds = num;
			((Control)sendButton).IsEnabled = false;
			((ContentControl)sendButton).Content = $"{remainingSeconds} 秒后可重发";
			resendTimer.Start();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowEmailBindingDialogAsync_b__3(DispatcherQueueTimer _, object _2)
		{
			remainingSeconds--;
			if (remainingSeconds <= 0)
			{
				_ShowEmailBindingDialogAsync_g__StopCooldown_1();
				return;
			}
			((ContentControl)sendButton).Content = $"{remainingSeconds} 秒后可重发";
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ShowEmailBindingDialogAsync_g__WarnAboutTypo_4(string email)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			__c__DisplayClass8_1 _c__DisplayClass8_ = (__c__DisplayClass8_1)new __c__DisplayClass8_1
			{
				CS___8__locals1 = this,
				suggestion = F0NMLsCkIKFUF5TJCVr.AYWCYaQrtD(email)
			};
			if (_c__DisplayClass8_.suggestion == null || string.Equals(typoConfirmedFor, email, (StringComparison)5))
			{
				return false;
			}
			typoConfirmedFor = email;
			Button val = new Button
			{
				Content = "改为 " + _c__DisplayClass8_.suggestion
			};
			((ButtonBase)val).Click += new RoutedEventHandler(_c__DisplayClass8_._ShowEmailBindingDialogAsync_b__9);
			messageBar.ActionButton = (ButtonBase)(object)val;
			messageBar.Severity = (InfoBarSeverity)2;
			messageBar.Message = $"是不是想输 {_c__DisplayClass8_.suggestion}？确认没错的话再点一次「{sendButtonText}」。";
			NotificationAutoDismiss.Show(messageBar);
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _ShowEmailBindingDialogAsync_g__SendVerificationAsync_5()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d _ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d = default(__ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d);
			_ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d.__4__this = this;
			_ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d.__1__state = -1;
			_ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d.__t__builder.Start<__ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d>(ref _ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d);
			return _ShowEmailBindingDialogAsync_g__SendVerificationAsync_5_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowEmailBindingDialogAsync_b__6(object _, RoutedEventArgs _2)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowEmailBindingDialogAsync_b__6_d _ShowEmailBindingDialogAsync_b__6_d = default(__ShowEmailBindingDialogAsync_b__6_d);
			_ShowEmailBindingDialogAsync_b__6_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowEmailBindingDialogAsync_b__6_d.__4__this = this;
			_ShowEmailBindingDialogAsync_b__6_d.__1__state = -1;
			_ShowEmailBindingDialogAsync_b__6_d.__t__builder.Start<__ShowEmailBindingDialogAsync_b__6_d>(ref _ShowEmailBindingDialogAsync_b__6_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowEmailBindingDialogAsync_b__7(ContentDialog _, ContentDialogButtonClickEventArgs args)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowEmailBindingDialogAsync_b__7_d _ShowEmailBindingDialogAsync_b__7_d = default(__ShowEmailBindingDialogAsync_b__7_d);
			_ShowEmailBindingDialogAsync_b__7_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowEmailBindingDialogAsync_b__7_d.__4__this = this;
			_ShowEmailBindingDialogAsync_b__7_d.args = args;
			_ShowEmailBindingDialogAsync_b__7_d.__1__state = -1;
			_ShowEmailBindingDialogAsync_b__7_d.__t__builder.Start<__ShowEmailBindingDialogAsync_b__7_d>(ref _ShowEmailBindingDialogAsync_b__7_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowEmailBindingDialogAsync_b__8(ContentDialog _, ContentDialogClosingEventArgs args)
		{
			if (mandatory && !verified)
			{
				args.Cancel = true;
				return;
			}
			DispatcherQueueTimer obj = resendTimer;
			if (obj != null)
			{
				obj.Stop();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass8_1
	{
		public string suggestion;

		public __c__DisplayClass8_0_6 CS___8__locals1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowEmailBindingDialogAsync_b__9(object _, RoutedEventArgs _2)
		{
			CS___8__locals1.emailBox.Text = suggestion;
			CS___8__locals1.emailBox.SelectionStart = suggestion.Length;
			CS___8__locals1.typoConfirmedFor = string.Empty;
			NotificationAutoDismiss.Hide(CS___8__locals1.messageBar);
			CS___8__locals1.messageBar.ActionButton = null;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _EnterAppAsync_d__45 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ShellView __4__this;

		private Vo4fPIy7BiQdhKR0A4E _identity_5__2;

		private TaskAwaiter<dN4xMCftS2WHJlRJeqrU> __u__1;

		private TaskAwaiter __u__2;

		private TaskAwaiter<bool> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
			try
			{
				TaskAwaiter<dN4xMCftS2WHJlRJeqrU> _u__3 = default;
				TaskAwaiter _u__ = default;
				TaskAwaiter<bool> _u__2 = default;
				dN4xMCftS2WHJlRJeqrU result;
				switch (num)
				{
				default:
					_identity_5__2 = AppShell.Api.E55c4UCxKQ();
					_u__3 = AppShell.Api.C5p8zstqpd(default(CancellationToken)).GetAwaiter();
					if (!_u__3.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__3;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<dN4xMCftS2WHJlRJeqrU>, _EnterAppAsync_d__45>(ref _u__3, ref this);
						return;
					}
					goto IL_00ac;
				case 0:
					_u__3 = __u__1;
					__u__1 = default(TaskAwaiter<dN4xMCftS2WHJlRJeqrU>);
					num = (__1__state = -1);
					goto IL_00ac;
				case 1:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0172;
				case 2:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_020a;
				case 3:
					_u__2 = __u__3;
					__u__3 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_0285;
				case 4:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_02f0;
				case 5:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0351;
				case 6:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_03b2;
				case 7:
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_02f0:
					_u__.GetResult();
					_u__ = shellView.ShowEmailBindingPromptAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 5);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EnterAppAsync_d__45>(ref _u__, ref this);
						return;
					}
					goto IL_0351;
					IL_00ac:
					result = _u__3.GetResult();
					if (AppShell.Api.q3TchNx7iU(_identity_5__2))
					{
						AppShell.ClearSessionState();
						((UIElement)shellView.Auth).Visibility = (Visibility)1;
						((UIElement)shellView.AppLayer).Visibility = (Visibility)0;
						shellView.UpdateJavaNavigation(result);
						shellView.UserFooter.Update(result);
						shellView.NavigateContent(NavigationRegistry.MainPageType("home"), null);
						AppShell.Success("登录成功");
						_u__ = DesktopWebLoginCoordinator.ResumeAfterAuthenticationAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EnterAppAsync_d__45>(ref _u__, ref this);
							return;
						}
						goto IL_0172;
					}
					goto end_IL_0011;
					IL_03b2:
					_u__.GetResult();
					_u__ = UwpLoopbackUnlockPrompt.ShowIfNeededAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 7);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EnterAppAsync_d__45>(ref _u__, ref this);
						return;
					}
					break;
					IL_020a:
					_u__.GetResult();
					if (AppShell.Api.q3TchNx7iU(_identity_5__2))
					{
						_u__2 = shellView.CheckForMandatoryUpdateAsync().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 3);
							__u__3 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _EnterAppAsync_d__45>(ref _u__2, ref this);
							return;
						}
						goto IL_0285;
					}
					goto end_IL_0011;
					IL_0172:
					_u__.GetResult();
					if (AppShell.Api.q3TchNx7iU(_identity_5__2))
					{
						_u__ = AppShell.RunAsync(AppShell.RefreshSummaryAsync).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EnterAppAsync_d__45>(ref _u__, ref this);
							return;
						}
						goto IL_020a;
					}
					goto end_IL_0011;
					IL_0351:
					_u__.GetResult();
					_u__ = shellView.ShowLoginAnnouncementsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 6);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EnterAppAsync_d__45>(ref _u__, ref this);
						return;
					}
					goto IL_03b2;
					IL_0285:
					if (_u__2.GetResult())
					{
						_u__ = shellView.ShowChangelogOnUpgradeAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 4);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EnterAppAsync_d__45>(ref _u__, ref this);
							return;
						}
						goto IL_02f0;
					}
					goto end_IL_0011;
				}
				_u__.GetResult();
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _NavView_ItemInvoked_d__39 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public NavigationViewItemInvokedEventArgs args;

		public ShellView __4__this;

		private global::System.Type _pageType_5__2;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00bd;
				}
				NavigationViewItemBase invokedItemContainer = args.InvokedItemContainer;
				_pageType_5__2 = NavigationRegistry.ResolveMain((invokedItemContainer != null) ? ((FrameworkElement)invokedItemContainer).Tag : null);
				bool flag;
				if (_pageType_5__2 != null)
				{
					flag = NavigationRegistry.IsBedrockPage(_pageType_5__2);
					if (flag)
					{
						_u__ = BedrockAccessGuard.EnsureAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _NavView_ItemInvoked_d__39>(ref _u__, ref this);
							return;
						}
						goto IL_00bd;
					}
					goto IL_00c8;
				}
				goto end_IL_0011;
				IL_00bd:
				flag = !_u__.GetResult();
				goto IL_00c8;
				IL_00c8:
				if (!flag)
				{
					shellView.NavigateContent(_pageType_5__2, null);
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_pageType_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_pageType_5__2 = null;
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
	private struct _OnAuthenticationSucceeded_d__44 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ShellView __4__this;

		private Vo4fPIy7BiQdhKR0A4E _identity_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_003f;
				}
				if (!shellView._enteringApp)
				{
					shellView._enteringApp = true;
					_identity_5__2 = AppShell.Api.E55c4UCxKQ();
					goto IL_003f;
				}
				goto end_IL_0011;
				IL_003f:
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = shellView.EnterAppAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnAuthenticationSucceeded_d__44>(ref _u__, ref this);
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
					if (AppShell.Api.q3TchNx7iU(_identity_5__2) || AppShell.Api.CurrentUser == null)
					{
						shellView.EnterAuthenticationState(AppShell.GetExceptionDisplayMessage(exception, "OnAuthenticationSucceeded", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.xaml.cs", 238));
					}
				}
				finally
				{
					if (num < 0)
					{
						shellView._enteringApp = false;
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_identity_5__2 = null;
				__t__builder.SetException(exception2);
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
	private struct _OnLogoutRequested_d__51 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ShellView __4__this;

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
			ShellView __8_locals1 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__OnLogoutRequested_b__51_0_d _OnLogoutRequested_b__51_0_d = default(__OnLogoutRequested_b__51_0_d);
						_OnLogoutRequested_b__51_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_OnLogoutRequested_b__51_0_d.__4__this = __8_locals1;
						_OnLogoutRequested_b__51_0_d.__1__state = -1;
						_OnLogoutRequested_b__51_0_d.__t__builder.Start<__OnLogoutRequested_b__51_0_d>(ref _OnLogoutRequested_b__51_0_d);
						return _OnLogoutRequested_b__51_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnLogoutRequested_d__51>(ref _u__, ref this);
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
	private struct _OnRefreshRequested_d__48 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ShellView __4__this;

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
			ShellView __8_locals1 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__OnRefreshRequested_b__48_0_d _OnRefreshRequested_b__48_0_d = default(__OnRefreshRequested_b__48_0_d);
						_OnRefreshRequested_b__48_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_OnRefreshRequested_b__48_0_d.__4__this = __8_locals1;
						_OnRefreshRequested_b__48_0_d.__1__state = -1;
						_OnRefreshRequested_b__48_0_d.__t__builder.Start<__OnRefreshRequested_b__48_0_d>(ref _OnRefreshRequested_b__48_0_d);
						return _OnRefreshRequested_b__48_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnRefreshRequested_d__48>(ref _u__, ref this);
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
	private struct _RefreshCurrentPageAsync_d__49 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ShellView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
				{
					object content = ((ContentControl)shellView.ContentFrame).Content;
					FrameworkElement val = (FrameworkElement)((content is FrameworkElement) ? content : null);
					if (val != null)
					{
						if (val is BFW7DwZLAOwBnfcMB57 bFW7DwZLAOwBnfcMB)
						{
							_u__ = bFW7DwZLAOwBnfcMB.DTiZDQoFn6().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshCurrentPageAsync_d__49>(ref _u__, ref this);
								return;
							}
							goto IL_0118;
						}
						if (val is BpOjxVLPwPUO93lZkbW bpOjxVLPwPUO93lZkbW)
						{
							_u__ = bpOjxVLPwPUO93lZkbW.ORoLT64Rjr().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshCurrentPageAsync_d__49>(ref _u__, ref this);
								return;
							}
							goto IL_017f;
						}
						if (val is iv7VBsjI8muRaeK8cVn iv7VBsjI8muRaeK8cVn)
						{
							_u__ = iv7VBsjI8muRaeK8cVn.qlhjdAvSaB().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshCurrentPageAsync_d__49>(ref _u__, ref this);
								return;
							}
							goto IL_01e6;
						}
						if (!(val is HomePage) && !(val is ProductPage))
						{
							if (val is AccountPage accountPage)
							{
								_u__ = accountPage.RefreshForShellAsync().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 3);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshCurrentPageAsync_d__49>(ref _u__, ref this);
									return;
								}
								goto IL_024d;
							}
							if (val is BalancePage balancePage)
							{
								_u__ = balancePage.RefreshForShellAsync().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 4);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshCurrentPageAsync_d__49>(ref _u__, ref this);
									return;
								}
								goto IL_02b4;
							}
							if (val is PaymentOrdersPage paymentOrdersPage)
							{
								_u__ = paymentOrdersPage.RefreshForShellAsync().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 5);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshCurrentPageAsync_d__49>(ref _u__, ref this);
									return;
								}
								break;
							}
						}
					}
					goto end_IL_0011;
				}
				case 0:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0118;
				case 1:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_017f;
				case 2:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_01e6;
				case 3:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_024d;
				case 4:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_02b4;
				case 5:
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_024d:
					_u__.GetResult();
					goto end_IL_0011;
					IL_017f:
					_u__.GetResult();
					goto end_IL_0011;
					IL_01e6:
					_u__.GetResult();
					goto end_IL_0011;
					IL_0118:
					_u__.GetResult();
					goto end_IL_0011;
					IL_02b4:
					_u__.GetResult();
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshSummaryQuietlyAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.RefreshSummaryAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshSummaryQuietlyAsync_d__7>(ref _u__, ref this);
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
				catch (global::System.Exception)
				{
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ShowChangelogOnUpgradeAsync_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ShellView __4__this;

		private string _localVersion_5__2;

		private TaskAwaiter<PJWRpXfOZeOHKi4Pca4V> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_006e;
				}
				TaskAwaiter _u__ = default;
				if (num == 1)
				{
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_019b;
				}
				string text = default(string);
				try
				{
					_localVersion_5__2 = PrFs4fOBwUvdAORC617.CfCOdBTIDC();
					text = qJZUC0JY3okUVxPyXoP.ECLJ8DrKaM();
				}
				catch (global::System.Exception)
				{
					goto end_IL_0011;
				}
				if (text.Length == 0)
				{
					qJZUC0JY3okUVxPyXoP.gkTJydRdHq(_localVersion_5__2);
				}
				else if (qJZUC0JY3okUVxPyXoP.JL6JWL6oSt(_localVersion_5__2, text) > 0)
				{
					goto IL_006e;
				}
				goto end_IL_0011;
				IL_006e:
					text = default;
				PJWRpXfOZeOHKi4Pca4V result;
				try
				{
					TaskAwaiter<PJWRpXfOZeOHKi4Pca4V> _u__2 = default;
					if (num != 0)
					{
						_u__2 = shellView._changelogService.W8jJ0iw47P(text, default(CancellationToken)).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PJWRpXfOZeOHKi4Pca4V>, _ShowChangelogOnUpgradeAsync_d__2>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<PJWRpXfOZeOHKi4Pca4V>);
						num = (__1__state = -1);
					}
					result = _u__2.GetResult();
				}
				catch (global::System.Exception)
				{
					goto end_IL_0011;
				}
				qJZUC0JY3okUVxPyXoP.gkTJydRdHq(_localVersion_5__2);
				if (result.Entries.Count != 0)
				{
					_u__ = ChangelogDialog.ShowAsync(((UIElement)shellView).XamlRoot, (global::System.Collections.Generic.IReadOnlyList<d2iiUHfOLr9ZvQq4WHMC>)result.Entries, "更新日志 · v" + _localVersion_5__2.TrimStart(new char[2] { 'v', 'V' })).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ShowChangelogOnUpgradeAsync_d__2>(ref _u__, ref this);
						return;
					}
					goto IL_019b;
				}
				goto end_IL_0011;
				IL_019b:
				_u__.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_localVersion_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_localVersion_5__2 = null;
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
	private struct _ShowEmailBindingPromptAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ShellView __4__this;

		private TaskAwaiter<tR6PgnfOrMtDaK70FTsD> __u__1;

		private TaskAwaiter<bool> __u__2;

		private TaskAwaiter __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a4: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
			try
			{
				TaskAwaiter<bool> _u__2 = default;
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
					if (((UIElement)shellView).XamlRoot != null)
					{
						goto case 0;
					}
					goto end_IL_0011;
				case 0:
				{
					tR6PgnfOrMtDaK70FTsD result;
					try
					{
						TaskAwaiter<tR6PgnfOrMtDaK70FTsD> _u__3 = default;
						if (num != 0)
						{
							_u__3 = AppShell.Api.Vh0cHLpAgq().GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tR6PgnfOrMtDaK70FTsD>, _ShowEmailBindingPromptAsync_d__4>(ref _u__3, ref this);
								return;
							}
						}
						else
						{
							_u__3 = __u__1;
							__u__1 = default(TaskAwaiter<tR6PgnfOrMtDaK70FTsD>);
							num = (__1__state = -1);
						}
						result = _u__3.GetResult();
					}
					catch (Fx92Odf5YJhjb4F5o23y val)
					{
						Fx92Odf5YJhjb4F5o23y val2 = val;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "ShowEmailBindingPromptAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 41);
						AppShell.Warning("邮箱绑定状态获取失败：" + ((global::System.Exception)(object)val2).Message);
						goto end_IL_0011;
					}
					catch (global::System.Exception exception)
					{
						AppShell.Warning("邮箱绑定状态获取失败：" + AppShell.GetExceptionDisplayMessage(exception, "ShowEmailBindingPromptAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 48));
						goto end_IL_0011;
					}
					if (!result.EmailVerified && result.PromptRequired)
					{
						_u__2 = ShowEmailBindingDialogAsync(((UIElement)shellView).XamlRoot, result, result.PromptMandatory, allowSnooze: true).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ShowEmailBindingPromptAsync_d__4>(ref _u__2, ref this);
							return;
						}
						goto IL_0182;
					}
					goto end_IL_0011;
				}
				case 1:
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_0182;
				case 2:
					{
						_u__ = __u__3;
						__u__3 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_0182:
					if (_u__2.GetResult())
					{
						_u__ = RefreshSummaryQuietlyAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ShowEmailBindingPromptAsync_d__4>(ref _u__, ref this);
							return;
						}
						break;
					}
					goto end_IL_0011;
				}
				_u__.GetResult();
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
	private struct _ShowLoginAnnouncementsAsync_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ShellView __4__this;

		private string _clientVersion_5__2;

		private List<wmdNEbfHAbSdfRGI5xOQ> _announcements_5__3;

		private TaskAwaiter<jst9T8fHBNSLvRxAhlS5> __u__1;

		private TaskAwaiter<ContentDialogResult> __u__2;

		private TaskAwaiter<NhYeYbfHta7d3JARqihF> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0553: Unknown result type (might be due to invalid IL or missing references)
			//IL_0558: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0571: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Invalid comparison between Unknown and I4
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0614: Unknown result type (might be due to invalid IL or missing references)
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0593: Unknown result type (might be due to invalid IL or missing references)
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dc: Expected O, but got Unknown
			//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Expected O, but got Unknown
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Expected O, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected O, but got Unknown
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Expected O, but got Unknown
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected O, but got Unknown
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Expected O, but got Unknown
			//IL_02da: Expected O, but got Unknown
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Unknown result type (might be due to invalid IL or missing references)
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Expected O, but got Unknown
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Expected O, but got Unknown
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d5: Expected O, but got Unknown
			//IL_051b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ShellView shellView = __4__this;
			try
			{
				TaskAwaiter<ContentDialogResult> _u__ = default;
				switch (num)
				{
				default:
				{
					jst9T8fHBNSLvRxAhlS5 result;
					try
					{
						TaskAwaiter<jst9T8fHBNSLvRxAhlS5> _u__2 = default;
						if (num != 0)
						{
							_clientVersion_5__2 = PrFs4fOBwUvdAORC617.CfCOdBTIDC();
							_u__2 = AppShell.Api.oNPc8w5MfP(_clientVersion_5__2).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<jst9T8fHBNSLvRxAhlS5>, _ShowLoginAnnouncementsAsync_d__0>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<jst9T8fHBNSLvRxAhlS5>);
							num = (__1__state = -1);
						}
						result = _u__2.GetResult();
					}
					catch (global::System.Exception)
					{
						goto end_IL_0011;
					}
					_announcements_5__3 = Enumerable.ToList<wmdNEbfHAbSdfRGI5xOQ>((global::System.Collections.Generic.IEnumerable<wmdNEbfHAbSdfRGI5xOQ>)Enumerable.ThenByDescending<wmdNEbfHAbSdfRGI5xOQ, long>(Enumerable.ThenByDescending<wmdNEbfHAbSdfRGI5xOQ, DateTimeOffset>(Enumerable.ThenByDescending<wmdNEbfHAbSdfRGI5xOQ, int>(Enumerable.OrderByDescending<wmdNEbfHAbSdfRGI5xOQ, bool>((global::System.Collections.Generic.IEnumerable<wmdNEbfHAbSdfRGI5xOQ>)result.Announcements, (Func<wmdNEbfHAbSdfRGI5xOQ, bool>)__c_23.__9._ShowLoginAnnouncementsAsync_b__0_0), (Func<wmdNEbfHAbSdfRGI5xOQ, int>)__c_23.__9._ShowLoginAnnouncementsAsync_b__0_1), (Func<wmdNEbfHAbSdfRGI5xOQ, DateTimeOffset>)__c_23.__9._ShowLoginAnnouncementsAsync_b__0_2), (Func<wmdNEbfHAbSdfRGI5xOQ, long>)__c_23.__9._ShowLoginAnnouncementsAsync_b__0_3));
					if (_announcements_5__3.Count != 0)
					{
						bool isDarkTheme = AppearanceSettings.IsDarkTheme;
						StackPanel val = new StackPanel
						{
							Spacing = 18.0,
							MaxWidth = 720.0
						};
						for (int i = 0; i < _announcements_5__3.Count; i++)
						{
							wmdNEbfHAbSdfRGI5xOQ val2 = _announcements_5__3[i];
							StackPanel val3 = new StackPanel
							{
								Spacing = 10.0
							};
							Grid val4 = new Grid
							{
								ColumnSpacing = 10.0
							};
							val4.ColumnDefinitions.Add(new ColumnDefinition
							{
								Width = new GridLength(1.0, (GridUnitType)2)
							});
							val4.ColumnDefinitions.Add(new ColumnDefinition
							{
								Width = GridLength.Auto
							});
							((Panel)val4).Children.Add((UIElement)new TextBlock
							{
								Text = val2.Title,
								FontSize = 20.0,
								FontWeight = FontWeights.SemiBold,
								TextWrapping = (TextWrapping)2,
								VerticalAlignment = (VerticalAlignment)1
							});
							if (val2.IsMandatory)
							{
								Border val5 = new Border
								{
									Style = null,
									Child = (UIElement)new TextBlock
									{
										Text = "必须确认",
										FontSize = 12.0,
										Foreground = default(Brush)
									}
								};
								Grid.SetColumn((FrameworkElement)(object)val5, 1);
								((Panel)val4).Children.Add((UIElement)(object)val5);
							}
							((Panel)val3).Children.Add((UIElement)(object)val4);
							((Panel)val3).Children.Add((UIElement)new TextBlock
							{
								Text = val2.DisplayModeText + " · " + val2.TargetRoleText,
								FontSize = 12.0,
								Style = null
							});
							((Panel)val3).Children.Add((UIElement)(object)AnnouncementMarkdownRenderer.CreateView(val2.ContentMarkdown, isDarkTheme));
							((Panel)val).Children.Add((UIElement)(object)val3);
							if (i < _announcements_5__3.Count - 1)
							{
								((Panel)val).Children.Add((UIElement)new Border
								{
									Height = 1.0,
									Background = default(Brush)
								});
							}
						}
						bool num2 = Enumerable.Any<wmdNEbfHAbSdfRGI5xOQ>((global::System.Collections.Generic.IEnumerable<wmdNEbfHAbSdfRGI5xOQ>)_announcements_5__3, (Func<wmdNEbfHAbSdfRGI5xOQ, bool>)__c_23.__9._ShowLoginAnnouncementsAsync_b__0_4);
						ContentDialog val6 = new ContentDialog
						{
							XamlRoot = ((UIElement)shellView).XamlRoot,
							RequestedTheme = AppearanceSettings.Theme,
							Title = ((_announcements_5__3.Count > 1) ? $"公告（{_announcements_5__3.Count} 条）" : "公告"),
							Content = (object)new ScrollViewer
							{
								Content = val,
								MaxHeight = 560.0,
								VerticalScrollBarVisibility = (ScrollBarVisibility)1,
								HorizontalScrollBarVisibility = (ScrollBarVisibility)0
							},
							PrimaryButtonText = "知道了",
							DefaultButton = (ContentDialogButton)1
						};
						if (num2)
						{
							val6.Closing += __c_23.__9._ShowLoginAnnouncementsAsync_b__0_5;
						}
						else
						{
							val6.CloseButtonText = "稍后提醒";
						}
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(val6.ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ShowLoginAnnouncementsAsync_d__0>(ref _u__, ref this);
							return;
						}
						goto IL_056f;
					}
					goto end_IL_0011;
				}
				case 1:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter<ContentDialogResult>);
					num = (__1__state = -1);
					goto IL_056f;
				case 2:
					break;
					IL_056f:
					if ((int)_u__.GetResult() == 1)
					{
						break;
					}
					goto end_IL_0011;
				}
				try
				{
					TaskAwaiter<NhYeYbfHta7d3JARqihF> _u__3 = default;
					if (num != 2)
					{
						_u__3 = AppShell.Api.XMVcyYAl1S(new pO9GrCfHK9BLBgvouYYJ
						{
							ClientVersion = _clientVersion_5__2,
							Items = Enumerable.ToList<Tds4VefHlk4juYavZRe7>(Enumerable.Select<wmdNEbfHAbSdfRGI5xOQ, Tds4VefHlk4juYavZRe7>((global::System.Collections.Generic.IEnumerable<wmdNEbfHAbSdfRGI5xOQ>)_announcements_5__3, (Func<wmdNEbfHAbSdfRGI5xOQ, Tds4VefHlk4juYavZRe7>)__c_23.__9._ShowLoginAnnouncementsAsync_b__0_6))
						}).GetAwaiter();
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<NhYeYbfHta7d3JARqihF>, _ShowLoginAnnouncementsAsync_d__0>(ref _u__3, ref this);
							return;
						}
					}
					else
					{
						_u__3 = __u__3;
						__u__3 = default(TaskAwaiter<NhYeYbfHta7d3JARqihF>);
						num = (__1__state = -1);
					}
					_u__3.GetResult();
				}
				catch (global::System.Exception)
				{
					AppShell.Warning("公告确认状态暂未同步，下次登录将再次显示");
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_clientVersion_5__2 = null;
				_announcements_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_clientVersion_5__2 = null;
			_announcements_5__3 = null;
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

	private static Regex EmailPattern;

	private readonly PrFs4fOBwUvdAORC617 _updateCheckService;

	private bool _enteringApp;

	private bool _restorePaneAfterBedrock;

	private DispatcherQueueTimer? _loadingHideTimer;

	private dN4xMCftS2WHJlRJeqrU? _navigationUser;

	[CompilerGenerated]
	private EventHandler? m_CloseWindowRequested;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid RootGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border BackdropFallback;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid AppLayer;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AuthView Auth;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkTopLeft;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkTopCenter;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkTopRight;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkUpperLeftOffset;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkUpperRightOffset;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkMiddleLeft;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkMiddleCenter;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkMiddleRight;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkLeft;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkCenter;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkRight;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkLowerLeftOffset;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppWatermark WatermarkLowerRightOffset;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBarHost Notifications;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid LoadingOverlay;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ShutdownUploadOverlay ShutdownOverlay;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LoadingCard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing GlobalProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TitleBar AppTitleBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NavigationView NavView;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NavigationViewItem JavaNavItem;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NavigationUserFooter UserFooter;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Frame ContentFrame;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ThemeToggleButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IShellView_Bindings Bindings;

	internal TitleBar TitleBarElement
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return AppTitleBar;
		}
	}

	public XamlRoot? ShellXamlRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((UIElement)this).XamlRoot;
		}
	}

	internal EventHandler CloseWindowRequested;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowLoginAnnouncementsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowLoginAnnouncementsAsync_d__0 showLoginAnnouncementsAsync_d__ = default(_ShowLoginAnnouncementsAsync_d__0);
		showLoginAnnouncementsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showLoginAnnouncementsAsync_d__.__4__this = this;
		showLoginAnnouncementsAsync_d__.__1__state = -1;
		showLoginAnnouncementsAsync_d__.__t__builder.Start<_ShowLoginAnnouncementsAsync_d__0>(ref showLoginAnnouncementsAsync_d__);
		return showLoginAnnouncementsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowChangelogOnUpgradeAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowChangelogOnUpgradeAsync_d__2 showChangelogOnUpgradeAsync_d__ = default(_ShowChangelogOnUpgradeAsync_d__2);
		showChangelogOnUpgradeAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showChangelogOnUpgradeAsync_d__.__4__this = this;
		showChangelogOnUpgradeAsync_d__.__1__state = -1;
		showChangelogOnUpgradeAsync_d__.__t__builder.Start<_ShowChangelogOnUpgradeAsync_d__2>(ref showChangelogOnUpgradeAsync_d__);
		return showChangelogOnUpgradeAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowEmailBindingPromptAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowEmailBindingPromptAsync_d__4 showEmailBindingPromptAsync_d__ = default(_ShowEmailBindingPromptAsync_d__4);
		showEmailBindingPromptAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showEmailBindingPromptAsync_d__.__4__this = this;
		showEmailBindingPromptAsync_d__.__1__state = -1;
		showEmailBindingPromptAsync_d__.__t__builder.Start<_ShowEmailBindingPromptAsync_d__4>(ref showEmailBindingPromptAsync_d__);
		return showEmailBindingPromptAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<bool> EnsureEmailBoundAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		XamlRoot xamlRoot = AppShell.XamlRoot;
		if (xamlRoot == null)
		{
			return false;
		}
		tR6PgnfOrMtDaK70FTsD val;
		try
		{
			val = await AppShell.Api.Vh0cHLpAgq();
		}
		catch (Fx92Odf5YJhjb4F5o23y val2)
		{
			Fx92Odf5YJhjb4F5o23y val3 = val2;
			cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "EnsureEmailBoundAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 87);
			AppShell.Error("邮箱绑定状态获取失败：" + ((global::System.Exception)(object)val3).Message);
			return false;
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error("邮箱绑定状态获取失败：" + AppShell.GetExceptionDisplayMessage(exception, "EnsureEmailBoundAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 93));
			return false;
		}
		if (val.EmailVerified)
		{
			return true;
		}
		bool flag = await ShowEmailBindingDialogAsync(xamlRoot, val, mandatory: false, allowSnooze: false);
		if (flag)
		{
			await RefreshSummaryQuietlyAsync();
		}
		return flag;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Threading.Tasks.Task<bool> ShowEmailBindingFlowAsync()
	{
		return EnsureEmailBoundAsync();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task RefreshSummaryQuietlyAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshSummaryQuietlyAsync_d__7 refreshSummaryQuietlyAsync_d__ = default(_RefreshSummaryQuietlyAsync_d__7);
		refreshSummaryQuietlyAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshSummaryQuietlyAsync_d__.__1__state = -1;
		refreshSummaryQuietlyAsync_d__.__t__builder.Start<_RefreshSummaryQuietlyAsync_d__7>(ref refreshSummaryQuietlyAsync_d__);
		return refreshSummaryQuietlyAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static async global::System.Threading.Tasks.Task<bool> ShowEmailBindingDialogAsync(XamlRoot xamlRoot, tR6PgnfOrMtDaK70FTsD state, bool mandatory, bool allowSnooze)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass8_0_6 __8_locals44 = (__c__DisplayClass8_0_6)new __c__DisplayClass8_0_6();
		__8_locals44.mandatory = mandatory;
		__8_locals44.isLink = nkelP9fOQIfs4dM8xou1.i2tfO4KYbqq(state.VerifyMethod);
		DispatcherQueue forCurrentThread = DispatcherQueue.GetForCurrentThread();
		__8_locals44.verified = false;
		__8_locals44.remainingSeconds = 0;
		StackPanel val = new StackPanel
		{
			Spacing = 14.0,
			MaxWidth = 460.0
		};
		((Panel)val).Children.Add((UIElement)new TextBlock
		{
			Text = (__8_locals44.mandatory ? "为了账号安全，必须先绑定并验证一个常用邮箱才能继续使用。绑定后可用于找回密码、接收账单与到货提醒。" : "绑定邮箱后可用于找回密码、接收账单与到货提醒，建议现在完成。"),
			TextWrapping = (TextWrapping)2,
			Style = null
		});
		__8_locals44.messageBar = new InfoBar
		{
			IsOpen = false,
			IsClosable = false,
			Severity = (InfoBarSeverity)0
		};
		((Panel)val).Children.Add((UIElement)(object)__8_locals44.messageBar);
		__8_locals44.emailBox = new TextBox
		{
			Header = "邮箱地址",
			PlaceholderText = "you@example.com",
			MaxLength = 190
		};
		if (!string.IsNullOrWhiteSpace(state.Email))
		{
			__8_locals44.emailBox.Text = state.Email.Trim();
			__8_locals44.emailBox.SelectionStart = __8_locals44.emailBox.Text.Length;
		}
		((Panel)val).Children.Add((UIElement)(object)__8_locals44.emailBox);
		__8_locals44.sendButtonText = (__8_locals44.isLink ? "发送验证链接" : "发送验证码");
		__8_locals44.sendButton = new Button
		{
			Content = __8_locals44.sendButtonText,
			HorizontalAlignment = (HorizontalAlignment)3
		};
		((Panel)val).Children.Add((UIElement)(object)__8_locals44.sendButton);
		__8_locals44.codeBox = new TextBox
		{
			Header = "验证码",
			PlaceholderText = "邮件里的 6 位验证码",
			MaxLength = 8,
			IsEnabled = false,
			Visibility = ((__8_locals44.isLink ? true : false) ? Visibility.Visible : Visibility.Collapsed)
		};
		((Panel)val).Children.Add((UIElement)(object)__8_locals44.codeBox);
		TextBlock val2 = new TextBlock
		{
			Text = "点上面的按钮后，请到浏览器中打开邮件里的验证链接，完成后回到这里点「我已完成验证」。",
			TextWrapping = (TextWrapping)2,
			Visibility = ((!__8_locals44.isLink) ? Visibility.Visible : Visibility.Collapsed),
			Style = null
		};
		((Panel)val).Children.Add((UIElement)(object)val2);
		if (state.HasEmail && !state.EmailVerified)
		{
			((Panel)val).Children.Add((UIElement)new TextBlock
			{
				Text = "当前邮箱 " + state.DisplayEmail + " 尚未完成验证。",
				TextWrapping = (TextWrapping)2,
				FontWeight = FontWeights.SemiBold,
				Style = null
			});
		}
		ContentDialog val3 = new ContentDialog
		{
			XamlRoot = xamlRoot,
			RequestedTheme = AppearanceSettings.Theme,
			Title = "绑定邮箱",
			Content = (object)new ScrollViewer
			{
				Content = val,
				MaxHeight = 520.0,
				VerticalScrollBarVisibility = (ScrollBarVisibility)1,
				HorizontalScrollBarVisibility = (ScrollBarVisibility)0
			},
			PrimaryButtonText = (__8_locals44.isLink ? "我已完成验证" : "验证并绑定"),
			DefaultButton = (ContentDialogButton)1
		};
		if (!__8_locals44.mandatory)
		{
			val3.CloseButtonText = (allowSnooze ? "稍后再说" : "取消");
		}
		__8_locals44.resendTimer = ((forCurrentThread != null) ? forCurrentThread.CreateTimer() : null);
		if (__8_locals44.resendTimer != null)
		{
			__8_locals44.resendTimer.Interval = TimeSpan.FromSeconds(1.0);
			__8_locals44.resendTimer.IsRepeating = true;
		}
		if (__8_locals44.resendTimer != null)
		{
			__8_locals44.resendTimer.Tick += [MethodImpl((MethodImplOptions)8)] (DispatcherQueueTimer _, object _) =>
			{
				__8_locals44.remainingSeconds--;
				if (__8_locals44.remainingSeconds <= 0)
				{
					__8_locals44._ShowEmailBindingDialogAsync_g__StopCooldown_1();
				}
				else
				{
					((ContentControl)__8_locals44.sendButton).Content = $"{__8_locals44.remainingSeconds} 秒后可重发";
				}
			};
		}
		__8_locals44.typoConfirmedFor = string.Empty;
		((ButtonBase)__8_locals44.sendButton).Click += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] (object _, RoutedEventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__c__DisplayClass8_0_6.__ShowEmailBindingDialogAsync_b__6_d _ShowEmailBindingDialogAsync_b__6_d = default(__c__DisplayClass8_0_6.__ShowEmailBindingDialogAsync_b__6_d);
			_ShowEmailBindingDialogAsync_b__6_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowEmailBindingDialogAsync_b__6_d.__4__this = __8_locals44;
			_ShowEmailBindingDialogAsync_b__6_d.__1__state = -1;
			_ShowEmailBindingDialogAsync_b__6_d.__t__builder.Start<__c__DisplayClass8_0_6.__ShowEmailBindingDialogAsync_b__6_d>(ref _ShowEmailBindingDialogAsync_b__6_d);
		});
		val3.PrimaryButtonClick += [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] (ContentDialog _, ContentDialogButtonClickEventArgs args) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__c__DisplayClass8_0_6.__ShowEmailBindingDialogAsync_b__7_d _ShowEmailBindingDialogAsync_b__7_d = default(__c__DisplayClass8_0_6.__ShowEmailBindingDialogAsync_b__7_d);
			_ShowEmailBindingDialogAsync_b__7_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowEmailBindingDialogAsync_b__7_d.__4__this = __8_locals44;
			_ShowEmailBindingDialogAsync_b__7_d.args = args;
			_ShowEmailBindingDialogAsync_b__7_d.__1__state = -1;
			_ShowEmailBindingDialogAsync_b__7_d.__t__builder.Start<__c__DisplayClass8_0_6.__ShowEmailBindingDialogAsync_b__7_d>(ref _ShowEmailBindingDialogAsync_b__7_d);
		};
		val3.Closing += [MethodImpl((MethodImplOptions)8)] (ContentDialog _, ContentDialogClosingEventArgs args) =>
		{
			if (__8_locals44.mandatory && !__8_locals44.verified)
			{
				args.Cancel = true;
			}
			else
			{
				DispatcherQueueTimer obj3 = __8_locals44.resendTimer;
				if (obj3 != null)
				{
					obj3.Stop();
				}
			}
		};
		ContentDialogResult result;
		try
		{
			TaskAwaiter<ContentDialogResult> val4 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(val3.ShowAsync());
			if (!val4.IsCompleted)
			{
				val4.GetResult();
				TaskAwaiter<ContentDialogResult> val5 = default(TaskAwaiter<ContentDialogResult>);
				val4 = val5;
			}
			result = val4.GetResult();
		}
		catch (global::System.Exception exception)
		{
			DispatcherQueueTimer obj = __8_locals44.resendTimer;
			if (obj != null)
			{
				obj.Stop();
			}
			AppShell.Error("邮箱绑定弹窗打开失败：" + AppShell.GetExceptionDisplayMessage(exception, "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 462));
			return false;
		}
		finally
		{
			DispatcherQueueTimer obj2 = __8_locals44.resendTimer;
			if (obj2 != null)
			{
				obj2.Stop();
			}
		}
		if (__8_locals44.verified)
		{
			AppShell.Success("邮箱已绑定并验证");
			return true;
		}
		if (allowSnooze && (int)result == 0)
		{
			try
			{
				Uy9tFVfOxhwU9apNbaGc val6 = await AppShell.Api.tsEcwliGhy();
				AppShell.Info((!val6.SnoozedUntil.HasValue) ? "已推迟邮箱绑定提醒" : ("已推迟邮箱绑定提醒至 " + val6.SnoozedUntilText));
			}
			catch (Fx92Odf5YJhjb4F5o23y val7)
			{
				Fx92Odf5YJhjb4F5o23y val8 = val7;
				cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val8, "ui-exception", "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 488);
				AppShell.Warning("推迟提醒失败：" + ((global::System.Exception)(object)val8).Message);
			}
			catch (global::System.Exception exception2)
			{
				AppShell.Warning("推迟提醒失败：" + AppShell.GetExceptionDisplayMessage(exception2, "ShowEmailBindingDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 493));
			}
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IsValidEmail(string? email)
	{
		if (!string.IsNullOrWhiteSpace(email) && email.Length <= 190)
		{
			return EmailPattern.IsMatch(email);
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<sxb90VfOvfxZ3y2XxwdE?> TryLoadStockSubscriptionsAsync(bool quiet = true)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			return await AppShell.Api.D3Ecx4XJpH();
		}
		catch (global::System.Exception exception)
		{
			if (!quiet)
			{
				AppShell.Error("到货订阅列表加载失败：" + AppShell.GetExceptionDisplayMessage(exception, "TryLoadStockSubscriptionsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.EmailBinding.cs", 516));
			}
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void ApplyStockSubscriptionStates(global::System.Collections.Generic.IEnumerable<long>? subscribedProductIds)
	{
		HashSet<long> val = new HashSet<long>(subscribedProductIds ?? Enumerable.Empty<long>());
		global::System.Collections.Generic.IEnumerator<xbVf4FftyKLP9yqO5mWE> enumerator = ((Collection<xbVf4FftyKLP9yqO5mWE>)(object)AppShell.Products).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				xbVf4FftyKLP9yqO5mWE current = enumerator.Current;
				current.IsSubscribed = val.Contains(current.Id);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void SetStockSubscriptionState(long productId, bool subscribed)
	{
		global::System.Collections.Generic.IEnumerator<xbVf4FftyKLP9yqO5mWE> enumerator = ((Collection<xbVf4FftyKLP9yqO5mWE>)(object)AppShell.Products).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				xbVf4FftyKLP9yqO5mWE current = enumerator.Current;
				if (current.Id == productId)
				{
					current.IsSubscribed = subscribed;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string FormatTtl(int ttlMinutes)
	{
		if (ttlMinutes <= 0)
		{
			return string.Empty;
		}
		return $"，{ttlMinutes} 分钟内有效";
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<bool> CheckForMandatoryUpdateAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		sJFvIGfehRs7r8TsV0mL val;
		try
		{
			val = await YA7sBfOoI9bvBEcJtLN.hbvO7hTeS8(_updateCheckService, default(CancellationToken));
		}
		catch (pgtYkwJFJM26NGMqxI5 val2)
		{
			pgtYkwJFJM26NGMqxI5 val3 = val2;
			cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "CheckForMandatoryUpdateAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\ShellView.UpdateCheck.cs", 22);
			EnterAuthenticationState(((global::System.Exception)(object)val3).Message);
			RequestCloseWindow();
			return false;
		}
		catch
		{
			return true;
		}
		if (!val.IsUpdateAvailable)
		{
			return true;
		}
		await AppUpdateFlow.ShowAsync(((UIElement)this).XamlRoot, val, mandatory: true, new Action(RequestCloseWindow));
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	public ShellView()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		_changelogService = new qJZUC0JY3okUVxPyXoP();
		_updateCheckService = new PrFs4fOBwUvdAORC617();
		InitializeComponent();
		AppShell.Host = this;
		Auth.AuthenticationSucceeded += new EventHandler(OnAuthenticationSucceeded);
		UserFooter.RefreshRequested += new EventHandler(OnRefreshRequested);
		UserFooter.LogoutRequested += new EventHandler(OnLogoutRequested);
		AppearanceSettings.Changed += new EventHandler(OnAppearanceChanged);
		AppShell.SummaryRefreshed += OnSummaryRefreshed;
		ApplyAppearance();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void ShowShutdownUpload()
	{
		ShutdownOverlay.Begin();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void ShowLoading(bool show)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		GlobalProgressRing.IsActive = show;
		if (show)
		{
			DispatcherQueueTimer? loadingHideTimer = _loadingHideTimer;
			if (loadingHideTimer != null)
			{
				loadingHideTimer.Stop();
			}
			((UIElement)LoadingOverlay).Visibility = (Visibility)0;
			((UIElement)LoadingOverlay).Opacity = 1.0;
			((UIElement)LoadingCard).Scale = Vector3.One;
			return;
		}
		((UIElement)LoadingOverlay).Opacity = 0.0;
		((UIElement)LoadingCard).Scale = new Vector3(0.92f, 0.92f, 1f);
		if (_loadingHideTimer == null)
		{
			_loadingHideTimer = ((DependencyObject)this).DispatcherQueue.CreateTimer();
			_loadingHideTimer.Interval = TimeSpan.FromMilliseconds(180.0);
			_loadingHideTimer.IsRepeating = false;
			_loadingHideTimer.Tick += [MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (DispatcherQueueTimer _, object _) =>
			{
				if (((UIElement)LoadingOverlay).Opacity == 0.0)
				{
					((UIElement)LoadingOverlay).Visibility = (Visibility)1;
				}
			};
		}
		_loadingHideTimer.Start();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LoadingCard_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Border loadingCard = LoadingCard;
		Size newSize = e.NewSize;
		float num = (float)(newSize.Width / 2.0);
		newSize = e.NewSize;
		((UIElement)loadingCard).CenterPoint = new Vector3(num, (float)(newSize.Height / 2.0), 0f);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void PostNotification(InfoBarSeverity severity, string message, string? title = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Notifications.Post(severity, message, title);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void NavigateContent(global::System.Type pageType, object? parameter)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)pageType, "pageType");
		if ((!(pageType == typeof(global::Mahiro_Account.Views.Pages.ToolboxPage)) || _navigationUser != null) && (!NavigationRegistry.IsJavaPage(pageType) || NavigationAuthorization.CanAccessJava(_navigationUser)) && (!(ContentFrame.CurrentSourcePageType == pageType) || parameter != null))
		{
			ContentFrame.Navigate(pageType, parameter);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void EnterAuthenticationState(string? message)
	{
		AppShell.ClearSessionState();
		Notifications.Clear();
		ShowLoading(show: false);
		((UIElement)AppLayer).Visibility = (Visibility)1;
		((UIElement)Auth).Visibility = (Visibility)0;
		Auth.Reset(message);
		((UIElement)JavaNavItem).Visibility = (Visibility)1;
		_navigationUser = null;
		NavView.SelectedItem = null;
		((ContentControl)ContentFrame).Content = null;
		((global::System.Collections.Generic.ICollection<PageStackEntry>)ContentFrame.BackStack).Clear();
		UserFooter.Update(null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnAppearanceChanged(object? sender, EventArgs e)
	{
		ApplyAppearance();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyAppearance()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		((FrameworkElement)RootGrid).RequestedTheme = AppearanceSettings.Theme;
		((UIElement)BackdropFallback).Opacity = ((AppearanceSettings.Backdrop == AppBackdropKind.Solid) ? 1 : 0);
		((ContentControl)ThemeToggleButton).Content = (AppearanceSettings.IsDarkTheme ? "\ue706" : "\ue708");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ThemeToggleButton_Click(object sender, RoutedEventArgs e)
	{
		AppearanceSettings.Update((ElementTheme)(AppearanceSettings.IsDarkTheme ? 1 : 2), AppearanceSettings.Backdrop);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AppTitleBar_PaneToggleRequested(TitleBar sender, object args)
	{
		NavView.IsPaneOpen = !NavView.IsPaneOpen;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AppTitleBar_BackRequested(TitleBar sender, object args)
	{
		if (ContentFrame.CanGoBack)
		{
			ContentFrame.GoBack();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_NavView_ItemInvoked_d__39 navView_ItemInvoked_d__ = default(_NavView_ItemInvoked_d__39);
		navView_ItemInvoked_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		navView_ItemInvoked_d__.__4__this = this;
		navView_ItemInvoked_d__.args = args;
		navView_ItemInvoked_d__.__1__state = -1;
		navView_ItemInvoked_d__.__t__builder.Start<_NavView_ItemInvoked_d__39>(ref navView_ItemInvoked_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void NavView_DisplayModeChanged(NavigationView sender, NavigationViewDisplayModeChangedEventArgs args)
	{
		UpdateFooterCompact();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void NavView_PaneStateChanged(NavigationView sender, object args)
	{
		UpdateFooterCompact();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateFooterCompact()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		UserFooter.SetCompact((int)NavView.DisplayMode == 0 || !NavView.IsPaneOpen);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
	{
		string text = NavigationRegistry.MainKeyOf(e.SourcePageType);
		if (text != null && !(text == "productDetail"))
		{
			NavigationViewItem val = NavigationViewItemFinder.FindByTag((global::System.Collections.IEnumerable)NavView.MenuItems, text, NavView.IsPaneOpen);
			if (val != null && NavView.SelectedItem != val)
			{
				NavView.SelectedItem = val;
			}
		}
		if (NavigationRegistry.IsBedrockPage(e.SourcePageType))
		{
			if (NavView.IsPaneOpen && AppearanceSettings.AutoHideSidebarForBedrock)
			{
				_restorePaneAfterBedrock = true;
				NavView.IsPaneOpen = false;
			}
		}
		else if (_restorePaneAfterBedrock)
		{
			_restorePaneAfterBedrock = false;
			NavView.IsPaneOpen = true;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnAuthenticationSucceeded(object? sender, EventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnAuthenticationSucceeded_d__44 onAuthenticationSucceeded_d__ = default(_OnAuthenticationSucceeded_d__44);
		onAuthenticationSucceeded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onAuthenticationSucceeded_d__.__4__this = this;
		onAuthenticationSucceeded_d__.__1__state = -1;
		onAuthenticationSucceeded_d__.__t__builder.Start<_OnAuthenticationSucceeded_d__44>(ref onAuthenticationSucceeded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task EnterAppAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_EnterAppAsync_d__45 enterAppAsync_d__ = default(_EnterAppAsync_d__45);
		enterAppAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		enterAppAsync_d__.__4__this = this;
		enterAppAsync_d__.__1__state = -1;
		enterAppAsync_d__.__t__builder.Start<_EnterAppAsync_d__45>(ref enterAppAsync_d__);
		return enterAppAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSummaryRefreshed(object? sender, yg9HVZft43Yd2k4O7qX5 summary)
	{
		UserFooter.Update(summary.User);
		UpdateJavaNavigation(summary.User);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateJavaNavigation(dN4xMCftS2WHJlRJeqrU? user)
	{
		_navigationUser = user;
		bool flag = NavigationAuthorization.CanAccessJava(user);
		((UIElement)JavaNavItem).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		if (!flag)
		{
			if (NavigationRegistry.IsJavaPage(ContentFrame.CurrentSourcePageType))
			{
				ContentFrame.Navigate(NavigationRegistry.MainPageType("home"));
			}
			PageStackEntry[] array = Enumerable.ToArray<PageStackEntry>(Enumerable.Where<PageStackEntry>((global::System.Collections.Generic.IEnumerable<PageStackEntry>)ContentFrame.BackStack, (Func<PageStackEntry, bool>)([MethodImpl((MethodImplOptions)8)] (PageStackEntry entry) => NavigationRegistry.IsJavaPage(entry.SourcePageType))));
			foreach (PageStackEntry val in array)
			{
				((global::System.Collections.Generic.ICollection<PageStackEntry>)ContentFrame.BackStack).Remove(val);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnRefreshRequested(object? sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnRefreshRequested_d__48 onRefreshRequested_d__ = default(_OnRefreshRequested_d__48);
		onRefreshRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onRefreshRequested_d__.__4__this = this;
		onRefreshRequested_d__.__1__state = -1;
		onRefreshRequested_d__.__t__builder.Start<_OnRefreshRequested_d__48>(ref onRefreshRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshCurrentPageAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshCurrentPageAsync_d__49 refreshCurrentPageAsync_d__ = default(_RefreshCurrentPageAsync_d__49);
		refreshCurrentPageAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshCurrentPageAsync_d__.__4__this = this;
		refreshCurrentPageAsync_d__.__1__state = -1;
		refreshCurrentPageAsync_d__.__t__builder.Start<_RefreshCurrentPageAsync_d__49>(ref refreshCurrentPageAsync_d__);
		return refreshCurrentPageAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		OnRefreshRequested(sender, EventArgs.Empty);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnLogoutRequested(object? sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnLogoutRequested_d__51 onLogoutRequested_d__ = default(_OnLogoutRequested_d__51);
		onLogoutRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onLogoutRequested_d__.__4__this = this;
		onLogoutRequested_d__.__1__state = -1;
		onLogoutRequested_d__.__t__builder.Start<_OnLogoutRequested_d__51>(ref onLogoutRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void RequestCloseWindow()
	{
		EventHandler? obj = this.CloseWindowRequested;
		if (obj != null)
		{
			obj.Invoke((object)this, EventArgs.Empty);
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
			Uri val = new Uri("ms-appx:///UI/Shell/ShellView.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			RootGrid = CastExtensions.As<Grid>(target);
			break;
		case 3:
			BackdropFallback = CastExtensions.As<Border>(target);
			break;
		case 4:
			AppLayer = CastExtensions.As<Grid>(target);
			break;
		case 5:
			Auth = CastExtensions.As<AuthView>(target);
			break;
		case 6:
			WatermarkTopLeft = CastExtensions.As<AppWatermark>(target);
			break;
		case 7:
			WatermarkTopCenter = CastExtensions.As<AppWatermark>(target);
			break;
		case 8:
			WatermarkTopRight = CastExtensions.As<AppWatermark>(target);
			break;
		case 9:
			WatermarkUpperLeftOffset = CastExtensions.As<AppWatermark>(target);
			break;
		case 10:
			WatermarkUpperRightOffset = CastExtensions.As<AppWatermark>(target);
			break;
		case 11:
			WatermarkMiddleLeft = CastExtensions.As<AppWatermark>(target);
			break;
		case 12:
			WatermarkMiddleCenter = CastExtensions.As<AppWatermark>(target);
			break;
		case 13:
			WatermarkMiddleRight = CastExtensions.As<AppWatermark>(target);
			break;
		case 14:
			WatermarkLeft = CastExtensions.As<AppWatermark>(target);
			break;
		case 15:
			WatermarkCenter = CastExtensions.As<AppWatermark>(target);
			break;
		case 16:
			WatermarkRight = CastExtensions.As<AppWatermark>(target);
			break;
		case 17:
			WatermarkLowerLeftOffset = CastExtensions.As<AppWatermark>(target);
			break;
		case 18:
			WatermarkLowerRightOffset = CastExtensions.As<AppWatermark>(target);
			break;
		case 19:
			Notifications = CastExtensions.As<InfoBarHost>(target);
			break;
		case 20:
			LoadingOverlay = CastExtensions.As<Grid>(target);
			break;
		case 21:
			ShutdownOverlay = CastExtensions.As<ShutdownUploadOverlay>(target);
			break;
		case 22:
			LoadingCard = CastExtensions.As<Border>(target);
			((FrameworkElement)LoadingCard).SizeChanged += new SizeChangedEventHandler(LoadingCard_SizeChanged);
			break;
		case 23:
			GlobalProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 24:
			AppTitleBar = CastExtensions.As<TitleBar>(target);
			AppTitleBar.BackRequested += AppTitleBar_BackRequested;
			AppTitleBar.PaneToggleRequested += AppTitleBar_PaneToggleRequested;
			break;
		case 25:
			NavView = CastExtensions.As<NavigationView>(target);
			NavView.DisplayModeChanged += NavView_DisplayModeChanged;
			NavView.ItemInvoked += NavView_ItemInvoked;
			NavView.PaneClosed += NavView_PaneStateChanged;
			NavView.PaneOpened += NavView_PaneStateChanged;
			break;
		case 26:
			JavaNavItem = CastExtensions.As<NavigationViewItem>(target);
			break;
		case 27:
			UserFooter = CastExtensions.As<NavigationUserFooter>(target);
			break;
		case 28:
			ContentFrame = CastExtensions.As<Frame>(target);
			ContentFrame.Navigated += new NavigatedEventHandler(ContentFrame_Navigated);
			break;
		case 29:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 30:
			ThemeToggleButton = CastExtensions.As<Button>(target);
			((ButtonBase)ThemeToggleButton).Click += new RoutedEventHandler(ThemeToggleButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		IComponentConnector result = null;
		if (connectionId == 1)
		{
			UserControl val = (UserControl)target;
			ShellView_obj1_Bindings shellView_obj1_Bindings = (ShellView_obj1_Bindings)new ShellView_obj1_Bindings();
			result = (IComponentConnector)(object)shellView_obj1_Bindings;
			shellView_obj1_Bindings.SetDataRoot(this);
			Bindings = shellView_obj1_Bindings;
			((FrameworkElement)val).Loading += shellView_obj1_Bindings.Loading;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		EmailPattern = new Regex("^[^@\\s]{1,64}@[^@\\s.]{1,63}(\\.[^@\\s.]{1,63})+$", (RegexOptions)520);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void _ShowLoading_b__29_0(DispatcherQueueTimer _, object _2)
	{
		if (((UIElement)LoadingOverlay).Opacity == 0.0)
		{
			((UIElement)LoadingOverlay).Visibility = (Visibility)1;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _OnRefreshRequested_b__48_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__OnRefreshRequested_b__48_0_d _OnRefreshRequested_b__48_0_d = default(__OnRefreshRequested_b__48_0_d);
		_OnRefreshRequested_b__48_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_OnRefreshRequested_b__48_0_d.__4__this = this;
		_OnRefreshRequested_b__48_0_d.__1__state = -1;
		_OnRefreshRequested_b__48_0_d.__t__builder.Start<__OnRefreshRequested_b__48_0_d>(ref _OnRefreshRequested_b__48_0_d);
		return _OnRefreshRequested_b__48_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _OnLogoutRequested_b__51_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__OnLogoutRequested_b__51_0_d _OnLogoutRequested_b__51_0_d = default(__OnLogoutRequested_b__51_0_d);
		_OnLogoutRequested_b__51_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_OnLogoutRequested_b__51_0_d.__4__this = this;
		_OnLogoutRequested_b__51_0_d.__1__state = -1;
		_OnLogoutRequested_b__51_0_d.__t__builder.Start<__OnLogoutRequested_b__51_0_d>(ref _OnLogoutRequested_b__51_0_d);
		return _OnLogoutRequested_b__51_0_d.__t__builder.Task;
	}
}

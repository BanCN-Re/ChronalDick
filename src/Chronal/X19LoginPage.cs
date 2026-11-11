using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using CGTgWZfPLqikrZ4Zv8WL;
using F136b4fPSdmC42O7w85w;
using HyH29AfPDgIWpjh1J2P1;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Navigation;
using PsXpS654E57g4aJfi0E;
using RyDfSXfPyKj0ty7cSIxY;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using cletKkfPZjREQWSkQVvp;
using l6fA40fP0TXAIKJYPUiR;
using lO2F7FfPr06ErwscbOD2;
using lrX9Z9fPViY0A6VWglFy;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class X19LoginPage : Page, IComponentConnector
{
	private enum NeteaseLoginMode
	{
		EmailPassword,
		PhonePassword,
		PhoneSms
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IX19LoginPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IX19LoginPage_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	private class X19LoginPage_obj11_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IX19LoginPage_Bindings
	{
		private G87XFJfPfhylQ4RC1HmY dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj11;

		private TextBlock obj14;

		private TextBlock obj15;

		private TextBlock obj16;

		private TextBlock obj17;

		[MethodImpl((MethodImplOptions)8)]
		public X19LoginPage_obj11_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 11:
				obj11 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 14:
				obj14 = CastExtensions.As<TextBlock>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<TextBlock>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<TextBlock>(target);
				break;
			case 17:
				obj17 = CastExtensions.As<TextBlock>(target);
				break;
			case 12:
			case 13:
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
			object target = obj11.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<G87XFJfPfhylQ4RC1HmY>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<G87XFJfPfhylQ4RC1HmY>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(G87XFJfPfhylQ4RC1HmY obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_SauthStateText(obj.SauthStateText, phase);
				Update_LoginModeText(obj.LoginModeText, phase);
				Update_AccountDisplayText(obj.AccountDisplayText, phase);
				Update_SavedAtText(obj.SavedAtText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_SauthStateText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj14, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_LoginModeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj15, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AccountDisplayText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj16, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_SavedAtText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	private class X19LoginPage_obj1_Bindings : IComponentConnector, IX19LoginPage_Bindings
	{
		private X19LoginPage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ListView obj8;

		[MethodImpl((MethodImplOptions)8)]
		public X19LoginPage_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 8)
			{
				obj8 = CastExtensions.As<ListView>(target);
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
				dataRoot = CastExtensions.As<X19LoginPage>(newDataRoot);
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
		private void Update_(X19LoginPage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_GeneratedAccountHistory(obj.GeneratedAccountHistory, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_GeneratedAccountHistory(ObservableCollection<G87XFJfPfhylQ4RC1HmY> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __X19ClearAccountHistoryButton_Click_b__31_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private TaskAwaiter<AbUlPhfPYYajXI8uxbCb> __u__1;

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
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter<AbUlPhfPYYajXI8uxbCb> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.zPW0r2rLNp().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<AbUlPhfPYYajXI8uxbCb>, __X19ClearAccountHistoryButton_Click_b__31_0_d>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<AbUlPhfPYYajXI8uxbCb>);
					num = (__1__state = -1);
				}
				_u__.GetResult();
				((Collection<G87XFJfPfhylQ4RC1HmY>)(object)x19LoginPage.GeneratedAccountHistory).Clear();
				x19LoginPage.UpdateAccountHistoryState();
				x19LoginPage.X19ResultBox.Text = string.Empty;
				((Control)x19LoginPage.X19CopyResultButton).IsEnabled = false;
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
	private sealed class __c__DisplayClass13_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __X19LoginButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass13_0_1 __4__this;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Unknown result type (might be due to invalid IL or missing references)
				//IL_0111: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_011d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00db: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass13_0_1 _c__DisplayClass13_0_ = __4__this;
				try
				{
					TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__ = default;
					t30hHHfP8gMStFdbd6rB result;
					if (num != 0)
					{
						if (num != 1)
						{
							if (_c__DisplayClass13_0_.__4__this._loginMode == NeteaseLoginMode.PhonePassword)
							{
								_u__ = _c__DisplayClass13_0_.__4__this._x19Service.LoginMobilePasswordAsync(_c__DisplayClass13_0_.account, _c__DisplayClass13_0_.password, default(CancellationToken), true).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __X19LoginButton_Click_b__0_d>(ref _u__, ref this);
									return;
								}
								goto IL_00a7;
							}
							_u__ = _c__DisplayClass13_0_.__4__this._x19Service.spo5hfZ6ui(_c__DisplayClass13_0_.account, _c__DisplayClass13_0_.password, default(CancellationToken), true).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __X19LoginButton_Click_b__0_d>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
							num = (__1__state = -1);
						}
						result = _u__.GetResult();
						goto IL_0134;
					}
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
					num = (__1__state = -1);
					goto IL_00a7;
					IL_00a7:
					result = _u__.GetResult();
					goto IL_0134;
					IL_0134:
					_c__DisplayClass13_0_.result = result;
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

		public X19LoginPage __4__this;

		public string account;

		public string password;

		public t30hHHfP8gMStFdbd6rB result;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass13_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _X19LoginButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__X19LoginButton_Click_b__0_d _X19LoginButton_Click_b__0_d = default(__X19LoginButton_Click_b__0_d);
			_X19LoginButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_X19LoginButton_Click_b__0_d.__4__this = this;
			_X19LoginButton_Click_b__0_d.__1__state = -1;
			_X19LoginButton_Click_b__0_d.__t__builder.Start<__X19LoginButton_Click_b__0_d>(ref _X19LoginButton_Click_b__0_d);
			return _X19LoginButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass14_0_3
	{
		[StructLayout((LayoutKind)3)]
		private struct __X19SendLoginSmsButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass14_0_3 __4__this;

			private TaskAwaiter<aGcPkqfPUnlETcp0tP2t> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass14_0_3 _c__DisplayClass14_0_ = __4__this;
				try
				{
					TaskAwaiter<aGcPkqfPUnlETcp0tP2t> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass14_0_.__4__this._x19Service.SendMobileLoginSmsAsync(_c__DisplayClass14_0_.phone, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aGcPkqfPUnlETcp0tP2t>, __X19SendLoginSmsButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<aGcPkqfPUnlETcp0tP2t>);
						num = (__1__state = -1);
					}
					aGcPkqfPUnlETcp0tP2t result = _u__.GetResult();
					_c__DisplayClass14_0_.result = result;
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

		public X19LoginPage __4__this;

		public string phone;

		public aGcPkqfPUnlETcp0tP2t result;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass14_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _X19SendLoginSmsButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__X19SendLoginSmsButton_Click_b__0_d _X19SendLoginSmsButton_Click_b__0_d = default(__X19SendLoginSmsButton_Click_b__0_d);
			_X19SendLoginSmsButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_X19SendLoginSmsButton_Click_b__0_d.__4__this = this;
			_X19SendLoginSmsButton_Click_b__0_d.__1__state = -1;
			_X19SendLoginSmsButton_Click_b__0_d.__t__builder.Start<__X19SendLoginSmsButton_Click_b__0_d>(ref _X19SendLoginSmsButton_Click_b__0_d);
			return _X19SendLoginSmsButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass15_0_4
	{
		[StructLayout((LayoutKind)3)]
		private struct __X19SubmitLoginSmsButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass15_0_4 __4__this;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass15_0_4 _c__DisplayClass15_0_ = __4__this;
				try
				{
					TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass15_0_.__4__this._x19Service.CompleteMobileSmsLoginAsync(_c__DisplayClass15_0_.phone, _c__DisplayClass15_0_.code, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __X19SubmitLoginSmsButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
						num = (__1__state = -1);
					}
					t30hHHfP8gMStFdbd6rB result = _u__.GetResult();
					_c__DisplayClass15_0_.result = result;
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

		public X19LoginPage __4__this;

		public string phone;

		public string code;

		public t30hHHfP8gMStFdbd6rB result;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass15_0_4()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _X19SubmitLoginSmsButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__X19SubmitLoginSmsButton_Click_b__0_d _X19SubmitLoginSmsButton_Click_b__0_d = default(__X19SubmitLoginSmsButton_Click_b__0_d);
			_X19SubmitLoginSmsButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_X19SubmitLoginSmsButton_Click_b__0_d.__4__this = this;
			_X19SubmitLoginSmsButton_Click_b__0_d.__1__state = -1;
			_X19SubmitLoginSmsButton_Click_b__0_d.__t__builder.Start<__X19SubmitLoginSmsButton_Click_b__0_d>(ref _X19SubmitLoginSmsButton_Click_b__0_d);
			return _X19SubmitLoginSmsButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass16_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __X19SendSmsButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass16_0_1 __4__this;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass16_0_1 _c__DisplayClass16_0_ = __4__this;
				try
				{
					TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass16_0_.__4__this._x19Service.o9e5oE3eau(_c__DisplayClass16_0_.__4__this._x19Ticket, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __X19SendSmsButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
						num = (__1__state = -1);
					}
					t30hHHfP8gMStFdbd6rB result = _u__.GetResult();
					_c__DisplayClass16_0_.result = result;
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

		public X19LoginPage __4__this;

		public t30hHHfP8gMStFdbd6rB result;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass16_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _X19SendSmsButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__X19SendSmsButton_Click_b__0_d _X19SendSmsButton_Click_b__0_d = default(__X19SendSmsButton_Click_b__0_d);
			_X19SendSmsButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_X19SendSmsButton_Click_b__0_d.__4__this = this;
			_X19SendSmsButton_Click_b__0_d.__1__state = -1;
			_X19SendSmsButton_Click_b__0_d.__t__builder.Start<__X19SendSmsButton_Click_b__0_d>(ref _X19SendSmsButton_Click_b__0_d);
			return _X19SendSmsButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass17_0_2
	{
		[StructLayout((LayoutKind)3)]
		private struct __X19SubmitSmsButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass17_0_2 __4__this;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass17_0_2 _c__DisplayClass17_0_ = __4__this;
				try
				{
					TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass17_0_.__4__this._x19Service.lwC5m1qfoG(_c__DisplayClass17_0_.__4__this._x19Ticket, _c__DisplayClass17_0_.code, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __X19SubmitSmsButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
						num = (__1__state = -1);
					}
					t30hHHfP8gMStFdbd6rB result = _u__.GetResult();
					_c__DisplayClass17_0_.result = result;
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

		public X19LoginPage __4__this;

		public string code;

		public t30hHHfP8gMStFdbd6rB result;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass17_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _X19SubmitSmsButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__X19SubmitSmsButton_Click_b__0_d _X19SubmitSmsButton_Click_b__0_d = default(__X19SubmitSmsButton_Click_b__0_d);
			_X19SubmitSmsButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_X19SubmitSmsButton_Click_b__0_d.__4__this = this;
			_X19SubmitSmsButton_Click_b__0_d.__1__state = -1;
			_X19SubmitSmsButton_Click_b__0_d.__t__builder.Start<__X19SubmitSmsButton_Click_b__0_d>(ref _X19SubmitSmsButton_Click_b__0_d);
			return _X19SubmitSmsButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass23_0_2
	{
		[StructLayout((LayoutKind)3)]
		private struct __X19UpsmsCheckButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass23_0_2 __4__this;

			private TaskAwaiter<t30hHHfP8gMStFdbd6rB> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass23_0_2 _c__DisplayClass23_0_ = __4__this;
				try
				{
					TaskAwaiter<t30hHHfP8gMStFdbd6rB> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass23_0_.__4__this._x19Service.hmF57u3jTT(_c__DisplayClass23_0_.__4__this._x19Ticket, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<t30hHHfP8gMStFdbd6rB>, __X19UpsmsCheckButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<t30hHHfP8gMStFdbd6rB>);
						num = (__1__state = -1);
					}
					t30hHHfP8gMStFdbd6rB result = _u__.GetResult();
					_c__DisplayClass23_0_.result = result;
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

		public X19LoginPage __4__this;

		public t30hHHfP8gMStFdbd6rB result;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass23_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _X19UpsmsCheckButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__X19UpsmsCheckButton_Click_b__0_d _X19UpsmsCheckButton_Click_b__0_d = default(__X19UpsmsCheckButton_Click_b__0_d);
			_X19UpsmsCheckButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_X19UpsmsCheckButton_Click_b__0_d.__4__this = this;
			_X19UpsmsCheckButton_Click_b__0_d.__1__state = -1;
			_X19UpsmsCheckButton_Click_b__0_d.__t__builder.Start<__X19UpsmsCheckButton_Click_b__0_d>(ref _X19UpsmsCheckButton_Click_b__0_d);
			return _X19UpsmsCheckButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OnNavigatedTo_d__10_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

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
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					x19LoginPage.__n__0(e);
					_u__ = AppShell.RunAsync(x19LoginPage.RefreshGeneratedAccountHistoryAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__10_1>(ref _u__, ref this);
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
	private struct _RefreshGeneratedAccountHistoryAsync_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private TaskAwaiter<MlZUkZfPjYZrm0aLx9iF> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				if (num != 0)
				{
					((Control)x19LoginPage.X19AccountHistoryList).IsEnabled = false;
					((Control)x19LoginPage.X19ClearAccountHistoryButton).IsEnabled = false;
				}
				try
				{
					TaskAwaiter<MlZUkZfPjYZrm0aLx9iF> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.ear0hYd3w1().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MlZUkZfPjYZrm0aLx9iF>, _RefreshGeneratedAccountHistoryAsync_d__24>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<MlZUkZfPjYZrm0aLx9iF>);
						num = (__1__state = -1);
					}
					MlZUkZfPjYZrm0aLx9iF result = _u__.GetResult();
					((Collection<G87XFJfPfhylQ4RC1HmY>)(object)x19LoginPage.GeneratedAccountHistory).Clear();
					var enumerator = result.Accounts.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							G87XFJfPfhylQ4RC1HmY current = enumerator.Current;
							((Collection<G87XFJfPfhylQ4RC1HmY>)(object)x19LoginPage.GeneratedAccountHistory).Add(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RefreshGeneratedAccountHistoryAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\X19LoginPage.xaml.cs", 352);
					AppShell.Error("无法加载账号记录：" + ex.Message);
				}
				finally
				{
					if (num < 0)
					{
						((Control)x19LoginPage.X19AccountHistoryList).IsEnabled = true;
						x19LoginPage.UpdateAccountHistoryState();
					}
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
	private struct _SaveGeneratedAccountAsync_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		public string sauthJson;

		private TaskAwaiter<GHhtABfPkamWkVwisi16> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				string account = default(string);
				string password = default(string);
				string loginMode = default(string);
				if (num != 0)
				{
					account = x19LoginPage.X19AccountBox.Text.Trim();
					password = x19LoginPage.X19PasswordBox.Password;
					loginMode = x19LoginPage._loginMode switch
					{
						NeteaseLoginMode.PhonePassword => "phone-password", 
						NeteaseLoginMode.PhoneSms => "phone-sms", 
						_ => "email-password", 
					};
				}
				try
				{
					TaskAwaiter<GHhtABfPkamWkVwisi16> _u__ = default;
					if (num != 0)
					{
						ONqw1ofP95psXgbRXRlF val = new ONqw1ofP95psXgbRXRlF
						{
							Account = account,
							Password = password,
							SauthJson = sauthJson,
							LoginMode = loginMode
						};
						_u__ = AppShell.Api.qZ20UTMODo(val).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GHhtABfPkamWkVwisi16>, _SaveGeneratedAccountAsync_d__26>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<GHhtABfPkamWkVwisi16>);
						num = (__1__state = -1);
					}
					GHhtABfPkamWkVwisi16 result = _u__.GetResult();
					x19LoginPage.AppendSavedAccountRecord(result.Account);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SaveGeneratedAccountAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\X19LoginPage.xaml.cs", 396);
					AppShell.Error("账号记录保存失败：" + ex.Message);
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
	private struct _X19ClearAccountHistoryButton_Click_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

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
			X19LoginPage __8_locals2 = __4__this;
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
				if (((Collection<G87XFJfPfhylQ4RC1HmY>)(object)__8_locals2.GeneratedAccountHistory).Count != 0)
				{
					_u__ = AppShell.ConfirmAsync("清空账号记录", "将删除当前保存的全部网易账号、密码和 SAUTH。", "清空").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _X19ClearAccountHistoryButton_Click_d__31>(ref _u__, ref this);
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
					_u__2 = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__X19ClearAccountHistoryButton_Click_b__31_0_d _X19ClearAccountHistoryButton_Click_b__31_0_d = default(__X19ClearAccountHistoryButton_Click_b__31_0_d);
						_X19ClearAccountHistoryButton_Click_b__31_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_X19ClearAccountHistoryButton_Click_b__31_0_d.__4__this = __8_locals2;
						_X19ClearAccountHistoryButton_Click_b__31_0_d.__1__state = -1;
						_X19ClearAccountHistoryButton_Click_b__31_0_d.__t__builder.Start<__X19ClearAccountHistoryButton_Click_b__31_0_d>(ref _X19ClearAccountHistoryButton_Click_b__31_0_d);
						return _X19ClearAccountHistoryButton_Click_b__31_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _X19ClearAccountHistoryButton_Click_d__31>(ref _u__2, ref this);
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
	private struct _X19LoginButton_Click_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private __c__DisplayClass13_0_1 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0148;
				}
				__8__1 = (__c__DisplayClass13_0_1)new __c__DisplayClass13_0_1();
				__8__1.__4__this = __4__this;
				__8__1.account = x19LoginPage.X19AccountBox.Text.Trim();
				__8__1.password = x19LoginPage.X19PasswordBox.Password;
				if (!string.IsNullOrWhiteSpace(__8__1.account) && !string.IsNullOrEmpty(__8__1.password))
				{
					x19LoginPage.ResetVerifyState();
					x19LoginPage.X19ResultBox.Text = string.Empty;
					((Control)x19LoginPage.X19CopyResultButton).IsEnabled = false;
					__8__1.result = null;
					_u__ = AppShell.RunAsync(__8__1._X19LoginButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _X19LoginButton_Click_d__13>(ref _u__, ref this);
						return;
					}
					goto IL_0148;
				}
				AppShell.Error((x19LoginPage._loginMode == NeteaseLoginMode.PhonePassword) ? "请输入手机号和密码" : "请输入邮箱和密码");
				goto end_IL_0011;
				IL_0148:
				_u__.GetResult();
				if (__8__1.result != null)
				{
					x19LoginPage.ApplyResult(__8__1.result);
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
	private struct _X19SendLoginSmsButton_Click_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private __c__DisplayClass14_0_3 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00e5;
				}
				__8__1 = (__c__DisplayClass14_0_3)new __c__DisplayClass14_0_3();
				__8__1.__4__this = __4__this;
				__8__1.phone = x19LoginPage.X19AccountBox.Text.Trim();
				if (p7aMTy5CiDjPcd5Qwt6.L0h5qD8l7r(__8__1.phone))
				{
					__8__1.result = null;
					_u__ = AppShell.RunAsync(__8__1._X19SendLoginSmsButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _X19SendLoginSmsButton_Click_d__14>(ref _u__, ref this);
						return;
					}
					goto IL_00e5;
				}
				AppShell.Error("请输入有效手机号");
				goto end_IL_0011;
				IL_00e5:
				_u__.GetResult();
				if (__8__1.result != null)
				{
					x19LoginPage.X19StatusText.Text = __8__1.result.Message;
					if (__8__1.result.Success)
					{
						AppShell.Success(__8__1.result.Message);
						((UIElement)x19LoginPage.X19LoginSmsCodeBox).Focus((FocusState)3);
					}
					else
					{
						AppShell.Error(__8__1.result.Message);
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
	private struct _X19SendSmsButton_Click_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private __c__DisplayClass16_0_1 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00c5;
				}
				__8__1 = (__c__DisplayClass16_0_1)new __c__DisplayClass16_0_1();
				__8__1.__4__this = __4__this;
				if (!string.IsNullOrEmpty(x19LoginPage._x19Ticket))
				{
					__8__1.result = null;
					_u__ = AppShell.RunAsync(__8__1._X19SendSmsButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _X19SendSmsButton_Click_d__16>(ref _u__, ref this);
						return;
					}
					goto IL_00c5;
				}
				AppShell.Error("当前没有待验证的安全会话，请重新登录");
				goto end_IL_0011;
				IL_00c5:
				_u__.GetResult();
				if (__8__1.result != null)
				{
					x19LoginPage.ApplyResult(__8__1.result);
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
	private struct _X19SubmitLoginSmsButton_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private __c__DisplayClass15_0_4 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0131;
				}
				__8__1 = (__c__DisplayClass15_0_4)new __c__DisplayClass15_0_4();
				__8__1.__4__this = __4__this;
				__8__1.phone = x19LoginPage.X19AccountBox.Text.Trim();
				__8__1.code = x19LoginPage.X19LoginSmsCodeBox.Text.Trim();
				if (p7aMTy5CiDjPcd5Qwt6.L0h5qD8l7r(__8__1.phone) && __8__1.code.Length != 0)
				{
					x19LoginPage.X19ResultBox.Text = string.Empty;
					((Control)x19LoginPage.X19CopyResultButton).IsEnabled = false;
					__8__1.result = null;
					_u__ = AppShell.RunAsync(__8__1._X19SubmitLoginSmsButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _X19SubmitLoginSmsButton_Click_d__15>(ref _u__, ref this);
						return;
					}
					goto IL_0131;
				}
				AppShell.Error("请输入有效手机号和短信验证码");
				goto end_IL_0011;
				IL_0131:
				_u__.GetResult();
				if (__8__1.result != null)
				{
					x19LoginPage.ApplyResult(__8__1.result);
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
	private struct _X19SubmitSmsButton_Click_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private __c__DisplayClass17_0_2 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0104;
				}
				__8__1 = (__c__DisplayClass17_0_2)new __c__DisplayClass17_0_2();
				__8__1.__4__this = __4__this;
				if (string.IsNullOrEmpty(x19LoginPage._x19Ticket))
				{
					AppShell.Error("当前没有待验证的安全会话，请重新登录");
				}
				else
				{
					__8__1.code = x19LoginPage.X19SmsCodeBox.Text.Trim();
					if (!string.IsNullOrWhiteSpace(__8__1.code))
					{
						__8__1.result = null;
						_u__ = AppShell.RunAsync(__8__1._X19SubmitSmsButton_Click_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _X19SubmitSmsButton_Click_d__17>(ref _u__, ref this);
							return;
						}
						goto IL_0104;
					}
					AppShell.Error("请输入短信验证码");
				}
				goto end_IL_0011;
				IL_0104:
				_u__.GetResult();
				if (__8__1.result != null)
				{
					x19LoginPage.ApplyResult(__8__1.result);
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
	private struct _X19UpsmsCheckButton_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public X19LoginPage __4__this;

		private __c__DisplayClass23_0_2 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			X19LoginPage x19LoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00c5;
				}
				__8__1 = (__c__DisplayClass23_0_2)new __c__DisplayClass23_0_2();
				__8__1.__4__this = __4__this;
				if (!string.IsNullOrEmpty(x19LoginPage._x19Ticket))
				{
					__8__1.result = null;
					_u__ = AppShell.RunAsync(__8__1._X19UpsmsCheckButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _X19UpsmsCheckButton_Click_d__23>(ref _u__, ref this);
						return;
					}
					goto IL_00c5;
				}
				AppShell.Error("当前没有待验证的安全会话，请重新登录");
				goto end_IL_0011;
				IL_00c5:
				_u__.GetResult();
				if (__8__1.result != null)
				{
					x19LoginPage.ApplyResult(__8__1.result);
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

	private readonly p7aMTy5CiDjPcd5Qwt6 _x19Service;

	private string _x19Ticket;

	private bool _upsmsMode;

	private string _upsmsContent;

	private string _upsmsNumber;

	private NeteaseLoginMode _loginMode;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox X19ResultBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19CopyResultButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBar X19LoginModeSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel X19AccountFormPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel X19AccountHistoryPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView X19AccountHistoryList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border X19AccountHistoryEmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19ClearAccountHistoryButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock X19AccountHistoryCountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock X19AccountTitleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox X19AccountBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox X19PasswordBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19LoginButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel X19MobileSmsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock X19StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border X19VerifyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel X19UpsmsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel X19SmsCodePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19SubmitSmsButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox X19SmsCodeBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19SendSmsButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock X19UpsmsIntroText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19UpsmsCheckButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock X19UpsmsCodeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock X19UpsmsBackupText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock X19UpsmsNumberText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19UpsmsCopyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19SubmitLoginSmsButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox X19LoginSmsCodeBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button X19SendLoginSmsButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IX19LoginPage_Bindings Bindings;

	[field: CompilerGenerated]
	private ObservableCollection<G87XFJfPfhylQ4RC1HmY> _GeneratedAccountHistory_k__BackingField;

	public ObservableCollection<G87XFJfPfhylQ4RC1HmY> GeneratedAccountHistory
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public X19LoginPage()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		_x19Service = new p7aMTy5CiDjPcd5Qwt6();
		_x19Ticket = string.Empty;
		_upsmsContent = string.Empty;
		_upsmsNumber = string.Empty;
		_GeneratedAccountHistory_k__BackingField = new ObservableCollection<G87XFJfPfhylQ4RC1HmY>();
		InitializeComponent();
		AppShell.RegisterDisposable((global::System.IDisposable)_x19Service);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__10_1 onNavigatedTo_d__10_ = default(_OnNavigatedTo_d__10_1);
		onNavigatedTo_d__10_.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__10_.__4__this = this;
		onNavigatedTo_d__10_.e = e;
		onNavigatedTo_d__10_.__1__state = -1;
		onNavigatedTo_d__10_.__t__builder.Start<_OnNavigatedTo_d__10_1>(ref onNavigatedTo_d__10_);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		ResetVerifyState();
		X19ResultBox.Text = string.Empty;
		X19StatusText.Text = string.Empty;
		X19PasswordBox.Password = string.Empty;
		X19LoginSmsCodeBox.Text = string.Empty;
		((Control)X19CopyResultButton).IsEnabled = false;
		((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).Clear();
		UpdateAccountHistoryState();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19LoginModeSelector_SelectionChanged(SelectorBar sender, SelectorBarSelectionChangedEventArgs args)
	{
		SelectorBarItem selectedItem = sender.SelectedItem;
		if (selectedItem == null)
		{
			return;
		}
		string text = ((FrameworkElement)selectedItem).Tag?.ToString();
		bool flag = text == "history";
		if (X19AccountFormPanel != null)
		{
			((UIElement)X19AccountFormPanel).Visibility = (flag) ? Visibility.Visible : Visibility.Collapsed;
		}
		if (X19AccountHistoryPanel != null)
		{
			((UIElement)X19AccountHistoryPanel).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		}
		if (!flag)
		{
			NeteaseLoginMode loginMode = ((text == "phone-password") ? NeteaseLoginMode.PhonePassword : ((text == "phone-sms") ? NeteaseLoginMode.PhoneSms : NeteaseLoginMode.EmailPassword));
			_loginMode = loginMode;
			bool flag2 = _loginMode != NeteaseLoginMode.EmailPassword;
			bool flag3 = _loginMode == NeteaseLoginMode.PhoneSms;
			if (X19AccountTitleText != null)
			{
				X19AccountTitleText.Text = (flag2 ? "输入网易手机号" : "输入网易邮箱账号");
			}
			if (X19AccountBox != null)
			{
				X19AccountBox.Header = (flag2 ? "手机号" : "邮箱");
				X19AccountBox.PlaceholderText = (flag2 ? "11 位手机号" : "example@163.com");
				X19AccountBox.Text = string.Empty;
			}
			if (X19PasswordBox != null)
			{
				((UIElement)X19PasswordBox).Visibility = (flag3) ? Visibility.Visible : Visibility.Collapsed;
				X19PasswordBox.Password = string.Empty;
			}
			if (X19LoginButton != null)
			{
				((UIElement)X19LoginButton).Visibility = (flag3) ? Visibility.Visible : Visibility.Collapsed;
				((ContentControl)X19LoginButton).Content = ((_loginMode == NeteaseLoginMode.PhonePassword) ? "使用手机号密码生成 SAuth" : "使用邮箱密码生成 SAuth");
			}
			if (X19MobileSmsPanel != null)
			{
				((UIElement)X19MobileSmsPanel).Visibility = ((!flag3) ? Visibility.Visible : Visibility.Collapsed);
			}
			if (X19LoginSmsCodeBox != null)
			{
				X19LoginSmsCodeBox.Text = string.Empty;
			}
			if (X19StatusText != null)
			{
				X19StatusText.Text = string.Empty;
			}
			ResetVerifyState();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void X19LoginButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_X19LoginButton_Click_d__13 x19LoginButton_Click_d__ = default(_X19LoginButton_Click_d__13);
		x19LoginButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		x19LoginButton_Click_d__.__4__this = this;
		x19LoginButton_Click_d__.__1__state = -1;
		x19LoginButton_Click_d__.__t__builder.Start<_X19LoginButton_Click_d__13>(ref x19LoginButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void X19SendLoginSmsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_X19SendLoginSmsButton_Click_d__14 x19SendLoginSmsButton_Click_d__ = default(_X19SendLoginSmsButton_Click_d__14);
		x19SendLoginSmsButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		x19SendLoginSmsButton_Click_d__.__4__this = this;
		x19SendLoginSmsButton_Click_d__.__1__state = -1;
		x19SendLoginSmsButton_Click_d__.__t__builder.Start<_X19SendLoginSmsButton_Click_d__14>(ref x19SendLoginSmsButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void X19SubmitLoginSmsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_X19SubmitLoginSmsButton_Click_d__15 x19SubmitLoginSmsButton_Click_d__ = default(_X19SubmitLoginSmsButton_Click_d__15);
		x19SubmitLoginSmsButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		x19SubmitLoginSmsButton_Click_d__.__4__this = this;
		x19SubmitLoginSmsButton_Click_d__.__1__state = -1;
		x19SubmitLoginSmsButton_Click_d__.__t__builder.Start<_X19SubmitLoginSmsButton_Click_d__15>(ref x19SubmitLoginSmsButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void X19SendSmsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_X19SendSmsButton_Click_d__16 x19SendSmsButton_Click_d__ = default(_X19SendSmsButton_Click_d__16);
		x19SendSmsButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		x19SendSmsButton_Click_d__.__4__this = this;
		x19SendSmsButton_Click_d__.__1__state = -1;
		x19SendSmsButton_Click_d__.__t__builder.Start<_X19SendSmsButton_Click_d__16>(ref x19SendSmsButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void X19SubmitSmsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_X19SubmitSmsButton_Click_d__17 x19SubmitSmsButton_Click_d__ = default(_X19SubmitSmsButton_Click_d__17);
		x19SubmitSmsButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		x19SubmitSmsButton_Click_d__.__4__this = this;
		x19SubmitSmsButton_Click_d__.__1__state = -1;
		x19SubmitSmsButton_Click_d__.__t__builder.Start<_X19SubmitSmsButton_Click_d__17>(ref x19SubmitSmsButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19CopyResultButton_Click(object sender, RoutedEventArgs e)
	{
		string text = X19ResultBox.Text;
		if (!string.IsNullOrEmpty(text))
		{
			UiHelpers.CopyToClipboard(text);
			AppShell.Success("SAuth 已复制，请到基岩版启动页面粘贴");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19GoToBedrockButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("bedrock_account"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyResult(t30hHHfP8gMStFdbd6rB result)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		y6pelrfPcMaoKw9oseWu status = result.Status;
		if ((int)status != 0)
		{
			if ((int)status == 1)
			{
				_x19Ticket = result.Ticket ?? string.Empty;
				_upsmsMode = !result.CanSms;
				_upsmsContent = result.UpsmsContent ?? string.Empty;
				_upsmsNumber = result.UpsmsNumber ?? string.Empty;
				((UIElement)X19UpsmsPanel).Visibility = ((!_upsmsMode) ? Visibility.Visible : Visibility.Collapsed);
				((UIElement)X19SmsCodePanel).Visibility = (_upsmsMode) ? Visibility.Visible : Visibility.Collapsed;
				if (_upsmsMode)
				{
					X19UpsmsIntroText.Text = result.Message;
					X19UpsmsCodeText.Text = _upsmsContent;
					X19UpsmsNumberText.Text = _upsmsNumber;
					X19UpsmsBackupText.Text = (string.IsNullOrEmpty(result.UpsmsBackupNumber) ? string.Empty : ("备用号码：" + result.UpsmsBackupNumber));
					((UIElement)X19UpsmsBackupText).Visibility = (string.IsNullOrEmpty(result.UpsmsBackupNumber)) ? Visibility.Visible : Visibility.Collapsed;
				}
				((UIElement)X19VerifyPanel).Visibility = (Visibility)0;
				X19StatusText.Text = result.Message;
				AppShell.Warning(result.Message);
			}
			else
			{
				X19StatusText.Text = result.Message;
				AppShell.Error(result.Message);
			}
		}
		else
		{
			ResetVerifyState();
			X19ResultBox.Text = result.SauthJson ?? string.Empty;
			((Control)X19CopyResultButton).IsEnabled = !string.IsNullOrEmpty(result.SauthJson);
			X19StatusText.Text = result.Message;
			AppShell.Success(result.Message);
			if (!string.IsNullOrEmpty(result.SauthJson))
			{
				SaveGeneratedAccountAsync(result.SauthJson);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetVerifyState()
	{
		_x19Ticket = string.Empty;
		_upsmsMode = false;
		_upsmsContent = string.Empty;
		_upsmsNumber = string.Empty;
		((UIElement)X19VerifyPanel).Visibility = (Visibility)1;
		((UIElement)X19UpsmsPanel).Visibility = (Visibility)1;
		((UIElement)X19SmsCodePanel).Visibility = (Visibility)0;
		X19SmsCodeBox.Text = string.Empty;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19UpsmsCopyButton_Click(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrEmpty(_upsmsContent) && !string.IsNullOrEmpty(_upsmsNumber))
		{
			UiHelpers.CopyToClipboard("收件号码：" + _upsmsNumber + "\n短信内容：" + _upsmsContent);
			AppShell.Success("号码与验证内容已复制，请到手机短信中发送");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void X19UpsmsCheckButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_X19UpsmsCheckButton_Click_d__23 x19UpsmsCheckButton_Click_d__ = default(_X19UpsmsCheckButton_Click_d__23);
		x19UpsmsCheckButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		x19UpsmsCheckButton_Click_d__.__4__this = this;
		x19UpsmsCheckButton_Click_d__.__1__state = -1;
		x19UpsmsCheckButton_Click_d__.__t__builder.Start<_X19UpsmsCheckButton_Click_d__23>(ref x19UpsmsCheckButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshGeneratedAccountHistoryAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshGeneratedAccountHistoryAsync_d__24 refreshGeneratedAccountHistoryAsync_d__ = default(_RefreshGeneratedAccountHistoryAsync_d__24);
		refreshGeneratedAccountHistoryAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshGeneratedAccountHistoryAsync_d__.__4__this = this;
		refreshGeneratedAccountHistoryAsync_d__.__1__state = -1;
		refreshGeneratedAccountHistoryAsync_d__.__t__builder.Start<_RefreshGeneratedAccountHistoryAsync_d__24>(ref refreshGeneratedAccountHistoryAsync_d__);
		return refreshGeneratedAccountHistoryAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateAccountHistoryState()
	{
		bool flag = ((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).Count > 0;
		X19AccountHistoryCountText.Text = $"{((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).Count} 条";
		((UIElement)X19AccountHistoryList).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)X19AccountHistoryEmptyState).Visibility = (flag) ? Visibility.Visible : Visibility.Collapsed;
		((Control)X19ClearAccountHistoryButton).IsEnabled = flag;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SaveGeneratedAccountAsync(string sauthJson)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SaveGeneratedAccountAsync_d__26 saveGeneratedAccountAsync_d__ = default(_SaveGeneratedAccountAsync_d__26);
		saveGeneratedAccountAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		saveGeneratedAccountAsync_d__.__4__this = this;
		saveGeneratedAccountAsync_d__.sauthJson = sauthJson;
		saveGeneratedAccountAsync_d__.__1__state = -1;
		saveGeneratedAccountAsync_d__.__t__builder.Start<_SaveGeneratedAccountAsync_d__26>(ref saveGeneratedAccountAsync_d__);
		return saveGeneratedAccountAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AppendSavedAccountRecord(G87XFJfPfhylQ4RC1HmY record)
	{
		for (int num = ((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).Count - 1; num >= 0; num--)
		{
			if (((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory)[num].Id == record.Id || string.Equals(((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory)[num].Account, record.Account, (StringComparison)5))
			{
				((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).RemoveAt(num);
			}
		}
		((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).Insert(0, record);
		while (((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).Count > 100)
		{
			((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).RemoveAt(((Collection<G87XFJfPfhylQ4RC1HmY>)(object)GeneratedAccountHistory).Count - 1);
		}
		UpdateAccountHistoryState();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19AccountHistoryList_ItemClick(object sender, ItemClickEventArgs e)
	{
		object clickedItem = e.ClickedItem;
		G87XFJfPfhylQ4RC1HmY val = (G87XFJfPfhylQ4RC1HmY)((clickedItem is G87XFJfPfhylQ4RC1HmY) ? clickedItem : null);
		if (val != null)
		{
			if (val.HasSauth)
			{
				X19ResultBox.Text = val.SauthJson;
				((Control)X19CopyResultButton).IsEnabled = true;
				AppShell.Success("已载入选中的账号 SAUTH");
			}
			else
			{
				AppShell.Warning("该账号尚未生成 SAUTH");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19LoadSavedSauthButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val == null)
		{
			return;
		}
		object dataContext = ((FrameworkElement)val).DataContext;
		G87XFJfPfhylQ4RC1HmY val2 = (G87XFJfPfhylQ4RC1HmY)((dataContext is G87XFJfPfhylQ4RC1HmY) ? dataContext : null);
		if (val2 != null)
		{
			if (val2.HasSauth)
			{
				X19ResultBox.Text = val2.SauthJson;
				((Control)X19CopyResultButton).IsEnabled = true;
				AppShell.Success("已载入选中的账号 SAUTH");
			}
			else
			{
				AppShell.Warning("该账号尚未生成 SAUTH");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void X19CopySavedAccountButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null)
		{
			object dataContext = ((FrameworkElement)val).DataContext;
			G87XFJfPfhylQ4RC1HmY val2 = (G87XFJfPfhylQ4RC1HmY)((dataContext is G87XFJfPfhylQ4RC1HmY) ? dataContext : null);
			if (val2 != null)
			{
				UiHelpers.CopyToClipboard(val2.CopyText);
				AppShell.Success("账号和密码已复制");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void X19ClearAccountHistoryButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_X19ClearAccountHistoryButton_Click_d__31 x19ClearAccountHistoryButton_Click_d__ = default(_X19ClearAccountHistoryButton_Click_d__31);
		x19ClearAccountHistoryButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		x19ClearAccountHistoryButton_Click_d__.__4__this = this;
		x19ClearAccountHistoryButton_Click_d__.__1__state = -1;
		x19ClearAccountHistoryButton_Click_d__.__t__builder.Start<_X19ClearAccountHistoryButton_Click_d__31>(ref x19ClearAccountHistoryButton_Click_d__);
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
			Uri val = new Uri("ms-appx:///Views/Pages/X19LoginPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			X19ResultBox = CastExtensions.As<TextBox>(target);
			break;
		case 3:
			X19CopyResultButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19CopyResultButton).Click += new RoutedEventHandler(X19CopyResultButton_Click);
			break;
		case 4:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(X19GoToBedrockButton_Click);
			break;
		case 5:
			X19LoginModeSelector = CastExtensions.As<SelectorBar>(target);
			X19LoginModeSelector.SelectionChanged += X19LoginModeSelector_SelectionChanged;
			break;
		case 6:
			X19AccountFormPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 7:
			X19AccountHistoryPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 8:
			X19AccountHistoryList = CastExtensions.As<ListView>(target);
			((ListViewBase)X19AccountHistoryList).ItemClick += new ItemClickEventHandler(X19AccountHistoryList_ItemClick);
			break;
		case 9:
			X19AccountHistoryEmptyState = CastExtensions.As<Border>(target);
			break;
		case 12:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(X19LoadSavedSauthButton_Click);
			break;
		case 13:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(X19CopySavedAccountButton_Click);
			break;
		case 18:
			X19ClearAccountHistoryButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19ClearAccountHistoryButton).Click += new RoutedEventHandler(X19ClearAccountHistoryButton_Click);
			break;
		case 19:
			X19AccountHistoryCountText = CastExtensions.As<TextBlock>(target);
			break;
		case 20:
			X19AccountTitleText = CastExtensions.As<TextBlock>(target);
			break;
		case 21:
			X19AccountBox = CastExtensions.As<TextBox>(target);
			break;
		case 22:
			X19PasswordBox = CastExtensions.As<PasswordBox>(target);
			break;
		case 23:
			X19LoginButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19LoginButton).Click += new RoutedEventHandler(X19LoginButton_Click);
			break;
		case 24:
			X19MobileSmsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 25:
			X19StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 26:
			X19VerifyPanel = CastExtensions.As<Border>(target);
			break;
		case 27:
			X19UpsmsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 28:
			X19SmsCodePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 29:
			X19SubmitSmsButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19SubmitSmsButton).Click += new RoutedEventHandler(X19SubmitSmsButton_Click);
			break;
		case 30:
			X19SmsCodeBox = CastExtensions.As<TextBox>(target);
			break;
		case 31:
			X19SendSmsButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19SendSmsButton).Click += new RoutedEventHandler(X19SendSmsButton_Click);
			break;
		case 32:
			X19UpsmsIntroText = CastExtensions.As<TextBlock>(target);
			break;
		case 33:
			X19UpsmsCheckButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19UpsmsCheckButton).Click += new RoutedEventHandler(X19UpsmsCheckButton_Click);
			break;
		case 34:
			X19UpsmsCodeText = CastExtensions.As<TextBlock>(target);
			break;
		case 35:
			X19UpsmsBackupText = CastExtensions.As<TextBlock>(target);
			break;
		case 36:
			X19UpsmsNumberText = CastExtensions.As<TextBlock>(target);
			break;
		case 37:
			X19UpsmsCopyButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19UpsmsCopyButton).Click += new RoutedEventHandler(X19UpsmsCopyButton_Click);
			break;
		case 38:
			X19SubmitLoginSmsButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19SubmitLoginSmsButton).Click += new RoutedEventHandler(X19SubmitLoginSmsButton_Click);
			break;
		case 39:
			X19LoginSmsCodeBox = CastExtensions.As<TextBox>(target);
			break;
		case 40:
			X19SendLoginSmsButton = CastExtensions.As<Button>(target);
			((ButtonBase)X19SendLoginSmsButton).Click += new RoutedEventHandler(X19SendLoginSmsButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 1:
		{
			Page val2 = (Page)target;
			X19LoginPage_obj1_Bindings x19LoginPage_obj1_Bindings = (X19LoginPage_obj1_Bindings)new X19LoginPage_obj1_Bindings();
			result = (IComponentConnector)(object)x19LoginPage_obj1_Bindings;
			x19LoginPage_obj1_Bindings.SetDataRoot(this);
			Bindings = x19LoginPage_obj1_Bindings;
			((FrameworkElement)val2).Loading += x19LoginPage_obj1_Bindings.Loading;
			break;
		}
		case 11:
		{
			Border val = (Border)target;
			X19LoginPage_obj11_Bindings x19LoginPage_obj11_Bindings = (X19LoginPage_obj11_Bindings)new X19LoginPage_obj11_Bindings();
			result = (IComponentConnector)(object)x19LoginPage_obj11_Bindings;
			x19LoginPage_obj11_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += x19LoginPage_obj11_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)x19LoginPage_obj11_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)x19LoginPage_obj11_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__9_0(object _, RoutedEventArgs _2)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	[CompilerGenerated]
	private void __n__0(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _X19ClearAccountHistoryButton_Click_b__31_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__X19ClearAccountHistoryButton_Click_b__31_0_d _X19ClearAccountHistoryButton_Click_b__31_0_d = default(__X19ClearAccountHistoryButton_Click_b__31_0_d);
		_X19ClearAccountHistoryButton_Click_b__31_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_X19ClearAccountHistoryButton_Click_b__31_0_d.__4__this = this;
		_X19ClearAccountHistoryButton_Click_b__31_0_d.__1__state = -1;
		_X19ClearAccountHistoryButton_Click_b__31_0_d.__t__builder.Start<__X19ClearAccountHistoryButton_Click_b__31_0_d>(ref _X19ClearAccountHistoryButton_Click_b__31_0_d);
		return _X19ClearAccountHistoryButton_Click_b__31_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

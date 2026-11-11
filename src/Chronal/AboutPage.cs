using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using EiAPRwJSDFvNotiSTTX;
using FdRq9UOmyfvNjvAvu1J;
using Mahiro_Account.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Vlsi7UfO9ch6W4RxaQqv;
using WinRT;
using WinRT.ChronalVtableClasses;
using jayVXsfeU04hSNk3ePPo;
using pDFcXyfOjGiubvpRL0gO;
using qS8vkpL43FlTMgcj0rgs;
using rt6nJFOgpDacgmTF8Ih;
using upxeYBfDKCIugOs5dAeA;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class AboutPage : Page, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_21
	{
		public static readonly __c_21 __9;

		public static Action __9__10_1;

		[MethodImpl((MethodImplOptions)8)]
		static __c_21()
		{
			__9 = (__c_21)new __c_21();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_21()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _CheckUpdateButton_Click_b__10_1()
		{
			Application.Current.Exit();
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass10_0_3
	{
		[StructLayout((LayoutKind)3)]
		private struct __CheckUpdateButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass10_0_3 __4__this;

			private TaskAwaiter<sJFvIGfehRs7r8TsV0mL> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass10_0_3 _c__DisplayClass10_0_ = __4__this;
				try
				{
					TaskAwaiter<sJFvIGfehRs7r8TsV0mL> _u__ = default;
					if (num != 0)
					{
						_u__ = YA7sBfOoI9bvBEcJtLN.hbvO7hTeS8(_c__DisplayClass10_0_.__4__this._updateCheckService, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sJFvIGfehRs7r8TsV0mL>, __CheckUpdateButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<sJFvIGfehRs7r8TsV0mL>);
						num = (__1__state = -1);
					}
					sJFvIGfehRs7r8TsV0mL result = _u__.GetResult();
					_c__DisplayClass10_0_.result = result;
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

		public AboutPage __4__this;

		public sJFvIGfehRs7r8TsV0mL result;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass10_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _CheckUpdateButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__CheckUpdateButton_Click_b__0_d _CheckUpdateButton_Click_b__0_d = default(__CheckUpdateButton_Click_b__0_d);
			_CheckUpdateButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_CheckUpdateButton_Click_b__0_d.__4__this = this;
			_CheckUpdateButton_Click_b__0_d.__1__state = -1;
			_CheckUpdateButton_Click_b__0_d.__t__builder.Start<__CheckUpdateButton_Click_b__0_d>(ref _CheckUpdateButton_Click_b__0_d);
			return _CheckUpdateButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass4_0_1
	{
		public string tag;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass4_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SelectByTag_b__0(ComboBoxItem item)
		{
			return string.Equals(((FrameworkElement)item).Tag?.ToString(), tag, (StringComparison)4);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0_7
	{
		[StructLayout((LayoutKind)3)]
		private struct __ChangelogButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass9_0_7 __4__this;

			private TaskAwaiter<PJWRpXfOZeOHKi4Pca4V> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass9_0_7 _c__DisplayClass9_0_ = __4__this;
				try
				{
					TaskAwaiter<PJWRpXfOZeOHKi4Pca4V> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass9_0_.__4__this._changelogService.xTXJcGhP0T(default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PJWRpXfOZeOHKi4Pca4V>, __ChangelogButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<PJWRpXfOZeOHKi4Pca4V>);
						num = (__1__state = -1);
					}
					PJWRpXfOZeOHKi4Pca4V result = _u__.GetResult();
					_c__DisplayClass9_0_.response = result;
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

		public AboutPage __4__this;

		public PJWRpXfOZeOHKi4Pca4V response;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0_7()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _ChangelogButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ChangelogButton_Click_b__0_d _ChangelogButton_Click_b__0_d = default(__ChangelogButton_Click_b__0_d);
			_ChangelogButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_ChangelogButton_Click_b__0_d.__4__this = this;
			_ChangelogButton_Click_b__0_d.__1__state = -1;
			_ChangelogButton_Click_b__0_d.__t__builder.Start<__ChangelogButton_Click_b__0_d>(ref _ChangelogButton_Click_b__0_d);
			return _ChangelogButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ChangelogButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AboutPage __4__this;

		private __c__DisplayClass9_0_7 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
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
						goto IL_015b;
					}
					__8__1 = (__c__DisplayClass9_0_7)new __c__DisplayClass9_0_7();
					__8__1.__4__this = __4__this;
					__8__1.response = null;
					_u__ = AppShell.RunAsync(__8__1._ChangelogButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ChangelogButton_Click_d__9>(ref _u__, ref this);
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
				if (__8__1.response != null)
				{
					if (__8__1.response.Entries.Count != 0)
					{
						_u__ = ChangelogDialog.ShowAsync(AppShell.XamlRoot, (global::System.Collections.Generic.IReadOnlyList<d2iiUHfOLr9ZvQq4WHMC>)__8__1.response.Entries, "更新日志").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ChangelogButton_Click_d__9>(ref _u__, ref this);
							return;
						}
						goto IL_015b;
					}
					AppShell.Info("暂无更新日志");
				}
				goto end_IL_000a;
				IL_015b:
				_u__.GetResult();
				end_IL_000a:;
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
	private struct _CheckUpdateButton_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AboutPage __4__this;

		private __c__DisplayClass10_0_3 __8__1;

		private TaskAwaiter __u__1;

		private TaskAwaiter<bool> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				TaskAwaiter _u__2 = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_0189;
					}
					__8__1 = (__c__DisplayClass10_0_3)new __c__DisplayClass10_0_3();
					__8__1.__4__this = __4__this;
					__8__1.result = null;
					_u__2 = AppShell.RunAsync(__8__1._CheckUpdateButton_Click_b__0).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CheckUpdateButton_Click_d__10>(ref _u__2, ref this);
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
				if (__8__1.result != null)
				{
					if (__8__1.result.IsUpdateAvailable)
					{
						XamlRoot? xamlRoot = AppShell.XamlRoot;
						sJFvIGfehRs7r8TsV0mL result = __8__1.result;
						object obj = __c_21.__9__10_1;
						if (obj == null)
						{
							Action val = __c_21.__9._CheckUpdateButton_Click_b__10_1;
							__c_21.__9__10_1 = val;
							obj = (object)val;
						}
						_u__ = AppUpdateFlow.ShowAsync(xamlRoot, result, mandatory: false, (Action)obj).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _CheckUpdateButton_Click_d__10>(ref _u__, ref this);
							return;
						}
						goto IL_0189;
					}
					AppShell.Success("已是最新版本（" + __8__1.result.LocalVersion + "）");
				}
				goto end_IL_000a;
				IL_0189:
				_u__.GetResult();
				end_IL_000a:;
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

	private readonly PrFs4fOBwUvdAORC617 _updateCheckService;

	private readonly qJZUC0JY3okUVxPyXoP _changelogService;

	private bool _appearanceInitialized;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AboutMachineHashText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch StatusHudDebugSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch AutoHideSidebarSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox BackgroundMaterialComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox ThemeColorComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ChangelogButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CheckUpdateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AboutVersionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public AboutPage()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		_updateCheckService = new PrFs4fOBwUvdAORC617();
		_changelogService = new qJZUC0JY3okUVxPyXoP();
		InitializeComponent();
		try
		{
			AboutVersionText.Text = "版本 " + PrFs4fOBwUvdAORC617.CfCOdBTIDC();
		}
		catch (global::System.Exception)
		{
			AboutVersionText.Text = "版本未知";
		}
		AboutMachineHashText.Text = (string.IsNullOrWhiteSpace(AppShell.Machine.Hash) ? "--" : AppShell.Machine.Hash);
		SelectByTag(ThemeColorComboBox, ((int)AppearanceSettings.Theme == 1) ? "light" : "dark");
		ComboBox backgroundMaterialComboBox = BackgroundMaterialComboBox;
		SelectByTag(backgroundMaterialComboBox, AppearanceSettings.Backdrop switch
		{
			AppBackdropKind.Solid => "solid", 
			AppBackdropKind.Acrylic => "acrylic", 
			_ => "mica", 
		});
		AutoHideSidebarSwitch.IsOn = AppearanceSettings.AutoHideSidebarForBedrock;
		StatusHudDebugSwitch.IsOn = XmZPH6fDdBx0Jhg6ql8p.StatusHudDebugEnabled;
		_appearanceInitialized = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void SelectByTag(ComboBox combo, string tag)
	{
		__c__DisplayClass4_0_1 __8_locals2 = (__c__DisplayClass4_0_1)new __c__DisplayClass4_0_1();
		__8_locals2.tag = tag;
		((Selector)combo).SelectedItem = Enumerable.FirstOrDefault<ComboBoxItem>(Enumerable.OfType<ComboBoxItem>((global::System.Collections.IEnumerable)((ItemsControl)combo).Items), (Func<ComboBoxItem, bool>)([MethodImpl((MethodImplOptions)8)] (ComboBoxItem item) => string.Equals(((FrameworkElement)item).Tag?.ToString(), __8_locals2.tag, (StringComparison)4))) ?? Enumerable.FirstOrDefault<ComboBoxItem>(Enumerable.OfType<ComboBoxItem>((global::System.Collections.IEnumerable)((ItemsControl)combo).Items));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AppearanceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (_appearanceInitialized)
		{
			object selectedItem = ((Selector)ThemeColorComboBox).SelectedItem;
			object obj = ((selectedItem is ComboBoxItem) ? selectedItem : null);
			ElementTheme theme = (ElementTheme)((((obj == null) ? null : ((FrameworkElement)obj).Tag?.ToString()) == "light") ? 1 : 2);
			object selectedItem2 = ((Selector)BackgroundMaterialComboBox).SelectedItem;
			object obj2 = ((selectedItem2 is ComboBoxItem) ? selectedItem2 : null);
			string text = ((obj2 == null) ? null : ((FrameworkElement)obj2).Tag?.ToString());
			AppBackdropKind appBackdropKind = ((text == "solid") ? AppBackdropKind.Solid : ((text == "acrylic") ? AppBackdropKind.Acrylic : AppBackdropKind.Mica));
			AppBackdropKind backdrop = appBackdropKind;
			AppearanceSettings.Update(theme, backdrop);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AutoHideSidebarSwitch_Toggled(object sender, RoutedEventArgs e)
	{
		if (_appearanceInitialized)
		{
			AppearanceSettings.SetAutoHideSidebarForBedrock(AutoHideSidebarSwitch.IsOn);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StatusHudDebugSwitch_Toggled(object sender, RoutedEventArgs e)
	{
		if (_appearanceInitialized)
		{
			XmZPH6fDdBx0Jhg6ql8p.StatusHudDebugEnabled = StatusHudDebugSwitch.IsOn;
			if (StatusHudDebugSwitch.IsOn)
			{
				AppShell.Info("游戏状态 HUD 调试已开启，后续启动游戏时将持续显示");
			}
			else
			{
				AppShell.Info("游戏状态 HUD 调试已关闭");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyMachineHashButton_Click(object sender, RoutedEventArgs e)
	{
		string hash = AppShell.Machine.Hash;
		if (!string.IsNullOrWhiteSpace(hash))
		{
			UiHelpers.CopyToClipboard(hash);
			AppShell.Info("机器码已复制");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChangelogButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChangelogButton_Click_d__9 changelogButton_Click_d__ = default(_ChangelogButton_Click_d__9);
		changelogButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		changelogButton_Click_d__.__4__this = this;
		changelogButton_Click_d__.__1__state = -1;
		changelogButton_Click_d__.__t__builder.Start<_ChangelogButton_Click_d__9>(ref changelogButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CheckUpdateButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CheckUpdateButton_Click_d__10 checkUpdateButton_Click_d__ = default(_CheckUpdateButton_Click_d__10);
		checkUpdateButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		checkUpdateButton_Click_d__.__4__this = this;
		checkUpdateButton_Click_d__.__1__state = -1;
		checkUpdateButton_Click_d__.__t__builder.Start<_CheckUpdateButton_Click_d__10>(ref checkUpdateButton_Click_d__);
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
			Uri val = new Uri("ms-appx:///Views/Pages/AboutPage.xaml");
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			AboutMachineHashText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CopyMachineHashButton_Click);
			break;
		case 4:
			StatusHudDebugSwitch = CastExtensions.As<ToggleSwitch>(target);
			StatusHudDebugSwitch.Toggled += new RoutedEventHandler(StatusHudDebugSwitch_Toggled);
			break;
		case 5:
			AutoHideSidebarSwitch = CastExtensions.As<ToggleSwitch>(target);
			AutoHideSidebarSwitch.Toggled += new RoutedEventHandler(AutoHideSidebarSwitch_Toggled);
			break;
		case 6:
			BackgroundMaterialComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)BackgroundMaterialComboBox).SelectionChanged += new SelectionChangedEventHandler(AppearanceComboBox_SelectionChanged);
			break;
		case 7:
			ThemeColorComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)ThemeColorComboBox).SelectionChanged += new SelectionChangedEventHandler(AppearanceComboBox_SelectionChanged);
			break;
		case 8:
			ChangelogButton = CastExtensions.As<Button>(target);
			((ButtonBase)ChangelogButton).Click += new RoutedEventHandler(ChangelogButton_Click);
			break;
		case 9:
			CheckUpdateButton = CastExtensions.As<Button>(target);
			((ButtonBase)CheckUpdateButton).Click += new RoutedEventHandler(CheckUpdateButton_Click);
			break;
		case 10:
			AboutVersionText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

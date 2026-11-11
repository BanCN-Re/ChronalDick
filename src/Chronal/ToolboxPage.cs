using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using LlvQkpftcKTPAsaRP0ff;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Controls.Toolbox;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.Storage.Pickers;
using Tvw078XBFRwnaL01RSPg;
using VFQxICfth84Lkoc3ch2l;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using cZMx3PflYFcP4cCHO7W5;
using i6TlJMfuChv2AjPXr7O8;
using mqSxymXxirA01jCDGieJ;
using qS8vkpL43FlTMgcj0rgs;
using upxeYBfDKCIugOs5dAeA;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class ToolboxPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IToolboxPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IToolboxPage_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class ToolboxPage_obj1_Bindings : IComponentConnector, IToolboxPage_Bindings
	{
		private ToolboxPage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ItemsControl obj23;

		[MethodImpl((MethodImplOptions)8)]
		public ToolboxPage_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 23)
			{
				obj23 = CastExtensions.As<ItemsControl>(target);
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
				dataRoot = CastExtensions.As<ToolboxPage>(newDataRoot);
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
		private void Update_(ToolboxPage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_AccountSwitchInstances(obj.AccountSwitchInstances, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AccountSwitchInstances(ObservableCollection<BedrockInstanceCardViewModel> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(obj23, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_20
	{
		public static readonly __c_20 __9;

		public static Func<zG6ueUfuQUk6CEmxLYji, bool> __9__8_0;

		public static Func<zG6ueUfuQUk6CEmxLYji, ValueTuple<int, DateTimeOffset>> __9__8_1;

		[MethodImpl((MethodImplOptions)8)]
		static __c_20()
		{
			__9 = (__c_20)new __c_20();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_20()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshAccountSwitchInstances_b__8_0(zG6ueUfuQUk6CEmxLYji instance)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Invalid comparison between Unknown and I4
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Invalid comparison between Unknown and I4
			if ((int)instance.Kind != 3)
			{
				return (int)instance.State == 0;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal ValueTuple<int, DateTimeOffset> _RefreshAccountSwitchInstances_b__8_1(zG6ueUfuQUk6CEmxLYji instance)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<int, DateTimeOffset>(instance.ProcessId, instance.StartedAt);
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass10_0_2
	{
		public zG6ueUfuQUk6CEmxLYji instance;

		public Func<BedrockInstanceCardViewModel, bool> __9__0;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass10_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SetAccountSwitchStatus_b__0(BedrockInstanceCardViewModel card)
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			zG6ueUfuQUk6CEmxLYji? obj = card.Instance;
			if (((obj != null) ? new int?(obj.ProcessId) : ((int?)null)) == instance.ProcessId)
			{
				return card.Instance.StartedAt == instance.StartedAt;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass28_0_1
	{
		public ToolboxPage __4__this;

		public dN4xMCftS2WHJlRJeqrU user;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass28_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _EnqueueToolboxPermissionsUpdate_g__Refresh_0()
		{
			if (__4__this._toolboxPermissionsLoaded)
			{
				__4__this.UpdateToolboxPermissions(user);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_5
	{
		public HashSet<ValueTuple<int, DateTimeOffset>> active;

		public Func<ValueTuple<int, DateTimeOffset>, bool> __9__2;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_5()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshAccountSwitchInstances_b__2(ValueTuple<int, DateTimeOffset> key)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			return !active.Contains(key);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ChooseResourceDecryptInputButton_Click_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ToolboxPage __4__this;

		private TaskAwaiter<string?> __u__1;

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
			ToolboxPage toolboxPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num != 0)
				{
					_u__ = DesktopFilePicker.PickOpenFileAsync(AppShell.WindowHandle, (PickerLocationId)3, new global::__z__ReadOnlySingleElementList_1<string>(".zip"), "选择加密资源 ZIP").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseResourceDecryptInputButton_Click_d__31>(ref _u__, ref this);
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
				if (result != null)
				{
					toolboxPage.ResourceDecryptInputPathTextBox.Text = result;
					if (string.IsNullOrWhiteSpace(toolboxPage.ResourceDecryptOutputPathTextBox.Text))
					{
						toolboxPage.ResourceDecryptOutputPathTextBox.Text = Path.Combine(Path.GetDirectoryName(result) ?? Environment.GetFolderPath((System.Environment.SpecialFolder)5), Path.GetFileNameWithoutExtension(result) + ".decrypted.zip");
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
	private struct _ChooseResourceDecryptOutputButton_Click_d__32 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ToolboxPage __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ToolboxPage toolboxPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num != 0)
				{
					string text = toolboxPage.ResourceDecryptInputPathTextBox.Text?.Trim();
					string suggestedFileName = (string.IsNullOrWhiteSpace(text) ? "decrypted-resources.zip" : (Path.GetFileNameWithoutExtension(text) + ".decrypted.zip"));
					_u__ = DesktopFilePicker.PickSaveFileAsync(AppShell.WindowHandle, (PickerLocationId)3, suggestedFileName, new global::__z__ReadOnlySingleElementList_1<DesktopFileTypeChoice>((DesktopFileTypeChoice)new DesktopFileTypeChoice("ZIP 压缩包", (global::System.Collections.Generic.IReadOnlyList<string>)new global::__z__ReadOnlySingleElementList_1<string>(".zip"))), "选择解密 ZIP 保存位置").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseResourceDecryptOutputButton_Click_d__32>(ref _u__, ref this);
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
				if (result != null)
				{
					toolboxPage.ResourceDecryptOutputPathTextBox.Text = result;
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
	private struct _DecryptResourceArchiveButton_Click_d__33 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ToolboxPage __4__this;

		private string _output_5__2;

		private CancellationTokenSource _cancellation_5__3;

		private TaskAwaiter<nQIdMjXxGGtHBfhuOHIF> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			int num = __1__state;
			ToolboxPage __8_locals20 = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0154;
				}
				string text = default(string);
				string[] array2 = default(string[]);
				if (__8_locals20._resourceDecryptCancellation == null)
				{
					text = __8_locals20.ResourceDecryptInputPathTextBox.Text?.Trim() ?? string.Empty;
					_output_5__2 = __8_locals20.ResourceDecryptOutputPathTextBox.Text?.Trim() ?? string.Empty;
					string obj = __8_locals20.ResourceDecryptItemIdsTextBox.Text ?? string.Empty;
					char[] array = new char[6];
					array2 = Enumerable.ToArray<string>(Enumerable.Distinct<string>((global::System.Collections.Generic.IEnumerable<string>)obj.Split(array, (StringSplitOptions)3), (IEqualityComparer<string>)(object)StringComparer.Ordinal));
					if (!File.Exists(text) || !string.Equals(Path.GetExtension(text), ".zip", (StringComparison)5))
					{
						AppShell.Warning("请选择有效的 ZIP 文件");
					}
					else if (array2.Length == 0 || array2.Length > 16)
					{
						AppShell.Warning("请输入 1 至 16 个网易资源 itemId");
					}
					else
					{
						if (!string.IsNullOrWhiteSpace(_output_5__2) && string.Equals(Path.GetExtension(_output_5__2), ".zip", (StringComparison)5))
						{
							_cancellation_5__3 = new CancellationTokenSource();
							goto IL_0154;
						}
						AppShell.Warning("请选择 ZIP 格式的输出位置");
					}
				}
				goto end_IL_0011;
				IL_0154:
					array2 = default;
					text = default;
				try
				{
					if (num != 0)
					{
						__8_locals20._resourceDecryptCancellation = _cancellation_5__3;
						((Control)__8_locals20.ResourceDecryptButton).IsEnabled = false;
						((Control)__8_locals20.CancelResourceDecryptButton).IsEnabled = true;
						__8_locals20.ResourceDecryptProgressRing.IsActive = true;
						((UIElement)__8_locals20.ResourceDecryptProgressRing).Visibility = (Visibility)0;
						__8_locals20.ResourceDecryptStatusText.Text = "正在准备解密";
					}
					try
					{
						TaskAwaiter<nQIdMjXxGGtHBfhuOHIF> _u__ = default;
						if (num != 0)
						{
							Progress<string> val = new Progress<string>((Action<string>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (string message) =>
							{
								__8_locals20.ResourceDecryptStatusText.Text = message;
							}));
							_u__ = da18CdX55laNMRKtM3p0.Shared.QsCXRIBkT60(text, _output_5__2, (global::System.Collections.Generic.IReadOnlyList<string>)array2, (IProgress<string>)(object)val, _cancellation_5__3.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<nQIdMjXxGGtHBfhuOHIF>, _DecryptResourceArchiveButton_Click_d__33>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<nQIdMjXxGGtHBfhuOHIF>);
							num = (__1__state = -1);
						}
						nQIdMjXxGGtHBfhuOHIF result = _u__.GetResult();
						__8_locals20.ResourceDecryptStatusText.Text = $"解密完成：{result.DecryptedFiles} 个文件，展开 {result.ExpandedArchives} 个内嵌资源包。输出：{_output_5__2}";
						AppShell.Success("自定义资源 ZIP 解密完成");
					}
					catch (OperationCanceledException)
					{
						__8_locals20.ResourceDecryptStatusText.Text = "解密已取消，未写入不完整的输出 ZIP";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "bedrock-custom-resource-decrypt", "DecryptResourceArchiveButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.ResourceDecrypt.cs", 96);
						__8_locals20.ResourceDecryptStatusText.Text = AppShell.GetExceptionDisplayMessage(ex2, "DecryptResourceArchiveButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.ResourceDecrypt.cs", 97);
						AppShell.Error(__8_locals20.ResourceDecryptStatusText.Text);
					}
					finally
					{
						if (num < 0)
						{
							__8_locals20._resourceDecryptCancellation = null;
							((Control)__8_locals20.ResourceDecryptButton).IsEnabled = true;
							((Control)__8_locals20.CancelResourceDecryptButton).IsEnabled = false;
							__8_locals20.ResourceDecryptProgressRing.IsActive = false;
							((UIElement)__8_locals20.ResourceDecryptProgressRing).Visibility = (Visibility)1;
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__3 != null)
					{
						((global::System.IDisposable)_cancellation_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_output_5__2 = null;
				_cancellation_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_output_5__2 = null;
			_cancellation_5__3 = null;
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
	private struct _InjectAccountSwitchButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public ToolboxPage __4__this;

		private zG6ueUfuQUk6CEmxLYji _instance_5__2;

		private TaskAwaiter<string> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ToolboxPage toolboxPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00b9;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null && ((ButtonBase)val).CommandParameter is BedrockInstanceCardViewModel { CanLoadOverlay: not false } bedrockInstanceCardViewModel)
				{
					_instance_5__2 = bedrockInstanceCardViewModel.Instance;
					if (_instance_5__2 != null)
					{
						ValueTuple<int, DateTimeOffset> val2 = default(ValueTuple<int, DateTimeOffset>);
						ValueTuple<bool, string> val3 = default(ValueTuple<bool, string>);
						if (!toolboxPage._accountSwitchStates.TryGetValue(val2, out val3) || !val3.Item1)
						{
							toolboxPage.SetAccountSwitchStatus(_instance_5__2, busy: true, "正在注入账户切换，请稍候…");
							goto IL_00b9;
						}
					}
				}
				goto end_IL_0011;
				IL_00b9:
				try
				{
					TaskAwaiter<string> _u__ = default;
					if (num != 0)
					{
						_u__ = qvn5b7flVgrc4ZZh8K4A.d6EflSe65OT(_instance_5__2, da18CdX55laNMRKtM3p0.Shared).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _InjectAccountSwitchButton_Click_d__9>(ref _u__, ref this);
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
					toolboxPage.SetAccountSwitchStatus(_instance_5__2, busy: false, result);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "InjectAccountSwitchButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.AccountSwitch.cs", 84);
					string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(ex, "InjectAccountSwitchButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.AccountSwitch.cs", 85);
					toolboxPage.SetAccountSwitchStatus(_instance_5__2, busy: false, exceptionDisplayMessage);
					AppShell.Error(exceptionDisplayMessage);
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_instance_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_instance_5__2 = null;
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

	private readonly Dictionary<ValueTuple<int, DateTimeOffset>, ValueTuple<bool, string>> _accountSwitchStates;

	private bool _accountSwitchLoaded;

	private bool _updatingBujiDaoPatchSwitches;

	private bool _updatingEaseCationDeviceSpoofer;

	private bool _toolboxPermissionsLoaded;

	private bool _canAccessHwidTools;

	private SelectorBarItem? _hwidCategoryItem;

	private CancellationTokenSource? _resourceDecryptCancellation;

	private bool _initialized;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ScrollViewer ToolboxScrollViewer;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel GameToolsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel HwidToolsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EaseCationToolsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel NetworkToolsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel ResourceToolsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel MaintenanceToolsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ResourceDecryptStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ResourceDecryptButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing ResourceDecryptProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelResourceDecryptButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ResourceDecryptOutputPathTextBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ResourceDecryptItemIdsTextBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ResourceDecryptInputPathTextBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch EaseCationDeviceSpooferSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ContentControl HwidToolsContent;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch BujiDaoDeviceSpoofSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch BujiDaoMcpPatchSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch BujiDaoAndroidTouchSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AccountSwitchEmptyText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBar ToolboxCategoryBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBarItem GameCategoryItem;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IToolboxPage_Bindings Bindings;

	private ObservableCollection<BedrockInstanceCardViewModel> _AccountSwitchInstances_k__BackingField;

	[field: CompilerGenerated]
	public ObservableCollection<BedrockInstanceCardViewModel> AccountSwitchInstances
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AccountSwitch_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		if (!_accountSwitchLoaded)
		{
			_accountSwitchLoaded = true;
			da18CdX55laNMRKtM3p0.Shared.InstancesChanged += new EventHandler(AccountSwitch_InstancesChanged);
			RefreshAccountSwitchInstances();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AccountSwitch_Unloaded(object sender, RoutedEventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		_accountSwitchLoaded = false;
		da18CdX55laNMRKtM3p0.Shared.InstancesChanged -= new EventHandler(AccountSwitch_InstancesChanged);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AccountSwitch_InstancesChanged(object? sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			RefreshAccountSwitchInstances();
		}
		else
		{
			((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(RefreshAccountSwitchInstances));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshAccountSwitchInstances()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (!_accountSwitchLoaded)
		{
			return;
		}
		try
		{
			__c__DisplayClass8_0_5 __8_locals2 = (__c__DisplayClass8_0_5)new __c__DisplayClass8_0_5();
			zG6ueUfuQUk6CEmxLYji[] array = Enumerable.ToArray<zG6ueUfuQUk6CEmxLYji>(Enumerable.Where<zG6ueUfuQUk6CEmxLYji>((global::System.Collections.Generic.IEnumerable<zG6ueUfuQUk6CEmxLYji>)da18CdX55laNMRKtM3p0.Shared.fqaX64xovpi(), (Func<zG6ueUfuQUk6CEmxLYji, bool>)([MethodImpl((MethodImplOptions)8)] (zG6ueUfuQUk6CEmxLYji instance) => (int)instance.Kind != 3 && (int)instance.State == 0)));
			((Collection<BedrockInstanceCardViewModel>)(object)AccountSwitchInstances).Clear();
			zG6ueUfuQUk6CEmxLYji[] array2 = array;
			ValueTuple<bool, string> val2 = default(ValueTuple<bool, string>);
			foreach (zG6ueUfuQUk6CEmxLYji val in array2)
			{
				BedrockInstanceCardViewModel bedrockInstanceCardViewModel = (BedrockInstanceCardViewModel)new BedrockInstanceCardViewModel(val);
				if (_accountSwitchStates.TryGetValue(new ValueTuple<int, DateTimeOffset>(val.ProcessId, val.StartedAt), out val2))
				{
					bedrockInstanceCardViewModel.SetOverlayStatus(val2.Item1, val2.Item2);
				}
				((Collection<BedrockInstanceCardViewModel>)(object)AccountSwitchInstances).Add(bedrockInstanceCardViewModel);
			}
			__8_locals2.active = Enumerable.ToHashSet<ValueTuple<int, DateTimeOffset>>(Enumerable.Select<zG6ueUfuQUk6CEmxLYji, ValueTuple<int, DateTimeOffset>>((global::System.Collections.Generic.IEnumerable<zG6ueUfuQUk6CEmxLYji>)array, (Func<zG6ueUfuQUk6CEmxLYji, ValueTuple<int, DateTimeOffset>>)([MethodImpl((MethodImplOptions)8)] (zG6ueUfuQUk6CEmxLYji instance) => new ValueTuple<int, DateTimeOffset>(instance.ProcessId, instance.StartedAt))));
			ValueTuple<int, DateTimeOffset>[] array3 = Enumerable.ToArray<ValueTuple<int, DateTimeOffset>>(Enumerable.Where<ValueTuple<int, DateTimeOffset>>((global::System.Collections.Generic.IEnumerable<ValueTuple<int, DateTimeOffset>>)_accountSwitchStates.Keys, (Func<ValueTuple<int, DateTimeOffset>, bool>)([MethodImpl((MethodImplOptions)8)] (ValueTuple<int, DateTimeOffset> key) => !__8_locals2.active.Contains(key))));
			foreach (ValueTuple<int, DateTimeOffset> val3 in array3)
			{
				_accountSwitchStates.Remove(val3);
			}
			((UIElement)AccountSwitchEmptyText).Visibility = ((array.Length != 0) ? Visibility.Visible : Visibility.Collapsed);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RefreshAccountSwitchInstances", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.AccountSwitch.cs", 65);
			AppShell.Error(AppShell.GetExceptionDisplayMessage(ex, "RefreshAccountSwitchInstances", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.AccountSwitch.cs", 66));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void InjectAccountSwitchButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InjectAccountSwitchButton_Click_d__9 injectAccountSwitchButton_Click_d__ = default(_InjectAccountSwitchButton_Click_d__9);
		injectAccountSwitchButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		injectAccountSwitchButton_Click_d__.__4__this = this;
		injectAccountSwitchButton_Click_d__.sender = sender;
		injectAccountSwitchButton_Click_d__.__1__state = -1;
		injectAccountSwitchButton_Click_d__.__t__builder.Start<_InjectAccountSwitchButton_Click_d__9>(ref injectAccountSwitchButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetAccountSwitchStatus(zG6ueUfuQUk6CEmxLYji instance, bool busy, string status)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass10_0_2 __8_locals5 = (__c__DisplayClass10_0_2)new __c__DisplayClass10_0_2();
		__8_locals5.instance = instance;
		_accountSwitchStates[new ValueTuple<int, DateTimeOffset>(__8_locals5.instance.ProcessId, __8_locals5.instance.StartedAt)] = new ValueTuple<bool, string>(busy, status);
		global::System.Collections.Generic.IEnumerator<BedrockInstanceCardViewModel> enumerator = Enumerable.Where<BedrockInstanceCardViewModel>((global::System.Collections.Generic.IEnumerable<BedrockInstanceCardViewModel>)AccountSwitchInstances, (Func<BedrockInstanceCardViewModel, bool>)([MethodImpl((MethodImplOptions)8)] (BedrockInstanceCardViewModel card) =>
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			zG6ueUfuQUk6CEmxLYji? instance2 = card.Instance;
			return ((instance2 != null) ? new int?(instance2.ProcessId) : ((int?)null)) == __8_locals5.instance.ProcessId && card.Instance.StartedAt == __8_locals5.instance.StartedAt;
		})).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.Current.SetOverlayStatus(busy, status);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void InitializeBujiDaoPatchMethod()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		bool updatingBujiDaoPatchSwitches = _updatingBujiDaoPatchSwitches;
		_updatingBujiDaoPatchSwitches = true;
		try
		{
			ROFAgMXBxPFbLi6HIjJh val = (ROFAgMXBxPFbLi6HIjJh)(XmZPH6fDdBx0Jhg6ql8p.NetworkDeviceSpoofingEnabled ? ((int)XmZPH6fDdBx0Jhg6ql8p.NetworkPatchMethod) : 0);
			BujiDaoAndroidTouchSwitch.IsOn = ((global::System.Enum)val).HasFlag((global::System.Enum)(object)(ROFAgMXBxPFbLi6HIjJh)1);
			BujiDaoMcpPatchSwitch.IsOn = ((global::System.Enum)val).HasFlag((global::System.Enum)(object)(ROFAgMXBxPFbLi6HIjJh)2);
			BujiDaoDeviceSpoofSwitch.IsOn = ((global::System.Enum)val).HasFlag((global::System.Enum)(object)(ROFAgMXBxPFbLi6HIjJh)4);
		}
		finally
		{
			_updatingBujiDaoPatchSwitches = updatingBujiDaoPatchSwitches;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AndroidTouchSwitch_Toggled(object sender, RoutedEventArgs e)
	{
		UpdateBujiDaoPatchMethods();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BujiDaoMcpPatchSwitch_Toggled(object sender, RoutedEventArgs e)
	{
		UpdateBujiDaoPatchMethods();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BujiDaoDeviceSpoofSwitch_Toggled(object sender, RoutedEventArgs e)
	{
		UpdateBujiDaoPatchMethods();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateBujiDaoPatchMethods()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (!_initialized || _updatingBujiDaoPatchSwitches)
		{
			return;
		}
		_updatingBujiDaoPatchSwitches = true;
		try
		{
			ROFAgMXBxPFbLi6HIjJh val = (ROFAgMXBxPFbLi6HIjJh)0;
			if (BujiDaoAndroidTouchSwitch.IsOn)
			{
				val = (ROFAgMXBxPFbLi6HIjJh)((int)val | 1);
			}
			if (BujiDaoMcpPatchSwitch.IsOn)
			{
				val = (ROFAgMXBxPFbLi6HIjJh)((int)val | 2);
			}
			if (BujiDaoDeviceSpoofSwitch.IsOn)
			{
				val = (ROFAgMXBxPFbLi6HIjJh)((int)val | 4);
			}
			XmZPH6fDdBx0Jhg6ql8p.NetworkPatchMethod = val;
			XmZPH6fDdBx0Jhg6ql8p.AndroidTouchEnabled = (int)val > 0;
			InitializeBujiDaoPatchMethod();
			AppShell.Info(((int)val == 0) ? "网络服设备伪装已关闭，下次启动生效" : ("网络服伪装方式已更新：" + XmZPH6fDdBx0Jhg6ql8p.i3dfD6hQKQA() + "；下次启动生效"));
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "UpdateBujiDaoPatchMethods", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.BedrockMcp.cs", 64);
			try
			{
				InitializeBujiDaoPatchMethod();
			}
			catch (global::System.Exception)
			{
				BujiDaoAndroidTouchSwitch.IsOn = false;
				BujiDaoMcpPatchSwitch.IsOn = false;
				BujiDaoDeviceSpoofSwitch.IsOn = false;
			}
			AppShell.Error("保存网络服设备伪装开关失败：" + ex.Message);
		}
		finally
		{
			_updatingBujiDaoPatchSwitches = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void EaseCationDeviceSpooferSwitch_Toggled(object sender, RoutedEventArgs e)
	{
		if (!_initialized || _updatingEaseCationDeviceSpoofer)
		{
			return;
		}
		_updatingEaseCationDeviceSpoofer = true;
		bool isOn = !EaseCationDeviceSpooferSwitch.IsOn;
		try
		{
			isOn = XmZPH6fDdBx0Jhg6ql8p.EaseCationDeviceSpooferEnabled;
			XmZPH6fDdBx0Jhg6ql8p.EaseCationDeviceSpooferEnabled = EaseCationDeviceSpooferSwitch.IsOn;
			AppShell.Info(EaseCationDeviceSpooferSwitch.IsOn ? "EC 适配器已开启，下次启动 EC 生效" : "EC 适配器已关闭，下次启动 EC 生效");
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "EaseCationDeviceSpooferSwitch_Toggled", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.EaseCation.cs", 31);
			EaseCationDeviceSpooferSwitch.IsOn = isOn;
			AppShell.Error("保存 EC 适配器 设置失败，请重试：" + ex.Message);
		}
		finally
		{
			_updatingEaseCationDeviceSpoofer = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToolboxCategory_SelectionChanged(SelectorBar sender, SelectorBarSelectionChangedEventArgs args)
	{
		if (GameToolsPanel == null || NetworkToolsPanel == null || ResourceToolsPanel == null || MaintenanceToolsPanel == null || EaseCationToolsPanel == null)
		{
			return;
		}
		SelectorBarItem selectedItem = sender.SelectedItem;
		string text = (((selectedItem != null) ? ((FrameworkElement)selectedItem).Tag : null) as string) ?? "game";
		if (text == "identity")
		{
			if (!_canAccessHwidTools || _hwidCategoryItem == null)
			{
				sender.SelectedItem = GameCategoryItem;
				return;
			}
			ContentControl hwidToolsContent = HwidToolsContent;
			if (hwidToolsContent.Content == null)
			{
				object obj = (hwidToolsContent.Content = (object)new HwidSpoofToolsView());
			}
		}
		((UIElement)GameToolsPanel).Visibility = ((!(text == "game")) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)NetworkToolsPanel).Visibility = ((!(text == "network")) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)HwidToolsPanel).Visibility = ((!(text == "identity")) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)EaseCationToolsPanel).Visibility = ((!(text == "ec")) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)ResourceToolsPanel).Visibility = ((!(text == "resources")) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)MaintenanceToolsPanel).Visibility = ((!(text == "maintenance")) ? Visibility.Visible : Visibility.Collapsed);
		ToolboxScrollViewer.ChangeView((double?)null, (double?)0.0, (float?)null, true);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToolboxPermissions_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		if (_toolboxPermissionsLoaded)
		{
			return;
		}
		_toolboxPermissionsLoaded = true;
		AppShell.SummaryRefreshed += ToolboxPermissions_SummaryRefreshed;
		AppShell.SessionCleared += new EventHandler(ToolboxPermissions_SessionCleared);
		AppShell.Api.AuthenticationUpdated += new EventHandler(ToolboxPermissions_AuthenticationUpdated);
		AppShell.Api.AuthenticationExpired += new EventHandler(ToolboxPermissions_SessionCleared);
		dN4xMCftS2WHJlRJeqrU val = AppShell.Api.CurrentUser;
		if (val != null)
		{
			yg9HVZft43Yd2k4O7qX5? latestSummary = AppShell.LatestSummary;
			dN4xMCftS2WHJlRJeqrU val2 = ((latestSummary != null) ? latestSummary.User : null);
			if (val2 != null && val2.Id == val.Id)
			{
				val = val2;
			}
		}
		UpdateToolboxPermissions(val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToolboxPermissions_Unloaded(object sender, RoutedEventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		_toolboxPermissionsLoaded = false;
		AppShell.SummaryRefreshed -= ToolboxPermissions_SummaryRefreshed;
		AppShell.SessionCleared -= new EventHandler(ToolboxPermissions_SessionCleared);
		AppShell.Api.AuthenticationUpdated -= new EventHandler(ToolboxPermissions_AuthenticationUpdated);
		AppShell.Api.AuthenticationExpired -= new EventHandler(ToolboxPermissions_SessionCleared);
		UpdateToolboxPermissions(null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToolboxPermissions_SummaryRefreshed(object? sender, yg9HVZft43Yd2k4O7qX5 summary)
	{
		EnqueueToolboxPermissionsUpdate(summary.User);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToolboxPermissions_AuthenticationUpdated(object? sender, EventArgs e)
	{
		EnqueueToolboxPermissionsUpdate(AppShell.Api.CurrentUser);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToolboxPermissions_SessionCleared(object? sender, EventArgs e)
	{
		EnqueueToolboxPermissionsUpdate(null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void EnqueueToolboxPermissionsUpdate(dN4xMCftS2WHJlRJeqrU? user)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		__c__DisplayClass28_0_1 __8_locals6 = (__c__DisplayClass28_0_1)new __c__DisplayClass28_0_1();
		__8_locals6.__4__this = this;
		__8_locals6.user = user;
		if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			__8_locals6._EnqueueToolboxPermissionsUpdate_g__Refresh_0();
			return;
		}
		((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] () =>
		{
			if (__8_locals6.__4__this._toolboxPermissionsLoaded)
			{
				__8_locals6.__4__this.UpdateToolboxPermissions(__8_locals6.user);
			}
		}));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateToolboxPermissions(dN4xMCftS2WHJlRJeqrU? user)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00ab: Expected O, but got Unknown
		try
		{
			int canAccessHwidTools;
			if (user != null)
			{
				long id = user.Id;
				dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
				if (id == ((currentUser != null) ? new long?(currentUser.Id) : ((long?)null)))
				{
					canAccessHwidTools = (NavigationAuthorization.CanAccessHwidTools(user) ? 1 : 0);
					goto IL_0059;
				}
			}
			canAccessHwidTools = 0;
			goto IL_0059;
			IL_0059:
			_canAccessHwidTools = (byte)canAccessHwidTools != 0;
			if (_canAccessHwidTools)
			{
				if (_hwidCategoryItem == null)
				{
					_hwidCategoryItem = new SelectorBarItem
					{
						Tag = "identity",
						Text = "身份标识",
						Icon = (IconElement)new FontIcon
						{
							Glyph = "\ue72e"
						}
					};
				}
				if (!((global::System.Collections.Generic.ICollection<SelectorBarItem>)ToolboxCategoryBar.Items).Contains(_hwidCategoryItem))
				{
					ToolboxCategoryBar.Items.Insert(2, _hwidCategoryItem);
				}
				return;
			}
			if (_hwidCategoryItem != null)
			{
				if (ToolboxCategoryBar.SelectedItem == _hwidCategoryItem)
				{
					ToolboxCategoryBar.SelectedItem = GameCategoryItem;
				}
				((global::System.Collections.Generic.ICollection<SelectorBarItem>)ToolboxCategoryBar.Items).Remove(_hwidCategoryItem);
				_hwidCategoryItem = null;
			}
			((UIElement)HwidToolsPanel).Visibility = (Visibility)1;
			HwidToolsContent.Content = null;
		}
		catch (global::System.Exception ex)
		{
			_canAccessHwidTools = false;
			if (_hwidCategoryItem != null)
			{
				((global::System.Collections.Generic.ICollection<SelectorBarItem>)ToolboxCategoryBar.Items).Remove(_hwidCategoryItem);
			}
			_hwidCategoryItem = null;
			((UIElement)HwidToolsPanel).Visibility = (Visibility)1;
			HwidToolsContent.Content = null;
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "toolbox-permissions", "UpdateToolboxPermissions", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.Permissions.cs", 99);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseResourceDecryptInputButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseResourceDecryptInputButton_Click_d__31 chooseResourceDecryptInputButton_Click_d__ = default(_ChooseResourceDecryptInputButton_Click_d__31);
		chooseResourceDecryptInputButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseResourceDecryptInputButton_Click_d__.__4__this = this;
		chooseResourceDecryptInputButton_Click_d__.__1__state = -1;
		chooseResourceDecryptInputButton_Click_d__.__t__builder.Start<_ChooseResourceDecryptInputButton_Click_d__31>(ref chooseResourceDecryptInputButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseResourceDecryptOutputButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseResourceDecryptOutputButton_Click_d__32 chooseResourceDecryptOutputButton_Click_d__ = default(_ChooseResourceDecryptOutputButton_Click_d__32);
		chooseResourceDecryptOutputButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseResourceDecryptOutputButton_Click_d__.__4__this = this;
		chooseResourceDecryptOutputButton_Click_d__.__1__state = -1;
		chooseResourceDecryptOutputButton_Click_d__.__t__builder.Start<_ChooseResourceDecryptOutputButton_Click_d__32>(ref chooseResourceDecryptOutputButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DecryptResourceArchiveButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DecryptResourceArchiveButton_Click_d__33 decryptResourceArchiveButton_Click_d__ = default(_DecryptResourceArchiveButton_Click_d__33);
		decryptResourceArchiveButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		decryptResourceArchiveButton_Click_d__.__4__this = this;
		decryptResourceArchiveButton_Click_d__.__1__state = -1;
		decryptResourceArchiveButton_Click_d__.__t__builder.Start<_DecryptResourceArchiveButton_Click_d__33>(ref decryptResourceArchiveButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelResourceDecryptButton_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? resourceDecryptCancellation = _resourceDecryptCancellation;
		if (resourceDecryptCancellation != null)
		{
			resourceDecryptCancellation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public ToolboxPage()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		_accountSwitchStates = new Dictionary<ValueTuple<int, DateTimeOffset>, ValueTuple<bool, string>>();
		_AccountSwitchInstances_k__BackingField = new ObservableCollection<BedrockInstanceCardViewModel>();
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(AccountSwitch_Loaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(AccountSwitch_Unloaded);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(ToolboxPermissions_Loaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(ToolboxPermissions_Unloaded);
		try
		{
			InitializeBujiDaoPatchMethod();
			EaseCationDeviceSpooferSwitch.IsOn = XmZPH6fDdBx0Jhg6ql8p.EaseCationDeviceSpooferEnabled;
			_initialized = true;
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", ".ctor", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ToolboxPage.xaml.cs", 27);
			((Control)this).IsEnabled = false;
			AppShell.Error("加载工具箱设置失败：" + ex.Message);
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
			Uri val = new Uri("ms-appx:///Views/Pages/ToolboxPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ToolboxScrollViewer = CastExtensions.As<ScrollViewer>(target);
			break;
		case 3:
			GameToolsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			HwidToolsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 5:
			EaseCationToolsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 6:
			NetworkToolsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 7:
			ResourceToolsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 8:
			MaintenanceToolsPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 9:
			ResourceDecryptStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			ResourceDecryptButton = CastExtensions.As<Button>(target);
			((ButtonBase)ResourceDecryptButton).Click += new RoutedEventHandler(DecryptResourceArchiveButton_Click);
			break;
		case 11:
			ResourceDecryptProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 12:
			CancelResourceDecryptButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelResourceDecryptButton).Click += new RoutedEventHandler(CancelResourceDecryptButton_Click);
			break;
		case 13:
			ResourceDecryptOutputPathTextBox = CastExtensions.As<TextBox>(target);
			break;
		case 14:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ChooseResourceDecryptOutputButton_Click);
			break;
		case 15:
			ResourceDecryptItemIdsTextBox = CastExtensions.As<TextBox>(target);
			break;
		case 16:
			ResourceDecryptInputPathTextBox = CastExtensions.As<TextBox>(target);
			break;
		case 17:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ChooseResourceDecryptInputButton_Click);
			break;
		case 18:
			EaseCationDeviceSpooferSwitch = CastExtensions.As<ToggleSwitch>(target);
			EaseCationDeviceSpooferSwitch.Toggled += new RoutedEventHandler(EaseCationDeviceSpooferSwitch_Toggled);
			break;
		case 19:
			HwidToolsContent = CastExtensions.As<ContentControl>(target);
			break;
		case 20:
			BujiDaoDeviceSpoofSwitch = CastExtensions.As<ToggleSwitch>(target);
			BujiDaoDeviceSpoofSwitch.Toggled += new RoutedEventHandler(BujiDaoDeviceSpoofSwitch_Toggled);
			break;
		case 21:
			BujiDaoMcpPatchSwitch = CastExtensions.As<ToggleSwitch>(target);
			BujiDaoMcpPatchSwitch.Toggled += new RoutedEventHandler(BujiDaoMcpPatchSwitch_Toggled);
			break;
		case 22:
			BujiDaoAndroidTouchSwitch = CastExtensions.As<ToggleSwitch>(target);
			BujiDaoAndroidTouchSwitch.Toggled += new RoutedEventHandler(AndroidTouchSwitch_Toggled);
			break;
		case 25:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(InjectAccountSwitchButton_Click);
			break;
		case 26:
			AccountSwitchEmptyText = CastExtensions.As<TextBlock>(target);
			break;
		case 27:
			ToolboxCategoryBar = CastExtensions.As<SelectorBar>(target);
			ToolboxCategoryBar.SelectionChanged += ToolboxCategory_SelectionChanged;
			break;
		case 28:
			GameCategoryItem = CastExtensions.As<SelectorBarItem>(target);
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
			Page val = (Page)target;
			ToolboxPage_obj1_Bindings toolboxPage_obj1_Bindings = (ToolboxPage_obj1_Bindings)new ToolboxPage_obj1_Bindings();
			result = (IComponentConnector)(object)toolboxPage_obj1_Bindings;
			toolboxPage_obj1_Bindings.SetDataRoot(this);
			Bindings = toolboxPage_obj1_Bindings;
			((FrameworkElement)val).Loading += toolboxPage_obj1_Bindings.Loading;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void _DecryptResourceArchiveButton_Click_b__33_0(string message)
	{
		ResourceDecryptStatusText.Text = message;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using K5FCrdFj16NFnFBU3KQ;
using Mahiro_Account.UI;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.Storage.Pickers;
using SLvJQFfxw2j1ECrhEo56;
using SVtRc2fFvnG78kygrK2C;
using WinRT;
using WinRT.ChronalVtableClasses;
using YXMjNoXcouOKeTTRMKFH;
using bUfedyCg1PBqhqIkB8r;
using bVyVYtfFgCItGPihJweI;
using ePeBZXfsCVxgSE2pDQBf;
using g9URnXfPsZf2NEmlbUkL;
using hEe5DDfshi43hFljV651;
using kq2pipfTwPkE4qWLSUgF;
using qS8vkpL43FlTMgcj0rgs;
using zX707pfFXiAmiNASTxFS;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class JavaVersionManagementPage : Page, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IJavaVersionManagementPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IJavaVersionManagementPage_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_ContentControl_Content(ContentControl obj, object value, string targetNullValue)
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
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class JavaVersionManagementPage_obj8_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IJavaVersionManagementPage_Bindings
	{
		private WkLnWrfTRJdhyRBYcOwg dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj8;

		private Button obj9;

		private TextBlock obj10;

		private TextBlock obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private TextBlock obj14;

		private TextBlock obj15;

		[MethodImpl((MethodImplOptions)8)]
		public JavaVersionManagementPage_obj8_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			switch (connectionId)
			{
			case 8:
				obj8 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 9:
				obj9 = CastExtensions.As<Button>(target);
				break;
			case 10:
				obj10 = CastExtensions.As<TextBlock>(target);
				break;
			case 11:
				obj11 = CastExtensions.As<TextBlock>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<TextBlock>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<TextBlock>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<TextBlock>(target);
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
			object target = obj8.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<WkLnWrfTRJdhyRBYcOwg>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<WkLnWrfTRJdhyRBYcOwg>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(WkLnWrfTRJdhyRBYcOwg obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Version(obj.Version, phase);
				Update_ActionText(obj.ActionText, phase);
				Update_StatusText(obj.StatusText, phase);
				Update_InstallationPath(obj.InstallationPath, phase);
				Update_ClientStateText(obj.ClientStateText, phase);
				Update_RuntimeStateText(obj.RuntimeStateText, phase);
				Update_RuntimeText(obj.RuntimeText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Version(ys1lxxfFBPhowwZS5N6T obj, int phase)
		{
			if (obj != (ys1lxxfFBPhowwZS5N6T)null && (phase & -2147483647) != 0)
			{
				Update_Version_Name(obj.Name, phase);
			}
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ActionText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentControl_Content((ContentControl)(object)obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_InstallationPath(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ClientStateText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_RuntimeStateText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Version_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj14, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_RuntimeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj15, obj, null);
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
	private class JavaVersionManagementPage_obj1_Bindings : IComponentConnector, IJavaVersionManagementPage_Bindings
	{
		private JavaVersionManagementPage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ListView obj2;

		[MethodImpl((MethodImplOptions)8)]
		public JavaVersionManagementPage_obj1_Bindings()
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
				dataRoot = CastExtensions.As<JavaVersionManagementPage>(newDataRoot);
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
		private void Update_(JavaVersionManagementPage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_Installations(obj.Installations, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Installations(ObservableCollection<WkLnWrfTRJdhyRBYcOwg> obj, int phase)
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
	private sealed class __c__DisplayClass25_0
	{
		public ys1lxxfFBPhowwZS5N6T version;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass25_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _InstallVersionButton_Click_b__0(ys1lxxfFBPhowwZS5N6T item)
		{
			return item.Id == version.Id;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass26_0_1
	{
		public JavaVersionManagementPage __4__this;

		public ys1lxxfFBPhowwZS5N6T version;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass26_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal async global::System.Threading.Tasks.Task<string> _InstallVersionAsync_b__0(IProgress<pqWRiwfFbLTQvJu9JjbG> progress, CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			JAWVYgfF3C6jngi7m3yp val = await __4__this._client.DGSs8v4wRt(version, progress, cancellationToken);
			return $"Java {version.Name} 已完成：检查 {val.CheckedUnits} 个单元，修复 {val.RepairedUnits} 个，跳过 {val.SkippedUnits} 个";
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _InstallVersionAsync_b__1()
		{
			return __4__this.InstallVersionAsync(version);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass3_0
	{
		public JavaVersionManagementPage __4__this;

		public RThjl9fsQN0B8woeqALL mode;

		public string label;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass3_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal async global::System.Threading.Tasks.Task<string> _ValidateResourcesAsync_b__0(IProgress<pqWRiwfFbLTQvJu9JjbG> _, CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			wCWSpCfs47ZEvTcn8LeV val = await __4__this._client.uVCsY73rfx(mode, cancellationToken);
			return $"{label}完成：共 {val.TotalUnits} 个单元，有效 {val.ValidUnits} 个，损坏 {val.InvalidUnits} 个";
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _ValidateResourcesAsync_b__1()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return __4__this.ValidateResourcesAsync(mode);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ChooseRootButton_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_0098;
					}
					_u__ = DesktopFilePicker.PickFolderAsync(AppShell.WindowHandle, (PickerLocationId)1, "选择 Java 客户端目录").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseRootButton_Click_d__23>(ref _u__, ref this);
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
				if (!string.IsNullOrWhiteSpace(result))
				{
					goto IL_0098;
				}
				goto end_IL_0011;
				IL_0098:
					result = default;
				try
				{
					TaskAwaiter _u__2 = default;
					if (num != 1)
					{
						javaVersionManagementPage._client.E5GFmGfxb2(result);
						javaVersionManagementPage.RefreshStatus();
						_u__2 = javaVersionManagementPage.RefreshPageStateAsync().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ChooseRootButton_Click_d__23>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
					}
					_u__2.GetResult();
					AppShell.Success("Java 客户端目录已更新");
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "ChooseRootButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaVersionManagementPage.xaml.cs", 83);
					AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "选择当前用户可写的客户端目录后重试"));
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
	private struct _CleanupCacheAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage __8_locals4 = __4__this;
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
						goto IL_00f6;
					}
					_u__2 = __8_locals4.RunTaskAsync("清理 Java 下载缓存", [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] async (IProgress<pqWRiwfFbLTQvJu9JjbG> _, CancellationToken cancellationToken) => "缓存清理完成，当前占用 " + FormatBytes((await __8_locals4._client.FpHsJ4hEEn(cancellationToken)).TotalBytes), __8_locals4.CleanupCacheAsync).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _CleanupCacheAsync_d__7>(ref _u__2, ref this);
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
					_u__ = __8_locals4.RefreshPageStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CleanupCacheAsync_d__7>(ref _u__, ref this);
						return;
					}
					goto IL_00f6;
				}
				goto end_IL_0011;
				IL_00f6:
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
	private struct _CleanupCacheButton_Click_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

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
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaVersionManagementPage.CleanupCacheAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CleanupCacheButton_Click_d__6>(ref _u__, ref this);
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
	private struct _FullValidateButton_Click_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaVersionManagementPage.ValidateResourcesAsync((RThjl9fsQN0B8woeqALL)1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _FullValidateButton_Click_d__2>(ref _u__, ref this);
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
	private struct _InstallButton_Click_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0086;
				}
				object selectedItem = ((Selector)javaVersionManagementPage.VersionSelector).SelectedItem;
				ys1lxxfFBPhowwZS5N6T val = (ys1lxxfFBPhowwZS5N6T)((selectedItem is ys1lxxfFBPhowwZS5N6T) ? selectedItem : null);
				if (val != null)
				{
					_u__ = javaVersionManagementPage.InstallVersionAsync(val).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InstallButton_Click_d__24>(ref _u__, ref this);
						return;
					}
					goto IL_0086;
				}
				goto end_IL_0011;
				IL_0086:
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
	private struct _InstallVersionAsync_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		public ys1lxxfFBPhowwZS5N6T version;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
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
						goto IL_0127;
					}
					__c__DisplayClass26_0_1 _c__DisplayClass26_0_ = (__c__DisplayClass26_0_1)new __c__DisplayClass26_0_1
					{
						__4__this = __4__this,
						version = version
					};
					_u__2 = javaVersionManagementPage.RunTaskAsync("安装或修复 Java " + _c__DisplayClass26_0_.version.Name, _c__DisplayClass26_0_._InstallVersionAsync_b__0, _c__DisplayClass26_0_._InstallVersionAsync_b__1, requiresSession: true).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _InstallVersionAsync_d__26>(ref _u__2, ref this);
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
					_u__ = javaVersionManagementPage.RefreshPageStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InstallVersionAsync_d__26>(ref _u__, ref this);
						return;
					}
					goto IL_0127;
				}
				goto end_IL_0011;
				IL_0127:
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
	private struct _InstallVersionButton_Click_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00dd;
				}
				__c__DisplayClass25_0 _c__DisplayClass25_ = (__c__DisplayClass25_0)new __c__DisplayClass25_0();
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object commandParameter = ((ButtonBase)val).CommandParameter;
					_c__DisplayClass25_.version = (ys1lxxfFBPhowwZS5N6T)((commandParameter is ys1lxxfFBPhowwZS5N6T) ? commandParameter : null);
					if (_c__DisplayClass25_.version != null)
					{
						((Selector)javaVersionManagementPage.VersionSelector).SelectedItem = Enumerable.FirstOrDefault<ys1lxxfFBPhowwZS5N6T>((global::System.Collections.Generic.IEnumerable<ys1lxxfFBPhowwZS5N6T>)ys1lxxfFBPhowwZS5N6T.SupportedVersions, (Func<ys1lxxfFBPhowwZS5N6T, bool>)_c__DisplayClass25_._InstallVersionButton_Click_b__0) ?? _c__DisplayClass25_.version;
						_u__ = javaVersionManagementPage.InstallVersionAsync(_c__DisplayClass25_.version).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InstallVersionButton_Click_d__25>(ref _u__, ref this);
							return;
						}
						goto IL_00dd;
					}
				}
				goto end_IL_0011;
				IL_00dd:
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
	private struct _JavaVersionManagementPage_Loaded_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

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
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					javaVersionManagementPage.AuthenticationStatusText.Text = "认证资源 自动管理";
					javaVersionManagementPage.RefreshStatus();
					_u__ = javaVersionManagementPage.RefreshPageStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _JavaVersionManagementPage_Loaded_d__19>(ref _u__, ref this);
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
	private struct _QuickValidateButton_Click_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaVersionManagementPage.ValidateResourcesAsync((RThjl9fsQN0B8woeqALL)0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _QuickValidateButton_Click_d__1>(ref _u__, ref this);
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
	private struct _RefreshPageButton_Click_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

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
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaVersionManagementPage.RefreshPageStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshPageButton_Click_d__21>(ref _u__, ref this);
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
	private struct _RefreshPageStateAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private CancellationTokenSource _cancellation_5__2;

		private global::System.Collections.Generic.IReadOnlyList<WkLnWrfTRJdhyRBYcOwg> _installations_5__3;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WkLnWrfTRJdhyRBYcOwg>> __u__1;

		private TaskAwaiter<iMlXO3fPFoonsNtH3fS2> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0034;
				}
				if (javaVersionManagementPage._operation == null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0034;
				}
				goto end_IL_0011;
				IL_0034:
				try
				{
					if ((uint)num > 1u)
					{
						javaVersionManagementPage._operation = _cancellation_5__2;
						javaVersionManagementPage.SetControlsEnabled(enabled: false);
						javaVersionManagementPage.VersionListProgressRing.IsActive = true;
						((UIElement)javaVersionManagementPage.VersionListProgressRing).Visibility = (Visibility)0;
						((UIElement)javaVersionManagementPage.VersionEmptyPanel).Visibility = (((Collection<WkLnWrfTRJdhyRBYcOwg>)(object)javaVersionManagementPage.Installations).Count != 0) ? Visibility.Visible : Visibility.Collapsed;
						javaVersionManagementPage.VersionEmptyTitle.Text = "正在读取版本状态";
						javaVersionManagementPage.VersionEmptyDescription.Text = "请稍候";
						javaVersionManagementPage.ResourceProgressRing.IsActive = true;
						((UIElement)javaVersionManagementPage.ResourceProgressRing).Visibility = (Visibility)0;
					}
					try
					{
						TaskAwaiter<iMlXO3fPFoonsNtH3fS2> _u__ = default;
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WkLnWrfTRJdhyRBYcOwg>> _u__2;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<iMlXO3fPFoonsNtH3fS2>);
								num = (__1__state = -1);
								goto IL_01b1;
							}
							_u__2 = javaVersionManagementPage._client.P3GsVqRg9P(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WkLnWrfTRJdhyRBYcOwg>>, _RefreshPageStateAsync_d__10>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<WkLnWrfTRJdhyRBYcOwg>>);
							num = (__1__state = -1);
						}
						global::System.Collections.Generic.IReadOnlyList<WkLnWrfTRJdhyRBYcOwg> result = _u__2.GetResult();
						_installations_5__3 = result;
						_u__ = javaVersionManagementPage._client.HplsW7QPAD(_cancellation_5__2.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<iMlXO3fPFoonsNtH3fS2>, _RefreshPageStateAsync_d__10>(ref _u__, ref this);
							return;
						}
						goto IL_01b1;
						IL_01b1:
						iMlXO3fPFoonsNtH3fS2 result2 = _u__.GetResult();
						((Collection<WkLnWrfTRJdhyRBYcOwg>)(object)javaVersionManagementPage.Installations).Clear();
						global::System.Collections.Generic.IEnumerator<WkLnWrfTRJdhyRBYcOwg> enumerator = ((global::System.Collections.Generic.IEnumerable<WkLnWrfTRJdhyRBYcOwg>)_installations_5__3).GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
							{
								WkLnWrfTRJdhyRBYcOwg current = enumerator.Current;
								((Collection<WkLnWrfTRJdhyRBYcOwg>)(object)javaVersionManagementPage.Installations).Add(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								((global::System.IDisposable)enumerator)?.Dispose();
							}
						}
						((UIElement)javaVersionManagementPage.VersionEmptyPanel).Visibility = (((Collection<WkLnWrfTRJdhyRBYcOwg>)(object)javaVersionManagementPage.Installations).Count != 0) ? Visibility.Visible : Visibility.Collapsed;
						javaVersionManagementPage.VersionEmptyTitle.Text = "暂无版本信息";
						javaVersionManagementPage.VersionEmptyDescription.Text = "请刷新后重试";
						javaVersionManagementPage.ResourceStatusText.Text = $"下载缓存 {FormatBytes(result2.TotalBytes)} · {result2.FileCount} 个文件 · 断点 {FormatBytes(result2.PartialBytes)} · 正在使用 {result2.ProtectedFileCount} 个";
						javaVersionManagementPage.RefreshStatus();
						javaVersionManagementPage._retryOperation = null;
						((UIElement)javaVersionManagementPage.RetryOperationButton).Visibility = (Visibility)1;
						_installations_5__3 = null;
					}
					catch (OperationCanceledException)
					{
						javaVersionManagementPage.ResourceStatusText.Text = "状态刷新已取消，可以重新刷新";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "RefreshPageStateAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaVersionManagementPage.Operations.cs", 225);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "重新刷新版本和缓存状态");
						javaVersionManagementPage.ResourceStatusText.Text = text;
						((UIElement)javaVersionManagementPage.VersionEmptyPanel).Visibility = (Visibility)0;
						javaVersionManagementPage.VersionEmptyTitle.Text = "版本状态读取失败";
						javaVersionManagementPage.VersionEmptyDescription.Text = text;
						javaVersionManagementPage._retryOperation = javaVersionManagementPage.RefreshPageStateAsync;
						((UIElement)javaVersionManagementPage.RetryOperationButton).Visibility = (Visibility)0;
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaVersionManagementPage._operation == _cancellation_5__2)
							{
								javaVersionManagementPage._operation = null;
							}
							javaVersionManagementPage.VersionListProgressRing.IsActive = false;
							((UIElement)javaVersionManagementPage.VersionListProgressRing).Visibility = (Visibility)1;
							javaVersionManagementPage.ResourceProgressRing.IsActive = false;
							((UIElement)javaVersionManagementPage.ResourceProgressRing).Visibility = (Visibility)1;
							javaVersionManagementPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__2 != null)
					{
						((global::System.IDisposable)_cancellation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
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
	private struct _RefreshResourcesButton_Click_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

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
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaVersionManagementPage.RefreshPageStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshResourcesButton_Click_d__0>(ref _u__, ref this);
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
	private struct _RepairAllButton_Click_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

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
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaVersionManagementPage.RepairAllResourcesAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RepairAllButton_Click_d__4>(ref _u__, ref this);
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
	private struct _RepairAllResourcesAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage __8_locals4 = __4__this;
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
						goto IL_00f6;
					}
					_u__2 = __8_locals4.RunTaskAsync("修复全部 Java 资源", [MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] async (IProgress<pqWRiwfFbLTQvJu9JjbG> progress, CancellationToken cancellationToken) =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						//IL_0021: Unknown result type (might be due to invalid IL or missing references)
						//IL_0022: Unknown result type (might be due to invalid IL or missing references)
						JAWVYgfF3C6jngi7m3yp val = await __8_locals4._client.Ab7syBue1G(progress, cancellationToken);
						return $"修复完成：检查 {val.CheckedUnits} 个单元，修复 {val.RepairedUnits} 个，跳过 {val.SkippedUnits} 个";
					}, __8_locals4.RepairAllResourcesAsync, requiresSession: true).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _RepairAllResourcesAsync_d__5>(ref _u__2, ref this);
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
					_u__ = __8_locals4.RefreshPageStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RepairAllResourcesAsync_d__5>(ref _u__, ref this);
						return;
					}
					goto IL_00f6;
				}
				goto end_IL_0011;
				IL_00f6:
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
	private struct _RetryOperationButton_Click_d__28 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_007b;
				}
				Func<global::System.Threading.Tasks.Task> retryOperation = javaVersionManagementPage._retryOperation;
				if (retryOperation != null)
				{
					_u__ = retryOperation.Invoke().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RetryOperationButton_Click_d__28>(ref _u__, ref this);
						return;
					}
					goto IL_007b;
				}
				goto end_IL_0011;
				IL_007b:
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
	private struct _ValidateResourcesAsync_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaVersionManagementPage __4__this;

		public RThjl9fsQN0B8woeqALL mode;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaVersionManagementPage javaVersionManagementPage = __4__this;
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
						goto IL_0138;
					}
					__c__DisplayClass3_0 _c__DisplayClass3_ = (__c__DisplayClass3_0)new __c__DisplayClass3_0();
					_c__DisplayClass3_.__4__this = __4__this;
					_c__DisplayClass3_.mode = mode;
					_c__DisplayClass3_.label = (((int)_c__DisplayClass3_.mode == 0) ? "快速校验" : "完整校验");
					_u__2 = javaVersionManagementPage.RunTaskAsync(_c__DisplayClass3_.label, _c__DisplayClass3_._ValidateResourcesAsync_b__0, _c__DisplayClass3_._ValidateResourcesAsync_b__1).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ValidateResourcesAsync_d__3>(ref _u__2, ref this);
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
					_u__ = javaVersionManagementPage.RefreshPageStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ValidateResourcesAsync_d__3>(ref _u__, ref this);
						return;
					}
					goto IL_0138;
				}
				goto end_IL_0011;
				IL_0138:
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

	private readonly KxOGVaFL8AQcstEY1GC _client;

	private CancellationTokenSource? _operation;

	private Func<global::System.Threading.Tasks.Task>? _retryOperation;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView VersionList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel VersionEmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing VersionListProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock VersionEmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock VersionEmptyDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing ResourceProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button QuickValidateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button FullValidateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RepairAllButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CleanupCacheButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshResourcesButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ResourceStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar TaskProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SessionHintText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AuthenticationStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Java21StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Java17StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Java8StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock Java7StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BaseStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox RootPathBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing TaskProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock TaskPercentText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock TaskTitleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock TaskStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock TaskCurrentFileText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox VersionSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button InstallButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelOperationButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RetryOperationButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock InstallDescriptionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshPageButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IJavaVersionManagementPage_Bindings Bindings;

	[CompilerGenerated]
	private readonly ObservableCollection<WkLnWrfTRJdhyRBYcOwg> _Installations_k__BackingField;

	public ObservableCollection<WkLnWrfTRJdhyRBYcOwg> Installations
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Installations_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshResourcesButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshResourcesButton_Click_d__0 refreshResourcesButton_Click_d__ = default(_RefreshResourcesButton_Click_d__0);
		refreshResourcesButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshResourcesButton_Click_d__.__4__this = this;
		refreshResourcesButton_Click_d__.__1__state = -1;
		refreshResourcesButton_Click_d__.__t__builder.Start<_RefreshResourcesButton_Click_d__0>(ref refreshResourcesButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void QuickValidateButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_QuickValidateButton_Click_d__1 quickValidateButton_Click_d__ = default(_QuickValidateButton_Click_d__1);
		quickValidateButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		quickValidateButton_Click_d__.__4__this = this;
		quickValidateButton_Click_d__.__1__state = -1;
		quickValidateButton_Click_d__.__t__builder.Start<_QuickValidateButton_Click_d__1>(ref quickValidateButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void FullValidateButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_FullValidateButton_Click_d__2 fullValidateButton_Click_d__ = default(_FullValidateButton_Click_d__2);
		fullValidateButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		fullValidateButton_Click_d__.__4__this = this;
		fullValidateButton_Click_d__.__1__state = -1;
		fullValidateButton_Click_d__.__t__builder.Start<_FullValidateButton_Click_d__2>(ref fullValidateButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ValidateResourcesAsync(RThjl9fsQN0B8woeqALL mode)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_ValidateResourcesAsync_d__3 validateResourcesAsync_d__ = default(_ValidateResourcesAsync_d__3);
		validateResourcesAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		validateResourcesAsync_d__.__4__this = this;
		validateResourcesAsync_d__.mode = mode;
		validateResourcesAsync_d__.__1__state = -1;
		validateResourcesAsync_d__.__t__builder.Start<_ValidateResourcesAsync_d__3>(ref validateResourcesAsync_d__);
		return validateResourcesAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RepairAllButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RepairAllButton_Click_d__4 repairAllButton_Click_d__ = default(_RepairAllButton_Click_d__4);
		repairAllButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		repairAllButton_Click_d__.__4__this = this;
		repairAllButton_Click_d__.__1__state = -1;
		repairAllButton_Click_d__.__t__builder.Start<_RepairAllButton_Click_d__4>(ref repairAllButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RepairAllResourcesAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RepairAllResourcesAsync_d__5 repairAllResourcesAsync_d__ = default(_RepairAllResourcesAsync_d__5);
		repairAllResourcesAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		repairAllResourcesAsync_d__.__4__this = this;
		repairAllResourcesAsync_d__.__1__state = -1;
		repairAllResourcesAsync_d__.__t__builder.Start<_RepairAllResourcesAsync_d__5>(ref repairAllResourcesAsync_d__);
		return repairAllResourcesAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CleanupCacheButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CleanupCacheButton_Click_d__6 cleanupCacheButton_Click_d__ = default(_CleanupCacheButton_Click_d__6);
		cleanupCacheButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		cleanupCacheButton_Click_d__.__4__this = this;
		cleanupCacheButton_Click_d__.__1__state = -1;
		cleanupCacheButton_Click_d__.__t__builder.Start<_CleanupCacheButton_Click_d__6>(ref cleanupCacheButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task CleanupCacheAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CleanupCacheAsync_d__7 cleanupCacheAsync_d__ = default(_CleanupCacheAsync_d__7);
		cleanupCacheAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		cleanupCacheAsync_d__.__4__this = this;
		cleanupCacheAsync_d__.__1__state = -1;
		cleanupCacheAsync_d__.__t__builder.Start<_CleanupCacheAsync_d__7>(ref cleanupCacheAsync_d__);
		return cleanupCacheAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<bool> RunTaskAsync(string title, Func<IProgress<pqWRiwfFbLTQvJu9JjbG>, CancellationToken, global::System.Threading.Tasks.Task<string>> operation, Func<global::System.Threading.Tasks.Task> retry, bool requiresSession = false)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (_operation != null)
		{
			return false;
		}
		if (requiresSession && _client.CurrentSession == null)
		{
			string text = "尚未建立 Java 游戏会话。下一步：前往 Java 账号配置完成登录";
			TaskTitleText.Text = title;
			TaskStatusText.Text = text;
			((UIElement)RetryOperationButton).Visibility = (Visibility)0;
			_retryOperation = retry;
			AppShell.Error(text);
			return false;
		}
		CancellationTokenSource val = new CancellationTokenSource();
		try
		{
			_operation = val;
			_retryOperation = retry;
			SetControlsEnabled(enabled: false);
			((UIElement)RetryOperationButton).Visibility = (Visibility)1;
			TaskProgressRing.IsActive = true;
			ResourceProgressRing.IsActive = true;
			((UIElement)ResourceProgressRing).Visibility = (Visibility)0;
			TaskTitleText.Text = title;
			TaskStatusText.Text = "正在准备任务";
			TaskCurrentFileText.Text = string.Empty;
			((RangeBase)TaskProgressBar).Value = 0.0;
			TaskPercentText.Text = "0%";
			Progress<pqWRiwfFbLTQvJu9JjbG> val2 = new Progress<pqWRiwfFbLTQvJu9JjbG>((Action<pqWRiwfFbLTQvJu9JjbG>)UpdateTaskProgress);
			try
			{
				string text2 = await operation.Invoke((IProgress<pqWRiwfFbLTQvJu9JjbG>)(object)val2, val.Token);
				TaskStatusText.Text = text2;
				ResourceStatusText.Text = text2;
				((RangeBase)TaskProgressBar).Value = 100.0;
				TaskPercentText.Text = "100%";
				_retryOperation = null;
				AppShell.Success(text2);
				return true;
			}
			catch (OperationCanceledException)
			{
				TaskStatusText.Text = "任务已取消，可以重新发起";
				ResourceStatusText.Text = "上次操作已取消";
				((UIElement)RetryOperationButton).Visibility = (Visibility)0;
				return false;
			}
			catch (global::System.Exception ex2)
			{
				cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "RunTaskAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaVersionManagementPage.Operations.cs", 141);
				string text3 = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "保留当前文件后重试该任务");
				TaskStatusText.Text = text3;
				ResourceStatusText.Text = text3;
				((UIElement)RetryOperationButton).Visibility = (Visibility)0;
				AppShell.Error(text3);
				return false;
			}
			finally
			{
				if (_operation == val)
				{
					_operation = null;
				}
				TaskProgressRing.IsActive = false;
				ResourceProgressRing.IsActive = false;
				((UIElement)ResourceProgressRing).Visibility = (Visibility)1;
				SetControlsEnabled(enabled: true);
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateTaskProgress(pqWRiwfFbLTQvJu9JjbG item)
	{
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		double value = Math.Clamp(item.Percent, 0.0, 100.0);
		((RangeBase)TaskProgressBar).Value = value;
		TaskPercentText.Text = value.ToString("0", (IFormatProvider)(object)CultureInfo.InvariantCulture) + "%";
		string text = ((item.StepCount > 0) ? $"步骤 {Math.Clamp(item.StepIndex, 0, item.StepCount)} / {item.StepCount} · " : string.Empty);
		TaskStatusText.Text = text + item.Message;
		long? totalBytes = item.TotalBytes;
		string text2 = ((totalBytes.HasValue && totalBytes.GetValueOrDefault() > 0) ? (FormatBytes(item.BytesProcessed) + " / " + FormatBytes(item.TotalBytes.Value)) : ((item.BytesProcessed > 0) ? FormatBytes(item.BytesProcessed) : string.Empty));
		double? bytesPerSecond = item.BytesPerSecond;
		string text3 = ((bytesPerSecond.HasValue && bytesPerSecond.GetValueOrDefault() > 0.0) ? (" · " + FormatBytes((long)item.BytesPerSecond.Value) + "/s") : string.Empty);
		TimeSpan? estimatedRemaining = item.EstimatedRemaining;
		string text4;
		if (estimatedRemaining.HasValue)
		{
			TimeSpan valueOrDefault = estimatedRemaining.GetValueOrDefault();
			text4 = " · 剩余约 " + FormatDuration(valueOrDefault);
		}
		else
		{
			text4 = string.Empty;
		}
		string text5 = text4;
		string text6 = (string.IsNullOrWhiteSpace(item.CurrentFile) ? string.Empty : (item.CurrentFile + " · "));
		TaskCurrentFileText.Text = text6 + text2 + text3 + text5;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshPageStateAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshPageStateAsync_d__10 refreshPageStateAsync_d__ = default(_RefreshPageStateAsync_d__10);
		refreshPageStateAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshPageStateAsync_d__.__4__this = this;
		refreshPageStateAsync_d__.__1__state = -1;
		refreshPageStateAsync_d__.__t__builder.Start<_RefreshPageStateAsync_d__10>(ref refreshPageStateAsync_d__);
		return refreshPageStateAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaVersionManagementPage()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		_client = KxOGVaFL8AQcstEY1GC.Shared;
		_Installations_k__BackingField = new ObservableCollection<WkLnWrfTRJdhyRBYcOwg>();
		InitializeComponent();
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_client);
		((ItemsControl)VersionSelector).ItemsSource = ys1lxxfFBPhowwZS5N6T.SupportedVersions;
		((Selector)VersionSelector).SelectedIndex = ((global::System.Collections.Generic.IReadOnlyCollection<ys1lxxfFBPhowwZS5N6T>)ys1lxxfFBPhowwZS5N6T.SupportedVersions).Count - 1;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(JavaVersionManagementPage_Loaded);
		_client.SessionChanged += new EventHandler(Client_SessionChanged);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void JavaVersionManagementPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_JavaVersionManagementPage_Loaded_d__19 javaVersionManagementPage_Loaded_d__ = default(_JavaVersionManagementPage_Loaded_d__19);
		javaVersionManagementPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		javaVersionManagementPage_Loaded_d__.__4__this = this;
		javaVersionManagementPage_Loaded_d__.__1__state = -1;
		javaVersionManagementPage_Loaded_d__.__t__builder.Start<_JavaVersionManagementPage_Loaded_d__19>(ref javaVersionManagementPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Client_SessionChanged(object? sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () =>
		{
			RefreshStatus();
			SetControlsEnabled(_operation == null);
		}));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshPageButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshPageButton_Click_d__21 refreshPageButton_Click_d__ = default(_RefreshPageButton_Click_d__21);
		refreshPageButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshPageButton_Click_d__.__4__this = this;
		refreshPageButton_Click_d__.__1__state = -1;
		refreshPageButton_Click_d__.__t__builder.Start<_RefreshPageButton_Click_d__21>(ref refreshPageButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VersionSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		object selectedItem = ((Selector)VersionSelector).SelectedItem;
		ys1lxxfFBPhowwZS5N6T val = (ys1lxxfFBPhowwZS5N6T)((selectedItem is ys1lxxfFBPhowwZS5N6T) ? selectedItem : null);
		if (val != null)
		{
			TaskTitleText.Text = "Java " + val.Name;
			TaskStatusText.Text = "可安装或校验修复该版本的客户端与匹配运行时";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseRootButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseRootButton_Click_d__23 chooseRootButton_Click_d__ = default(_ChooseRootButton_Click_d__23);
		chooseRootButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseRootButton_Click_d__.__4__this = this;
		chooseRootButton_Click_d__.__1__state = -1;
		chooseRootButton_Click_d__.__t__builder.Start<_ChooseRootButton_Click_d__23>(ref chooseRootButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void InstallButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InstallButton_Click_d__24 installButton_Click_d__ = default(_InstallButton_Click_d__24);
		installButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		installButton_Click_d__.__4__this = this;
		installButton_Click_d__.__1__state = -1;
		installButton_Click_d__.__t__builder.Start<_InstallButton_Click_d__24>(ref installButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void InstallVersionButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InstallVersionButton_Click_d__25 installVersionButton_Click_d__ = default(_InstallVersionButton_Click_d__25);
		installVersionButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		installVersionButton_Click_d__.__4__this = this;
		installVersionButton_Click_d__.sender = sender;
		installVersionButton_Click_d__.__1__state = -1;
		installVersionButton_Click_d__.__t__builder.Start<_InstallVersionButton_Click_d__25>(ref installVersionButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task InstallVersionAsync(ys1lxxfFBPhowwZS5N6T version)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InstallVersionAsync_d__26 installVersionAsync_d__ = default(_InstallVersionAsync_d__26);
		installVersionAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		installVersionAsync_d__.__4__this = this;
		installVersionAsync_d__.version = version;
		installVersionAsync_d__.__1__state = -1;
		installVersionAsync_d__.__t__builder.Start<_InstallVersionAsync_d__26>(ref installVersionAsync_d__);
		return installVersionAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelOperationButton_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			CancellationTokenSource? operation = _operation;
			if (operation != null)
			{
				operation.Cancel();
			}
			TaskStatusText.Text = "正在取消任务，请稍候";
		}
		catch (ObjectDisposedException)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RetryOperationButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RetryOperationButton_Click_d__28 retryOperationButton_Click_d__ = default(_RetryOperationButton_Click_d__28);
		retryOperationButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		retryOperationButton_Click_d__.__4__this = this;
		retryOperationButton_Click_d__.__1__state = -1;
		retryOperationButton_Click_d__.__t__builder.Start<_RetryOperationButton_Click_d__28>(ref retryOperationButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshStatus()
	{
		mqa4AHfxRx59lAWQN6re val = _client.eqFF7QhTqP();
		RootPathBox.Text = val.RootPath;
		InstallDescriptionText.Text = val.Description;
		BaseStatusText.Text = "基础文件 " + State(val.BaseClientInstalled);
		Java7StatusText.Text = "JRE 7 " + State(val.Java7Installed);
		Java8StatusText.Text = "JRE 8 " + State(val.Java8Installed);
		Java17StatusText.Text = "JRE 17 " + State(val.Java17Installed);
		Java21StatusText.Text = "JRE 21 " + State(val.Java21Installed);
		((UIElement)SessionHintText).Visibility = ((_client.CurrentSession != null) ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetControlsEnabled(bool enabled)
	{
		((Control)RefreshPageButton).IsEnabled = enabled;
		((Control)VersionSelector).IsEnabled = enabled;
		((Control)VersionList).IsEnabled = enabled && _client.CurrentSession != null;
		((Control)InstallButton).IsEnabled = enabled && _client.CurrentSession != null;
		((Control)CancelOperationButton).IsEnabled = !enabled;
		((Control)QuickValidateButton).IsEnabled = enabled;
		((Control)FullValidateButton).IsEnabled = enabled;
		((Control)RepairAllButton).IsEnabled = enabled && _client.CurrentSession != null;
		((Control)CleanupCacheButton).IsEnabled = enabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string State(bool installed)
	{
		if (!installed)
		{
			return "待安装";
		}
		return "已就绪";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatBytes(long bytes)
	{
		if (!((double)bytes >= 1073741824.0))
		{
			if (!((double)bytes >= 1048576.0))
			{
				return ((double)bytes / 1024.0).ToString("0.##", (IFormatProvider)(object)CultureInfo.InvariantCulture) + " KB";
			}
			return ((double)bytes / 1048576.0).ToString("0.##", (IFormatProvider)(object)CultureInfo.InvariantCulture) + " MB";
		}
		return ((double)bytes / 1073741824.0).ToString("0.##", (IFormatProvider)(object)CultureInfo.InvariantCulture) + " GB";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatDuration(TimeSpan duration)
	{
		if (!(duration.TotalHours >= 1.0))
		{
			return duration.ToString("m\\:ss", (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}
		return duration.ToString("h\\:mm\\:ss", (IFormatProvider)(object)CultureInfo.InvariantCulture);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (_disposed)
		{
			return;
		}
		_disposed = true;
		((FrameworkElement)this).Loaded -= new RoutedEventHandler(JavaVersionManagementPage_Loaded);
		_client.SessionChanged -= new EventHandler(Client_SessionChanged);
		try
		{
			CancellationTokenSource? operation = _operation;
			if (operation != null)
			{
				operation.Cancel();
			}
		}
		catch (ObjectDisposedException)
		{
		}
		CancellationTokenSource? operation2 = _operation;
		if (operation2 != null)
		{
			operation2.Dispose();
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
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaVersionManagementPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			VersionList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			VersionEmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			VersionListProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 5:
			VersionEmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			VersionEmptyDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 9:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(InstallVersionButton_Click);
			break;
		case 16:
			ResourceProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 17:
			QuickValidateButton = CastExtensions.As<Button>(target);
			((ButtonBase)QuickValidateButton).Click += new RoutedEventHandler(QuickValidateButton_Click);
			break;
		case 18:
			FullValidateButton = CastExtensions.As<Button>(target);
			((ButtonBase)FullValidateButton).Click += new RoutedEventHandler(FullValidateButton_Click);
			break;
		case 19:
			RepairAllButton = CastExtensions.As<Button>(target);
			((ButtonBase)RepairAllButton).Click += new RoutedEventHandler(RepairAllButton_Click);
			break;
		case 20:
			CleanupCacheButton = CastExtensions.As<Button>(target);
			((ButtonBase)CleanupCacheButton).Click += new RoutedEventHandler(CleanupCacheButton_Click);
			break;
		case 21:
			RefreshResourcesButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshResourcesButton).Click += new RoutedEventHandler(RefreshResourcesButton_Click);
			break;
		case 22:
			ResourceStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 23:
			TaskProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 24:
			SessionHintText = CastExtensions.As<TextBlock>(target);
			break;
		case 25:
			AuthenticationStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 26:
			Java21StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 27:
			Java17StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 28:
			Java8StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 29:
			Java7StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 30:
			BaseStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 31:
			RootPathBox = CastExtensions.As<TextBox>(target);
			break;
		case 32:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ChooseRootButton_Click);
			break;
		case 33:
			TaskProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 34:
			TaskPercentText = CastExtensions.As<TextBlock>(target);
			break;
		case 35:
			TaskTitleText = CastExtensions.As<TextBlock>(target);
			break;
		case 36:
			TaskStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 37:
			TaskCurrentFileText = CastExtensions.As<TextBlock>(target);
			break;
		case 38:
			VersionSelector = CastExtensions.As<ComboBox>(target);
			((Selector)VersionSelector).SelectionChanged += new SelectionChangedEventHandler(VersionSelector_SelectionChanged);
			break;
		case 39:
			InstallButton = CastExtensions.As<Button>(target);
			((ButtonBase)InstallButton).Click += new RoutedEventHandler(InstallButton_Click);
			break;
		case 40:
			CancelOperationButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelOperationButton).Click += new RoutedEventHandler(CancelOperationButton_Click);
			break;
		case 41:
			RetryOperationButton = CastExtensions.As<Button>(target);
			((ButtonBase)RetryOperationButton).Click += new RoutedEventHandler(RetryOperationButton_Click);
			break;
		case 42:
			InstallDescriptionText = CastExtensions.As<TextBlock>(target);
			break;
		case 43:
			RefreshPageButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshPageButton).Click += new RoutedEventHandler(RefreshPageButton_Click);
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
			Page val2 = (Page)target;
			JavaVersionManagementPage_obj1_Bindings javaVersionManagementPage_obj1_Bindings = (JavaVersionManagementPage_obj1_Bindings)new JavaVersionManagementPage_obj1_Bindings();
			result = (IComponentConnector)(object)javaVersionManagementPage_obj1_Bindings;
			javaVersionManagementPage_obj1_Bindings.SetDataRoot(this);
			Bindings = javaVersionManagementPage_obj1_Bindings;
			((FrameworkElement)val2).Loading += javaVersionManagementPage_obj1_Bindings.Loading;
			break;
		}
		case 8:
		{
			Grid val = (Grid)target;
			JavaVersionManagementPage_obj8_Bindings javaVersionManagementPage_obj8_Bindings = (JavaVersionManagementPage_obj8_Bindings)new JavaVersionManagementPage_obj8_Bindings();
			result = (IComponentConnector)(object)javaVersionManagementPage_obj8_Bindings;
			javaVersionManagementPage_obj8_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += javaVersionManagementPage_obj8_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)javaVersionManagementPage_obj8_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)javaVersionManagementPage_obj8_Bindings);
			break;
		}
		}
		return result = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<string> _RepairAllResourcesAsync_b__5_0(IProgress<pqWRiwfFbLTQvJu9JjbG> progress, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		JAWVYgfF3C6jngi7m3yp val = await _client.Ab7syBue1G(progress, cancellationToken);
		return $"修复完成：检查 {val.CheckedUnits} 个单元，修复 {val.RepairedUnits} 个，跳过 {val.SkippedUnits} 个";
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private async global::System.Threading.Tasks.Task<string> _CleanupCacheAsync_b__7_0(IProgress<pqWRiwfFbLTQvJu9JjbG> _, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return "缓存清理完成，当前占用 " + FormatBytes((await _client.FpHsJ4hEEn(cancellationToken)).TotalBytes);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void _Client_SessionChanged_b__20_0()
	{
		RefreshStatus();
		SetControlsEnabled(_operation == null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

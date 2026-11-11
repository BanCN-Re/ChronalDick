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
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using HN5yyEfpz8TLMVS2CfPf;
using LoJqk4XOcTiaec2Tj2e5;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.Storage.Pickers;
using SGLutIO07VZ7bawO9WX;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Storage;
using Windows.System;
using a7SGhofapyfcs667hqvi;
using aeBigbfujSeXw46tqPFb;
using bUfedyCg1PBqhqIkB8r;
using bVpm9ofaNkQaQ1BfGtjU;
using i6TlJMfuChv2AjPXr7O8;
using knGiRcfu9DhbMgArQGtn;
using q6cFd2fu1TbUdv8pP4I2;
using qS8vkpL43FlTMgcj0rgs;
using r7Ie1ifM7owYurGstPtD;
using wA5dHmfMOZ8Gget4VdMo;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockVersionManagementPage : Page, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockVersionManagementPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockVersionManagementPage_BindingsScopeConnector
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

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class BedrockVersionManagementPage_obj37_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockVersionManagementPage_Bindings
	{
		private NK1xXqfMtdg5sbI362F8 dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj37;

		private FontIcon obj38;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockVersionManagementPage_obj37_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			switch (connectionId)
			{
			case 37:
				obj37 = new WeakReference((object)CastExtensions.As<StackPanel>(target));
				break;
			case 38:
				obj38 = CastExtensions.As<FontIcon>(target);
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
			nextPhase = 0;
			removedDataContextHandler = true;
			object target = obj37.Target;
			StackPanel val = (StackPanel)((target is StackPanel) ? target : null);
			if (val != (StackPanel)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<NK1xXqfMtdg5sbI362F8>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<NK1xXqfMtdg5sbI362F8>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(NK1xXqfMtdg5sbI362F8 obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_IsInstalled(obj.IsInstalled, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IsInstalled(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				Update_IsInstalled_Cast_IsInstalled_To_Visibility(((!obj) ? Visibility.Visible : Visibility.Collapsed), phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IsInstalled_Cast_IsInstalled_To_Visibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj38, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __InstallButton_Click_b__31_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public IProgress<TNGLHufuZJeliMhnBLZ9> progress;

		public CancellationToken token;

		private TaskAwaiter<xssD3cfpnxdefR05FuDD> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter<xssD3cfpnxdefR05FuDD> _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockVersionManagementPage._clientService.EskX6vWsWDp(progress, token).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<xssD3cfpnxdefR05FuDD>, __InstallButton_Click_b__31_0_d>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<xssD3cfpnxdefR05FuDD>);
					num = (__1__state = -1);
				}
				xssD3cfpnxdefR05FuDD result = _u__.GetResult();
				AppShell.Success("客户端版本已安装并设为当前", result.InstallationPath);
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
	private struct __StandaloneLaunchButton_Click_b__32_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public IProgress<TNGLHufuZJeliMhnBLZ9> progress;

		public CancellationToken token;

		private TaskAwaiter<int> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter<int> _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockVersionManagementPage._clientService.Et8X6zrhmbu(progress, token).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, __StandaloneLaunchButton_Click_b__32_0_d>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<int>);
					num = (__1__state = -1);
				}
				int result = _u__.GetResult();
				AppShell.Success($"基岩版客户端已启动，PID {result}");
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

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_2
	{
		public static readonly __c_2 __9;

		public static Func<wSe3XtfuacgO0nXuwqHe, bool> __9__16_0;

		public static Func<wSe3XtfuacgO0nXuwqHe, uY2l6VfMmfM34jZlW4GQ> __9__16_1;

		public static Func<wSe3XtfuacgO0nXuwqHe, bool> __9__16_2;

		public static Func<wSe3XtfuacgO0nXuwqHe, string> __9__16_3;

		public static Func<uY2l6VfMmfM34jZlW4GQ, string> __9__16_4;

		public static Func<IGrouping<string, uY2l6VfMmfM34jZlW4GQ>, uY2l6VfMmfM34jZlW4GQ> __9__16_5;

		public static Func<wSe3XtfuacgO0nXuwqHe, bool> __9__19_0;

		public static Func<BedrockVersionEntryViewModel, bool> __9__20_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_2()
		{
			__9 = (__c_2)new __c_2();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _LoadVersionSelectorAsync_b__16_0(wSe3XtfuacgO0nXuwqHe item)
		{
			if (item.IsHealthy && !item.IsRegisteredClient)
			{
				return item.IsCurrentLocation;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal uY2l6VfMmfM34jZlW4GQ _LoadVersionSelectorAsync_b__16_1(wSe3XtfuacgO0nXuwqHe item)
		{
			return uY2l6VfMmfM34jZlW4GQ.AbGfMAKkuHk(item.Installation.Version, item.Installation.ExecutablePath);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _LoadVersionSelectorAsync_b__16_2(wSe3XtfuacgO0nXuwqHe item)
		{
			if (item.IsHealthy && !item.IsRegisteredClient)
			{
				return item.IsCurrentLocation;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _LoadVersionSelectorAsync_b__16_3(wSe3XtfuacgO0nXuwqHe item)
		{
			return item.Installation.Version;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _LoadVersionSelectorAsync_b__16_4(uY2l6VfMmfM34jZlW4GQ package)
		{
			return package.Version;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal uY2l6VfMmfM34jZlW4GQ _LoadVersionSelectorAsync_b__16_5(IGrouping<string, uY2l6VfMmfM34jZlW4GQ> group)
		{
			return Enumerable.First<uY2l6VfMmfM34jZlW4GQ>((global::System.Collections.Generic.IEnumerable<uY2l6VfMmfM34jZlW4GQ>)group);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _BindLocalState_b__19_0(wSe3XtfuacgO0nXuwqHe item)
		{
			return item.IsCorrupt;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _PruneMissingVersionEntries_b__20_0(BedrockVersionEntryViewModel entry)
		{
			return Directory.Exists(entry.InstallationPath);
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass16_0
	{
		public HashSet<string> installedVersions;

		public string previousVersion;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass16_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal NK1xXqfMtdg5sbI362F8 _LoadVersionSelectorAsync_b__6(uY2l6VfMmfM34jZlW4GQ package)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			return new NK1xXqfMtdg5sbI362F8(package, installedVersions.Contains(package.Version));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _LoadVersionSelectorAsync_b__7(NK1xXqfMtdg5sbI362F8 option)
		{
			return string.Equals(option.Version, previousVersion, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass18_0
	{
		public string selectedCustomPath;

		public BedrockVersionManagementPage __4__this;

		public string selectedVersion;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal BedrockVersionEntryViewModel _BindLocalInstallations_b__0(wSe3XtfuacgO0nXuwqHe entry)
		{
			bool isSelected = ((!entry.IsRegisteredClient) ? (!__4__this._clientService.UsesCustomClient && entry.IsCurrentLocation && string.Equals(entry.Installation.Version, selectedVersion, (StringComparison)5)) : (!string.IsNullOrWhiteSpace(selectedCustomPath) && PathsEqual(entry.Installation.InstallationPath, selectedCustomPath)));
			svXO9wfaM98XKNvcsrMd renderEngine = (entry.IsCorrupt ? null : __4__this._clientService.PjPX6hTM9ak(entry.Installation));
			return (BedrockVersionEntryViewModel)new BedrockVersionEntryViewModel(entry, isSelected, renderEngine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass21_0
	{
		public string sourceTag;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass21_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshSourceState_b__0(ComboBoxItem item)
		{
			return string.Equals(((FrameworkElement)item).Tag?.ToString(), sourceTag, (StringComparison)4);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass23_0
	{
		public string current;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass23_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshCustomClientDirectoryList_b__0(string path)
		{
			return PathsEqual(path, current);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass37_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __HandleCorruptVersionAsync_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass37_0 __4__this;

			public IProgress<TNGLHufuZJeliMhnBLZ9> progress;

			public CancellationToken token;

			private TaskAwaiter<xssD3cfpnxdefR05FuDD> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass37_0 _c__DisplayClass37_ = __4__this;
				try
				{
					TaskAwaiter<xssD3cfpnxdefR05FuDD> _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass37_.__4__this._clientService.gUdX6ELM7Og(_c__DisplayClass37_.item.Entry, progress, token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<xssD3cfpnxdefR05FuDD>, __HandleCorruptVersionAsync_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<xssD3cfpnxdefR05FuDD>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
					AppShell.Success("客户端版本 " + _c__DisplayClass37_.item.Version + " 已修复");
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

		public BedrockVersionManagementPage __4__this;

		public BedrockVersionEntryViewModel item;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass37_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _HandleCorruptVersionAsync_b__0(IProgress<TNGLHufuZJeliMhnBLZ9> progress, CancellationToken token)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			__HandleCorruptVersionAsync_b__0_d _HandleCorruptVersionAsync_b__0_d = default(__HandleCorruptVersionAsync_b__0_d);
			_HandleCorruptVersionAsync_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_HandleCorruptVersionAsync_b__0_d.__4__this = this;
			_HandleCorruptVersionAsync_b__0_d.progress = progress;
			_HandleCorruptVersionAsync_b__0_d.token = token;
			_HandleCorruptVersionAsync_b__0_d.__1__state = -1;
			_HandleCorruptVersionAsync_b__0_d.__t__builder.Start<__HandleCorruptVersionAsync_b__0_d>(ref _HandleCorruptVersionAsync_b__0_d);
			return _HandleCorruptVersionAsync_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass39_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __DeleteEntryAsync_b__1_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass39_0 __4__this;

			public CancellationToken token;

			private TaskAwaiter __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass39_0 _c__DisplayClass39_ = __4__this;
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = _c__DisplayClass39_.__4__this._clientService.EE5X66iHJN1(_c__DisplayClass39_.item.Entry, token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __DeleteEntryAsync_b__1_d>(ref _u__, ref this);
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
					if (_c__DisplayClass39_.item.IsRegisteredClient)
					{
						AppShell.Success("已移除本机客户端登记，本地文件未删除");
					}
					else
					{
						AppShell.Success("已删除客户端版本 " + _c__DisplayClass39_.item.Version);
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

		public BedrockVersionEntryViewModel item;

		public BedrockVersionManagementPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass39_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _DeleteEntryAsync_b__0(zG6ueUfuQUk6CEmxLYji instance)
		{
			return string.Equals(instance.InstallationPath, item.InstallationPath, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _DeleteEntryAsync_b__1(IProgress<TNGLHufuZJeliMhnBLZ9> _, CancellationToken token)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			__DeleteEntryAsync_b__1_d _DeleteEntryAsync_b__1_d = default(__DeleteEntryAsync_b__1_d);
			_DeleteEntryAsync_b__1_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_DeleteEntryAsync_b__1_d.__4__this = this;
			_DeleteEntryAsync_b__1_d.token = token;
			_DeleteEntryAsync_b__1_d.__1__state = -1;
			_DeleteEntryAsync_b__1_d.__t__builder.Start<__DeleteEntryAsync_b__1_d>(ref _DeleteEntryAsync_b__1_d);
			return _DeleteEntryAsync_b__1_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BedrockVersionManagementPage_Loaded_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
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
					bedrockVersionManagementPage.PruneMissingVersionEntries();
					bedrockVersionManagementPage._localStateTimer.Start();
					_u__2 = BedrockAccessGuard.EnsureAsync().GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _BedrockVersionManagementPage_Loaded_d__11>(ref _u__2, ref this);
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
					_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BedrockVersionManagementPage_Loaded_d__11>(ref _u__, ref this);
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
	private struct _ChooseCustomClientButton_Click_d__28 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

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
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_0093;
					}
					_u__ = DesktopFilePicker.PickFolderAsync(AppShell.WindowHandle, (PickerLocationId)1, "选择本机客户端目录").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseCustomClientButton_Click_d__28>(ref _u__, ref this);
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
					goto IL_0093;
				}
				goto end_IL_0011;
				IL_0093:
					result = default;
				try
				{
					TaskAwaiter _u__2 = default;
					if (num != 1)
					{
						bedrockVersionManagementPage._clientService.JnAX6F2IJZI(result);
						AppShell.Success("本机客户端目录已添加并设为当前");
						_u__2 = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ChooseCustomClientButton_Click_d__28>(ref _u__2, ref this);
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
				}
				catch (global::System.Exception exception)
				{
					bedrockVersionManagementPage.CustomClientStatusText.Text = AppShell.GetExceptionDisplayMessage(exception, "ChooseCustomClientButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 474);
					AppShell.Error(bedrockVersionManagementPage.CustomClientStatusText.Text);
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
	private struct _ChooseManagedClientRootButton_Click_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
					goto IL_008f;
				}
				if (num == 1)
				{
					goto IL_00a3;
				}
				if (!bedrockVersionManagementPage._operationRunning)
				{
					_u__ = DesktopFilePicker.PickFolderAsync(AppShell.WindowHandle, (PickerLocationId)1, "选择客户端存储位置").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _ChooseManagedClientRootButton_Click_d__26>(ref _u__, ref this);
						return;
					}
					goto IL_008f;
				}
				goto end_IL_0011;
				IL_00a3:
				string result = default(string);
				try
				{
					TaskAwaiter _u__2 = default;
					if (num != 1)
					{
						string text = bedrockVersionManagementPage._clientService.wjcX6egsFM6(result);
						AppShell.Success("客户端存储位置已更改", "后续下载和安装将保存到 " + text + "，旧目录中的版本不会被删除");
						_u__2 = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: true).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ChooseManagedClientRootButton_Click_d__26>(ref _u__2, ref this);
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
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ChooseManagedClientRootButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 432));
				}
				goto end_IL_0011;
				IL_008f:
				result = _u__.GetResult();
				if (result != null)
				{
					goto IL_00a3;
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
	private struct _ClientSourceSelector_SelectionChanged_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0105;
				}
				if (num == 1)
				{
					goto IL_0132;
				}
				string text = default(string);
				if (!bedrockVersionManagementPage._suppressSourceSelection)
				{
					object selectedItem = ((Selector)bedrockVersionManagementPage.ClientSourceSelector).SelectedItem;
					ComboBoxItem val = (ComboBoxItem)((selectedItem is ComboBoxItem) ? selectedItem : null);
					if (val != null)
					{
						bool flag = string.Equals(((FrameworkElement)val).Tag?.ToString(), "custom", (StringComparison)4);
						((UIElement)bedrockVersionManagementPage.ManagedClientRootPanel).Visibility = ((flag ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
						((UIElement)bedrockVersionManagementPage.CustomClientPanel).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
						if (!flag)
						{
							bedrockVersionManagementPage._clientService.xxCX6NtJpnd();
							_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ClientSourceSelector_SelectionChanged_d__24>(ref _u__, ref this);
								return;
							}
							goto IL_0105;
						}
						bedrockVersionManagementPage.RefreshCustomClientDirectoryList(selectCurrent: true);
						text = ((Selector)bedrockVersionManagementPage.CustomClientDirectorySelector).SelectedItem as string;
						if (text != null)
						{
							goto IL_0132;
						}
						bedrockVersionManagementPage.CustomClientStatusText.Text = "请添加或选择一个包含 Minecraft.Windows.exe 的完整客户端目录。";
						bedrockVersionManagementPage.SetOperationState(isRunning: false, "等待选择已有客户端");
					}
				}
				goto end_IL_0011;
				IL_0105:
				_u__.GetResult();
				goto end_IL_0011;
				IL_0132:
					text = default;
				try
				{
					if (num != 1)
					{
						bedrockVersionManagementPage._clientService.DqPX6sYxNe5(text);
						_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ClientSourceSelector_SelectionChanged_d__24>(ref _u__, ref this);
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
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ClientSourceSelector_SelectionChanged", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 375));
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
	private struct _ClientVersionSelector_SelectionChanged_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00de;
				}
				if (!bedrockVersionManagementPage._suppressVersionSelection)
				{
					object selectedItem = ((Selector)bedrockVersionManagementPage.ClientVersionSelector).SelectedItem;
					NK1xXqfMtdg5sbI362F8 val = (NK1xXqfMtdg5sbI362F8)((selectedItem is NK1xXqfMtdg5sbI362F8) ? selectedItem : null);
					if (val != null)
					{
						bedrockVersionManagementPage._clientService.xxCX6NtJpnd();
						if (WZy1TmXOSFudeLaMeIEs.vogXOI7ggkX(val.Package))
						{
							bedrockVersionManagementPage._clientService.KVlX6pbNkht(val.Package);
						}
						else
						{
							bedrockVersionManagementPage._clientService.NnnX6uo0RvB(val.Package);
						}
						bedrockVersionManagementPage.RefreshSourceState();
						_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ClientVersionSelector_SelectionChanged_d__25>(ref _u__, ref this);
							return;
						}
						goto IL_00de;
					}
				}
				goto end_IL_0011;
				IL_00de:
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
	private struct _CustomClientDirectorySelector_SelectionChanged_d__29 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_003f;
				}
				string text = default(string);
				if (!bedrockVersionManagementPage._suppressCustomSelection)
				{
					text = ((Selector)bedrockVersionManagementPage.CustomClientDirectorySelector).SelectedItem as string;
					if (text != null)
					{
						goto IL_003f;
					}
				}
				goto end_IL_0011;
				IL_003f:
					text = default;
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						bedrockVersionManagementPage._clientService.DqPX6sYxNe5(text);
						_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CustomClientDirectorySelector_SelectionChanged_d__29>(ref _u__, ref this);
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
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "CustomClientDirectorySelector_SelectionChanged", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 494));
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
	private struct _DeleteButton_Click_d__38 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_009e;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0100;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null && ((ButtonBase)val).CommandParameter is BedrockVersionEntryViewModel item)
				{
					_u__ = bedrockVersionManagementPage.DeleteEntryAsync(item, skipConfirmation: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _DeleteButton_Click_d__38>(ref _u__, ref this);
						return;
					}
					goto IL_009e;
				}
				goto end_IL_0011;
				IL_009e:
				_u__.GetResult();
				_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _DeleteButton_Click_d__38>(ref _u__, ref this);
					return;
				}
				goto IL_0100;
				IL_0100:
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
	private struct _DeleteEntryAsync_d__39 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockVersionEntryViewModel item;

		public BedrockVersionManagementPage __4__this;

		public bool skipConfirmation;

		private __c__DisplayClass39_0 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_017f;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0234;
				}
				__8__1 = (__c__DisplayClass39_0)new __c__DisplayClass39_0();
				__8__1.item = item;
				__8__1.__4__this = __4__this;
				if (!bedrockVersionManagementPage._operationRunning)
				{
					if (!Enumerable.Any<zG6ueUfuQUk6CEmxLYji>((global::System.Collections.Generic.IEnumerable<zG6ueUfuQUk6CEmxLYji>)bedrockVersionManagementPage._clientService.fqaX64xovpi(), (Func<zG6ueUfuQUk6CEmxLYji, bool>)__8__1._DeleteEntryAsync_b__0))
					{
						if (!skipConfirmation)
						{
							string title = (__8__1.item.IsRegisteredClient ? "移除本机客户端登记" : "删除客户端版本");
							string message = (__8__1.item.IsRegisteredClient ? ("确定从列表移除 " + __8__1.item.InstallationPath + " 吗？本地文件不会被删除。") : ("确定删除版本 " + __8__1.item.Version + " 吗？删除后需要重新安装才能使用，已下载的安装包缓存会保留。"));
							_u__ = AppShell.ConfirmAsync(title, message, __8__1.item.ActionText).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _DeleteEntryAsync_d__39>(ref _u__, ref this);
								return;
							}
							goto IL_017f;
						}
						goto IL_0190;
					}
					AppShell.Error("该版本仍有正在运行的实例，请先在实例页面关闭客户端");
				}
				goto end_IL_0011;
				IL_017f:
				if (_u__.GetResult())
				{
					goto IL_0190;
				}
				goto end_IL_0011;
				IL_0234:
				_u__2.GetResult();
				goto end_IL_0011;
				IL_0190:
				_u__2 = bedrockVersionManagementPage.RunClientOperationAsync(__8__1.item.IsRegisteredClient ? "正在移除本机客户端登记" : ("正在删除版本 " + __8__1.item.Version), __8__1._DeleteEntryAsync_b__1).GetAwaiter();
				if (!_u__2.IsCompleted)
				{
					num = (__1__state = 1);
					__u__2 = _u__2;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _DeleteEntryAsync_d__39>(ref _u__2, ref this);
					return;
				}
				goto IL_0234;
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
	private struct _HandleCorruptVersionAsync_d__37 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public BedrockVersionEntryViewModel item;

		private __c__DisplayClass37_0 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__2 = default;
				TaskAwaiter _u__ = default;
				bool result = default;
				switch (num)
				{
				default:
					__8__1 = (__c__DisplayClass37_0)new __c__DisplayClass37_0();
					__8__1.__4__this = __4__this;
					__8__1.item = item;
					if (!bedrockVersionManagementPage._operationRunning && __8__1.item.IsCorrupt && !__8__1.item.IsRegisteredClient)
					{
						if (Directory.Exists(__8__1.item.InstallationPath))
						{
							_u__2 = AppShell.ConfirmAsync("发现损坏的客户端版本", $"版本 {__8__1.item.Version} 无法启动：{__8__1.item.IntegrityMessage}。选择“自动修复”将重新下载并替换损坏文件；选择“取消”会立即删除这个版本。", "自动修复").GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _HandleCorruptVersionAsync_d__37>(ref _u__2, ref this);
								return;
							}
							goto IL_017a;
						}
						bedrockVersionManagementPage.PruneMissingVersionEntries();
					}
					goto end_IL_0011;
				case 0:
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_017a;
				case 1:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_01fd;
				case 2:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0294;
				case 3:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0306;
				case 4:
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_0306:
					_u__.GetResult();
					goto IL_030d;
					IL_017a:
					result = _u__2.GetResult();
					if (!Directory.Exists(__8__1.item.InstallationPath))
					{
						bedrockVersionManagementPage.PruneMissingVersionEntries();
						_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HandleCorruptVersionAsync_d__37>(ref _u__, ref this);
							return;
						}
						goto IL_01fd;
					}
					if (result)
					{
						_u__ = bedrockVersionManagementPage.RunClientOperationAsync("正在修复版本 " + __8__1.item.Version, __8__1._HandleCorruptVersionAsync_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HandleCorruptVersionAsync_d__37>(ref _u__, ref this);
							return;
						}
						goto IL_0294;
					}
					_u__ = bedrockVersionManagementPage.DeleteEntryAsync(__8__1.item, skipConfirmation: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 3);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HandleCorruptVersionAsync_d__37>(ref _u__, ref this);
						return;
					}
					goto IL_0306;
					IL_030d:
					_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 4);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HandleCorruptVersionAsync_d__37>(ref _u__, ref this);
						return;
					}
					break;
					IL_0294:
					_u__.GetResult();
					goto IL_030d;
					IL_01fd:
					_u__.GetResult();
					goto end_IL_0011;
				}
				_u__.GetResult();
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
	private struct _InstallButton_Click_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage __8_locals7 = __4__this;
			try
			{
				TaskAwaiter<bool> _u__2 = default;
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
					_u__2 = BedrockAccessGuard.EnsureAsync(default(CancellationToken), forceRefresh: true).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _InstallButton_Click_d__31>(ref _u__2, ref this);
						return;
					}
					goto IL_0084;
				case 0:
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_0084;
				case 1:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0171;
				case 2:
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_0171:
					_u__.GetResult();
					_u__ = __8_locals7.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 2);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InstallButton_Click_d__31>(ref _u__, ref this);
						return;
					}
					break;
					IL_0084:
					if (_u__2.GetResult())
					{
						if (__8_locals7._clientService.CurrentSession == null)
						{
							AppShell.Error("请先在账号配置建立游戏会话，再下载客户端版本");
						}
						else
						{
							if (!__8_locals7._clientService.UsesCustomClient)
							{
								object selectedItem = ((Selector)__8_locals7.ClientVersionSelector).SelectedItem;
								NK1xXqfMtdg5sbI362F8 val = (NK1xXqfMtdg5sbI362F8)((selectedItem is NK1xXqfMtdg5sbI362F8) ? selectedItem : null);
								if (val != null)
								{
									__8_locals7._clientService.KVlX6pbNkht(val.Package);
									_u__ = __8_locals7.RunClientOperationAsync("正在准备版本 " + val.Version, [MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (IProgress<TNGLHufuZJeliMhnBLZ9> progress, CancellationToken token) =>
									{
										//IL_0005: Unknown result type (might be due to invalid IL or missing references)
										//IL_000a: Unknown result type (might be due to invalid IL or missing references)
										//IL_0021: Unknown result type (might be due to invalid IL or missing references)
										//IL_0022: Unknown result type (might be due to invalid IL or missing references)
										__InstallButton_Click_b__31_0_d _InstallButton_Click_b__31_0_d = default(__InstallButton_Click_b__31_0_d);
										_InstallButton_Click_b__31_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
										_InstallButton_Click_b__31_0_d.__4__this = __8_locals7;
										_InstallButton_Click_b__31_0_d.progress = progress;
										_InstallButton_Click_b__31_0_d.token = token;
										_InstallButton_Click_b__31_0_d.__1__state = -1;
										_InstallButton_Click_b__31_0_d.__t__builder.Start<__InstallButton_Click_b__31_0_d>(ref _InstallButton_Click_b__31_0_d);
										return _InstallButton_Click_b__31_0_d.__t__builder.Task;
									}).GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 1);
										__u__2 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InstallButton_Click_d__31>(ref _u__, ref this);
										return;
									}
									goto IL_0171;
								}
							}
							AppShell.Error("请选择一个可下载的 Chronal 客户端版本");
						}
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadAsync_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public bool promptForCorruptVersions;

		private CancellationTokenSource _cancellation_5__2;

		private global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe> _installed_5__3;

		private bool _localScanCompleted_5__4;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe>> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0477: Unknown result type (might be due to invalid IL or missing references)
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage __8_locals40 = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_0051;
				}
				if (!__8_locals40._disposed && !__8_locals40._operationRunning && !__8_locals40._loadingVersions)
				{
					__8_locals40._loadingVersions = true;
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0051;
				}
				goto end_IL_0011;
				IL_0051:
				try
				{
					TaskAwaiter _u__ = default;
					if ((uint)num > 1u)
					{
						if (num == 2)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_048e;
						}
						__8_locals40._operationCancellation = _cancellation_5__2;
						__8_locals40.SetOperationState(isRunning: true, "正在扫描本地客户端");
						_installed_5__3 = global::System.Array.Empty<wSe3XtfuacgO0nXuwqHe>();
						_localScanCompleted_5__4 = false;
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe>> _u__2;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_01c3;
							}
							__8_locals40.RefreshSourceState();
							__8_locals40.RefreshManagedClientRootState();
							__8_locals40.RefreshCustomClientDirectoryList(selectCurrent: true);
							((UIElement)__8_locals40.SessionHintPanel).Visibility = ((__8_locals40._clientService.CurrentSession != null) ? Visibility.Visible : Visibility.Collapsed);
							_u__2 = __8_locals40._clientService.AwZX6O78X3F(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe>>, _LoadAsync_d__15>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe>>);
							num = (__1__state = -1);
						}
						global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe> result = _u__2.GetResult();
						_installed_5__3 = result;
						_localScanCompleted_5__4 = true;
						__8_locals40.BindLocalState(_installed_5__3);
						_u__ = __8_locals40.LoadVersionSelectorAsync(_installed_5__3, _cancellation_5__2.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadAsync_d__15>(ref _u__, ref this);
							return;
						}
						goto IL_01c3;
						IL_029c:
						if (__8_locals40._clientService.UsesCustomClient)
						{
							TextBlock statusText = __8_locals40.StatusText;
							string customClientPath = __8_locals40._clientService.CustomClientPath;
							statusText.Text = ((customClientPath != null && customClientPath.Length > 0) ? ("当前使用本机客户端：" + customClientPath) : "请选择一个完整的本机客户端目录");
						}
						else
						{
							__8_locals40.StatusText.Text = ((__8_locals40._clientService.CurrentSession == null) ? "请先前往账号配置登录，登录后才能获取并下载客户端版本" : "请选择一个客户端版本");
						}
						goto end_IL_008a;
						IL_0226:
						if (__8_locals40._clientService.UsesCustomClient)
						{
							goto IL_029c;
						}
						object selectedItem = ((Selector)__8_locals40.ClientVersionSelector).SelectedItem;
						NK1xXqfMtdg5sbI362F8 val = (NK1xXqfMtdg5sbI362F8)((selectedItem is NK1xXqfMtdg5sbI362F8) ? selectedItem : null);
						if (val == null)
						{
							goto IL_029c;
						}
						__8_locals40.StatusText.Text = (val.IsInstalled ? ("已选择版本 " + val.Version + "，可直接启动或重新修复") : ("已选择版本 " + val.Version + "，点击安装后才能启动"));
						goto end_IL_008a;
						IL_01c3:
						_u__.GetResult();
						if (__8_locals40._clientService.CurrentSession != null || __8_locals40._clientService.UsesCustomClient)
						{
							goto IL_0226;
						}
						object selectedItem2 = ((Selector)__8_locals40.ClientVersionSelector).SelectedItem;
						NK1xXqfMtdg5sbI362F8 val2 = (NK1xXqfMtdg5sbI362F8)((selectedItem2 is NK1xXqfMtdg5sbI362F8) ? selectedItem2 : null);
						if (val2 == null)
						{
							goto IL_0226;
						}
						__8_locals40.StatusText.Text = "已选择已安装版本 " + val2.Version + "；获取和下载其他版本需要先前往账号配置登录";
						end_IL_008a:;
					}
					catch (OperationCanceledException)
					{
						__8_locals40.StatusText.Text = "刷新已取消";
					}
					catch (global::System.Exception exception)
					{
						if (!_localScanCompleted_5__4)
						{
							((ItemsControl)__8_locals40.VersionList).ItemsSource = null;
							((UIElement)__8_locals40.EmptyPanel).Visibility = (Visibility)0;
							__8_locals40.EmptyTitle.Text = "版本扫描失败";
						}
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "LoadAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 149);
						if (!_localScanCompleted_5__4)
						{
							__8_locals40.LocalStatusText.Text = exceptionDisplayMessage;
						}
						__8_locals40.StatusText.Text = exceptionDisplayMessage;
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							if (__8_locals40._operationCancellation == _cancellation_5__2)
							{
								__8_locals40._operationCancellation = null;
							}
							__8_locals40._loadingVersions = false;
							__8_locals40.SetOperationState(isRunning: false, __8_locals40.StatusText.Text);
						}
					}
					if (promptForCorruptVersions && __8_locals40._clientService.CurrentSession != null)
					{
						wSe3XtfuacgO0nXuwqHe val3 = Enumerable.FirstOrDefault<wSe3XtfuacgO0nXuwqHe>((global::System.Collections.Generic.IEnumerable<wSe3XtfuacgO0nXuwqHe>)_installed_5__3, (Func<wSe3XtfuacgO0nXuwqHe, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (wSe3XtfuacgO0nXuwqHe item) => item.IsCorrupt && !item.IsRegisteredClient && __8_locals40._promptedCorruptPaths.Add(item.Installation.InstallationPath)));
						if (val3 != null)
						{
							_u__ = __8_locals40.HandleCorruptVersionAsync((BedrockVersionEntryViewModel)new BedrockVersionEntryViewModel(val3, isSelected: false, (svXO9wfaM98XKNvcsrMd?)null)).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadAsync_d__15>(ref _u__, ref this);
								return;
							}
							goto IL_048e;
						}
					}
					goto end_IL_0051;
					IL_048e:
					_u__.GetResult();
					end_IL_0051:;
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
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				_installed_5__3 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
			_installed_5__3 = null;
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
	private struct _LoadVersionSelectorAsync_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public CancellationToken cancellationToken;

		public global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe> localInstallations;

		private __c__DisplayClass16_0 __8__1;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<uY2l6VfMmfM34jZlW4GQ>> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				global::System.Collections.Generic.IReadOnlyList<uY2l6VfMmfM34jZlW4GQ> readOnlyList;
				TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<uY2l6VfMmfM34jZlW4GQ>> _u__;
				if (num != 0)
				{
					__8__1 = (__c__DisplayClass16_0)new __c__DisplayClass16_0();
					__c__DisplayClass16_0 _c__DisplayClass16_ = __8__1;
					object selectedItem = ((Selector)bedrockVersionManagementPage.ClientVersionSelector).SelectedItem;
					object obj = ((selectedItem is NK1xXqfMtdg5sbI362F8) ? selectedItem : null);
					object obj2 = ((obj != null) ? ((NK1xXqfMtdg5sbI362F8)obj).Version : null);
					if (obj2 == null)
					{
						uY2l6VfMmfM34jZlW4GQ obj3 = bedrockVersionManagementPage._clientService.yQdX6RCQjO2();
						obj2 = ((obj3 != null) ? obj3.Version : null) ?? bedrockVersionManagementPage._clientService.fL9X6w1Dv6X();
					}
					_c__DisplayClass16_.previousVersion = (string)obj2;
					if (bedrockVersionManagementPage._clientService.CurrentSession == null)
					{
						readOnlyList = Enumerable.ToArray<uY2l6VfMmfM34jZlW4GQ>(Enumerable.Select<wSe3XtfuacgO0nXuwqHe, uY2l6VfMmfM34jZlW4GQ>(Enumerable.Where<wSe3XtfuacgO0nXuwqHe>((global::System.Collections.Generic.IEnumerable<wSe3XtfuacgO0nXuwqHe>)localInstallations, (Func<wSe3XtfuacgO0nXuwqHe, bool>)__c_2.__9._LoadVersionSelectorAsync_b__16_0), (Func<wSe3XtfuacgO0nXuwqHe, uY2l6VfMmfM34jZlW4GQ>)__c_2.__9._LoadVersionSelectorAsync_b__16_1));
						goto IL_0161;
					}
					_u__ = bedrockVersionManagementPage._clientService.VvxX6HvxMFS(cancellationToken).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<uY2l6VfMmfM34jZlW4GQ>>, _LoadVersionSelectorAsync_d__16>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<uY2l6VfMmfM34jZlW4GQ>>);
					num = (__1__state = -1);
				}
				readOnlyList = _u__.GetResult();
				goto IL_0161;
				IL_0161:
				__8__1.installedVersions = Enumerable.ToHashSet<string>(Enumerable.Select<wSe3XtfuacgO0nXuwqHe, string>(Enumerable.Where<wSe3XtfuacgO0nXuwqHe>((global::System.Collections.Generic.IEnumerable<wSe3XtfuacgO0nXuwqHe>)localInstallations, (Func<wSe3XtfuacgO0nXuwqHe, bool>)__c_2.__9._LoadVersionSelectorAsync_b__16_2), (Func<wSe3XtfuacgO0nXuwqHe, string>)__c_2.__9._LoadVersionSelectorAsync_b__16_3), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
				NK1xXqfMtdg5sbI362F8[] array = Enumerable.ToArray<NK1xXqfMtdg5sbI362F8>(Enumerable.Select<uY2l6VfMmfM34jZlW4GQ, NK1xXqfMtdg5sbI362F8>(Enumerable.Select<IGrouping<string, uY2l6VfMmfM34jZlW4GQ>, uY2l6VfMmfM34jZlW4GQ>(Enumerable.GroupBy<uY2l6VfMmfM34jZlW4GQ, string>((global::System.Collections.Generic.IEnumerable<uY2l6VfMmfM34jZlW4GQ>)readOnlyList, (Func<uY2l6VfMmfM34jZlW4GQ, string>)__c_2.__9._LoadVersionSelectorAsync_b__16_4, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase), (Func<IGrouping<string, uY2l6VfMmfM34jZlW4GQ>, uY2l6VfMmfM34jZlW4GQ>)__c_2.__9._LoadVersionSelectorAsync_b__16_5), (Func<uY2l6VfMmfM34jZlW4GQ, NK1xXqfMtdg5sbI362F8>)__8__1._LoadVersionSelectorAsync_b__6));
				NK1xXqfMtdg5sbI362F8 selectedItem2 = Enumerable.FirstOrDefault<NK1xXqfMtdg5sbI362F8>((global::System.Collections.Generic.IEnumerable<NK1xXqfMtdg5sbI362F8>)array, (Func<NK1xXqfMtdg5sbI362F8, bool>)__8__1._LoadVersionSelectorAsync_b__7);
				bedrockVersionManagementPage._suppressVersionSelection = true;
				((ItemsControl)bedrockVersionManagementPage.ClientVersionSelector).ItemsSource = ((array.Length == 0) ? null : array);
				((Selector)bedrockVersionManagementPage.ClientVersionSelector).SelectedItem = selectedItem2;
				bedrockVersionManagementPage.ClientVersionSelector.PlaceholderText = ((bedrockVersionManagementPage._clientService.CurrentSession == null) ? "请先登录以获取可下载版本" : "请选择要下载或启动的版本");
				bedrockVersionManagementPage._suppressVersionSelection = false;
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
	private struct _LocalStateTimer_Tick_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage __8_locals7 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00c9;
				}
				if (!__8_locals7._disposed && !__8_locals7._operationRunning && !__8_locals7._loadingVersions && ((ItemsControl)__8_locals7.VersionList).ItemsSource is global::System.Collections.Generic.IEnumerable<BedrockVersionEntryViewModel> enumerable && Enumerable.Any<BedrockVersionEntryViewModel>(enumerable, (Func<BedrockVersionEntryViewModel, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (BedrockVersionEntryViewModel entry) => __8_locals7._clientService.k9nX61tFkrs(entry.Entry))))
				{
					__8_locals7.PruneMissingVersionEntries();
					_u__ = __8_locals7.LoadAsync(promptForCorruptVersions: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LocalStateTimer_Tick_d__13>(ref _u__, ref this);
						return;
					}
					goto IL_00c9;
				}
				goto end_IL_0011;
				IL_00c9:
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
	private struct _OpenFolderButton_Click_d__40 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public BedrockVersionManagementPage __4__this;

		private BedrockVersionEntryViewModel _item_5__2;

		private object __7__wrap2;

		private int __7__wrap3;

		private TaskAwaiter __u__1;

		private TaskAwaiter<StorageFolder> __u__2;

		private TaskAwaiter<bool> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_005c;
				}
				TaskAwaiter _u__ = default;
				if (num == 3)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0281;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object commandParameter = ((ButtonBase)val).CommandParameter;
					_item_5__2 = commandParameter as BedrockVersionEntryViewModel;
					if (_item_5__2 != null)
					{
						__7__wrap3 = 0;
						goto IL_005c;
					}
				}
				goto end_IL_0011;
				IL_005c:
				try
				{
					TaskAwaiter<StorageFolder> _u__3 = default;
					TaskAwaiter<bool> _u__2 = default;
					switch (num)
					{
					default:
						if (!Directory.Exists(_item_5__2.InstallationPath))
						{
							AppShell.Warning("客户端目录已不存在，正在刷新版本列表");
							_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenFolderButton_Click_d__40>(ref _u__, ref this);
								return;
							}
							goto IL_00e8;
						}
						_u__3 = WindowsRuntimeSystemExtensions.GetAwaiter<StorageFolder>(StorageFolder.GetFolderFromPathAsync(_item_5__2.InstallationPath));
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<StorageFolder>, _OpenFolderButton_Click_d__40>(ref _u__3, ref this);
							return;
						}
						goto IL_0158;
					case 0:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00e8;
					case 1:
						_u__3 = __u__2;
						__u__2 = default(TaskAwaiter<StorageFolder>);
						num = (__1__state = -1);
						goto IL_0158;
					case 2:
						{
							_u__2 = __u__3;
							__u__3 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							break;
						}
						IL_00e8:
						_u__.GetResult();
						goto end_IL_0011;
						IL_0158:
						_u__2 = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchFolderAsync((IStorageFolder)(object)_u__3.GetResult()));
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenFolderButton_Click_d__40>(ref _u__2, ref this);
							return;
						}
						break;
					}
					if (!_u__2.GetResult())
					{
						throw new IOException("系统未能打开客户端目录");
					}
				}
				catch (global::System.Exception _7__wrap)
				{
					__7__wrap2 = _7__wrap;
					__7__wrap3 = 1;
				}
				int num2 = __7__wrap3;
				if (num2 == 1)
				{
					global::System.Exception exception = (global::System.Exception)__7__wrap2;
					if (!Directory.Exists(_item_5__2.InstallationPath))
					{
						AppShell.Warning("客户端目录已不存在，正在刷新版本列表");
						_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 3);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenFolderButton_Click_d__40>(ref _u__, ref this);
							return;
						}
						goto IL_0281;
					}
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "OpenFolderButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 793));
				}
				__7__wrap2 = null;
				goto end_IL_0011;
				IL_0281:
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
	private struct _RefreshButton_Click_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

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
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__14>(ref _u__, ref this);
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
	private struct _RemoveCustomClientButton_Click_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private string _path_5__2;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				bool flag;
				TaskAwaiter<bool> _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_00d8;
					}
					object selectedItem = ((Selector)bedrockVersionManagementPage.CustomClientDirectorySelector).SelectedItem;
					_path_5__2 = selectedItem as string;
					flag = _path_5__2 == null;
					if (flag)
					{
						goto IL_00cc;
					}
					_u__ = AppShell.ConfirmAsync("移除本机客户端登记", "确定从列表移除 " + _path_5__2 + " 吗？本地文件不会被删除。", "移除登记").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _RemoveCustomClientButton_Click_d__30>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				flag = !_u__.GetResult();
				goto IL_00cc;
				IL_00cc:
				if (!flag)
				{
					goto IL_00d8;
				}
				goto end_IL_0011;
				IL_00d8:
				try
				{
					TaskAwaiter _u__2 = default;
					if (num != 1)
					{
						bedrockVersionManagementPage._clientService.oqUX6T81yVn(_path_5__2);
						AppShell.Success("已移除本机客户端登记，本地文件未删除");
						_u__2 = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RemoveCustomClientButton_Click_d__30>(ref _u__2, ref this);
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
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "RemoveCustomClientButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 517));
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_path_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_path_5__2 = null;
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
	private struct _RepairButton_Click_d__34 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0096;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null && ((ButtonBase)val).CommandParameter is BedrockVersionEntryViewModel item)
				{
					_u__ = bedrockVersionManagementPage.HandleCorruptVersionAsync(item).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RepairButton_Click_d__34>(ref _u__, ref this);
						return;
					}
					goto IL_0096;
				}
				goto end_IL_0011;
				IL_0096:
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
	private struct _ResetManagedClientRootButton_Click_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				if (num == 0 || (!bedrockVersionManagementPage._operationRunning && !bedrockVersionManagementPage._clientService.UsesDefaultManagedClientRoot))
				{
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							string message = bedrockVersionManagementPage._clientService.WelX6PnmSjf();
							AppShell.Success("已恢复默认存储位置", message);
							_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: true).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ResetManagedClientRootButton_Click_d__27>(ref _u__, ref this);
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
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ResetManagedClientRootButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 451));
					}
				}
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
	private struct _ResetRendererButton_Click_d__36 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0177;
				}
				if (!bedrockVersionManagementPage._operationRunning)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null && ((ButtonBase)val).CommandParameter is BedrockVersionEntryViewModel { IsCorrupt: false } bedrockVersionEntryViewModel)
					{
						svXO9wfaM98XKNvcsrMd? renderEngine = bedrockVersionEntryViewModel.RenderEngine;
						if (renderEngine != null && renderEngine.UsesVersionProfile)
						{
							bool flag = false;
							try
							{
								bedrockVersionManagementPage.SetOperationState(isRunning: true, "正在恢复 " + bedrockVersionEntryViewModel.Version + " 的全局渲染配置");
								bedrockVersionManagementPage._clientService.GPFX6rtif0c(bedrockVersionEntryViewModel.Installation);
								AppShell.Success("版本 " + bedrockVersionEntryViewModel.Version + " 已恢复全局配置", "版本独立文件已停用并保留备份，后续启动不再加载重定向组件");
								flag = true;
							}
							catch (global::System.Exception exception)
							{
								AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ResetRendererButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 659));
							}
							finally
							{
								if (num < 0)
								{
									bedrockVersionManagementPage.SetOperationState(isRunning: false, flag ? "已恢复全局渲染配置" : "恢复全局配置失败");
								}
							}
							if (flag)
							{
								_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ResetRendererButton_Click_d__36>(ref _u__, ref this);
									return;
								}
								goto IL_0177;
							}
						}
					}
				}
				goto end_IL_0011;
				IL_0177:
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
	private struct _RunClientOperationAsync_d__41 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public string status;

		public Func<IProgress<TNGLHufuZJeliMhnBLZ9>, CancellationToken, global::System.Threading.Tasks.Task> operation;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0033;
				}
				if (!bedrockVersionManagementPage._operationRunning)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0033;
				}
				goto end_IL_0011;
				IL_0033:
				try
				{
					Progress<TNGLHufuZJeliMhnBLZ9> val = default(Progress<TNGLHufuZJeliMhnBLZ9>);
					if (num != 0)
					{
						bedrockVersionManagementPage._operationCancellation = _cancellation_5__2;
						bedrockVersionManagementPage.SetOperationState(isRunning: true, status);
						val = new Progress<TNGLHufuZJeliMhnBLZ9>((Action<TNGLHufuZJeliMhnBLZ9>)bedrockVersionManagementPage.UpdateProgress);
					}
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = operation.Invoke((IProgress<TNGLHufuZJeliMhnBLZ9>)(object)val, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunClientOperationAsync_d__41>(ref _u__, ref this);
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
					catch (OperationCanceledException)
					{
						bedrockVersionManagementPage.StatusText.Text = "操作已取消";
						AppShell.Warning("操作已取消");
					}
					catch (global::System.Exception exception)
					{
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "RunClientOperationAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 821);
						bedrockVersionManagementPage.StatusText.Text = exceptionDisplayMessage;
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockVersionManagementPage._operationCancellation == _cancellation_5__2)
							{
								bedrockVersionManagementPage._operationCancellation = null;
							}
							bedrockVersionManagementPage.SetOperationState(isRunning: false, bedrockVersionManagementPage.StatusText.Text);
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
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
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
	private struct _SelectButton_Click_d__33 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004c;
				}
				BedrockVersionEntryViewModel bedrockVersionEntryViewModel = default(BedrockVersionEntryViewModel);
				if (!bedrockVersionManagementPage._operationRunning)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						bedrockVersionEntryViewModel = ((ButtonBase)val).CommandParameter as BedrockVersionEntryViewModel;
						if (bedrockVersionEntryViewModel != null)
						{
							goto IL_004c;
						}
					}
				}
				goto end_IL_0011;
				IL_004c:
					bedrockVersionEntryViewModel = default;
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						bedrockVersionManagementPage._clientService.jQ9X6aZJPMK(bedrockVersionEntryViewModel.Entry);
						AppShell.Success("已将 " + bedrockVersionEntryViewModel.Version + " 设为当前启动版本");
						_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SelectButton_Click_d__33>(ref _u__, ref this);
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
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "SelectButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 586));
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
	private struct _StandaloneLaunchButton_Click_d__32 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage __8_locals6 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					if (!__8_locals6._clientService.UsesCustomClient)
					{
						object selectedItem = ((Selector)__8_locals6.ClientVersionSelector).SelectedItem;
						NK1xXqfMtdg5sbI362F8 val = (NK1xXqfMtdg5sbI362F8)((selectedItem is NK1xXqfMtdg5sbI362F8) ? selectedItem : null);
						if (val != null)
						{
							if (WZy1TmXOSFudeLaMeIEs.vogXOI7ggkX(val.Package))
							{
								__8_locals6._clientService.KVlX6pbNkht(val.Package);
							}
							else
							{
								__8_locals6._clientService.NnnX6uo0RvB(val.Package);
							}
						}
					}
					_u__ = __8_locals6.RunClientOperationAsync("正在启动已选择的本地客户端", [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] (IProgress<TNGLHufuZJeliMhnBLZ9> progress, CancellationToken token) =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						//IL_0021: Unknown result type (might be due to invalid IL or missing references)
						//IL_0022: Unknown result type (might be due to invalid IL or missing references)
						__StandaloneLaunchButton_Click_b__32_0_d _StandaloneLaunchButton_Click_b__32_0_d = default(__StandaloneLaunchButton_Click_b__32_0_d);
						_StandaloneLaunchButton_Click_b__32_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_StandaloneLaunchButton_Click_b__32_0_d.__4__this = __8_locals6;
						_StandaloneLaunchButton_Click_b__32_0_d.progress = progress;
						_StandaloneLaunchButton_Click_b__32_0_d.token = token;
						_StandaloneLaunchButton_Click_b__32_0_d.__1__state = -1;
						_StandaloneLaunchButton_Click_b__32_0_d.__t__builder.Start<__StandaloneLaunchButton_Click_b__32_0_d>(ref _StandaloneLaunchButton_Click_b__32_0_d);
						return _StandaloneLaunchButton_Click_b__32_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StandaloneLaunchButton_Click_d__32>(ref _u__, ref this);
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
	private struct _ToggleRendererButton_Click_d__35 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockVersionManagementPage __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockVersionManagementPage bedrockVersionManagementPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0191;
				}
				if (!bedrockVersionManagementPage._operationRunning)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null && ((ButtonBase)val).CommandParameter is BedrockVersionEntryViewModel { IsCorrupt: false } bedrockVersionEntryViewModel)
					{
						bool flag = false;
						try
						{
							bedrockVersionManagementPage.SetOperationState(isRunning: true, "正在切换 " + bedrockVersionEntryViewModel.Version + " 的渲染引擎");
							string text = ((bedrockVersionManagementPage._clientService.adyX6Uyi5qc(bedrockVersionEntryViewModel.Installation, bedrockVersionEntryViewModel.RendererTarget).Engine == (P0AvWCfaT2GZfGOulKXm?)0) ? "OpenGL" : "渲染龙");
							AppShell.Success("版本 " + bedrockVersionEntryViewModel.Version + " 已切换为 " + text, "该设置只会在 Chronal 启动此版本时生效，全局 options.txt 未被修改");
							flag = true;
						}
						catch (global::System.Exception exception)
						{
							AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ToggleRendererButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 624));
						}
						finally
						{
							if (num < 0)
							{
								bedrockVersionManagementPage.SetOperationState(isRunning: false, flag ? "渲染引擎已切换" : "渲染引擎切换失败");
							}
						}
						if (flag)
						{
							_u__ = bedrockVersionManagementPage.LoadAsync(promptForCorruptVersions: false).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ToggleRendererButton_Click_d__35>(ref _u__, ref this);
								return;
							}
							goto IL_0191;
						}
					}
				}
				goto end_IL_0011;
				IL_0191:
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

	private readonly da18CdX55laNMRKtM3p0 _clientService;

	private readonly HashSet<string> _promptedCorruptPaths;

	private readonly DispatcherTimer _localStateTimer;

	private CancellationTokenSource? _operationCancellation;

	private bool _operationRunning;

	private bool _loadingVersions;

	private bool _suppressSourceSelection;

	private bool _suppressVersionSelection;

	private bool _suppressCustomSelection;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView VersionList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoadingRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LocalStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel ManagedClientRootPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel CustomClientPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border SessionHintPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar InstallProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProgressBytesText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DownloadSpeedText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProgressPercentText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CustomClientStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox CustomClientDirectorySelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RemoveCustomClientButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ManagedClientRootHintText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ManagedClientRootTextBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ChooseManagedClientRootButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ResetManagedClientRootButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button InstallButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button StandaloneLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox ClientVersionSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox ClientSourceSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockVersionManagementPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockVersionManagementPage()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		_promptedCorruptPaths = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		_localStateTimer = new DispatcherTimer
		{
			Interval = TimeSpan.FromSeconds(2.0)
		};
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockVersionManagementPage_Loaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(BedrockVersionManagementPage_Unloaded);
		_localStateTimer.Tick += LocalStateTimer_Tick;
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockVersionManagementPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockVersionManagementPage_Loaded_d__11 bedrockVersionManagementPage_Loaded_d__ = default(_BedrockVersionManagementPage_Loaded_d__11);
		bedrockVersionManagementPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockVersionManagementPage_Loaded_d__.__4__this = this;
		bedrockVersionManagementPage_Loaded_d__.__1__state = -1;
		bedrockVersionManagementPage_Loaded_d__.__t__builder.Start<_BedrockVersionManagementPage_Loaded_d__11>(ref bedrockVersionManagementPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BedrockVersionManagementPage_Unloaded(object sender, RoutedEventArgs e)
	{
		_localStateTimer.Stop();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LocalStateTimer_Tick(object? sender, object e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LocalStateTimer_Tick_d__13 localStateTimer_Tick_d__ = default(_LocalStateTimer_Tick_d__13);
		localStateTimer_Tick_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		localStateTimer_Tick_d__.__4__this = this;
		localStateTimer_Tick_d__.__1__state = -1;
		localStateTimer_Tick_d__.__t__builder.Start<_LocalStateTimer_Tick_d__13>(ref localStateTimer_Tick_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__14 refreshButton_Click_d__ = default(_RefreshButton_Click_d__14);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__14>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadAsync(bool promptForCorruptVersions)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__15 loadAsync_d__ = default(_LoadAsync_d__15);
		loadAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__.__4__this = this;
		loadAsync_d__.promptForCorruptVersions = promptForCorruptVersions;
		loadAsync_d__.__1__state = -1;
		loadAsync_d__.__t__builder.Start<_LoadAsync_d__15>(ref loadAsync_d__);
		return loadAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadVersionSelectorAsync(global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe> localInstallations, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_LoadVersionSelectorAsync_d__16 loadVersionSelectorAsync_d__ = default(_LoadVersionSelectorAsync_d__16);
		loadVersionSelectorAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadVersionSelectorAsync_d__.__4__this = this;
		loadVersionSelectorAsync_d__.localInstallations = localInstallations;
		loadVersionSelectorAsync_d__.cancellationToken = cancellationToken;
		loadVersionSelectorAsync_d__.__1__state = -1;
		loadVersionSelectorAsync_d__.__t__builder.Start<_LoadVersionSelectorAsync_d__16>(ref loadVersionSelectorAsync_d__);
		return loadVersionSelectorAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void GoToAccountLoginButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("bedrock_account"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BindLocalInstallations(global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe> installed)
	{
		__c__DisplayClass18_0 __8_locals8 = (__c__DisplayClass18_0)new __c__DisplayClass18_0();
		__8_locals8.__4__this = this;
		uY2l6VfMmfM34jZlW4GQ obj = _clientService.yQdX6RCQjO2();
		__8_locals8.selectedVersion = ((obj != null) ? obj.Version : null) ?? _clientService.fL9X6w1Dv6X();
		__8_locals8.selectedCustomPath = (_clientService.UsesCustomClient ? _clientService.CustomClientPath : null);
		global::System.Collections.Generic.IEnumerable<BedrockVersionEntryViewModel> enumerable = Enumerable.Select<wSe3XtfuacgO0nXuwqHe, BedrockVersionEntryViewModel>((global::System.Collections.Generic.IEnumerable<wSe3XtfuacgO0nXuwqHe>)installed, (Func<wSe3XtfuacgO0nXuwqHe, BedrockVersionEntryViewModel>)([MethodImpl((MethodImplOptions)8)] (wSe3XtfuacgO0nXuwqHe entry) =>
		{
			bool isSelected = ((!entry.IsRegisteredClient) ? (!__8_locals8.__4__this._clientService.UsesCustomClient && entry.IsCurrentLocation && string.Equals(entry.Installation.Version, __8_locals8.selectedVersion, (StringComparison)5)) : (!string.IsNullOrWhiteSpace(__8_locals8.selectedCustomPath) && PathsEqual(entry.Installation.InstallationPath, __8_locals8.selectedCustomPath)));
			svXO9wfaM98XKNvcsrMd renderEngine = (entry.IsCorrupt ? null : __8_locals8.__4__this._clientService.PjPX6hTM9ak(entry.Installation));
			return (BedrockVersionEntryViewModel)new BedrockVersionEntryViewModel(entry, isSelected, renderEngine);
		}));
		((ItemsControl)VersionList).ItemsSource = new ObservableCollection<BedrockVersionEntryViewModel>(enumerable);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BindLocalState(global::System.Collections.Generic.IReadOnlyList<wSe3XtfuacgO0nXuwqHe> installed)
	{
		BindLocalInstallations(installed);
		int num = Enumerable.Count<wSe3XtfuacgO0nXuwqHe>((global::System.Collections.Generic.IEnumerable<wSe3XtfuacgO0nXuwqHe>)installed, (Func<wSe3XtfuacgO0nXuwqHe, bool>)([MethodImpl((MethodImplOptions)8)] (wSe3XtfuacgO0nXuwqHe item) => item.IsCorrupt));
		LocalStatusText.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<wSe3XtfuacgO0nXuwqHe>)installed).Count == 0) ? "默认位置、自定义存储位置和登记目录中均未找到客户端" : ((num == 0) ? $"共找到 {((global::System.Collections.Generic.IReadOnlyCollection<wSe3XtfuacgO0nXuwqHe>)installed).Count} 个本地客户端，文件状态正常" : $"共找到 {((global::System.Collections.Generic.IReadOnlyCollection<wSe3XtfuacgO0nXuwqHe>)installed).Count} 个本地客户端，其中 {num} 个已损坏"));
		((UIElement)EmptyPanel).Visibility = (((((global::System.Collections.Generic.IReadOnlyCollection<wSe3XtfuacgO0nXuwqHe>)installed).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		EmptyTitle.Text = "尚未安装客户端";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PruneMissingVersionEntries()
	{
		if (((ItemsControl)VersionList).ItemsSource is global::System.Collections.Generic.IEnumerable<BedrockVersionEntryViewModel> enumerable)
		{
			BedrockVersionEntryViewModel[] array = Enumerable.ToArray<BedrockVersionEntryViewModel>(enumerable);
			BedrockVersionEntryViewModel[] array2 = Enumerable.ToArray<BedrockVersionEntryViewModel>(Enumerable.Where<BedrockVersionEntryViewModel>((global::System.Collections.Generic.IEnumerable<BedrockVersionEntryViewModel>)array, (Func<BedrockVersionEntryViewModel, bool>)([MethodImpl((MethodImplOptions)8)] (BedrockVersionEntryViewModel entry) => Directory.Exists(entry.InstallationPath))));
			if (array2.Length != array.Length)
			{
				((ItemsControl)VersionList).ItemsSource = new ObservableCollection<BedrockVersionEntryViewModel>((global::System.Collections.Generic.IEnumerable<BedrockVersionEntryViewModel>)array2);
				LocalStatusText.Text = ((array2.Length == 0) ? "默认位置、自定义存储位置和登记目录中均未找到客户端" : $"共找到 {array2.Length} 个本地客户端，正在重新校验文件状态");
				((UIElement)EmptyPanel).Visibility = (((array2.Length != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
				EmptyTitle.Text = "尚未安装客户端";
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshSourceState()
	{
		__c__DisplayClass21_0 __8_locals2 = (__c__DisplayClass21_0)new __c__DisplayClass21_0();
		_suppressSourceSelection = true;
		__8_locals2.sourceTag = (_clientService.UsesCustomClient ? "custom" : "official");
		((Selector)ClientSourceSelector).SelectedItem = Enumerable.FirstOrDefault<ComboBoxItem>(Enumerable.OfType<ComboBoxItem>((global::System.Collections.IEnumerable)((ItemsControl)ClientSourceSelector).Items), (Func<ComboBoxItem, bool>)([MethodImpl((MethodImplOptions)8)] (ComboBoxItem item) => string.Equals(((FrameworkElement)item).Tag?.ToString(), __8_locals2.sourceTag, (StringComparison)4)));
		_suppressSourceSelection = false;
		((UIElement)ManagedClientRootPanel).Visibility = ((_clientService.UsesCustomClient ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)CustomClientPanel).Visibility = ((!_clientService.UsesCustomClient) ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshManagedClientRootState()
	{
		ManagedClientRootTextBox.Text = _clientService.ManagedClientRootPath;
		ManagedClientRootHintText.Text = (_clientService.UsesDefaultManagedClientRoot ? "当前使用默认位置。下载缓存和客户端版本都会保存在这里。" : "当前使用自定义位置。切换目录不会移动或删除旧版本。");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshCustomClientDirectoryList(bool selectCurrent)
	{
		__c__DisplayClass23_0 __8_locals3 = (__c__DisplayClass23_0)new __c__DisplayClass23_0();
		global::System.Collections.Generic.IReadOnlyList<string> readOnlyList = _clientService.DMyX6xY9uD9();
		__8_locals3.current = _clientService.CustomClientPath;
		_suppressCustomSelection = true;
		((ItemsControl)CustomClientDirectorySelector).ItemsSource = ((((global::System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count == 0) ? null : readOnlyList);
		((Selector)CustomClientDirectorySelector).SelectedItem = ((selectCurrent && __8_locals3.current != null) ? Enumerable.FirstOrDefault<string>((global::System.Collections.Generic.IEnumerable<string>)readOnlyList, (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string path) => PathsEqual(path, __8_locals3.current))) : null);
		_suppressCustomSelection = false;
		((Control)RemoveCustomClientButton).IsEnabled = !_operationRunning && ((Selector)CustomClientDirectorySelector).SelectedItem != null;
		CustomClientStatusText.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count == 0) ? "添加包含 Minecraft.Windows.exe 的完整客户端根目录。" : string.Empty);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ClientSourceSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ClientSourceSelector_SelectionChanged_d__24 clientSourceSelector_SelectionChanged_d__ = default(_ClientSourceSelector_SelectionChanged_d__24);
		clientSourceSelector_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		clientSourceSelector_SelectionChanged_d__.__4__this = this;
		clientSourceSelector_SelectionChanged_d__.__1__state = -1;
		clientSourceSelector_SelectionChanged_d__.__t__builder.Start<_ClientSourceSelector_SelectionChanged_d__24>(ref clientSourceSelector_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ClientVersionSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ClientVersionSelector_SelectionChanged_d__25 clientVersionSelector_SelectionChanged_d__ = default(_ClientVersionSelector_SelectionChanged_d__25);
		clientVersionSelector_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		clientVersionSelector_SelectionChanged_d__.__4__this = this;
		clientVersionSelector_SelectionChanged_d__.__1__state = -1;
		clientVersionSelector_SelectionChanged_d__.__t__builder.Start<_ClientVersionSelector_SelectionChanged_d__25>(ref clientVersionSelector_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseManagedClientRootButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseManagedClientRootButton_Click_d__26 chooseManagedClientRootButton_Click_d__ = default(_ChooseManagedClientRootButton_Click_d__26);
		chooseManagedClientRootButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseManagedClientRootButton_Click_d__.__4__this = this;
		chooseManagedClientRootButton_Click_d__.__1__state = -1;
		chooseManagedClientRootButton_Click_d__.__t__builder.Start<_ChooseManagedClientRootButton_Click_d__26>(ref chooseManagedClientRootButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ResetManagedClientRootButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ResetManagedClientRootButton_Click_d__27 resetManagedClientRootButton_Click_d__ = default(_ResetManagedClientRootButton_Click_d__27);
		resetManagedClientRootButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		resetManagedClientRootButton_Click_d__.__4__this = this;
		resetManagedClientRootButton_Click_d__.__1__state = -1;
		resetManagedClientRootButton_Click_d__.__t__builder.Start<_ResetManagedClientRootButton_Click_d__27>(ref resetManagedClientRootButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ChooseCustomClientButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChooseCustomClientButton_Click_d__28 chooseCustomClientButton_Click_d__ = default(_ChooseCustomClientButton_Click_d__28);
		chooseCustomClientButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		chooseCustomClientButton_Click_d__.__4__this = this;
		chooseCustomClientButton_Click_d__.__1__state = -1;
		chooseCustomClientButton_Click_d__.__t__builder.Start<_ChooseCustomClientButton_Click_d__28>(ref chooseCustomClientButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CustomClientDirectorySelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CustomClientDirectorySelector_SelectionChanged_d__29 customClientDirectorySelector_SelectionChanged_d__ = default(_CustomClientDirectorySelector_SelectionChanged_d__29);
		customClientDirectorySelector_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		customClientDirectorySelector_SelectionChanged_d__.__4__this = this;
		customClientDirectorySelector_SelectionChanged_d__.__1__state = -1;
		customClientDirectorySelector_SelectionChanged_d__.__t__builder.Start<_CustomClientDirectorySelector_SelectionChanged_d__29>(ref customClientDirectorySelector_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RemoveCustomClientButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RemoveCustomClientButton_Click_d__30 removeCustomClientButton_Click_d__ = default(_RemoveCustomClientButton_Click_d__30);
		removeCustomClientButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		removeCustomClientButton_Click_d__.__4__this = this;
		removeCustomClientButton_Click_d__.__1__state = -1;
		removeCustomClientButton_Click_d__.__t__builder.Start<_RemoveCustomClientButton_Click_d__30>(ref removeCustomClientButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void InstallButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InstallButton_Click_d__31 installButton_Click_d__ = default(_InstallButton_Click_d__31);
		installButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		installButton_Click_d__.__4__this = this;
		installButton_Click_d__.__1__state = -1;
		installButton_Click_d__.__t__builder.Start<_InstallButton_Click_d__31>(ref installButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void StandaloneLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StandaloneLaunchButton_Click_d__32 standaloneLaunchButton_Click_d__ = default(_StandaloneLaunchButton_Click_d__32);
		standaloneLaunchButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		standaloneLaunchButton_Click_d__.__4__this = this;
		standaloneLaunchButton_Click_d__.__1__state = -1;
		standaloneLaunchButton_Click_d__.__t__builder.Start<_StandaloneLaunchButton_Click_d__32>(ref standaloneLaunchButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SelectButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SelectButton_Click_d__33 selectButton_Click_d__ = default(_SelectButton_Click_d__33);
		selectButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		selectButton_Click_d__.__4__this = this;
		selectButton_Click_d__.sender = sender;
		selectButton_Click_d__.__1__state = -1;
		selectButton_Click_d__.__t__builder.Start<_SelectButton_Click_d__33>(ref selectButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RepairButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RepairButton_Click_d__34 repairButton_Click_d__ = default(_RepairButton_Click_d__34);
		repairButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		repairButton_Click_d__.__4__this = this;
		repairButton_Click_d__.sender = sender;
		repairButton_Click_d__.__1__state = -1;
		repairButton_Click_d__.__t__builder.Start<_RepairButton_Click_d__34>(ref repairButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ToggleRendererButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ToggleRendererButton_Click_d__35 toggleRendererButton_Click_d__ = default(_ToggleRendererButton_Click_d__35);
		toggleRendererButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		toggleRendererButton_Click_d__.__4__this = this;
		toggleRendererButton_Click_d__.sender = sender;
		toggleRendererButton_Click_d__.__1__state = -1;
		toggleRendererButton_Click_d__.__t__builder.Start<_ToggleRendererButton_Click_d__35>(ref toggleRendererButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ResetRendererButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ResetRendererButton_Click_d__36 resetRendererButton_Click_d__ = default(_ResetRendererButton_Click_d__36);
		resetRendererButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		resetRendererButton_Click_d__.__4__this = this;
		resetRendererButton_Click_d__.sender = sender;
		resetRendererButton_Click_d__.__1__state = -1;
		resetRendererButton_Click_d__.__t__builder.Start<_ResetRendererButton_Click_d__36>(ref resetRendererButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task HandleCorruptVersionAsync(BedrockVersionEntryViewModel item)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HandleCorruptVersionAsync_d__37 handleCorruptVersionAsync_d__ = default(_HandleCorruptVersionAsync_d__37);
		handleCorruptVersionAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		handleCorruptVersionAsync_d__.__4__this = this;
		handleCorruptVersionAsync_d__.item = item;
		handleCorruptVersionAsync_d__.__1__state = -1;
		handleCorruptVersionAsync_d__.__t__builder.Start<_HandleCorruptVersionAsync_d__37>(ref handleCorruptVersionAsync_d__);
		return handleCorruptVersionAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DeleteButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DeleteButton_Click_d__38 deleteButton_Click_d__ = default(_DeleteButton_Click_d__38);
		deleteButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		deleteButton_Click_d__.__4__this = this;
		deleteButton_Click_d__.sender = sender;
		deleteButton_Click_d__.__1__state = -1;
		deleteButton_Click_d__.__t__builder.Start<_DeleteButton_Click_d__38>(ref deleteButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task DeleteEntryAsync(BedrockVersionEntryViewModel item, bool skipConfirmation)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DeleteEntryAsync_d__39 deleteEntryAsync_d__ = default(_DeleteEntryAsync_d__39);
		deleteEntryAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		deleteEntryAsync_d__.__4__this = this;
		deleteEntryAsync_d__.item = item;
		deleteEntryAsync_d__.skipConfirmation = skipConfirmation;
		deleteEntryAsync_d__.__1__state = -1;
		deleteEntryAsync_d__.__t__builder.Start<_DeleteEntryAsync_d__39>(ref deleteEntryAsync_d__);
		return deleteEntryAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenFolderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenFolderButton_Click_d__40 openFolderButton_Click_d__ = default(_OpenFolderButton_Click_d__40);
		openFolderButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openFolderButton_Click_d__.__4__this = this;
		openFolderButton_Click_d__.sender = sender;
		openFolderButton_Click_d__.__1__state = -1;
		openFolderButton_Click_d__.__t__builder.Start<_OpenFolderButton_Click_d__40>(ref openFolderButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunClientOperationAsync(string status, Func<IProgress<TNGLHufuZJeliMhnBLZ9>, CancellationToken, global::System.Threading.Tasks.Task> operation)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunClientOperationAsync_d__41 runClientOperationAsync_d__ = default(_RunClientOperationAsync_d__41);
		runClientOperationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runClientOperationAsync_d__.__4__this = this;
		runClientOperationAsync_d__.status = status;
		runClientOperationAsync_d__.operation = operation;
		runClientOperationAsync_d__.__1__state = -1;
		runClientOperationAsync_d__.__t__builder.Start<_RunClientOperationAsync_d__41>(ref runClientOperationAsync_d__);
		return runClientOperationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateProgress(TNGLHufuZJeliMhnBLZ9 progress)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Invalid comparison between Unknown and I4
		double num = Math.Clamp(progress.Percent, 0.0, 100.0);
		((RangeBase)InstallProgressBar).Value = num;
		StatusText.Text = progress.Message;
		TextBlock progressBytesText = ProgressBytesText;
		long? totalBytes = progress.TotalBytes;
		bool flag = totalBytes.HasValue && totalBytes.GetValueOrDefault() > 0;
		if (flag)
		{
			OWksHlfuLC6O7fQPn0v2 stage = progress.Stage;
			bool flag2 = (int)stage - 3 <= 1;
			flag = flag2;
		}
		progressBytesText.Text = (flag ? (W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(progress.BytesProcessed) + " / " + W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(progress.TotalBytes.Value)) : string.Empty);
		DownloadSpeedText.Text = (((int)progress.Stage == 3) ? W0wBpiOcLVX0Ukx7VdU.MFpOy4Ua8e(progress.BytesPerSecond) : string.Empty);
		ProgressPercentText.Text = $"{num:0.#}%";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelButton_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? operationCancellation = _operationCancellation;
		if (operationCancellation != null)
		{
			operationCancellation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetOperationState(bool isRunning, string status)
	{
		_operationRunning = isRunning;
		((Control)RefreshButton).IsEnabled = !isRunning;
		((Control)ClientSourceSelector).IsEnabled = !isRunning;
		((Control)ClientVersionSelector).IsEnabled = !isRunning && !_clientService.UsesCustomClient && ((ItemsControl)ClientVersionSelector).Items.Count > 0;
		((Control)InstallButton).IsEnabled = !isRunning && !_clientService.UsesCustomClient && _clientService.CurrentSession != null && ((Selector)ClientVersionSelector).SelectedItem != null;
		((Control)StandaloneLaunchButton).IsEnabled = !isRunning;
		((Control)CancelButton).IsEnabled = isRunning;
		((Control)ChooseManagedClientRootButton).IsEnabled = !isRunning && !_clientService.UsesCustomClient;
		((Control)ResetManagedClientRootButton).IsEnabled = !isRunning && !_clientService.UsesCustomClient && !_clientService.UsesDefaultManagedClientRoot;
		((Control)CustomClientDirectorySelector).IsEnabled = !isRunning;
		((Control)RemoveCustomClientButton).IsEnabled = !isRunning && ((Selector)CustomClientDirectorySelector).SelectedItem != null;
		((Control)VersionList).IsEnabled = !isRunning;
		LoadingRing.IsActive = isRunning;
		((UIElement)LoadingRing).Visibility = ((!isRunning) ? Visibility.Visible : Visibility.Collapsed);
		if (!string.IsNullOrWhiteSpace(status))
		{
			StatusText.Text = status;
		}
		if (!isRunning)
		{
			DownloadSpeedText.Text = string.Empty;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool PathsEqual(string left, string right)
	{
		try
		{
			return string.Equals(Path.GetFullPath(left).TrimEnd(new char[2]
			{
				Path.DirectorySeparatorChar,
				Path.AltDirectorySeparatorChar
			}), Path.GetFullPath(right).TrimEnd(new char[2]
			{
				Path.DirectorySeparatorChar,
				Path.AltDirectorySeparatorChar
			}), (StringComparison)5);
		}
		catch (global::System.Exception ex) when (((ex is ArgumentException || ex is NotSupportedException || ex is PathTooLongException) ? 1 : 0) != 0)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "PathsEqual", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockVersionManagementPage.xaml.cs", 899);
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			_localStateTimer.Stop();
			_localStateTimer.Tick -= LocalStateTimer_Tick;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockVersionManagementPage_Loaded);
			((FrameworkElement)this).Unloaded -= new RoutedEventHandler(BedrockVersionManagementPage_Unloaded);
			CancellationTokenSource? operationCancellation = _operationCancellation;
			if (operationCancellation != null)
			{
				operationCancellation.Cancel();
			}
			CancellationTokenSource? operationCancellation2 = _operationCancellation;
			if (operationCancellation2 != null)
			{
				operationCancellation2.Dispose();
			}
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockVersionManagementPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			VersionList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RepairButton_Click);
			break;
		case 8:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(SelectButton_Click);
			break;
		case 9:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ToggleRendererButton_Click);
			break;
		case 10:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ResetRendererButton_Click);
			break;
		case 11:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenFolderButton_Click);
			break;
		case 12:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DeleteButton_Click);
			break;
		case 13:
			LoadingRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 14:
			LocalStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			ManagedClientRootPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 16:
			CustomClientPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 17:
			SessionHintPanel = CastExtensions.As<Border>(target);
			break;
		case 18:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(GoToAccountLoginButton_Click);
			break;
		case 19:
			InstallProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 20:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 21:
			ProgressBytesText = CastExtensions.As<TextBlock>(target);
			break;
		case 22:
			DownloadSpeedText = CastExtensions.As<TextBlock>(target);
			break;
		case 23:
			ProgressPercentText = CastExtensions.As<TextBlock>(target);
			break;
		case 24:
			CustomClientStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 25:
			CustomClientDirectorySelector = CastExtensions.As<ComboBox>(target);
			((Selector)CustomClientDirectorySelector).SelectionChanged += new SelectionChangedEventHandler(CustomClientDirectorySelector_SelectionChanged);
			break;
		case 26:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ChooseCustomClientButton_Click);
			break;
		case 27:
			RemoveCustomClientButton = CastExtensions.As<Button>(target);
			((ButtonBase)RemoveCustomClientButton).Click += new RoutedEventHandler(RemoveCustomClientButton_Click);
			break;
		case 28:
			ManagedClientRootHintText = CastExtensions.As<TextBlock>(target);
			break;
		case 29:
			ManagedClientRootTextBox = CastExtensions.As<TextBox>(target);
			break;
		case 30:
			ChooseManagedClientRootButton = CastExtensions.As<Button>(target);
			((ButtonBase)ChooseManagedClientRootButton).Click += new RoutedEventHandler(ChooseManagedClientRootButton_Click);
			break;
		case 31:
			ResetManagedClientRootButton = CastExtensions.As<Button>(target);
			((ButtonBase)ResetManagedClientRootButton).Click += new RoutedEventHandler(ResetManagedClientRootButton_Click);
			break;
		case 32:
			InstallButton = CastExtensions.As<Button>(target);
			((ButtonBase)InstallButton).Click += new RoutedEventHandler(InstallButton_Click);
			break;
		case 33:
			StandaloneLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)StandaloneLaunchButton).Click += new RoutedEventHandler(StandaloneLaunchButton_Click);
			break;
		case 34:
			CancelButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelButton).Click += new RoutedEventHandler(CancelButton_Click);
			break;
		case 35:
			ClientVersionSelector = CastExtensions.As<ComboBox>(target);
			((Selector)ClientVersionSelector).SelectionChanged += new SelectionChangedEventHandler(ClientVersionSelector_SelectionChanged);
			break;
		case 39:
			ClientSourceSelector = CastExtensions.As<ComboBox>(target);
			((Selector)ClientSourceSelector).SelectionChanged += new SelectionChangedEventHandler(ClientSourceSelector_SelectionChanged);
			break;
		case 40:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		IComponentConnector result = null;
		if (connectionId == 37)
		{
			StackPanel val = (StackPanel)target;
			BedrockVersionManagementPage_obj37_Bindings bedrockVersionManagementPage_obj37_Bindings = (BedrockVersionManagementPage_obj37_Bindings)new BedrockVersionManagementPage_obj37_Bindings();
			result = (IComponentConnector)(object)bedrockVersionManagementPage_obj37_Bindings;
			bedrockVersionManagementPage_obj37_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockVersionManagementPage_obj37_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockVersionManagementPage_obj37_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockVersionManagementPage_obj37_Bindings);
		}
		return result = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool _LocalStateTimer_Tick_b__13_0(BedrockVersionEntryViewModel entry)
	{
		return _clientService.k9nX61tFkrs(entry.Entry);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool _LoadAsync_b__15_0(wSe3XtfuacgO0nXuwqHe item)
	{
		if (item.IsCorrupt && !item.IsRegisteredClient)
		{
			return _promptedCorruptPaths.Add(item.Installation.InstallationPath);
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task _InstallButton_Click_b__31_0(IProgress<TNGLHufuZJeliMhnBLZ9> progress, CancellationToken token)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		__InstallButton_Click_b__31_0_d _InstallButton_Click_b__31_0_d = default(__InstallButton_Click_b__31_0_d);
		_InstallButton_Click_b__31_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_InstallButton_Click_b__31_0_d.__4__this = this;
		_InstallButton_Click_b__31_0_d.progress = progress;
		_InstallButton_Click_b__31_0_d.token = token;
		_InstallButton_Click_b__31_0_d.__1__state = -1;
		_InstallButton_Click_b__31_0_d.__t__builder.Start<__InstallButton_Click_b__31_0_d>(ref _InstallButton_Click_b__31_0_d);
		return _InstallButton_Click_b__31_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _StandaloneLaunchButton_Click_b__32_0(IProgress<TNGLHufuZJeliMhnBLZ9> progress, CancellationToken token)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		__StandaloneLaunchButton_Click_b__32_0_d _StandaloneLaunchButton_Click_b__32_0_d = default(__StandaloneLaunchButton_Click_b__32_0_d);
		_StandaloneLaunchButton_Click_b__32_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_StandaloneLaunchButton_Click_b__32_0_d.__4__this = this;
		_StandaloneLaunchButton_Click_b__32_0_d.progress = progress;
		_StandaloneLaunchButton_Click_b__32_0_d.token = token;
		_StandaloneLaunchButton_Click_b__32_0_d.__1__state = -1;
		_StandaloneLaunchButton_Click_b__32_0_d.__t__builder.Start<__StandaloneLaunchButton_Click_b__32_0_d>(ref _StandaloneLaunchButton_Click_b__32_0_d);
		return _StandaloneLaunchButton_Click_b__32_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

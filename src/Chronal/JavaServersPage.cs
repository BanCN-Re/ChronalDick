using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using GJFHuMfF9Tsu20PjaEve;
using GxkGd8NIqf0OYNxx8A9;
using IuqQinfT23xjoF4oaqQu;
using K5FCrdFj16NFnFBU3KQ;
using MO7P8ffTaQSVRaD0dASm;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls.Bedrock;
using MbG5jwfxlw0m88c0LC5O;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Navigation;
using O7oSQyfxiUTrhAE02s2Q;
using SGLutIO07VZ7bawO9WX;
using WMO32gy5EZANSQKlHAx;
using WP2chpfxfiuBSYyeOFWV;
using WSSx9lfs5tSw9PCtPx5s;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using XqoLwmfxKZ22pXoXD9rh;
using YXMjNoXcouOKeTTRMKFH;
using bUfedyCg1PBqhqIkB8r;
using bVyVYtfFgCItGPihJweI;
using c4PNM5fxD3whDVKOiLnG;
using cIxlXCXUST0hXJn4yluJ;
using cbspFOfxzNo4PxhKDFpf;
using fAXRvmNZu6fmaZ5kmc8;
using h0gZa9fFSAVM5Du5jTuE;
using lRqHE4fsJKg7jIYnaPkx;
using p0W4TyfP1bcYlLMoqU4C;
using qS8vkpL43FlTMgcj0rgs;
using sIIqaHfsvUMJoArTBa4b;
using vYmlyBfslFXKQh5C4Pa2;
using y6aXjmfNjqEa4QZsAxq8;
using zX707pfFXiAmiNASTxFS;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class JavaServersPage : Page, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IJavaServersPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IJavaServersPage_BindingsScopeConnector
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
		public static void Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(BedrockNetworkImage obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.ImageUrl = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	private class JavaServersPage_obj54_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IJavaServersPage_Bindings
	{
		private YlErsbfs35V4xTUvrlXK dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj54;

		private TextBlock obj55;

		private TextBlock obj56;

		private TextBlock obj57;

		private BedrockNetworkImage obj58;

		[MethodImpl((MethodImplOptions)8)]
		public JavaServersPage_obj54_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			switch (connectionId)
			{
			case 54:
				obj54 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 55:
				obj55 = CastExtensions.As<TextBlock>(target);
				break;
			case 56:
				obj56 = CastExtensions.As<TextBlock>(target);
				break;
			case 57:
				obj57 = CastExtensions.As<TextBlock>(target);
				break;
			case 58:
				obj58 = CastExtensions.As<BedrockNetworkImage>(target);
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
			nextPhase = 0;
			removedDataContextHandler = true;
			object target = obj54.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<YlErsbfs35V4xTUvrlXK>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<YlErsbfs35V4xTUvrlXK>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(YlErsbfs35V4xTUvrlXK obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Name(obj.Name, phase);
				Update_Summary(obj.Summary, phase);
				Update_OnlineDisplayText(obj.OnlineDisplayText, phase);
				Update_ImageUrl(obj.ImageUrl, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj55, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Summary(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj56, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_OnlineDisplayText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj57, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ImageUrl(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(obj58, obj, null);
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
	private class JavaServersPage_obj1_Bindings : IComponentConnector, IJavaServersPage_Bindings
	{
		private JavaServersPage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private GridView obj49;

		[MethodImpl((MethodImplOptions)8)]
		public JavaServersPage_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 49)
			{
				obj49 = CastExtensions.As<GridView>(target);
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
				dataRoot = CastExtensions.As<JavaServersPage>(newDataRoot);
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
		private void Update_(JavaServersPage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_Servers(obj.Servers, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Servers(ObservableCollection<YlErsbfs35V4xTUvrlXK> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj49, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_14
	{
		public static readonly __c_14 __9;

		public static Func<QTHpUQfsgtyJIMkBwTYM, bool> __9__8_0;

		public static Func<QTHpUQfsgtyJIMkBwTYM, bool> __9__8_1;

		[MethodImpl((MethodImplOptions)8)]
		static __c_14()
		{
			__9 = (__c_14)new __c_14();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_14()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _PresentRoles_b__8_0(QTHpUQfsgtyJIMkBwTYM role)
		{
			return role.IsAvailable;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _PresentRoles_b__8_1(QTHpUQfsgtyJIMkBwTYM role)
		{
			return role.IsAvailable;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass15_0_2
	{
		public r9S4FZfxG0478bdNv59r mode;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass15_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SelectLaunchMode_b__0(JavaLaunchModeOption item)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return item.Mode == mode;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateRoleButton_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private TaskAwaiter<hPcUc1fsOc8n0MyPD82d> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0048;
				}
				if (javaServersPage._selectedServer != null && javaServersPage._operation == null)
				{
					_operation_5__2 = new CancellationTokenSource();
					goto IL_0048;
				}
				AppShell.Error("请先选择服务器。下一步：从左侧目录选择一个网络服务器");
				goto end_IL_0011;
				IL_0048:
				try
				{
					if (num != 0)
					{
						javaServersPage._operation = _operation_5__2;
						javaServersPage.SetControlsEnabled(enabled: false);
						javaServersPage.RoleStatusText.Text = "正在创建并同步角色";
					}
					try
					{
						TaskAwaiter<hPcUc1fsOc8n0MyPD82d> _u__ = default;
						if (num != 0)
						{
							_u__ = javaServersPage._client.PqAFoHIelP(javaServersPage._selectedServer.Id, javaServersPage.NewRoleNameBox.Text, _operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<hPcUc1fsOc8n0MyPD82d>, _CreateRoleButton_Click_d__10>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<hPcUc1fsOc8n0MyPD82d>);
							num = (__1__state = -1);
						}
						hPcUc1fsOc8n0MyPD82d result = _u__.GetResult();
						javaServersPage.PresentRoles(result.Roles);
						((Selector)javaServersPage.RoleComboBox).SelectedItem = result.CreatedRole;
						javaServersPage.NewRoleNameBox.Text = string.Empty;
						AppShell.Success("角色 " + result.CreatedRole.Name + " 已创建并同步");
					}
					catch (OperationCanceledException)
					{
						javaServersPage.RoleStatusText.Text = "角色创建已取消，可以重新提交";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "CreateRoleButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaServersPage.Catalog.cs", 246);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "检查角色名后重试");
						javaServersPage.RoleStatusText.Text = text;
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__2)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _EstablishEntryButton_Click_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

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
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaServersPage.EstablishSelectedEntryAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _EstablishEntryButton_Click_d__16>(ref _u__, ref this);
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
	private struct _EstablishSelectedEntryAsync_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private TaskAwaiter<qC3ZV7fxXAJqu2TjY3Nc> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00ae;
				}
				vbT0RwfPa3ScEuruAINf request = default(vbT0RwfPa3ScEuruAINf);
				if (!javaServersPage.TryCreateConnectionRequest(out request))
				{
					AppShell.Error("连接条件不完整。下一步：选择服务器、版本和可用角色");
				}
				else if (javaServersPage._operation == null)
				{
					if (javaServersPage._connectionCoordinator != null)
					{
						_operation_5__2 = new CancellationTokenSource();
						goto IL_00ae;
					}
					string text = (((int)javaServersPage._selectedLaunchMode == 0) ? "当前安装尚未接入后台宿主的外部客户端启动器；为避免回退到独立认证链，本次未建立入口" : "当前安装尚未接入后台宿主的官方客户端启动器；本次未建立入口，可从兼容工具进入旧托管流程");
					javaServersPage.ResetConnectionRetry();
					javaServersPage.SetLaunchState(running: false, text, 0.0, failed: true, retryAvailable: false);
					javaServersPage.LaunchStageText.Text = JavaConnectionStatePresentation.TitleOf((T9LWLtfx944ku4NynZ2L)10);
					AppShell.Warning(text);
				}
				goto end_IL_0011;
				IL_00ae:
					request = default;
				try
				{
					if (num != 0)
					{
						javaServersPage._operation = _operation_5__2;
						javaServersPage._retryContext = JavaServerRetryContext.ForCoordinatedConnection(javaServersPage._selectedLaunchMode);
						javaServersPage.SetControlsEnabled(enabled: false);
						JavaConnectionModePresentation javaConnectionModePresentation = JavaConnectionModePresentation.For(javaServersPage._selectedLaunchMode);
						javaServersPage.PresentConnectionState((T9LWLtfx944ku4NynZ2L)0, javaConnectionModePresentation.StartingMessage, 0);
					}
					try
					{
						TaskAwaiter<qC3ZV7fxXAJqu2TjY3Nc> _u__ = default;
						if (num != 0)
						{
							javaServersPage._connectionCoordinator.V3WNlk2OMF(javaServersPage._selectedLaunchMode);
							_u__ = javaServersPage._connectionCoordinator.SAGNP8y384(request, _operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<qC3ZV7fxXAJqu2TjY3Nc>, _EstablishSelectedEntryAsync_d__17>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<qC3ZV7fxXAJqu2TjY3Nc>);
							num = (__1__state = -1);
						}
						qC3ZV7fxXAJqu2TjY3Nc result = _u__.GetResult();
						javaServersPage.PresentConnectionSnapshot(result);
					}
					catch (OperationCanceledException)
					{
						javaServersPage.ResetConnectionRetry();
						javaServersPage.PresentConnectionState((T9LWLtfx944ku4NynZ2L)8, "连接入口建立已取消", 0);
						AppShell.Warning("Java 连接入口建立已取消");
					}
					catch (global::System.Exception ex2)
					{
						gX17swyO7x0JWQxdaD1.TyQywPUFFh("java-connection", "Java 本机连接入口建立失败", ex2);
						string text2 = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "检查后台宿主、账号会话和服务器状态后重试");
						javaServersPage.SetLaunchState(running: false, text2, ((RangeBase)javaServersPage.LaunchProgressBar).Value, failed: true);
						javaServersPage.LaunchStageText.Text = JavaConnectionStatePresentation.TitleOf((T9LWLtfx944ku4NynZ2L)10);
						AppShell.Error(text2);
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__2)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _JavaServersPage_Loaded_d__62 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_008b;
				}
				javaServersPage.LoadGameSettings();
				javaServersPage._loaded = true;
				if (((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Count == 0)
				{
					_u__ = javaServersPage.RefreshServersAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _JavaServersPage_Loaded_d__62>(ref _u__, ref this);
						return;
					}
					goto IL_008b;
				}
				goto end_IL_0011;
				IL_008b:
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
	private struct _LaunchButton_Click_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					javaServersPage.ResetConnectionRetry();
					_u__ = javaServersPage.LaunchSelectedAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LaunchButton_Click_d__30>(ref _u__, ref this);
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
	private struct _LaunchModeComboBox_SelectionChanged_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00d7;
				}
				if (!javaServersPage._suppressLaunchModeSelection && ((Selector)javaServersPage.LaunchModeComboBox).SelectedItem is JavaLaunchModeOption javaLaunchModeOption && (javaLaunchModeOption.Mode != javaServersPage._selectedLaunchMode || (javaServersPage._connectionCoordinator != null && javaServersPage._connectionCoordinator.SelectedMode != javaLaunchModeOption.Mode)))
				{
					_u__ = javaServersPage.SwitchLaunchModeAsync(javaLaunchModeOption.Mode).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LaunchModeComboBox_SelectionChanged_d__13>(ref _u__, ref this);
						return;
					}
					goto IL_00d7;
				}
				goto end_IL_0011;
				IL_00d7:
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
	private struct _LaunchProxySelectedAsync_d__43 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private ys1lxxfFBPhowwZS5N6T _version_5__2;

		private CancellationTokenSource _operation_5__3;

		private TaskAwaiter<w059WIfTE0Fg0LMhfHCu> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected O, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00ed;
				}
				QTHpUQfsgtyJIMkBwTYM val = default(QTHpUQfsgtyJIMkBwTYM);
				int num2 = default(int);
				if (javaServersPage._compatibilityDestination != JavaCompatibilityDestination.IndependentProxy)
				{
					javaServersPage.ResetConnectionRetry();
					AppShell.Warning("独立认证代理只能从兼容工具显式启动");
				}
				else
				{
					javaServersPage.ResetConnectionRetry();
					if (javaServersPage._selectedServer == null)
					{
						goto IL_0095;
					}
					object selectedItem = ((Selector)javaServersPage.VersionComboBox).SelectedItem;
					_version_5__2 = (ys1lxxfFBPhowwZS5N6T)((selectedItem is ys1lxxfFBPhowwZS5N6T) ? selectedItem : null);
					if (_version_5__2 == null)
					{
						goto IL_0095;
					}
					object selectedItem2 = ((Selector)javaServersPage.RoleComboBox).SelectedItem;
					val = (QTHpUQfsgtyJIMkBwTYM)((selectedItem2 is QTHpUQfsgtyJIMkBwTYM) ? selectedItem2 : null);
					if (val == null || !val.IsAvailable)
					{
						goto IL_0095;
					}
					if (javaServersPage._operation == null)
					{
						num2 = (double.IsFinite(javaServersPage.ProxyPortBox.Value) ? ((int)Math.Round(javaServersPage.ProxyPortBox.Value)) : 0);
						_operation_5__3 = new CancellationTokenSource();
						goto IL_00ed;
					}
				}
				goto end_IL_0011;
				IL_0095:
				AppShell.Error("代理条件不完整。下一步：选择服务器、版本和可用角色");
				goto end_IL_0011;
				IL_00ed:
					num2 = default;
					val = default;
				try
				{
					Progress<pqWRiwfFbLTQvJu9JjbG> val2 = default(Progress<pqWRiwfFbLTQvJu9JjbG>);
					if (num != 0)
					{
						javaServersPage._operation = _operation_5__3;
						javaServersPage.SetControlsEnabled(enabled: false);
						javaServersPage.SetLaunchState(running: true, "正在准备高级兼容代理", 0.0, failed: false);
						val2 = new Progress<pqWRiwfFbLTQvJu9JjbG>((Action<pqWRiwfFbLTQvJu9JjbG>)javaServersPage.UpdateLaunchProgress);
					}
					try
					{
						TaskAwaiter<w059WIfTE0Fg0LMhfHCu> _u__ = default;
						if (num != 0)
						{
							_u__ = javaServersPage._proxy.TbGXU0kGCLq(new uEPS2GfTuQVVlxDPjsX8(javaServersPage._selectedServer, _version_5__2, val, num2, (UMHcoIfNLE9EKKScQadx)null), (IProgress<pqWRiwfFbLTQvJu9JjbG>)(object)val2, _operation_5__3.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<w059WIfTE0Fg0LMhfHCu>, _LaunchProxySelectedAsync_d__43>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<w059WIfTE0Fg0LMhfHCu>);
							num = (__1__state = -1);
						}
						w059WIfTE0Fg0LMhfHCu result = _u__.GetResult();
						javaServersPage.SetLaunchState(running: false, "代理已就绪 · " + result.LocalAddressText, 100.0, failed: false);
						AppShell.Success("高级兼容代理已就绪，请在 " + _version_5__2.Name + " 外部客户端连接 " + result.LocalAddressText);
					}
					catch (OperationCanceledException)
					{
						javaServersPage.SetLaunchState(running: false, "代理启动已取消，可以重新启动", ((RangeBase)javaServersPage.LaunchProgressBar).Value, failed: false);
						AppShell.Warning("Java 代理启动已取消");
					}
					catch (global::System.Exception ex2)
					{
						gX17swyO7x0JWQxdaD1.TyQywPUFFh("java-proxy", "高级兼容代理准备失败", ex2);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "点击重试；仍然失败时刷新账号、角色和服务器入口");
						javaServersPage.SetLaunchState(running: false, text, ((RangeBase)javaServersPage.LaunchProgressBar).Value, failed: true, retryAvailable: false);
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__3)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__3 != null)
					{
						((global::System.IDisposable)_operation_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_version_5__2 = null;
				_operation_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_version_5__2 = null;
			_operation_5__3 = null;
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
	private struct _LaunchSelectedAsync_d__32 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private TaskAwaiter<ODG5TvfFY1lU8Uhmpn4V> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00be;
				}
				ys1lxxfFBPhowwZS5N6T val = default(ys1lxxfFBPhowwZS5N6T);
				QTHpUQfsgtyJIMkBwTYM val2 = default(QTHpUQfsgtyJIMkBwTYM);
				if (javaServersPage._compatibilityDestination != JavaCompatibilityDestination.ManagedClient)
				{
					javaServersPage.ResetConnectionRetry();
					AppShell.Warning("项目托管客户端只能从兼容工具显式启动");
				}
				else
				{
					if (javaServersPage._selectedServer == null)
					{
						goto IL_0093;
					}
					object selectedItem = ((Selector)javaServersPage.VersionComboBox).SelectedItem;
					val = (ys1lxxfFBPhowwZS5N6T)((selectedItem is ys1lxxfFBPhowwZS5N6T) ? selectedItem : null);
					if (val == null)
					{
						goto IL_0093;
					}
					object selectedItem2 = ((Selector)javaServersPage.RoleComboBox).SelectedItem;
					val2 = (QTHpUQfsgtyJIMkBwTYM)((selectedItem2 is QTHpUQfsgtyJIMkBwTYM) ? selectedItem2 : null);
					if (val2 == null || !val2.IsAvailable)
					{
						goto IL_0093;
					}
					if (javaServersPage._operation == null)
					{
						_operation_5__2 = new CancellationTokenSource();
						goto IL_00be;
					}
				}
				goto end_IL_0011;
				IL_0093:
				AppShell.Error("启动条件不完整。下一步：选择服务器、版本和可用角色");
				goto end_IL_0011;
				IL_00be:
					val2 = default;
					val = default;
				try
				{
					Progress<pqWRiwfFbLTQvJu9JjbG> val3 = default(Progress<pqWRiwfFbLTQvJu9JjbG>);
					if (num != 0)
					{
						javaServersPage._operation = _operation_5__2;
						javaServersPage._retryContext = JavaServerRetryContext.ManagedClient;
						javaServersPage.SetControlsEnabled(enabled: false);
						javaServersPage.SetLaunchState(running: true, "正在准备自有 Java 客户端与本机代理", 0.0, failed: false);
						val3 = new Progress<pqWRiwfFbLTQvJu9JjbG>((Action<pqWRiwfFbLTQvJu9JjbG>)javaServersPage.UpdateLaunchProgress);
					}
					try
					{
						TaskAwaiter<ODG5TvfFY1lU8Uhmpn4V> _u__ = default;
						if (num != 0)
						{
							tkF3LRfxdkiPD0dqhesT val4 = javaServersPage.ReadGameSettings();
							javaServersPage._client.hMjFYVvoO3(val4);
							HDDHYcfFZMJBwyk4WxDY val5 = new HDDHYcfFZMJBwyk4WxDY(javaServersPage._selectedServer, val, val2, val4.MemoryMegabytes, (string)null, val4);
							_u__ = javaServersPage._client.zOnFAA8Kw4(val5, (IProgress<pqWRiwfFbLTQvJu9JjbG>)(object)val3, _operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ODG5TvfFY1lU8Uhmpn4V>, _LaunchSelectedAsync_d__32>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<ODG5TvfFY1lU8Uhmpn4V>);
							num = (__1__state = -1);
						}
						ODG5TvfFY1lU8Uhmpn4V result = _u__.GetResult();
						if (result.LoginConfirmed)
						{
							javaServersPage.SetLaunchState(running: false, $"已确认进入服务器 · PID {result.ProcessId}", 100.0, failed: false);
							AppShell.Success("已确认进入 " + javaServersPage._selectedServer.Name);
						}
						else
						{
							javaServersPage.SetLaunchState(running: false, $"自有客户端已启动，暂未收到进服确认 · PID {result.ProcessId}", 100.0, failed: false);
							AppShell.Warning("自有 Java 客户端已启动，但本机代理暂未收到进服确认；请查看客户端界面或实例日志");
						}
					}
					catch (OperationCanceledException)
					{
						javaServersPage.ResetConnectionRetry();
						javaServersPage.SetLaunchState(running: false, "启动已取消，可以重新启动", ((RangeBase)javaServersPage.LaunchProgressBar).Value, failed: false);
						AppShell.Warning("Java 启动已取消");
					}
					catch (global::System.Exception ex2)
					{
						gX17swyO7x0JWQxdaD1.TyQywPUFFh("java-launch", "Java 本机代理进服启动失败", ex2);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "点击重试；仍然失败时前往版本管理执行修复");
						javaServersPage.SetLaunchState(running: false, text, ((RangeBase)javaServersPage.LaunchProgressBar).Value, failed: true);
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__2)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _LoadServerDetailsAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		public YlErsbfs35V4xTUvrlXK server;

		private CancellationTokenSource _operation_5__2;

		private YlErsbfs35V4xTUvrlXK _detailed_5__3;

		private TaskAwaiter<YlErsbfs35V4xTUvrlXK> __u__1;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if ((uint)num > 1u)
				{
					_operation_5__2 = new CancellationTokenSource();
				}
				try
				{
					if ((uint)num > 1u)
					{
						javaServersPage._operation = _operation_5__2;
						javaServersPage.SetControlsEnabled(enabled: false);
						javaServersPage.DetailName.Text = server.Name;
						javaServersPage.DetailDescription.Text = "正在读取服务器详情与角色";
						javaServersPage.RoleStatusText.Text = "正在同步角色";
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>> _u__;
						TaskAwaiter<YlErsbfs35V4xTUvrlXK> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>>);
								num = (__1__state = -1);
								goto IL_017b;
							}
							_u__2 = javaServersPage._client.fLoFhpUViO(server.Id, _operation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<YlErsbfs35V4xTUvrlXK>, _LoadServerDetailsAsync_d__6>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<YlErsbfs35V4xTUvrlXK>);
							num = (__1__state = -1);
						}
						YlErsbfs35V4xTUvrlXK result = _u__2.GetResult();
						_detailed_5__3 = result;
						_u__ = javaServersPage._client.x1BFU2dCoW(_detailed_5__3.Id, _operation_5__2.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>>, _LoadServerDetailsAsync_d__6>(ref _u__, ref this);
							return;
						}
						goto IL_017b;
						IL_017b:
						global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM> result2 = _u__.GetResult();
						javaServersPage._selectedServer = _detailed_5__3;
						javaServersPage.PresentServer(_detailed_5__3);
						javaServersPage.PresentRoles(result2);
						javaServersPage.CatalogStatusText.Text = "已选择 " + _detailed_5__3.Name;
						_detailed_5__3 = null;
					}
					catch (OperationCanceledException)
					{
						javaServersPage.RoleStatusText.Text = "详情加载已取消，可以重新选择服务器";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "LoadServerDetailsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaServersPage.Catalog.cs", 142);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "重新选择服务器或刷新目录");
						javaServersPage._selectedServer = null;
						javaServersPage.DetailDescription.Text = text;
						javaServersPage.RoleStatusText.Text = "服务器详情不可用";
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__2)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _ProxyLaunchButton_Click_d__42 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					javaServersPage.ResetConnectionRetry();
					_u__ = javaServersPage.LaunchProxySelectedAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ProxyLaunchButton_Click_d__42>(ref _u__, ref this);
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
	private struct _RefreshButton_Click_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

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
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaServersPage.RefreshServersAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__0>(ref _u__, ref this);
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
	private struct _RefreshRolesButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_003e;
				}
				if (javaServersPage._selectedServer != null && javaServersPage._operation == null)
				{
					_operation_5__2 = new CancellationTokenSource();
					goto IL_003e;
				}
				goto end_IL_0011;
				IL_003e:
				try
				{
					if (num != 0)
					{
						javaServersPage._operation = _operation_5__2;
						javaServersPage.SetControlsEnabled(enabled: false);
						javaServersPage.RoleStatusText.Text = "正在刷新角色";
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>> _u__;
						if (num != 0)
						{
							_u__ = javaServersPage._client.x1BFU2dCoW(javaServersPage._selectedServer.Id, _operation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>>, _RefreshRolesButton_Click_d__9>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM>>);
							num = (__1__state = -1);
						}
						global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM> result = _u__.GetResult();
						javaServersPage.PresentRoles(result);
					}
					catch (OperationCanceledException)
					{
						javaServersPage.RoleStatusText.Text = "角色刷新已取消";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "RefreshRolesButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaServersPage.Catalog.cs", 203);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "重新刷新角色或重新建立会话");
						javaServersPage.RoleStatusText.Text = text;
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__2)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _RefreshServersAsync_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private CancellationTokenSource _operation_5__2;

		private string _keyword_5__3;

		private bool _selectFirst_5__4;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK>> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0064;
				}
				if (javaServersPage._operation == null && !javaServersPage._disposed)
				{
					if (javaServersPage._client.CurrentSession != null)
					{
						_operation_5__2 = new CancellationTokenSource();
						goto IL_0064;
					}
					javaServersPage.ClearCatalog("等待服务器目录", "请先在 Java 账号配置建立游戏会话");
				}
				goto end_IL_0011;
				IL_0064:
				try
				{
					if ((uint)num > 1u)
					{
						javaServersPage._operation = _operation_5__2;
						javaServersPage.SetControlsEnabled(enabled: false);
						_keyword_5__3 = javaServersPage.ServerSearchBox.Text.Trim();
						javaServersPage.ShowCatalogLoading((_keyword_5__3.Length == 0) ? "正在同步服务器目录" : "正在搜索服务器");
						_selectFirst_5__4 = false;
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK>> _u__;
						global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK> result;
						if (num != 0)
						{
							if (num != 1)
							{
								if (_keyword_5__3.Length == 0)
								{
									_u__ = javaServersPage._client.c5tFC5txcX(_operation_5__2.Token).GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 0);
										__u__1 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK>>, _RefreshServersAsync_d__3>(ref _u__, ref this);
										return;
									}
									goto IL_0145;
								}
								_u__ = javaServersPage._client.rgEF4qA31B(_keyword_5__3, _operation_5__2.Token).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK>>, _RefreshServersAsync_d__3>(ref _u__, ref this);
									return;
								}
							}
							else
							{
								_u__ = __u__1;
								__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK>>);
								num = (__1__state = -1);
							}
							result = _u__.GetResult();
							goto IL_01c7;
						}
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK>>);
						num = (__1__state = -1);
						goto IL_0145;
						IL_0145:
						result = _u__.GetResult();
						goto IL_01c7;
						IL_01c7:
						global::System.Collections.Generic.IReadOnlyList<YlErsbfs35V4xTUvrlXK> readOnlyList = result;
						((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Clear();
						global::System.Collections.Generic.IEnumerator<YlErsbfs35V4xTUvrlXK> enumerator = ((global::System.Collections.Generic.IEnumerable<YlErsbfs35V4xTUvrlXK>)readOnlyList).GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
							{
								YlErsbfs35V4xTUvrlXK current = enumerator.Current;
								((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Add(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								((global::System.IDisposable)enumerator)?.Dispose();
							}
						}
						_selectFirst_5__4 = ((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Count > 0;
						((UIElement)javaServersPage.EmptyPanel).Visibility = ((_selectFirst_5__4 ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
						javaServersPage.EmptyTitle.Text = ((_keyword_5__3.Length == 0) ? "暂无可用服务器" : "没有匹配的服务器");
						javaServersPage.EmptyDescription.Text = ((_keyword_5__3.Length == 0) ? "服务器目录暂时为空，请稍后刷新" : "尝试缩短关键词或清空搜索条件");
						javaServersPage.CatalogStatusText.Text = ((((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Count == 0) ? "目录暂时为空" : ((_keyword_5__3.Length == 0) ? $"已同步 {((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Count} 个网络服务器" : $"找到 {((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Count} 个相关服务器"));
					}
					catch (OperationCanceledException)
					{
						javaServersPage.CatalogStatusText.Text = "服务器加载已取消，可以刷新重试";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "RefreshServersAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaServersPage.Catalog.cs", 80);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "刷新服务器目录或重新建立会话");
						((Collection<YlErsbfs35V4xTUvrlXK>)(object)javaServersPage.Servers).Clear();
						javaServersPage.ClearCatalog("服务器目录加载失败", text);
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__2)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.CatalogProgressRing.IsActive = false;
							((UIElement)javaServersPage.CatalogProgressRing).Visibility = (Visibility)1;
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
					if (_selectFirst_5__4 && !javaServersPage._disposed && javaServersPage._operation == null)
					{
						((Selector)javaServersPage.ServerGrid).SelectedIndex = 0;
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				_keyword_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
			_keyword_5__3 = null;
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
	private struct _RetryLaunchButton_Click_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00c1;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_014a;
				}
				JavaServerRetryContext retryContext = javaServersPage._retryContext;
				JavaServerRetryKind kind = retryContext.Kind;
				if (kind != JavaServerRetryKind.CoordinatedConnection)
				{
					if (kind == JavaServerRetryKind.ManagedClient && javaServersPage._compatibilityDestination == JavaCompatibilityDestination.ManagedClient)
					{
						_u__ = javaServersPage.LaunchSelectedAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RetryLaunchButton_Click_d__31>(ref _u__, ref this);
							return;
						}
						goto IL_014a;
					}
				}
				else if (retryContext.ConnectionMode == (r9S4FZfxG0478bdNv59r?)javaServersPage._selectedLaunchMode)
				{
					_u__ = javaServersPage.EstablishSelectedEntryAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RetryLaunchButton_Click_d__31>(ref _u__, ref this);
						return;
					}
					goto IL_00c1;
				}
				javaServersPage.ResetConnectionRetry();
				goto end_IL_0011;
				IL_00c1:
				_u__.GetResult();
				goto end_IL_0011;
				IL_014a:
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
	private struct _ServerGrid_SelectionChanged_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0091;
				}
				object selectedItem = ((Selector)javaServersPage.ServerGrid).SelectedItem;
				YlErsbfs35V4xTUvrlXK val = (YlErsbfs35V4xTUvrlXK)((selectedItem is YlErsbfs35V4xTUvrlXK) ? selectedItem : null);
				if (val != null && javaServersPage._operation == null)
				{
					_u__ = javaServersPage.LoadServerDetailsAsync(val).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ServerGrid_SelectionChanged_d__5>(ref _u__, ref this);
						return;
					}
					goto IL_0091;
				}
				goto end_IL_0011;
				IL_0091:
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
	private struct _ServerSearchBox_QuerySubmitted_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

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
			JavaServersPage javaServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaServersPage.RefreshServersAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ServerSearchBox_QuerySubmitted_d__1>(ref _u__, ref this);
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
	private struct _ServerSearchBox_TextChanged_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		public AutoSuggestBoxTextChangedEventArgs args;

		public AutoSuggestBox sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
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
				if (javaServersPage._loaded && (int)args.Reason == 0 && string.IsNullOrWhiteSpace(sender.Text))
				{
					_u__ = javaServersPage.RefreshServersAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ServerSearchBox_TextChanged_d__2>(ref _u__, ref this);
						return;
					}
					goto IL_009e;
				}
				goto end_IL_0011;
				IL_009e:
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
	private struct _SwitchLaunchModeAsync_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaServersPage __4__this;

		public r9S4FZfxG0478bdNv59r mode;

		private Jj84PVNAj19tCbr5gHp _coordinator_5__2;

		private CancellationTokenSource _operation_5__3;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaServersPage javaServersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0080;
				}
				if (javaServersPage._operation != null)
				{
					Jj84PVNAj19tCbr5gHp? connectionCoordinator = javaServersPage._connectionCoordinator;
					javaServersPage.SelectLaunchMode((connectionCoordinator != null) ? connectionCoordinator.SelectedMode : javaServersPage._selectedLaunchMode, updateCoordinator: false);
				}
				else
				{
					_coordinator_5__2 = javaServersPage._connectionCoordinator;
					if (_coordinator_5__2 != null)
					{
						_operation_5__3 = new CancellationTokenSource();
						goto IL_0080;
					}
					javaServersPage.SelectLaunchMode(mode, updateCoordinator: false);
				}
				goto end_IL_0011;
				IL_0080:
				try
				{
					if (num != 0)
					{
						javaServersPage._operation = _operation_5__3;
						javaServersPage.SetControlsEnabled(enabled: false);
					}
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							qC3ZV7fxXAJqu2TjY3Nc current = _coordinator_5__2.Current;
							if (current == null || !current.IsActive)
							{
								goto IL_013e;
							}
							javaServersPage.PresentConnectionState((T9LWLtfx944ku4NynZ2L)9, "正在停止当前连接后切换客户端模式", 0);
							_u__ = _coordinator_5__2.GGwNtycGrm(_operation_5__3.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SwitchLaunchModeAsync_d__14>(ref _u__, ref this);
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
						goto IL_013e;
						IL_013e:
						_coordinator_5__2.V3WNlk2OMF(mode);
						javaServersPage.SelectLaunchMode(mode, updateCoordinator: false);
					}
					catch (OperationCanceledException)
					{
						javaServersPage.SelectLaunchMode(_coordinator_5__2.SelectedMode, updateCoordinator: false);
						AppShell.Warning("客户端模式切换已取消");
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "SwitchLaunchModeAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaServersPage.ConnectionEntry.cs", 110);
						javaServersPage.SelectLaunchMode(_coordinator_5__2.SelectedMode, updateCoordinator: false);
						AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "确认当前连接已停止后重新切换客户端模式"));
					}
					finally
					{
						if (num < 0)
						{
							if (javaServersPage._operation == _operation_5__3)
							{
								javaServersPage._operation = null;
							}
							javaServersPage.SetControlsEnabled(enabled: true);
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__3 != null)
					{
						((global::System.IDisposable)_operation_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_coordinator_5__2 = null;
				_operation_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_coordinator_5__2 = null;
			_operation_5__3 = null;
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

	private const double WideLayoutThreshold = 1040.0;

	private const double WideConnectionEntryThreshold = 920.0;

	private readonly KxOGVaFL8AQcstEY1GC _client;

	private readonly kXxcqCXUYs1qiIst9kaY _proxy;

	private Jj84PVNAj19tCbr5gHp? _connectionCoordinator;

	private CancellationTokenSource? _operation;

	private YlErsbfs35V4xTUvrlXK? _selectedServer;

	private r9S4FZfxG0478bdNv59r _selectedLaunchMode;

	private JavaServerRetryContext _retryContext;

	private JavaCompatibilityDestination? _compatibilityDestination;

	private bool _loaded;

	private bool _suppressLaunchModeSelection;

	private bool _disposed;

	private double _connectionEntryWidth;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ResponsiveRoot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border ConnectionEntryPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ConnectionEntryGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition EntrySummaryColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition EntryModeColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition EntryPortColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition EntryActionColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel ConnectionEntrySummaryPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel LaunchModePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel ProxyPortPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button EstablishEntryButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private FontIcon EstablishEntryButtonIcon;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EstablishEntryButtonText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProxyPortLabelText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox ProxyPortBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox LaunchModeComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ConnectionEntryTitleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ConnectionModeDescriptionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition DetailColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition CompactDetailRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border DetailPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox MemoryBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch AutoSaveSettingsToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch ChineseToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch WindowSizeToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ResourcePacksBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch AutoJumpToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox NarratorComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch AccessibilityToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button SaveSettingsButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox WindowWidthBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox WindowHeightBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch GuiScaleToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox GuiScaleBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch AutoReconnectToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox ReconnectDelayBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox RoleComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RoleStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox NewRoleNameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CreateRoleButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshRolesButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox VersionComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailName;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailAuthor;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailOnline;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockNetworkImage DetailCover;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private GridView ServerGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing CatalogProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CatalogStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border CompatibilityEntryPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LaunchOperationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStageText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchPercentText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RetryLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LocalEndpointPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchTransferText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar LaunchProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CopyLocalEndpointButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LocalEndpointAddressText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ProxyLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CompatibilityEntryTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CompatibilityEntryDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AutoSuggestBox ServerSearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IJavaServersPage_Bindings Bindings;

	private ObservableCollection<YlErsbfs35V4xTUvrlXK> _Servers_k__BackingField;
	[field: CompilerGenerated]
	public ObservableCollection<YlErsbfs35V4xTUvrlXK> Servers
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__0 refreshButton_Click_d__ = default(_RefreshButton_Click_d__0);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__0>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ServerSearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ServerSearchBox_QuerySubmitted_d__1 serverSearchBox_QuerySubmitted_d__ = default(_ServerSearchBox_QuerySubmitted_d__1);
		serverSearchBox_QuerySubmitted_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		serverSearchBox_QuerySubmitted_d__.__4__this = this;
		serverSearchBox_QuerySubmitted_d__.__1__state = -1;
		serverSearchBox_QuerySubmitted_d__.__t__builder.Start<_ServerSearchBox_QuerySubmitted_d__1>(ref serverSearchBox_QuerySubmitted_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ServerSearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ServerSearchBox_TextChanged_d__2 serverSearchBox_TextChanged_d__ = default(_ServerSearchBox_TextChanged_d__2);
		serverSearchBox_TextChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		serverSearchBox_TextChanged_d__.__4__this = this;
		serverSearchBox_TextChanged_d__.sender = sender;
		serverSearchBox_TextChanged_d__.args = args;
		serverSearchBox_TextChanged_d__.__1__state = -1;
		serverSearchBox_TextChanged_d__.__t__builder.Start<_ServerSearchBox_TextChanged_d__2>(ref serverSearchBox_TextChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshServersAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshServersAsync_d__3 refreshServersAsync_d__ = default(_RefreshServersAsync_d__3);
		refreshServersAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshServersAsync_d__.__4__this = this;
		refreshServersAsync_d__.__1__state = -1;
		refreshServersAsync_d__.__t__builder.Start<_RefreshServersAsync_d__3>(ref refreshServersAsync_d__);
		return refreshServersAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ServerGrid_ItemClick(object sender, ItemClickEventArgs e)
	{
		object clickedItem = e.ClickedItem;
		YlErsbfs35V4xTUvrlXK val = (YlErsbfs35V4xTUvrlXK)((clickedItem is YlErsbfs35V4xTUvrlXK) ? clickedItem : null);
		if (val != null)
		{
			((Selector)ServerGrid).SelectedItem = val;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ServerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ServerGrid_SelectionChanged_d__5 serverGrid_SelectionChanged_d__ = default(_ServerGrid_SelectionChanged_d__5);
		serverGrid_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		serverGrid_SelectionChanged_d__.__4__this = this;
		serverGrid_SelectionChanged_d__.__1__state = -1;
		serverGrid_SelectionChanged_d__.__t__builder.Start<_ServerGrid_SelectionChanged_d__5>(ref serverGrid_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadServerDetailsAsync(YlErsbfs35V4xTUvrlXK server)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadServerDetailsAsync_d__6 loadServerDetailsAsync_d__ = default(_LoadServerDetailsAsync_d__6);
		loadServerDetailsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadServerDetailsAsync_d__.__4__this = this;
		loadServerDetailsAsync_d__.server = server;
		loadServerDetailsAsync_d__.__1__state = -1;
		loadServerDetailsAsync_d__.__t__builder.Start<_LoadServerDetailsAsync_d__6>(ref loadServerDetailsAsync_d__);
		return loadServerDetailsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PresentServer(YlErsbfs35V4xTUvrlXK server)
	{
		DetailCover.ImageUrl = server.ImageUrl;
		DetailName.Text = server.Name;
		DetailOnline.Text = server.OnlineDisplayText;
		DetailAuthor.Text = (string.IsNullOrWhiteSpace(server.Author) ? "作者：未提供" : ("作者：" + server.Author));
		DetailDescription.Text = ((!string.IsNullOrWhiteSpace(server.Description)) ? server.Description : (string.IsNullOrWhiteSpace(server.Summary) ? "暂无服务器说明" : server.Summary));
		((ItemsControl)VersionComboBox).ItemsSource = server.Versions;
		((Selector)VersionComboBox).SelectedIndex = ((((global::System.Collections.Generic.IReadOnlyCollection<ys1lxxfFBPhowwZS5N6T>)server.Versions).Count <= 0) ? (-1) : 0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PresentRoles(global::System.Collections.Generic.IReadOnlyList<QTHpUQfsgtyJIMkBwTYM> roles)
	{
		((ItemsControl)RoleComboBox).ItemsSource = roles;
		((Selector)RoleComboBox).SelectedItem = Enumerable.FirstOrDefault<QTHpUQfsgtyJIMkBwTYM>((global::System.Collections.Generic.IEnumerable<QTHpUQfsgtyJIMkBwTYM>)roles, (Func<QTHpUQfsgtyJIMkBwTYM, bool>)([MethodImpl((MethodImplOptions)8)] (QTHpUQfsgtyJIMkBwTYM role) => role.IsAvailable));
		RoleStatusText.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<QTHpUQfsgtyJIMkBwTYM>)roles).Count == 0) ? "当前服务器没有角色，可以在下方创建" : $"共 {((global::System.Collections.Generic.IReadOnlyCollection<QTHpUQfsgtyJIMkBwTYM>)roles).Count} 个角色 · {Enumerable.Count<QTHpUQfsgtyJIMkBwTYM>((global::System.Collections.Generic.IEnumerable<QTHpUQfsgtyJIMkBwTYM>)roles, (Func<QTHpUQfsgtyJIMkBwTYM, bool>)([MethodImpl((MethodImplOptions)8)] (QTHpUQfsgtyJIMkBwTYM role) => role.IsAvailable))} 个可用");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshRolesButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshRolesButton_Click_d__9 refreshRolesButton_Click_d__ = default(_RefreshRolesButton_Click_d__9);
		refreshRolesButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshRolesButton_Click_d__.__4__this = this;
		refreshRolesButton_Click_d__.__1__state = -1;
		refreshRolesButton_Click_d__.__t__builder.Start<_RefreshRolesButton_Click_d__9>(ref refreshRolesButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CreateRoleButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CreateRoleButton_Click_d__10 createRoleButton_Click_d__ = default(_CreateRoleButton_Click_d__10);
		createRoleButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		createRoleButton_Click_d__.__4__this = this;
		createRoleButton_Click_d__.__1__state = -1;
		createRoleButton_Click_d__.__t__builder.Start<_CreateRoleButton_Click_d__10>(ref createRoleButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
		ApplyCompatibilityDestination((e.Parameter is JavaCompatibilityNavigationRequest javaCompatibilityNavigationRequest) ? new JavaCompatibilityDestination?(javaCompatibilityNavigationRequest.Destination) : ((JavaCompatibilityDestination?)null));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void AttachConnectionCoordinator(Jj84PVNAj19tCbr5gHp coordinator)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)coordinator, "coordinator");
		if (_connectionCoordinator != coordinator)
		{
			if (_connectionCoordinator != null)
			{
				_connectionCoordinator.Changed -= new EventHandler(ConnectionCoordinator_Changed);
			}
			_connectionCoordinator = coordinator;
			_connectionCoordinator.Changed += new EventHandler(ConnectionCoordinator_Changed);
			SelectLaunchMode(coordinator.SelectedMode, updateCoordinator: false);
			RefreshConnectionCoordinatorState();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LaunchModeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LaunchModeComboBox_SelectionChanged_d__13 launchModeComboBox_SelectionChanged_d__ = default(_LaunchModeComboBox_SelectionChanged_d__13);
		launchModeComboBox_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		launchModeComboBox_SelectionChanged_d__.__4__this = this;
		launchModeComboBox_SelectionChanged_d__.__1__state = -1;
		launchModeComboBox_SelectionChanged_d__.__t__builder.Start<_LaunchModeComboBox_SelectionChanged_d__13>(ref launchModeComboBox_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SwitchLaunchModeAsync(r9S4FZfxG0478bdNv59r mode)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_SwitchLaunchModeAsync_d__14 switchLaunchModeAsync_d__ = default(_SwitchLaunchModeAsync_d__14);
		switchLaunchModeAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		switchLaunchModeAsync_d__.__4__this = this;
		switchLaunchModeAsync_d__.mode = mode;
		switchLaunchModeAsync_d__.__1__state = -1;
		switchLaunchModeAsync_d__.__t__builder.Start<_SwitchLaunchModeAsync_d__14>(ref switchLaunchModeAsync_d__);
		return switchLaunchModeAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SelectLaunchMode(r9S4FZfxG0478bdNv59r mode, bool updateCoordinator)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass15_0_2 __8_locals7 = (__c__DisplayClass15_0_2)new __c__DisplayClass15_0_2();
		__8_locals7.mode = mode;
		if (!global::System.Enum.IsDefined<r9S4FZfxG0478bdNv59r>(__8_locals7.mode))
		{
			throw new ArgumentOutOfRangeException("mode");
		}
		if (updateCoordinator)
		{
			Jj84PVNAj19tCbr5gHp? connectionCoordinator = _connectionCoordinator;
			if (connectionCoordinator != null)
			{
				connectionCoordinator.V3WNlk2OMF(__8_locals7.mode);
			}
		}
		_selectedLaunchMode = __8_locals7.mode;
		JavaLaunchModeOption javaLaunchModeOption = Enumerable.First<JavaLaunchModeOption>((global::System.Collections.Generic.IEnumerable<JavaLaunchModeOption>)JavaLaunchModeOption.All, (Func<JavaLaunchModeOption, bool>)([MethodImpl((MethodImplOptions)8)] (JavaLaunchModeOption item) => item.Mode == __8_locals7.mode));
		if (((Selector)LaunchModeComboBox).SelectedItem != javaLaunchModeOption)
		{
			_suppressLaunchModeSelection = true;
			try
			{
				((Selector)LaunchModeComboBox).SelectedItem = javaLaunchModeOption;
			}
			finally
			{
				_suppressLaunchModeSelection = false;
			}
		}
		ConnectionModeDescriptionText.Text = javaLaunchModeOption.Description;
		JavaConnectionModePresentation javaConnectionModePresentation = JavaConnectionModePresentation.For(__8_locals7.mode);
		ConnectionEntryTitleText.Text = javaConnectionModePresentation.EntryTitle;
		EstablishEntryButtonText.Text = javaConnectionModePresentation.ActionTitle;
		EstablishEntryButtonIcon.Glyph = (((int)__8_locals7.mode == 0) ? "\ue774" : "\ue768");
		AutomationProperties.SetName((DependencyObject)(object)EstablishEntryButton, javaConnectionModePresentation.ActionAutomationName);
		HideLocalEndpoint();
		UpdateConnectionEntryLayout();
		ResetConnectionRetry();
		SetControlsEnabled(_operation == null);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void EstablishEntryButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_EstablishEntryButton_Click_d__16 establishEntryButton_Click_d__ = default(_EstablishEntryButton_Click_d__16);
		establishEntryButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		establishEntryButton_Click_d__.__4__this = this;
		establishEntryButton_Click_d__.__1__state = -1;
		establishEntryButton_Click_d__.__t__builder.Start<_EstablishEntryButton_Click_d__16>(ref establishEntryButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task EstablishSelectedEntryAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_EstablishSelectedEntryAsync_d__17 establishSelectedEntryAsync_d__ = default(_EstablishSelectedEntryAsync_d__17);
		establishSelectedEntryAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		establishSelectedEntryAsync_d__.__4__this = this;
		establishSelectedEntryAsync_d__.__1__state = -1;
		establishSelectedEntryAsync_d__.__t__builder.Start<_EstablishSelectedEntryAsync_d__17>(ref establishSelectedEntryAsync_d__);
		return establishSelectedEntryAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool TryCreateConnectionRequest(out vbT0RwfPa3ScEuruAINf request)
	{
		//IL_0006: Expected I8, but got O
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected I8, but got Unknown
		request = (vbT0RwfPa3ScEuruAINf)null;
		if (_selectedServer != null)
		{
			object selectedItem = ((Selector)VersionComboBox).SelectedItem;
			ys1lxxfFBPhowwZS5N6T val = (ys1lxxfFBPhowwZS5N6T)((selectedItem is ys1lxxfFBPhowwZS5N6T) ? selectedItem : null);
			if (val != null)
			{
				object selectedItem2 = ((Selector)RoleComboBox).SelectedItem;
				QTHpUQfsgtyJIMkBwTYM val2 = (QTHpUQfsgtyJIMkBwTYM)((selectedItem2 is QTHpUQfsgtyJIMkBwTYM) ? selectedItem2 : null);
				if (val2 != null && val2.IsAvailable)
				{
					int num = (double.IsFinite(ProxyPortBox.Value) ? ((int)Math.Round(ProxyPortBox.Value)) : 0);
					if ((int)_selectedLaunchMode == 1)
					{
						num = 0;
					}
					request = (vbT0RwfPa3ScEuruAINf)new vbT0RwfPa3ScEuruAINf(_selectedServer, val, val2, num);
					return true;
				}
			}
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ConnectionCoordinator_Changed(object? sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (_disposed)
		{
			return;
		}
		if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			RefreshConnectionCoordinatorState();
			return;
		}
		((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () =>
		{
			if (!_disposed)
			{
				RefreshConnectionCoordinatorState();
			}
		}));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshConnectionCoordinatorState()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (!_disposed)
		{
			Jj84PVNAj19tCbr5gHp connectionCoordinator = _connectionCoordinator;
			if (connectionCoordinator != null && connectionCoordinator.SelectedMode != _selectedLaunchMode)
			{
				SelectLaunchMode(connectionCoordinator.SelectedMode, updateCoordinator: false);
			}
			qC3ZV7fxXAJqu2TjY3Nc val = ((connectionCoordinator != null) ? connectionCoordinator.Current : null);
			if (val != null)
			{
				PresentConnectionSnapshot(val);
			}
			SetControlsEnabled(_operation == null);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PresentConnectionSnapshot(qC3ZV7fxXAJqu2TjY3Nc snapshot)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		string message = (string.IsNullOrWhiteSpace(snapshot.Message) ? JavaConnectionStatePresentation.TitleOf(snapshot.State) : snapshot.Message);
		PresentConnectionState(snapshot.State, message, snapshot.LocalPort);
		if (JavaConnectionModePresentation.CanCopyLocalAddress(snapshot))
		{
			ShowLocalEndpoint(snapshot.LocalAddressText);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PresentConnectionState(T9LWLtfx944ku4NynZ2L state, string message, int localPort)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (int)state <= 3;
		bool running = flag;
		bool flag2 = (int)state == 10;
		int num;
		switch ((int)state)
		{
		case 0:
			num = 10;
			break;
		case 1:
			num = 30;
			break;
		case 2:
			num = 55;
			break;
		case 3:
			num = 80;
			break;
		case 8:
		case 10:
			num = 0;
			break;
		default:
			num = 100;
			break;
		}
		int num2 = num;
		SetLaunchState(running, message, num2, flag2, flag2 && _retryContext.CanRetry);
		LaunchStageText.Text = JavaConnectionStatePresentation.TitleOf(state);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowLocalEndpoint(string address)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(address) || (int)_selectedLaunchMode != 0)
		{
			HideLocalEndpoint();
			return;
		}
		LocalEndpointAddressText.Text = address;
		((UIElement)LocalEndpointPanel).Visibility = (Visibility)0;
		((Control)CopyLocalEndpointButton).IsEnabled = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void HideLocalEndpoint()
	{
		LocalEndpointAddressText.Text = string.Empty;
		((UIElement)LocalEndpointPanel).Visibility = (Visibility)1;
		((Control)CopyLocalEndpointButton).IsEnabled = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyLocalEndpointButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((UIElement)LocalEndpointPanel).Visibility == 0 && (int)_selectedLaunchMode == 0 && !string.IsNullOrWhiteSpace(LocalEndpointAddressText.Text))
		{
			UiHelpers.CopyToClipboard(LocalEndpointAddressText.Text);
			AppShell.Success("已复制本机连接地址");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyCompatibilityDestination(JavaCompatibilityDestination? destination)
	{
		_compatibilityDestination = destination;
		((UIElement)CompatibilityEntryPanel).Visibility = ((!destination.HasValue) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)LaunchButton).Visibility = ((destination != JavaCompatibilityDestination.ManagedClient) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)ProxyLaunchButton).Visibility = ((destination != JavaCompatibilityDestination.IndependentProxy) ? Visibility.Visible : Visibility.Collapsed);
		switch (destination)
		{
		case JavaCompatibilityDestination.ManagedClient:
			CompatibilityEntryTitle.Text = "项目托管客户端（旧流程）";
			CompatibilityEntryDescription.Text = "由项目准备资源并启动游戏进程。返回默认入口可改用外部客户端或官方客户端模式。";
			break;
		case JavaCompatibilityDestination.IndependentProxy:
			CompatibilityEntryTitle.Text = "独立认证代理（旧流程）";
			CompatibilityEntryDescription.Text = "此入口使用独立认证链，仅用于兼容性排查；失败后不会进入页面顶部的通用重试。";
			break;
		default:
			CompatibilityEntryTitle.Text = string.Empty;
			CompatibilityEntryDescription.Text = string.Empty;
			break;
		}
		ResetConnectionRetry();
		UpdateConnectionEntryLayout();
		SetControlsEnabled(_operation == null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ReturnToDefaultEntryButton_Click(object sender, RoutedEventArgs e)
	{
		ApplyCompatibilityDestination(null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetConnectionRetry()
	{
		_retryContext = JavaServerRetryContext.None;
		((UIElement)RetryLaunchButton).Visibility = (Visibility)1;
		((Control)RetryLaunchButton).IsEnabled = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LaunchSelection_Changed(object sender, SelectionChangedEventArgs e)
	{
		ResetConnectionRetry();
		SetControlsEnabled(_operation == null);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LaunchButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LaunchButton_Click_d__30 launchButton_Click_d__ = default(_LaunchButton_Click_d__30);
		launchButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		launchButton_Click_d__.__4__this = this;
		launchButton_Click_d__.__1__state = -1;
		launchButton_Click_d__.__t__builder.Start<_LaunchButton_Click_d__30>(ref launchButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RetryLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RetryLaunchButton_Click_d__31 retryLaunchButton_Click_d__ = default(_RetryLaunchButton_Click_d__31);
		retryLaunchButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		retryLaunchButton_Click_d__.__4__this = this;
		retryLaunchButton_Click_d__.__1__state = -1;
		retryLaunchButton_Click_d__.__t__builder.Start<_RetryLaunchButton_Click_d__31>(ref retryLaunchButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LaunchSelectedAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LaunchSelectedAsync_d__32 launchSelectedAsync_d__ = default(_LaunchSelectedAsync_d__32);
		launchSelectedAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		launchSelectedAsync_d__.__4__this = this;
		launchSelectedAsync_d__.__1__state = -1;
		launchSelectedAsync_d__.__t__builder.Start<_LaunchSelectedAsync_d__32>(ref launchSelectedAsync_d__);
		return launchSelectedAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? operation = _operation;
		if (operation != null)
		{
			operation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateLaunchProgress(pqWRiwfFbLTQvJu9JjbG progress)
	{
		double num = Math.Clamp(progress.Percent, 0.0, 100.0);
		((UIElement)LaunchOperationPanel).Visibility = (Visibility)0;
		LaunchStageText.Text = GetLaunchStageText(progress);
		LaunchStatusText.Text = progress.Message;
		((RangeBase)LaunchProgressBar).Value = num;
		LaunchPercentText.Text = $"{num:0.#}%";
		string text = BuildTransferText(progress);
		LaunchTransferText.Text = text;
		((UIElement)LaunchTransferText).Visibility = ((string.IsNullOrWhiteSpace(text) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetLaunchState(bool running, string status, double percent, bool failed, bool retryAvailable = true)
	{
		HideLocalEndpoint();
		((UIElement)LaunchOperationPanel).Visibility = (Visibility)0;
		LaunchStageText.Text = (running ? "正在启动" : (failed ? "启动失败" : ((percent >= 100.0) ? "启动完成" : "启动已停止")));
		LaunchStatusText.Text = status;
		((RangeBase)LaunchProgressBar).Value = percent;
		LaunchPercentText.Text = $"{percent:0.#}%";
		((Control)CancelLaunchButton).IsEnabled = running;
		bool flag = failed && retryAvailable && _retryContext.CanRetry;
		((ContentControl)RetryLaunchButton).Content = _retryContext.ButtonTitle;
		((UIElement)RetryLaunchButton).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		((Control)RetryLaunchButton).IsEnabled = flag && !running;
		if (!running)
		{
			((UIElement)LaunchTransferText).Visibility = (Visibility)1;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetLaunchStageText(pqWRiwfFbLTQvJu9JjbG progress)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected I4, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		switch (progress.ResourceStep)
		{
		case (tWpCAMfsWit9QyZsQNWD)0L:
			return "准备 Java 运行时";
		case (tWpCAMfsWit9QyZsQNWD)1L:
			return "准备基础版本";
		case (tWpCAMfsWit9QyZsQNWD)2L:
			return "准备游戏版本";
		case (tWpCAMfsWit9QyZsQNWD)3L:
			return "准备核心库";
		case (tWpCAMfsWit9QyZsQNWD)4L:
			return "准备认证组件";
		case (tWpCAMfsWit9QyZsQNWD)5L:
			return "准备服务器资源";
		case (tWpCAMfsWit9QyZsQNWD)6L:
			return "启动游戏进程";
		default:
		{
			uH1x9kfxnJ8cnPDOVSjO stage = progress.Stage;
			return (int)stage switch
			{
				0 => "校验游戏会话", 
				1 => "解析服务器入口", 
				2 => "下载游戏资源", 
				3 => "安装游戏资源", 
				4 => "准备运行目录", 
				5 => "启动本机代理与认证服务", 
				6 => "建立互联会话", 
				7 => "创建游戏进程", 
				8 => "等待进服确认", 
				_ => "启动完成", 
			};
		}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string BuildTransferText(pqWRiwfFbLTQvJu9JjbG progress)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		long? totalBytes = progress.TotalBytes;
		if (!totalBytes.HasValue || totalBytes.GetValueOrDefault() <= 0)
		{
			if (!string.IsNullOrWhiteSpace(progress.CurrentFile))
			{
				return progress.CurrentFile;
			}
			return string.Empty;
		}
		double? bytesPerSecond = progress.BytesPerSecond;
		string text = ((bytesPerSecond.HasValue && bytesPerSecond.GetValueOrDefault() > 0.0) ? (" · " + W0wBpiOcLVX0Ukx7VdU.MFpOy4Ua8e(progress.BytesPerSecond)) : string.Empty);
		TimeSpan? estimatedRemaining = progress.EstimatedRemaining;
		object obj;
		if (estimatedRemaining.HasValue)
		{
			TimeSpan valueOrDefault = estimatedRemaining.GetValueOrDefault();
			if (valueOrDefault > TimeSpan.Zero)
			{
				obj = $" · 约 {Math.Max(1, (int)Math.Ceiling(valueOrDefault.TotalSeconds))} 秒";
				goto IL_0102;
			}
		}
		obj = string.Empty;
		goto IL_0102;
		IL_0102:
		string text2 = (string)obj;
		return $"{W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(progress.BytesProcessed)} / {W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(progress.TotalBytes.Value)}{text}{text2}";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			_client.hMjFYVvoO3(ReadGameSettings());
			AppShell.Success("Java 启动配置已保存");
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SaveSettingsButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaServersPage.Launch.cs", 211);
			AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "检查配置值后重新保存"));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LoadGameSettings()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected I4, but got Unknown
		tkF3LRfxdkiPD0dqhesT val = default;
		try
		{
			val = _client.higFV0nXmU();
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "LoadGameSettings", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaServersPage.Launch.cs", 225);
			AppShell.Warning(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "使用当前安全默认值并重新保存"));
			val = new tkF3LRfxdkiPD0dqhesT();
		}
		MemoryBox.Value = val.MemoryMegabytes;
		AutoReconnectToggle.IsOn = val.AutoReconnect;
		ReconnectDelayBox.Value = val.ReconnectDelaySeconds;
		AutoSaveSettingsToggle.IsOn = val.AutoSaveGameSettings;
		ChineseToggle.IsOn = val.AutoSetChinese;
		GuiScaleToggle.IsOn = val.AutoSetGuiScale;
		GuiScaleBox.Value = val.GuiScale;
		WindowSizeToggle.IsOn = val.AutoSetWindowSize;
		WindowWidthBox.Value = val.WindowWidth;
		WindowHeightBox.Value = val.WindowHeight;
		ResourcePacksBox.Text = string.Join(Environment.NewLine, val.ResourcePacks);
		AutoJumpToggle.IsOn = val.AutoJump;
		((Selector)NarratorComboBox).SelectedIndex = Math.Clamp((int)val.Narrator, 0, 3);
		AccessibilityToggle.IsOn = val.CompleteAccessibilitySetup;
	}

	[MethodImpl((MethodImplOptions)8)]
	private tkF3LRfxdkiPD0dqhesT ReadGameSettings()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		tkF3LRfxdkiPD0dqhesT val = new tkF3LRfxdkiPD0dqhesT();
		val.GetType().GetProperty("MemoryMegabytes").SetValue(val, ReadInteger(MemoryBox, 4096));
		val.GetType().GetProperty("AutoReconnect").SetValue(val, AutoReconnectToggle.IsOn);
		val.GetType().GetProperty("ReconnectDelaySeconds").SetValue(val, ReadInteger(ReconnectDelayBox, 10));
		val.GetType().GetProperty("AutoSaveGameSettings").SetValue(val, AutoSaveSettingsToggle.IsOn);
		val.GetType().GetProperty("AutoSetChinese").SetValue(val, ChineseToggle.IsOn);
		val.GetType().GetProperty("AutoSetGuiScale").SetValue(val, GuiScaleToggle.IsOn);
		val.GetType().GetProperty("GuiScale").SetValue(val, ReadInteger(GuiScaleBox, 2));
		val.GetType().GetProperty("AutoSetWindowSize").SetValue(val, WindowSizeToggle.IsOn);
		val.GetType().GetProperty("WindowWidth").SetValue(val, ReadInteger(WindowWidthBox, 854));
		val.GetType().GetProperty("WindowHeight").SetValue(val, ReadInteger(WindowHeightBox, 480));
		string text = ResourcePacksBox.Text;
		char[] array = new char[4];
		val.GetType().GetProperty("ResourcePacks").SetValue(val, text.Split(array, (StringSplitOptions)3));
		val.GetType().GetProperty("AutoJump").SetValue(val, AutoJumpToggle.IsOn);
		val.GetType().GetProperty("Narrator").SetValue(val, (FePRPefxg9ZDZZ0a83Pb)Math.Clamp(((Selector)NarratorComboBox).SelectedIndex, 0, 3));
		val.GetType().GetProperty("CompleteAccessibilitySetup").SetValue(val, AccessibilityToggle.IsOn);
		return val.EoMfxHxm9I9();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int ReadInteger(NumberBox box, int fallback)
	{
		if (!double.IsFinite(box.Value))
		{
			return fallback;
		}
		return (int)Math.Round(box.Value);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ProxyLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ProxyLaunchButton_Click_d__42 proxyLaunchButton_Click_d__ = default(_ProxyLaunchButton_Click_d__42);
		proxyLaunchButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		proxyLaunchButton_Click_d__.__4__this = this;
		proxyLaunchButton_Click_d__.__1__state = -1;
		proxyLaunchButton_Click_d__.__t__builder.Start<_ProxyLaunchButton_Click_d__42>(ref proxyLaunchButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LaunchProxySelectedAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LaunchProxySelectedAsync_d__43 launchProxySelectedAsync_d__ = default(_LaunchProxySelectedAsync_d__43);
		launchProxySelectedAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		launchProxySelectedAsync_d__.__4__this = this;
		launchProxySelectedAsync_d__.__1__state = -1;
		launchProxySelectedAsync_d__.__t__builder.Start<_LaunchProxySelectedAsync_d__43>(ref launchProxySelectedAsync_d__);
		return launchProxySelectedAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaServersPage()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		_client = KxOGVaFL8AQcstEY1GC.Shared;
		_proxy = kXxcqCXUYs1qiIst9kaY.Shared;
		_retryContext = JavaServerRetryContext.None;
		_Servers_k__BackingField = new ObservableCollection<YlErsbfs35V4xTUvrlXK>();
		InitializeComponent();
		((ItemsControl)LaunchModeComboBox).ItemsSource = JavaLaunchModeOption.All;
		((Selector)LaunchModeComboBox).SelectedIndex = 0;
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_client);
		AppShell.RegisterDisposable((global::System.IDisposable)_proxy);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(JavaServersPage_Loaded);
		AppShell.SessionCleared += new EventHandler(AppShell_SessionCleared);
		AttachConnectionCoordinator(Yx0jy4NjAWxONbCjY3P.Shared);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void JavaServersPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_JavaServersPage_Loaded_d__62 javaServersPage_Loaded_d__ = default(_JavaServersPage_Loaded_d__62);
		javaServersPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		javaServersPage_Loaded_d__.__4__this = this;
		javaServersPage_Loaded_d__.__1__state = -1;
		javaServersPage_Loaded_d__.__t__builder.Start<_JavaServersPage_Loaded_d__62>(ref javaServersPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowCatalogLoading(string status)
	{
		CatalogStatusText.Text = status;
		CatalogProgressRing.IsActive = true;
		((UIElement)CatalogProgressRing).Visibility = (Visibility)0;
		((UIElement)EmptyPanel).Visibility = (((((Collection<YlErsbfs35V4xTUvrlXK>)(object)Servers).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		EmptyTitle.Text = status;
		EmptyDescription.Text = "请稍候";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearCatalog(string title, string description)
	{
		((Collection<YlErsbfs35V4xTUvrlXK>)(object)Servers).Clear();
		((Selector)ServerGrid).SelectedItem = null;
		_selectedServer = null;
		((UIElement)EmptyPanel).Visibility = (Visibility)0;
		EmptyTitle.Text = title;
		EmptyDescription.Text = description;
		CatalogStatusText.Text = description;
		ClearDetails();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearDetails()
	{
		DetailCover.ImageUrl = string.Empty;
		DetailName.Text = "选择一个服务器";
		DetailOnline.Text = string.Empty;
		DetailAuthor.Text = "作者信息将在这里显示";
		DetailDescription.Text = "从左侧目录选择服务器，查看信息并直接启动。";
		((ItemsControl)VersionComboBox).ItemsSource = null;
		((ItemsControl)RoleComboBox).ItemsSource = null;
		RoleStatusText.Text = "选择服务器后读取角色";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetControlsEnabled(bool enabled)
	{
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Invalid comparison between Unknown and I4
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Invalid comparison between Unknown and I4
		((Control)ServerSearchBox).IsEnabled = enabled;
		((Control)RefreshButton).IsEnabled = enabled && _client.CurrentSession != null;
		((Control)ServerGrid).IsEnabled = enabled;
		((Control)VersionComboBox).IsEnabled = enabled;
		((Control)RoleComboBox).IsEnabled = enabled;
		((Control)RefreshRolesButton).IsEnabled = enabled && _selectedServer != null;
		((Control)NewRoleNameBox).IsEnabled = enabled && _selectedServer != null;
		((Control)CreateRoleButton).IsEnabled = enabled && _selectedServer != null;
		((Control)MemoryBox).IsEnabled = enabled;
		((Control)AutoReconnectToggle).IsEnabled = enabled;
		((Control)ReconnectDelayBox).IsEnabled = enabled;
		((Control)AutoSaveSettingsToggle).IsEnabled = enabled;
		((Control)ChineseToggle).IsEnabled = enabled;
		((Control)GuiScaleToggle).IsEnabled = enabled;
		((Control)GuiScaleBox).IsEnabled = enabled;
		((Control)WindowSizeToggle).IsEnabled = enabled;
		((Control)WindowWidthBox).IsEnabled = enabled;
		((Control)WindowHeightBox).IsEnabled = enabled;
		((Control)ResourcePacksBox).IsEnabled = enabled;
		((Control)AutoJumpToggle).IsEnabled = enabled;
		((Control)NarratorComboBox).IsEnabled = enabled;
		((Control)AccessibilityToggle).IsEnabled = enabled;
		((Control)SaveSettingsButton).IsEnabled = enabled;
		Jj84PVNAj19tCbr5gHp? connectionCoordinator = _connectionCoordinator;
		int num;
		if (connectionCoordinator == null)
		{
			num = 0;
		}
		else
		{
			qC3ZV7fxXAJqu2TjY3Nc current = connectionCoordinator.Current;
			num = ((((current != null) ? new bool?(current.IsActive) : ((bool?)null)) == true) ? 1 : 0);
		}
		bool flag = (byte)num != 0;
		((Control)LaunchModeComboBox).IsEnabled = enabled && !flag;
		((Control)ProxyPortBox).IsEnabled = enabled && !flag && ShouldShowProxyPort();
		int num2 = default;
		if (_selectedServer != null && ((Selector)VersionComboBox).SelectedItem is ys1lxxfFBPhowwZS5N6T)
		{
			object selectedItem = ((Selector)RoleComboBox).SelectedItem;
			QTHpUQfsgtyJIMkBwTYM val = (QTHpUQfsgtyJIMkBwTYM)((selectedItem is QTHpUQfsgtyJIMkBwTYM) ? selectedItem : null);
			num2 = ((val != null && val.IsAvailable) ? 1 : 0);
		}
		else
		{
			num2 = 0;
		}
		bool flag2 = (byte)num2 != 0;
		((Control)EstablishEntryButton).IsEnabled = enabled && !flag && flag2;
		((Control)ProxyLaunchButton).IsEnabled = enabled && !flag && (int)((UIElement)ProxyLaunchButton).Visibility == 0 && flag2;
		((Control)LaunchButton).IsEnabled = enabled && !flag && (int)((UIElement)LaunchButton).Visibility == 0 && flag2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResponsiveRoot_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		Size newSize = e.NewSize;
		bool flag = newSize.Width >= 1040.0;
		DetailColumn.Width = (flag ? new GridLength(390.0) : new GridLength(0.0));
		CompactDetailRow.Height = (flag ? new GridLength(0.0) : new GridLength(1.0, (GridUnitType)2));
		Grid.SetRow((FrameworkElement)(object)DetailPanel, (!flag) ? 2 : 0);
		Grid.SetRowSpan((FrameworkElement)(object)DetailPanel, (!flag) ? 1 : 2);
		Grid.SetColumn((FrameworkElement)(object)DetailPanel, flag ? 1 : 0);
		((FrameworkElement)DetailPanel).Margin = (flag ? new Thickness(0.0) : new Thickness(0.0, 16.0, 0.0, 0.0));
		((FrameworkElement)DetailPanel).MinHeight = 0.0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ConnectionEntryGrid_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Size newSize = e.NewSize;
		_connectionEntryWidth = newSize.Width;
		UpdateConnectionEntryLayout();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateConnectionEntryLayout()
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		bool num = _connectionEntryWidth >= 920.0;
		bool flag = ShouldShowProxyPort();
		((UIElement)ProxyPortPanel).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		ProxyPortLabelText.Text = ((_compatibilityDestination == JavaCompatibilityDestination.IndependentProxy) ? "兼容代理端口（0 自动）" : "本机端口（0 自动）");
		if (num)
		{
			EntrySummaryColumn.Width = new GridLength(1.0, (GridUnitType)2);
			EntryModeColumn.Width = new GridLength(210.0);
			EntryPortColumn.Width = (flag ? new GridLength(150.0) : new GridLength(0.0));
			EntryActionColumn.Width = GridLength.Auto;
			PlaceEntryElement((FrameworkElement)(object)ConnectionEntrySummaryPanel, 0, 0);
			PlaceEntryElement((FrameworkElement)(object)LaunchModePanel, 0, 1);
			PlaceEntryElement((FrameworkElement)(object)ProxyPortPanel, 0, 2);
			PlaceEntryElement((FrameworkElement)(object)EstablishEntryButton, 0, 3);
			((FrameworkElement)EstablishEntryButton).HorizontalAlignment = (HorizontalAlignment)2;
			((FrameworkElement)EstablishEntryButton).Margin = new Thickness(0.0);
		}
		else
		{
			EntrySummaryColumn.Width = new GridLength(1.0, (GridUnitType)2);
			EntryModeColumn.Width = new GridLength(1.0, (GridUnitType)2);
			EntryPortColumn.Width = new GridLength(0.0);
			EntryActionColumn.Width = new GridLength(0.0);
			PlaceEntryElement((FrameworkElement)(object)ConnectionEntrySummaryPanel, 0, 0, 2);
			PlaceEntryElement((FrameworkElement)(object)LaunchModePanel, 1, 0, flag ? 1 : 2);
			PlaceEntryElement((FrameworkElement)(object)ProxyPortPanel, 1, 1);
			PlaceEntryElement((FrameworkElement)(object)EstablishEntryButton, 2, 0, 2);
			((FrameworkElement)EstablishEntryButton).HorizontalAlignment = (HorizontalAlignment)3;
			((FrameworkElement)EstablishEntryButton).Margin = new Thickness(0.0, 2.0, 0.0, 0.0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool ShouldShowProxyPort()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		if (_compatibilityDestination != JavaCompatibilityDestination.IndependentProxy)
		{
			JavaCompatibilityDestination? compatibilityDestination = _compatibilityDestination;
			if (!compatibilityDestination.HasValue)
			{
				return (int)_selectedLaunchMode == 0;
			}
			return false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void PlaceEntryElement(FrameworkElement element, int row, int column, int columnSpan = 1)
	{
		Grid.SetRow(element, row);
		Grid.SetColumn(element, column);
		Grid.SetColumnSpan(element, columnSpan);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AppShell_SessionCleared(object? sender, EventArgs e)
	{
		CancellationTokenSource? operation = _operation;
		if (operation != null)
		{
			operation.Cancel();
		}
		ResetConnectionRetry();
		ClearCatalog("等待服务器目录", "请先在 Java 账号配置建立游戏会话");
		SetControlsEnabled(enabled: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(JavaServersPage_Loaded);
			AppShell.SessionCleared -= new EventHandler(AppShell_SessionCleared);
			if (_connectionCoordinator != null)
			{
				_connectionCoordinator.Changed -= new EventHandler(ConnectionCoordinator_Changed);
				_connectionCoordinator = null;
			}
			CancellationTokenSource? operation = _operation;
			if (operation != null)
			{
				operation.Cancel();
			}
			CancellationTokenSource? operation2 = _operation;
			if (operation2 != null)
			{
				operation2.Dispose();
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
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaServersPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Expected O, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected O, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ResponsiveRoot = CastExtensions.As<Grid>(target);
			((FrameworkElement)ResponsiveRoot).SizeChanged += new SizeChangedEventHandler(ResponsiveRoot_SizeChanged);
			break;
		case 3:
			ConnectionEntryPanel = CastExtensions.As<Border>(target);
			break;
		case 4:
			ConnectionEntryGrid = CastExtensions.As<Grid>(target);
			((FrameworkElement)ConnectionEntryGrid).SizeChanged += new SizeChangedEventHandler(ConnectionEntryGrid_SizeChanged);
			break;
		case 5:
			EntrySummaryColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 6:
			EntryModeColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 7:
			EntryPortColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 8:
			EntryActionColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 9:
			ConnectionEntrySummaryPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 10:
			LaunchModePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 11:
			ProxyPortPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 12:
			EstablishEntryButton = CastExtensions.As<Button>(target);
			((ButtonBase)EstablishEntryButton).Click += new RoutedEventHandler(EstablishEntryButton_Click);
			break;
		case 13:
			EstablishEntryButtonIcon = CastExtensions.As<FontIcon>(target);
			break;
		case 14:
			EstablishEntryButtonText = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			ProxyPortLabelText = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			ProxyPortBox = CastExtensions.As<NumberBox>(target);
			break;
		case 17:
			LaunchModeComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)LaunchModeComboBox).SelectionChanged += new SelectionChangedEventHandler(LaunchModeComboBox_SelectionChanged);
			break;
		case 18:
			ConnectionEntryTitleText = CastExtensions.As<TextBlock>(target);
			break;
		case 19:
			ConnectionModeDescriptionText = CastExtensions.As<TextBlock>(target);
			break;
		case 20:
			DetailColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 21:
			CompactDetailRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 22:
			DetailPanel = CastExtensions.As<Border>(target);
			break;
		case 23:
			DetailDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 24:
			MemoryBox = CastExtensions.As<NumberBox>(target);
			break;
		case 25:
			AutoSaveSettingsToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 26:
			ChineseToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 27:
			WindowSizeToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 28:
			ResourcePacksBox = CastExtensions.As<TextBox>(target);
			break;
		case 29:
			AutoJumpToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 30:
			NarratorComboBox = CastExtensions.As<ComboBox>(target);
			break;
		case 31:
			AccessibilityToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 32:
			SaveSettingsButton = CastExtensions.As<Button>(target);
			((ButtonBase)SaveSettingsButton).Click += new RoutedEventHandler(SaveSettingsButton_Click);
			break;
		case 33:
			WindowWidthBox = CastExtensions.As<NumberBox>(target);
			break;
		case 34:
			WindowHeightBox = CastExtensions.As<NumberBox>(target);
			break;
		case 35:
			GuiScaleToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 36:
			GuiScaleBox = CastExtensions.As<NumberBox>(target);
			break;
		case 37:
			AutoReconnectToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 38:
			ReconnectDelayBox = CastExtensions.As<NumberBox>(target);
			break;
		case 39:
			RoleComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)RoleComboBox).SelectionChanged += new SelectionChangedEventHandler(LaunchSelection_Changed);
			break;
		case 40:
			RoleStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 41:
			NewRoleNameBox = CastExtensions.As<TextBox>(target);
			break;
		case 42:
			CreateRoleButton = CastExtensions.As<Button>(target);
			((ButtonBase)CreateRoleButton).Click += new RoutedEventHandler(CreateRoleButton_Click);
			break;
		case 43:
			RefreshRolesButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshRolesButton).Click += new RoutedEventHandler(RefreshRolesButton_Click);
			break;
		case 44:
			VersionComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)VersionComboBox).SelectionChanged += new SelectionChangedEventHandler(LaunchSelection_Changed);
			break;
		case 45:
			DetailName = CastExtensions.As<TextBlock>(target);
			break;
		case 46:
			DetailAuthor = CastExtensions.As<TextBlock>(target);
			break;
		case 47:
			DetailOnline = CastExtensions.As<TextBlock>(target);
			break;
		case 48:
			DetailCover = CastExtensions.As<BedrockNetworkImage>(target);
			break;
		case 49:
			ServerGrid = CastExtensions.As<GridView>(target);
			((ListViewBase)ServerGrid).ItemClick += new ItemClickEventHandler(ServerGrid_ItemClick);
			((Selector)ServerGrid).SelectionChanged += new SelectionChangedEventHandler(ServerGrid_SelectionChanged);
			break;
		case 50:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 51:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 52:
			EmptyDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 59:
			CatalogProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 60:
			CatalogStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 61:
			CompatibilityEntryPanel = CastExtensions.As<Border>(target);
			break;
		case 62:
			LaunchOperationPanel = CastExtensions.As<Border>(target);
			break;
		case 63:
			LaunchStageText = CastExtensions.As<TextBlock>(target);
			break;
		case 64:
			LaunchPercentText = CastExtensions.As<TextBlock>(target);
			break;
		case 65:
			RetryLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)RetryLaunchButton).Click += new RoutedEventHandler(RetryLaunchButton_Click);
			break;
		case 66:
			CancelLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelLaunchButton).Click += new RoutedEventHandler(CancelLaunchButton_Click);
			break;
		case 67:
			LaunchStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 68:
			LocalEndpointPanel = CastExtensions.As<Border>(target);
			break;
		case 69:
			LaunchTransferText = CastExtensions.As<TextBlock>(target);
			break;
		case 70:
			LaunchProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 71:
			CopyLocalEndpointButton = CastExtensions.As<Button>(target);
			((ButtonBase)CopyLocalEndpointButton).Click += new RoutedEventHandler(CopyLocalEndpointButton_Click);
			break;
		case 72:
			LocalEndpointAddressText = CastExtensions.As<TextBlock>(target);
			break;
		case 73:
			LaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)LaunchButton).Click += new RoutedEventHandler(LaunchButton_Click);
			break;
		case 74:
			ProxyLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)ProxyLaunchButton).Click += new RoutedEventHandler(ProxyLaunchButton_Click);
			break;
		case 75:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ReturnToDefaultEntryButton_Click);
			break;
		case 76:
			CompatibilityEntryTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 77:
			CompatibilityEntryDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 78:
			ServerSearchBox = CastExtensions.As<AutoSuggestBox>(target);
			ServerSearchBox.QuerySubmitted += ServerSearchBox_QuerySubmitted;
			ServerSearchBox.TextChanged += ServerSearchBox_TextChanged;
			break;
		case 79:
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
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 1:
		{
			Page val2 = (Page)target;
			JavaServersPage_obj1_Bindings javaServersPage_obj1_Bindings = (JavaServersPage_obj1_Bindings)new JavaServersPage_obj1_Bindings();
			result = (IComponentConnector)(object)javaServersPage_obj1_Bindings;
			javaServersPage_obj1_Bindings.SetDataRoot(this);
			Bindings = javaServersPage_obj1_Bindings;
			((FrameworkElement)val2).Loading += javaServersPage_obj1_Bindings.Loading;
			break;
		}
		case 54:
		{
			Grid val = (Grid)target;
			JavaServersPage_obj54_Bindings javaServersPage_obj54_Bindings = (JavaServersPage_obj54_Bindings)new JavaServersPage_obj54_Bindings();
			result = (IComponentConnector)(object)javaServersPage_obj54_Bindings;
			javaServersPage_obj54_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += javaServersPage_obj54_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)javaServersPage_obj54_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)javaServersPage_obj54_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void _ConnectionCoordinator_Changed_b__19_0()
	{
		if (!_disposed)
		{
			RefreshConnectionCoordinatorState();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

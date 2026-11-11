using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using K5FCrdFj16NFnFBU3KQ;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Controls.Java;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using NZ7BFNfTm5VG46qeZyiO;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using YXMjNoXcouOKeTTRMKFH;
using bUfedyCg1PBqhqIkB8r;
using kTag3lfTQlMnWtlhqJue;
using qS8vkpL43FlTMgcj0rgs;
using uOyCk4fTgaXUep5AxvBV;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class JavaSkinsPage : Page, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IJavaSkinsPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IJavaSkinsPage_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(UIElement obj, Visibility value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Visibility = value;
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

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	private class JavaSkinsPage_obj25_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IJavaSkinsPage_Bindings
	{
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		private class JavaSkinsPage_obj25_BindingsTracking
		{
			private WeakReference<JavaSkinsPage_obj25_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public JavaSkinsPage_obj25_BindingsTracking(JavaSkinsPage_obj25_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<JavaSkinsPage_obj25_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public JavaSkinsPage_obj25_Bindings TryGetBindingObject()
			{
				JavaSkinsPage_obj25_Bindings javaSkinsPage_obj25_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out javaSkinsPage_obj25_Bindings);
					if (javaSkinsPage_obj25_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return javaSkinsPage_obj25_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
				UpdateChildListeners_(null);
			}

			[MethodImpl((MethodImplOptions)8)]
			public void PropertyChanged_(object sender, PropertyChangedEventArgs e)
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				JavaSkinsPage_obj25_Bindings javaSkinsPage_obj25_Bindings = TryGetBindingObject();
				if (javaSkinsPage_obj25_Bindings == null)
				{
					return;
				}
				string propertyName = e.PropertyName;
				JavaSkinCardViewModel javaSkinCardViewModel = sender as JavaSkinCardViewModel;
				if (string.IsNullOrEmpty(propertyName))
				{
					if (javaSkinCardViewModel != null)
					{
						javaSkinsPage_obj25_Bindings.Update_AppliedVisibility(javaSkinCardViewModel.AppliedVisibility, 1073741824);
					}
				}
				else if (propertyName == "AppliedVisibility" && javaSkinCardViewModel != null)
				{
					javaSkinsPage_obj25_Bindings.Update_AppliedVisibility(javaSkinCardViewModel.AppliedVisibility, 1073741824);
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_(JavaSkinCardViewModel obj)
			{
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				JavaSkinsPage_obj25_Bindings javaSkinsPage_obj25_Bindings = TryGetBindingObject();
				if (javaSkinsPage_obj25_Bindings != null)
				{
					if (javaSkinsPage_obj25_Bindings.dataRoot != null)
					{
						((INotifyPropertyChanged)javaSkinsPage_obj25_Bindings.dataRoot).PropertyChanged -= new PropertyChangedEventHandler(PropertyChanged_);
					}
					if (obj != null)
					{
						javaSkinsPage_obj25_Bindings.dataRoot = obj;
						((INotifyPropertyChanged)obj).PropertyChanged += new PropertyChangedEventHandler(PropertyChanged_);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private JavaSkinCardViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj25;

		private Border obj26;

		private TextBlock obj27;

		private TextBlock obj28;

		private TextBlock obj29;

		private TextBlock obj30;

		private BedrockNetworkImage obj31;

		private JavaSkinsPage_obj25_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public JavaSkinsPage_obj25_Bindings()
		{
			bindingsTracking = (JavaSkinsPage_obj25_BindingsTracking)new JavaSkinsPage_obj25_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 25:
				obj25 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 26:
				obj26 = CastExtensions.As<Border>(target);
				break;
			case 27:
				obj27 = CastExtensions.As<TextBlock>(target);
				break;
			case 28:
				obj28 = CastExtensions.As<TextBlock>(target);
				break;
			case 29:
				obj29 = CastExtensions.As<TextBlock>(target);
				break;
			case 30:
				obj30 = CastExtensions.As<TextBlock>(target);
				break;
			case 31:
				obj31 = CastExtensions.As<BedrockNetworkImage>(target);
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
			object target = obj25.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<JavaSkinCardViewModel>(item), 1 << phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Recycle()
		{
			bindingsTracking.ReleaseAllListeners();
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
				dataRoot = CastExtensions.As<JavaSkinCardViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(JavaSkinCardViewModel obj, int phase)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			bindingsTracking.UpdateChildListeners_(obj);
			if (obj != null)
			{
				if ((phase & -1073741823) != 0)
				{
					Update_AppliedVisibility(obj.AppliedVisibility, phase);
				}
				if ((phase & -2147483647) != 0)
				{
					Update_Name(obj.Name, phase);
					Update_Developer(obj.Developer, phase);
					Update_MetricsText(obj.MetricsText, phase);
					Update_OwnershipText(obj.OwnershipText, phase);
					Update_CoverUrl(obj.CoverUrl, phase);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AppliedVisibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj26, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj27, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Developer(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj28, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_MetricsText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj29, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_OwnershipText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj30, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CoverUrl(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(obj31, obj, null);
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
	private class JavaSkinsPage_obj1_Bindings : IComponentConnector, IJavaSkinsPage_Bindings
	{
		private JavaSkinsPage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private GridView obj17;

		[MethodImpl((MethodImplOptions)8)]
		public JavaSkinsPage_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 17)
			{
				obj17 = CastExtensions.As<GridView>(target);
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
				dataRoot = CastExtensions.As<JavaSkinsPage>(newDataRoot);
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
		private void Update_(JavaSkinsPage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_Skins(obj.Skins, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Skins(ObservableCollection<JavaSkinCardViewModel> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __Client_SessionChanged_b__26_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0097;
				}
				javaSkinsPage.CancelOperation();
				javaSkinsPage.ClearPage();
				if (javaSkinsPage._loaded && javaSkinsPage._client.CurrentSession != null)
				{
					_u__ = javaSkinsPage.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Client_SessionChanged_b__26_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_0097;
				}
				goto end_IL_0011;
				IL_0097:
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

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0_6
	{
		public JavaSkinsPage __4__this;

		public gcmmptfTJGk6dCBYHIl7 skin;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0_6()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _ApplyButton_Click_b__0(CancellationToken token)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._client.UsDsUnVJan(skin, token);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ApplyButton_Click_b__1()
		{
			__4__this._currentSkinId = skin.Id;
			__4__this.CurrentSkinText.Text = "当前皮肤：" + skin.Name;
			AppShell.Success("Java 皮肤已应用");
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ApplyButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00c4;
				}
				__c__DisplayClass9_0_6 _c__DisplayClass9_0_ = (__c__DisplayClass9_0_6)new __c__DisplayClass9_0_6
				{
					__4__this = __4__this
				};
				if (javaSkinsPage._selectedSkin != null && javaSkinsPage._operation == null)
				{
					_c__DisplayClass9_0_.skin = javaSkinsPage._selectedSkin;
					_u__ = javaSkinsPage.RunSkinOperationAsync("正在应用皮肤", _c__DisplayClass9_0_._ApplyButton_Click_b__0, new Action(_c__DisplayClass9_0_._ApplyButton_Click_b__1)).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ApplyButton_Click_d__9>(ref _u__, ref this);
						return;
					}
					goto IL_00c4;
				}
				goto end_IL_0011;
				IL_00c4:
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
	private struct _CatalogSelector_SelectionChanged_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0090;
				}
				if (javaSkinsPage._loaded)
				{
					javaSkinsPage.SearchBox.Text = string.Empty;
					_u__ = javaSkinsPage.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CatalogSelector_SelectionChanged_d__0>(ref _u__, ref this);
						return;
					}
					goto IL_0090;
				}
				goto end_IL_0011;
				IL_0090:
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
	private struct _EnsureCurrentSkinAsync_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		public CancellationToken cancellationToken;

		private TaskAwaiter<LFf4EgfTB7txKTFSuZ2L> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter<LFf4EgfTB7txKTFSuZ2L> _u__ = default;
				if (num != 0)
				{
					_u__ = javaSkinsPage._client.SqgsoFEFcD(cancellationToken).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<LFf4EgfTB7txKTFSuZ2L>, _EnsureCurrentSkinAsync_d__8>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<LFf4EgfTB7txKTFSuZ2L>);
					num = (__1__state = -1);
				}
				LFf4EgfTB7txKTFSuZ2L result = _u__.GetResult();
				javaSkinsPage._currentSkinId = (result.IsDefault ? "10000" : result.SkinId);
				javaSkinsPage.CurrentSkinText.Text = (result.IsDefault ? "当前使用默认皮肤" : ("当前皮肤编号：" + result.SkinId));
				((Control)javaSkinsPage.ResetSkinButton).IsEnabled = !result.IsDefault;
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
	private struct _JavaSkinsPage_Loaded_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0093;
				}
				javaSkinsPage._loaded = true;
				javaSkinsPage.UpdateResponsiveLayout(((FrameworkElement)javaSkinsPage).ActualWidth);
				if (((Collection<JavaSkinCardViewModel>)(object)javaSkinsPage.Skins).Count == 0)
				{
					_u__ = javaSkinsPage.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _JavaSkinsPage_Loaded_d__25>(ref _u__, ref this);
						return;
					}
					goto IL_0093;
				}
				goto end_IL_0011;
				IL_0093:
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
	private struct _LoadDetailsAsync_d__29 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		public gcmmptfTJGk6dCBYHIl7 skin;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter<gcmmptfTJGk6dCBYHIl7> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0033;
				}
				if (javaSkinsPage._operation == null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0033;
				}
				goto end_IL_0011;
				IL_0033:
				try
				{
					if (num != 0)
					{
						javaSkinsPage._operation = _cancellation_5__2;
						javaSkinsPage.SetControlsEnabled(enabled: false);
						javaSkinsPage.PreviewProgressRing.IsActive = true;
						((UIElement)javaSkinsPage.PreviewProgressRing).Visibility = (Visibility)0;
						((UIElement)javaSkinsPage.PreviewEmptyPanel).Visibility = (Visibility)0;
						javaSkinsPage.PreviewEmptyTitle.Text = "正在加载皮肤详情";
					}
					try
					{
						TaskAwaiter<gcmmptfTJGk6dCBYHIl7> _u__ = default;
						if (num != 0)
						{
							_u__ = javaSkinsPage._client.CdlshiEKUE(skin.Id, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<gcmmptfTJGk6dCBYHIl7>, _LoadDetailsAsync_d__29>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<gcmmptfTJGk6dCBYHIl7>);
							num = (__1__state = -1);
						}
						gcmmptfTJGk6dCBYHIl7 result = _u__.GetResult();
						javaSkinsPage._selectedSkin = result;
						javaSkinsPage.PreviewImage.ImageUrl = javaSkinsPage._selectedSkin.ImageUrl;
						javaSkinsPage.PreviewName.Text = javaSkinsPage._selectedSkin.Name;
						javaSkinsPage.PreviewDeveloper.Text = javaSkinsPage._selectedSkin.DeveloperText;
						javaSkinsPage.PreviewSummary.Text = javaSkinsPage._selectedSkin.Summary;
						javaSkinsPage.PreviewStatusText.Text = javaSkinsPage._selectedSkin.MetricsText + (javaSkinsPage._selectedSkin.IsOwned ? " · 已拥有" : "");
						((UIElement)javaSkinsPage.PreviewEmptyPanel).Visibility = (Visibility)1;
						((ContentControl)javaSkinsPage.ApplyButton).Content = (string.Equals(javaSkinsPage._selectedSkin.Id, javaSkinsPage._currentSkinId, (StringComparison)4) ? "当前皮肤" : "应用皮肤");
					}
					catch (OperationCanceledException)
					{
						javaSkinsPage.PreviewEmptyTitle.Text = "预览已取消";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "LoadDetailsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaSkinsPage.xaml.cs", 108);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "重新选择皮肤并加载详情");
						javaSkinsPage.PreviewEmptyTitle.Text = "皮肤详情加载失败";
						javaSkinsPage.PreviewStatusText.Text = text;
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaSkinsPage._operation == _cancellation_5__2)
							{
								javaSkinsPage._operation = null;
							}
							javaSkinsPage.PreviewProgressRing.IsActive = false;
							((UIElement)javaSkinsPage.PreviewProgressRing).Visibility = (Visibility)1;
							javaSkinsPage.SetControlsEnabled(enabled: true);
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
	private struct _LoadMoreButton_Click_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0099;
				}
				sl0MnQfToFOG6cTWVbCc? currentPage = javaSkinsPage._currentPage;
				if (currentPage != null && currentPage.HasNextPage)
				{
					_u__ = javaSkinsPage.LoadPageAsync(javaSkinsPage._currentPage.PageNumber + 1, append: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadMoreButton_Click_d__4>(ref _u__, ref this);
						return;
					}
					goto IL_0099;
				}
				goto end_IL_0011;
				IL_0099:
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
	private struct _LoadPageAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		public bool append;

		public int pageNumber;

		private CancellationTokenSource _cancellation_5__2;

		private string _keyword_5__3;

		private TaskAwaiter __u__1;

		private TaskAwaiter<sl0MnQfToFOG6cTWVbCc> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				if ((uint)num <= 3u)
				{
					goto IL_007f;
				}
				if (javaSkinsPage._operation == null)
				{
					if (javaSkinsPage._client.CurrentSession != null)
					{
						_cancellation_5__2 = new CancellationTokenSource();
						goto IL_007f;
					}
					javaSkinsPage.ClearPage();
					javaSkinsPage.StatusText.Text = "尚未登录";
					javaSkinsPage.EmptyTitle.Text = "请先登录 Java 账号";
					javaSkinsPage.EmptyDescription.Text = "登录后可浏览、预览和应用皮肤";
				}
				goto end_IL_0011;
				IL_007f:
				try
				{
					if ((uint)num > 3u)
					{
						javaSkinsPage._operation = _cancellation_5__2;
						javaSkinsPage.SetControlsEnabled(enabled: false);
						javaSkinsPage.CatalogProgressRing.IsActive = true;
						((UIElement)javaSkinsPage.CatalogProgressRing).Visibility = (Visibility)0;
						((UIElement)javaSkinsPage.EmptyPanel).Visibility = (append ? Visibility.Visible : Visibility.Collapsed);
						javaSkinsPage.EmptyTitle.Text = "正在加载皮肤";
						javaSkinsPage.EmptyDescription.Text = "请稍候";
						javaSkinsPage.StatusText.Text = "正在读取 Java 皮肤目录";
					}
					try
					{
						TaskAwaiter _u__2 = default;
						TaskAwaiter<sl0MnQfToFOG6cTWVbCc> _u__ = default;
						sl0MnQfToFOG6cTWVbCc result;
						switch (num)
						{
						default:
							_u__2 = javaSkinsPage.EnsureCurrentSkinAsync(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadPageAsync_d__7>(ref _u__2, ref this);
								return;
							}
							goto IL_0177;
						case 0:
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_0177;
						case 1:
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<sl0MnQfToFOG6cTWVbCc>);
							num = (__1__state = -1);
							goto IL_021a;
						case 2:
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<sl0MnQfToFOG6cTWVbCc>);
							num = (__1__state = -1);
							goto IL_02a8;
						case 3:
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<sl0MnQfToFOG6cTWVbCc>);
								num = (__1__state = -1);
								goto IL_0325;
							}
							IL_021a:
							result = _u__.GetResult();
							break;
							IL_0177:
							_u__2.GetResult();
							_keyword_5__3 = javaSkinsPage.SearchBox.Text.Trim();
							if (!string.IsNullOrWhiteSpace(_keyword_5__3))
							{
								_u__ = javaSkinsPage._client.BN1s49E7tk(_keyword_5__3, pageNumber, _cancellation_5__2.Token).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sl0MnQfToFOG6cTWVbCc>, _LoadPageAsync_d__7>(ref _u__, ref this);
									return;
								}
								goto IL_021a;
							}
							if (((Selector)javaSkinsPage.CatalogSelector).SelectedIndex == 1)
							{
								_u__ = javaSkinsPage._client.XxDsCgZ9RC(pageNumber, _cancellation_5__2.Token).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 2);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sl0MnQfToFOG6cTWVbCc>, _LoadPageAsync_d__7>(ref _u__, ref this);
									return;
								}
								goto IL_02a8;
							}
							_u__ = javaSkinsPage._client.MyFsQUjnJA(pageNumber, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 3);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sl0MnQfToFOG6cTWVbCc>, _LoadPageAsync_d__7>(ref _u__, ref this);
								return;
							}
							goto IL_0325;
							IL_02a8:
							result = _u__.GetResult();
							break;
							IL_0325:
							result = _u__.GetResult();
							break;
						}
						if (!append)
						{
							((Collection<JavaSkinCardViewModel>)(object)javaSkinsPage.Skins).Clear();
							((Selector)javaSkinsPage.SkinGrid).SelectedItem = null;
							javaSkinsPage.ClearPreview();
						}
						global::System.Collections.Generic.IEnumerator<gcmmptfTJGk6dCBYHIl7> enumerator = ((global::System.Collections.Generic.IEnumerable<gcmmptfTJGk6dCBYHIl7>)result.Items).GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
							{
								gcmmptfTJGk6dCBYHIl7 current = enumerator.Current;
								((Collection<JavaSkinCardViewModel>)(object)javaSkinsPage.Skins).Add((JavaSkinCardViewModel)new JavaSkinCardViewModel(current, string.Equals(current.Id, javaSkinsPage._currentSkinId, (StringComparison)4)));
							}
						}
						finally
						{
							if (num < 0)
							{
								((global::System.IDisposable)enumerator)?.Dispose();
							}
						}
						javaSkinsPage._currentPage = result;
						((UIElement)javaSkinsPage.LoadMoreButton).Visibility = ((!result.HasNextPage) ? Visibility.Visible : Visibility.Collapsed);
						javaSkinsPage.StatusText.Text = $"已显示 {((Collection<JavaSkinCardViewModel>)(object)javaSkinsPage.Skins).Count} / {result.TotalItems} 个皮肤";
						((UIElement)javaSkinsPage.EmptyPanel).Visibility = (((((Collection<JavaSkinCardViewModel>)(object)javaSkinsPage.Skins).Count != 0)) ? Visibility.Visible : Visibility.Collapsed);
						javaSkinsPage.EmptyTitle.Text = (string.IsNullOrWhiteSpace(_keyword_5__3) ? "暂无可用皮肤" : "没有搜索结果");
						javaSkinsPage.EmptyDescription.Text = (string.IsNullOrWhiteSpace(_keyword_5__3) ? "可以刷新目录后重试" : "请更换关键词后重试");
						_keyword_5__3 = null;
					}
					catch (OperationCanceledException)
					{
						javaSkinsPage.StatusText.Text = "加载已取消，可以重新刷新";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "LoadPageAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaSkinsPage.Catalog.cs", 132);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "检查网络和登录状态后刷新皮肤目录");
						javaSkinsPage.StatusText.Text = text;
						((UIElement)javaSkinsPage.EmptyPanel).Visibility = (Visibility)0;
						javaSkinsPage.EmptyTitle.Text = "皮肤目录加载失败";
						javaSkinsPage.EmptyDescription.Text = text;
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaSkinsPage._operation == _cancellation_5__2)
							{
								javaSkinsPage._operation = null;
							}
							javaSkinsPage.CatalogProgressRing.IsActive = false;
							((UIElement)javaSkinsPage.CatalogProgressRing).Visibility = (Visibility)1;
							javaSkinsPage.SetControlsEnabled(enabled: true);
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
	private struct _RefreshButton_Click_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaSkinsPage.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__3>(ref _u__, ref this);
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
	private struct _ResetSkinButton_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage __8_locals4 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = __8_locals4.RunSkinOperationAsync("正在恢复默认皮肤", [MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (CancellationToken token) => __8_locals4._client.zpKsrvF070(token), (Action)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () =>
					{
						__8_locals4._currentSkinId = "10000";
						__8_locals4.CurrentSkinText.Text = "当前使用默认皮肤";
						AppShell.Success("已恢复 Java 默认皮肤");
					})).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ResetSkinButton_Click_d__10>(ref _u__, ref this);
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
	private struct _RunSkinOperationAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		public string status;

		public Func<CancellationToken, global::System.Threading.Tasks.Task> operation;

		public Action completed;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0043;
				}
				if (javaSkinsPage._operation == null && javaSkinsPage._client.CurrentSession != null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0043;
				}
				goto end_IL_0011;
				IL_0043:
				try
				{
					if (num != 0)
					{
						javaSkinsPage._operation = _cancellation_5__2;
						javaSkinsPage.SetControlsEnabled(enabled: false);
						javaSkinsPage.PreviewProgressRing.IsActive = true;
						((UIElement)javaSkinsPage.PreviewProgressRing).Visibility = (Visibility)0;
						javaSkinsPage.PreviewStatusText.Text = status;
					}
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = operation.Invoke(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunSkinOperationAsync_d__11>(ref _u__, ref this);
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
						completed.Invoke();
						javaSkinsPage.RefreshAppliedState();
					}
					catch (OperationCanceledException)
					{
						javaSkinsPage.PreviewStatusText.Text = "操作已取消，可以重新操作";
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "RunSkinOperationAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaSkinsPage.Operations.cs", 70);
						string text = pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex2, "检查登录状态后重新操作皮肤");
						javaSkinsPage.PreviewStatusText.Text = text;
						AppShell.Error(text);
					}
					finally
					{
						if (num < 0)
						{
							if (javaSkinsPage._operation == _cancellation_5__2)
							{
								javaSkinsPage._operation = null;
							}
							javaSkinsPage.PreviewProgressRing.IsActive = false;
							((UIElement)javaSkinsPage.PreviewProgressRing).Visibility = (Visibility)1;
							javaSkinsPage.SetControlsEnabled(enabled: true);
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
	private struct _SearchBox_QuerySubmitted_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaSkinsPage.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchBox_QuerySubmitted_d__1>(ref _u__, ref this);
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
	private struct _SearchBox_TextChanged_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

		public AutoSuggestBoxTextChangedEventArgs args;

		public AutoSuggestBox sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaSkinsPage javaSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00a0;
				}
				if (javaSkinsPage._loaded && (int)args.Reason == 0 && string.IsNullOrWhiteSpace(sender.Text))
				{
					_u__ = javaSkinsPage.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchBox_TextChanged_d__2>(ref _u__, ref this);
						return;
					}
					goto IL_00a0;
				}
				goto end_IL_0011;
				IL_00a0:
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
	private struct _SkinGrid_SelectionChanged_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaSkinsPage __4__this;

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
			JavaSkinsPage javaSkinsPage = __4__this;
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
				if (((Selector)javaSkinsPage.SkinGrid).SelectedItem is JavaSkinCardViewModel javaSkinCardViewModel)
				{
					_u__ = javaSkinsPage.LoadDetailsAsync(javaSkinCardViewModel.Skin).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SkinGrid_SelectionChanged_d__6>(ref _u__, ref this);
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

	private const double WideLayoutThreshold = 1000.0;

	private readonly KxOGVaFL8AQcstEY1GC _client;

	private CancellationTokenSource? _operation;

	private sl0MnQfToFOG6cTWVbCc? _currentPage;

	private gcmmptfTJGk6dCBYHIl7? _selectedSkin;

	private string _currentSkinId;

	private bool _disposed;

	private bool _loaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ResponsiveRoot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition PreviewColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition CompactPreviewRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border PreviewPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ApplyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ResetSkinButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewName;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewDeveloper;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewSummary;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockNetworkImage PreviewImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel PreviewEmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing PreviewProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewEmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentSkinText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private GridView SkinGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LoadMoreButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing CatalogProgressRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private FontIcon EmptyIcon;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox CatalogSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AutoSuggestBox SearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IJavaSkinsPage_Bindings Bindings;

	[field: CompilerGenerated]
	private ObservableCollection<JavaSkinCardViewModel> _Skins_k__BackingField;
	public ObservableCollection<JavaSkinCardViewModel> Skins
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CatalogSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CatalogSelector_SelectionChanged_d__0 catalogSelector_SelectionChanged_d__ = default(_CatalogSelector_SelectionChanged_d__0);
		catalogSelector_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		catalogSelector_SelectionChanged_d__.__4__this = this;
		catalogSelector_SelectionChanged_d__.__1__state = -1;
		catalogSelector_SelectionChanged_d__.__t__builder.Start<_CatalogSelector_SelectionChanged_d__0>(ref catalogSelector_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchBox_QuerySubmitted_d__1 searchBox_QuerySubmitted_d__ = default(_SearchBox_QuerySubmitted_d__1);
		searchBox_QuerySubmitted_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchBox_QuerySubmitted_d__.__4__this = this;
		searchBox_QuerySubmitted_d__.__1__state = -1;
		searchBox_QuerySubmitted_d__.__t__builder.Start<_SearchBox_QuerySubmitted_d__1>(ref searchBox_QuerySubmitted_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchBox_TextChanged_d__2 searchBox_TextChanged_d__ = default(_SearchBox_TextChanged_d__2);
		searchBox_TextChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchBox_TextChanged_d__.__4__this = this;
		searchBox_TextChanged_d__.sender = sender;
		searchBox_TextChanged_d__.args = args;
		searchBox_TextChanged_d__.__1__state = -1;
		searchBox_TextChanged_d__.__t__builder.Start<_SearchBox_TextChanged_d__2>(ref searchBox_TextChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__3 refreshButton_Click_d__ = default(_RefreshButton_Click_d__3);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__3>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LoadMoreButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadMoreButton_Click_d__4 loadMoreButton_Click_d__ = default(_LoadMoreButton_Click_d__4);
		loadMoreButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		loadMoreButton_Click_d__.__4__this = this;
		loadMoreButton_Click_d__.__1__state = -1;
		loadMoreButton_Click_d__.__t__builder.Start<_LoadMoreButton_Click_d__4>(ref loadMoreButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SkinGrid_ItemClick(object sender, ItemClickEventArgs e)
	{
		if (e.ClickedItem is JavaSkinCardViewModel selectedItem)
		{
			((Selector)SkinGrid).SelectedItem = selectedItem;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SkinGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SkinGrid_SelectionChanged_d__6 skinGrid_SelectionChanged_d__ = default(_SkinGrid_SelectionChanged_d__6);
		skinGrid_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		skinGrid_SelectionChanged_d__.__4__this = this;
		skinGrid_SelectionChanged_d__.__1__state = -1;
		skinGrid_SelectionChanged_d__.__t__builder.Start<_SkinGrid_SelectionChanged_d__6>(ref skinGrid_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadPageAsync(int pageNumber, bool append)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadPageAsync_d__7 loadPageAsync_d__ = default(_LoadPageAsync_d__7);
		loadPageAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadPageAsync_d__.__4__this = this;
		loadPageAsync_d__.pageNumber = pageNumber;
		loadPageAsync_d__.append = append;
		loadPageAsync_d__.__1__state = -1;
		loadPageAsync_d__.__t__builder.Start<_LoadPageAsync_d__7>(ref loadPageAsync_d__);
		return loadPageAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task EnsureCurrentSkinAsync(CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_EnsureCurrentSkinAsync_d__8 ensureCurrentSkinAsync_d__ = default(_EnsureCurrentSkinAsync_d__8);
		ensureCurrentSkinAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		ensureCurrentSkinAsync_d__.__4__this = this;
		ensureCurrentSkinAsync_d__.cancellationToken = cancellationToken;
		ensureCurrentSkinAsync_d__.__1__state = -1;
		ensureCurrentSkinAsync_d__.__t__builder.Start<_EnsureCurrentSkinAsync_d__8>(ref ensureCurrentSkinAsync_d__);
		return ensureCurrentSkinAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ApplyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ApplyButton_Click_d__9 applyButton_Click_d__ = default(_ApplyButton_Click_d__9);
		applyButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		applyButton_Click_d__.__4__this = this;
		applyButton_Click_d__.__1__state = -1;
		applyButton_Click_d__.__t__builder.Start<_ApplyButton_Click_d__9>(ref applyButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ResetSkinButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ResetSkinButton_Click_d__10 resetSkinButton_Click_d__ = default(_ResetSkinButton_Click_d__10);
		resetSkinButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		resetSkinButton_Click_d__.__4__this = this;
		resetSkinButton_Click_d__.__1__state = -1;
		resetSkinButton_Click_d__.__t__builder.Start<_ResetSkinButton_Click_d__10>(ref resetSkinButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunSkinOperationAsync(string status, Func<CancellationToken, global::System.Threading.Tasks.Task> operation, Action completed)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunSkinOperationAsync_d__11 runSkinOperationAsync_d__ = default(_RunSkinOperationAsync_d__11);
		runSkinOperationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runSkinOperationAsync_d__.__4__this = this;
		runSkinOperationAsync_d__.status = status;
		runSkinOperationAsync_d__.operation = operation;
		runSkinOperationAsync_d__.completed = completed;
		runSkinOperationAsync_d__.__1__state = -1;
		runSkinOperationAsync_d__.__t__builder.Start<_RunSkinOperationAsync_d__11>(ref runSkinOperationAsync_d__);
		return runSkinOperationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshAppliedState()
	{
		global::System.Collections.Generic.IEnumerator<JavaSkinCardViewModel> enumerator = ((Collection<JavaSkinCardViewModel>)(object)Skins).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				JavaSkinCardViewModel current = enumerator.Current;
				current.IsApplied = string.Equals(current.Skin.Id, _currentSkinId, (StringComparison)4);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		bool flag = _selectedSkin != null && string.Equals(_selectedSkin.Id, _currentSkinId, (StringComparison)4);
		((ContentControl)ApplyButton).Content = (flag ? "当前皮肤" : "应用皮肤");
		((Control)ApplyButton).IsEnabled = _selectedSkin != null && !flag && _operation == null;
		((Control)ResetSkinButton).IsEnabled = _currentSkinId != "10000" && _operation == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaSkinsPage()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		_client = KxOGVaFL8AQcstEY1GC.Shared;
		_currentSkinId = "10000";
		_Skins_k__BackingField = new ObservableCollection<JavaSkinCardViewModel>();
		InitializeComponent();
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_client);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(JavaSkinsPage_Loaded);
		_client.SessionChanged += new EventHandler(Client_SessionChanged);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void JavaSkinsPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_JavaSkinsPage_Loaded_d__25 javaSkinsPage_Loaded_d__ = default(_JavaSkinsPage_Loaded_d__25);
		javaSkinsPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		javaSkinsPage_Loaded_d__.__4__this = this;
		javaSkinsPage_Loaded_d__.__1__state = -1;
		javaSkinsPage_Loaded_d__.__t__builder.Start<_JavaSkinsPage_Loaded_d__25>(ref javaSkinsPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Client_SessionChanged(object? sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		if (!((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__Client_SessionChanged_b__26_0_d _Client_SessionChanged_b__26_0_d = default(__Client_SessionChanged_b__26_0_d);
			_Client_SessionChanged_b__26_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_Client_SessionChanged_b__26_0_d.__4__this = this;
			_Client_SessionChanged_b__26_0_d.__1__state = -1;
			_Client_SessionChanged_b__26_0_d.__t__builder.Start<__Client_SessionChanged_b__26_0_d>(ref _Client_SessionChanged_b__26_0_d);
		})))
		{
			CancelOperation();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResponsiveRoot_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Size newSize = e.NewSize;
		UpdateResponsiveLayout(newSize.Width);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateResponsiveLayout(double width)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		bool flag = width >= 1000.0;
		PreviewColumn.Width = (flag ? new GridLength(400.0) : new GridLength(0.0));
		CompactPreviewRow.Height = (GridLength)(flag ? new GridLength(0.0) : GridLength.Auto);
		Grid.SetColumn((FrameworkElement)(object)PreviewPanel, flag ? 1 : 0);
		Grid.SetRow((FrameworkElement)(object)PreviewPanel, (!flag) ? 2 : 0);
		Grid.SetRowSpan((FrameworkElement)(object)PreviewPanel, (!flag) ? 1 : 2);
		((FrameworkElement)PreviewPanel).Margin = (flag ? new Thickness(0.0) : new Thickness(0.0, 18.0, 0.0, 0.0));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadDetailsAsync(gcmmptfTJGk6dCBYHIl7 skin)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadDetailsAsync_d__29 loadDetailsAsync_d__ = default(_LoadDetailsAsync_d__29);
		loadDetailsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadDetailsAsync_d__.__4__this = this;
		loadDetailsAsync_d__.skin = skin;
		loadDetailsAsync_d__.__1__state = -1;
		loadDetailsAsync_d__.__t__builder.Start<_LoadDetailsAsync_d__29>(ref loadDetailsAsync_d__);
		return loadDetailsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetControlsEnabled(bool enabled)
	{
		((Control)CatalogSelector).IsEnabled = enabled;
		((Control)SearchBox).IsEnabled = enabled;
		((Control)RefreshButton).IsEnabled = enabled;
		((Control)SkinGrid).IsEnabled = enabled;
		((Control)LoadMoreButton).IsEnabled = enabled;
		bool flag = _selectedSkin != null && string.Equals(_selectedSkin.Id, _currentSkinId, (StringComparison)4);
		((Control)ApplyButton).IsEnabled = enabled && _selectedSkin != null && !flag;
		((Control)ResetSkinButton).IsEnabled = enabled && _currentSkinId != "10000";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearPage()
	{
		((Collection<JavaSkinCardViewModel>)(object)Skins).Clear();
		_currentPage = null;
		_currentSkinId = "10000";
		((UIElement)LoadMoreButton).Visibility = (Visibility)1;
		((UIElement)EmptyPanel).Visibility = (Visibility)0;
		CurrentSkinText.Text = "登录后读取当前游戏内皮肤";
		ClearPreview();
		SetControlsEnabled(enabled: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearPreview()
	{
		_selectedSkin = null;
		PreviewImage.ImageUrl = string.Empty;
		PreviewName.Text = "未选择皮肤";
		PreviewDeveloper.Text = string.Empty;
		PreviewSummary.Text = string.Empty;
		PreviewStatusText.Text = string.Empty;
		((UIElement)PreviewEmptyPanel).Visibility = (Visibility)0;
		PreviewEmptyTitle.Text = "选择皮肤开始预览";
		((ContentControl)ApplyButton).Content = "应用皮肤";
		((Control)ApplyButton).IsEnabled = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelOperation()
	{
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
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(JavaSkinsPage_Loaded);
			_client.SessionChanged -= new EventHandler(Client_SessionChanged);
			CancelOperation();
			CancellationTokenSource? operation = _operation;
			if (operation != null)
			{
				operation.Dispose();
			}
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
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaSkinsPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ResponsiveRoot = CastExtensions.As<Grid>(target);
			((FrameworkElement)ResponsiveRoot).SizeChanged += new SizeChangedEventHandler(ResponsiveRoot_SizeChanged);
			break;
		case 3:
			PreviewColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 4:
			CompactPreviewRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 5:
			PreviewPanel = CastExtensions.As<Border>(target);
			break;
		case 6:
			ApplyButton = CastExtensions.As<Button>(target);
			((ButtonBase)ApplyButton).Click += new RoutedEventHandler(ApplyButton_Click);
			break;
		case 7:
			ResetSkinButton = CastExtensions.As<Button>(target);
			((ButtonBase)ResetSkinButton).Click += new RoutedEventHandler(ResetSkinButton_Click);
			break;
		case 8:
			PreviewName = CastExtensions.As<TextBlock>(target);
			break;
		case 9:
			PreviewDeveloper = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			PreviewSummary = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			PreviewStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			PreviewImage = CastExtensions.As<BedrockNetworkImage>(target);
			break;
		case 13:
			PreviewEmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 14:
			PreviewProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 15:
			PreviewEmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			CurrentSkinText = CastExtensions.As<TextBlock>(target);
			break;
		case 17:
			SkinGrid = CastExtensions.As<GridView>(target);
			((ListViewBase)SkinGrid).ItemClick += new ItemClickEventHandler(SkinGrid_ItemClick);
			((Selector)SkinGrid).SelectionChanged += new SelectionChangedEventHandler(SkinGrid_SelectionChanged);
			break;
		case 18:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 19:
			LoadMoreButton = CastExtensions.As<Button>(target);
			((ButtonBase)LoadMoreButton).Click += new RoutedEventHandler(LoadMoreButton_Click);
			break;
		case 20:
			CatalogProgressRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 21:
			EmptyIcon = CastExtensions.As<FontIcon>(target);
			break;
		case 22:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 23:
			EmptyDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 32:
			CatalogSelector = CastExtensions.As<ComboBox>(target);
			((Selector)CatalogSelector).SelectionChanged += new SelectionChangedEventHandler(CatalogSelector_SelectionChanged);
			break;
		case 33:
			SearchBox = CastExtensions.As<AutoSuggestBox>(target);
			SearchBox.QuerySubmitted += SearchBox_QuerySubmitted;
			SearchBox.TextChanged += SearchBox_TextChanged;
			break;
		case 34:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 35:
			StatusText = CastExtensions.As<TextBlock>(target);
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
			JavaSkinsPage_obj1_Bindings javaSkinsPage_obj1_Bindings = (JavaSkinsPage_obj1_Bindings)new JavaSkinsPage_obj1_Bindings();
			result = (IComponentConnector)(object)javaSkinsPage_obj1_Bindings;
			javaSkinsPage_obj1_Bindings.SetDataRoot(this);
			Bindings = javaSkinsPage_obj1_Bindings;
			((FrameworkElement)val2).Loading += javaSkinsPage_obj1_Bindings.Loading;
			break;
		}
		case 25:
		{
			Grid val = (Grid)target;
			JavaSkinsPage_obj25_Bindings javaSkinsPage_obj25_Bindings = (JavaSkinsPage_obj25_Bindings)new JavaSkinsPage_obj25_Bindings();
			result = (IComponentConnector)(object)javaSkinsPage_obj25_Bindings;
			javaSkinsPage_obj25_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += javaSkinsPage_obj25_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)javaSkinsPage_obj25_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)javaSkinsPage_obj25_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _ResetSkinButton_Click_b__10_0(CancellationToken token)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return _client.zpKsrvF070(token);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void _ResetSkinButton_Click_b__10_1()
	{
		_currentSkinId = "10000";
		CurrentSkinText.Text = "当前使用默认皮肤";
		AppShell.Success("已恢复 Java 默认皮肤");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private void _Client_SessionChanged_b__26_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__Client_SessionChanged_b__26_0_d _Client_SessionChanged_b__26_0_d = default(__Client_SessionChanged_b__26_0_d);
		_Client_SessionChanged_b__26_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		_Client_SessionChanged_b__26_0_d.__4__this = this;
		_Client_SessionChanged_b__26_0_d.__1__state = -1;
		_Client_SessionChanged_b__26_0_d.__t__builder.Start<__Client_SessionChanged_b__26_0_d>(ref _Client_SessionChanged_b__26_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

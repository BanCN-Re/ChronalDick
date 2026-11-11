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
using IU7UTPfFQa3t5mwomQTu;
using IuqQinfT23xjoF4oaqQu;
using K5FCrdFj16NFnFBU3KQ;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.ApplicationModel.DataTransfer;
using YXMjNoXcouOKeTTRMKFH;
using bUfedyCg1PBqhqIkB8r;
using cIxlXCXUST0hXJn4yluJ;
using h0gZa9fFSAVM5Du5jTuE;
using qS8vkpL43FlTMgcj0rgs;
using rEWmcPfNAhtZSJjsJvk3;
using zX707pfFXiAmiNASTxFS;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class JavaCompatibilityInstancesPage : Page, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IJavaCompatibilityInstancesPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IJavaCompatibilityInstancesPage_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled(Control obj, bool value)
		{
			obj.IsEnabled = value;
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
	private class JavaCompatibilityInstancesPage_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IJavaCompatibilityInstancesPage_Bindings
	{
		private bq7k3qfN7qMnvLJMNOZa dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private TextBlock obj6;

		private Button obj7;

		private Button obj8;

		private Button obj9;

		private TextBlock obj10;

		private TextBlock obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private TextBlock obj14;

		private TextBlock obj15;

		[MethodImpl((MethodImplOptions)8)]
		public JavaCompatibilityInstancesPage_obj5_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			switch (connectionId)
			{
			case 5:
				obj5 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 6:
				obj6 = CastExtensions.As<TextBlock>(target);
				break;
			case 7:
				obj7 = CastExtensions.As<Button>(target);
				break;
			case 8:
				obj8 = CastExtensions.As<Button>(target);
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
			object target = obj5.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<bq7k3qfN7qMnvLJMNOZa>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<bq7k3qfN7qMnvLJMNOZa>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(bq7k3qfN7qMnvLJMNOZa obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_StartedAtText(obj.StartedAtText, phase);
				Update_LocalAddressText(obj.LocalAddressText, phase);
				Update_Id(obj.Id, phase);
				Update_CanStop(obj.CanStop, phase);
				Update_CanRetry(obj.CanRetry, phase);
				Update_VersionName(obj.VersionName, phase);
				Update_TrafficText(obj.TrafficText, phase);
				Update_StateText(obj.StateText, phase);
				Update_ServerRoleText(obj.ServerRoleText, phase);
				Update_DisconnectText(obj.DisconnectText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StartedAtText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_LocalAddressText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj7, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Id(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj8, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CanStop(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj8, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CanRetry(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj9, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_VersionName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TrafficText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StateText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ServerRoleText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj14, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DisconnectText(string obj, int phase)
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

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class JavaCompatibilityInstancesPage_obj21_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IJavaCompatibilityInstancesPage_Bindings
	{
		private rIp8CZfFJ2ofCfwfl3J2 dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj21;

		private TextBlock obj22;

		private Button obj23;

		private Button obj24;

		private Button obj25;

		private Button obj26;

		private TextBlock obj27;

		private TextBlock obj28;

		private TextBlock obj29;

		private TextBlock obj30;

		private TextBlock obj31;

		private TextBlock obj32;

		[MethodImpl((MethodImplOptions)8)]
		public JavaCompatibilityInstancesPage_obj21_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			switch (connectionId)
			{
			case 21:
				obj21 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 22:
				obj22 = CastExtensions.As<TextBlock>(target);
				break;
			case 23:
				obj23 = CastExtensions.As<Button>(target);
				break;
			case 24:
				obj24 = CastExtensions.As<Button>(target);
				break;
			case 25:
				obj25 = CastExtensions.As<Button>(target);
				break;
			case 26:
				obj26 = CastExtensions.As<Button>(target);
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
				obj31 = CastExtensions.As<TextBlock>(target);
				break;
			case 32:
				obj32 = CastExtensions.As<TextBlock>(target);
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
			object target = obj21.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<rIp8CZfFJ2ofCfwfl3J2>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<rIp8CZfFJ2ofCfwfl3J2>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(rIp8CZfFJ2ofCfwfl3J2 obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_StartedAtText(obj.StartedAtText, phase);
				Update_WorkingDirectory(obj.WorkingDirectory, phase);
				Update_PrimaryCrashArtifactPath(obj.PrimaryCrashArtifactPath, phase);
				Update_HasRawCrashArtifact(obj.HasRawCrashArtifact, phase);
				Update_Id(obj.Id, phase);
				Update_CanStop(obj.CanStop, phase);
				Update_CanRestart(obj.CanRestart, phase);
				Update_ProcessIdText(obj.ProcessIdText, phase);
				Update_RoleName(obj.RoleName, phase);
				Update_Version(obj.Version, phase);
				Update_StatusText(obj.StatusText, phase);
				Update_ServerName(obj.ServerName, phase);
				Update_DetailText(obj.DetailText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StartedAtText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_WorkingDirectory(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj23, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PrimaryCrashArtifactPath(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj24, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_HasRawCrashArtifact(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj24, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Id(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj25, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter((ButtonBase)(object)obj26, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CanStop(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj25, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CanRestart(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Control_IsEnabled((Control)(object)obj26, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ProcessIdText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj27, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_RoleName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj28, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Version(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj29, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj30, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ServerName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj31, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DetailText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj32, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	private class JavaCompatibilityInstancesPage_obj1_Bindings : IComponentConnector, IJavaCompatibilityInstancesPage_Bindings
	{
		private JavaCompatibilityInstancesPage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ListView obj3;

		private ListView obj19;

		[MethodImpl((MethodImplOptions)8)]
		public JavaCompatibilityInstancesPage_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				obj3 = CastExtensions.As<ListView>(target);
				break;
			case 19:
				obj19 = CastExtensions.As<ListView>(target);
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
				dataRoot = CastExtensions.As<JavaCompatibilityInstancesPage>(newDataRoot);
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
		private void Update_(JavaCompatibilityInstancesPage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -2147483647) != 0)
			{
				Update_ProxyInstances(obj.ProxyInstances, phase);
				Update_ManagedInstances(obj.ManagedInstances, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ProxyInstances(ObservableCollection<bq7k3qfN7qMnvLJMNOZa> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj3, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ManagedInstances(ObservableCollection<rIp8CZfFJ2ofCfwfl3J2> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj19, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_4
	{
		public static readonly __c_4 __9;

		public static Func<rIp8CZfFJ2ofCfwfl3J2, bool> __9__16_0;

		public static Func<bq7k3qfN7qMnvLJMNOZa, bool> __9__16_1;

		public static Func<bq7k3qfN7qMnvLJMNOZa, bool> __9__16_2;

		public static Func<bq7k3qfN7qMnvLJMNOZa, bool> __9__20_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_4()
		{
			__9 = (__c_4)new __c_4();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_4()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Refresh_b__16_0(rIp8CZfFJ2ofCfwfl3J2 instance)
		{
			if (!instance.CanStop)
			{
				return instance.IsRunning;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Refresh_b__16_1(bq7k3qfN7qMnvLJMNOZa proxy)
		{
			return proxy.CanStop;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Refresh_b__16_2(bq7k3qfN7qMnvLJMNOZa proxy)
		{
			return proxy.CanStop;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _StopAllProxyButton_Click_b__20_0(bq7k3qfN7qMnvLJMNOZa item)
		{
			return item.CanStop;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass17_0
	{
		public string id;

		public JavaCompatibilityInstancesPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass17_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _StopManagedButton_Click_b__0(rIp8CZfFJ2ofCfwfl3J2 item)
		{
			return item.Id == id;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _StopManagedButton_Click_b__1()
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._client.vgEF64ekHp(id, default(CancellationToken));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass19_0
	{
		public string id;

		public JavaCompatibilityInstancesPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass19_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _StopProxyButton_Click_b__0(bq7k3qfN7qMnvLJMNOZa item)
		{
			return item.Id == id;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _StopProxyButton_Click_b__1()
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._proxy.NHAXU8oquPT(id, default(CancellationToken));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RetryManagedButton_Click_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public JavaCompatibilityInstancesPage __4__this;

		private TaskAwaiter<ODG5TvfFY1lU8Uhmpn4V> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaCompatibilityInstancesPage javaCompatibilityInstancesPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0059;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				string text = default(string);
				if (val != null)
				{
					text = ((ButtonBase)val).CommandParameter as string;
					if (text != null && !javaCompatibilityInstancesPage._operationInProgress)
					{
						javaCompatibilityInstancesPage._operationInProgress = true;
						javaCompatibilityInstancesPage.Refresh();
						goto IL_0059;
					}
				}
				goto end_IL_0011;
				IL_0059:
					text = default;
				try
				{
					TaskAwaiter<ODG5TvfFY1lU8Uhmpn4V> _u__ = default;
					if (num != 0)
					{
						_u__ = javaCompatibilityInstancesPage._client.k3rFRo1vqd(text, (IProgress<pqWRiwfFbLTQvJu9JjbG>)null, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ODG5TvfFY1lU8Uhmpn4V>, _RetryManagedButton_Click_d__18>(ref _u__, ref this);
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
					javaCompatibilityInstancesPage.Refresh();
					AppShell.Success("旧托管客户端已重新启动，进程 ID：" + result.ProcessId);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RetryManagedButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaCompatibilityInstancesPage.xaml.cs", 152);
					AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "检查旧版本资源和账号会话后重新启动"));
				}
				finally
				{
					if (num < 0)
					{
						javaCompatibilityInstancesPage._operationInProgress = false;
						javaCompatibilityInstancesPage.Refresh();
					}
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
	private struct _RetryProxyButton_Click_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public JavaCompatibilityInstancesPage __4__this;

		private TaskAwaiter<w059WIfTE0Fg0LMhfHCu> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaCompatibilityInstancesPage javaCompatibilityInstancesPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0059;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				string text = default(string);
				if (val != null)
				{
					text = ((ButtonBase)val).CommandParameter as string;
					if (text != null && !javaCompatibilityInstancesPage._operationInProgress)
					{
						javaCompatibilityInstancesPage._operationInProgress = true;
						javaCompatibilityInstancesPage.Refresh();
						goto IL_0059;
					}
				}
				goto end_IL_0011;
				IL_0059:
					text = default;
				try
				{
					TaskAwaiter<w059WIfTE0Fg0LMhfHCu> _u__ = default;
					if (num != 0)
					{
						_u__ = javaCompatibilityInstancesPage._proxy.QSnXUWwTPu1(text, (IProgress<pqWRiwfFbLTQvJu9JjbG>)null, default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<w059WIfTE0Fg0LMhfHCu>, _RetryProxyButton_Click_d__21>(ref _u__, ref this);
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
					javaCompatibilityInstancesPage.Refresh();
					AppShell.Success("独立代理已重新就绪，请连接 " + result.LocalAddressText);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RetryProxyButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaCompatibilityInstancesPage.xaml.cs", 228);
					AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "检查旧代理的账号、角色和网络服绑定后重试"));
				}
				finally
				{
					if (num < 0)
					{
						javaCompatibilityInstancesPage._operationInProgress = false;
						javaCompatibilityInstancesPage.Refresh();
					}
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
	private struct _RunOperationAsync_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaCompatibilityInstancesPage __4__this;

		public Func<global::System.Threading.Tasks.Task> operation;

		public string successMessage;

		public string nextStep;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaCompatibilityInstancesPage javaCompatibilityInstancesPage = __4__this;
			try
			{
				if (num != 0)
				{
					javaCompatibilityInstancesPage._operationInProgress = true;
					((Control)javaCompatibilityInstancesPage.ManagedInstanceList).IsEnabled = false;
					((Control)javaCompatibilityInstancesPage.ProxyInstanceList).IsEnabled = false;
					((Control)javaCompatibilityInstancesPage.StopAllProxyButton).IsEnabled = false;
				}
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = operation.Invoke().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunOperationAsync_d__23>(ref _u__, ref this);
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
					javaCompatibilityInstancesPage.Refresh();
					AppShell.Success(successMessage);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RunOperationAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaCompatibilityInstancesPage.xaml.cs", 281);
					AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, nextStep));
				}
				finally
				{
					if (num < 0)
					{
						javaCompatibilityInstancesPage._operationInProgress = false;
						((Control)javaCompatibilityInstancesPage.ManagedInstanceList).IsEnabled = true;
						((Control)javaCompatibilityInstancesPage.ProxyInstanceList).IsEnabled = true;
						javaCompatibilityInstancesPage.Refresh();
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
	private struct _StopAllProxyButton_Click_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaCompatibilityInstancesPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaCompatibilityInstancesPage __8_locals4 = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00fb;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0181;
				}
				bool flag;
				if (!__8_locals4._operationInProgress)
				{
					int num2 = Enumerable.Count<bq7k3qfN7qMnvLJMNOZa>((global::System.Collections.Generic.IEnumerable<bq7k3qfN7qMnvLJMNOZa>)__8_locals4.ProxyInstances, (Func<bq7k3qfN7qMnvLJMNOZa, bool>)__c_4.__9._StopAllProxyButton_Click_b__20_0);
					flag = num2 == 0;
					if (!flag)
					{
						_u__ = AppShell.ConfirmAsync("停止全部独立代理？", $"将断开当前 {num2} 个兼容代理并释放其本机端口。", "停止全部").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _StopAllProxyButton_Click_d__20>(ref _u__, ref this);
							return;
						}
						goto IL_00fb;
					}
					goto IL_0106;
				}
				goto end_IL_0011;
				IL_0181:
				_u__2.GetResult();
				goto end_IL_0011;
				IL_0106:
				if (!flag)
				{
					_u__2 = __8_locals4.RunOperationAsync([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () => __8_locals4._proxy.k2QXUJ3SkpE(default(CancellationToken)), "全部独立代理已停止", "刷新兼容实例后重新停止代理").GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StopAllProxyButton_Click_d__20>(ref _u__2, ref this);
						return;
					}
					goto IL_0181;
				}
				goto end_IL_0011;
				IL_00fb:
				flag = !_u__.GetResult();
				goto IL_0106;
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
	private struct _StopManagedButton_Click_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaCompatibilityInstancesPage __4__this;

		public object sender;

		private __c__DisplayClass17_0 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaCompatibilityInstancesPage javaCompatibilityInstancesPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_0133;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_01b9;
				}
				__8__1 = (__c__DisplayClass17_0)new __c__DisplayClass17_0();
				__8__1.__4__this = __4__this;
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object commandParameter = ((ButtonBase)val).CommandParameter;
					__8__1.id = commandParameter as string;
					if (__8__1.id != null && !javaCompatibilityInstancesPage._operationInProgress)
					{
						rIp8CZfFJ2ofCfwfl3J2 val2 = Enumerable.FirstOrDefault<rIp8CZfFJ2ofCfwfl3J2>((global::System.Collections.Generic.IEnumerable<rIp8CZfFJ2ofCfwfl3J2>)javaCompatibilityInstancesPage.ManagedInstances, (Func<rIp8CZfFJ2ofCfwfl3J2, bool>)__8__1._StopManagedButton_Click_b__0);
						_u__ = AppShell.ConfirmAsync("停止旧托管客户端？", "只会停止本项目创建的“" + (((val2 != null) ? val2.ServerName : null) ?? "当前实例") + "”游戏进程与配套服务。", "停止实例").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _StopManagedButton_Click_d__17>(ref _u__, ref this);
							return;
						}
						goto IL_0133;
					}
				}
				goto end_IL_0011;
				IL_01b9:
				_u__2.GetResult();
				goto end_IL_0011;
				IL_0133:
				if (_u__.GetResult())
				{
					_u__2 = javaCompatibilityInstancesPage.RunOperationAsync(__8__1._StopManagedButton_Click_b__1, "旧托管客户端已停止", "刷新兼容实例后重新停止").GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StopManagedButton_Click_d__17>(ref _u__2, ref this);
						return;
					}
					goto IL_01b9;
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
	private struct _StopProxyButton_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaCompatibilityInstancesPage __4__this;

		public object sender;

		private __c__DisplayClass19_0 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaCompatibilityInstancesPage javaCompatibilityInstancesPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_0133;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_01b9;
				}
				__8__1 = (__c__DisplayClass19_0)new __c__DisplayClass19_0();
				__8__1.__4__this = __4__this;
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object commandParameter = ((ButtonBase)val).CommandParameter;
					__8__1.id = commandParameter as string;
					if (__8__1.id != null && !javaCompatibilityInstancesPage._operationInProgress)
					{
						bq7k3qfN7qMnvLJMNOZa val2 = Enumerable.FirstOrDefault<bq7k3qfN7qMnvLJMNOZa>((global::System.Collections.Generic.IEnumerable<bq7k3qfN7qMnvLJMNOZa>)javaCompatibilityInstancesPage.ProxyInstances, (Func<bq7k3qfN7qMnvLJMNOZa, bool>)__8__1._StopProxyButton_Click_b__0);
						_u__ = AppShell.ConfirmAsync("停止独立代理？", "将断开“" + (((val2 != null) ? val2.ServerRoleText : null) ?? "当前代理") + "”并释放其本机端口。", "停止代理").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _StopProxyButton_Click_d__19>(ref _u__, ref this);
							return;
						}
						goto IL_0133;
					}
				}
				goto end_IL_0011;
				IL_01b9:
				_u__2.GetResult();
				goto end_IL_0011;
				IL_0133:
				if (_u__.GetResult())
				{
					_u__2 = javaCompatibilityInstancesPage.RunOperationAsync(__8__1._StopProxyButton_Click_b__1, "独立代理已停止", "刷新兼容实例后重新停止代理").GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StopProxyButton_Click_d__19>(ref _u__2, ref this);
						return;
					}
					goto IL_01b9;
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

	private readonly KxOGVaFL8AQcstEY1GC _client;

	private readonly kXxcqCXUYs1qiIst9kaY _proxy;

	private bool _operationInProgress;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProxyEmptyText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView ProxyInstanceList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button StopAllProxyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProxySummaryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ManagedEmptyText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView ManagedInstanceList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ManagedSummaryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CompatibilitySummaryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IJavaCompatibilityInstancesPage_Bindings Bindings;

	private ObservableCollection<rIp8CZfFJ2ofCfwfl3J2> _ManagedInstances_k__BackingField;
	[field: CompilerGenerated]
	public ObservableCollection<rIp8CZfFJ2ofCfwfl3J2> ManagedInstances
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private ObservableCollection<bq7k3qfN7qMnvLJMNOZa> _ProxyInstances_k__BackingField;
	[field: CompilerGenerated]
	public ObservableCollection<bq7k3qfN7qMnvLJMNOZa> ProxyInstances
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaCompatibilityInstancesPage()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		_client = KxOGVaFL8AQcstEY1GC.Shared;
		_proxy = kXxcqCXUYs1qiIst9kaY.Shared;
		_ManagedInstances_k__BackingField = new ObservableCollection<rIp8CZfFJ2ofCfwfl3J2>();
		_ProxyInstances_k__BackingField = new ObservableCollection<bq7k3qfN7qMnvLJMNOZa>();
		InitializeComponent();
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_client);
		AppShell.RegisterDisposable((global::System.IDisposable)_proxy);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(JavaCompatibilityInstancesPage_Loaded);
		_client.InstancesChanged += new EventHandler(Client_InstancesChanged);
		_proxy.InstancesChanged += new EventHandler(Proxy_InstancesChanged);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void JavaCompatibilityInstancesPage_Loaded(object sender, RoutedEventArgs e)
	{
		Refresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		Refresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BackToCompatibilityToolsButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("java_compatibility"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Client_InstancesChanged(object? sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(Refresh));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Proxy_InstancesChanged(object? sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(Refresh));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Refresh()
	{
		if (_disposed)
		{
			return;
		}
		try
		{
			((Collection<rIp8CZfFJ2ofCfwfl3J2>)(object)ManagedInstances).Clear();
			global::System.Collections.Generic.IEnumerator<rIp8CZfFJ2ofCfwfl3J2> enumerator = ((global::System.Collections.Generic.IEnumerable<rIp8CZfFJ2ofCfwfl3J2>)_client.dmOFOpNfjF()).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					rIp8CZfFJ2ofCfwfl3J2 current = enumerator.Current;
					((Collection<rIp8CZfFJ2ofCfwfl3J2>)(object)ManagedInstances).Add(current);
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			((Collection<bq7k3qfN7qMnvLJMNOZa>)(object)ProxyInstances).Clear();
			global::System.Collections.Generic.IEnumerator<bq7k3qfN7qMnvLJMNOZa> enumerator2 = ((global::System.Collections.Generic.IEnumerable<bq7k3qfN7qMnvLJMNOZa>)_proxy.L7BXUcjl8m9()).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
				{
					bq7k3qfN7qMnvLJMNOZa current2 = enumerator2.Current;
					((Collection<bq7k3qfN7qMnvLJMNOZa>)(object)ProxyInstances).Add(current2);
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator2)?.Dispose();
			}
		}
		catch (ObjectDisposedException)
		{
			return;
		}
		int num = Enumerable.Count<rIp8CZfFJ2ofCfwfl3J2>((global::System.Collections.Generic.IEnumerable<rIp8CZfFJ2ofCfwfl3J2>)ManagedInstances, (Func<rIp8CZfFJ2ofCfwfl3J2, bool>)([MethodImpl((MethodImplOptions)8)] (rIp8CZfFJ2ofCfwfl3J2 instance) => instance.CanStop || instance.IsRunning));
		int num2 = Enumerable.Count<bq7k3qfN7qMnvLJMNOZa>((global::System.Collections.Generic.IEnumerable<bq7k3qfN7qMnvLJMNOZa>)ProxyInstances, (Func<bq7k3qfN7qMnvLJMNOZa, bool>)([MethodImpl((MethodImplOptions)8)] (bq7k3qfN7qMnvLJMNOZa proxy) => proxy.CanStop));
		ManagedSummaryText.Text = ((((Collection<rIp8CZfFJ2ofCfwfl3J2>)(object)ManagedInstances).Count == 0) ? "当前没有托管客户端实例" : $"活动 {num} 个 · 历史 {((Collection<rIp8CZfFJ2ofCfwfl3J2>)(object)ManagedInstances).Count - num} 个");
		ProxySummaryText.Text = ((((Collection<bq7k3qfN7qMnvLJMNOZa>)(object)ProxyInstances).Count == 0) ? "当前没有独立代理实例" : $"活动 {num2} 个 · 历史 {((Collection<bq7k3qfN7qMnvLJMNOZa>)(object)ProxyInstances).Count - num2} 个");
		CompatibilitySummaryText.Text = $"托管客户端 {((Collection<rIp8CZfFJ2ofCfwfl3J2>)(object)ManagedInstances).Count} 个 · 独立代理 {((Collection<bq7k3qfN7qMnvLJMNOZa>)(object)ProxyInstances).Count} 个";
		((UIElement)ManagedEmptyText).Visibility = (((((Collection<rIp8CZfFJ2ofCfwfl3J2>)(object)ManagedInstances).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)ManagedInstanceList).Visibility = ((((Collection<rIp8CZfFJ2ofCfwfl3J2>)(object)ManagedInstances).Count == 0) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)ProxyEmptyText).Visibility = (((((Collection<bq7k3qfN7qMnvLJMNOZa>)(object)ProxyInstances).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)ProxyInstanceList).Visibility = ((((Collection<bq7k3qfN7qMnvLJMNOZa>)(object)ProxyInstances).Count == 0) ? Visibility.Visible : Visibility.Collapsed);
		((Control)StopAllProxyButton).IsEnabled = !_operationInProgress && Enumerable.Any<bq7k3qfN7qMnvLJMNOZa>((global::System.Collections.Generic.IEnumerable<bq7k3qfN7qMnvLJMNOZa>)ProxyInstances, (Func<bq7k3qfN7qMnvLJMNOZa, bool>)([MethodImpl((MethodImplOptions)8)] (bq7k3qfN7qMnvLJMNOZa proxy) => proxy.CanStop));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void StopManagedButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StopManagedButton_Click_d__17 stopManagedButton_Click_d__ = default(_StopManagedButton_Click_d__17);
		stopManagedButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		stopManagedButton_Click_d__.__4__this = this;
		stopManagedButton_Click_d__.sender = sender;
		stopManagedButton_Click_d__.__1__state = -1;
		stopManagedButton_Click_d__.__t__builder.Start<_StopManagedButton_Click_d__17>(ref stopManagedButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RetryManagedButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RetryManagedButton_Click_d__18 retryManagedButton_Click_d__ = default(_RetryManagedButton_Click_d__18);
		retryManagedButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		retryManagedButton_Click_d__.__4__this = this;
		retryManagedButton_Click_d__.sender = sender;
		retryManagedButton_Click_d__.__1__state = -1;
		retryManagedButton_Click_d__.__t__builder.Start<_RetryManagedButton_Click_d__18>(ref retryManagedButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void StopProxyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StopProxyButton_Click_d__19 stopProxyButton_Click_d__ = default(_StopProxyButton_Click_d__19);
		stopProxyButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		stopProxyButton_Click_d__.__4__this = this;
		stopProxyButton_Click_d__.sender = sender;
		stopProxyButton_Click_d__.__1__state = -1;
		stopProxyButton_Click_d__.__t__builder.Start<_StopProxyButton_Click_d__19>(ref stopProxyButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void StopAllProxyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StopAllProxyButton_Click_d__20 stopAllProxyButton_Click_d__ = default(_StopAllProxyButton_Click_d__20);
		stopAllProxyButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		stopAllProxyButton_Click_d__.__4__this = this;
		stopAllProxyButton_Click_d__.__1__state = -1;
		stopAllProxyButton_Click_d__.__t__builder.Start<_StopAllProxyButton_Click_d__20>(ref stopAllProxyButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RetryProxyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RetryProxyButton_Click_d__21 retryProxyButton_Click_d__ = default(_RetryProxyButton_Click_d__21);
		retryProxyButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		retryProxyButton_Click_d__.__4__this = this;
		retryProxyButton_Click_d__.sender = sender;
		retryProxyButton_Click_d__.__1__state = -1;
		retryProxyButton_Click_d__.__t__builder.Start<_RetryProxyButton_Click_d__21>(ref retryProxyButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyProxyAddressButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		Button val = (Button)((sender is Button) ? sender : null);
		if (val == null || !(((ButtonBase)val).CommandParameter is string text) || string.IsNullOrWhiteSpace(text))
		{
			return;
		}
		try
		{
			DataPackage val2 = new DataPackage();
			val2.SetText(text);
			Clipboard.SetContent(val2);
			AppShell.Success("已复制独立代理地址：" + text);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "CopyProxyAddressButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaCompatibilityInstancesPage.xaml.cs", 257);
			AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "手动复制兼容实例页中的本机地址"));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunOperationAsync(Func<global::System.Threading.Tasks.Task> operation, string successMessage, string nextStep)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunOperationAsync_d__23 runOperationAsync_d__ = default(_RunOperationAsync_d__23);
		runOperationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runOperationAsync_d__.__4__this = this;
		runOperationAsync_d__.operation = operation;
		runOperationAsync_d__.successMessage = successMessage;
		runOperationAsync_d__.nextStep = nextStep;
		runOperationAsync_d__.__1__state = -1;
		runOperationAsync_d__.__t__builder.Start<_RunOperationAsync_d__23>(ref runOperationAsync_d__);
		return runOperationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenFolderButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null && ((ButtonBase)val).CommandParameter is string path)
		{
			OpenPath(path, expectDirectory: true);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenCrashLogButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null && ((ButtonBase)val).CommandParameter is string path)
		{
			OpenPath(path, expectDirectory: false);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OpenPath(string path, bool expectDirectory)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(path))
		{
			return;
		}
		try
		{
			string fullPath = Path.GetFullPath(path);
			if (expectDirectory ? (!Directory.Exists(fullPath)) : (!File.Exists(fullPath)))
			{
				throw expectDirectory ? new DirectoryNotFoundException("兼容实例目录已不存在") : new FileNotFoundException("原始崩溃日志已不存在", fullPath);
			}
			Process.Start(new ProcessStartInfo
			{
				FileName = fullPath,
				UseShellExecute = true
			});
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "OpenPath", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaCompatibilityInstancesPage.xaml.cs", 334);
			AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, expectDirectory ? "刷新兼容实例后重新打开目录" : "刷新兼容实例并重新读取崩溃日志"));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(JavaCompatibilityInstancesPage_Loaded);
			_client.InstancesChanged -= new EventHandler(Client_InstancesChanged);
			_proxy.InstancesChanged -= new EventHandler(Proxy_InstancesChanged);
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
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaCompatibilityInstancesPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ProxyEmptyText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			ProxyInstanceList = CastExtensions.As<ListView>(target);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CopyProxyAddressButton_Click);
			break;
		case 8:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(StopProxyButton_Click);
			break;
		case 9:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RetryProxyButton_Click);
			break;
		case 16:
			StopAllProxyButton = CastExtensions.As<Button>(target);
			((ButtonBase)StopAllProxyButton).Click += new RoutedEventHandler(StopAllProxyButton_Click);
			break;
		case 17:
			ProxySummaryText = CastExtensions.As<TextBlock>(target);
			break;
		case 18:
			ManagedEmptyText = CastExtensions.As<TextBlock>(target);
			break;
		case 19:
			ManagedInstanceList = CastExtensions.As<ListView>(target);
			break;
		case 23:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenFolderButton_Click);
			break;
		case 24:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenCrashLogButton_Click);
			break;
		case 25:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(StopManagedButton_Click);
			break;
		case 26:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RetryManagedButton_Click);
			break;
		case 33:
			ManagedSummaryText = CastExtensions.As<TextBlock>(target);
			break;
		case 34:
			CompatibilitySummaryText = CastExtensions.As<TextBlock>(target);
			break;
		case 35:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(BackToCompatibilityToolsButton_Click);
			break;
		case 36:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 1:
		{
			Page val3 = (Page)target;
			JavaCompatibilityInstancesPage_obj1_Bindings javaCompatibilityInstancesPage_obj1_Bindings = (JavaCompatibilityInstancesPage_obj1_Bindings)new JavaCompatibilityInstancesPage_obj1_Bindings();
			result = (IComponentConnector)(object)javaCompatibilityInstancesPage_obj1_Bindings;
			javaCompatibilityInstancesPage_obj1_Bindings.SetDataRoot(this);
			Bindings = javaCompatibilityInstancesPage_obj1_Bindings;
			((FrameworkElement)val3).Loading += javaCompatibilityInstancesPage_obj1_Bindings.Loading;
			break;
		}
		case 5:
		{
			Border val2 = (Border)target;
			JavaCompatibilityInstancesPage_obj5_Bindings javaCompatibilityInstancesPage_obj5_Bindings = (JavaCompatibilityInstancesPage_obj5_Bindings)new JavaCompatibilityInstancesPage_obj5_Bindings();
			result = (IComponentConnector)(object)javaCompatibilityInstancesPage_obj5_Bindings;
			javaCompatibilityInstancesPage_obj5_Bindings.SetDataRoot(((FrameworkElement)val2).DataContext);
			((FrameworkElement)val2).DataContextChanged += javaCompatibilityInstancesPage_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val2, (IDataTemplateExtension)(object)javaCompatibilityInstancesPage_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val2, (IDataTemplateComponent)(object)javaCompatibilityInstancesPage_obj5_Bindings);
			break;
		}
		case 21:
		{
			Border val = (Border)target;
			JavaCompatibilityInstancesPage_obj21_Bindings javaCompatibilityInstancesPage_obj21_Bindings = (JavaCompatibilityInstancesPage_obj21_Bindings)new JavaCompatibilityInstancesPage_obj21_Bindings();
			result = (IComponentConnector)(object)javaCompatibilityInstancesPage_obj21_Bindings;
			javaCompatibilityInstancesPage_obj21_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += javaCompatibilityInstancesPage_obj21_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)javaCompatibilityInstancesPage_obj21_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)javaCompatibilityInstancesPage_obj21_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _StopAllProxyButton_Click_b__20_1()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return _proxy.k2QXUJ3SkpE(default(CancellationToken));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

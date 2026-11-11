using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using EBJLMifNn8QeuhMRSx7U;
using GWTRrnfpaWE7CGUVCeZU;
using IAx1o0f1iQkCqF80SQqk;
using KgRi2CfpSO33rCtNjhfF;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using NfdorxfpWBqmvmt4ZpvI;
using Sntfc6XKNnOgyXsrPR4m;
using Tyvtv8fMcpNM0tYbgekP;
using VE4SD3fpOtryqPu1jwJE;
using VkGHrBfa53sbZRVUGNON;
using Vl4jDMX56cFYkU2Jw1oo;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using ajau5tfpTXRk8mjlQPRa;
using cK2p8BfMfgWEdApq7hkm;
using d2QGZNfpebAURApTvW49;
using dFXbSSfp7AGypITCPxjt;
using fYjvfFf1p8udxK21D6pd;
using gBChU1fpll4QJwuh1uJt;
using hMm1lMfph7PJcuUgXHNe;
using i6TlJMfuChv2AjPXr7O8;
using o3VPfkXKPxSCP8Onfcp3;
using p0fRltfaPXGenAFPYG7A;
using qS8vkpL43FlTMgcj0rgs;
using v1AhFSfMblmp1q5wGqxg;
using xsbjKUfp9um80Gf8YymA;
using yj2YwMfp2pJng8UApool;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockSkinBrowser : UserControl, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockSkinBrowser_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockSkinBrowser_BindingsScopeConnector
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

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[DebuggerNonUserCode]
	private class BedrockSkinBrowser_obj28_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockSkinBrowser_Bindings
	{
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		private class BedrockSkinBrowser_obj28_BindingsTracking
		{
			private WeakReference<BedrockSkinBrowser_obj28_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public BedrockSkinBrowser_obj28_BindingsTracking(BedrockSkinBrowser_obj28_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<BedrockSkinBrowser_obj28_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public BedrockSkinBrowser_obj28_Bindings TryGetBindingObject()
			{
				BedrockSkinBrowser_obj28_Bindings bedrockSkinBrowser_obj28_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out bedrockSkinBrowser_obj28_Bindings);
					if (bedrockSkinBrowser_obj28_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return bedrockSkinBrowser_obj28_Bindings;
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
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				BedrockSkinBrowser_obj28_Bindings bedrockSkinBrowser_obj28_Bindings = TryGetBindingObject();
				if (bedrockSkinBrowser_obj28_Bindings == null)
				{
					return;
				}
				string propertyName = e.PropertyName;
				BedrockSkinCardViewModel bedrockSkinCardViewModel = sender as BedrockSkinCardViewModel;
				if (string.IsNullOrEmpty(propertyName))
				{
					if (bedrockSkinCardViewModel != null)
					{
						bedrockSkinBrowser_obj28_Bindings.Update_AppliedVisibility(bedrockSkinCardViewModel.AppliedVisibility, 1073741824);
						bedrockSkinBrowser_obj28_Bindings.Update_ResourceStatusText(bedrockSkinCardViewModel.ResourceStatusText, 1073741824);
					}
				}
				else if (!(propertyName == "AppliedVisibility"))
				{
					if (propertyName == "ResourceStatusText" && bedrockSkinCardViewModel != null)
					{
						bedrockSkinBrowser_obj28_Bindings.Update_ResourceStatusText(bedrockSkinCardViewModel.ResourceStatusText, 1073741824);
					}
				}
				else if (bedrockSkinCardViewModel != null)
				{
					bedrockSkinBrowser_obj28_Bindings.Update_AppliedVisibility(bedrockSkinCardViewModel.AppliedVisibility, 1073741824);
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_(BedrockSkinCardViewModel obj)
			{
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				BedrockSkinBrowser_obj28_Bindings bedrockSkinBrowser_obj28_Bindings = TryGetBindingObject();
				if (bedrockSkinBrowser_obj28_Bindings != null)
				{
					if (bedrockSkinBrowser_obj28_Bindings.dataRoot != null)
					{
						((INotifyPropertyChanged)bedrockSkinBrowser_obj28_Bindings.dataRoot).PropertyChanged -= new PropertyChangedEventHandler(PropertyChanged_);
					}
					if (obj != null)
					{
						bedrockSkinBrowser_obj28_Bindings.dataRoot = obj;
						((INotifyPropertyChanged)obj).PropertyChanged += new PropertyChangedEventHandler(PropertyChanged_);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private BedrockSkinCardViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj28;

		private Border obj29;

		private TextBlock obj30;

		private TextBlock obj31;

		private TextBlock obj32;

		private TextBlock obj33;

		private BedrockNetworkImage obj34;

		private BedrockSkinBrowser_obj28_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockSkinBrowser_obj28_Bindings()
		{
			bindingsTracking = (BedrockSkinBrowser_obj28_BindingsTracking)new BedrockSkinBrowser_obj28_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 28:
				obj28 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 29:
				obj29 = CastExtensions.As<Border>(target);
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
			case 33:
				obj33 = CastExtensions.As<TextBlock>(target);
				break;
			case 34:
				obj34 = CastExtensions.As<BedrockNetworkImage>(target);
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
			object target = obj28.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BedrockSkinCardViewModel>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<BedrockSkinCardViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockSkinCardViewModel obj, int phase)
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
				}
				if ((phase & -1073741823) != 0)
				{
					Update_ResourceStatusText(obj.ResourceStatusText, phase);
				}
				if ((phase & -2147483647) != 0)
				{
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
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj29, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj30, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Developer(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj31, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_MetricsText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj32, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ResourceStatusText(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj33, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CoverUrl(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(obj34, obj, null);
			}
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
	private class BedrockSkinBrowser_obj1_Bindings : IComponentConnector, IBedrockSkinBrowser_Bindings
	{
		private BedrockSkinBrowser dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private GridView obj22;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockSkinBrowser_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 22)
			{
				obj22 = CastExtensions.As<GridView>(target);
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
				dataRoot = CastExtensions.As<BedrockSkinBrowser>(newDataRoot);
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
		private void Update_(BedrockSkinBrowser obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -2147483647) != 0)
			{
				Update_Skins(obj.Skins, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Skins(ObservableCollection<BedrockSkinCardViewModel> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_10
	{
		public static readonly __c_10 __9;

		public static Func<m4wFTFfpZW4pcAqQZC1k, string> __9__33_2;

		public static Func<m4wFTFfpZW4pcAqQZC1k, int> __9__42_2;

		public static Func<l6vC8LfMXvCYSRCp4C3a, string> __9__65_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_10()
		{
			__9 = (__c_10)new __c_10();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_10()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _LoadPageAsync_b__33_2(m4wFTFfpZW4pcAqQZC1k part)
		{
			return part.Id;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int _PreparePreviewAsync_b__42_2(m4wFTFfpZW4pcAqQZC1k part)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected I4, but got Unknown
			return (int)part.Slot;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _FormatSlotFailures_b__65_0(l6vC8LfMXvCYSRCp4C3a failure)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return GetSlotName(failure.Slot) + failure.CategoryName;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass33_0
	{
		public string appliedId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass33_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal BedrockSkinCardViewModel _LoadPageAsync_b__0(ejKX8wfpsw8ins4MWI7J skin)
		{
			return (BedrockSkinCardViewModel)new BedrockSkinCardViewModel(skin, string.Equals(skin.Id, appliedId, (StringComparison)4));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass33_1
	{
		public string appliedId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass33_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal BedrockSkinCardViewModel _LoadPageAsync_b__1(dZU6g2fptC4VZ350fMxJ skin)
		{
			return (BedrockSkinCardViewModel)new BedrockSkinCardViewModel(skin, string.Equals(skin.Id, appliedId, (StringComparison)4));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass33_2
	{
		public IReadOnlySet<string> appliedIds;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass33_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal BedrockSkinCardViewModel _LoadPageAsync_b__3(m4wFTFfpZW4pcAqQZC1k part)
		{
			return (BedrockSkinCardViewModel)new BedrockSkinCardViewModel(part, appliedIds.Contains(part.Id));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass42_0
	{
		public BedrockSkinBrowser __4__this;

		public CancellationTokenSource cancellation;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass42_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<NIF9GNfaOUIlucHK2qQs> _PreparePreviewAsync_b__0(m4wFTFfpZW4pcAqQZC1k part)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.gfOX6YQmonS(part, cancellation.Token);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<NIF9GNfaOUIlucHK2qQs> _PreparePreviewAsync_b__4(m4wFTFfpZW4pcAqQZC1k part)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._service.gfOX6YQmonS(part, cancellation.Token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass42_1
	{
		public m4wFTFfpZW4pcAqQZC1k fourDimensionalPart;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass42_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _PreparePreviewAsync_b__1(m4wFTFfpZW4pcAqQZC1k part)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			return part.Slot != fourDimensionalPart.Slot;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _PreparePreviewAsync_b__3(m4wFTFfpZW4pcAqQZC1k part)
		{
			return !string.Equals(part.Id, fourDimensionalPart.Id, (StringComparison)4);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass64_0
	{
		public string userId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass64_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ShowAppearanceAppliedSuccess_b__0(zG6ueUfuQUk6CEmxLYji instance)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			if ((int)instance.Kind == 0)
			{
				return string.Equals(instance.AccountId, userId, (StringComparison)4);
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ApplyButton_Click_d__44 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private CancellationTokenSource _cancellation_5__2;

		private bool _requiresServerReadback_5__3;

		private TaskAwaiter<SiCQKdfMS08AxK51wAlm> __u__1;

		private TaskAwaiter<AZci00fpEbV8HcEwinMT> __u__2;

		private dZU6g2fptC4VZ350fMxJ _skin_5__4;

		private TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ> __u__3;

		private m4wFTFfpZW4pcAqQZC1k _part_5__5;

		private TaskAwaiter __u__4;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				if ((uint)num <= 4u)
				{
					goto IL_0090;
				}
				if (bedrockSkinBrowser._service != null && (bedrockSkinBrowser._preparedSkin != null || bedrockSkinBrowser._preparedFourDimensionalAppearance != null))
				{
					CancellationTokenSource? applyCancellation = bedrockSkinBrowser._applyCancellation;
					if (applyCancellation != null)
					{
						applyCancellation.Cancel();
					}
					CancellationTokenSource? applyCancellation2 = bedrockSkinBrowser._applyCancellation;
					if (applyCancellation2 != null)
					{
						applyCancellation2.Dispose();
					}
					_cancellation_5__2 = new CancellationTokenSource();
					bedrockSkinBrowser._applyCancellation = _cancellation_5__2;
					((Control)bedrockSkinBrowser.ApplyButton).IsEnabled = false;
					goto IL_0090;
				}
				goto end_IL_0011;
				IL_0090:
				try
				{
					TaskAwaiter<SiCQKdfMS08AxK51wAlm> _u__4 = default;
					TaskAwaiter<AZci00fpEbV8HcEwinMT> _u__3 = default;
					TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ> _u__2 = default;
					TaskAwaiter _u__ = default;
					CancellationToken token;
					LFmY9Rfae1HtFQ0pDVND preparedSkin;
					NIF9GNfaOUIlucHK2qQs? preparedFourDimensionalAppearance;
					NIF9GNfaOUIlucHK2qQs? preparedFourDimensionalAppearance2;
					AZci00fpEbV8HcEwinMT result;
					switch (num)
					{
					default:
						_requiresServerReadback_5__3 = bedrockSkinBrowser._preparedSkin == null;
						if (_requiresServerReadback_5__3)
						{
							bedrockSkinBrowser.StatusText.Text = "正在读取当前装扮";
							_u__4 = bedrockSkinBrowser._service.JoSX6Z0yTbY(_cancellation_5__2.Token).GetAwaiter();
							if (!_u__4.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__4;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SiCQKdfMS08AxK51wAlm>, _ApplyButton_Click_d__44>(ref _u__4, ref this);
								return;
							}
							goto IL_013b;
						}
						goto IL_0143;
					case 0:
						_u__4 = __u__1;
						__u__1 = default(TaskAwaiter<SiCQKdfMS08AxK51wAlm>);
						num = (__1__state = -1);
						goto IL_013b;
					case 1:
						_u__3 = __u__2;
						__u__2 = default(TaskAwaiter<AZci00fpEbV8HcEwinMT>);
						num = (__1__state = -1);
						goto IL_01df;
					case 2:
						_u__2 = __u__3;
						__u__3 = default(TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ>);
						num = (__1__state = -1);
						goto IL_02ae;
					case 3:
						_u__2 = __u__3;
						__u__3 = default(TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ>);
						num = (__1__state = -1);
						goto IL_036f;
					case 4:
						{
							_u__ = __u__4;
							__u__4 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_0415;
						}
						IL_0399:
						_skin_5__4 = null;
						goto IL_03a0;
						IL_03a0:
						if (!_requiresServerReadback_5__3)
						{
							break;
						}
						bedrockSkinBrowser.StatusText.Text = "正在回读验证装扮";
						_u__ = bedrockSkinBrowser.RefreshServerAppliedStateAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 4);
							__u__4 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ApplyButton_Click_d__44>(ref _u__, ref this);
							return;
						}
						goto IL_0415;
						IL_013b:
						_u__4.GetResult();
						goto IL_0143;
						IL_0143:
						token = _cancellation_5__2.Token;
						token.ThrowIfCancellationRequested();
						bedrockSkinBrowser.StatusText.Text = "正在同步装扮";
						preparedSkin = bedrockSkinBrowser._preparedSkin;
						if (preparedSkin != null)
						{
							_u__3 = bedrockSkinBrowser._service.UqXX6WdpvCY(preparedSkin, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<AZci00fpEbV8HcEwinMT>, _ApplyButton_Click_d__44>(ref _u__3, ref this);
								return;
							}
							goto IL_01df;
						}
						preparedFourDimensionalAppearance = bedrockSkinBrowser._preparedFourDimensionalAppearance;
						_skin_5__4 = ((preparedFourDimensionalAppearance != null) ? preparedFourDimensionalAppearance.Skin : null);
						if (_skin_5__4 != null)
						{
							_u__2 = bedrockSkinBrowser._service.KTGX69kh1RY(_skin_5__4, bedrockSkinBrowser._resolvedFourDimensionalParts, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 2);
								__u__3 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ>, _ApplyButton_Click_d__44>(ref _u__2, ref this);
								return;
							}
							goto IL_02ae;
						}
						preparedFourDimensionalAppearance2 = bedrockSkinBrowser._preparedFourDimensionalAppearance;
						_part_5__5 = ((preparedFourDimensionalAppearance2 != null) ? preparedFourDimensionalAppearance2.Part : null);
						if (_part_5__5 != null)
						{
							_u__2 = bedrockSkinBrowser._service.pAWX6D53Dsx(bedrockSkinBrowser._resolvedFourDimensionalParts, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 3);
								__u__3 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ>, _ApplyButton_Click_d__44>(ref _u__2, ref this);
								return;
							}
							goto IL_036f;
						}
						goto IL_0392;
						IL_036f:
						_u__2.GetResult();
						bedrockSkinBrowser.ShowAppearanceAppliedSuccess("已穿戴 4D 组件并完成服务器回读：" + _part_5__5.Name);
						goto IL_0392;
						IL_02ae:
						_u__2.GetResult();
						bedrockSkinBrowser.ShowAppearanceAppliedSuccess("已穿戴 4D 皮肤并完成服务器回读：" + _skin_5__4.Name);
						goto IL_0399;
						IL_01df:
						result = _u__3.GetResult();
						bedrockSkinBrowser.ClearServerAppliedStateCache();
						bedrockSkinBrowser.ShowAppearanceAppliedSuccess("已应用 2D 皮肤：" + result.Skin.Name);
						goto IL_03a0;
						IL_0415:
						_u__.GetResult();
						break;
						IL_0392:
						_part_5__5 = null;
						goto IL_0399;
					}
					bedrockSkinBrowser.RefreshAppliedState();
					bedrockSkinBrowser.StatusText.Text = (_requiresServerReadback_5__3 ? "装扮已同步并通过服务器回读" : "2D 皮肤已同步");
				}
				catch (OperationCanceledException)
				{
				}
				catch (global::System.Exception) when (_cancellation_5__2.IsCancellationRequested || bedrockSkinBrowser._applyCancellation != _cancellation_5__2)
				{
				}
				catch (global::System.Exception ex3)
				{
					LFmY9Rfae1HtFQ0pDVND? preparedSkin2 = bedrockSkinBrowser._preparedSkin;
					object obj = ((preparedSkin2 != null) ? preparedSkin2.Skin.Id : null);
					if (obj == null)
					{
						NIF9GNfaOUIlucHK2qQs? preparedFourDimensionalAppearance3 = bedrockSkinBrowser._preparedFourDimensionalAppearance;
						obj = ((preparedFourDimensionalAppearance3 != null) ? preparedFourDimensionalAppearance3.Id : null) ?? "unknown";
					}
					string text = (string)obj;
					gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-skins", "装扮应用失败 itemId=" + text, ex3);
					string text2 = BedrockAppearanceErrorClassifier.Apply(ex3);
					bedrockSkinBrowser.StatusText.Text = text2;
					AppShell.Error(text2);
				}
				finally
				{
					if (num < 0)
					{
						if (bedrockSkinBrowser._applyCancellation == _cancellation_5__2)
						{
							bedrockSkinBrowser._applyCancellation = null;
						}
						_cancellation_5__2.Dispose();
						bedrockSkinBrowser.UpdateButtons();
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
	private struct _CatalogSelector_SelectionChanged_d__34 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Invalid comparison between Unknown and I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00a4;
				}
				if (bedrockSkinBrowser._service != null)
				{
					((UIElement)bedrockSkinBrowser.PartSlotSelector).Visibility = (((int)bedrockSkinBrowser.CurrentCatalog != 3) ? Visibility.Visible : Visibility.Collapsed);
					bedrockSkinBrowser.ResetCatalogState();
					_u__ = bedrockSkinBrowser.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CatalogSelector_SelectionChanged_d__34>(ref _u__, ref this);
						return;
					}
					goto IL_00a4;
				}
				goto end_IL_0011;
				IL_00a4:
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
	private struct _LoadInitialAsync_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_009d;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00fd;
				}
				da18CdX55laNMRKtM3p0? service = bedrockSkinBrowser._service;
				if (((service != null) ? service.CurrentSession : null) != null)
				{
					_u__ = bedrockSkinBrowser.RefreshServerAppliedStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadInitialAsync_d__31>(ref _u__, ref this);
						return;
					}
					goto IL_009d;
				}
				bedrockSkinBrowser.Clear();
				goto end_IL_0011;
				IL_009d:
				_u__.GetResult();
				_u__ = bedrockSkinBrowser.LoadPageAsync(0, append: false).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadInitialAsync_d__31>(ref _u__, ref this);
					return;
				}
				goto IL_00fd;
				IL_00fd:
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
	private struct _LoadMoreButton_Click_d__39 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0087;
				}
				if (bedrockSkinBrowser._hasMore)
				{
					_u__ = bedrockSkinBrowser.LoadPageAsync(bedrockSkinBrowser._currentOffset + bedrockSkinBrowser._currentItemCount, append: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadMoreButton_Click_d__39>(ref _u__, ref this);
						return;
					}
					goto IL_0087;
				}
				goto end_IL_0011;
				IL_0087:
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
	private struct _LoadPageAsync_d__33 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		public int offset;

		private __c__DisplayClass33_0 __8__1;

		private __c__DisplayClass33_1 __8__2;

		private __c__DisplayClass33_2 __8__3;

		public bool append;

		private CancellationTokenSource _cancellation_5__2;

		private p1aif0fNieMbuxR5AlNF _catalog_5__3;

		private string _catalogName_5__4;

		private string _keyword_5__5;

		private List<BedrockSkinCardViewModel> _cards_5__6;

		private global::System.Collections.Generic.IReadOnlyList<l6vC8LfMXvCYSRCp4C3a> _slotFailures_5__7;

		private TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H> __u__1;

		private TaskAwaiter<EtpQQffpwcLcasYY4ys8> __u__2;

		private TaskAwaiter<QOWulRfpYAmINmqtkSMV> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0642: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Unknown result type (might be due to invalid IL or missing references)
			//IL_075b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0763: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected I4, but got Unknown
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Invalid comparison between Unknown and I4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_079a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0714: Unknown result type (might be due to invalid IL or missing references)
			//IL_071e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0723: Unknown result type (might be due to invalid IL or missing references)
			//IL_0667: Unknown result type (might be due to invalid IL or missing references)
			//IL_0680: Unknown result type (might be due to invalid IL or missing references)
			//IL_068a: Unknown result type (might be due to invalid IL or missing references)
			//IL_068f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0602: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_073b: Unknown result type (might be due to invalid IL or missing references)
			//IL_073d: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_061a: Unknown result type (might be due to invalid IL or missing references)
			//IL_061c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0915: Unknown result type (might be due to invalid IL or missing references)
			//IL_091a: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bac: Expected I4, but got Unknown
			//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				if ((uint)num <= 9u)
				{
					goto IL_0063;
				}
				if (bedrockSkinBrowser._service != null)
				{
					CancellationTokenSource? loadCancellation = bedrockSkinBrowser._loadCancellation;
					if (loadCancellation != null)
					{
						loadCancellation.Cancel();
					}
					CancellationTokenSource? loadCancellation2 = bedrockSkinBrowser._loadCancellation;
					if (loadCancellation2 != null)
					{
						loadCancellation2.Dispose();
					}
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0063;
				}
				goto end_IL_0011;
				IL_0063:
				try
				{
					if ((uint)num > 9u)
					{
						bedrockSkinBrowser._loadCancellation = _cancellation_5__2;
						_catalog_5__3 = bedrockSkinBrowser.CurrentCatalog;
						_catalogName_5__4 = GetCatalogName(_catalog_5__3);
						_keyword_5__5 = bedrockSkinBrowser.SearchBox.Text.Trim();
						bedrockSkinBrowser.StatusText.Text = ((_keyword_5__5.Length == 0) ? ("正在同步" + _catalogName_5__4) : ("正在搜索" + _catalogName_5__4));
						((Control)bedrockSkinBrowser.LoadMoreButton).IsEnabled = false;
					}
					try
					{
						TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H> _u__3 = default;
						TaskAwaiter<EtpQQffpwcLcasYY4ys8> _u__2 = default;
						TaskAwaiter<QOWulRfpYAmINmqtkSMV> _u__ = default;
						mWGKInfNzSRMjl3TLmeA? currentPartSlot;
						Cw5ByxfpuZxBRmf8IH2H val2;
						EtpQQffpwcLcasYY4ys8 result2;
						EtpQQffpwcLcasYY4ys8 val3;
						__c__DisplayClass33_1 _c__DisplayClass33_;
						object appliedId;
						int total;
						bool hasMore;
						QOWulRfpYAmINmqtkSMV val4;
						Cw5ByxfpuZxBRmf8IH2H result;
						QOWulRfpYAmINmqtkSMV result3;
						Cw5ByxfpuZxBRmf8IH2H val5;
						QOWulRfpYAmINmqtkSMV val6;
						__c__DisplayClass33_2 _c__DisplayClass33_2;
						IReadOnlySet<string> appliedIds;
						switch (num)
						{
						default:
						{
							_cards_5__6 = new List<BedrockSkinCardViewModel>();
							_slotFailures_5__7 = global::System.Array.Empty<l6vC8LfMXvCYSRCp4C3a>();
							p1aif0fNieMbuxR5AlNF val = _catalog_5__3;
							switch ((int)val)
							{
							case 0:
							case 1:
								break;
							case 2:
								goto IL_03fc;
							case 3:
								goto IL_05a9;
							default:
								throw new InvalidOperationException("不支持的皮肤目录类型");
							}
							__8__1 = (__c__DisplayClass33_0)new __c__DisplayClass33_0();
							if ((int)_catalog_5__3 == 1)
							{
								if (_keyword_5__5.Length == 0)
								{
									_u__3 = bedrockSkinBrowser._service.plFX5G2FqKX(offset, 20, _cancellation_5__2.Token).GetAwaiter();
									if (!_u__3.IsCompleted)
									{
										num = (__1__state = 0);
										__u__1 = _u__3;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>, _LoadPageAsync_d__33>(ref _u__3, ref this);
										return;
									}
									goto IL_01f8;
								}
								_u__3 = bedrockSkinBrowser._service.TjsX5iktn2L(_keyword_5__5, offset, 20, _cancellation_5__2.Token).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 1);
									__u__1 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>, _LoadPageAsync_d__33>(ref _u__3, ref this);
									return;
								}
								goto IL_027e;
							}
							if (_keyword_5__5.Length == 0)
							{
								_u__3 = bedrockSkinBrowser._service.BRMX52p1XNX(offset, 20, _cancellation_5__2.Token).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 2);
									__u__1 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>, _LoadPageAsync_d__33>(ref _u__3, ref this);
									return;
								}
								goto IL_0312;
							}
							_u__3 = bedrockSkinBrowser._service.ioSX5qxRONa(_keyword_5__5, offset, 20, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 3);
								__u__1 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>, _LoadPageAsync_d__33>(ref _u__3, ref this);
								return;
							}
							goto IL_0398;
						}
						case 0:
							_u__3 = __u__1;
							__u__1 = default(TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>);
							num = (__1__state = -1);
							goto IL_01f8;
						case 1:
							_u__3 = __u__1;
							__u__1 = default(TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>);
							num = (__1__state = -1);
							goto IL_027e;
						case 2:
							_u__3 = __u__1;
							__u__1 = default(TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>);
							num = (__1__state = -1);
							goto IL_0312;
						case 3:
							_u__3 = __u__1;
							__u__1 = default(TaskAwaiter<Cw5ByxfpuZxBRmf8IH2H>);
							num = (__1__state = -1);
							goto IL_0398;
						case 4:
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter<EtpQQffpwcLcasYY4ys8>);
							num = (__1__state = -1);
							goto IL_0489;
						case 5:
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter<EtpQQffpwcLcasYY4ys8>);
							num = (__1__state = -1);
							goto IL_050f;
						case 6:
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter<QOWulRfpYAmINmqtkSMV>);
							num = (__1__state = -1);
							goto IL_0651;
						case 7:
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter<QOWulRfpYAmINmqtkSMV>);
							num = (__1__state = -1);
							goto IL_06de;
						case 8:
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter<QOWulRfpYAmINmqtkSMV>);
							num = (__1__state = -1);
							goto IL_0772;
						case 9:
							{
								_u__ = __u__3;
								__u__3 = default(TaskAwaiter<QOWulRfpYAmINmqtkSMV>);
								num = (__1__state = -1);
								goto IL_07f9;
							}
							IL_05a9:
							__8__3 = (__c__DisplayClass33_2)new __c__DisplayClass33_2();
							currentPartSlot = bedrockSkinBrowser.CurrentPartSlot;
							if (currentPartSlot.HasValue)
							{
								if (_keyword_5__5.Length == 0)
								{
									_u__ = bedrockSkinBrowser._service.luxX6bjv4VF(currentPartSlot.Value, offset, 20, _cancellation_5__2.Token).GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 6);
										__u__3 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QOWulRfpYAmINmqtkSMV>, _LoadPageAsync_d__33>(ref _u__, ref this);
										return;
									}
									goto IL_0651;
								}
								_u__ = bedrockSkinBrowser._service.np4X6XWEpPU(currentPartSlot.Value, _keyword_5__5, offset, 20, _cancellation_5__2.Token).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 7);
									__u__3 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QOWulRfpYAmINmqtkSMV>, _LoadPageAsync_d__33>(ref _u__, ref this);
									return;
								}
								goto IL_06de;
							}
							if (_keyword_5__5.Length == 0)
							{
								_u__ = bedrockSkinBrowser._service.o67X6fRY4bB(offset, 20, _cancellation_5__2.Token).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 8);
									__u__3 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QOWulRfpYAmINmqtkSMV>, _LoadPageAsync_d__33>(ref _u__, ref this);
									return;
								}
								goto IL_0772;
							}
							_u__ = bedrockSkinBrowser._service.DFwX6LfGg5x(_keyword_5__5, offset, 20, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 9);
								__u__3 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QOWulRfpYAmINmqtkSMV>, _LoadPageAsync_d__33>(ref _u__, ref this);
								return;
							}
							goto IL_07f9;
							IL_03fc:
							__8__2 = (__c__DisplayClass33_1)new __c__DisplayClass33_1();
							if (_keyword_5__5.Length == 0)
							{
								_u__2 = bedrockSkinBrowser._service.K12X5nJ4JHK(offset, 20, _cancellation_5__2.Token).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 4);
									__u__2 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<EtpQQffpwcLcasYY4ys8>, _LoadPageAsync_d__33>(ref _u__2, ref this);
									return;
								}
								goto IL_0489;
							}
							_u__2 = bedrockSkinBrowser._service.yj9X5z3iK9P(_keyword_5__5, offset, 20, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 5);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<EtpQQffpwcLcasYY4ys8>, _LoadPageAsync_d__33>(ref _u__2, ref this);
								return;
							}
							goto IL_050f;
							IL_0287:
							val2 = result;
							goto IL_03a5;
							IL_050f:
							result2 = _u__2.GetResult();
							goto IL_0518;
							IL_0651:
							result3 = _u__.GetResult();
							goto IL_06e7;
							IL_01f8:
							result = _u__3.GetResult();
							goto IL_0287;
							IL_0518:
							val3 = result2;
							_c__DisplayClass33_ = __8__2;
							if (!bedrockSkinBrowser._hasServerAppliedState)
							{
								Di0YdyfpgW3VyQ3SAJMx selectedFourDimensionalAppearance = bedrockSkinBrowser._service.SelectedFourDimensionalAppearance;
								if (selectedFourDimensionalAppearance == null)
								{
									appliedId = null;
								}
								else
								{
									dZU6g2fptC4VZ350fMxJ skin = selectedFourDimensionalAppearance.Skin;
									appliedId = ((skin != null) ? skin.Id : null);
								}
							}
							else
							{
								appliedId = bedrockSkinBrowser._serverAppliedSkinId;
							}
							_c__DisplayClass33_.appliedId = (string)appliedId;
							_cards_5__6.AddRange(Enumerable.Select<dZU6g2fptC4VZ350fMxJ, BedrockSkinCardViewModel>((global::System.Collections.Generic.IEnumerable<dZU6g2fptC4VZ350fMxJ>)val3.Items, (Func<dZU6g2fptC4VZ350fMxJ, BedrockSkinCardViewModel>)__8__2._LoadPageAsync_b__1));
							total = val3.Total;
							hasMore = val3.HasMore;
							break;
							IL_06de:
							result3 = _u__.GetResult();
							goto IL_06e7;
							IL_06e7:
							val4 = result3;
							goto IL_0806;
							IL_0489:
							result2 = _u__2.GetResult();
							goto IL_0518;
							IL_0312:
							result = _u__3.GetResult();
							goto IL_03a1;
							IL_0398:
							result = _u__3.GetResult();
							goto IL_03a1;
							IL_0772:
							result3 = _u__.GetResult();
							goto IL_0802;
							IL_03a5:
							val5 = val2;
							__8__1.appliedId = bedrockSkinBrowser.ResolveAppliedDisplayState().TwoDimensionalSkinId;
							_cards_5__6.AddRange(Enumerable.Select<ejKX8wfpsw8ins4MWI7J, BedrockSkinCardViewModel>((global::System.Collections.Generic.IEnumerable<ejKX8wfpsw8ins4MWI7J>)val5.Items, (Func<ejKX8wfpsw8ins4MWI7J, BedrockSkinCardViewModel>)__8__1._LoadPageAsync_b__0));
							total = val5.Total;
							hasMore = val5.HasMore;
							break;
							IL_03a1:
							val2 = result;
							goto IL_03a5;
							IL_07f9:
							result3 = _u__.GetResult();
							goto IL_0802;
							IL_0802:
							val4 = result3;
							goto IL_0806;
							IL_0806:
							val6 = val4;
							_c__DisplayClass33_2 = __8__3;
							if (!bedrockSkinBrowser._hasServerAppliedState)
							{
								Di0YdyfpgW3VyQ3SAJMx selectedFourDimensionalAppearance2 = bedrockSkinBrowser._service.SelectedFourDimensionalAppearance;
								IReadOnlySet<string> val7 = (IReadOnlySet<string>)(object)(((selectedFourDimensionalAppearance2 != null) ? Enumerable.ToHashSet<string>(Enumerable.Select<m4wFTFfpZW4pcAqQZC1k, string>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)selectedFourDimensionalAppearance2.Parts, (Func<m4wFTFfpZW4pcAqQZC1k, string>)__c_10.__9._LoadPageAsync_b__33_2), (IEqualityComparer<string>)(object)StringComparer.Ordinal) : null) ?? new HashSet<string>());
								appliedIds = val7;
							}
							else
							{
								appliedIds = bedrockSkinBrowser._serverAppliedPartIds;
							}
							_c__DisplayClass33_2.appliedIds = appliedIds;
							_cards_5__6.AddRange(Enumerable.Select<m4wFTFfpZW4pcAqQZC1k, BedrockSkinCardViewModel>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)val6.Items, (Func<m4wFTFfpZW4pcAqQZC1k, BedrockSkinCardViewModel>)__8__3._LoadPageAsync_b__3));
							_slotFailures_5__7 = val6.Failures;
							total = val6.Total;
							hasMore = val6.HasMore;
							break;
							IL_027e:
							result = _u__3.GetResult();
							goto IL_0287;
						}
						if (!_cancellation_5__2.IsCancellationRequested)
						{
							if (!append)
							{
								((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Clear();
								bedrockSkinBrowser.ResetPreviewState();
							}
							var enumerator = _cards_5__6.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									BedrockSkinCardViewModel current = enumerator.Current;
									((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Add(current);
								}
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								}
							}
							bedrockSkinBrowser._currentOffset = offset;
							bedrockSkinBrowser._currentItemCount = _cards_5__6.Count;
							bedrockSkinBrowser._hasMore = hasMore;
							((UIElement)bedrockSkinBrowser.EmptyPanel).Visibility = (((((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Count != 0) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
							string text = FormatSlotFailures(_slotFailures_5__7);
							bedrockSkinBrowser.EmptyTitle.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<l6vC8LfMXvCYSRCp4C3a>)_slotFailures_5__7).Count > 0 && ((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Count == 0) ? "4D 拆件部分分类加载失败" : ((_keyword_5__5.Length == 0) ? GetEmptyTitle(_catalog_5__3, !bedrockSkinBrowser.CurrentPartSlot.HasValue) : "没有匹配的装扮"));
							bedrockSkinBrowser.EmptyDescription.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<l6vC8LfMXvCYSRCp4C3a>)_slotFailures_5__7).Count > 0 && ((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Count == 0) ? text : ((_keyword_5__5.Length == 0) ? GetEmptyDescription(_catalog_5__3, !bedrockSkinBrowser.CurrentPartSlot.HasValue) : "请更换关键词后重试"));
							string text2 = ((total > 0) ? $"已显示 {((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Count} / {total} 个{_catalogName_5__4}" : $"已显示 {((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Count} 个{_catalogName_5__4}");
							bedrockSkinBrowser.StatusText.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<l6vC8LfMXvCYSRCp4C3a>)_slotFailures_5__7).Count == 0) ? text2 : (text2 + "；" + text));
							global::System.Collections.Generic.IEnumerator<l6vC8LfMXvCYSRCp4C3a> enumerator2 = ((global::System.Collections.Generic.IEnumerable<l6vC8LfMXvCYSRCp4C3a>)_slotFailures_5__7).GetEnumerator();
							try
							{
								while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
								{
									l6vC8LfMXvCYSRCp4C3a current2 = enumerator2.Current;
									gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-skins", $"4D 拆件槽位 {(int)current2.Slot} 加载失败 category={current2.Kind} message={current2.Message}", (global::System.Exception)null);
								}
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)enumerator2)?.Dispose();
								}
							}
							((UIElement)bedrockSkinBrowser.LoadMoreButton).Visibility = ((!hasMore) ? Visibility.Visible : Visibility.Collapsed);
							_cards_5__6 = null;
							_slotFailures_5__7 = null;
						}
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception) when (_cancellation_5__2.IsCancellationRequested || bedrockSkinBrowser._loadCancellation != _cancellation_5__2)
					{
					}
					catch (global::System.Exception ex3)
					{
						string text3 = BedrockAppearanceErrorClassifier.Catalog(ex3);
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-skins", $"{_catalogName_5__4}加载失败 offset={offset} append={append}", ex3);
						if (((Collection<BedrockSkinCardViewModel>)(object)bedrockSkinBrowser.Skins).Count == 0)
						{
							bedrockSkinBrowser.StatusText.Text = text3;
							((UIElement)bedrockSkinBrowser.EmptyPanel).Visibility = (Visibility)0;
							bedrockSkinBrowser.EmptyTitle.Text = "装扮目录加载失败";
							bedrockSkinBrowser.EmptyDescription.Text = text3;
							AppShell.Error(text3);
						}
						else
						{
							bedrockSkinBrowser.StatusText.Text = _catalogName_5__4 + "刷新失败，已保留当前列表";
							((UIElement)bedrockSkinBrowser.EmptyPanel).Visibility = (Visibility)1;
						}
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockSkinBrowser._loadCancellation == _cancellation_5__2)
							{
								bedrockSkinBrowser._loadCancellation = null;
							}
							bedrockSkinBrowser.UpdateButtons();
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
				_catalogName_5__4 = null;
				_keyword_5__5 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
			_catalogName_5__4 = null;
			_keyword_5__5 = null;
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
	private struct _PartSlotSelector_SelectionChanged_d__35 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Invalid comparison between Unknown and I4
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0092;
				}
				if (bedrockSkinBrowser._service != null && (int)bedrockSkinBrowser.CurrentCatalog == 3)
				{
					bedrockSkinBrowser.ResetCatalogState();
					_u__ = bedrockSkinBrowser.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PartSlotSelector_SelectionChanged_d__35>(ref _u__, ref this);
						return;
					}
					goto IL_0092;
				}
				goto end_IL_0011;
				IL_0092:
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
	private struct _PreparePreviewAsync_d__42 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		public BedrockSkinCardViewModel item;

		private __c__DisplayClass42_0 __8__1;

		private __c__DisplayClass42_1 __8__2;

		private TaskAwaiter<LFmY9Rfae1HtFQ0pDVND> __u__1;

		private TaskAwaiter __u__2;

		private dZU6g2fptC4VZ350fMxJ _fourDimensionalSkin_5__2;

		private global::System.Threading.Tasks.Task<NIF9GNfaOUIlucHK2qQs> _prepareTask_5__3;

		private global::System.Threading.Tasks.Task<global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k>> _partsTask_5__4;

		private TaskAwaiter<NIF9GNfaOUIlucHK2qQs> __u__3;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k>> __u__4;

		private TaskAwaiter<NIF9GNfaOUIlucHK2qQs[]> __u__5;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Invalid comparison between Unknown and I4
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Unknown result type (might be due to invalid IL or missing references)
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0504: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0696: Unknown result type (might be due to invalid IL or missing references)
			//IL_069b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0778: Unknown result type (might be due to invalid IL or missing references)
			//IL_077d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0785: Unknown result type (might be due to invalid IL or missing references)
			//IL_0895: Unknown result type (might be due to invalid IL or missing references)
			//IL_089a: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0960: Unknown result type (might be due to invalid IL or missing references)
			//IL_0965: Unknown result type (might be due to invalid IL or missing references)
			//IL_096d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_065e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0663: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_054f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_067b: Unknown result type (might be due to invalid IL or missing references)
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0927: Unknown result type (might be due to invalid IL or missing references)
			//IL_092c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0451: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0945: Unknown result type (might be due to invalid IL or missing references)
			//IL_0947: Unknown result type (might be due to invalid IL or missing references)
			//IL_0736: Unknown result type (might be due to invalid IL or missing references)
			//IL_0740: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745: Unknown result type (might be due to invalid IL or missing references)
			//IL_0469: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Unknown result type (might be due to invalid IL or missing references)
			//IL_075d: Unknown result type (might be due to invalid IL or missing references)
			//IL_075f: Unknown result type (might be due to invalid IL or missing references)
			//IL_085d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0862: Unknown result type (might be due to invalid IL or missing references)
			//IL_087a: Unknown result type (might be due to invalid IL or missing references)
			//IL_087c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				if ((uint)num <= 9u)
				{
					goto IL_0084;
				}
				__8__1 = (__c__DisplayClass42_0)new __c__DisplayClass42_0();
				__8__1.__4__this = __4__this;
				if (bedrockSkinBrowser._service != null)
				{
					CancellationTokenSource? previewCancellation = bedrockSkinBrowser._previewCancellation;
					if (previewCancellation != null)
					{
						previewCancellation.Cancel();
					}
					CancellationTokenSource? previewCancellation2 = bedrockSkinBrowser._previewCancellation;
					if (previewCancellation2 != null)
					{
						previewCancellation2.Dispose();
					}
					__8__1.cancellation = new CancellationTokenSource();
					goto IL_0084;
				}
				goto end_IL_0011;
				IL_0084:
				try
				{
					if ((uint)num > 9u)
					{
						bedrockSkinBrowser._previewCancellation = __8__1.cancellation;
						bedrockSkinBrowser._preparedSkin = null;
						bedrockSkinBrowser._preparedFourDimensionalAppearance = null;
						bedrockSkinBrowser._fourDimensionalPreviewPayload = null;
						bedrockSkinBrowser._resolvedFourDimensionalParts = global::System.Array.Empty<m4wFTFfpZW4pcAqQZC1k>();
						bedrockSkinBrowser._fourDimensionalPreviewSummary = string.Empty;
						bedrockSkinBrowser.FourDimensionalViewer.ClearAppearance();
						((UIElement)bedrockSkinBrowser.SkinViewer).Visibility = (Visibility)1;
						((UIElement)bedrockSkinBrowser.FourDimensionalViewer).Visibility = (Visibility)1;
						((UIElement)bedrockSkinBrowser.RemovePartButton).Visibility = (Visibility)1;
						item.ResourceStatusText = "资源：校验中";
						bedrockSkinBrowser.PreviewName.Text = item.Name;
						bedrockSkinBrowser.PreviewDeveloper.Text = item.Developer;
						TextBlock previewSummary = bedrockSkinBrowser.PreviewSummary;
						p1aif0fNieMbuxR5AlNF kind = item.Kind;
						bool flag = (int)kind - 2 <= 1;
						previewSummary.Text = (flag ? "正在下载、校验并解析 4D 模型、动画和粒子资源" : "正在下载并校验 2D 皮肤纹理");
						bedrockSkinBrowser.StatusText.Text = "正在准备装扮资源";
						((UIElement)bedrockSkinBrowser.PreviewEmptyPanel).Visibility = (Visibility)0;
						((Control)bedrockSkinBrowser.ApplyButton).IsEnabled = false;
					}
					try
					{
						TaskAwaiter<LFmY9Rfae1HtFQ0pDVND> _u__5 = default;
						TaskAwaiter _u__ = default;
						TaskAwaiter<NIF9GNfaOUIlucHK2qQs> _u__3 = default;
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k>> _u__4;
						TaskAwaiter<NIF9GNfaOUIlucHK2qQs[]> _u__2;
						Di0YdyfpgW3VyQ3SAJMx selectedFourDimensionalAppearance;
						NIF9GNfaOUIlucHK2qQs[] result2;
						LFmY9Rfae1HtFQ0pDVND result3;
						NIF9GNfaOUIlucHK2qQs result;
						global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k> result4;
						NIF9GNfaOUIlucHK2qQs[] result5;
						switch (num)
						{
						default:
						{
							ejKX8wfpsw8ins4MWI7J twoDimensionalSkin = item.TwoDimensionalSkin;
							if (twoDimensionalSkin != null)
							{
								_u__5 = bedrockSkinBrowser._service.sLcX6yegKUP(twoDimensionalSkin, __8__1.cancellation.Token).GetAwaiter();
								if (!_u__5.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__5;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<LFmY9Rfae1HtFQ0pDVND>, _PreparePreviewAsync_d__42>(ref _u__5, ref this);
									return;
								}
								goto IL_0252;
							}
							_fourDimensionalSkin_5__2 = item.FourDimensionalSkin;
							if (_fourDimensionalSkin_5__2 != null)
							{
								_prepareTask_5__3 = bedrockSkinBrowser._service.LItX6VaLIpi(_fourDimensionalSkin_5__2, __8__1.cancellation.Token);
								_partsTask_5__4 = bedrockSkinBrowser._service.S0GX6c9Jrwd(_fourDimensionalSkin_5__2, __8__1.cancellation.Token);
								_u__ = global::System.Threading.Tasks.Task.WhenAll(new global::System.Threading.Tasks.Task[2] { _prepareTask_5__3, _partsTask_5__4 }).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 2);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PreparePreviewAsync_d__42>(ref _u__, ref this);
									return;
								}
								goto IL_04a0;
							}
							__8__2 = (__c__DisplayClass42_1)new __c__DisplayClass42_1();
							__8__2.fourDimensionalPart = item.FourDimensionalPart;
							if (__8__2.fourDimensionalPart != null)
							{
								_u__3 = bedrockSkinBrowser._service.gfOX6YQmonS(__8__2.fourDimensionalPart, __8__1.cancellation.Token).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 7);
									__u__3 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<NIF9GNfaOUIlucHK2qQs>, _PreparePreviewAsync_d__42>(ref _u__3, ref this);
									return;
								}
								goto IL_0794;
							}
							goto IL_09a0;
						}
						case 0:
							_u__5 = __u__1;
							__u__1 = default(TaskAwaiter<LFmY9Rfae1HtFQ0pDVND>);
							num = (__1__state = -1);
							goto IL_0252;
						case 1:
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_0399;
						case 2:
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_04a0;
						case 3:
							_u__3 = __u__3;
							__u__3 = default(TaskAwaiter<NIF9GNfaOUIlucHK2qQs>);
							num = (__1__state = -1);
							goto IL_051b;
						case 4:
							_u__4 = __u__4;
							__u__4 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k>>);
							num = (__1__state = -1);
							goto IL_0586;
						case 5:
							_u__2 = __u__5;
							__u__5 = default(TaskAwaiter<NIF9GNfaOUIlucHK2qQs[]>);
							num = (__1__state = -1);
							goto IL_060c;
						case 6:
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_06b2;
						case 7:
							_u__3 = __u__3;
							__u__3 = default(TaskAwaiter<NIF9GNfaOUIlucHK2qQs>);
							num = (__1__state = -1);
							goto IL_0794;
						case 8:
							_u__2 = __u__5;
							__u__5 = default(TaskAwaiter<NIF9GNfaOUIlucHK2qQs[]>);
							num = (__1__state = -1);
							goto IL_08b1;
						case 9:
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_097c;
							}
							IL_0794:
							result = _u__3.GetResult();
							bedrockSkinBrowser._preparedFourDimensionalAppearance = result;
							selectedFourDimensionalAppearance = bedrockSkinBrowser._service.SelectedFourDimensionalAppearance;
							bedrockSkinBrowser._resolvedFourDimensionalParts = Enumerable.ToArray<m4wFTFfpZW4pcAqQZC1k>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)Enumerable.OrderBy<m4wFTFfpZW4pcAqQZC1k, int>(Enumerable.Append<m4wFTFfpZW4pcAqQZC1k>(Enumerable.Where<m4wFTFfpZW4pcAqQZC1k>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)(((selectedFourDimensionalAppearance != null) ? selectedFourDimensionalAppearance.Parts : null) ?? global::System.Array.Empty<m4wFTFfpZW4pcAqQZC1k>()), (Func<m4wFTFfpZW4pcAqQZC1k, bool>)__8__2._PreparePreviewAsync_b__1), __8__2.fourDimensionalPart), (Func<m4wFTFfpZW4pcAqQZC1k, int>)__c_10.__9._PreparePreviewAsync_b__42_2));
							_u__2 = global::System.Threading.Tasks.Task.WhenAll<NIF9GNfaOUIlucHK2qQs>(Enumerable.Select<m4wFTFfpZW4pcAqQZC1k, global::System.Threading.Tasks.Task<NIF9GNfaOUIlucHK2qQs>>(Enumerable.Where<m4wFTFfpZW4pcAqQZC1k>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)bedrockSkinBrowser._resolvedFourDimensionalParts, (Func<m4wFTFfpZW4pcAqQZC1k, bool>)__8__2._PreparePreviewAsync_b__3), (Func<m4wFTFfpZW4pcAqQZC1k, global::System.Threading.Tasks.Task<NIF9GNfaOUIlucHK2qQs>>)__8__1._PreparePreviewAsync_b__4)).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 8);
								__u__5 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<NIF9GNfaOUIlucHK2qQs[]>, _PreparePreviewAsync_d__42>(ref _u__2, ref this);
								return;
							}
							goto IL_08b1;
							IL_08b1:
							result2 = _u__2.GetResult();
							bedrockSkinBrowser._fourDimensionalPreviewPayload = bedrockSkinBrowser._service.rS9X6SDIWjg(__8__2.fourDimensionalPart.Id, __8__2.fourDimensionalPart.Name, Enumerable.Concat<NIF9GNfaOUIlucHK2qQs>((global::System.Collections.Generic.IEnumerable<NIF9GNfaOUIlucHK2qQs>)(object)new NIF9GNfaOUIlucHK2qQs[1] { bedrockSkinBrowser._preparedFourDimensionalAppearance }, (global::System.Collections.Generic.IEnumerable<NIF9GNfaOUIlucHK2qQs>)result2));
							if (!__8__1.cancellation.IsCancellationRequested)
							{
								_u__ = bedrockSkinBrowser.ShowFourDimensionalPreviewAsync(item).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 9);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PreparePreviewAsync_d__42>(ref _u__, ref this);
									return;
								}
								goto IL_097c;
							}
							goto end_IL_019f;
							IL_0252:
							result3 = _u__5.GetResult();
							if (!__8__1.cancellation.IsCancellationRequested)
							{
								bedrockSkinBrowser._preparedSkin = result3;
								bedrockSkinBrowser.FourDimensionalViewer.ClearAppearance();
								((UIElement)bedrockSkinBrowser.SkinViewer).Visibility = (Visibility)0;
								((UIElement)bedrockSkinBrowser.FourDimensionalViewer).Visibility = (Visibility)1;
								bedrockSkinBrowser.SetAnimationNames(global::System.Array.Empty<string>());
								bedrockSkinBrowser.PreviewTitle.Text = "2D 三维预览";
								((ContentControl)bedrockSkinBrowser.ApplyButton).Content = "应用 2D 皮肤";
								bedrockSkinBrowser.PreviewName.Text = result3.Skin.Name;
								bedrockSkinBrowser.PreviewDeveloper.Text = item.Developer;
								bedrockSkinBrowser.PreviewSummary.Text = result3.Skin.Summary;
								((UIElement)bedrockSkinBrowser.PreviewEmptyPanel).Visibility = (Visibility)1;
								_u__ = bedrockSkinBrowser.SkinViewer.ShowSkinAsync(result3.LocalPath, result3.Skin.Name, result3.Skin.TitleImageUrl).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PreparePreviewAsync_d__42>(ref _u__, ref this);
									return;
								}
								goto IL_0399;
							}
							goto end_IL_019f;
							IL_097c:
							_u__.GetResult();
							bedrockSkinBrowser.UpdateFourDimensionalCardStatus(item, 0);
							bedrockSkinBrowser.StatusText.Text = "4D 拆件资源已就绪";
							goto IL_09a0;
							IL_09a0:
							__8__2 = null;
							break;
							IL_0399:
							_u__.GetResult();
							item.ResourceStatusText = "资源：2D 纹理已校验";
							bedrockSkinBrowser.StatusText.Text = "2D 皮肤资源已就绪";
							goto end_IL_019f;
							IL_051b:
							result = _u__3.GetResult();
							bedrockSkinBrowser._preparedFourDimensionalAppearance = result;
							_u__4 = _partsTask_5__4.GetAwaiter();
							if (!_u__4.IsCompleted)
							{
								num = (__1__state = 4);
								__u__4 = _u__4;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k>>, _PreparePreviewAsync_d__42>(ref _u__4, ref this);
								return;
							}
							goto IL_0586;
							IL_0586:
							result4 = _u__4.GetResult();
							bedrockSkinBrowser._resolvedFourDimensionalParts = result4;
							_u__2 = global::System.Threading.Tasks.Task.WhenAll<NIF9GNfaOUIlucHK2qQs>(Enumerable.Select<m4wFTFfpZW4pcAqQZC1k, global::System.Threading.Tasks.Task<NIF9GNfaOUIlucHK2qQs>>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)bedrockSkinBrowser._resolvedFourDimensionalParts, (Func<m4wFTFfpZW4pcAqQZC1k, global::System.Threading.Tasks.Task<NIF9GNfaOUIlucHK2qQs>>)__8__1._PreparePreviewAsync_b__0)).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 5);
								__u__5 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<NIF9GNfaOUIlucHK2qQs[]>, _PreparePreviewAsync_d__42>(ref _u__2, ref this);
								return;
							}
							goto IL_060c;
							IL_060c:
							result5 = _u__2.GetResult();
							bedrockSkinBrowser._fourDimensionalPreviewPayload = bedrockSkinBrowser._service.rS9X6SDIWjg(_fourDimensionalSkin_5__2.Id, _fourDimensionalSkin_5__2.Name, Enumerable.Concat<NIF9GNfaOUIlucHK2qQs>((global::System.Collections.Generic.IEnumerable<NIF9GNfaOUIlucHK2qQs>)(object)new NIF9GNfaOUIlucHK2qQs[1] { bedrockSkinBrowser._preparedFourDimensionalAppearance }, (global::System.Collections.Generic.IEnumerable<NIF9GNfaOUIlucHK2qQs>)result5));
							_u__ = bedrockSkinBrowser.ShowFourDimensionalPreviewAsync(item).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 6);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PreparePreviewAsync_d__42>(ref _u__, ref this);
								return;
							}
							goto IL_06b2;
							IL_04a0:
							_u__.GetResult();
							if (!__8__1.cancellation.IsCancellationRequested)
							{
								_u__3 = _prepareTask_5__3.GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 3);
									__u__3 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<NIF9GNfaOUIlucHK2qQs>, _PreparePreviewAsync_d__42>(ref _u__3, ref this);
									return;
								}
								goto IL_051b;
							}
							goto end_IL_019f;
							IL_06b2:
							_u__.GetResult();
							bedrockSkinBrowser.UpdateFourDimensionalCardStatus(item, 0);
							bedrockSkinBrowser.StatusText.Text = "4D 皮肤资源已就绪";
							_prepareTask_5__3 = null;
							_partsTask_5__4 = null;
							break;
						}
						_fourDimensionalSkin_5__2 = null;
						end_IL_019f:;
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception) when (__8__1.cancellation.IsCancellationRequested || bedrockSkinBrowser._previewCancellation != __8__1.cancellation)
					{
					}
					catch (global::System.Exception ex3)
					{
						bedrockSkinBrowser.PreviewSummary.Text = BedrockAppearanceErrorClassifier.Resource(ex3);
						item.ResourceStatusText = "资源：准备失败";
						((UIElement)bedrockSkinBrowser.PreviewEmptyPanel).Visibility = (Visibility)0;
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-skins", "装扮预览失败 itemId=" + item.Id, ex3);
						AppShell.Error(bedrockSkinBrowser.PreviewSummary.Text);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockSkinBrowser._previewCancellation == __8__1.cancellation)
							{
								bedrockSkinBrowser._previewCancellation = null;
							}
							bedrockSkinBrowser.UpdateButtons();
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
	private struct _RefreshServerAppliedStateAsync_d__32 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private TaskAwaiter<SiCQKdfMS08AxK51wAlm> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				if (num == 0 || bedrockSkinBrowser._service != null)
				{
					try
					{
						TaskAwaiter<SiCQKdfMS08AxK51wAlm> _u__ = default;
						if (num != 0)
						{
							_u__ = bedrockSkinBrowser._service.JoSX6Z0yTbY(default(CancellationToken)).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SiCQKdfMS08AxK51wAlm>, _RefreshServerAppliedStateAsync_d__32>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<SiCQKdfMS08AxK51wAlm>);
							num = (__1__state = -1);
						}
						SiCQKdfMS08AxK51wAlm result = _u__.GetResult();
						bedrockSkinBrowser._serverAppliedSkinId = result.SkinId;
						bedrockSkinBrowser._serverAppliedPartIds = (IReadOnlySet<string>)(object)Enumerable.ToHashSet<string>(result.PartItemIds.Values, (IEqualityComparer<string>)(object)StringComparer.Ordinal);
						bedrockSkinBrowser._serverAppliedPartSlots = (IReadOnlySet<mWGKInfNzSRMjl3TLmeA>)(object)Enumerable.ToHashSet<mWGKInfNzSRMjl3TLmeA>(result.PartItemIds.Keys);
						bedrockSkinBrowser._hasServerAppliedState = true;
					}
					catch (global::System.Exception ex)
					{
						bedrockSkinBrowser.ClearServerAppliedStateCache();
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-skins", "读取当前服务器装扮状态失败，回退到本地选择", ex);
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
	private struct _RemovePartButton_Click_d__46 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private m4wFTFfpZW4pcAqQZC1k _part_5__2;

		private CancellationTokenSource _cancellation_5__3;

		private TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_0240: Expected I4, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0097;
				}
				if (bedrockSkinBrowser._service != null)
				{
					NIF9GNfaOUIlucHK2qQs? preparedFourDimensionalAppearance = bedrockSkinBrowser._preparedFourDimensionalAppearance;
					_part_5__2 = ((preparedFourDimensionalAppearance != null) ? preparedFourDimensionalAppearance.Part : null);
					if (_part_5__2 != null)
					{
						CancellationTokenSource? applyCancellation = bedrockSkinBrowser._applyCancellation;
						if (applyCancellation != null)
						{
							applyCancellation.Cancel();
						}
						CancellationTokenSource? applyCancellation2 = bedrockSkinBrowser._applyCancellation;
						if (applyCancellation2 != null)
						{
							applyCancellation2.Dispose();
						}
						_cancellation_5__3 = new CancellationTokenSource();
						bedrockSkinBrowser._applyCancellation = _cancellation_5__3;
						goto IL_0097;
					}
				}
				goto end_IL_0011;
				IL_0097:
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_01af;
						}
						bedrockSkinBrowser.StatusText.Text = "正在卸下" + GetSlotName(_part_5__2.Slot) + " 4D 拆件";
						_u__2 = bedrockSkinBrowser._service.eCOX6kehfQO(_part_5__2.Slot, _cancellation_5__3.Token).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ>, _RemovePartButton_Click_d__46>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<sqxgGaf1G3NFtC5JDIRJ>);
						num = (__1__state = -1);
					}
					_u__2.GetResult();
					bedrockSkinBrowser.StatusText.Text = "正在回读验证装扮";
					_u__ = bedrockSkinBrowser.RefreshServerAppliedStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RemovePartButton_Click_d__46>(ref _u__, ref this);
						return;
					}
					goto IL_01af;
					IL_01af:
					_u__.GetResult();
					bedrockSkinBrowser.RefreshAppliedState();
					bedrockSkinBrowser.StatusText.Text = "已卸下" + GetSlotName(_part_5__2.Slot) + " 4D 拆件并通过服务器回读";
					bedrockSkinBrowser.ShowAppearanceAppliedSuccess("已卸下 4D 拆件槽位：" + GetSlotName(_part_5__2.Slot));
				}
				catch (OperationCanceledException)
				{
				}
				catch (global::System.Exception ex2)
				{
					gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-skins", $"卸下 4D 拆件失败 slot={(int)_part_5__2.Slot}", ex2);
					string text = BedrockAppearanceErrorClassifier.Apply(ex2);
					bedrockSkinBrowser.StatusText.Text = text;
					AppShell.Error(text);
				}
				finally
				{
					if (num < 0)
					{
						if (bedrockSkinBrowser._applyCancellation == _cancellation_5__3)
						{
							bedrockSkinBrowser._applyCancellation = null;
						}
						_cancellation_5__3.Dispose();
						bedrockSkinBrowser.UpdateButtons();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_part_5__2 = null;
				_cancellation_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_part_5__2 = null;
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
	private struct _ResetSkinButton_Click_d__45 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		private TaskAwaiter<AZci00fpEbV8HcEwinMT> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0034;
				}
				if (bedrockSkinBrowser._service != null)
				{
					((Control)bedrockSkinBrowser.ResetSkinButton).IsEnabled = false;
					goto IL_0034;
				}
				goto end_IL_0011;
				IL_0034:
				try
				{
					TaskAwaiter<AZci00fpEbV8HcEwinMT> _u__ = default;
					if (num != 0)
					{
						bedrockSkinBrowser.StatusText.Text = "正在同步默认 2D 皮肤";
						_u__ = bedrockSkinBrowser._service.tTBX6J3dirb("10000", default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<AZci00fpEbV8HcEwinMT>, _ResetSkinButton_Click_d__45>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<AZci00fpEbV8HcEwinMT>);
						num = (__1__state = -1);
					}
					AZci00fpEbV8HcEwinMT result = _u__.GetResult();
					bedrockSkinBrowser.ClearServerAppliedStateCache();
					bedrockSkinBrowser.RefreshAppliedState();
					bedrockSkinBrowser.StatusText.Text = "默认 2D 皮肤已同步";
					bedrockSkinBrowser.ShowAppearanceAppliedSuccess("已恢复默认 2D 皮肤：" + result.Skin.Name);
				}
				catch (global::System.Exception ex)
				{
					gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-skins", "恢复默认皮肤失败", ex);
					string text = BedrockAppearanceErrorClassifier.Apply(ex);
					bedrockSkinBrowser.StatusText.Text = text;
					AppShell.Error(text);
				}
				finally
				{
					if (num < 0)
					{
						bedrockSkinBrowser.UpdateButtons();
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
	private struct _SearchBox_QuerySubmitted_d__37 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

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
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockSkinBrowser.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchBox_QuerySubmitted_d__37>(ref _u__, ref this);
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
	private struct _SearchBox_TextChanged_d__38 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

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
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
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
				if (!bedrockSkinBrowser._suppressSearchRefresh && (int)args.Reason == 0 && string.IsNullOrWhiteSpace(sender.Text))
				{
					_u__ = bedrockSkinBrowser.LoadPageAsync(0, append: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchBox_TextChanged_d__38>(ref _u__, ref this);
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
	private struct _ShowFourDimensionalPreviewAsync_d__43 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

		public BedrockSkinCardViewModel item;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_01ca;
				}
				NIF9GNfaOUIlucHK2qQs val = bedrockSkinBrowser._preparedFourDimensionalAppearance ?? throw new InvalidOperationException("4D 装扮尚未准备完成");
				((UIElement)bedrockSkinBrowser.SkinViewer).Visibility = (Visibility)1;
				((UIElement)bedrockSkinBrowser.FourDimensionalViewer).Visibility = (Visibility)0;
				bedrockSkinBrowser.PreviewTitle.Text = "4D 动画与粒子预览";
				((ContentControl)bedrockSkinBrowser.ApplyButton).Content = (val.IsCompleteSkin ? "穿戴 4D 皮肤" : "穿戴 4D 组件");
				((UIElement)bedrockSkinBrowser.RemovePartButton).Visibility = ((val.Part == null) ? Visibility.Visible : Visibility.Collapsed);
				bedrockSkinBrowser.PreviewName.Text = val.Name;
				bedrockSkinBrowser.PreviewDeveloper.Text = item.Developer;
				bedrockSkinBrowser._fourDimensionalPreviewSummary = item.Summary;
				bedrockSkinBrowser.PreviewSummary.Text = bedrockSkinBrowser._fourDimensionalPreviewSummary;
				((UIElement)bedrockSkinBrowser.PreviewEmptyPanel).Visibility = (Visibility)1;
				wj4U04fpmtYOnJb5AT2Q val2 = bedrockSkinBrowser._fourDimensionalPreviewPayload ?? val.Preview;
				if (((global::System.Collections.Generic.IReadOnlyCollection<yFupgpfpy3KmMqUSH5b5>)val2.GeometryFiles).Count != 0 && ((global::System.Collections.Generic.IReadOnlyCollection<b9eIS3fp4yf1hN7CxE1B>)val2.Textures).Count != 0)
				{
					BedrockFourDimensionalViewer fourDimensionalViewer = bedrockSkinBrowser.FourDimensionalViewer;
					string coverUrl = item.CoverUrl;
					CancellationTokenSource? previewCancellation = bedrockSkinBrowser._previewCancellation;
					_u__ = fourDimensionalViewer.ShowAppearanceAsync(val2, coverUrl, (previewCancellation != null) ? previewCancellation.Token : CancellationToken.None).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ShowFourDimensionalPreviewAsync_d__43>(ref _u__, ref this);
						return;
					}
					goto IL_01ca;
				}
				bedrockSkinBrowser.FourDimensionalViewer.ShowFallbackAppearance(item.CoverUrl, "该装扮资源未提供可独立渲染的模型，已显示网易官方预览图");
				goto end_IL_0011;
				IL_01ca:
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
	private struct _SkinGrid_SelectionChanged_d__41 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinBrowser __4__this;

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
			BedrockSkinBrowser bedrockSkinBrowser = __4__this;
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
				if (((Selector)bedrockSkinBrowser.SkinGrid).SelectedItem is BedrockSkinCardViewModel item)
				{
					_u__ = bedrockSkinBrowser.PreparePreviewAsync(item).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SkinGrid_SelectionChanged_d__41>(ref _u__, ref this);
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

	private const int PageSize = 20;

	private const double WideLayoutThreshold = 1000.0;

	private da18CdX55laNMRKtM3p0? _service;

	private CancellationTokenSource? _loadCancellation;

	private CancellationTokenSource? _previewCancellation;

	private CancellationTokenSource? _applyCancellation;

	private LFmY9Rfae1HtFQ0pDVND? _preparedSkin;

	private NIF9GNfaOUIlucHK2qQs? _preparedFourDimensionalAppearance;

	private wj4U04fpmtYOnJb5AT2Q? _fourDimensionalPreviewPayload;

	private global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k> _resolvedFourDimensionalParts;

	private string _serverAppliedSkinId;

	private IReadOnlySet<string> _serverAppliedPartIds;

	private IReadOnlySet<mWGKInfNzSRMjl3TLmeA> _serverAppliedPartSlots;

	private bool _hasServerAppliedState;

	private int _currentOffset;

	private int _currentItemCount;

	private bool _hasMore;

	private bool _suppressSearchRefresh;

	private bool _suppressAnimationSelection;

	private string _fourDimensionalPreviewSummary;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ResponsiveRoot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition CatalogColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition PreviewColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition CompactPreviewRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border PreviewPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ApplyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RemovePartButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ResetSkinButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewName;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewDeveloper;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewSummary;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockSkinViewer SkinViewer;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockFourDimensionalViewer FourDimensionalViewer;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel PreviewEmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleButton AutoRotateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleButton AnimationButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleButton ParticleButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PreviewTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox AnimationSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private GridView SkinGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LoadMoreButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox PartSlotSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SelectorBar CatalogSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AutoSuggestBox SearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockSkinBrowser_Bindings Bindings;

	[field: CompilerGenerated]
	private ObservableCollection<BedrockSkinCardViewModel> _Skins_k__BackingField;
	public ObservableCollection<BedrockSkinCardViewModel> Skins
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private p1aif0fNieMbuxR5AlNF CurrentCatalog
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			SelectorBarItem selectedItem = CatalogSelector.SelectedItem;
			string text = ((selectedItem == null) ? null : ((FrameworkElement)selectedItem).Tag?.ToString());
			if (!(text == "owned-2d"))
			{
				if (!(text == "4d-skin"))
				{
					if (text == "4d-part")
					{
						return (p1aif0fNieMbuxR5AlNF)3;
					}
					return (p1aif0fNieMbuxR5AlNF)0;
				}
				return (p1aif0fNieMbuxR5AlNF)2;
			}
			return (p1aif0fNieMbuxR5AlNF)1;
		}
	}

	private mWGKInfNzSRMjl3TLmeA? CurrentPartSlot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			object selectedItem = ((Selector)PartSlotSelector).SelectedItem;
			ComboBoxItem val = (ComboBoxItem)((selectedItem is ComboBoxItem) ? selectedItem : null);
			int num = default(int);
			if (val != null && int.TryParse(((FrameworkElement)val).Tag?.ToString(), out num) && num >= 16 && num <= 22)
			{
				return (mWGKInfNzSRMjl3TLmeA)num;
			}
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockSkinBrowser()
	{
		_resolvedFourDimensionalParts = global::System.Array.Empty<m4wFTFfpZW4pcAqQZC1k>();
		_serverAppliedSkinId = string.Empty;
		_serverAppliedPartIds = (IReadOnlySet<string>)(object)new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		_serverAppliedPartSlots = (IReadOnlySet<mWGKInfNzSRMjl3TLmeA>)(object)new HashSet<mWGKInfNzSRMjl3TLmeA>();
		_fourDimensionalPreviewSummary = string.Empty;
		_Skins_k__BackingField = new ObservableCollection<BedrockSkinCardViewModel>();
		InitializeComponent();
		AutoRotateButton.IsChecked = SkinViewer.AutoRotateEnabled;
		FourDimensionalViewer.AnimationNamesChanged += FourDimensionalViewer_AnimationNamesChanged;
		FourDimensionalViewer.PreviewWarningsChanged += FourDimensionalViewer_PreviewWarningsChanged;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Attach(da18CdX55laNMRKtM3p0 service)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_service = service ?? throw new ArgumentNullException("service");
		RefreshAppliedState();
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		CancelRequests();
		((Collection<BedrockSkinCardViewModel>)(object)Skins).Clear();
		_currentOffset = 0;
		_currentItemCount = 0;
		_hasMore = false;
		ClearServerAppliedStateCache();
		ResetPreviewState();
		StatusText.Text = "登录后浏览网易皮肤";
		((UIElement)EmptyPanel).Visibility = (Visibility)0;
		EmptyTitle.Text = "等待皮肤目录";
		EmptyDescription.Text = "登录后可预览并应用 2D/4D 装扮";
		((UIElement)LoadMoreButton).Visibility = (Visibility)1;
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task LoadInitialAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadInitialAsync_d__31 loadInitialAsync_d__ = default(_LoadInitialAsync_d__31);
		loadInitialAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadInitialAsync_d__.__4__this = this;
		loadInitialAsync_d__.__1__state = -1;
		loadInitialAsync_d__.__t__builder.Start<_LoadInitialAsync_d__31>(ref loadInitialAsync_d__);
		return loadInitialAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshServerAppliedStateAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshServerAppliedStateAsync_d__32 refreshServerAppliedStateAsync_d__ = default(_RefreshServerAppliedStateAsync_d__32);
		refreshServerAppliedStateAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshServerAppliedStateAsync_d__.__4__this = this;
		refreshServerAppliedStateAsync_d__.__1__state = -1;
		refreshServerAppliedStateAsync_d__.__t__builder.Start<_RefreshServerAppliedStateAsync_d__32>(ref refreshServerAppliedStateAsync_d__);
		return refreshServerAppliedStateAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadPageAsync(int offset, bool append)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadPageAsync_d__33 loadPageAsync_d__ = default(_LoadPageAsync_d__33);
		loadPageAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadPageAsync_d__.__4__this = this;
		loadPageAsync_d__.offset = offset;
		loadPageAsync_d__.append = append;
		loadPageAsync_d__.__1__state = -1;
		loadPageAsync_d__.__t__builder.Start<_LoadPageAsync_d__33>(ref loadPageAsync_d__);
		return loadPageAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CatalogSelector_SelectionChanged(SelectorBar sender, SelectorBarSelectionChangedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CatalogSelector_SelectionChanged_d__34 catalogSelector_SelectionChanged_d__ = default(_CatalogSelector_SelectionChanged_d__34);
		catalogSelector_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		catalogSelector_SelectionChanged_d__.__4__this = this;
		catalogSelector_SelectionChanged_d__.__1__state = -1;
		catalogSelector_SelectionChanged_d__.__t__builder.Start<_CatalogSelector_SelectionChanged_d__34>(ref catalogSelector_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void PartSlotSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PartSlotSelector_SelectionChanged_d__35 partSlotSelector_SelectionChanged_d__ = default(_PartSlotSelector_SelectionChanged_d__35);
		partSlotSelector_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		partSlotSelector_SelectionChanged_d__.__4__this = this;
		partSlotSelector_SelectionChanged_d__.__1__state = -1;
		partSlotSelector_SelectionChanged_d__.__t__builder.Start<_PartSlotSelector_SelectionChanged_d__35>(ref partSlotSelector_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetCatalogState()
	{
		CancelRequests();
		_suppressSearchRefresh = true;
		SearchBox.Text = string.Empty;
		_suppressSearchRefresh = false;
		((Collection<BedrockSkinCardViewModel>)(object)Skins).Clear();
		_currentOffset = 0;
		_currentItemCount = 0;
		_hasMore = false;
		ResetPreviewState();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchBox_QuerySubmitted_d__37 searchBox_QuerySubmitted_d__ = default(_SearchBox_QuerySubmitted_d__37);
		searchBox_QuerySubmitted_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchBox_QuerySubmitted_d__.__4__this = this;
		searchBox_QuerySubmitted_d__.__1__state = -1;
		searchBox_QuerySubmitted_d__.__t__builder.Start<_SearchBox_QuerySubmitted_d__37>(ref searchBox_QuerySubmitted_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchBox_TextChanged_d__38 searchBox_TextChanged_d__ = default(_SearchBox_TextChanged_d__38);
		searchBox_TextChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchBox_TextChanged_d__.__4__this = this;
		searchBox_TextChanged_d__.sender = sender;
		searchBox_TextChanged_d__.args = args;
		searchBox_TextChanged_d__.__1__state = -1;
		searchBox_TextChanged_d__.__t__builder.Start<_SearchBox_TextChanged_d__38>(ref searchBox_TextChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LoadMoreButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadMoreButton_Click_d__39 loadMoreButton_Click_d__ = default(_LoadMoreButton_Click_d__39);
		loadMoreButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		loadMoreButton_Click_d__.__4__this = this;
		loadMoreButton_Click_d__.__1__state = -1;
		loadMoreButton_Click_d__.__t__builder.Start<_LoadMoreButton_Click_d__39>(ref loadMoreButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SkinGrid_ItemClick(object sender, ItemClickEventArgs e)
	{
		if (e.ClickedItem is BedrockSkinCardViewModel selectedItem)
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
		_SkinGrid_SelectionChanged_d__41 skinGrid_SelectionChanged_d__ = default(_SkinGrid_SelectionChanged_d__41);
		skinGrid_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		skinGrid_SelectionChanged_d__.__4__this = this;
		skinGrid_SelectionChanged_d__.__1__state = -1;
		skinGrid_SelectionChanged_d__.__t__builder.Start<_SkinGrid_SelectionChanged_d__41>(ref skinGrid_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task PreparePreviewAsync(BedrockSkinCardViewModel item)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PreparePreviewAsync_d__42 preparePreviewAsync_d__ = default(_PreparePreviewAsync_d__42);
		preparePreviewAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		preparePreviewAsync_d__.__4__this = this;
		preparePreviewAsync_d__.item = item;
		preparePreviewAsync_d__.__1__state = -1;
		preparePreviewAsync_d__.__t__builder.Start<_PreparePreviewAsync_d__42>(ref preparePreviewAsync_d__);
		return preparePreviewAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowFourDimensionalPreviewAsync(BedrockSkinCardViewModel item)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowFourDimensionalPreviewAsync_d__43 showFourDimensionalPreviewAsync_d__ = default(_ShowFourDimensionalPreviewAsync_d__43);
		showFourDimensionalPreviewAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showFourDimensionalPreviewAsync_d__.__4__this = this;
		showFourDimensionalPreviewAsync_d__.item = item;
		showFourDimensionalPreviewAsync_d__.__1__state = -1;
		showFourDimensionalPreviewAsync_d__.__t__builder.Start<_ShowFourDimensionalPreviewAsync_d__43>(ref showFourDimensionalPreviewAsync_d__);
		return showFourDimensionalPreviewAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ApplyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ApplyButton_Click_d__44 applyButton_Click_d__ = default(_ApplyButton_Click_d__44);
		applyButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		applyButton_Click_d__.__4__this = this;
		applyButton_Click_d__.__1__state = -1;
		applyButton_Click_d__.__t__builder.Start<_ApplyButton_Click_d__44>(ref applyButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ResetSkinButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ResetSkinButton_Click_d__45 resetSkinButton_Click_d__ = default(_ResetSkinButton_Click_d__45);
		resetSkinButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		resetSkinButton_Click_d__.__4__this = this;
		resetSkinButton_Click_d__.__1__state = -1;
		resetSkinButton_Click_d__.__t__builder.Start<_ResetSkinButton_Click_d__45>(ref resetSkinButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RemovePartButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RemovePartButton_Click_d__46 removePartButton_Click_d__ = default(_RemovePartButton_Click_d__46);
		removePartButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		removePartButton_Click_d__.__4__this = this;
		removePartButton_Click_d__.__1__state = -1;
		removePartButton_Click_d__.__t__builder.Start<_RemovePartButton_Click_d__46>(ref removePartButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AutoRotateButton_Click(object sender, RoutedEventArgs e)
	{
		bool valueOrDefault = AutoRotateButton.IsChecked == true;
		SkinViewer.SetAutoRotate(valueOrDefault);
		FourDimensionalViewer.SetAutoRotate(valueOrDefault);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AnimationButton_Click(object sender, RoutedEventArgs e)
	{
		FourDimensionalViewer.SetAnimationsEnabled(AnimationButton.IsChecked == true);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AnimationSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (!_suppressAnimationSelection && ((Selector)AnimationSelector).SelectedItem is string animation)
		{
			FourDimensionalViewer.SetAnimation(animation);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void FourDimensionalViewer_AnimationNamesChanged(global::System.Collections.Generic.IReadOnlyList<string> names)
	{
		SetAnimationNames(names);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void FourDimensionalViewer_PreviewWarningsChanged(global::System.Collections.Generic.IReadOnlyList<string> warnings)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		PreviewSummary.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<string>)warnings).Count == 0) ? _fourDimensionalPreviewSummary : (string.IsNullOrWhiteSpace(_fourDimensionalPreviewSummary) ? ("兼容性提示：" + string.Join("；", (global::System.Collections.Generic.IEnumerable<string>)warnings)) : (_fourDimensionalPreviewSummary + "；兼容性提示：" + string.Join("；", (global::System.Collections.Generic.IEnumerable<string>)warnings))));
		BedrockSkinCardViewModel bedrockSkinCardViewModel = ((Selector)SkinGrid).SelectedItem as BedrockSkinCardViewModel;
		bool flag = bedrockSkinCardViewModel != null;
		if (flag)
		{
			p1aif0fNieMbuxR5AlNF kind = bedrockSkinCardViewModel.Kind;
			bool flag2 = (int)kind - 2 <= 1;
			flag = flag2;
		}
		if (flag)
		{
			UpdateFourDimensionalCardStatus(bedrockSkinCardViewModel, ((global::System.Collections.Generic.IReadOnlyCollection<string>)warnings).Count);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateFourDimensionalCardStatus(BedrockSkinCardViewModel item, int warningCount)
	{
		NIF9GNfaOUIlucHK2qQs? preparedFourDimensionalAppearance = _preparedFourDimensionalAppearance;
		wj4U04fpmtYOnJb5AT2Q val = ((preparedFourDimensionalAppearance != null) ? preparedFourDimensionalAppearance.Preview : null);
		if (val != null)
		{
			item.ResourceStatusText = ((warningCount == 0) ? $"已缓存 · G{((global::System.Collections.Generic.IReadOnlyCollection<yFupgpfpy3KmMqUSH5b5>)val.GeometryFiles).Count} A{((global::System.Collections.Generic.IReadOnlyCollection<yFupgpfpy3KmMqUSH5b5>)val.AnimationFiles).Count} P{((global::System.Collections.Generic.IReadOnlyCollection<yFupgpfpy3KmMqUSH5b5>)val.ParticleFiles).Count} · 兼容" : $"已缓存 · G{((global::System.Collections.Generic.IReadOnlyCollection<yFupgpfpy3KmMqUSH5b5>)val.GeometryFiles).Count} A{((global::System.Collections.Generic.IReadOnlyCollection<yFupgpfpy3KmMqUSH5b5>)val.AnimationFiles).Count} P{((global::System.Collections.Generic.IReadOnlyCollection<yFupgpfpy3KmMqUSH5b5>)val.ParticleFiles).Count} · {warningCount} 项降级");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetAnimationNames(global::System.Collections.Generic.IReadOnlyList<string> names)
	{
		_suppressAnimationSelection = true;
		try
		{
			((ItemsControl)AnimationSelector).ItemsSource = names;
			((Selector)AnimationSelector).SelectedIndex = ((((global::System.Collections.Generic.IReadOnlyCollection<string>)names).Count <= 0) ? (-1) : 0);
			((UIElement)AnimationSelector).Visibility = ((((global::System.Collections.Generic.IReadOnlyCollection<string>)names).Count <= 0) ? Visibility.Visible : Visibility.Collapsed);
		}
		finally
		{
			_suppressAnimationSelection = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ParticleButton_Click(object sender, RoutedEventArgs e)
	{
		FourDimensionalViewer.SetParticlesEnabled(ParticleButton.IsChecked == true);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetViewButton_Click(object sender, RoutedEventArgs e)
	{
		SkinViewer.ResetView();
		FourDimensionalViewer.ResetView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResponsiveRoot_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		Size newSize = e.NewSize;
		bool flag = newSize.Width >= 1000.0;
		PreviewColumn.Width = (flag ? new GridLength(400.0) : new GridLength(0.0));
		CompactPreviewRow.Height = (GridLength)(flag ? new GridLength(0.0) : GridLength.Auto);
		Grid.SetRow((FrameworkElement)(object)PreviewPanel, (!flag) ? 2 : 0);
		Grid.SetRowSpan((FrameworkElement)(object)PreviewPanel, (!flag) ? 1 : 2);
		Grid.SetColumn((FrameworkElement)(object)PreviewPanel, flag ? 1 : 0);
		((FrameworkElement)PreviewPanel).Margin = (flag ? new Thickness(0.0) : new Thickness(0.0, 16.0, 0.0, 0.0));
		((FrameworkElement)PreviewPanel).MinHeight = ((!flag) ? 560 : 0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshAppliedState()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		TeW086XKeOM5MZhBfSt8 val = ResolveAppliedDisplayState();
		global::System.Collections.Generic.IEnumerator<BedrockSkinCardViewModel> enumerator = ((Collection<BedrockSkinCardViewModel>)(object)Skins).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				BedrockSkinCardViewModel current = enumerator.Current;
				BedrockSkinCardViewModel bedrockSkinCardViewModel = current;
				p1aif0fNieMbuxR5AlNF kind = current.Kind;
				bool isApplied;
				switch ((int)kind)
				{
				case 0:
				case 1:
					isApplied = string.Equals(current.Id, val.TwoDimensionalSkinId, (StringComparison)4);
					break;
				case 2:
					isApplied = string.Equals(current.Id, val.FourDimensionalSkinId, (StringComparison)4);
					break;
				case 3:
					isApplied = val.PartItemIds.Contains(current.Id);
					break;
				default:
					isApplied = false;
					break;
				}
				bedrockSkinCardViewModel.IsApplied = isApplied;
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateButtons()
	{
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		da18CdX55laNMRKtM3p0? service = _service;
		bool flag = ((service != null) ? service.CurrentSession : null) != null;
		bool flag2 = _loadCancellation == null;
		((Control)CatalogSelector).IsEnabled = flag && flag2;
		((Control)PartSlotSelector).IsEnabled = flag && flag2;
		((Control)SearchBox).IsEnabled = flag && flag2;
		((Control)LoadMoreButton).IsEnabled = flag && flag2;
		LFmY9Rfae1HtFQ0pDVND? preparedSkin = _preparedSkin;
		object obj = ((preparedSkin != null) ? preparedSkin.Skin.Id : null);
		if (obj == null)
		{
			NIF9GNfaOUIlucHK2qQs? preparedFourDimensionalAppearance = _preparedFourDimensionalAppearance;
			obj = ((preparedFourDimensionalAppearance != null) ? preparedFourDimensionalAppearance.Id : null);
		}
		string text = (string)obj;
		BedrockSkinCardViewModel bedrockSkinCardViewModel = ((Selector)SkinGrid).SelectedItem as BedrockSkinCardViewModel;
		TeW086XKeOM5MZhBfSt8 val = ResolveAppliedDisplayState();
		((Control)ApplyButton).IsEnabled = flag && text != null && _previewCancellation == null && _applyCancellation == null && (bedrockSkinCardViewModel == null || !bedrockSkinCardViewModel.IsApplied);
		NIF9GNfaOUIlucHK2qQs? preparedFourDimensionalAppearance2 = _preparedFourDimensionalAppearance;
		m4wFTFfpZW4pcAqQZC1k val2 = ((preparedFourDimensionalAppearance2 != null) ? preparedFourDimensionalAppearance2.Part : null);
		bool flag3 = val2 != null && val.PartSlots.Contains(val2.Slot);
		((Control)RemovePartButton).IsEnabled = flag && val2 != null && _applyCancellation == null && flag3;
		((Control)ResetSkinButton).IsEnabled = flag && val.CanResetToDefault;
	}

	[MethodImpl((MethodImplOptions)8)]
	private TeW086XKeOM5MZhBfSt8 ResolveAppliedDisplayState()
	{
		bool hasServerAppliedState = _hasServerAppliedState;
		string serverAppliedSkinId = _serverAppliedSkinId;
		IReadOnlySet<string> serverAppliedPartIds = _serverAppliedPartIds;
		IReadOnlySet<mWGKInfNzSRMjl3TLmeA> serverAppliedPartSlots = _serverAppliedPartSlots;
		da18CdX55laNMRKtM3p0? service = _service;
		AZci00fpEbV8HcEwinMT obj = ((service != null) ? service.SelectedFreeSkin : null);
		da18CdX55laNMRKtM3p0? service2 = _service;
		return y815qQXKTjo7lMVCIYBr.UjIXKMM9Xt3(hasServerAppliedState, serverAppliedSkinId, (global::System.Collections.Generic.IEnumerable<string>)serverAppliedPartIds, (global::System.Collections.Generic.IEnumerable<mWGKInfNzSRMjl3TLmeA>)serverAppliedPartSlots, obj, (service2 != null) ? service2.SelectedFourDimensionalAppearance : null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearServerAppliedStateCache()
	{
		_serverAppliedSkinId = string.Empty;
		_serverAppliedPartIds = (IReadOnlySet<string>)(object)new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		_serverAppliedPartSlots = (IReadOnlySet<mWGKInfNzSRMjl3TLmeA>)(object)new HashSet<mWGKInfNzSRMjl3TLmeA>();
		_hasServerAppliedState = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetPreviewState()
	{
		_preparedSkin = null;
		_preparedFourDimensionalAppearance = null;
		_fourDimensionalPreviewPayload = null;
		_resolvedFourDimensionalParts = global::System.Array.Empty<m4wFTFfpZW4pcAqQZC1k>();
		_fourDimensionalPreviewSummary = string.Empty;
		((Selector)SkinGrid).SelectedItem = null;
		FourDimensionalViewer.ClearAppearance();
		((UIElement)SkinViewer).Visibility = (Visibility)0;
		((UIElement)FourDimensionalViewer).Visibility = (Visibility)1;
		((UIElement)PreviewEmptyPanel).Visibility = (Visibility)0;
		PreviewTitle.Text = "2D 三维预览";
		PreviewName.Text = "未选择皮肤";
		PreviewDeveloper.Text = string.Empty;
		PreviewSummary.Text = string.Empty;
		SetAnimationNames(global::System.Array.Empty<string>());
		((ContentControl)ApplyButton).Content = "应用皮肤";
		((UIElement)RemovePartButton).Visibility = (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelRequests()
	{
		CancellationTokenSource? loadCancellation = _loadCancellation;
		if (loadCancellation != null)
		{
			loadCancellation.Cancel();
		}
		CancellationTokenSource? loadCancellation2 = _loadCancellation;
		if (loadCancellation2 != null)
		{
			loadCancellation2.Dispose();
		}
		_loadCancellation = null;
		CancellationTokenSource? previewCancellation = _previewCancellation;
		if (previewCancellation != null)
		{
			previewCancellation.Cancel();
		}
		CancellationTokenSource? previewCancellation2 = _previewCancellation;
		if (previewCancellation2 != null)
		{
			previewCancellation2.Dispose();
		}
		_previewCancellation = null;
		CancellationTokenSource? applyCancellation = _applyCancellation;
		if (applyCancellation != null)
		{
			applyCancellation.Cancel();
		}
		CancellationTokenSource? applyCancellation2 = _applyCancellation;
		if (applyCancellation2 != null)
		{
			applyCancellation2.Dispose();
		}
		_applyCancellation = null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetCatalogName(p1aif0fNieMbuxR5AlNF catalog)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		return (int)catalog switch
		{
			0 => "免费 2D 皮肤", 
			1 => "账户已有 2D 皮肤", 
			2 => "账户已有 4D 皮肤", 
			3 => "账户已有 4D 拆件", 
			_ => "皮肤", 
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowAppearanceAppliedSuccess(string message)
	{
		__c__DisplayClass64_0 __8_locals3 = (__c__DisplayClass64_0)new __c__DisplayClass64_0();
		da18CdX55laNMRKtM3p0? service = _service;
		object userId;
		if (service == null)
		{
			userId = null;
		}
		else
		{
			c7lEmkf1MoB1jUf1XEF1 currentSession = service.CurrentSession;
			userId = ((currentSession != null) ? currentSession.UserId : null);
		}
		__8_locals3.userId = (string)userId;
		AppShell.Success((!string.IsNullOrWhiteSpace(__8_locals3.userId) && Enumerable.Any<zG6ueUfuQUk6CEmxLYji>((global::System.Collections.Generic.IEnumerable<zG6ueUfuQUk6CEmxLYji>)_service.fqaX64xovpi(), (Func<zG6ueUfuQUk6CEmxLYji, bool>)([MethodImpl((MethodImplOptions)8)] (zG6ueUfuQUk6CEmxLYji instance) => (int)instance.Kind == 0 && string.Equals(instance.AccountId, __8_locals3.userId, (StringComparison)4)))) ? (message + "；已有游戏正在运行，请重新进入服务器以确保其他玩家同步看到新装扮") : message);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatSlotFailures(global::System.Collections.Generic.IReadOnlyList<l6vC8LfMXvCYSRCp4C3a> failures)
	{
		return string.Join("；", Enumerable.Select<l6vC8LfMXvCYSRCp4C3a, string>((global::System.Collections.Generic.IEnumerable<l6vC8LfMXvCYSRCp4C3a>)failures, (Func<l6vC8LfMXvCYSRCp4C3a, string>)([MethodImpl((MethodImplOptions)8)] (l6vC8LfMXvCYSRCp4C3a failure) => GetSlotName(failure.Slot) + failure.CategoryName)));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetSlotName(mWGKInfNzSRMjl3TLmeA slot)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected I4, but got Unknown
		return (slot - 16) switch
		{
			0 => "头饰", 
			(v1AhFSfMblmp1q5wGqxg.mWGKInfNzSRMjl3TLmeA)1 => "头部", 
			(v1AhFSfMblmp1q5wGqxg.mWGKInfNzSRMjl3TLmeA)2 => "上装", 
			(v1AhFSfMblmp1q5wGqxg.mWGKInfNzSRMjl3TLmeA)3 => "下装", 
			(v1AhFSfMblmp1q5wGqxg.mWGKInfNzSRMjl3TLmeA)4 => "背饰", 
			(v1AhFSfMblmp1q5wGqxg.mWGKInfNzSRMjl3TLmeA)5 => "周身", 
			(v1AhFSfMblmp1q5wGqxg.mWGKInfNzSRMjl3TLmeA)6 => "挂饰", 
			_ => $"槽位 {(int)slot}", 
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetEmptyTitle(p1aif0fNieMbuxR5AlNF catalog, bool allPartSlots)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		return (int)catalog switch
		{
			0 => "暂无免费 2D 皮肤", 
			1 => "账户中暂无 2D 皮肤", 
			2 => "账户中暂无 4D 皮肤", 
			3 => allPartSlots ? "账户中暂无 4D 拆件" : "该槽位暂无 4D 拆件", 
			_ => "暂无皮肤", 
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetEmptyDescription(p1aif0fNieMbuxR5AlNF catalog, bool allPartSlots)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		return (int)catalog switch
		{
			0 => "可以稍后刷新目录后重试", 
			1 => "已购买或领取的普通皮肤会显示在这里", 
			2 => "账户拥有的 4D 整皮会显示在这里", 
			3 => allPartSlots ? "账户已有的七类 4D 拆件会统一显示在这里" : "切换全部或其他槽位继续查看", 
			_ => "可以稍后刷新目录后重试", 
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
			CancelRequests();
			FourDimensionalViewer.AnimationNamesChanged -= FourDimensionalViewer_AnimationNamesChanged;
			FourDimensionalViewer.PreviewWarningsChanged -= FourDimensionalViewer_PreviewWarningsChanged;
			SkinViewer.Dispose();
			FourDimensionalViewer.Dispose();
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockSkinBrowser.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ResponsiveRoot = CastExtensions.As<Grid>(target);
			((FrameworkElement)ResponsiveRoot).SizeChanged += new SizeChangedEventHandler(ResponsiveRoot_SizeChanged);
			break;
		case 3:
			CatalogColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 4:
			PreviewColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 5:
			CompactPreviewRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 6:
			PreviewPanel = CastExtensions.As<Border>(target);
			break;
		case 7:
			ApplyButton = CastExtensions.As<Button>(target);
			((ButtonBase)ApplyButton).Click += new RoutedEventHandler(ApplyButton_Click);
			break;
		case 8:
			RemovePartButton = CastExtensions.As<Button>(target);
			((ButtonBase)RemovePartButton).Click += new RoutedEventHandler(RemovePartButton_Click);
			break;
		case 9:
			ResetSkinButton = CastExtensions.As<Button>(target);
			((ButtonBase)ResetSkinButton).Click += new RoutedEventHandler(ResetSkinButton_Click);
			break;
		case 10:
			PreviewName = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			PreviewDeveloper = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			PreviewSummary = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			SkinViewer = CastExtensions.As<BedrockSkinViewer>(target);
			break;
		case 14:
			FourDimensionalViewer = CastExtensions.As<BedrockFourDimensionalViewer>(target);
			break;
		case 15:
			PreviewEmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 16:
			AutoRotateButton = CastExtensions.As<ToggleButton>(target);
			((ButtonBase)AutoRotateButton).Click += new RoutedEventHandler(AutoRotateButton_Click);
			break;
		case 17:
			AnimationButton = CastExtensions.As<ToggleButton>(target);
			((ButtonBase)AnimationButton).Click += new RoutedEventHandler(AnimationButton_Click);
			break;
		case 18:
			ParticleButton = CastExtensions.As<ToggleButton>(target);
			((ButtonBase)ParticleButton).Click += new RoutedEventHandler(ParticleButton_Click);
			break;
		case 19:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ResetViewButton_Click);
			break;
		case 20:
			PreviewTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 21:
			AnimationSelector = CastExtensions.As<ComboBox>(target);
			((Selector)AnimationSelector).SelectionChanged += new SelectionChangedEventHandler(AnimationSelector_SelectionChanged);
			break;
		case 22:
			SkinGrid = CastExtensions.As<GridView>(target);
			((ListViewBase)SkinGrid).ItemClick += new ItemClickEventHandler(SkinGrid_ItemClick);
			((Selector)SkinGrid).SelectionChanged += new SelectionChangedEventHandler(SkinGrid_SelectionChanged);
			break;
		case 23:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 24:
			LoadMoreButton = CastExtensions.As<Button>(target);
			((ButtonBase)LoadMoreButton).Click += new RoutedEventHandler(LoadMoreButton_Click);
			break;
		case 25:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 26:
			EmptyDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 35:
			PartSlotSelector = CastExtensions.As<ComboBox>(target);
			((Selector)PartSlotSelector).SelectionChanged += new SelectionChangedEventHandler(PartSlotSelector_SelectionChanged);
			break;
		case 36:
			CatalogSelector = CastExtensions.As<SelectorBar>(target);
			CatalogSelector.SelectionChanged += CatalogSelector_SelectionChanged;
			break;
		case 37:
			SearchBox = CastExtensions.As<AutoSuggestBox>(target);
			SearchBox.QuerySubmitted += SearchBox_QuerySubmitted;
			SearchBox.TextChanged += SearchBox_TextChanged;
			break;
		case 38:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
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
			UserControl val2 = (UserControl)target;
			BedrockSkinBrowser_obj1_Bindings bedrockSkinBrowser_obj1_Bindings = (BedrockSkinBrowser_obj1_Bindings)new BedrockSkinBrowser_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockSkinBrowser_obj1_Bindings;
			bedrockSkinBrowser_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockSkinBrowser_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockSkinBrowser_obj1_Bindings.Loading;
			break;
		}
		case 28:
		{
			Grid val = (Grid)target;
			BedrockSkinBrowser_obj28_Bindings bedrockSkinBrowser_obj28_Bindings = (BedrockSkinBrowser_obj28_Bindings)new BedrockSkinBrowser_obj28_Bindings();
			result = (IComponentConnector)(object)bedrockSkinBrowser_obj28_Bindings;
			bedrockSkinBrowser_obj28_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockSkinBrowser_obj28_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockSkinBrowser_obj28_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockSkinBrowser_obj28_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

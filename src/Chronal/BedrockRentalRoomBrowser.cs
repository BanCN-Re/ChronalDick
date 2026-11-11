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
using GCwkjSf1L5l3Ynhk7uPu;
using Hc3wD2fa2BedOc5HQmXr;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using WlF3LVf1krxInGwqCRLt;
using bUfedyCg1PBqhqIkB8r;
using c21CjIfaGPDKMKsUKgMv;
using fZGimHf0suVRPkaXFQcr;
using g7NT9YfavIqAmX2G0j61;
using qS8vkpL43FlTMgcj0rgs;
using yun8CRfanLkaBpPLfVrd;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
public sealed class BedrockRentalRoomBrowser : UserControl, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockRentalRoomBrowser_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockRentalRoomBrowser_BindingsScopeConnector
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

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	private class BedrockRentalRoomBrowser_obj26_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockRentalRoomBrowser_Bindings
	{
		private BedrockRentalRoomCardViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj26;

		private TextBlock obj27;

		private TextBlock obj28;

		private TextBlock obj29;

		private TextBlock obj30;

		private TextBlock obj31;

		private BedrockNetworkImage obj32;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockRentalRoomBrowser_obj26_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 26:
				obj26 = new WeakReference((object)CastExtensions.As<Grid>(target));
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
				obj32 = CastExtensions.As<BedrockNetworkImage>(target);
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
			object target = obj26.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BedrockRentalRoomCardViewModel>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<BedrockRentalRoomCardViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockRentalRoomCardViewModel obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Name(obj.Name, phase);
				Update_SummaryText(obj.SummaryText, phase);
				Update_PlayerText(obj.PlayerText, phase);
				Update_PasswordShortText(obj.PasswordShortText, phase);
				Update_LevelShortText(obj.LevelShortText, phase);
				Update_CoverUrl(obj.CoverUrl, phase);
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
		private void Update_SummaryText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj28, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PlayerText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj29, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PasswordShortText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj30, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_LevelShortText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj31, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CoverUrl(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(obj32, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class BedrockRentalRoomBrowser_obj1_Bindings : IComponentConnector, IBedrockRentalRoomBrowser_Bindings
	{
		private BedrockRentalRoomBrowser dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private GridView obj22;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockRentalRoomBrowser_obj1_Bindings()
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
				dataRoot = CastExtensions.As<BedrockRentalRoomBrowser>(newDataRoot);
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
		private void Update_(BedrockRentalRoomBrowser obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -2147483647) != 0)
			{
				Update_Rooms(obj.Rooms, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Rooms(ObservableCollection<BedrockRentalRoomCardViewModel> obj, int phase)
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
	private sealed class __c_8
	{
		public static readonly __c_8 __9;

		public static Func<DAoPoufaie63jNVdbNug, string> __9__34_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_8()
		{
			__9 = (__c_8)new __c_8();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_8()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _AppendUnique_b__34_0(DAoPoufaie63jNVdbNug room)
		{
			return room.EntityId;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass35_0
	{
		public string selectedId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass35_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ApplyFilters_b__0(BedrockRentalRoomCardViewModel item)
		{
			return string.Equals(item.Room.EntityId, selectedId, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadCatalogAsync_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockRentalRoomBrowser __4__this;

		public bool reset;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter<QahyWHf1foo36eJeXRAV> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockRentalRoomBrowser bedrockRentalRoomBrowser = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0092;
				}
				if (!bedrockRentalRoomBrowser._disposed)
				{
					da18CdX55laNMRKtM3p0? service = bedrockRentalRoomBrowser._service;
					if (((service != null) ? service.CurrentSession : null) != null)
					{
						if (reset)
						{
							bedrockRentalRoomBrowser._catalog.Clear();
							bedrockRentalRoomBrowser._nextOffset = 0;
							bedrockRentalRoomBrowser._hasMore = false;
							bedrockRentalRoomBrowser._searchMode = false;
							bedrockRentalRoomBrowser._searchQuery = string.Empty;
						}
						_cancellation_5__2 = bedrockRentalRoomBrowser.BeginLoad();
						goto IL_0092;
					}
					bedrockRentalRoomBrowser.Clear();
				}
				goto end_IL_0011;
				IL_0092:
				try
				{
					if (num != 0)
					{
						bedrockRentalRoomBrowser.StatusText.Text = (reset ? "正在同步租赁房目录" : "正在加载更多租赁房");
					}
					try
					{
						TaskAwaiter<QahyWHf1foo36eJeXRAV> _u__ = default;
						if (num != 0)
						{
							_u__ = bedrockRentalRoomBrowser._service.WeiX6dyaaf6(bedrockRentalRoomBrowser._nextOffset, bedrockRentalRoomBrowser.SelectedSort, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QahyWHf1foo36eJeXRAV>, _LoadCatalogAsync_d__30>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<QahyWHf1foo36eJeXRAV>);
							num = (__1__state = -1);
						}
						QahyWHf1foo36eJeXRAV result = _u__.GetResult();
						if (!_cancellation_5__2.IsCancellationRequested)
						{
							bedrockRentalRoomBrowser.AppendUnique((global::System.Collections.Generic.IEnumerable<DAoPoufaie63jNVdbNug>)result.Rooms);
							bedrockRentalRoomBrowser._nextOffset = result.NextOffset;
							bedrockRentalRoomBrowser._hasMore = result.HasMore;
							bedrockRentalRoomBrowser.ApplyFilters();
							bedrockRentalRoomBrowser.StatusText.Text = (result.Total.HasValue ? $"已加载 {bedrockRentalRoomBrowser._catalog.Count} / {result.Total.Value} 个租赁房" : $"已加载 {bedrockRentalRoomBrowser._catalog.Count} 个租赁房");
						}
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "LoadCatalogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockRentalRoomBrowser.xaml.cs", 129);
						bedrockRentalRoomBrowser.ShowLoadFailure(ex2);
					}
					finally
					{
						if (num < 0)
						{
							bedrockRentalRoomBrowser.EndLoad(_cancellation_5__2);
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
	private struct _SearchAsync_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockRentalRoomBrowser __4__this;

		public string query;

		private string _normalized_5__2;

		private CancellationTokenSource _cancellation_5__3;

		private TaskAwaiter __u__1;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<DAoPoufaie63jNVdbNug>> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockRentalRoomBrowser bedrockRentalRoomBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00be;
				}
				if (num == 1)
				{
					goto IL_00f1;
				}
				da18CdX55laNMRKtM3p0? service = bedrockRentalRoomBrowser._service;
				if (((service != null) ? service.CurrentSession : null) != null)
				{
					_normalized_5__2 = query.Trim();
					if (_normalized_5__2.Length == 0)
					{
						_u__ = bedrockRentalRoomBrowser.LoadAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchAsync_d__31>(ref _u__, ref this);
							return;
						}
						goto IL_00be;
					}
					bedrockRentalRoomBrowser._searchMode = true;
					bedrockRentalRoomBrowser._searchQuery = _normalized_5__2;
					bedrockRentalRoomBrowser._hasMore = false;
					_cancellation_5__3 = bedrockRentalRoomBrowser.BeginLoad();
					goto IL_00f1;
				}
				bedrockRentalRoomBrowser.Clear();
				goto end_IL_0011;
				IL_00f1:
				try
				{
					if (num != 1)
					{
						bedrockRentalRoomBrowser.StatusText.Text = "正在搜索“" + _normalized_5__2 + "”";
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<DAoPoufaie63jNVdbNug>> _u__2;
						if (num != 1)
						{
							_u__2 = bedrockRentalRoomBrowser._service.DVeX6KNOgCf(_normalized_5__2, bedrockRentalRoomBrowser.SelectedSort, _cancellation_5__3.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<DAoPoufaie63jNVdbNug>>, _SearchAsync_d__31>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<DAoPoufaie63jNVdbNug>>);
							num = (__1__state = -1);
						}
						global::System.Collections.Generic.IReadOnlyList<DAoPoufaie63jNVdbNug> result = _u__2.GetResult();
						if (!_cancellation_5__3.IsCancellationRequested)
						{
							bedrockRentalRoomBrowser._catalog.Clear();
							bedrockRentalRoomBrowser.AppendUnique((global::System.Collections.Generic.IEnumerable<DAoPoufaie63jNVdbNug>)result);
							bedrockRentalRoomBrowser.ApplyFilters();
							bedrockRentalRoomBrowser.StatusText.Text = $"搜索“{_normalized_5__2}” · 共 {bedrockRentalRoomBrowser._catalog.Count} 个结果";
						}
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "SearchAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockRentalRoomBrowser.xaml.cs", 177);
						bedrockRentalRoomBrowser.ShowLoadFailure(ex2);
					}
					finally
					{
						if (num < 0)
						{
							bedrockRentalRoomBrowser.EndLoad(_cancellation_5__3);
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
				goto end_IL_0011;
				IL_00be:
				_u__.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_normalized_5__2 = null;
				_cancellation_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_normalized_5__2 = null;
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

	private const double WideLayoutThreshold = 1000.0;

	private readonly List<DAoPoufaie63jNVdbNug> _catalog;

	private da18CdX55laNMRKtM3p0? _service;

	private CancellationTokenSource? _loadCancellation;

	private bool _searchMode;

	private string _searchQuery;

	private int _nextOffset;

	private bool _hasMore;

	private bool _loading;

	private bool _operationRunning;

	private bool _relayRunning;

	private bool _disposed;

	[CompilerGenerated]
	private EventHandler<DAoPoufaie63jNVdbNug>? m_LaunchRequested;

	[CompilerGenerated]
	private EventHandler<DAoPoufaie63jNVdbNug>? m_RelayLaunchRequested;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ResponsiveRoot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition CatalogColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition DetailColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition CompactDetailRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border DetailPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RelayLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RelayStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox RelayProtocolCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch RelayLanToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailPlayers;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailPopularity;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailLevel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailPassword;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailStatus;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailName;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailRoomNumber;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailVersion;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockNetworkImage DetailCover;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LoadMoreButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private GridView RoomGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AutoSuggestBox SearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox SortCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox PasswordCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox LevelCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockRentalRoomBrowser_Bindings Bindings;

	private ObservableCollection<BedrockRentalRoomCardViewModel> _Rooms_k__BackingField;
	[field: CompilerGenerated]
	public ObservableCollection<BedrockRentalRoomCardViewModel> Rooms
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public mpVm6bf0F2Qxo2jn2O2u RelayBindScope
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (RelayLanToggle.IsOn)
			{
				return (mpVm6bf0F2Qxo2jn2O2u)1;
			}
			return (mpVm6bf0F2Qxo2jn2O2u)0;
		}
	}

	public int RelayFrontendProtocol
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			object selectedItem = ((Selector)RelayProtocolCombo).SelectedItem;
			object obj = ((selectedItem is ComboBoxItem) ? selectedItem : null);
			int result = default(int);
			if (!(((obj != null) ? ((FrameworkElement)obj).Tag : null) is string text) || !int.TryParse(text, out result))
			{
				return 844;
			}
			return result;
		}
	}

	private VfD7YQfa3rrq4kCVhnHx SelectedSort
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (VfD7YQfa3rrq4kCVhnHx)ReadSelectedTag(SortCombo);
		}
	}

	private BCm72DfaEvUuy6vZwloY SelectedPasswordFilter
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (BCm72DfaEvUuy6vZwloY)ReadSelectedTag(PasswordCombo);
		}
	}

	private cfZuAyfaqko9nE8Uk8mf SelectedLevelFilter
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (cfZuAyfaqko9nE8Uk8mf)ReadSelectedTag(LevelCombo);
		}
	}

	public EventHandler<DAoPoufaie63jNVdbNug>? LaunchRequested;

	public EventHandler<DAoPoufaie63jNVdbNug>? RelayLaunchRequested;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockRentalRoomBrowser()
	{
		_catalog = new List<DAoPoufaie63jNVdbNug>();
		_searchQuery = string.Empty;
		_Rooms_k__BackingField = new ObservableCollection<BedrockRentalRoomCardViewModel>();
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Attach(da18CdX55laNMRKtM3p0 service)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		ObjectDisposedException.ThrowIf(_disposed, (object)this);
		_service = service ?? throw new ArgumentNullException("service");
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetOperationRunning(bool running)
	{
		_operationRunning = running;
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		CancellationTokenSource? loadCancellation = _loadCancellation;
		if (loadCancellation != null)
		{
			loadCancellation.Cancel();
		}
		_catalog.Clear();
		((Collection<BedrockRentalRoomCardViewModel>)(object)Rooms).Clear();
		((Selector)RoomGrid).SelectedItem = null;
		_nextOffset = 0;
		_hasMore = false;
		_searchMode = false;
		_searchQuery = string.Empty;
		StatusText.Text = "请先建立游戏会话";
		EmptyTitle.Text = "请先建立游戏会话";
		((UIElement)EmptyPanel).Visibility = (Visibility)0;
		ShowSelection(null);
		RelayStatusText.Text = "代理未启动";
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task LoadAsync()
	{
		return LoadCatalogAsync(reset: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadCatalogAsync(bool reset)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadCatalogAsync_d__30 loadCatalogAsync_d__ = default(_LoadCatalogAsync_d__30);
		loadCatalogAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadCatalogAsync_d__.__4__this = this;
		loadCatalogAsync_d__.reset = reset;
		loadCatalogAsync_d__.__1__state = -1;
		loadCatalogAsync_d__.__t__builder.Start<_LoadCatalogAsync_d__30>(ref loadCatalogAsync_d__);
		return loadCatalogAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SearchAsync(string query)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchAsync_d__31 searchAsync_d__ = default(_SearchAsync_d__31);
		searchAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		searchAsync_d__.__4__this = this;
		searchAsync_d__.query = query;
		searchAsync_d__.__1__state = -1;
		searchAsync_d__.__t__builder.Start<_SearchAsync_d__31>(ref searchAsync_d__);
		return searchAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private CancellationTokenSource BeginLoad()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
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
		CancellationTokenSource result = (_loadCancellation = new CancellationTokenSource());
		_loading = true;
		UpdateButtons();
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void EndLoad(CancellationTokenSource cancellation)
	{
		if (_loadCancellation == cancellation)
		{
			_loadCancellation = null;
			_loading = false;
		}
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AppendUnique(global::System.Collections.Generic.IEnumerable<DAoPoufaie63jNVdbNug> rooms)
	{
		HashSet<string> val = new HashSet<string>(Enumerable.Select<DAoPoufaie63jNVdbNug, string>((global::System.Collections.Generic.IEnumerable<DAoPoufaie63jNVdbNug>)_catalog, (Func<DAoPoufaie63jNVdbNug, string>)([MethodImpl((MethodImplOptions)8)] (DAoPoufaie63jNVdbNug room) => room.EntityId)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		global::System.Collections.Generic.IEnumerator<DAoPoufaie63jNVdbNug> enumerator = rooms.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DAoPoufaie63jNVdbNug current = enumerator.Current;
				if (val.Add(current.EntityId))
				{
					_catalog.Add(current);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyFilters()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass35_0 __8_locals2 = (__c__DisplayClass35_0)new __c__DisplayClass35_0();
		BedrockRentalRoomCardViewModel obj = ((Selector)RoomGrid).SelectedItem as BedrockRentalRoomCardViewModel;
		__8_locals2.selectedId = ((obj != null) ? obj.Room.EntityId : null);
		global::System.Collections.Generic.IReadOnlyList<DAoPoufaie63jNVdbNug> readOnlyList = mlck9xf1DW0OXgLuKE8t.BVqf1Vm5401((global::System.Collections.Generic.IEnumerable<DAoPoufaie63jNVdbNug>)_catalog, SelectedPasswordFilter, SelectedLevelFilter);
		((Collection<BedrockRentalRoomCardViewModel>)(object)Rooms).Clear();
		global::System.Collections.Generic.IEnumerator<DAoPoufaie63jNVdbNug> enumerator = ((global::System.Collections.Generic.IEnumerable<DAoPoufaie63jNVdbNug>)readOnlyList).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DAoPoufaie63jNVdbNug current = enumerator.Current;
				((Collection<BedrockRentalRoomCardViewModel>)(object)Rooms).Add((BedrockRentalRoomCardViewModel)new BedrockRentalRoomCardViewModel(current));
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		((UIElement)EmptyPanel).Visibility = (((((Collection<BedrockRentalRoomCardViewModel>)(object)Rooms).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		EmptyTitle.Text = ((((Collection<BedrockRentalRoomCardViewModel>)(object)Rooms).Count != 0) ? string.Empty : (_searchMode ? "没有匹配的租赁房" : "没有符合筛选的租赁房"));
		BedrockRentalRoomCardViewModel bedrockRentalRoomCardViewModel = Enumerable.FirstOrDefault<BedrockRentalRoomCardViewModel>((global::System.Collections.Generic.IEnumerable<BedrockRentalRoomCardViewModel>)Rooms, (Func<BedrockRentalRoomCardViewModel, bool>)([MethodImpl((MethodImplOptions)8)] (BedrockRentalRoomCardViewModel item) => string.Equals(item.Room.EntityId, __8_locals2.selectedId, (StringComparison)5)));
		((Selector)RoomGrid).SelectedItem = bedrockRentalRoomCardViewModel ?? Enumerable.FirstOrDefault<BedrockRentalRoomCardViewModel>((global::System.Collections.Generic.IEnumerable<BedrockRentalRoomCardViewModel>)Rooms);
		ShowSelection(((Selector)RoomGrid).SelectedItem as BedrockRentalRoomCardViewModel);
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowLoadFailure(global::System.Exception exception)
	{
		string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "ShowLoadFailure", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockRentalRoomBrowser.xaml.cs", 248);
		da18CdX55laNMRKtM3p0? service = _service;
		if (((service != null) ? service.CurrentSession : null) == null)
		{
			Clear();
			AppShell.Error(exceptionDisplayMessage);
			return;
		}
		StatusText.Text = exceptionDisplayMessage;
		((UIElement)EmptyPanel).Visibility = (((((Collection<BedrockRentalRoomCardViewModel>)(object)Rooms).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		EmptyTitle.Text = "租赁房目录加载失败";
		AppShell.Error(exceptionDisplayMessage);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		SearchBox.Text = string.Empty;
		LoadAsync();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LoadMoreButton_Click(object sender, RoutedEventArgs e)
	{
		LoadCatalogAsync(reset: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
	{
		SearchAsync(args.QueryText ?? string.Empty);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SortCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (_service != null && !_loading)
		{
			if (!_searchMode || _searchQuery.Length <= 0)
			{
				LoadAsync();
			}
			else
			{
				SearchAsync(_searchQuery);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void FilterCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (_service != null)
		{
			ApplyFilters();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RoomGrid_ItemClick(object sender, ItemClickEventArgs e)
	{
		if (e.ClickedItem is BedrockRentalRoomCardViewModel selectedItem)
		{
			((Selector)RoomGrid).SelectedItem = selectedItem;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RoomGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		ShowSelection(((Selector)RoomGrid).SelectedItem as BedrockRentalRoomCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowSelection(BedrockRentalRoomCardViewModel? item)
	{
		DetailCover.ImageUrl = item?.CoverUrl ?? string.Empty;
		DetailName.Text = item?.Name ?? "选择一个租赁房";
		DetailRoomNumber.Text = item?.RoomNumberText ?? "从目录中选择租赁房";
		DetailPlayers.Text = ((item == null) ? string.Empty : ("在线人数：" + item.PlayerText));
		DetailPopularity.Text = item?.PopularityText ?? string.Empty;
		DetailLevel.Text = item?.LevelText ?? string.Empty;
		DetailPassword.Text = item?.PasswordText ?? string.Empty;
		DetailStatus.Text = item?.StatusText ?? string.Empty;
		DetailVersion.Text = item?.VersionText ?? "基岩移动端";
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LaunchButton_Click(object sender, RoutedEventArgs e)
	{
		if (((Selector)RoomGrid).SelectedItem is BedrockRentalRoomCardViewModel bedrockRentalRoomCardViewModel)
		{
			this.LaunchRequested?.Invoke((object)this, bedrockRentalRoomCardViewModel.Room);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RelayLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		if (((Selector)RoomGrid).SelectedItem is BedrockRentalRoomCardViewModel bedrockRentalRoomCardViewModel)
		{
			this.RelayLaunchRequested?.Invoke((object)this, bedrockRentalRoomCardViewModel.Room);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetRelayRunning(bool running)
	{
		_relayRunning = running;
		if (running)
		{
			RelayStatusText.Text = "正在启动代理";
		}
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetRelayStatus(string status)
	{
		RelayStatusText.Text = (string.IsNullOrWhiteSpace(status) ? "代理未启动" : status);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateButtons()
	{
		da18CdX55laNMRKtM3p0? service = _service;
		bool flag = ((service != null) ? service.CurrentSession : null) != null && !_operationRunning && !_loading;
		((Control)RefreshButton).IsEnabled = flag;
		((Control)SearchBox).IsEnabled = flag;
		((Control)SortCombo).IsEnabled = flag;
		((Control)PasswordCombo).IsEnabled = flag;
		((Control)LevelCombo).IsEnabled = flag;
		((Control)LaunchButton).IsEnabled = flag && ((Selector)RoomGrid).SelectedItem is BedrockRentalRoomCardViewModel;
		((Control)RelayLaunchButton).IsEnabled = ((Control)LaunchButton).IsEnabled && !_relayRunning;
		((Control)RelayProtocolCombo).IsEnabled = ((Control)LaunchButton).IsEnabled && !_relayRunning;
		((Control)RelayLanToggle).IsEnabled = ((Control)LaunchButton).IsEnabled && !_relayRunning;
		((Control)LoadMoreButton).IsEnabled = flag && _hasMore && !_searchMode;
		((UIElement)LoadMoreButton).Visibility = (((!_hasMore || _searchMode) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int ReadSelectedTag(ComboBox comboBox)
	{
		object selectedItem = ((Selector)comboBox).SelectedItem;
		ComboBoxItem val = (ComboBoxItem)((selectedItem is ComboBoxItem) ? selectedItem : null);
		int result = default(int);
		if (val == null || !(((FrameworkElement)val).Tag is string text) || !int.TryParse(text, out result))
		{
			return 0;
		}
		return result;
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
		DetailColumn.Width = (flag ? new GridLength(360.0) : new GridLength(0.0));
		CompactDetailRow.Height = (GridLength)(flag ? new GridLength(0.0) : GridLength.Auto);
		Grid.SetRow((FrameworkElement)(object)DetailPanel, (!flag) ? 2 : 0);
		Grid.SetRowSpan((FrameworkElement)(object)DetailPanel, (!flag) ? 1 : 2);
		Grid.SetColumn((FrameworkElement)(object)DetailPanel, flag ? 1 : 0);
		((FrameworkElement)DetailPanel).Margin = (flag ? new Thickness(0.0) : new Thickness(0.0, 16.0, 0.0, 0.0));
		((FrameworkElement)DetailPanel).MinHeight = ((!flag) ? 360 : 0);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
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
			_service = null;
			this.LaunchRequested = null;
			this.RelayLaunchRequested = null;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockRentalRoomBrowser.xaml");
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
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
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
			DetailColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 5:
			CompactDetailRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 6:
			DetailPanel = CastExtensions.As<Border>(target);
			break;
		case 7:
			LaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)LaunchButton).Click += new RoutedEventHandler(LaunchButton_Click);
			break;
		case 8:
			RelayLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)RelayLaunchButton).Click += new RoutedEventHandler(RelayLaunchButton_Click);
			break;
		case 9:
			RelayStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			RelayProtocolCombo = CastExtensions.As<ComboBox>(target);
			break;
		case 11:
			RelayLanToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 12:
			DetailPlayers = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			DetailPopularity = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			DetailLevel = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			DetailPassword = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			DetailStatus = CastExtensions.As<TextBlock>(target);
			break;
		case 17:
			DetailName = CastExtensions.As<TextBlock>(target);
			break;
		case 18:
			DetailRoomNumber = CastExtensions.As<TextBlock>(target);
			break;
		case 19:
			DetailVersion = CastExtensions.As<TextBlock>(target);
			break;
		case 20:
			DetailCover = CastExtensions.As<BedrockNetworkImage>(target);
			break;
		case 21:
			LoadMoreButton = CastExtensions.As<Button>(target);
			((ButtonBase)LoadMoreButton).Click += new RoutedEventHandler(LoadMoreButton_Click);
			break;
		case 22:
			RoomGrid = CastExtensions.As<GridView>(target);
			((ListViewBase)RoomGrid).ItemClick += new ItemClickEventHandler(RoomGrid_ItemClick);
			((Selector)RoomGrid).SelectionChanged += new SelectionChangedEventHandler(RoomGrid_SelectionChanged);
			break;
		case 23:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 24:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 33:
			SearchBox = CastExtensions.As<AutoSuggestBox>(target);
			SearchBox.QuerySubmitted += SearchBox_QuerySubmitted;
			break;
		case 34:
			SortCombo = CastExtensions.As<ComboBox>(target);
			((Selector)SortCombo).SelectionChanged += new SelectionChangedEventHandler(SortCombo_SelectionChanged);
			break;
		case 35:
			PasswordCombo = CastExtensions.As<ComboBox>(target);
			((Selector)PasswordCombo).SelectionChanged += new SelectionChangedEventHandler(FilterCombo_SelectionChanged);
			break;
		case 36:
			LevelCombo = CastExtensions.As<ComboBox>(target);
			((Selector)LevelCombo).SelectionChanged += new SelectionChangedEventHandler(FilterCombo_SelectionChanged);
			break;
		case 37:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
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
			BedrockRentalRoomBrowser_obj1_Bindings bedrockRentalRoomBrowser_obj1_Bindings = (BedrockRentalRoomBrowser_obj1_Bindings)new BedrockRentalRoomBrowser_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockRentalRoomBrowser_obj1_Bindings;
			bedrockRentalRoomBrowser_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockRentalRoomBrowser_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockRentalRoomBrowser_obj1_Bindings.Loading;
			break;
		}
		case 26:
		{
			Grid val = (Grid)target;
			BedrockRentalRoomBrowser_obj26_Bindings bedrockRentalRoomBrowser_obj26_Bindings = (BedrockRentalRoomBrowser_obj26_Bindings)new BedrockRentalRoomBrowser_obj26_Bindings();
			result = (IComponentConnector)(object)bedrockRentalRoomBrowser_obj26_Bindings;
			bedrockRentalRoomBrowser_obj26_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockRentalRoomBrowser_obj26_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockRentalRoomBrowser_obj26_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockRentalRoomBrowser_obj26_Bindings);
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

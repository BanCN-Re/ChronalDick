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
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using akZfq1faY32TToCyfXZV;
using bP1knHfaZRN10coBj77w;
using qS8vkpL43FlTMgcj0rgs;
using zCVMnbfabiR2jSY2xUjH;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
public sealed class BedrockLocalLobbyBrowser : UserControl, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockLocalLobbyBrowser_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockLocalLobbyBrowser_BindingsScopeConnector
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

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class BedrockLocalLobbyBrowser_obj21_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockLocalLobbyBrowser_Bindings
	{
		private BedrockLocalLobbyRoomCardViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj21;

		private TextBlock obj22;

		private TextBlock obj23;

		private TextBlock obj24;

		private TextBlock obj25;

		private TextBlock obj26;

		private BedrockNetworkImage obj27;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockLocalLobbyBrowser_obj21_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 21:
				obj21 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 22:
				obj22 = CastExtensions.As<TextBlock>(target);
				break;
			case 23:
				obj23 = CastExtensions.As<TextBlock>(target);
				break;
			case 24:
				obj24 = CastExtensions.As<TextBlock>(target);
				break;
			case 25:
				obj25 = CastExtensions.As<TextBlock>(target);
				break;
			case 26:
				obj26 = CastExtensions.As<TextBlock>(target);
				break;
			case 27:
				obj27 = CastExtensions.As<BedrockNetworkImage>(target);
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
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BedrockLocalLobbyRoomCardViewModel>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<BedrockLocalLobbyRoomCardViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockLocalLobbyRoomCardViewModel obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Name(obj.Name, phase);
				Update_Description(obj.Description, phase);
				Update_CategoryText(obj.CategoryText, phase);
				Update_PlayerText(obj.PlayerText, phase);
				Update_VersionText(obj.VersionText, phase);
				Update_CoverUrl(obj.CoverUrl, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Description(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj23, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CategoryText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj24, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PlayerText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj25, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_VersionText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj26, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CoverUrl(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(obj27, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	private class BedrockLocalLobbyBrowser_obj1_Bindings : IComponentConnector, IBedrockLocalLobbyBrowser_Bindings
	{
		private BedrockLocalLobbyBrowser dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private GridView obj17;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockLocalLobbyBrowser_obj1_Bindings()
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
				dataRoot = CastExtensions.As<BedrockLocalLobbyBrowser>(newDataRoot);
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
		private void Update_(BedrockLocalLobbyBrowser obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -2147483647) != 0)
			{
				Update_Rooms(obj.Rooms, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Rooms(ObservableCollection<BedrockLocalLobbyRoomCardViewModel> obj, int phase)
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

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_7
	{
		public static readonly __c_7 __9;

		public static Func<BedrockLocalLobbyRoomCardViewModel, string> __9__21_1;

		public static Func<BedrockLocalLobbyRoomCardViewModel, string> __9__21_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_7()
		{
			__9 = (__c_7)new __c_7();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_7()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _LoadRoomsAsync_b__21_1(BedrockLocalLobbyRoomCardViewModel item)
		{
			return item.Room.RoomId;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _LoadRoomsAsync_b__21_0(BedrockLocalLobbyRoomCardViewModel item)
		{
			return item.Room.RoomId;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CategoryButton_Click_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockLocalLobbyBrowser __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockLocalLobbyBrowser bedrockLocalLobbyBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00e4;
				}
				if (!bedrockLocalLobbyBrowser._operationRunning)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					int categoryId = default(int);
					if (val != null && ((FrameworkElement)val).Tag is string text && int.TryParse(text, out categoryId))
					{
						bedrockLocalLobbyBrowser._categoryId = categoryId;
						bedrockLocalLobbyBrowser._searchMode = false;
						bedrockLocalLobbyBrowser._searchQuery = string.Empty;
						bedrockLocalLobbyBrowser.SearchBox.Text = string.Empty;
						bedrockLocalLobbyBrowser.UpdateCategoryVisuals();
						_u__ = bedrockLocalLobbyBrowser.LoadAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CategoryButton_Click_d__26>(ref _u__, ref this);
							return;
						}
						goto IL_00e4;
					}
				}
				goto end_IL_0011;
				IL_00e4:
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
	private struct _LoadMoreButton_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockLocalLobbyBrowser __4__this;

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
			BedrockLocalLobbyBrowser bedrockLocalLobbyBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockLocalLobbyBrowser.LoadRoomsAsync(reset: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadMoreButton_Click_d__23>(ref _u__, ref this);
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
	private struct _LoadRoomsAsync_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockLocalLobbyBrowser __4__this;

		public bool reset;

		private CancellationTokenSource _cancellation_5__2;

		private bool _searchMode_5__3;

		private string _query_5__4;

		private vfa5PsfaVtd3I1U6CeBJ _page_5__5;

		private ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<cwSYjVfuzDOvn8hKeZih>>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<vfa5PsfaVtd3I1U6CeBJ>.ConfiguredTaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockLocalLobbyBrowser bedrockLocalLobbyBrowser = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_00af;
				}
				if (!bedrockLocalLobbyBrowser._disposed)
				{
					da18CdX55laNMRKtM3p0? service = bedrockLocalLobbyBrowser._service;
					if (((service != null) ? service.CurrentSession : null) == null)
					{
						bedrockLocalLobbyBrowser.Clear();
					}
					else if (reset || (bedrockLocalLobbyBrowser._loadCancellation == null && bedrockLocalLobbyBrowser._hasMore && !bedrockLocalLobbyBrowser._searchMode && !bedrockLocalLobbyBrowser._operationRunning))
					{
						CancellationTokenSource? loadCancellation = bedrockLocalLobbyBrowser._loadCancellation;
						if (loadCancellation != null)
						{
							loadCancellation.Cancel();
						}
						_cancellation_5__2 = new CancellationTokenSource();
						goto IL_00af;
					}
				}
				goto end_IL_0011;
				IL_00af:
				try
				{
					int categoryId = default(int);
					if ((uint)num > 1u)
					{
						bedrockLocalLobbyBrowser._loadCancellation = _cancellation_5__2;
						if (reset)
						{
							bedrockLocalLobbyBrowser._nextOffset = 0;
							bedrockLocalLobbyBrowser._hasMore = false;
							((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Clear();
							((Selector)bedrockLocalLobbyBrowser.RoomGrid).SelectedItem = null;
							bedrockLocalLobbyBrowser.ShowSelection(null);
						}
						_searchMode_5__3 = bedrockLocalLobbyBrowser._searchMode;
						_query_5__4 = bedrockLocalLobbyBrowser._searchQuery;
						categoryId = bedrockLocalLobbyBrowser._categoryId;
						bedrockLocalLobbyBrowser.UpdateButtons();
						bedrockLocalLobbyBrowser.StatusText.Text = (_searchMode_5__3 ? ("正在搜索“" + _query_5__4 + "”") : (reset ? "正在同步公共房间目录" : "正在加载更多公共房间"));
					}
					try
					{
						ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<cwSYjVfuzDOvn8hKeZih>>.ConfiguredTaskAwaiter _u__;
						global::System.Collections.Generic.IReadOnlyList<cwSYjVfuzDOvn8hKeZih> readOnlyList;
						if (num != 0)
						{
							ConfiguredTaskAwaitable<vfa5PsfaVtd3I1U6CeBJ>.ConfiguredTaskAwaiter _u__2 = default;
							if (num != 1)
							{
								_page_5__5 = null;
								if (_searchMode_5__3)
								{
									_u__ = bedrockLocalLobbyBrowser._service.wCIX6IoTGYU(_query_5__4, categoryId, _cancellation_5__2.Token).ConfigureAwait(true).GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 0);
										__u__1 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<cwSYjVfuzDOvn8hKeZih>>.ConfiguredTaskAwaiter, _LoadRoomsAsync_d__21>(ref _u__, ref this);
										return;
									}
									goto IL_0203;
								}
								_u__2 = bedrockLocalLobbyBrowser._service.GetLocalLobbyRoomsAsync(categoryId, bedrockLocalLobbyBrowser._nextOffset, _cancellation_5__2.Token, (global::System.Collections.Generic.IReadOnlyCollection<string>)(object)Enumerable.ToArray<string>(Enumerable.Select<BedrockLocalLobbyRoomCardViewModel, string>((global::System.Collections.Generic.IEnumerable<BedrockLocalLobbyRoomCardViewModel>)bedrockLocalLobbyBrowser.Rooms, (Func<BedrockLocalLobbyRoomCardViewModel, string>)__c_7.__9._LoadRoomsAsync_b__21_1))).ConfigureAwait(true).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<vfa5PsfaVtd3I1U6CeBJ>.ConfiguredTaskAwaiter, _LoadRoomsAsync_d__21>(ref _u__2, ref this);
									return;
								}
							}
							else
							{
								_u__2 = __u__2;
								__u__2 = default(ConfiguredTaskAwaitable<vfa5PsfaVtd3I1U6CeBJ>.ConfiguredTaskAwaiter);
								num = (__1__state = -1);
							}
							vfa5PsfaVtd3I1U6CeBJ result = _u__2.GetResult();
							_page_5__5 = result;
							readOnlyList = _page_5__5.Rooms;
							goto IL_02da;
						}
						_u__ = __u__1;
						__u__1 = default(ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<cwSYjVfuzDOvn8hKeZih>>.ConfiguredTaskAwaiter);
						num = (__1__state = -1);
						goto IL_0203;
						IL_02da:
						if (!_cancellation_5__2.IsCancellationRequested && !bedrockLocalLobbyBrowser._disposed && bedrockLocalLobbyBrowser._loadCancellation == _cancellation_5__2)
						{
							HashSet<string> val = new HashSet<string>(Enumerable.Select<BedrockLocalLobbyRoomCardViewModel, string>((global::System.Collections.Generic.IEnumerable<BedrockLocalLobbyRoomCardViewModel>)bedrockLocalLobbyBrowser.Rooms, (Func<BedrockLocalLobbyRoomCardViewModel, string>)__c_7.__9._LoadRoomsAsync_b__21_0), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
							int count = ((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count;
							global::System.Collections.Generic.IEnumerator<cwSYjVfuzDOvn8hKeZih> enumerator = ((global::System.Collections.Generic.IEnumerable<cwSYjVfuzDOvn8hKeZih>)readOnlyList).GetEnumerator();
							try
							{
								while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
								{
									cwSYjVfuzDOvn8hKeZih current = enumerator.Current;
									if (val.Add(current.RoomId))
									{
										((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Add((BedrockLocalLobbyRoomCardViewModel)new BedrockLocalLobbyRoomCardViewModel(current));
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)enumerator)?.Dispose();
								}
							}
							vfa5PsfaVtd3I1U6CeBJ obj = _page_5__5;
							bedrockLocalLobbyBrowser._nextOffset = ((obj != null) ? obj.NextOffset : 0);
							vfa5PsfaVtd3I1U6CeBJ obj2 = _page_5__5;
							bedrockLocalLobbyBrowser._hasMore = obj2 != null && obj2.HasMore;
							((UIElement)bedrockLocalLobbyBrowser.EmptyPanel).Visibility = (((((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
							bedrockLocalLobbyBrowser.EmptyTitle.Text = ((((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count == 0) ? "暂无可用公共房间" : string.Empty);
							bedrockLocalLobbyBrowser.StatusText.Text = (_searchMode_5__3 ? $"搜索“{_query_5__4}” · 共 {((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count} 个结果" : ((!reset && ((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count == count) ? $"已加载 {((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count} 个公共房间，暂未发现更多房间，可稍后重试" : ((((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count == 0) ? "大厅暂时没有匹配房间" : $"已加载 {((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count} 个公共房间")));
							if (((Selector)bedrockLocalLobbyBrowser.RoomGrid).SelectedItem == null)
							{
								((Selector)bedrockLocalLobbyBrowser.RoomGrid).SelectedIndex = ((((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count <= 0) ? (-1) : 0);
							}
							_page_5__5 = null;
						}
						goto end_IL_0169;
						IL_0203:
						readOnlyList = _u__.GetResult();
						goto IL_02da;
						end_IL_0169:;
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception exception)
					{
						if (!_cancellation_5__2.IsCancellationRequested && !bedrockLocalLobbyBrowser._disposed && bedrockLocalLobbyBrowser._loadCancellation == _cancellation_5__2)
						{
							bedrockLocalLobbyBrowser.StatusText.Text = AppShell.GetExceptionDisplayMessage(exception, "LoadRoomsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockLocalLobbyBrowser.xaml.cs", 163);
							((UIElement)bedrockLocalLobbyBrowser.EmptyPanel).Visibility = (((((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)bedrockLocalLobbyBrowser.Rooms).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
							bedrockLocalLobbyBrowser.EmptyTitle.Text = "公共房间目录加载失败";
							AppShell.Error(bedrockLocalLobbyBrowser.StatusText.Text);
						}
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockLocalLobbyBrowser._loadCancellation == _cancellation_5__2)
							{
								bedrockLocalLobbyBrowser._loadCancellation = null;
							}
							if (!bedrockLocalLobbyBrowser._disposed)
							{
								bedrockLocalLobbyBrowser.UpdateButtons();
							}
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
				_query_5__4 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
			_query_5__4 = null;
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
	private struct _RefreshButton_Click_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockLocalLobbyBrowser __4__this;

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
			BedrockLocalLobbyBrowser bedrockLocalLobbyBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockLocalLobbyBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__22>(ref _u__, ref this);
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
	private struct _SearchBox_QuerySubmitted_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockLocalLobbyBrowser __4__this;

		public AutoSuggestBoxQuerySubmittedEventArgs args;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockLocalLobbyBrowser bedrockLocalLobbyBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00b4;
				}
				if (!bedrockLocalLobbyBrowser._operationRunning)
				{
					bedrockLocalLobbyBrowser._searchQuery = (args.QueryText ?? string.Empty).Trim();
					bedrockLocalLobbyBrowser._searchMode = bedrockLocalLobbyBrowser._searchQuery.Length > 0;
					_u__ = bedrockLocalLobbyBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchBox_QuerySubmitted_d__25>(ref _u__, ref this);
						return;
					}
					goto IL_00b4;
				}
				goto end_IL_0011;
				IL_00b4:
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
	private struct _SearchButton_Click_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockLocalLobbyBrowser __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockLocalLobbyBrowser bedrockLocalLobbyBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					bedrockLocalLobbyBrowser._searchQuery = bedrockLocalLobbyBrowser.SearchBox.Text.Trim();
					bedrockLocalLobbyBrowser._searchMode = bedrockLocalLobbyBrowser._searchQuery.Length > 0;
					_u__ = bedrockLocalLobbyBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchButton_Click_d__24>(ref _u__, ref this);
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

	private const double WideLayoutThreshold = 1000.0;

	private da18CdX55laNMRKtM3p0? _service;

	private CancellationTokenSource? _loadCancellation;

	private int _categoryId;

	private bool _searchMode;

	private string _searchQuery;

	private int _nextOffset;

	private bool _hasMore;

	private bool _operationRunning;

	private bool _disposed;

	[CompilerGenerated]
	private EventHandler<YBV0pDfajTopiWOW3iSn>? m_StartLobbyRequested;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid RootGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition CatalogColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition DetailColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition CompactDetailRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border DetailPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox RoomPasswordBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button StartLobbyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailPlayers;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailVersion;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailRoomId;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailConnection;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailName;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailCategory;

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
	private Button SearchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategoryAllButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategorySurvivalButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategoryCreativeButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategoryAdventureButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategorySimulationButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategoryMinigameButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategoryPvpButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CategoryCasualButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockLocalLobbyBrowser_Bindings Bindings;

	private ObservableCollection<BedrockLocalLobbyRoomCardViewModel> _Rooms_k__BackingField;
	[field: CompilerGenerated]
	public ObservableCollection<BedrockLocalLobbyRoomCardViewModel> Rooms
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public EventHandler<YBV0pDfajTopiWOW3iSn>? StartLobbyRequested;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockLocalLobbyBrowser()
	{
		_searchQuery = string.Empty;
		_Rooms_k__BackingField = new ObservableCollection<BedrockLocalLobbyRoomCardViewModel>();
		InitializeComponent();
		UpdateCategoryVisuals();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetOperationRunning(bool running)
	{
		_operationRunning = running;
		UpdateButtons();
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
	public void Clear()
	{
		CancellationTokenSource? loadCancellation = _loadCancellation;
		if (loadCancellation != null)
		{
			loadCancellation.Cancel();
		}
		_loadCancellation = null;
		_nextOffset = 0;
		_hasMore = false;
		_searchMode = false;
		_searchQuery = string.Empty;
		SearchBox.Text = string.Empty;
		((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)Rooms).Clear();
		((Selector)RoomGrid).SelectedItem = null;
		StatusText.Text = "登录后获取公共房间";
		((UIElement)EmptyPanel).Visibility = (Visibility)0;
		EmptyTitle.Text = "等待公共房间目录";
		ShowSelection(null);
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task LoadAsync()
	{
		return LoadRoomsAsync(reset: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadRoomsAsync(bool reset)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadRoomsAsync_d__21 loadRoomsAsync_d__ = default(_LoadRoomsAsync_d__21);
		loadRoomsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadRoomsAsync_d__.__4__this = this;
		loadRoomsAsync_d__.reset = reset;
		loadRoomsAsync_d__.__1__state = -1;
		loadRoomsAsync_d__.__t__builder.Start<_LoadRoomsAsync_d__21>(ref loadRoomsAsync_d__);
		return loadRoomsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__22 refreshButton_Click_d__ = default(_RefreshButton_Click_d__22);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__22>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LoadMoreButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadMoreButton_Click_d__23 loadMoreButton_Click_d__ = default(_LoadMoreButton_Click_d__23);
		loadMoreButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		loadMoreButton_Click_d__.__4__this = this;
		loadMoreButton_Click_d__.__1__state = -1;
		loadMoreButton_Click_d__.__t__builder.Start<_LoadMoreButton_Click_d__23>(ref loadMoreButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchButton_Click_d__24 searchButton_Click_d__ = default(_SearchButton_Click_d__24);
		searchButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchButton_Click_d__.__4__this = this;
		searchButton_Click_d__.__1__state = -1;
		searchButton_Click_d__.__t__builder.Start<_SearchButton_Click_d__24>(ref searchButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchBox_QuerySubmitted_d__25 searchBox_QuerySubmitted_d__ = default(_SearchBox_QuerySubmitted_d__25);
		searchBox_QuerySubmitted_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchBox_QuerySubmitted_d__.__4__this = this;
		searchBox_QuerySubmitted_d__.args = args;
		searchBox_QuerySubmitted_d__.__1__state = -1;
		searchBox_QuerySubmitted_d__.__t__builder.Start<_SearchBox_QuerySubmitted_d__25>(ref searchBox_QuerySubmitted_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CategoryButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CategoryButton_Click_d__26 categoryButton_Click_d__ = default(_CategoryButton_Click_d__26);
		categoryButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		categoryButton_Click_d__.__4__this = this;
		categoryButton_Click_d__.sender = sender;
		categoryButton_Click_d__.__1__state = -1;
		categoryButton_Click_d__.__t__builder.Start<_CategoryButton_Click_d__26>(ref categoryButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RoomGrid_ItemClick(object sender, ItemClickEventArgs e)
	{
		if (e.ClickedItem is BedrockLocalLobbyRoomCardViewModel selectedItem)
		{
			((Selector)RoomGrid).SelectedItem = selectedItem;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RoomGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		ShowSelection(((Selector)RoomGrid).SelectedItem as BedrockLocalLobbyRoomCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowSelection(BedrockLocalLobbyRoomCardViewModel? item)
	{
		cwSYjVfuzDOvn8hKeZih val = item?.Room;
		DetailCover.ImageUrl = item?.CoverUrl ?? string.Empty;
		DetailName.Text = item?.Name ?? "选择一个公共房间";
		DetailCategory.Text = ((val == null) ? string.Empty : ("分类：" + val.CategoryText + " · " + val.StatusText));
		DetailPlayers.Text = ((val == null) ? string.Empty : ("在线人数：" + val.PlayerText));
		DetailVersion.Text = ((val == null) ? string.Empty : ("版本：" + val.VersionText));
		DetailRoomId.Text = ((val == null) ? string.Empty : (string.IsNullOrWhiteSpace(val.RoomId) ? "房间号：由大厅分配" : ("房间号：" + val.RoomId)));
		DetailConnection.Text = ((val == null) ? "选择公共房间查看大厅连接信息" : (string.IsNullOrWhiteSpace(val.NetherNetId) ? "连接方式：官方公共大厅" : "连接方式：NetherNet 公网大厅（由官方客户端建立连接）"));
		RoomPasswordBox.Password = string.Empty;
		((UIElement)RoomPasswordBox).Visibility = (((val == null || !val.RequiresPassword) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StartLobbyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if (((Selector)RoomGrid).SelectedItem is BedrockLocalLobbyRoomCardViewModel bedrockLocalLobbyRoomCardViewModel)
		{
			this.StartLobbyRequested?.Invoke((object)this, new YBV0pDfajTopiWOW3iSn(bedrockLocalLobbyRoomCardViewModel.Room, RoomPasswordBox.Password));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RoomPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
	{
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RootGrid_SizeChanged(object sender, SizeChangedEventArgs e)
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
		((FrameworkElement)DetailPanel).MinHeight = ((!flag) ? 340 : 0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateCategoryVisuals()
	{
		Button[] array = (Button[])(object)new Button[8] { CategoryAllButton, CategorySurvivalButton, CategoryCreativeButton, CategoryAdventureButton, CategorySimulationButton, CategoryMinigameButton, CategoryPvpButton, CategoryCasualButton };
		foreach (Button obj in array)
		{
			((UIElement)obj).Opacity = (object.Equals(((FrameworkElement)obj).Tag, (object)_categoryId.ToString()) ? 1.0 : 0.72);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateButtons()
	{
		da18CdX55laNMRKtM3p0? service = _service;
		bool flag = ((service != null) ? service.CurrentSession : null) != null;
		((Control)RefreshButton).IsEnabled = flag && _loadCancellation == null && !_operationRunning;
		((Control)SearchButton).IsEnabled = flag && _loadCancellation == null && !_operationRunning;
		((Control)SearchBox).IsEnabled = flag && !_operationRunning;
		((Control)LoadMoreButton).IsEnabled = flag && _loadCancellation == null && !_operationRunning;
		((UIElement)LoadMoreButton).Visibility = (((!_hasMore || _searchMode || ((Collection<BedrockLocalLobbyRoomCardViewModel>)(object)Rooms).Count <= 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		((ContentControl)LoadMoreButton).Content = ((_loadCancellation == null) ? "加载更多" : "正在加载…");
		((Control)StartLobbyButton).IsEnabled = flag && !_operationRunning && ((Selector)RoomGrid).SelectedItem is BedrockLocalLobbyRoomCardViewModel bedrockLocalLobbyRoomCardViewModel && bedrockLocalLobbyRoomCardViewModel.Room.HasJoinMetadata && (!bedrockLocalLobbyRoomCardViewModel.Room.RequiresPassword || RoomPasswordBox.Password.Length > 0);
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
			this.StartLobbyRequested = null;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockLocalLobbyBrowser.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			RootGrid = CastExtensions.As<Grid>(target);
			((FrameworkElement)RootGrid).SizeChanged += new SizeChangedEventHandler(RootGrid_SizeChanged);
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
			RoomPasswordBox = CastExtensions.As<PasswordBox>(target);
			RoomPasswordBox.PasswordChanged += new RoutedEventHandler(RoomPasswordBox_PasswordChanged);
			break;
		case 8:
			StartLobbyButton = CastExtensions.As<Button>(target);
			((ButtonBase)StartLobbyButton).Click += new RoutedEventHandler(StartLobbyButton_Click);
			break;
		case 9:
			DetailPlayers = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			DetailVersion = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			DetailRoomId = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			DetailConnection = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			DetailName = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			DetailCategory = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			DetailCover = CastExtensions.As<BedrockNetworkImage>(target);
			break;
		case 16:
			LoadMoreButton = CastExtensions.As<Button>(target);
			((ButtonBase)LoadMoreButton).Click += new RoutedEventHandler(LoadMoreButton_Click);
			break;
		case 17:
			RoomGrid = CastExtensions.As<GridView>(target);
			((ListViewBase)RoomGrid).ItemClick += new ItemClickEventHandler(RoomGrid_ItemClick);
			((Selector)RoomGrid).SelectionChanged += new SelectionChangedEventHandler(RoomGrid_SelectionChanged);
			break;
		case 18:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 19:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 28:
			SearchBox = CastExtensions.As<AutoSuggestBox>(target);
			SearchBox.QuerySubmitted += SearchBox_QuerySubmitted;
			break;
		case 29:
			SearchButton = CastExtensions.As<Button>(target);
			((ButtonBase)SearchButton).Click += new RoutedEventHandler(SearchButton_Click);
			break;
		case 30:
			CategoryAllButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategoryAllButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 31:
			CategorySurvivalButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategorySurvivalButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 32:
			CategoryCreativeButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategoryCreativeButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 33:
			CategoryAdventureButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategoryAdventureButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 34:
			CategorySimulationButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategorySimulationButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 35:
			CategoryMinigameButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategoryMinigameButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 36:
			CategoryPvpButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategoryPvpButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 37:
			CategoryCasualButton = CastExtensions.As<Button>(target);
			((ButtonBase)CategoryCasualButton).Click += new RoutedEventHandler(CategoryButton_Click);
			break;
		case 38:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 39:
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
			BedrockLocalLobbyBrowser_obj1_Bindings bedrockLocalLobbyBrowser_obj1_Bindings = (BedrockLocalLobbyBrowser_obj1_Bindings)new BedrockLocalLobbyBrowser_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockLocalLobbyBrowser_obj1_Bindings;
			bedrockLocalLobbyBrowser_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockLocalLobbyBrowser_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockLocalLobbyBrowser_obj1_Bindings.Loading;
			break;
		}
		case 21:
		{
			Grid val = (Grid)target;
			BedrockLocalLobbyBrowser_obj21_Bindings bedrockLocalLobbyBrowser_obj21_Bindings = (BedrockLocalLobbyBrowser_obj21_Bindings)new BedrockLocalLobbyBrowser_obj21_Bindings();
			result = (IComponentConnector)(object)bedrockLocalLobbyBrowser_obj21_Bindings;
			bedrockLocalLobbyBrowser_obj21_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockLocalLobbyBrowser_obj21_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockLocalLobbyBrowser_obj21_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockLocalLobbyBrowser_obj21_Bindings);
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

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using IhxG38wVtDG2vuN9Gfn;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using NGs23dRsf1NAcIqosyu;
using R5yqr9R1IELhaDBLEJI;
using UnQPwWwCfQypdIMXZqd;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.UI;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Toolbox;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class HwidSpoofToolsView : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_9
	{
		public static readonly __c_9 __9;

		public static Func<string, bool> __9__14_3;

		[MethodImpl((MethodImplOptions)8)]
		static __c_9()
		{
			__9 = (__c_9)new __c_9();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_9()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _CollectConfig_b__14_3(string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass11_0_1
	{
		public int? previousId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass11_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshProcesses_b__0(fOcOY1RFFHl1umhJwJs target)
		{
			return target.ProcessId == previousId.Value;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass14_0_1
	{
		public string key;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass14_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _CollectConfig_b__1(HwidSpooferFieldItem field)
		{
			return field.Key == key;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _CollectConfig_b__2(HwidSpooferFieldItem field)
		{
			return field.Key == key;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass18_0_3
	{
		public HwidSpoofToolsView __4__this;

		public fOcOY1RFFHl1umhJwJs target;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Inject_Click_b__0()
		{
			return __4__this._injector.UNjRvji1H4(target, __4__this._spoofer.DllPath);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _Inject_Click_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HwidSpoofToolsView __4__this;

		private __c__DisplayClass18_0_3 __8__1;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HwidSpoofToolsView hwidSpoofToolsView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00d3;
				}
				__8__1 = (__c__DisplayClass18_0_3)new __c__DisplayClass18_0_3();
				__8__1.__4__this = __4__this;
				object selectedItem = ((Selector)hwidSpoofToolsView.TargetProcessBox).SelectedItem;
				__8__1.target = (fOcOY1RFFHl1umhJwJs)((selectedItem is fOcOY1RFFHl1umhJwJs) ? selectedItem : null);
				MWIWmYwkv3CUvmIFS5G val = default(MWIWmYwkv3CUvmIFS5G);
				if (__8__1.target == null)
				{
					hwidSpoofToolsView.SetStatus("先刷新并选择一个运行中的 PE 客户端。", isError: true);
				}
				else
				{
					val = hwidSpoofToolsView.CollectConfig();
					global::System.Collections.Generic.IReadOnlyList<string> readOnlyList = hwidSpoofToolsView._spoofer.cYmwhnPSe0(val);
					if (((global::System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count > 0)
					{
						hwidSpoofToolsView.SetStatus(string.Join(" ", (global::System.Collections.Generic.IEnumerable<string>)readOnlyList), isError: true);
					}
					else
					{
						if (val.Enabled)
						{
							((Control)hwidSpoofToolsView.InjectButton).IsEnabled = false;
							goto IL_00d3;
						}
						hwidSpoofToolsView.SetStatus("至少启用一项并填写有效值后才能注入。", isError: true);
					}
				}
				goto end_IL_0011;
				IL_00d3:
					val = default;
				try
				{
					TaskAwaiter<bool> _u__ = default;
					if (num != 0)
					{
						hwidSpoofToolsView._spoofer.bbVwUH0miN(val);
						_u__ = global::System.Threading.Tasks.Task.Run<bool>((Func<bool>)__8__1._Inject_Click_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _Inject_Click_d__18>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
					}
					bool result = _u__.GetResult();
					hwidSpoofToolsView.SetStatus(result ? $"Hook 已加载到 PE 进程 PID {__8__1.target.ProcessId}。" : $"PE 进程 PID {__8__1.target.ProcessId} 已加载该 Hook。", isError: false);
					hwidSpoofToolsView.RefreshLog();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "hwid-process-inject", "Inject_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\HwidSpoofToolsView.xaml.cs", 190);
					hwidSpoofToolsView.SetStatus("注入失败：" + ex.Message, isError: true);
				}
				finally
				{
					if (num < 0)
					{
						hwidSpoofToolsView.RefreshProcesses();
						hwidSpoofToolsView.UpdateInjectAvailability();
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

	private readonly yxQBCUwQBfCFevaontu _spoofer;

	private readonly S2o5G5RaBS3I3hNd033 _injector;

	private bool _initialized;

	private bool _payloadReady;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ItemsRepeater FieldsRepeater;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox DllLogTextBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock OperationStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button InjectButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PayloadStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox TargetProcessBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[CompilerGenerated]
	private readonly ObservableCollection<HwidSpooferFieldItem> _Fields_k__BackingField;

	[field: CompilerGenerated]
	private ObservableCollection<HwidSpooferFieldItem> Fields
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Fields_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public HwidSpoofToolsView()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		_spoofer = new yxQBCUwQBfCFevaontu();
		_injector = new S2o5G5RaBS3I3hNd033();
		_Fields_k__BackingField = new ObservableCollection<HwidSpooferFieldItem>();
		InitializeComponent();
		FieldsRepeater.ItemsSource = Fields;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(HwidSpoofToolsView_Loaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void HwidSpoofToolsView_Loaded(object sender, RoutedEventArgs e)
	{
		if (_initialized)
		{
			return;
		}
		_initialized = true;
		try
		{
			BuildFields(_spoofer.LoadConfig());
			RefreshProcesses();
			RefreshPayload();
			RefreshLog();
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "hwid-toolbox-load", "HwidSpoofToolsView_Loaded", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\HwidSpoofToolsView.xaml.cs", 45);
			SetStatus("加载 HWID 工具失败：" + ex.Message, isError: true);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BuildFields(MWIWmYwkv3CUvmIFS5G config)
	{
		((Collection<HwidSpooferFieldItem>)(object)Fields).Clear();
		((Collection<HwidSpooferFieldItem>)(object)Fields).Add(CreateField("mac", "网卡 MAC", "GetAdaptersInfo / GetAdaptersAddresses", "02:1A:2B:3C:4D:5E", config.Mac));
		((Collection<HwidSpooferFieldItem>)(object)Fields).Add(CreateField("volumeSerial", "卷序列号", "GetVolumeInformationW / A / ByHandleW", "A1B2C3D4", config.VolumeSerial));
		((Collection<HwidSpooferFieldItem>)(object)Fields).Add(CreateField("diskSerial", "磁盘序列号", "DeviceIoControl · StorageDeviceProperty", "SN8K4P2M7Q1R5T9V", config.DiskSerial));
		((Collection<HwidSpooferFieldItem>)(object)Fields).Add(CreateField("smbiosUuid", "SMBIOS UUID", "GetSystemFirmwareTable · RSMB / Type 1", "8c2f7a21-3b59-4d18-9c06-5e7a1b2d4f60", config.SmbiosUuid));
		((Collection<HwidSpooferFieldItem>)(object)Fields).Add(CreateField("machineGuid", "MachineGuid", "RegQueryValueExW / A · HKLM", "3d79b506-2b6a-4f80-91c2-6480a7de3b19", config.MachineGuid));
		((Collection<HwidSpooferFieldItem>)(object)Fields).Add(CreateField("computerName", "计算机名", "GetComputerNameW / A / Ex", "CHRONAL-4J8K2P", config.ComputerName));
		((Collection<HwidSpooferFieldItem>)(object)Fields).Add(CreateField("userName", "用户名", "GetUserNameW / A", "Player4821", config.UserName));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HwidSpooferFieldItem CreateField(string key, string title, string description, string placeholder, string value)
	{
		return (HwidSpooferFieldItem)new HwidSpooferFieldItem(key, title, description, placeholder)
		{
			Value = value,
			Enabled = !string.IsNullOrWhiteSpace(value)
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshProcesses()
	{
		__c__DisplayClass11_0_1 __8_locals3 = (__c__DisplayClass11_0_1)new __c__DisplayClass11_0_1();
		object selectedItem = ((Selector)TargetProcessBox).SelectedItem;
		object obj = ((selectedItem is fOcOY1RFFHl1umhJwJs) ? selectedItem : null);
		__8_locals3.previousId = ((obj != null) ? new int?(((fOcOY1RFFHl1umhJwJs)obj).ProcessId) : ((int?)null));
		global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs> readOnlyList = _injector.AO8R3Oh34e();
		((ItemsControl)TargetProcessBox).ItemsSource = readOnlyList;
		fOcOY1RFFHl1umhJwJs val = (__8_locals3.previousId.HasValue ? Enumerable.FirstOrDefault<fOcOY1RFFHl1umhJwJs>((global::System.Collections.Generic.IEnumerable<fOcOY1RFFHl1umhJwJs>)readOnlyList, (Func<fOcOY1RFFHl1umhJwJs, bool>)([MethodImpl((MethodImplOptions)8)] (fOcOY1RFFHl1umhJwJs target) => target.ProcessId == __8_locals3.previousId.Value)) : null);
		((Selector)TargetProcessBox).SelectedItem = val ?? Enumerable.FirstOrDefault<fOcOY1RFFHl1umhJwJs>((global::System.Collections.Generic.IEnumerable<fOcOY1RFFHl1umhJwJs>)readOnlyList);
		UpdateInjectAvailability();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshPayload()
	{
		try
		{
			_payloadReady = _spoofer.Sg0w42JQpt();
			PayloadStatusText.Text = (_payloadReady ? ("x64 载荷已就绪 · " + _spoofer.DllPath) : "当前安装缺少 HWID.dll，请重新安装完整发布包。");
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "hwid-payload-install", "RefreshPayload", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\HwidSpoofToolsView.xaml.cs", 88);
			_payloadReady = false;
			PayloadStatusText.Text = "载荷不可用：" + ex.Message;
		}
		UpdateInjectAvailability();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshLog()
	{
		DllLogTextBox.Text = _spoofer.ReadLogTail(80);
	}

	[MethodImpl((MethodImplOptions)8)]
	private MWIWmYwkv3CUvmIFS5G CollectConfig()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		string[] array = new string[7]
		{
			_CollectConfig_g__GetValue_14_0("mac"),
			_CollectConfig_g__GetValue_14_0("volumeSerial"),
			_CollectConfig_g__GetValue_14_0("diskSerial"),
			_CollectConfig_g__GetValue_14_0("smbiosUuid"),
			_CollectConfig_g__GetValue_14_0("machineGuid"),
			_CollectConfig_g__GetValue_14_0("computerName"),
			_CollectConfig_g__GetValue_14_0("userName")
		};
		return new MWIWmYwkv3CUvmIFS5G
		{
			Enabled = Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string value) => !string.IsNullOrWhiteSpace(value))),
			Mac = array[0],
			VolumeSerial = array[1],
			DiskSerial = array[2],
			SmbiosUuid = array[3],
			MachineGuid = array[4],
			ComputerName = array[5],
			UserName = array[6]
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RandomField_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null && ((FrameworkElement)val).Tag is HwidSpooferFieldItem hwidSpooferFieldItem)
		{
			hwidSpooferFieldItem.Value = yxQBCUwQBfCFevaontu.bmUwmiES7p(hwidSpooferFieldItem.Key);
			hwidSpooferFieldItem.Enabled = true;
			SetStatus(hwidSpooferFieldItem.Title + " 已生成随机值。", isError: false);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RandomAll_Click(object sender, RoutedEventArgs e)
	{
		global::System.Collections.Generic.IEnumerator<HwidSpooferFieldItem> enumerator = ((Collection<HwidSpooferFieldItem>)(object)Fields).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				HwidSpooferFieldItem current = enumerator.Current;
				current.Value = yxQBCUwQBfCFevaontu.bmUwmiES7p(current.Key);
				current.Enabled = true;
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		SetStatus("已生成 7 项随机值；保存后写入进程配置。", isError: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SaveConfig_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			MWIWmYwkv3CUvmIFS5G val = CollectConfig();
			global::System.Collections.Generic.IReadOnlyList<string> readOnlyList = _spoofer.cYmwhnPSe0(val);
			if (((global::System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count > 0)
			{
				SetStatus(string.Join(" ", (global::System.Collections.Generic.IEnumerable<string>)readOnlyList), isError: true);
				return;
			}
			_spoofer.bbVwUH0miN(val);
			SetStatus("配置已保存；已注入的进程会在下一次轮询时重载。", isError: false);
			RefreshLog();
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "hwid-config-save", "SaveConfig_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\HwidSpoofToolsView.xaml.cs", 153);
			SetStatus("保存失败：" + ex.Message, isError: true);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Inject_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Inject_Click_d__18 inject_Click_d__ = default(_Inject_Click_d__18);
		inject_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		inject_Click_d__.__4__this = this;
		inject_Click_d__.__1__state = -1;
		inject_Click_d__.__t__builder.Start<_Inject_Click_d__18>(ref inject_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshProcesses_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			RefreshProcesses();
			SetStatus($"已检测到 {((ItemsControl)TargetProcessBox).Items.Count} 个 PE 进程。", isError: false);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "hwid-process-refresh", "RefreshProcesses_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\HwidSpoofToolsView.xaml.cs", 209);
			SetStatus("刷新进程失败：" + ex.Message, isError: true);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void TargetProcessBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		UpdateInjectAvailability();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshPayload_Click(object sender, RoutedEventArgs e)
	{
		RefreshPayload();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshLog_Click(object sender, RoutedEventArgs e)
	{
		RefreshLog();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearLog_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			_spoofer.SAvwrF6QgM();
			RefreshLog();
			SetStatus("DLL 日志已清空。", isError: false);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "hwid-log-clear", "ClearLog_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\HwidSpoofToolsView.xaml.cs", 230);
			SetStatus("清空日志失败：" + ex.Message, isError: true);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateInjectAvailability()
	{
		((Control)InjectButton).IsEnabled = _payloadReady && ((Selector)TargetProcessBox).SelectedItem is fOcOY1RFFHl1umhJwJs;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetStatus(string message, bool isError)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		OperationStatusText.Text = message;
		if (isError)
		{
			OperationStatusText.Foreground = (Brush)new SolidColorBrush(Color.FromArgb((byte)255, (byte)196, (byte)43, (byte)28));
		}
		else
		{
			((DependencyObject)OperationStatusText).ClearValue(TextBlock.ForegroundProperty);
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
			Uri val = new Uri("ms-appx:///UI/Controls/Toolbox/HwidSpoofToolsView.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			FieldsRepeater = CastExtensions.As<ItemsRepeater>(target);
			break;
		case 3:
			DllLogTextBox = CastExtensions.As<TextBox>(target);
			break;
		case 4:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ClearLog_Click);
			break;
		case 5:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshLog_Click);
			break;
		case 6:
			OperationStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RandomAll_Click);
			break;
		case 8:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(SaveConfig_Click);
			break;
		case 9:
			InjectButton = CastExtensions.As<Button>(target);
			((ButtonBase)InjectButton).Click += new RoutedEventHandler(Inject_Click);
			break;
		case 11:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RandomField_Click);
			break;
		case 12:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshPayload_Click);
			break;
		case 13:
			PayloadStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshProcesses_Click);
			break;
		case 15:
			TargetProcessBox = CastExtensions.As<ComboBox>(target);
			((Selector)TargetProcessBox).SelectionChanged += new SelectionChangedEventHandler(TargetProcessBox_SelectionChanged);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private string _CollectConfig_g__GetValue_14_0(string key)
	{
		__c__DisplayClass14_0_1 __8_locals3 = (__c__DisplayClass14_0_1)new __c__DisplayClass14_0_1();
		__8_locals3.key = key;
		if (!Enumerable.First<HwidSpooferFieldItem>((global::System.Collections.Generic.IEnumerable<HwidSpooferFieldItem>)Fields, (Func<HwidSpooferFieldItem, bool>)([MethodImpl((MethodImplOptions)8)] (HwidSpooferFieldItem field) => field.Key == __8_locals3.key)).Enabled)
		{
			return string.Empty;
		}
		return Enumerable.First<HwidSpooferFieldItem>((global::System.Collections.Generic.IEnumerable<HwidSpooferFieldItem>)Fields, (Func<HwidSpooferFieldItem, bool>)([MethodImpl((MethodImplOptions)8)] (HwidSpooferFieldItem field) => field.Key == __8_locals3.key)).Value.Trim();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

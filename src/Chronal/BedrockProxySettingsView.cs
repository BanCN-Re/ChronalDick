using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using CvQ8qLfIaPhOpHAJXxwb;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;
using qlCAcqfBlVPxjM35nT64;
using yIYtF0fIn7KHlAY0LkTJ;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
public sealed class BedrockProxySettingsView : UserControl, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _Probe_Click_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockProxySettingsView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockProxySettingsView bedrockProxySettingsView = __4__this;
			try
			{
				if (num != 0)
				{
					bedrockProxySettingsView._probing = true;
					bedrockProxySettingsView.UpdateFields();
					bedrockProxySettingsView.ShowStatus("正在检测 SOCKS5 认证与 UDP ASSOCIATE…", (InfoBarSeverity)0);
				}
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = bmfeEhfBgZsV5fKbd7IB.kVtfBd4scL5(bedrockProxySettingsView.ReadOptions(), default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Probe_Click_d__7>(ref _u__, ref this);
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
					bedrockProxySettingsView.ShowStatus("代理认证与 UDP ASSOCIATE 成功。尚未验证游戏服务器收发；请保存设置后启动游戏。", (InfoBarSeverity)1);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Probe_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockProxySettingsView.xaml.cs", 94);
					bedrockProxySettingsView.ShowStatus(ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						bedrockProxySettingsView._probing = false;
						bedrockProxySettingsView.UpdateFields();
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

	private bool _initialized;

	private bool _probing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar StatusBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch EnabledSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ProbeButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button SaveButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox SecretBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox UsernameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch AuthenticationSwitch;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox PortBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox HostBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockProxySettingsView()
	{
		InitializeComponent();
		try
		{
			jX93P4fIu15bhq10GXXT val = BMBwE6fIiRdqmheZPl4M.Load();
			EnabledSwitch.IsOn = val.Enabled;
			HostBox.Text = val.Host;
			PortBox.Text = val.Port.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture);
			AuthenticationSwitch.IsOn = val.UseAuthentication;
			UsernameBox.Text = val.Username;
			SecretBox.Password = val.Password;
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", ".ctor", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockProxySettingsView.xaml.cs", 29);
			ShowStatus(ex.Message, (InfoBarSeverity)3);
		}
		_initialized = true;
		UpdateFields();
	}

	[MethodImpl((MethodImplOptions)8)]
	private jX93P4fIu15bhq10GXXT ReadOptions()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		int num = default(int);
		bool flag = int.TryParse(PortBox.Text, (NumberStyles)0, (IFormatProvider)(object)CultureInfo.InvariantCulture, out num) && num >= 1 && num <= 65535;
		if (EnabledSwitch.IsOn && !flag)
		{
			throw new ArgumentException("代理端口必须是 1–65535 之间的整数。");
		}
		jX93P4fIu15bhq10GXXT val = new jX93P4fIu15bhq10GXXT();
		val.GetType().GetProperty("Enabled").SetValue(val, EnabledSwitch.IsOn);
		val.GetType().GetProperty("Host").SetValue(val, HostBox.Text.Trim());
		val.GetType().GetProperty("Port").SetValue(val, flag ? num : 1080);
		val.GetType().GetProperty("UseAuthentication").SetValue(val, AuthenticationSwitch.IsOn);
		val.GetType().GetProperty("Username").SetValue(val, UsernameBox.Text);
		val.GetType().GetProperty("Password").SetValue(val, SecretBox.Password);
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Options_Toggled(object sender, RoutedEventArgs e)
	{
		if (_initialized)
		{
			UpdateFields();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateFields()
	{
		bool flag = EnabledSwitch.IsOn && !_probing;
		((Control)EnabledSwitch).IsEnabled = !_probing;
		((Control)HostBox).IsEnabled = flag;
		((Control)PortBox).IsEnabled = flag;
		((Control)AuthenticationSwitch).IsEnabled = flag;
		TextBox usernameBox = UsernameBox;
		bool isEnabled = (((Control)SecretBox).IsEnabled = flag && AuthenticationSwitch.IsOn);
		((Control)usernameBox).IsEnabled = isEnabled;
		((Control)ProbeButton).IsEnabled = flag;
		((Control)SaveButton).IsEnabled = !_probing;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Save_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			jX93P4fIu15bhq10GXXT val = ReadOptions();
			BMBwE6fIiRdqmheZPl4M.Save(val);
			ShowStatus(val.Enabled ? "代理设置已保存。下次启动网络服、租赁服或基岩中继时生效；当前连接保持原设置。" : "代理已关闭，下次启动生效。", (InfoBarSeverity)1);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Save_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockProxySettingsView.xaml.cs", 80);
			ShowStatus(ex.Message, (InfoBarSeverity)3);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Probe_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Probe_Click_d__7 probe_Click_d__ = default(_Probe_Click_d__7);
		probe_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		probe_Click_d__.__4__this = this;
		probe_Click_d__.__1__state = -1;
		probe_Click_d__.__t__builder.Start<_Probe_Click_d__7>(ref probe_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowStatus(string message, InfoBarSeverity severity)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		StatusBar.Message = message;
		StatusBar.Severity = severity;
		StatusBar.IsOpen = true;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockProxySettingsView.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			StatusBar = CastExtensions.As<InfoBar>(target);
			break;
		case 3:
			EnabledSwitch = CastExtensions.As<ToggleSwitch>(target);
			EnabledSwitch.Toggled += new RoutedEventHandler(Options_Toggled);
			break;
		case 4:
			ProbeButton = CastExtensions.As<Button>(target);
			((ButtonBase)ProbeButton).Click += new RoutedEventHandler(Probe_Click);
			break;
		case 5:
			SaveButton = CastExtensions.As<Button>(target);
			((ButtonBase)SaveButton).Click += new RoutedEventHandler(Save_Click);
			break;
		case 6:
			SecretBox = CastExtensions.As<PasswordBox>(target);
			break;
		case 7:
			UsernameBox = CastExtensions.As<TextBox>(target);
			break;
		case 8:
			AuthenticationSwitch = CastExtensions.As<ToggleSwitch>(target);
			AuthenticationSwitch.Toggled += new RoutedEventHandler(Options_Toggled);
			break;
		case 9:
			PortBox = CastExtensions.As<TextBox>(target);
			break;
		case 10:
			HostBox = CastExtensions.As<TextBox>(target);
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
	private static void _cctor()
	{
	}
}

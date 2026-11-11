using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
public sealed class SmsVerificationView : UserControl, IComponentConnector
{
	private string? _smsContent;

	private string? _smsNumber;

	private string? _backupNumber;

	private bool _operationRunning;

	[CompilerGenerated]
	private EventHandler? m_RetryRequested;

	[CompilerGenerated]
	private EventHandler? m_CancelRequested;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock InstructionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel ActionsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CopyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RetryButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SmsContentText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SmsNumberText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BackupNumberText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	public EventHandler RetryRequested;

	public EventHandler CancelRequested;

	[MethodImpl((MethodImplOptions)8)]
	public SmsVerificationView()
	{
		InitializeComponent();
		Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Show(string content, string number, string? backupNumber, string instruction)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(content, "content");
		ArgumentException.ThrowIfNullOrWhiteSpace(number, "number");
		_smsContent = content;
		_smsNumber = number;
		_backupNumber = backupNumber;
		SmsContentText.Text = content;
		SmsNumberText.Text = number;
		BackupNumberText.Text = (string.IsNullOrWhiteSpace(backupNumber) ? string.Empty : ("备用号码：" + backupNumber));
		((UIElement)BackupNumberText).Visibility = (string.IsNullOrWhiteSpace(backupNumber)) ? Visibility.Visible : Visibility.Collapsed;
		InstructionText.Text = instruction;
		((UIElement)this).Visibility = (Visibility)0;
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		_smsContent = null;
		_smsNumber = null;
		_backupNumber = null;
		SmsContentText.Text = string.Empty;
		SmsNumberText.Text = string.Empty;
		BackupNumberText.Text = string.Empty;
		((UIElement)BackupNumberText).Visibility = (Visibility)1;
		InstructionText.Text = string.Empty;
		((UIElement)this).Visibility = (Visibility)1;
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetOperationRunning(bool running)
	{
		_operationRunning = running;
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateButtons()
	{
		bool flag = !string.IsNullOrWhiteSpace(_smsContent) && !string.IsNullOrWhiteSpace(_smsNumber);
		bool isEnabled = !_operationRunning && flag;
		((Control)CopyButton).IsEnabled = isEnabled;
		((Control)RetryButton).IsEnabled = isEnabled;
		((Control)CancelButton).IsEnabled = flag;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ActionsPanel_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		StackPanel actionsPanel = ActionsPanel;
		Size newSize = e.NewSize;
		actionsPanel.Orientation = ((!(newSize.Width < 480.0)) ? (Orientation)1 : (Orientation)0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyButton_Click(object sender, RoutedEventArgs e)
	{
		if (_smsContent == null || _smsNumber == null || _operationRunning)
		{
			return;
		}
		try
		{
			string text = (string.IsNullOrWhiteSpace(_backupNumber) ? string.Empty : ("\n备用号码：" + _backupNumber));
			UiHelpers.CopyToClipboard($"收件号码：{_smsNumber}{text}\n短信内容：{_smsContent}");
			AppShell.Success("号码与验证内容已复制");
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "CopyButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\SmsVerificationView.xaml.cs", 87));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RetryButton_Click(object sender, RoutedEventArgs e)
	{
		if (!_operationRunning && _smsContent != null && _smsNumber != null)
		{
			EventHandler? obj = this.RetryRequested;
			if (obj != null)
			{
				obj.Invoke((object)this, EventArgs.Empty);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelButton_Click(object sender, RoutedEventArgs e)
	{
		if (_smsContent != null && _smsNumber != null)
		{
			EventHandler? obj = this.CancelRequested;
			if (obj != null)
			{
				obj.Invoke((object)this, EventArgs.Empty);
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
			Uri val = new Uri("ms-appx:///UI/Controls/SmsVerificationView.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			InstructionText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			ActionsPanel = CastExtensions.As<StackPanel>(target);
			((FrameworkElement)ActionsPanel).SizeChanged += new SizeChangedEventHandler(ActionsPanel_SizeChanged);
			break;
		case 4:
			CopyButton = CastExtensions.As<Button>(target);
			((ButtonBase)CopyButton).Click += new RoutedEventHandler(CopyButton_Click);
			break;
		case 5:
			RetryButton = CastExtensions.As<Button>(target);
			((ButtonBase)RetryButton).Click += new RoutedEventHandler(RetryButton_Click);
			break;
		case 6:
			CancelButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelButton).Click += new RoutedEventHandler(CancelButton_Click);
			break;
		case 7:
			SmsContentText = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			SmsNumberText = CastExtensions.As<TextBlock>(target);
			break;
		case 9:
			BackupNumberText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

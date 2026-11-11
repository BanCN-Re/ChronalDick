using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Mahiro_Account.UI.Shell;

internal interface IShellHost
{
	XamlRoot? ShellXamlRoot { get; }

	void ShowLoading(bool show);

	void PostNotification(InfoBarSeverity severity, string message, string? title = null);

	void NavigateContent(global::System.Type pageType, object? parameter);

	void EnterAuthenticationState(string? message);
}

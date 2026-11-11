using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Toolbox;

internal sealed class HwidSpooferFieldItem : INotifyPropertyChanged
{
	private bool _enabled;

	private string _value;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	[field: CompilerGenerated]
	public string Key
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string Title
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string Description
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string Placeholder
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public bool Enabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _enabled;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			if (_enabled != value)
			{
				_enabled = value;
				OnPropertyChanged("Enabled");
			}
		}
	}

	public string Value
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _value;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			string text = value ?? string.Empty;
			if (!(_value == text))
			{
				_value = text;
				OnPropertyChanged("Value");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[MethodImpl((MethodImplOptions)8)]
	public HwidSpooferFieldItem(string key, string title, string description, string placeholder)
	{
		_value = string.Empty;
		Key = key;
		Title = title;
		Description = description;
		Placeholder = placeholder;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		PropertyChangedEventHandler? obj = this.PropertyChanged;
		if (obj != null)
		{
			obj.Invoke((object)this, new PropertyChangedEventArgs(propertyName));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

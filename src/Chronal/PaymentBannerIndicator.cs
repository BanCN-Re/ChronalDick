using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

public sealed class PaymentBannerIndicator : INotifyPropertyChanged
{
	private bool _isActive;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	[CompilerGenerated]
	private readonly int _Index_k__BackingField;

	[field: CompilerGenerated]
	public int Index
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Index_k__BackingField;
		}
	}

	[CompilerGenerated]
	private readonly int _Number_k__BackingField;

	[field: CompilerGenerated]
	public int Number
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Number_k__BackingField;
		}
	}

	public Visibility ActiveVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (_isActive)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public bool IsActive
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _isActive;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			if (_isActive != value)
			{
				_isActive = value;
				OnPropertyChanged("ActiveVisibility");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[MethodImpl((MethodImplOptions)8)]
	public PaymentBannerIndicator(int index)
	{
		_Index_k__BackingField = index;
		_Number_k__BackingField = index + 1;
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

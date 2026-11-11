using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using kTag3lfTQlMnWtlhqJue;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Java;

public sealed class JavaSkinCardViewModel : INotifyPropertyChanged
{
	private bool _isApplied;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	[field: CompilerGenerated]
	public gcmmptfTJGk6dCBYHIl7 Skin
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Skin.Name;
		}
	}

	public string Developer
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Skin.DeveloperText;
		}
	}

	public string Summary
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Skin.Summary;
		}
	}

	public string CoverUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Skin.ImageUrl;
		}
	}

	public string MetricsText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Skin.MetricsText;
		}
	}

	public string OwnershipText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!Skin.IsOwned)
			{
				return "可获取";
			}
			return "已拥有";
		}
	}

	public bool IsApplied
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _isApplied;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			if (_isApplied != value)
			{
				_isApplied = value;
				PropertyChangedEventHandler? obj = this.PropertyChanged;
				if (obj != null)
				{
					obj.Invoke((object)this, new PropertyChangedEventArgs("IsApplied"));
				}
				PropertyChangedEventHandler? obj2 = this.PropertyChanged;
				if (obj2 != null)
				{
					obj2.Invoke((object)this, new PropertyChangedEventArgs("AppliedVisibility"));
				}
			}
		}
	}

	public Visibility AppliedVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IsApplied)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[MethodImpl((MethodImplOptions)8)]
	public JavaSkinCardViewModel(gcmmptfTJGk6dCBYHIl7 skin, bool isApplied)
	{
		Skin = skin;
		_isApplied = isApplied;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

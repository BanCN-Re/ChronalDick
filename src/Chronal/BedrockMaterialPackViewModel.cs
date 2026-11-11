using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Imaging;
using nW2Sekfay3BSEMMb8toe;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockMaterialPackViewModel : INotifyPropertyChanged
{
	private WQh695fa8bRtqyh4inIH _pack;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	public WQh695fa8bRtqyh4inIH Pack
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _pack;
		}
	}

	public string Id
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _pack.Id;
		}
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _pack.Name;
		}
	}

	public string Description
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _pack.Description;
		}
	}

	public string MetadataText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return $"{(_pack.IsEnabled ? "已启用" : "未启用")}  ·  {_pack.SourceText}  ·  v{_pack.VersionText}  ·  {FontProtectionStateText}";
		}
	}

	public string ExclusionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _pack.ExcludedFoldersText;
		}
	}

	[field: CompilerGenerated]
	public BitmapImage? IconSource
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private BitmapImage? _IconSource_k__BackingField;

	public Visibility IconVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IconSource == null)
			{
				return (Visibility)1;
			}
			return (Visibility)0;
		}
	}

	public Visibility PlaceholderVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IconSource == null)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public bool IsEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _pack.IsEnabled;
		}
	}

	public string EnabledStateText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!IsEnabled)
			{
				return "未启用";
			}
			return "已启用";
		}
	}

	public bool AllowFontOverride
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return !Enumerable.Contains<string>((global::System.Collections.Generic.IEnumerable<string>)_pack.ExcludedFolders, "font", (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		}
	}

	public string EnableActionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!IsEnabled)
			{
				return "启用材质包";
			}
			return "停用材质包";
		}
	}

	public string FontProtectionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!AllowFontOverride)
			{
				return "允许覆盖字体";
			}
			return "保护服务器字体";
		}
	}

	public string FontProtectionStateText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!AllowFontOverride)
			{
				return "字体已保护";
			}
			return "字体可覆盖";
		}
	}

	public string FontProtectionToolTip
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return "当前：" + FontProtectionStateText + "；点击后：" + FontProtectionText;
		}
	}

	public string EnableToolTip
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return "当前：" + EnabledStateText + "；点击后：" + EnableActionText;
		}
	}

	public bool CanDelete
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return !_pack.IsPreset;
		}
	}

	public Visibility DeleteVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (CanDelete)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	[field: CompilerGenerated]
	public bool CanMoveUp
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set;
	}

	[field: CompilerGenerated]
	public bool CanMoveDown
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set;
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockMaterialPackViewModel(WQh695fa8bRtqyh4inIH pack)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		_pack = pack ?? throw new ArgumentNullException("pack");
		if (!string.IsNullOrWhiteSpace(pack.IconPath))
		{
			try
			{
				_IconSource_k__BackingField = new BitmapImage(new Uri(pack.IconPath));
			}
			catch (UriFormatException)
			{
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void SetPosition(int index, int count)
	{
		CanMoveUp = index > 0;
		CanMoveDown = index >= 0 && index < count - 1;
		OnPropertyChanged("CanMoveUp");
		OnPropertyChanged("CanMoveDown");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Replace(WQh695fa8bRtqyh4inIH pack)
	{
		_pack = pack;
		OnPropertyChanged("Pack");
		OnPropertyChanged("Name");
		OnPropertyChanged("Description");
		OnPropertyChanged("MetadataText");
		OnPropertyChanged("ExclusionText");
		OnPropertyChanged("IsEnabled");
		OnPropertyChanged("EnabledStateText");
		OnPropertyChanged("AllowFontOverride");
		OnPropertyChanged("EnableActionText");
		OnPropertyChanged("EnableToolTip");
		OnPropertyChanged("FontProtectionText");
		OnPropertyChanged("FontProtectionStateText");
		OnPropertyChanged("FontProtectionToolTip");
		OnPropertyChanged("CanDelete");
		OnPropertyChanged("DeleteVisibility");
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

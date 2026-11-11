using System.Collections.Generic;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages;

public sealed class TimelineEntry
{
	[field: CompilerGenerated]
	private string _VersionText_k__BackingField;
	public string VersionText
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	private string _DateText_k__BackingField;
	public string DateText
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool IsLatest
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	public Visibility LatestBadgeVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IsLatest)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	[field: CompilerGenerated]
	private List<TimelineNote> _Notes_k__BackingField;
	public List<TimelineNote> Notes
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[MethodImpl((MethodImplOptions)8)]
	public TimelineEntry()
	{
		_VersionText_k__BackingField = string.Empty;
		_DateText_k__BackingField = string.Empty;
		_Notes_k__BackingField = new List<TimelineNote>();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

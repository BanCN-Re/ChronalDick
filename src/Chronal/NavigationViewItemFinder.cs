using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Navigation;

internal static class NavigationViewItemFinder
{
	[MethodImpl((MethodImplOptions)8)]
	internal static NavigationViewItem? FindByTag(global::System.Collections.IEnumerable items, string key, bool expandAncestors)
	{
		ArgumentNullException.ThrowIfNull((object)items, "items");
		ArgumentException.ThrowIfNullOrWhiteSpace(key, "key");
		foreach (object item in items)
		{
			NavigationViewItem val = (NavigationViewItem)((item is NavigationViewItem) ? item : null);
			if (val == null)
			{
				continue;
			}
			if (string.Equals(((FrameworkElement)val).Tag as string, key, (StringComparison)4))
			{
				return val;
			}
			NavigationViewItem val2 = FindByTag((global::System.Collections.IEnumerable)val.MenuItems, key, expandAncestors);
			if (val2 != null)
			{
				if (expandAncestors)
				{
					val.IsExpanded = true;
				}
				return val2;
			}
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

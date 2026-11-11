using System;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Shell;

internal static class NotificationAutoDismiss
{
	private sealed class DismissState
	{
		[field: CompilerGenerated]
		internal DispatcherQueueTimer? Timer
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[MethodImpl((MethodImplOptions)8)]
		public DismissState()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_15
	{
		public static readonly __c_15 __9;

		public static System.Runtime.CompilerServices.ConditionalWeakTable<InfoBar, DismissState>.CreateValueCallback __9__2_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_15()
		{
			__9 = (__c_15)new __c_15();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_15()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DismissState _Show_b__2_0(InfoBar _)
		{
			return (DismissState)new DismissState();
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass2_0
	{
		public DismissState state;

		public InfoBar infoBar;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass2_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _Show_b__1(DispatcherQueueTimer sender, object _)
		{
			sender.Stop();
			if (state.Timer == sender)
			{
				state.Timer = null;
				infoBar.IsOpen = false;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private static readonly ConditionalWeakTable<InfoBar, DismissState> States;

	[MethodImpl((MethodImplOptions)8)]
	internal static TimeSpan GetDelay(InfoBarSeverity severity)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		return (TimeSpan)((int)severity switch
		{
			1 => TimeSpan.FromSeconds(4.0), 
			0 => TimeSpan.FromSeconds(5.0), 
			2 => TimeSpan.FromSeconds(7.0), 
			3 => TimeSpan.FromSeconds(10.0), 
			_ => TimeSpan.FromSeconds(5.0), 
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Show(InfoBar infoBar)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass2_0 __8_locals12 = (__c__DisplayClass2_0)new __c__DisplayClass2_0();
		__8_locals12.infoBar = infoBar;
		ArgumentNullException.ThrowIfNull((object)__8_locals12.infoBar, "infoBar");
		__8_locals12.state = States.GetValue(__8_locals12.infoBar, (System.Runtime.CompilerServices.ConditionalWeakTable<InfoBar, DismissState>.CreateValueCallback)([MethodImpl((MethodImplOptions)8)] (InfoBar _) => (DismissState)new DismissState()));
		DispatcherQueueTimer? timer = __8_locals12.state.Timer;
		if (timer != null)
		{
			timer.Stop();
		}
		DispatcherQueueTimer val = ((DependencyObject)__8_locals12.infoBar).DispatcherQueue.CreateTimer();
		val.Interval = GetDelay(__8_locals12.infoBar.Severity);
		val.IsRepeating = false;
		val.Tick += [MethodImpl((MethodImplOptions)8)] (DispatcherQueueTimer sender, object _) =>
		{
			sender.Stop();
			if (__8_locals12.state.Timer == sender)
			{
				__8_locals12.state.Timer = null;
				__8_locals12.infoBar.IsOpen = false;
			}
		};
		__8_locals12.state.Timer = val;
		__8_locals12.infoBar.IsOpen = true;
		val.Start();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Hide(InfoBar infoBar)
	{
		ArgumentNullException.ThrowIfNull((object)infoBar, "infoBar");
		DismissState dismissState = default(DismissState);
		if (States.TryGetValue(infoBar, out dismissState))
		{
			DispatcherQueueTimer? timer = dismissState.Timer;
			if (timer != null)
			{
				timer.Stop();
			}
			dismissState.Timer = null;
		}
		infoBar.IsOpen = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	static NotificationAutoDismiss()
	{
		States = new ConditionalWeakTable<InfoBar, DismissState>();
	}
}

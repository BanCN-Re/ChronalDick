using System;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

public static class Motion
{
	private sealed class CountState
	{
		[field: CompilerGenerated]
		internal decimal Current
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[field: CompilerGenerated]
		internal decimal From
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[field: CompilerGenerated]
		internal decimal To
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		private string _Prefix_k__BackingField;
		[field: CompilerGenerated]
		internal string Prefix
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		private string _Format_k__BackingField;
		[field: CompilerGenerated]
		internal string Format
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

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

		private Stopwatch _Clock_k__BackingField;
		[field: CompilerGenerated]
		internal Stopwatch Clock
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string Render(decimal value)
		{
			return Prefix + value.ToString(Format, (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}

		[MethodImpl((MethodImplOptions)8)]
		public CountState()
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			_Prefix_k__BackingField = string.Empty;
			_Format_k__BackingField = "0.00";
			_Clock_k__BackingField = new Stopwatch();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private static class __O_11
	{
		public static SizeChangedEventHandler _0___OnLiftSizeChanged;

		public static PointerEventHandler _1___OnLiftPointerEntered;

		public static PointerEventHandler _2___OnLiftPointerReset;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass15_0_5
	{
		public TextBlock target;

		public CountState state;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass15_0_5()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _CountTo_b__0(DispatcherQueueTimer _, object _2)
		{
			OnCountTick(target, state);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private static readonly TimeSpan LiftDuration;

	private static readonly TimeSpan CountDuration;

	private static readonly TimeSpan FrameInterval;

	private const float LiftScale = 1.012f;

	private const float LiftOffsetY = -3f;

	public static readonly DependencyProperty LiftProperty;

	private static readonly DependencyProperty CountStateProperty;

	[MethodImpl((MethodImplOptions)8)]
	public static bool GetLift(DependencyObject target)
	{
		return (bool)target.GetValue(LiftProperty);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void SetLift(DependencyObject target, bool value)
	{
		target.SetValue(LiftProperty, (object)value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnLiftChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		FrameworkElement val = (FrameworkElement)(object)((sender is FrameworkElement) ? sender : null);
		if (val == null)
		{
			return;
		}
		object obj = __O_11._0___OnLiftSizeChanged;
		if (obj == null)
		{
			SizeChangedEventHandler val2 = OnLiftSizeChanged;
			__O_11._0___OnLiftSizeChanged = val2;
			obj = (object)val2;
		}
		val.SizeChanged -= (SizeChangedEventHandler)obj;
		object obj2 = __O_11._1___OnLiftPointerEntered;
		if (obj2 == null)
		{
			PointerEventHandler val3 = OnLiftPointerEntered;
			__O_11._1___OnLiftPointerEntered = val3;
			obj2 = (object)val3;
		}
		((UIElement)val).PointerEntered -= (PointerEventHandler)obj2;
		object obj3 = __O_11._2___OnLiftPointerReset;
		if (obj3 == null)
		{
			PointerEventHandler val4 = OnLiftPointerReset;
			__O_11._2___OnLiftPointerReset = val4;
			obj3 = (object)val4;
		}
		((UIElement)val).PointerExited -= (PointerEventHandler)obj3;
		object obj4 = __O_11._2___OnLiftPointerReset;
		if (obj4 == null)
		{
			PointerEventHandler val5 = OnLiftPointerReset;
			__O_11._2___OnLiftPointerReset = val5;
			obj4 = (object)val5;
		}
		((UIElement)val).PointerCanceled -= (PointerEventHandler)obj4;
		object obj5 = __O_11._2___OnLiftPointerReset;
		if (obj5 == null)
		{
			PointerEventHandler val6 = OnLiftPointerReset;
			__O_11._2___OnLiftPointerReset = val6;
			obj5 = (object)val6;
		}
		((UIElement)val).PointerCaptureLost -= (PointerEventHandler)obj5;
		object newValue = args.NewValue;
		if (!(newValue is bool) || !(bool)newValue)
		{
			ResetLift((UIElement)(object)val);
			return;
		}
		((UIElement)val).ScaleTransition = new Vector3Transition
		{
			Duration = LiftDuration
		};
		((UIElement)val).TranslationTransition = new Vector3Transition
		{
			Duration = LiftDuration
		};
		UpdateCenterPoint(val);
		object obj6 = __O_11._0___OnLiftSizeChanged;
		if (obj6 == null)
		{
			SizeChangedEventHandler val7 = OnLiftSizeChanged;
			__O_11._0___OnLiftSizeChanged = val7;
			obj6 = (object)val7;
		}
		val.SizeChanged += (SizeChangedEventHandler)obj6;
		object obj7 = __O_11._1___OnLiftPointerEntered;
		if (obj7 == null)
		{
			PointerEventHandler val8 = OnLiftPointerEntered;
			__O_11._1___OnLiftPointerEntered = val8;
			obj7 = (object)val8;
		}
		((UIElement)val).PointerEntered += (PointerEventHandler)obj7;
		object obj8 = __O_11._2___OnLiftPointerReset;
		if (obj8 == null)
		{
			PointerEventHandler val9 = OnLiftPointerReset;
			__O_11._2___OnLiftPointerReset = val9;
			obj8 = (object)val9;
		}
		((UIElement)val).PointerExited += (PointerEventHandler)obj8;
		object obj9 = __O_11._2___OnLiftPointerReset;
		if (obj9 == null)
		{
			PointerEventHandler val10 = OnLiftPointerReset;
			__O_11._2___OnLiftPointerReset = val10;
			obj9 = (object)val10;
		}
		((UIElement)val).PointerCanceled += (PointerEventHandler)obj9;
		object obj10 = __O_11._2___OnLiftPointerReset;
		if (obj10 == null)
		{
			PointerEventHandler val11 = OnLiftPointerReset;
			__O_11._2___OnLiftPointerReset = val11;
			obj10 = (object)val11;
		}
		((UIElement)val).PointerCaptureLost += (PointerEventHandler)obj10;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnLiftSizeChanged(object sender, SizeChangedEventArgs e)
	{
		FrameworkElement val = (FrameworkElement)((sender is FrameworkElement) ? sender : null);
		if (val != null)
		{
			UpdateCenterPoint(val);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void UpdateCenterPoint(FrameworkElement element)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		double actualWidth = element.ActualWidth;
		double actualHeight = element.ActualHeight;
		if (actualWidth > 0.0 && actualHeight > 0.0)
		{
			((UIElement)element).CenterPoint = new Vector3((float)(actualWidth / 2.0), (float)(actualHeight / 2.0), 0f);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnLiftPointerEntered(object sender, PointerRoutedEventArgs e)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		FrameworkElement val = (FrameworkElement)((sender is FrameworkElement) ? sender : null);
		if (val != null)
		{
			UpdateCenterPoint(val);
			((UIElement)val).Scale = new Vector3(1.012f, 1.012f, 1f);
			((UIElement)val).Translation = new Vector3(0f, -3f, 0f);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnLiftPointerReset(object sender, PointerRoutedEventArgs e)
	{
		FrameworkElement val = (FrameworkElement)((sender is FrameworkElement) ? sender : null);
		if (val != null)
		{
			ResetLift((UIElement)(object)val);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ResetLift(UIElement element)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		element.Scale = Vector3.One;
		element.Translation = Vector3.Zero;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void CountTo(TextBlock target, decimal value, string prefix = "¥ ", string format = "0.00", bool animate = true)
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass15_0_5 __8_locals28 = (__c__DisplayClass15_0_5)new __c__DisplayClass15_0_5();
		__8_locals28.target = target;
		if (__8_locals28.target == null)
		{
			return;
		}
		try
		{
			bool num = !(((DependencyObject)__8_locals28.target).GetValue(CountStateProperty) is CountState);
			object value2 = ((DependencyObject)__8_locals28.target).GetValue(CountStateProperty);
			__8_locals28.state = value2 as CountState;
			if (__8_locals28.state == null)
			{
				__8_locals28.state = (CountState)new CountState();
				((DependencyObject)__8_locals28.target).SetValue(CountStateProperty, (object)__8_locals28.state);
			}
			__8_locals28.state.Prefix = prefix;
			__8_locals28.state.Format = format;
			DispatcherQueueTimer? timer = __8_locals28.state.Timer;
			if (timer != null)
			{
				timer.Stop();
			}
			if (num || !animate || __8_locals28.state.Current == value || ((DependencyObject)__8_locals28.target).DispatcherQueue == null)
			{
				__8_locals28.state.Current = value;
				__8_locals28.target.Text = __8_locals28.state.Render(value);
				return;
			}
			__8_locals28.state.From = __8_locals28.state.Current;
			__8_locals28.state.To = value;
			__8_locals28.state.Clock.Restart();
			if (__8_locals28.state.Timer == null)
			{
				DispatcherQueueTimer val = ((DependencyObject)__8_locals28.target).DispatcherQueue.CreateTimer();
				val.Interval = FrameInterval;
				val.IsRepeating = true;
				val.Tick += [MethodImpl((MethodImplOptions)8)] (DispatcherQueueTimer _, object _) =>
				{
					OnCountTick(__8_locals28.target, __8_locals28.state);
				};
				__8_locals28.state.Timer = val;
			}
			__8_locals28.state.Timer.Start();
		}
		catch (global::System.Exception)
		{
			__8_locals28.target.Text = prefix + value.ToString(format, (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnCountTick(TextBlock target, CountState state)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			TimeSpan elapsed = state.Clock.Elapsed;
			double num = elapsed.TotalMilliseconds / CountDuration.TotalMilliseconds;
			if (num >= 1.0)
			{
				DispatcherQueueTimer? timer = state.Timer;
				if (timer != null)
				{
					timer.Stop();
				}
				state.Clock.Stop();
				state.Current = state.To;
				target.Text = state.Render(state.To);
			}
			else
			{
				double num2 = 1.0 - Math.Pow(1.0 - num, 3.0);
				decimal value = (state.Current = state.From + (state.To - state.From) * (decimal)num2);
				target.Text = state.Render(value);
			}
		}
		catch (global::System.Exception)
		{
			DispatcherQueueTimer? timer2 = state.Timer;
			if (timer2 != null)
			{
				timer2.Stop();
			}
			state.Clock.Stop();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	static Motion()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		LiftDuration = TimeSpan.FromMilliseconds(160.0);
		CountDuration = TimeSpan.FromMilliseconds(520.0);
		FrameInterval = TimeSpan.FromMilliseconds(16.0);
		LiftProperty = DependencyProperty.RegisterAttached("Lift", typeof(global::System.Boolean), typeof(global::Mahiro_Account.UI.Motion), new PropertyMetadata((object)false, new PropertyChangedCallback(OnLiftChanged)));
		CountStateProperty = DependencyProperty.RegisterAttached("CountState", typeof(global::System.Object), typeof(global::Mahiro_Account.UI.Motion), new PropertyMetadata((object)null));
	}
}

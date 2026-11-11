using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using pDFcXyfOjGiubvpRL0gO;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal static class ChangelogDialog
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ShowAsync_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public XamlRoot xamlRoot;

		public global::System.Collections.Generic.IReadOnlyList<d2iiUHfOLr9ZvQq4WHMC> entries;

		public string title;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Expected O, but got Unknown
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Expected O, but got Unknown
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Expected O, but got Unknown
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_030d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Expected O, but got Unknown
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected O, but got Unknown
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected O, but got Unknown
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Expected O, but got Unknown
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Expected O, but got Unknown
			int num = __1__state;
			try
			{
				if (num == 0)
				{
					goto IL_03cb;
				}
				ContentDialog val8 = default(ContentDialog);
				if (xamlRoot != null && entries != null && ((global::System.Collections.Generic.IReadOnlyCollection<d2iiUHfOLr9ZvQq4WHMC>)entries).Count != 0)
				{
					StackPanel val = new StackPanel
					{
						Spacing = 18.0,
						MaxWidth = 640.0
					};
					for (int i = 0; i < ((global::System.Collections.Generic.IReadOnlyCollection<d2iiUHfOLr9ZvQq4WHMC>)entries).Count; i++)
					{
						d2iiUHfOLr9ZvQq4WHMC val2 = entries[i];
						StackPanel val3 = new StackPanel
						{
							Spacing = 8.0
						};
						StackPanel val4 = new StackPanel
						{
							Orientation = (Orientation)1,
							Spacing = 10.0
						};
						((Panel)val4).Children.Add((UIElement)new TextBlock
						{
							Text = val2.VersionText,
							FontSize = 18.0,
							FontWeight = FontWeights.SemiBold,
							VerticalAlignment = (VerticalAlignment)1
						});
						if (val2.DateText.Length > 0)
						{
							((Panel)val4).Children.Add((UIElement)new TextBlock
							{
								Text = val2.DateText,
								FontSize = 12.0,
								VerticalAlignment = (VerticalAlignment)1,
								Style = null
							});
						}
						((Panel)val3).Children.Add((UIElement)(object)val4);
						if (val2.Notes.Count == 0)
						{
							((Panel)val3).Children.Add((UIElement)new TextBlock
							{
								Text = "本版本未提供变更说明。",
								TextWrapping = (TextWrapping)2,
								Style = null
							});
						}
						else
						{
							StackPanel val5 = new StackPanel
							{
								Spacing = 6.0
							};
							var enumerator = val2.Notes.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									string current = enumerator.Current;
									Grid val6 = new Grid
									{
										ColumnSpacing = 8.0
									};
									val6.ColumnDefinitions.Add(new ColumnDefinition
									{
										Width = GridLength.Auto
									});
									val6.ColumnDefinitions.Add(new ColumnDefinition
									{
										Width = new GridLength(1.0, (GridUnitType)2)
									});
									((Panel)val6).Children.Add((UIElement)new TextBlock
									{
										Text = "•",
										VerticalAlignment = (VerticalAlignment)0
									});
									TextBlock val7 = new TextBlock
									{
										Text = current,
										TextWrapping = (TextWrapping)2,
										IsTextSelectionEnabled = true
									};
									Grid.SetColumn((FrameworkElement)(object)val7, 1);
									((Panel)val6).Children.Add((UIElement)(object)val7);
									((Panel)val5).Children.Add((UIElement)(object)val6);
								}
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								}
							}
							((Panel)val3).Children.Add((UIElement)(object)val5);
						}
						((Panel)val).Children.Add((UIElement)(object)val3);
						if (i < ((global::System.Collections.Generic.IReadOnlyCollection<d2iiUHfOLr9ZvQq4WHMC>)entries).Count - 1)
						{
							((Panel)val).Children.Add((UIElement)new Border
							{
								Height = 1.0,
								Background = default(Brush)
							});
						}
					}
					val8 = new ContentDialog
					{
						XamlRoot = xamlRoot,
						RequestedTheme = AppearanceSettings.Theme,
						Title = (string.IsNullOrWhiteSpace(title) ? "更新日志" : title),
						Content = (object)new ScrollViewer
						{
							Content = val,
							MaxHeight = 520.0,
							VerticalScrollBarVisibility = (ScrollBarVisibility)1,
							HorizontalScrollBarVisibility = (ScrollBarVisibility)0
						},
						PrimaryButtonText = "知道了",
						DefaultButton = (ContentDialogButton)1
					};
					goto IL_03cb;
				}
				goto end_IL_000a;
				IL_03cb:
					val8 = default;
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(val8.ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ShowAsync_d__0>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
				}
				catch (global::System.Exception)
				{
				}
				end_IL_000a:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task ShowAsync(XamlRoot? xamlRoot, global::System.Collections.Generic.IReadOnlyList<d2iiUHfOLr9ZvQq4WHMC> entries, string title)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowAsync_d__0 showAsync_d__ = default(_ShowAsync_d__0);
		showAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showAsync_d__.xamlRoot = xamlRoot;
		showAsync_d__.entries = entries;
		showAsync_d__.title = title;
		showAsync_d__.__1__state = -1;
		showAsync_d__.__t__builder.Start<_ShowAsync_d__0>(ref showAsync_d__);
		return showAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

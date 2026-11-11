using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using Markdig;
using Markdig.Helpers;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Windows.System;
using Windows.UI;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views;

public static class AnnouncementMarkdownRenderer
{
	private sealed class RenderPalette : IEquatable<RenderPalette>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				return typeof(global::Mahiro_Account.Views.AnnouncementMarkdownRenderer.RenderPalette);
			}
		}

		[CompilerGenerated]
		private SolidColorBrush _TextBrush_k__BackingField;
		public SolidColorBrush TextBrush
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _TextBrush_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
			{
				_TextBrush_k__BackingField = value;
			}
		}

		[CompilerGenerated]
		private SolidColorBrush _MutedBrush_k__BackingField;
		public SolidColorBrush MutedBrush
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _MutedBrush_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
			{
				_MutedBrush_k__BackingField = value;
			}
		}

		[CompilerGenerated]
		private SolidColorBrush _CodeBackgroundBrush_k__BackingField;
		public SolidColorBrush CodeBackgroundBrush
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _CodeBackgroundBrush_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
			{
				_CodeBackgroundBrush_k__BackingField = value;
			}
		}

		[CompilerGenerated]
		private SolidColorBrush _CodeBorderBrush_k__BackingField;
		public SolidColorBrush CodeBorderBrush
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _CodeBorderBrush_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
			{
				_CodeBorderBrush_k__BackingField = value;
			}
		}

		[CompilerGenerated]
		private SolidColorBrush _CodeTextBrush_k__BackingField;
		public SolidColorBrush CodeTextBrush
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _CodeTextBrush_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
			{
				_CodeTextBrush_k__BackingField = value;
			}
		}

		[CompilerGenerated]
		private SolidColorBrush _AccentBrush_k__BackingField;
		public SolidColorBrush AccentBrush
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _AccentBrush_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			init
			{
				_AccentBrush_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public RenderPalette(SolidColorBrush TextBrush, SolidColorBrush MutedBrush, SolidColorBrush CodeBackgroundBrush, SolidColorBrush CodeBorderBrush, SolidColorBrush CodeTextBrush, SolidColorBrush AccentBrush)
		{
			_TextBrush_k__BackingField = TextBrush;
			_MutedBrush_k__BackingField = MutedBrush;
			_CodeBackgroundBrush_k__BackingField = CodeBackgroundBrush;
			_CodeBorderBrush_k__BackingField = CodeBorderBrush;
			_CodeTextBrush_k__BackingField = CodeTextBrush;
			_AccentBrush_k__BackingField = AccentBrush;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append("RenderPalette");
			val.Append(" { ");
			if (PrintMembers(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("TextBrush = ");
			builder.Append((object)TextBrush);
			builder.Append(", MutedBrush = ");
			builder.Append((object)MutedBrush);
			builder.Append(", CodeBackgroundBrush = ");
			builder.Append((object)CodeBackgroundBrush);
			builder.Append(", CodeBorderBrush = ");
			builder.Append((object)CodeBorderBrush);
			builder.Append(", CodeTextBrush = ");
			builder.Append((object)CodeTextBrush);
			builder.Append(", AccentBrush = ");
			builder.Append((object)AccentBrush);
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(RenderPalette? left, RenderPalette? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(RenderPalette? left, RenderPalette? right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<SolidColorBrush>.Default.GetHashCode(_TextBrush_k__BackingField)) * -1521134295 + EqualityComparer<SolidColorBrush>.Default.GetHashCode(_MutedBrush_k__BackingField)) * -1521134295 + EqualityComparer<SolidColorBrush>.Default.GetHashCode(_CodeBackgroundBrush_k__BackingField)) * -1521134295 + EqualityComparer<SolidColorBrush>.Default.GetHashCode(_CodeBorderBrush_k__BackingField)) * -1521134295 + EqualityComparer<SolidColorBrush>.Default.GetHashCode(_CodeTextBrush_k__BackingField)) * -1521134295 + EqualityComparer<SolidColorBrush>.Default.GetHashCode(_AccentBrush_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as RenderPalette);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(RenderPalette? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<SolidColorBrush>.Default.Equals(_TextBrush_k__BackingField, other._TextBrush_k__BackingField) && EqualityComparer<SolidColorBrush>.Default.Equals(_MutedBrush_k__BackingField, other._MutedBrush_k__BackingField) && EqualityComparer<SolidColorBrush>.Default.Equals(_CodeBackgroundBrush_k__BackingField, other._CodeBackgroundBrush_k__BackingField) && EqualityComparer<SolidColorBrush>.Default.Equals(_CodeBorderBrush_k__BackingField, other._CodeBorderBrush_k__BackingField) && EqualityComparer<SolidColorBrush>.Default.Equals(_CodeTextBrush_k__BackingField, other._CodeTextBrush_k__BackingField))
				{
					return EqualityComparer<SolidColorBrush>.Default.Equals(_AccentBrush_k__BackingField, other._AccentBrush_k__BackingField);
				}
				return false;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public RenderPalette _Clone__()
		{
			return (RenderPalette)new RenderPalette(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private RenderPalette(RenderPalette original)
		{
			_TextBrush_k__BackingField = original._TextBrush_k__BackingField;
			_MutedBrush_k__BackingField = original._MutedBrush_k__BackingField;
			_CodeBackgroundBrush_k__BackingField = original._CodeBackgroundBrush_k__BackingField;
			_CodeBorderBrush_k__BackingField = original._CodeBorderBrush_k__BackingField;
			_CodeTextBrush_k__BackingField = original._CodeTextBrush_k__BackingField;
			_AccentBrush_k__BackingField = original._AccentBrush_k__BackingField;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void Deconstruct(out SolidColorBrush TextBrush, out SolidColorBrush MutedBrush, out SolidColorBrush CodeBackgroundBrush, out SolidColorBrush CodeBorderBrush, out SolidColorBrush CodeTextBrush, out SolidColorBrush AccentBrush)
		{
			//IL_000b: Expected I8, but got O
			//IL_0013: Expected I8, but got O
			//IL_001b: Expected I8, but got O
			//IL_0024: Expected I8, but got O
			//IL_002d: Expected I8, but got O
			//IL_0036: Expected I8, but got O
			TextBrush = (SolidColorBrush)this.TextBrush;
			MutedBrush = (SolidColorBrush)this.MutedBrush;
			CodeBackgroundBrush = (SolidColorBrush)this.CodeBackgroundBrush;
			CodeBorderBrush = (SolidColorBrush)this.CodeBorderBrush;
			CodeTextBrush = (SolidColorBrush)this.CodeTextBrush;
			AccentBrush = (SolidColorBrush)this.AccentBrush;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class __c__DisplayClass9_0_4
	{
		[StructLayout((LayoutKind)3)]
		internal struct __AddLink_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public __c__DisplayClass9_0_4 __4__this;

			private TaskAwaiter<bool> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass9_0_4 _c__DisplayClass9_0_ = __4__this;
				try
				{
					try
					{
						TaskAwaiter<bool> _u__ = default;
						if (num != 0)
						{
							_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(_c__DisplayClass9_0_.uri));
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __AddLink_b__0_d>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						_u__.GetResult();
					}
					catch (global::System.Exception)
					{
					}
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

		public Uri uri;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0_4()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _AddLink_b__0(Hyperlink _, HyperlinkClickEventArgs _2)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__AddLink_b__0_d _AddLink_b__0_d = default(__AddLink_b__0_d);
			_AddLink_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_AddLink_b__0_d.__4__this = this;
			_AddLink_b__0_d.__1__state = -1;
			_AddLink_b__0_d.__t__builder.Start<__AddLink_b__0_d>(ref _AddLink_b__0_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private static readonly MarkdownPipeline Pipeline;

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static StackPanel CreateView(string markdown, bool isDarkTheme)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		RenderPalette palette = CreatePalette(isDarkTheme);
		StackPanel val = new StackPanel
		{
			Spacing = 9.0
		};
		MarkdownDocument val2;
		try
		{
			val2 = Markdown.Parse(markdown ?? string.Empty, Pipeline, (MarkdownParserContext)null);
		}
		catch (global::System.Exception)
		{
			((Panel)val).Children.Add((UIElement)(object)CreatePlainText(markdown ?? string.Empty, palette));
			return val;
		}
		var enumerator = ((ContainerBlock)val2).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Markdig.Syntax.Block current = enumerator.Current;
				AddBlock(val, current, 0, palette);
			}
		}
		finally
		{
			((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
		}
		if (((Panel)val).Children.Count == 0)
		{
			((Panel)val).Children.Add((UIElement)(object)CreatePlainText(string.Empty, palette));
		}
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void AddBlock(StackPanel target, Markdig.Syntax.Block block, int depth, RenderPalette palette)
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if (block is HtmlBlock)
		{
			return;
		}
		HeadingBlock val = (HeadingBlock)(object)((block is HeadingBlock) ? block : null);
		if (val == null)
		{
			ParagraphBlock val2 = (ParagraphBlock)(object)((block is ParagraphBlock) ? block : null);
			if (val2 == null)
			{
				ListBlock val3 = (ListBlock)(object)((block is ListBlock) ? block : null);
				if (val3 == null)
				{
					FencedCodeBlock val4 = (FencedCodeBlock)(object)((block is FencedCodeBlock) ? block : null);
					if (val4 == null)
					{
						CodeBlock val5 = (CodeBlock)(object)((block is CodeBlock) ? block : null);
						if (val5 == null)
						{
							QuoteBlock val6 = (QuoteBlock)(object)((block is QuoteBlock) ? block : null);
							if (val6 == null)
							{
								if (!(block is ThematicBreakBlock))
								{
									ContainerBlock val7 = (ContainerBlock)(object)((block is ContainerBlock) ? block : null);
									if (val7 != null)
									{
										var enumerator = val7.GetEnumerator();
										try
										{
											while (enumerator.MoveNext())
											{
												Markdig.Syntax.Block current = enumerator.Current;
												AddBlock(target, current, depth, palette);
											}
											return;
										}
										finally
										{
											((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
										}
									}
									LeafBlock val8 = (LeafBlock)(object)((block is LeafBlock) ? block : null);
									if (val8 != null)
									{
										((Panel)target).Children.Add((UIElement)(object)CreatePlainText(((object)global::System.Runtime.CompilerServices.Unsafe.As<StringLineGroup, StringLineGroup>(ref val8.Lines)/*cast due to .constrained prefix*/).ToString(), palette));
									}
								}
								else
								{
									((Panel)target).Children.Add((UIElement)new Border
									{
										Height = 1.0,
										Background = (Brush)(object)palette.CodeBorderBrush,
										Margin = new Thickness(0.0, 4.0, 0.0, 4.0)
									});
								}
							}
							else
							{
								AddQuote(target, val6, depth, palette);
							}
						}
						else
						{
							((Panel)target).Children.Add((UIElement)(object)CreateCodeBlock(((object)global::System.Runtime.CompilerServices.Unsafe.As<StringLineGroup, StringLineGroup>(ref ((LeafBlock)val5).Lines)/*cast due to .constrained prefix*/).ToString(), palette));
						}
					}
					else
					{
						((Panel)target).Children.Add((UIElement)(object)CreateCodeBlock(((object)global::System.Runtime.CompilerServices.Unsafe.As<StringLineGroup, StringLineGroup>(ref ((LeafBlock)val4).Lines)/*cast due to .constrained prefix*/).ToString(), palette));
					}
				}
				else
				{
					AddList(target, val3, depth, palette);
				}
			}
			else
			{
				((Panel)target).Children.Add((UIElement)(object)CreateRichText(((LeafBlock)val2).Inline, 14.0, heading: false, palette));
			}
		}
		else
		{
			((Panel)target).Children.Add((UIElement)(object)CreateRichText(((LeafBlock)val).Inline, Math.Max(17, 25 - val.Level * 2), heading: true, palette));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void AddList(StackPanel target, ListBlock list, int depth, RenderPalette palette)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		string text = list.OrderedStart;
		var enumerator = ((ContainerBlock)list).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Markdig.Syntax.Block current = enumerator.Current;
				ListItemBlock val = (ListItemBlock)(object)((current is ListItemBlock) ? current : null);
				if (val == null)
				{
					continue;
				}
				Grid val2 = new Grid
				{
					ColumnSpacing = 8.0,
					Margin = new Thickness((double)(Math.Min(depth, 3) * 14), 0.0, 0.0, 0.0)
				};
				val2.ColumnDefinitions.Add(new ColumnDefinition
				{
					Width = GridLength.Auto
				});
				val2.ColumnDefinitions.Add(new ColumnDefinition
				{
					Width = new GridLength(1.0, (GridUnitType)2)
				});
				((Panel)val2).Children.Add((UIElement)new TextBlock
				{
					Text = (list.IsOrdered ? (text + ".") : "•"),
					Foreground = (Brush)(object)palette.MutedBrush,
					FontSize = 14.0,
					Margin = new Thickness(0.0, 1.0, 0.0, 0.0)
				});
				StackPanel val3 = new StackPanel
				{
					Spacing = 6.0
				};
				Grid.SetColumn((FrameworkElement)(object)val3, 1);
				var enumerator2 = ((ContainerBlock)val).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						Markdig.Syntax.Block current2 = enumerator2.Current;
						AddBlock(val3, current2, depth + 1, palette);
					}
				}
				finally
				{
					((global::System.IDisposable)(enumerator2)/*cast due to .constrained prefix*/).Dispose();
				}
				((Panel)val2).Children.Add((UIElement)(object)val3);
				((Panel)target).Children.Add((UIElement)(object)val2);
				text += 1;
			}
		}
		finally
		{
			((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void AddQuote(StackPanel target, QuoteBlock quote, int depth, RenderPalette palette)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		StackPanel val = new StackPanel
		{
			Spacing = 6.0
		};
		var enumerator = ((ContainerBlock)quote).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Markdig.Syntax.Block current = enumerator.Current;
				AddBlock(val, current, depth + 1, palette);
			}
		}
		finally
		{
			((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
		}
		((Panel)target).Children.Add((UIElement)new Border
		{
			BorderBrush = (Brush)(object)palette.AccentBrush,
			BorderThickness = new Thickness(3.0, 0.0, 0.0, 0.0),
			Padding = new Thickness(12.0, 3.0, 0.0, 3.0),
			Child = (UIElement)(object)val
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	private static RichTextBlock CreateRichText(ContainerInline? container, double fontSize, bool heading, RenderPalette palette)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		RichTextBlock val = new RichTextBlock
		{
			FontSize = fontSize,
			FontWeight = (heading ? FontWeights.SemiBold : FontWeights.Normal),
			Foreground = (Brush)(object)palette.TextBrush,
			TextWrapping = (TextWrapping)2,
			IsTextSelectionEnabled = true
		};
		Paragraph val2 = new Paragraph();
		AppendInlines(val2.Inlines, container, palette);
		val.Blocks.Add((Microsoft.UI.Xaml.Documents.Block)(object)val2);
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static TextBlock CreatePlainText(string text, RenderPalette palette)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		return new TextBlock
		{
			Text = text,
			FontSize = 14.0,
			Foreground = (Brush)(object)palette.TextBrush,
			TextWrapping = (TextWrapping)2,
			IsTextSelectionEnabled = true
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Border CreateCodeBlock(string text, RenderPalette palette)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Expected O, but got Unknown
		return new Border
		{
			Background = (Brush)(object)palette.CodeBackgroundBrush,
			BorderBrush = (Brush)(object)palette.CodeBorderBrush,
			BorderThickness = new Thickness(1.0),
			CornerRadius = new CornerRadius(4.0),
			Padding = new Thickness(12.0, 9.0, 12.0, 9.0),
			Child = (UIElement)new TextBlock
			{
				Text = text,
				FontFamily = new FontFamily("Consolas"),
				FontSize = 13.0,
				Foreground = (Brush)(object)palette.TextBrush,
				TextWrapping = (TextWrapping)2,
				IsTextSelectionEnabled = true
			}
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void AppendInlines(InlineCollection target, ContainerInline? container, RenderPalette palette)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		for (Markdig.Syntax.Inlines.Inline val = ((container != null) ? container.FirstChild : null); val != null; val = val.NextSibling)
		{
			Markdig.Syntax.Inlines.Inline val2 = val;
			LiteralInline val3 = (LiteralInline)(object)((val2 is LiteralInline) ? val2 : null);
			if (val3 == null)
			{
				if (!(val2 is LineBreakInline))
				{
					CodeInline val4 = (CodeInline)(object)((val2 is CodeInline) ? val2 : null);
					if (val4 == null)
					{
						EmphasisInline val5 = (EmphasisInline)(object)((val2 is EmphasisInline) ? val2 : null);
						if (val5 == null)
						{
							LinkInline val6 = (LinkInline)(object)((val2 is LinkInline) ? val2 : null);
							ContainerInline val7;
							if (val6 == null)
							{
								if (val2 is HtmlInline)
								{
									continue;
								}
								val7 = (ContainerInline)(object)((val2 is ContainerInline) ? val2 : null);
								if (val7 == null)
								{
									continue;
								}
							}
							else
							{
								if (!val6.IsImage)
								{
									AddLink(target, val6, palette);
									continue;
								}
								LinkInline val8 = val6;
								if (val8.IsImage)
								{
									AppendInlines(target, (ContainerInline?)(object)val8, palette);
									continue;
								}
								val7 = (ContainerInline)val2;
							}
							AppendInlines(target, val7, palette);
						}
						else
						{
							Span val9 = (Span)((val5.DelimiterCount >= 2) ? new Bold() : new Italic());
							AppendInlines(val9.Inlines, (ContainerInline?)(object)val5, palette);
							target.Add((Microsoft.UI.Xaml.Documents.Inline)(object)val9);
						}
					}
					else
					{
						target.Add((Microsoft.UI.Xaml.Documents.Inline)new Run
						{
							Text = val4.Content,
							FontFamily = new FontFamily("Consolas"),
							Foreground = (Brush)(object)palette.CodeTextBrush
						});
					}
				}
				else
				{
					target.Add((Microsoft.UI.Xaml.Documents.Inline)new LineBreak());
				}
			}
			else
			{
				target.Add((Microsoft.UI.Xaml.Documents.Inline)new Run
				{
					Text = ((object)global::System.Runtime.CompilerServices.Unsafe.As<StringSlice, StringSlice>(ref val3.Content)/*cast due to .constrained prefix*/).ToString()
				});
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void AddLink(InlineCollection target, LinkInline link, RenderPalette palette)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		__c__DisplayClass9_0_4 __8_locals3 = (__c__DisplayClass9_0_4)new __c__DisplayClass9_0_4();
		if (!Uri.TryCreate(link.Url, (UriKind)1, out __8_locals3.uri) || __8_locals3.uri.Scheme != Uri.UriSchemeHttps)
		{
			AppendInlines(target, (ContainerInline?)(object)link, palette);
			return;
		}
		Hyperlink val = new Hyperlink();
		AppendInlines(((Span)val).Inlines, (ContainerInline?)(object)link, palette);
		val.Click += [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] (Hyperlink _, HyperlinkClickEventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__c__DisplayClass9_0_4.__AddLink_b__0_d _AddLink_b__0_d = default(__c__DisplayClass9_0_4.__AddLink_b__0_d);
			_AddLink_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_AddLink_b__0_d.__4__this = __8_locals3;
			_AddLink_b__0_d.__1__state = -1;
			_AddLink_b__0_d.__t__builder.Start<__c__DisplayClass9_0_4.__AddLink_b__0_d>(ref _AddLink_b__0_d);
		};
		target.Add((Microsoft.UI.Xaml.Documents.Inline)(object)val);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static RenderPalette CreatePalette(bool isDarkTheme)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014c: Expected O, but got Unknown
		//IL_014c: Expected O, but got Unknown
		//IL_014c: Expected O, but got Unknown
		//IL_014c: Expected O, but got Unknown
		//IL_014c: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Expected O, but got Unknown
		if (!isDarkTheme)
		{
			return (RenderPalette)new RenderPalette(new SolidColorBrush(Color.FromArgb((byte)255, (byte)31, (byte)31, (byte)31)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)102, (byte)102, (byte)102)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)244, (byte)244, (byte)246)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)218, (byte)218, (byte)222)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)92, (byte)45, (byte)145)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)103, (byte)58, (byte)183)));
		}
		return (RenderPalette)new RenderPalette(new SolidColorBrush(Color.FromArgb((byte)255, (byte)245, (byte)245, (byte)245)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)184, (byte)184, (byte)184)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)35, (byte)35, (byte)35)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)74, (byte)74, (byte)74)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)216, (byte)201, (byte)255)), new SolidColorBrush(Color.FromArgb((byte)255, (byte)182, (byte)156, (byte)255)));
	}

	[MethodImpl((MethodImplOptions)8)]
	static AnnouncementMarkdownRenderer()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Pipeline = new MarkdownPipelineBuilder().Build();
	}
}

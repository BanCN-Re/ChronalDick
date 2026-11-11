using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Navigation;

internal sealed class NavigationEntry : IEquatable<NavigationEntry>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return typeof(global::Mahiro_Account.UI.Navigation.NavigationEntry);
		}
	}

	[field: CompilerGenerated]
	private string _Key_k__BackingField;

	public string Key
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private string _Title_k__BackingField;

	public string Title
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private string _Glyph_k__BackingField;

	public string Glyph
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private global::System.Type _PageType_k__BackingField;

	public global::System.Type PageType
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[MethodImpl((MethodImplOptions)8)]
	public NavigationEntry(string Key, string Title, string Glyph, global::System.Type PageType)
	{
		_Key_k__BackingField = Key;
		_Title_k__BackingField = Title;
		_Glyph_k__BackingField = Glyph;
		_PageType_k__BackingField = PageType;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append("NavigationEntry");
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
		builder.Append("Key = ");
		builder.Append((object)Key);
		builder.Append(", Title = ");
		builder.Append((object)Title);
		builder.Append(", Glyph = ");
		builder.Append((object)Glyph);
		builder.Append(", PageType = ");
		builder.Append((object)PageType);
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(NavigationEntry? left, NavigationEntry? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(NavigationEntry? left, NavigationEntry? right)
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
		return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Key_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Title_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Glyph_k__BackingField)) * -1521134295 + EqualityComparer<global::System.Type>.Default.GetHashCode(_PageType_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as NavigationEntry);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(NavigationEntry? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(_Key_k__BackingField, ((dynamic)other)._Key_k__BackingField) && EqualityComparer<string>.Default.Equals(_Title_k__BackingField, ((dynamic)other)._Title_k__BackingField) && EqualityComparer<string>.Default.Equals(_Glyph_k__BackingField, ((dynamic)other)._Glyph_k__BackingField))
			{
				return EqualityComparer<global::System.Type>.Default.Equals(_PageType_k__BackingField, (((dynamic)other)._PageType_k__BackingField));
			}
			return false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public NavigationEntry _Clone__()
	{
		return (NavigationEntry)new NavigationEntry(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private NavigationEntry(NavigationEntry original)
	{
		_Key_k__BackingField = ((dynamic)original)._Key_k__BackingField;
		_Title_k__BackingField = ((dynamic)original)._Title_k__BackingField;
		_Glyph_k__BackingField = ((dynamic)original)._Glyph_k__BackingField;
		_PageType_k__BackingField = ((dynamic)original)._PageType_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void Deconstruct(out string Key, out string Title, out string Glyph, out global::System.Type PageType)
	{
		//IL_000b: Expected I8, but got O
		//IL_0013: Expected I8, but got O
		//IL_001b: Expected I8, but got O
		//IL_0024: Expected I8, but got O
		Key = default;
		Title = default;
		Glyph = default;
		PageType = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

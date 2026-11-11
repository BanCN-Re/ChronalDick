using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal sealed class DesktopFileTypeChoice : IEquatable<DesktopFileTypeChoice>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return typeof(global::Mahiro_Account.UI.DesktopFileTypeChoice);
		}
	}

	private string _DisplayName_k__BackingField;
	[field: CompilerGenerated]
	public string DisplayName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	private global::System.Collections.Generic.IReadOnlyList<string> _Extensions_k__BackingField;
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<string> Extensions
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[MethodImpl((MethodImplOptions)8)]
	public DesktopFileTypeChoice(string DisplayName, global::System.Collections.Generic.IReadOnlyList<string> Extensions)
	{
		_DisplayName_k__BackingField = DisplayName;
		_Extensions_k__BackingField = Extensions;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append("DesktopFileTypeChoice");
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
		builder.Append("DisplayName = ");
		builder.Append((object)DisplayName);
		builder.Append(", Extensions = ");
		builder.Append((object)Extensions);
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(DesktopFileTypeChoice? left, DesktopFileTypeChoice? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(DesktopFileTypeChoice? left, DesktopFileTypeChoice? right)
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
		return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_DisplayName_k__BackingField)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(_Extensions_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as DesktopFileTypeChoice);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(DesktopFileTypeChoice? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(_DisplayName_k__BackingField, ((dynamic)other)._DisplayName_k__BackingField))
			{
				return EqualityComparer<global::System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(_Extensions_k__BackingField, (((dynamic)other)._Extensions_k__BackingField));
			}
			return false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public DesktopFileTypeChoice _Clone__()
	{
		return (DesktopFileTypeChoice)new DesktopFileTypeChoice(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private DesktopFileTypeChoice(DesktopFileTypeChoice original)
	{
		_DisplayName_k__BackingField = ((dynamic)original)._DisplayName_k__BackingField;
		_Extensions_k__BackingField = ((dynamic)original)._Extensions_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void Deconstruct(out string DisplayName, out global::System.Collections.Generic.IReadOnlyList<string> Extensions)
	{
		//IL_000b: Expected I8, but got O
		//IL_0013: Expected I8, but got O
		DisplayName = default;
		Extensions = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

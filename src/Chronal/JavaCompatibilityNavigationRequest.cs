using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Java;

internal sealed class JavaCompatibilityNavigationRequest : IEquatable<JavaCompatibilityNavigationRequest>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return typeof(global::Mahiro_Account.Views.Pages.Java.JavaCompatibilityNavigationRequest);
		}
	}

	private JavaCompatibilityDestination _Destination_k__BackingField;
	[field: CompilerGenerated]
	public JavaCompatibilityDestination Destination
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaCompatibilityNavigationRequest(JavaCompatibilityDestination Destination)
	{
		_Destination_k__BackingField = Destination;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append("JavaCompatibilityNavigationRequest");
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
		builder.Append("Destination = ");
		builder.Append(((object)Destination/*cast due to .constrained prefix*/).ToString());
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(JavaCompatibilityNavigationRequest? left, JavaCompatibilityNavigationRequest? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(JavaCompatibilityNavigationRequest? left, JavaCompatibilityNavigationRequest? right)
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
		return EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<JavaCompatibilityDestination>.Default.GetHashCode(_Destination_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as JavaCompatibilityNavigationRequest);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(JavaCompatibilityNavigationRequest? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract)
			{
				return EqualityComparer<JavaCompatibilityDestination>.Default.Equals(_Destination_k__BackingField, (((dynamic)other)._Destination_k__BackingField));
			}
			return false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public JavaCompatibilityNavigationRequest _Clone__()
	{
		return (JavaCompatibilityNavigationRequest)new JavaCompatibilityNavigationRequest(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private JavaCompatibilityNavigationRequest(JavaCompatibilityNavigationRequest original)
	{
		_Destination_k__BackingField = ((dynamic)original)._Destination_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void Deconstruct(out JavaCompatibilityDestination Destination)
	{
		Destination = this.Destination;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

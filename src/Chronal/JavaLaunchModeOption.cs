using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using O7oSQyfxiUTrhAE02s2Q;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Java;

internal sealed class JavaLaunchModeOption : IEquatable<JavaLaunchModeOption>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return typeof(global::Mahiro_Account.Views.Pages.Java.JavaLaunchModeOption);
		}
	}

	[field: CompilerGenerated]
	private r9S4FZfxG0478bdNv59r _Mode_k__BackingField;

	[field: CompilerGenerated]
	public r9S4FZfxG0478bdNv59r Mode
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

	[field: CompilerGenerated]
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
	private string _Description_k__BackingField;

	[field: CompilerGenerated]
	public string Description
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private static global::System.Collections.Generic.IReadOnlyList<JavaLaunchModeOption> _All_k__BackingField;

	[field: CompilerGenerated]
	internal static global::System.Collections.Generic.IReadOnlyList<JavaLaunchModeOption> All
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaLaunchModeOption(r9S4FZfxG0478bdNv59r Mode, string Title, string Description)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_Mode_k__BackingField = Mode;
		_Title_k__BackingField = Title;
		_Description_k__BackingField = Description;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append("JavaLaunchModeOption");
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
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.EnsureSufficientExecutionStack();
		builder.Append("Mode = ");
		builder.Append(((object)Mode/*cast due to .constrained prefix*/).ToString());
		builder.Append(", Title = ");
		builder.Append((object)Title);
		builder.Append(", Description = ");
		builder.Append((object)Description);
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(JavaLaunchModeOption? left, JavaLaunchModeOption? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(JavaLaunchModeOption? left, JavaLaunchModeOption? right)
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
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<r9S4FZfxG0478bdNv59r>.Default.GetHashCode(_Mode_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Title_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Description_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as JavaLaunchModeOption);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(JavaLaunchModeOption? other)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<r9S4FZfxG0478bdNv59r>.Default.Equals(_Mode_k__BackingField, ((dynamic)other)._Mode_k__BackingField) && EqualityComparer<string>.Default.Equals(_Title_k__BackingField, ((dynamic)other)._Title_k__BackingField))
			{
				return EqualityComparer<string>.Default.Equals(_Description_k__BackingField, (((dynamic)other)._Description_k__BackingField));
			}
			return false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public JavaLaunchModeOption _Clone__()
	{
		return (JavaLaunchModeOption)new JavaLaunchModeOption(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private JavaLaunchModeOption(JavaLaunchModeOption original)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_Mode_k__BackingField = ((dynamic)original)._Mode_k__BackingField;
		_Title_k__BackingField = ((dynamic)original)._Title_k__BackingField;
		_Description_k__BackingField = ((dynamic)original)._Description_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void Deconstruct(out r9S4FZfxG0478bdNv59r Mode, out string Title, out string Description)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I8, but got O
		//IL_001b: Expected I8, but got O
		Mode = this.Mode;
		Title = default;
		Description = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		_All_k__BackingField = new global::__z__ReadOnlyArray_1<JavaLaunchModeOption>(new JavaLaunchModeOption[2]
		{
			(JavaLaunchModeOption)new JavaLaunchModeOption((r9S4FZfxG0478bdNv59r)0, "外部客户端", "默认模式：建立本机入口后，在你自己的 Java 客户端中连接显示的地址。"),
			(JavaLaunchModeOption)new JavaLaunchModeOption((r9S4FZfxG0478bdNv59r)1, "官方客户端", "由后台宿主启动官方客户端；透明回环入口不会开放给外部客户端。")
		});
	}
}

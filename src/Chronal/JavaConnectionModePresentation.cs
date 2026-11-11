using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using O7oSQyfxiUTrhAE02s2Q;
using WP2chpfxfiuBSYyeOFWV;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Java;

internal sealed class JavaConnectionModePresentation : IEquatable<JavaConnectionModePresentation>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return typeof(global::Mahiro_Account.Views.Pages.Java.JavaConnectionModePresentation);
		}
	}

	[field: CompilerGenerated]
	private string _EntryTitle_k__BackingField;
	public string EntryTitle
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private string _ActionTitle_k__BackingField;
	public string ActionTitle
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private string _ActionAutomationName_k__BackingField;
	public string ActionAutomationName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private string _StartingMessage_k__BackingField;
	public string StartingMessage
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private bool _ShowsUserPort_k__BackingField;
	public bool ShowsUserPort
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaConnectionModePresentation(string EntryTitle, string ActionTitle, string ActionAutomationName, string StartingMessage, bool ShowsUserPort)
	{
		_EntryTitle_k__BackingField = EntryTitle;
		_ActionTitle_k__BackingField = ActionTitle;
		_ActionAutomationName_k__BackingField = ActionAutomationName;
		_StartingMessage_k__BackingField = StartingMessage;
		_ShowsUserPort_k__BackingField = ShowsUserPort;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JavaConnectionModePresentation For(r9S4FZfxG0478bdNv59r mode)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if ((int)mode != 0)
		{
			if ((int)mode == 1)
			{
				return (JavaConnectionModePresentation)new JavaConnectionModePresentation("官方客户端连接", "使用官方客户端启动", "使用官方 Java 客户端启动", "正在准备官方客户端连接", ShowsUserPort: false);
			}
			throw new ArgumentOutOfRangeException("mode", "Java 连接模式无效");
		}
		return (JavaConnectionModePresentation)new JavaConnectionModePresentation("外部客户端本机入口", "建立本机入口", "建立 Java 本机入口", "正在准备 Java 本机连接入口", ShowsUserPort: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool CanCopyLocalAddress(qC3ZV7fxXAJqu2TjY3Nc snapshot)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if ((int)snapshot.Mode == 0)
		{
			return snapshot.HasLocalEndpoint;
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append("JavaConnectionModePresentation");
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
		builder.Append("EntryTitle = ");
		builder.Append((object)EntryTitle);
		builder.Append(", ActionTitle = ");
		builder.Append((object)ActionTitle);
		builder.Append(", ActionAutomationName = ");
		builder.Append((object)ActionAutomationName);
		builder.Append(", StartingMessage = ");
		builder.Append((object)StartingMessage);
		builder.Append(", ShowsUserPort = ");
		builder.Append(((object)ShowsUserPort/*cast due to .constrained prefix*/).ToString());
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(JavaConnectionModePresentation? left, JavaConnectionModePresentation? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(JavaConnectionModePresentation? left, JavaConnectionModePresentation? right)
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
		return ((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_EntryTitle_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_ActionTitle_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_ActionAutomationName_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_StartingMessage_k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_ShowsUserPort_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as JavaConnectionModePresentation);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(JavaConnectionModePresentation? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(_EntryTitle_k__BackingField, ((dynamic)other)._EntryTitle_k__BackingField) && EqualityComparer<string>.Default.Equals(_ActionTitle_k__BackingField, ((dynamic)other)._ActionTitle_k__BackingField) && EqualityComparer<string>.Default.Equals(_ActionAutomationName_k__BackingField, ((dynamic)other)._ActionAutomationName_k__BackingField) && EqualityComparer<string>.Default.Equals(_StartingMessage_k__BackingField, ((dynamic)other)._StartingMessage_k__BackingField))
			{
				return EqualityComparer<bool>.Default.Equals(_ShowsUserPort_k__BackingField, (((dynamic)other)._ShowsUserPort_k__BackingField));
			}
			return false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public JavaConnectionModePresentation _Clone__()
	{
		return (JavaConnectionModePresentation)new JavaConnectionModePresentation(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private JavaConnectionModePresentation(JavaConnectionModePresentation original)
	{
		_EntryTitle_k__BackingField = ((dynamic)original)._EntryTitle_k__BackingField;
		_ActionTitle_k__BackingField = ((dynamic)original)._ActionTitle_k__BackingField;
		_ActionAutomationName_k__BackingField = ((dynamic)original)._ActionAutomationName_k__BackingField;
		_StartingMessage_k__BackingField = ((dynamic)original)._StartingMessage_k__BackingField;
		_ShowsUserPort_k__BackingField = ((dynamic)original)._ShowsUserPort_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void Deconstruct(out string EntryTitle, out string ActionTitle, out string ActionAutomationName, out string StartingMessage, out bool ShowsUserPort)
	{
		//IL_000b: Expected I8, but got O
		//IL_0013: Expected I8, but got O
		//IL_001b: Expected I8, but got O
		//IL_0024: Expected I8, but got O
		//IL_002d: Expected F4, but got I4
		EntryTitle = default;
		ActionTitle = default;
		ActionAutomationName = default;
		StartingMessage = default;
		ShowsUserPort = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

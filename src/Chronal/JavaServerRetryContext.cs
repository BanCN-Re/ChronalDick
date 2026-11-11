using System;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using O7oSQyfxiUTrhAE02s2Q;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Java;

internal sealed class JavaServerRetryContext
{
	private static JavaServerRetryContext _None_k__BackingField;
	[field: CompilerGenerated]
	internal static JavaServerRetryContext None
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private static JavaServerRetryContext _ManagedClient_k__BackingField;
	[field: CompilerGenerated]
	internal static JavaServerRetryContext ManagedClient
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private JavaServerRetryKind _Kind_k__BackingField;
	[field: CompilerGenerated]
	internal JavaServerRetryKind Kind
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private r9S4FZfxG0478bdNv59r? _ConnectionMode_k__BackingField;
	[field: CompilerGenerated]
	internal r9S4FZfxG0478bdNv59r? ConnectionMode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private string _ButtonTitle_k__BackingField;
	[field: CompilerGenerated]
	internal string ButtonTitle
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	internal bool CanRetry
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Kind != JavaServerRetryKind.None;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private JavaServerRetryContext(JavaServerRetryKind kind, r9S4FZfxG0478bdNv59r? connectionMode, string buttonTitle)
	{
		_Kind_k__BackingField = kind;
		_ConnectionMode_k__BackingField = connectionMode;
		_ButtonTitle_k__BackingField = buttonTitle;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JavaServerRetryContext ForCoordinatedConnection(r9S4FZfxG0478bdNv59r mode)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)mode != 0)
		{
			if ((int)mode == 1)
			{
				return (JavaServerRetryContext)new JavaServerRetryContext(JavaServerRetryKind.CoordinatedConnection, (r9S4FZfxG0478bdNv59r?)mode, "重试官方客户端");
			}
			throw new ArgumentOutOfRangeException("mode", "Java 连接模式无效");
		}
		return (JavaServerRetryContext)new JavaServerRetryContext(JavaServerRetryKind.CoordinatedConnection, (r9S4FZfxG0478bdNv59r?)mode, "重试建立入口");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		_None_k__BackingField = (JavaServerRetryContext)new JavaServerRetryContext(JavaServerRetryKind.None, (r9S4FZfxG0478bdNv59r?)null, string.Empty);
		_ManagedClient_k__BackingField = (JavaServerRetryContext)new JavaServerRetryContext(JavaServerRetryKind.ManagedClient, (r9S4FZfxG0478bdNv59r?)null, "重试托管客户端");
	}
}

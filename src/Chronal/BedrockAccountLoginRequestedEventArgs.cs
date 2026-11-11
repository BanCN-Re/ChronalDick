using System;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockAccountLoginRequestedEventArgs : EventArgs
{
	[field: CompilerGenerated]
	public long RecordId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockAccountLoginRequestedEventArgs(long recordId)
	{
		RecordId = recordId;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AWAwFNkh6yEOmYofsXA;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Microsoft.Win32.SafeHandles;
using U3xEbuS5FxK76HaUf1b;
using fDAldojjppXrctUVYOJn;
using fLGL4MwwvHDDJMPdFBl;
using g22rGliinsxMVg3ynPo;
using kjKrMVStekrkCnZqNlG;
using lSkwDWXXJ0MpIufQpfTB;

namespace KHlKrvzB7WBDoBYWlYe;

internal sealed class sou2e7zItdeLr2f3XFf
{
	private sealed class QotAoefnahtoXL371mqC : yF9DRswR5pVceOduim4
	{
		internal static object OPH2Jd9OAxZIAxfSLVVw;

		[MethodImpl((MethodImplOptions)8)]
		public global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> SendAsync(int hostProcessId, kpLhhaSH4f4durtm5lL request, TimeSpan responseTimeout, CancellationToken cancellationToken)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return SendNamedPipeAsync(hostProcessId, request, responseTimeout, cancellationToken);
		}

		[MethodImpl((MethodImplOptions)8)]
		public QotAoefnahtoXL371mqC()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool EdRlPg9OIKV0ps6pE3dG()
		{
			return OPH2Jd9OAxZIAxfSLVVw == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static QotAoefnahtoXL371mqC bA45ll9OBwKdsyHdEsnw()
		{
			return (QotAoefnahtoXL371mqC)OPH2Jd9OAxZIAxfSLVVw;
		}
	}

	private static readonly TimeSpan CiizgIC008;

	private static readonly TimeSpan W1TzlhqNWp;

	private static readonly TimeSpan HjLzdkgX8h;

	private readonly object QbCzKyE7Ar;

	internal static object mEDcHjZm7PZNtAVgM5DC;

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> PrepareAuthRelayAsync(int hostProcessId, Rw2xvdk4yUIbmFhBjx8 binding, CancellationToken cancellationToken)
	{
		ValidateBinding(binding);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> AuthenticateAuthRelayAsync(int hostProcessId, string relayHandle, Rw2xvdk4yUIbmFhBjx8 binding, string serverHash, CancellationToken cancellationToken)
	{
		kpLhhaSH4f4durtm5lL kpLhhaSH4f4durtm5lL = CreateAuthRelayRequest("auth_relay_authenticate", binding);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> ReleaseAuthRelayAsync(int hostProcessId, string relayHandle, Rw2xvdk4yUIbmFhBjx8 binding, CancellationToken cancellationToken)
	{
		kpLhhaSH4f4durtm5lL kpLhhaSH4f4durtm5lL = CreateAuthRelayRequest("auth_relay_release", binding);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> CancelAuthRelayAsync(int hostProcessId, string relayHandle, Rw2xvdk4yUIbmFhBjx8 binding, CancellationToken cancellationToken)
	{
		kpLhhaSH4f4durtm5lL kpLhhaSH4f4durtm5lL = CreateAuthRelayRequest("auth_relay_cancel", binding);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static kpLhhaSH4f4durtm5lL CreateAuthRelayRequest(object operation, object binding)
	{
		kpLhhaSH4f4durtm5lL kpLhhaSH4f4durtm5lL = CreateRequest(operation);
		kpLhhaSH4f4durtm5lL.RelayCapability = ((Rw2xvdk4yUIbmFhBjx8)binding).Capability;
		kpLhhaSH4f4durtm5lL.RelayTransactionId = ((Rw2xvdk4yUIbmFhBjx8)binding).TransactionId;
		kpLhhaSH4f4durtm5lL.ExpectedUserId = ((Rw2xvdk4yUIbmFhBjx8)binding).UserId;
		kpLhhaSH4f4durtm5lL.ExpectedVersion = ((Rw2xvdk4yUIbmFhBjx8)binding).GameVersion;
		kpLhhaSH4f4durtm5lL.GameEntityId = ((Rw2xvdk4yUIbmFhBjx8)binding).ServerId;
		kpLhhaSH4f4durtm5lL.RoleEntityId = ((Rw2xvdk4yUIbmFhBjx8)binding).RoleId;
		kpLhhaSH4f4durtm5lL.RoleName = ((Rw2xvdk4yUIbmFhBjx8)binding).RoleName;
		kpLhhaSH4f4durtm5lL.NativeAuthorizationTarget = ((Rw2xvdk4yUIbmFhBjx8)binding).NativeAuthorizationTarget;
		kpLhhaSH4f4durtm5lL.NativeAuthorizationFactory = ((Rw2xvdk4yUIbmFhBjx8)binding).NativeAuthorizationFactory;
		return kpLhhaSH4f4durtm5lL;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ValidateBinding(object binding)
	{
		System.ArgumentNullException.ThrowIfNull(binding, "binding");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ValidateBoundRequest(object relayHandle, object binding)
	{
		ValidateBinding(binding);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> PingAsync(int hostProcessId, CancellationToken cancellationToken)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		return SendAsync(hostProcessId, CreateRequest("ping"), CiizgIC008, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> GetCapabilitiesAsync(int hostProcessId, CancellationToken cancellationToken)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		return SendAsync(hostProcessId, CreateRequest("capabilities"), CiizgIC008, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> LaunchAsync(int hostProcessId, int proxyPort, int rpcPort, DhFU4viGjAxJ4L31dyW command, CancellationToken cancellationToken)
	{
		kpLhhaSH4f4durtm5lL kpLhhaSH4f4durtm5lL = default(kpLhhaSH4f4durtm5lL);
		kpLhhaSH4f4durtm5lL.JavaArguments = Enumerable.ToArray<string>((global::System.Collections.Generic.IEnumerable<string>)command.JavaArguments);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> CancelAsync(int hostProcessId, string targetRequestId, CancellationToken cancellationToken)
	{
		kpLhhaSH4f4durtm5lL kpLhhaSH4f4durtm5lL = CreateRequest("cancel");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> ShutdownAsync(int hostProcessId, CancellationToken cancellationToken)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		return SendAsync(hostProcessId, CreateRequest("shutdown"), CiizgIC008, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static kpLhhaSH4f4durtm5lL CreateRequest(object operation)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new kpLhhaSH4f4durtm5lL
		{
			Version = 3
		};
		Guid val = System.Guid.NewGuid();
		((kpLhhaSH4f4durtm5lL)obj).RequestId = (val).ToString("N");
		((kpLhhaSH4f4durtm5lL)obj).Sequence = 1L;
		((kpLhhaSH4f4durtm5lL)obj).Operation = (string)operation;
		return (kpLhhaSH4f4durtm5lL)obj;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> LaunchOfficialTransparentAsync(int hostProcessId, int proxyPort, NuVeQcXXWNsCbu4qaXwu command, CancellationToken cancellationToken)
	{
		kpLhhaSH4f4durtm5lL kpLhhaSH4f4durtm5lL = default(kpLhhaSH4f4durtm5lL);
		kpLhhaSH4f4durtm5lL.NativeAuthorizationTarget = command.Authorization?.Target;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal sou2e7zItdeLr2f3XFf()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal sou2e7zItdeLr2f3XFf(yF9DRswR5pVceOduim4 transport)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> SendAsync(int hostProcessId, kpLhhaSH4f4durtm5lL request, TimeSpan responseTimeout, CancellationToken cancellationToken)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return ((yF9DRswR5pVceOduim4)QbCzKyE7Ar).SendAsync(hostProcessId, request, responseTimeout, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> SendNamedPipeAsync(int hostProcessId, object request, TimeSpan responseTimeout, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_SendNamedPipeAsync_d__21 sendNamedPipeAsync_d__ = default(_SendNamedPipeAsync_d__21);
		sendNamedPipeAsync_d__.__t__builder = AsyncTaskMethodBuilder<k3bme1SOTyIb1sudW4A>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsValidResponse(object response, object request, int hostProcessId)
	{
		int num = 6;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static k3bme1SOTyIb1sudW4A Failure(object request, int hostProcessId, object code, object message)
	{
		return (k3bme1SOTyIb1sudW4A)new k3bme1SOTyIb1sudW4A
		{
			Version = 3,
			RequestId = ((kpLhhaSH4f4durtm5lL)request).RequestId,
			Sequence = ((kpLhhaSH4f4durtm5lL)request).Sequence,
			Success = false,
			Code = (string)code,
			Message = (string)message,
			HostProcessId = hostProcessId,
			ChallengeId = (((kpLhhaSH4f4durtm5lL)request)?.ChallengeId ?? string.Empty)
		};
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetNamedPipeServerProcessId(SafePipeHandle pipe, out uint serverProcessId);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool mkJtFeZmAyvDhxvXMURL()
	{
		return mEDcHjZm7PZNtAVgM5DC == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static sou2e7zItdeLr2f3XFf cZjhStZmIBTaIiFfJmsh()
	{
		return (sou2e7zItdeLr2f3XFf)mEDcHjZm7PZNtAVgM5DC;
	}
}

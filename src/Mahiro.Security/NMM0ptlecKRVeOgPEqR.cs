using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using QMs38GlwcmEZoBgEv53;
using apX549d5RUYrf4hSQnl;

namespace I8V9IHlPQ13yu5Bxh6J;

sealed class NMM0ptlecKRVeOgPEqR : global::System.IDisposable
{
	private readonly object yxfdfvN3sa;

	private readonly object BDBdLMGf41;

	private readonly hghW4TlR1p1DZ1uipC4? wjkdj2atUp;

	private readonly object v3ndZqTl5k;

	private readonly bool e5Ud9EerSs;

	private readonly object Qi5dDL3vPj;

	private readonly object nJMdkDNT52;

	private object V5ndV676PM;

	private hghW4TlR1p1DZ1uipC4? mn1dYCTyqO;

	private DateTimeOffset l8QdSnPGPU;

	private int wmVdcHg8Fw;

	private bool xJod0QZ4uK;

	private bool cl9d8kPl8p;

	private long wxUdy0rDuM;

	private bool cxBdWAMH1n;

	private global::System.Threading.Tasks.Task? oBpdJ26pSV;

	private static object HfSO1mZWJ9RskKXp8qNQ;

	internal extern hghW4TlR1p1DZ1uipC4 PrimaryEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		get;
	}

	internal extern hghW4TlR1p1DZ1uipC4? BackupEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		get;
	}

	internal extern bool IsBackupEndpointPinned
	{
		[MethodImpl((MethodImplOptions)8)]
		get;
	}

	internal extern hghW4TlR1p1DZ1uipC4 ActiveEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		get;
	}

	internal extern bool PrimaryRecoveryReady
	{
		[MethodImpl((MethodImplOptions)8)]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public extern NMM0ptlecKRVeOgPEqR(HttpClient primaryHttpClient, HttpClient? backupHttpClient, TOEJM3dOdJLn5K9AlWe options, bool ownsHttpClients, TimeProvider? timeProvider = null);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool htFlxE90ll(bool enabled);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool rDMlFtFEs1(hghW4TlR1p1DZ1uipC4 endpoint);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool sFmlsefF6H(hghW4TlR1p1DZ1uipC4 endpoint);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool RKLlT5vEVk(hghW4TlR1p1DZ1uipC4 endpoint);

	[MethodImpl((MethodImplOptions)8)]
	internal extern hghW4TlR1p1DZ1uipC4 wL5lN3qk1O(hghW4TlR1p1DZ1uipC4? excludedEndpoint = null);

	[MethodImpl((MethodImplOptions)8)]
	internal extern hghW4TlR1p1DZ1uipC4? Ke0lMnUdkq(hghW4TlR1p1DZ1uipC4 endpoint, hghW4TlR1p1DZ1uipC4? excludedEndpoint = null);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool Fa6lp2iBWX(hghW4TlR1p1DZ1uipC4 endpoint, string reason);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool KJ7luSDHWD(hghW4TlR1p1DZ1uipC4 endpoint);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool RAwlaiV4BT(string reason);

	[MethodImpl((MethodImplOptions)8)]
	internal extern bool zV7l1SCXQK(string reason);

	[MethodImpl((MethodImplOptions)8)]
	internal extern void Onml34hn5g(bool succeeded);

	[MethodImpl((MethodImplOptions)8)]
	private extern void AIqlvFBbHZ(bool succeeded, long? expectedGeneration);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool t3GlEV5L5y(HttpStatusCode statusCode);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool zwRl2MPGPc(object exception, CancellationToken callerCancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool kyhlqA1sLp(object exception);

	[MethodImpl((MethodImplOptions)8)]
	public extern void Dispose();

	[MethodImpl((MethodImplOptions)8)]
	private extern void HYWlGcgxX8();

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task vXfliyHSnD(CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task<bool> GsUln3ZlLG(CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void OLslzLhaOg(object httpClient, object baseUri);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void DfOdbXLagU(object options);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void XcodXIGQ5S(object uri, bool allowInsecureLoopback);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool cCmdjvZWQCCcoYfYUDij();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern NMM0ptlecKRVeOgPEqR aExGE8ZWCjqp91DXGVlj();
}

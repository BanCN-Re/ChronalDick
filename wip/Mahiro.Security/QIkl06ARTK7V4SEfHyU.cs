using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using HeKENIfwLrlVLAeb4tLR;
using fDAldojjppXrctUVYOJn;
using vc6Q6SfwXNjuEtBKwumq;

namespace ruw1iPAw2CUM7hnL63H;

sealed class QIkl06ARTK7V4SEfHyU : global::System.IDisposable
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass25_0
	{
		public AddressFamily addressFamily;

		internal static __c__DisplayClass25_0 ywVj4h9hORyXwx6KFVKM;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass25_0()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.ValueTask<Stream> NxefqYB9kEe(SocketsHttpConnectionContext context, CancellationToken cancellationToken)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			return SnLApMTQ3O((context).DnsEndPoint, addressFamily, cancellationToken);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 0;
							}
							return;
						case 0:
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							break;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ylcCKA9h5mbGsgiK6QXg()
		{
			return ywVj4h9hORyXwx6KFVKM == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass25_0 Ydttje9h6eUItLo5AGCq()
		{
			return ywVj4h9hORyXwx6KFVKM;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass26_0
	{
		public AddressFamily addressFamily;

		internal static __c__DisplayClass26_0 twXUqg9hRw1RTLnZTnWH;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass26_0()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool FlofqSSmcFZ(IPAddress address)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			return (address).AddressFamily == addressFamily;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 0;
							}
							return;
						case 0:
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
							{
								num3 = 4;
							}
							continue;
						case 2:
							break;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool LhI9AS9hwnyqGsFFUaoe()
		{
			return twXUqg9hRw1RTLnZTnWH == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass26_0 VcYdl59heSIaQT1ftKIK()
		{
			return twXUqg9hRw1RTLnZTnWH;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ConnectAsync_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncValueTaskMethodBuilder<Stream> __t__builder;

		public AddressFamily addressFamily;

		public DnsEndPoint endpoint;

		public CancellationToken cancellationToken;

		private __c__DisplayClass26_0 __8__1;

		private ConfiguredTaskAwaitable<IPAddress[]>.ConfiguredTaskAwaiter __u__1;

		private IPAddress[] __7__wrap1;

		private int __7__wrap2;

		private Socket _socket_5__4;

		private object __u__2;

		private static object pltGNZ9hPNhI2ft9lpQ2;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
							{
								num3 = 8;
							}
							continue;
						case 2:
							break;
						case 0:
							num3 = 2;
							continue;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
				{
					num = 7;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool gCA66J9hxdXA4YCBj2Br()
		{
			return pltGNZ9hPNhI2ft9lpQ2 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object kksGd79hFCcgAc0D833e()
		{
			return pltGNZ9hPNhI2ft9lpQ2;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ProbeAsync_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<pLlZUUfwbLE7ygaQx7ma> __t__builder;

		public CancellationToken cancellationToken;

		public HttpClient client;

		public AddressFamily expectedFamily;

		private CancellationTokenSource _timeout_5__2;

		private HttpRequestMessage _request_5__3;

		private HttpResponseMessage _response_5__4;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter __u__2;

		internal static object uRWQdF9hMQbNeqa0dDyA;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							switch (num2)
							{
							case 990:
								break;
							case 9:
								goto IL_0068;
							default:
								goto end_IL_000e;
							}
							break;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num3 = 6;
							}
							continue;
						case 0:
							return;
						case 1:
							goto end_IL_000e;
							IL_0068:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool XJC8P49hpsu9QuW4yUaF()
		{
			return uRWQdF9hMQbNeqa0dDyA == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object UhMSZn9hukDafKsn7T6q()
		{
			return uRWQdF9hMQbNeqa0dDyA;
		}
	}

	private static readonly object LNFAuNDggj;

	private static readonly TimeSpan v56AamJDuV;

	private static TimeSpan h71A1tJnAn;

	private readonly object DS8A2nSvDW;

	private readonly object WGJAqLe8qn;

	private readonly bool pSuAGPgbGR;

	private readonly object qwEAi9ub8L;

	private readonly object LX3AnegA4f;

	private EhWBH4fwfCGaf6mXVxMg? GtUAz71ySK;

	private DateTimeOffset BxMIboNQfi;

	private bool TRkIXuIXW2;

	private static object DshcN7ZyD5KRWcQvFMus;

	[MethodImpl((MethodImplOptions)8)]
	public QIkl06ARTK7V4SEfHyU()
	{
		//IL_005a: Expected I4, but got O
		//IL_003f->IL0051: Incompatible stack types: I4 vs O
		//IL_004a->IL0051: Incompatible stack types: I4 vs O
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		QIkl06ARTK7V4SEfHyU(tiEAMtfuV6((AddressFamily)2), tiEAMtfuV6((AddressFamily)23), ownsClients: true);
		object obj = 1;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
		{
			obj = 0;
		}
		object obj2 = default;
		while (true)
		{
			switch ((int)obj)
			{
			case 0:
				return;
			}
			if ((nint)obj2 == 988)
			{
				obj = obj2;
				continue;
			}
			return;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public QIkl06ARTK7V4SEfHyU(HttpClient ipv4Client, HttpClient ipv6Client)
	{
		//IL_004f: Expected I4, but got O
		//IL_0034->IL0046: Incompatible stack types: I4 vs O
		//IL_003f->IL0046: Incompatible stack types: I4 vs O
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		QIkl06ARTK7V4SEfHyU(ipv4Client, ipv6Client, ownsClients: false);
		object obj = 0;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
		{
			obj = 4;
		}
		object obj2 = default;
		while (true)
		{
			switch ((int)obj)
			{
			case 0:
				return;
			}
			if ((nint)obj2 == 988)
			{
				obj = obj2;
				continue;
			}
			return;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private QIkl06ARTK7V4SEfHyU(HttpClient ipv4Client, HttpClient ipv6Client, bool ownsClients)
	{
		//IL_001d: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		((QIkl06ARTK7V4SEfHyU)1).qwEAi9ub8L = 1;
		LX3AnegA4f = this;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task<EhWBH4fwfCGaf6mXVxMg> sONAeWkWJi(bool forceRefresh = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe void sENAPAfaQQ()
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0120: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected I4, but got O
		//IL_012a->IL0010: Incompatible stack types: I4 vs O
		//IL_0054->IL0010: Incompatible stack types: I4 vs O
		//IL_0082->IL0094: Incompatible stack types: I4 vs O
		//IL_005f->IL0010: Incompatible stack types: I4 vs O
		//IL_008d->IL0094: Incompatible stack types: I4 vs O
		//IL_00c9->IL0094: Incompatible stack types: I4 vs O
		//IL_00e9->IL0094: Incompatible stack types: I4 vs O
		//IL_00f4->IL0094: Incompatible stack types: I4 vs O
		object obj = 2;
		object lX3AnegA4f = default;
		object obj3 = default;
		object obj5 = default;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 991)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 2:
					lX3AnegA4f = LX3AnegA4f;
					obj2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
					{
						obj2 = 5;
					}
					break;
				case 3:
				{
					System.Threading.Monitor.Enter(lX3AnegA4f, ref obj3);
					object obj4 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
					{
						obj4 = 1;
					}
					while (true)
					{
						switch ((int)obj4)
						{
						default:
							if ((nint)obj5 == 990)
							{
								obj4 = obj5;
								break;
							}
							return;
						case 1:
							GtUAz71ySK = null;
							obj4 = 2;
							break;
						case 2:
							BxMIboNQfi = (DateTimeOffset)default(AuthenticationException);
							obj4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
							{
								obj4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
				case 1:
					obj3 = 0;
					obj2 = 3;
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe bool VJhAxtPHVd(out EhWBH4fwfCGaf6mXVxMg snapshot)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_01e3: Expected O, but got I4
		//IL_0070: Expected I8, but got O
		//IL_01a5: Expected I8, but got O
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected I4, but got O
		//IL_00c8: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_00ed: Expected I4, but got O
		//IL_01ed->IL0010: Incompatible stack types: I4 vs O
		//IL_0062->IL0010: Incompatible stack types: I4 vs O
		//IL_00b7->IL00cc: Incompatible stack types: I4 vs O
		//IL_006d->IL0010: Incompatible stack types: I4 vs O
		//IL_00c2->IL00cc: Incompatible stack types: I4 vs O
		//IL_0162->IL00cc: Incompatible stack types: I4 vs O
		//IL_0131->IL00cc: Incompatible stack types: I4 vs O
		//IL_016d->IL00cc: Incompatible stack types: I4 vs O
		//IL_013c->IL00cc: Incompatible stack types: I4 vs O
		int num = 1;
		object lX3AnegA4f = default;
		object obj3 = default;
		object obj6 = default;
		object obj5 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 10)
						{
							if ((nint)obj == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						snapshot = default;
						return false;
					case 1:
						lX3AnegA4f = LX3AnegA4f;
						obj2 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
						break;
					case 2:
					{
						System.Threading.Monitor.Enter(lX3AnegA4f, ref obj3);
						object obj4 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							obj4 = 0;
						}
						while (true)
						{
							int num2;
							switch ((int)obj4)
							{
							case 2:
							case 3:
							case 5:
								break;
							case 1:
								snapshot = default;
								return (byte)(int)obj6 != 0;
							default:
								if ((nint)obj5 != 14)
								{
									if ((nint)obj5 == 994)
									{
										goto IL_00c8;
									}
									goto case 4;
								}
								obj6 = 1;
								obj4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
								{
									obj4 = 1;
								}
								continue;
							case 0:
								if (GtUAz71ySK == null)
								{
									obj4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
									{
										obj4 = 1;
									}
									continue;
								}
								goto case 6;
							case 6:
								if (!(System.DateTimeOffset.UtcNow < BxMIboNQfi))
								{
									num2 = 5;
									goto IL_00c4;
								}
								goto case 4;
							case 4:
								{
									snapshot = default;
									num2 = 14;
									goto IL_00c4;
								}
								IL_00c4:
								obj5 = num2;
								goto IL_00c8;
								IL_00c8:
								obj4 = obj5;
								continue;
							}
							break;
						}
						break;
					}
					case 0:
						obj3 = 0;
						obj2 = 2;
						continue;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			snapshot = default;
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<pLlZUUfwbLE7ygaQx7ma?> hqpAFHfTIQ(object client, AddressFamily expectedFamily, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.cancellationToken = cancellationToken;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_ProbeAsync_d__21*)12)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static pLlZUUfwbLE7ygaQx7ma cMZAssO3gF(object payload, AddressFamily expectedFamily)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<byte[]> WgCATFIrAW(object content, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FV0AN0mCM1(object? ipv4, object? ipv6)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0056->IL0010: Incompatible stack types: I4 vs O
		//IL_00b1->IL0010: Incompatible stack types: I4 vs O
		//IL_00bc->IL0010: Incompatible stack types: I4 vs O
		//IL_00f8->IL0010: Incompatible stack types: I4 vs O
		//IL_0103->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 10)
						{
							if ((nint)obj == 991)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						return "ipv4_only";
					case 0:
						if (ipv6 != null)
						{
							obj2 = 3;
							continue;
						}
						break;
					case 3:
						return "dual_stack";
					case 1:
						if (ipv4 != null)
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
							{
								obj2 = 5;
							}
							continue;
						}
						break;
					case 2:
						return "unavailable";
					}
					if (ipv4 != null)
					{
						goto end_IL_000c;
					}
					if (ipv6 != null)
					{
						return "ipv6_only";
					}
					obj2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
					{
						obj2 = 5;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient tiEAMtfuV6(AddressFamily addressFamily)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(HttpClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.ValueTask<Stream> SnLApMTQ3O(object endpoint, AddressFamily addressFamily, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.cancellationToken = cancellationToken;
		return default(global::System.Threading.Tasks.ValueTask<Stream>);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		h71A1tJnAn = System.TimeSpan.FromMinutes(5.0);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HpYmFIZykbIPimYFvLgD()
	{
		return DshcN7ZyD5KRWcQvFMus == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QIkl06ARTK7V4SEfHyU do99hUZyVIv14QBLISWJ()
	{
		return (QIkl06ARTK7V4SEfHyU)DshcN7ZyD5KRWcQvFMus;
	}
}

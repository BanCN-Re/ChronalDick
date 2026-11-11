using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using D4SUYbmq8poOlKYw6Ed;
using HeBBVpUJtZc0wOjmeI1;
using K5FCrdFj16NFnFBU3KQ;
using PVsLSXUheTTt8wGgSJo;
using RyDfSXfPyKj0ty7cSIxY;
using WMO32gy5EZANSQKlHAx;
using Windows.Storage.Streams;
using dHUo7PXIxudqosA07XUa;
using fDAldojjppXrctUVYOJn;
using l6fA40fP0TXAIKJYPUiR;
using lkSKnmuHFVy3E1vQay0;
using mLmvCnJ22GFjtB7esCn;
using oJH8wFXbaYvifpxtNyVI;
using qExVEVXL9J4PufNQt1Z4;
using rsq4n3UgA8K542GL74j;
using todNS07L1BTskuVuFU3;

namespace LZeD85h0vvnYnit7g5w;

sealed class sDBJG2hcdnUxjaDOenm : global::System.IDisposable
{
	private enum YEOxnTfE6YtoCRHAQAYp
	{
		Login,
		Register
	}

	private sealed class G8kHLefERxBQolNcXL42 : IEquatable<G8kHLefERxBQolNcXL42>
	{
		[CompilerGenerated]
		private string _ClientId_k__BackingField;

		[CompilerGenerated]
		private string _State_k__BackingField;

		[CompilerGenerated]
		private string _Ref_k__BackingField;

		[CompilerGenerated]
		private string _BizId_k__BackingField;

		[CompilerGenerated]
		private string _RedirectUri_k__BackingField;

		internal static object QWp0Fn9J2q7qOLaOfLqi;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(G8kHLefERxBQolNcXL42).TypeHandle);
			}
		}

		public string ClientId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _ClientId_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							goto IL_001d;
						case 0:
							return;
						case 1:
							break;
						}
						goto IL_0031;
						IL_001d:
						if (num == 989)
						{
							break;
						}
						goto IL_0031;
						IL_0031:
						_ClientId_k__BackingField = value;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		public string State
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _State_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							goto IL_001d;
						case 0:
							return;
						case 1:
							break;
						}
						goto IL_0031;
						IL_001d:
						if (num == 989)
						{
							break;
						}
						goto IL_0031;
						IL_0031:
						_State_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		public string Ref
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Ref_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							goto IL_001d;
						case 0:
							return;
						case 1:
							break;
						}
						goto IL_0031;
						IL_001d:
						if (num == 989)
						{
							break;
						}
						goto IL_0031;
						IL_0031:
						_Ref_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
						{
							num2 = 0;
						}
					}
				}
			}
		}

		public string BizId
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _BizId_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
							_BizId_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
							{
								num2 = 5;
							}
							continue;
						case 0:
							return;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		public string RedirectUri
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _RedirectUri_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							_RedirectUri_k__BackingField = value;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						break;
					}
				}
				while (num == 989);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public G8kHLefERxBQolNcXL42(string ClientId, string State, string Ref, string BizId, string RedirectUri)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			_ClientId_k__BackingField = ClientId;
			_State_k__BackingField = State;
			_Ref_k__BackingField = Ref;
			_BizId_k__BackingField = BizId;
			_RedirectUri_k__BackingField = RedirectUri;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bool oM7fEwvUy7Y(StringBuilder builder)
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
							if (num2 != 17)
							{
								if (num2 == 998)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							(builder).Append(", BizId = ");
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
							{
								num3 = 5;
							}
							continue;
						case 4:
							break;
						case 8:
							(builder).Append(RedirectUri);
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
							{
								num3 = 9;
							}
							continue;
						case 0:
							(builder).Append("ClientId = ");
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
							{
								num3 = 16;
							}
							continue;
						case 10:
							(builder).Append(ClientId);
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
							{
								num3 = 6;
							}
							continue;
						case 7:
							(builder).Append(", RedirectUri = ");
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
							{
								num3 = 8;
							}
							continue;
						case 6:
							(builder).Append(", State = ");
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
							{
								num3 = 2;
							}
							continue;
						case 5:
							(builder).Append(BizId);
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 7;
							}
							continue;
						case 3:
							(builder).Append(State);
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
							{
								num3 = 10;
							}
							continue;
						case 2:
							return true;
						case 1:
							System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num3 = 0;
							}
							continue;
						case 9:
							(builder).Append(", Ref = ");
							num3 = 4;
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
				(builder).Append(Ref);
				num = 17;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(G8kHLefERxBQolNcXL42? left, G8kHLefERxBQolNcXL42? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(G8kHLefERxBQolNcXL42? left, G8kHLefERxBQolNcXL42? right)
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (num == 991)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 0:
						if (left == null)
						{
							num2 = 3;
							break;
						}
						goto case 2;
					case 2:
						return ((G8kHLefERxBQolNcXL42)left).Equals((G8kHLefERxBQolNcXL42?)right);
					case 3:
						return false;
					case 1:
						if (left == right)
						{
							return true;
						}
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
						{
							num2 = 0;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected I4, but got Unknown
			return (int)(((((EqualityContract * -1521134295 + _ClientId_k__BackingField) * -1521134295 + _State_k__BackingField) * -1521134295 + _Ref_k__BackingField) * -1521134295 + _BizId_k__BackingField) * -1521134295 + _RedirectUri_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as G8kHLefERxBQolNcXL42);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(G8kHLefERxBQolNcXL42? other)
		{
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public G8kHLefERxBQolNcXL42 oWLfEeT7Wdr()
		{
			return (G8kHLefERxBQolNcXL42)new G8kHLefERxBQolNcXL42(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private G8kHLefERxBQolNcXL42(G8kHLefERxBQolNcXL42 original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void DR3fEPC81HL(out string ClientId, out string State, out string Ref, out string BizId, out string RedirectUri)
		{
			//IL_0052: Expected I8, but got O
			//IL_00a2: Expected I8, but got O
			//IL_00f1: Expected I8, but got O
			//IL_007b: Expected I8, but got O
			//IL_00ca: Expected I8, but got O
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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0010;
								}
								goto case 3;
							}
							BizId = default;
							ClientId = default;
							RedirectUri = default;
							Ref = default;
							State = default;
							return;
						case 0:
							Ref = default;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
							{
								num3 = 3;
							}
							continue;
						case 3:
							BizId = default;
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
							{
								num3 = 3;
							}
							continue;
						case 1:
							State = default;
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							break;
						case 2:
							ClientId = default;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num3 = 1;
							}
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
				RedirectUri = default;
				num = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
				{
					num = 11;
				}
			}
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
							default:
								goto end_IL_000e;
							case 9:
								goto IL_0054;
							}
							break;
						case 1:
							return;
						case 2:
							goto end_IL_000e;
						case 0:
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
								{
									num3 = 1;
								}
								continue;
							}
							IL_0054:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
							{
								num3 = 7;
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
		internal static bool YUZwgU9Jqwkf2scvbpRr()
		{
			return QWp0Fn9J2q7qOLaOfLqi == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static G8kHLefERxBQolNcXL42 tb96dZ9JGx1JDFNyCfNX()
		{
			return (G8kHLefERxBQolNcXL42)QWp0Fn9J2q7qOLaOfLqi;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ApplyCaptchaAsync_d__33 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<ValueTuple<bool, bool, string>> __t__builder;

		public Dictionary<string, string> forms;

		public HttpClient httpClient;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public CancellationToken cancellationToken;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		private string _captchaId_5__2;

		private HttpResponseMessage _response_5__3;

		private byte[] _bytes_5__4;

		private Stopwatch _captchaStopwatch_5__5;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<string?>.ConfiguredTaskAwaiter __u__3;

		private static object moGiBm9JijAKS0XB3NPQ;

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
							if (num2 == 9)
							{
								return;
							}
							goto IL_0031;
						case 0:
							goto end_IL_000e;
						case 2:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						}
						goto IL_0078;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0078;
						IL_0078:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
						{
							num3 = 6;
						}
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
		internal static bool B2absG9JnHbs73cCuFpU()
		{
			return moGiBm9JijAKS0XB3NPQ == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object I371Cc9JzLijt2LiCBan()
		{
			return moGiBm9JijAKS0XB3NPQ;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CompleteOAuthAsync_d__28 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB> __t__builder;

		public Uri location;

		public string username;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public CancellationToken cancellationToken;

		public bool retryIncompleteCookie;

		public string password;

		public nNU9JoUBxAhVHRZ6PhH realNameInfo;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		public string successMessage;

		private ConfiguredTaskAwaitable<Wl2fv0UW3tuhZfbWA4W>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter __u__2;

		internal static object PdCy3w9QbdR9G47bJwip;

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
						case 0:
							return;
						case 2:
							num3 = 1;
							continue;
						case 1:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool txx7ie9QXkCeXcN2JxsW()
		{
			return PdCy3w9QbdR9G47bJwip == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object z9SQZm9QffUrCs8tTwuS()
		{
			return PdCy3w9QbdR9G47bJwip;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CompleteRealNameAsync_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB> __t__builder;

		public string responseBody;

		public nNU9JoUBxAhVHRZ6PhH realNameInfo;

		public string username;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public CancellationToken cancellationToken;

		public string password;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		public bool retryIncompleteCookie;

		public string successMessage;

		private HttpResponseMessage _response_5__2;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter __u__3;

		internal static object wd5VdB9QLKcIYEiuKeoD;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Expected O, but got I4
			//IL_0306: Expected O, but got I4
			//IL_03b8: Expected O, but got Ref
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0988: Unknown result type (might be due to invalid IL or missing references)
			//IL_098d: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07de: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bc: Expected O, but got Ref
			//IL_0655: Unknown result type (might be due to invalid IL or missing references)
			//IL_0666: Unknown result type (might be due to invalid IL or missing references)
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0904: Unknown result type (might be due to invalid IL or missing references)
			//IL_0906: Unknown result type (might be due to invalid IL or missing references)
			//IL_0591: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_080c: Expected O, but got I4
			//IL_0885: Unknown result type (might be due to invalid IL or missing references)
			//IL_088f: Expected I4, but got Unknown
			//IL_08d6: Expected O, but got I4
			//IL_0968: Expected O, but got Ref
			//IL_061f: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09dd: Invalid comparison between Unknown and I4
			//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b43->IL0ad8: Incompatible stack heights: 3 vs 1
			//IL_00b0->IL0008: Incompatible stack heights: 3 vs 1
			//IL_03a8->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_0454->IL00d4: Incompatible stack heights: 4 vs 1
			//IL_031a->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_019b->IL00d4: Incompatible stack heights: 4 vs 1
			//IL_03b3->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_045f->IL00d4: Incompatible stack heights: 4 vs 1
			//IL_0325->IL00d4: Incompatible stack heights: 2 vs 1
			//IL_07ea->IL04d4: Incompatible stack heights: 2 vs 1
			//IL_0672->IL04d4: Incompatible stack heights: 2 vs 1
			//IL_08e0->IL04d4: Incompatible stack heights: 2 vs 1
			sDBJG2hcdnUxjaDOenm sDBJG2hcdnUxjaDOenm2 = default;
			int num3 = default;
			int num11 = default;
			HttpResponseMessage response_5__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__3 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val3 = default;
			Dictionary<string, string> form = default;
			int num6 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<string> val2 = default;
			string text = default;
			ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter _u__2 = default;
			ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB> val = default;
			int num14 = default;
			while (true)
			{
				int num = 4;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num != 12)
							{
								if (num == 993)
								{
									goto end_IL_0010;
								}
								goto case 3;
							}
							return;
						case 2:
							__1__state = -2;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
							{
								num2 = 11;
							}
							continue;
						case 3:
							sDBJG2hcdnUxjaDOenm2 = __4__this;
							num2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
							{
								num2 = 1;
							}
							continue;
						case 5:
							break;
						case 1:
							try
							{
								int num4;
								if (num3 == 0)
								{
									num4 = 14;
									goto IL_00d4;
								}
								goto IL_01da;
								IL_01da:
								if ((uint)(num3 - 1) > 1u)
								{
									num4 = 18;
									goto IL_00d4;
								}
								goto IL_0218;
								IL_00d4:
								while (true)
								{
									int num10;
									switch (num4)
									{
									case 16:
										return;
									default:
										if (num11 != 26)
										{
											if (num11 == 1006)
											{
												goto IL_00d0;
											}
											goto case 8;
										}
										num3 = (__1__state = -1);
										num4 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
										{
											num4 = 4;
										}
										continue;
									case 13:
										_response_5__2 = response_5__;
										num4 = 3;
										continue;
									case 12:
										_ = "realname";
										(realNameInfo.Name).Trim();
										_ = 6;
										continue;
									case 2:
										if (&_u__3 == null)
										{
											num4 = 14;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
											{
												num4 = 8;
											}
											continue;
										}
										goto case 11;
									case 17:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _CompleteRealNameAsync_d__25>(ref _u__3, ref this);
										num10 = 16;
										goto IL_00cc;
									case 7:
										break;
									case 8:
										num3 = (__1__state = 0);
										num4 = 4;
										continue;
									case 0:
										__u__1 = default;
										num10 = 26;
										goto IL_00cc;
									case 3:
										goto IL_0218;
									case 10:
									{
										_ = "Login4399";
										global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
										(defaultInterpolatedStringHandler2).AppendLiteral("提交安全校验资料: username=");
										(defaultInterpolatedStringHandler2).AppendFormatted(username);
										(defaultInterpolatedStringHandler2).AppendLiteral(", nameLength=");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(((realNameInfo.Name).Trim()).Length);
										gX17swyO7x0JWQxdaD1.IdOy6I4Chb((string)32, (defaultInterpolatedStringHandler2).ToStringAndClear());
										_ = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
										{
											_ = 5;
										}
										continue;
									}
									case 9:
										_u__3 = val3;
										num10 = 2;
										goto IL_00cc;
									case 18:
										form = hZBhgkWm11(responseBody, "<div class=\"input_wrap_id finput_wrap\">");
										num10 = 12;
										goto IL_00cc;
									case 5:
										sDBJG2hcdnUxjaDOenm2.MyyhBARicd("https://ptlogin.4399.com/oauth2/setIdcardAndRealname.do", (IReadOnlyDictionary<string, string>)(object)form, cancellationToken);
										val3 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
										_ = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
										{
											_ = 9;
										}
										continue;
									case 11:
										response_5__ = (HttpResponseMessage)(object)(&_u__3);
										num4 = 13;
										continue;
									case 14:
									case 15:
										_u__3 = __u__1;
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
										{
											num4 = 0;
										}
										continue;
									case 6:
										_ = "idcard";
										(realNameInfo.IdCard).Trim();
										_ = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
										{
											_ = 6;
										}
										continue;
									case 4:
										__u__1 = _u__3;
										num4 = 17;
										continue;
									case 1:
										{
											try
											{
												int num5;
												if (num3 != 1)
												{
													num5 = 23;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
													{
														num5 = 24;
													}
													goto IL_04d4;
												}
												goto IL_0987;
												IL_04d4:
												while (true)
												{
													int num7;
													switch (num5)
													{
													case 11:
														return;
													case 21:
														return;
													default:
														if (num6 != 35)
														{
															if (num6 == 1015)
															{
																goto IL_04d0;
															}
															goto case 19;
														}
														goto end_IL_04d4;
													case 13:
														_u__ = val2;
														num5 = 16;
														continue;
													case 22:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _CompleteRealNameAsync_d__25>(ref _u__, ref this);
														num5 = 21;
														continue;
													case 9:
														num3 = (__1__state = 1);
														num5 = 8;
														continue;
													case 3:
													{
														t30hHHfP8gMStFdbd6rB t30hHHfP8gMStFdbd6rB = t30hHHfP8gMStFdbd6rB.Fail(text);
														num5 = 7;
														continue;
													}
													case 27:
														__u__3 = default;
														num5 = 11;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
														{
															num5 = 14;
														}
														continue;
													case 8:
														__u__2 = _u__;
														num7 = 22;
														goto IL_04cc;
													case 24:
														__u__2 = default;
														num5 = 15;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
														{
															num5 = 27;
														}
														continue;
													case 6:
														((_response_5__2).Content).ReadAsStringAsync(cancellationToken);
														val2 = (ConfiguredTaskAwaitable<string>)0;
														_ = 13;
														continue;
													case 2:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter, _CompleteRealNameAsync_d__25>(ref _u__2, ref this);
														num5 = 11;
														continue;
													case 14:
														num3 = (__1__state = -1);
														num5 = 20;
														continue;
													case 7:
														goto end_IL_04d4;
													case 12:
														if (&_u__2 == null)
														{
															num5 = 4;
															continue;
														}
														goto case 20;
													case 15:
														num3 = (__1__state = -1);
														num5 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
														{
															num5 = 6;
														}
														continue;
													case 0:
														gX17swyO7x0JWQxdaD1.rShyeXSwgD("Login4399", string.Concat("安全校验通过，继续 OAuth: username=", username));
														num5 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
														{
															num5 = 25;
														}
														continue;
													case 1:
														sDBJG2hcdnUxjaDOenm2.O70hCb2j0L(((_response_5__2).Headers).Location, username, password, realNameInfo, captchaCallback, retryIncompleteCookie, successMessage, cancellationToken);
														val = (ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>)0;
														_ = 25;
														continue;
													case 19:
													{
														_ = "Login4399";
														global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
														(defaultInterpolatedStringHandler).AppendLiteral("安全校验提交被拒绝: username=");
														(defaultInterpolatedStringHandler).AppendFormatted(username);
														(defaultInterpolatedStringHandler).AppendLiteral(", status=");
														defaultInterpolatedStringHandler.AppendFormatted<int>((int)(_response_5__2).StatusCode);
														(defaultInterpolatedStringHandler).AppendLiteral(", reason=");
														(defaultInterpolatedStringHandler).AppendFormatted(text);
														gX17swyO7x0JWQxdaD1.U3iyRWfbJV((string)38, (defaultInterpolatedStringHandler).ToStringAndClear());
														_ = 3;
														continue;
													}
													case 4:
														num3 = (__1__state = 2);
														num5 = 10;
														continue;
													case 25:
														_u__2 = val;
														num5 = 12;
														continue;
													case 10:
														__u__3 = _u__2;
														num5 = 33;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
														{
															num5 = 2;
														}
														continue;
													case 16:
														if (&_u__ == null)
														{
															num5 = 9;
															continue;
														}
														goto case 5;
													case 23:
														if (num3 != 2)
														{
															num5 = 26;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
															{
																num5 = 26;
															}
															continue;
														}
														goto case 17;
													case 20:
													{
														t30hHHfP8gMStFdbd6rB t30hHHfP8gMStFdbd6rB = (t30hHHfP8gMStFdbd6rB)(&_u__2);
														num7 = 23;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
														{
															num7 = 35;
														}
														goto IL_04cc;
													}
													case 18:
														break;
													case 5:
														text = c4khHBM5xq((object)(&_u__), "安全校验失败");
														num5 = 19;
														continue;
													case 26:
														if ((int)(_response_5__2).StatusCode != 302)
														{
															num5 = 6;
															continue;
														}
														goto case 0;
													case 17:
														{
															_u__2 = __u__3;
															num5 = 27;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
															{
																num5 = 21;
															}
															continue;
														}
														IL_04d0:
														num5 = num6;
														continue;
														IL_04cc:
														num6 = num7;
														goto IL_04d0;
													}
													goto IL_0987;
													continue;
													end_IL_04d4:
													break;
												}
												goto end_IL_049b;
												IL_0987:
												_u__ = __u__2;
												num5 = 24;
												goto IL_04d4;
												end_IL_049b:;
											}
											finally
											{
												if (num3 < 0)
												{
													int num8 = 2;
													while (true)
													{
														IL_0a38:
														int num9 = num8;
														while (true)
														{
															switch (num9)
															{
															default:
																goto IL_0a4d;
															case 2:
																if (_response_5__2 != null)
																{
																	num9 = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
																	{
																		num9 = 7;
																	}
																	continue;
																}
																goto end_IL_0a3c;
															case 1:
																break;
															case 0:
																goto end_IL_0a3c;
															}
															goto IL_0a8a;
															IL_0a4d:
															if (num8 == 990)
															{
																goto IL_0a38;
															}
															goto IL_0a8a;
															IL_0a8a:
															(_response_5__2).Dispose();
															num9 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
															{
																num9 = 2;
															}
															continue;
															end_IL_0a3c:
															break;
														}
														break;
													}
												}
											}
											goto end_IL_00b1;
										}
										IL_00cc:
										num11 = num10;
										goto IL_00d0;
										IL_00d0:
										num4 = num11;
										continue;
									}
									break;
								}
								goto IL_01da;
								IL_0218:
								num4 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num4 = 1;
								}
								goto IL_00d4;
								end_IL_00b1:;
							}
							catch (global::System.Exception)
							{
								int num12 = 2;
								while (true)
								{
									switch (num12)
									{
									case 1:
										return;
									default:
										if (num14 != 10)
										{
											if (num14 != 990)
											{
												break;
											}
											goto IL_0ad4;
										}
										_ = __t__builder;
										_ = 1;
										continue;
									case 0:
									{
										_response_5__2 = null;
										int num13 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
										{
											num13 = 10;
										}
										num14 = num13;
										goto IL_0ad4;
									}
									case 2:
										break;
										IL_0ad4:
										num12 = num14;
										continue;
									}
									__1__state = -2;
									num12 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
									{
										num12 = 2;
									}
								}
							}
							goto case 2;
						case 0:
							_response_5__2 = null;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num2 = 5;
							}
							continue;
						case 4:
							num3 = __1__state;
							num2 = 3;
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
				_ = __t__builder;
				_ = 12;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto end_IL_0012;
						case 1:
							break;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
							{
								num3 = 9;
							}
							continue;
						case 0:
							return;
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
				{
					num = 6;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KfCwhu9QjSVMixIYyQuN()
		{
			return wd5VdB9QLKcIYEiuKeoD == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object iWj7Z69QZGe2nwEDVrJ2()
		{
			return wd5VdB9QLKcIYEiuKeoD;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateOAuthSessionAsync_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<G8kHLefERxBQolNcXL42> __t__builder;

		public HttpClient postClient;

		public string username;

		public Dictionary<string, string> device;

		public CancellationToken cancellationToken;

		public HttpClient followClient;

		private HttpResponseMessage _response_5__2;

		private JsonDocument _document_5__3;

		private HttpResponseMessage _loginResponse_5__4;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object zq1jSn9QVhM3xfI1JDEB;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected O, but got Ref
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0601: Unknown result type (might be due to invalid IL or missing references)
			//IL_0575: Unknown result type (might be due to invalid IL or missing references)
			//IL_051d: Expected O, but got Ref
			//IL_0760: Unknown result type (might be due to invalid IL or missing references)
			//IL_0765: Unknown result type (might be due to invalid IL or missing references)
			//IL_0889: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e6: Invalid comparison between Unknown and I4
			//IL_0787: Unknown result type (might be due to invalid IL or missing references)
			//IL_0789: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a02: Invalid comparison between Unknown and I4
			//IL_0936: Unknown result type (might be due to invalid IL or missing references)
			//IL_093b: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b0: Expected O, but got Ref
			//IL_073f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a72: Expected O, but got I4
			//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab6: Expected I4, but got Unknown
			//IL_0b08: Expected O, but got I4
			//IL_096e: Unknown result type (might be due to invalid IL or missing references)
			//IL_097f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c9a: Expected O, but got I4
			//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd8: Expected I4, but got Unknown
			//IL_0e63: Expected I4, but got O
			//IL_0e74: Expected O, but got I4
			//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc6: Expected O, but got Ref
			//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
			//IL_12f0->IL12b7: Incompatible stack heights: 0 vs 2
			//IL_12bb->IL12bb: Incompatible stack heights: 3 vs 1
			//IL_0096->IL0010: Incompatible stack heights: 3 vs 1
			//IL_00a1->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0286->IL0109: Incompatible stack heights: 13 vs 1
			//IL_05e7->IL0408: Incompatible stack heights: 2 vs 1
			//IL_0b12->IL0665: Incompatible stack heights: 2 vs 1
			//IL_0995->IL0665: Incompatible stack heights: 2 vs 1
			//IL_09a0->IL0665: Incompatible stack heights: 2 vs 1
			//IL_0e7e->IL0b49: Incompatible stack heights: 2 vs 1
			//IL_0c6e->IL0b49: Incompatible stack heights: 2 vs 1
			//IL_0c79->IL0b49: Incompatible stack heights: 2 vs 1
			int num = 3;
			int num4 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__ = default;
			int num22 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val6 = default;
			HttpResponseMessage val4 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__2 = default;
			int num17 = default;
			string text = default;
			ConfiguredTaskAwaitable<string> val2 = default;
			int num13 = default;
			Uri val5 = default;
			JsonElement val7 = default;
			JsonElement val8 = default;
			JsonElement val3 = default;
			int num9 = default;
			Dictionary<string, string> val = default;
			G8kHLefERxBQolNcXL42 g8kHLefERxBQolNcXL = default;
			int num12 = default;
			int num16 = default;
			int num20 = default;
			int num25 = default;
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
							if (num2 != 13)
							{
								if (num2 == 994)
								{
									goto end_IL_0010;
								}
							}
							else
							{
								try
								{
									int num5;
									if (num4 != 0)
									{
										num5 = 11;
										goto IL_0111;
									}
									goto IL_02d1;
									IL_02d1:
									_u__ = __u__1;
									num5 = 10;
									goto IL_0111;
									IL_0111:
									while (true)
									{
										int num21;
										switch (num5)
										{
										default:
											if (num22 != 23 && num22 == 1003)
											{
												goto IL_010d;
											}
											goto case 4;
										case 11:
											if ((uint)(num4 - 1) <= 2u)
											{
												num5 = 13;
												continue;
											}
											goto case 3;
										case 3:
											_ = postClient;
											_ = "https://m.4399api.com/openapiv2/oauth.html";
											_ = "usernames";
											_ = username;
											_ = "top_bar";
											_ = "1";
											_ = "state";
											(string.Empty).PostAsync("device", (HttpContent)(object)JsonSerializer.Serialize<Dictionary<string, string>>(device, (JsonSerializerOptions)null), cancellationToken);
											val6 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
											_ = 6;
											goto IL_0109;
										case 4:
											val4 = (HttpResponseMessage)(object)(&_u__);
											num21 = 5;
											goto IL_0109;
										case 2:
											__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _CreateOAuthSessionAsync_d__31>(ref _u__, ref this);
											num5 = 13;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
											{
												num5 = 14;
											}
											continue;
										case 15:
											break;
										case 12:
											num4 = (__1__state = 0);
											num5 = 9;
											continue;
										case 10:
											__u__1 = default;
											num5 = 16;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
											{
												num5 = 0;
											}
											continue;
										case 9:
											__u__1 = _u__;
											num5 = 2;
											continue;
										case 1:
											if (&_u__ != null)
											{
												num5 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
												{
													num5 = 18;
												}
												continue;
											}
											goto case 12;
										case 6:
											_u__ = val6;
											num5 = 19;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
											{
												num5 = 1;
											}
											continue;
										case 8:
										case 13:
											num5 = 7;
											continue;
										case 5:
											_response_5__2 = val4;
											num5 = 17;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
											{
												num5 = 8;
											}
											continue;
										case 0:
											num4 = (__1__state = -1);
											num21 = 23;
											goto IL_0109;
										case 14:
											return;
										case 7:
											{
												try
												{
													int num6;
													if (num4 != 1)
													{
														num6 = 12;
														goto IL_0408;
													}
													goto IL_0506;
													IL_0506:
													_u__2 = __u__2;
													num6 = 10;
													goto IL_0408;
													IL_0408:
													while (true)
													{
														int num18;
														switch (num6)
														{
														default:
															if (num17 != 24)
															{
																if (num17 == 1004)
																{
																	goto IL_0404;
																}
																goto case 0;
															}
															goto case 16;
														case 3:
															__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _CreateOAuthSessionAsync_d__31>(ref _u__2, ref this);
															num6 = 14;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
															{
																num6 = 24;
															}
															continue;
														case 1:
															_document_5__3 = System.Text.Json.JsonDocument.Parse(text, default(JsonDocumentOptions));
															num6 = 10;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
															{
																num6 = 0;
															}
															continue;
														case 0:
														case 7:
															num18 = 9;
															goto IL_0400;
														case 14:
															return;
														case 8:
															__u__2 = _u__2;
															num6 = 3;
															continue;
														case 5:
															break;
														case 16:
															text = (string)(&_u__2);
															num6 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
															{
																num6 = 3;
															}
															continue;
														case 2:
															if (&_u__2 != null)
															{
																num6 = 16;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
																{
																	num6 = 0;
																}
																continue;
															}
															goto case 6;
														case 13:
															_u__2 = val2;
															num6 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
															{
																num6 = 1;
															}
															continue;
														case 11:
															num4 = (__1__state = -1);
															num18 = 24;
															goto IL_0400;
														case 4:
															((_response_5__2).Content).ReadAsStringAsync(cancellationToken);
															val2 = (ConfiguredTaskAwaitable<string>)0;
															_ = 13;
															continue;
														case 12:
															if ((uint)(num4 - 2) <= 1u)
															{
																num6 = 7;
																continue;
															}
															goto case 15;
														case 10:
															__u__2 = default;
															num6 = 11;
															continue;
														case 15:
															(_response_5__2).EnsureSuccessStatusCode();
															num6 = 4;
															continue;
														case 6:
															num4 = (__1__state = 1);
															num18 = 8;
															goto IL_0400;
														case 9:
															{
																try
																{
																	int num7;
																	if (num4 != 2)
																	{
																		num7 = 8;
																		goto IL_0665;
																	}
																	goto IL_075f;
																	IL_075f:
																	_u__ = __u__1;
																	num7 = 25;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
																	{
																		num7 = 1;
																	}
																	goto IL_0665;
																	IL_0665:
																	while (true)
																	{
																		int num14;
																		switch (num7)
																		{
																		default:
																			if (num13 != 32)
																			{
																				if (num13 == 1012)
																				{
																					goto IL_0661;
																				}
																				goto case 2;
																			}
																			if (string.Equals((val5).Scheme, Uri.UriSchemeHttps, (StringComparison)5))
																			{
																				num7 = 3;
																				continue;
																			}
																			goto case 0;
																		case 2:
																			if (!(val7).TryGetProperty("result", out val8))
																			{
																				num7 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
																				{
																					num7 = 17;
																				}
																				continue;
																			}
																			goto case 13;
																		case 23:
																			_u__ = val6;
																			num7 = 19;
																			continue;
																		case 7:
																			num4 = (__1__state = 2);
																			num7 = 11;
																			continue;
																		case 22:
																			break;
																		case 11:
																			__u__1 = _u__;
																			num7 = 12;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
																			{
																				num7 = 6;
																			}
																			continue;
																		case 16:
																			if (System.Uri.TryCreate((val3).GetString(), (UriKind)1, out val5))
																			{
																				num14 = 32;
																				goto IL_065d;
																			}
																			goto case 0;
																		case 3:
																			if (string.Equals((val5).Host, "ptlogin.4399.com", (StringComparison)5))
																			{
																				num7 = 4;
																				continue;
																			}
																			goto case 0;
																		case 15:
																			num7 = 21;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
																			{
																				num7 = 26;
																			}
																			continue;
																		case 5:
																			if ((val8).TryGetProperty("login_url", out val3))
																			{
																				num7 = 10;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
																				{
																					num7 = 30;
																				}
																				continue;
																			}
																			goto case 0;
																		case 1:
																			__u__1 = default;
																			num7 = 6;
																			continue;
																		case 8:
																			if (num4 != 3)
																			{
																				num7 = 17;
																				continue;
																			}
																			goto case 15;
																		case 18:
																			val4 = (HttpResponseMessage)(object)(&_u__);
																			num7 = 9;
																			continue;
																		case 6:
																			num4 = (__1__state = -1);
																			num7 = 18;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
																			{
																				num7 = 5;
																			}
																			continue;
																		case 20:
																			return;
																		case 17:
																			val7 = (_document_5__3).RootElement;
																			num7 = 2;
																			continue;
																		case 14:
																			throw new global::System.Exception("获取 4399 OAuth 登录地址失败");
																		case 4:
																			(followClient).GetAsync(val5, cancellationToken);
																			val6 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
																			_ = 26;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
																			{
																				_ = 23;
																			}
																			continue;
																		case 9:
																			_loginResponse_5__4 = val4;
																			num7 = 15;
																			continue;
																		case 12:
																			__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _CreateOAuthSessionAsync_d__31>(ref _u__, ref this);
																			num14 = 20;
																			goto IL_065d;
																		case 10:
																			if ((int)(val3).ValueKind == 3)
																			{
																				num7 = 16;
																				continue;
																			}
																			goto case 0;
																		case 13:
																			if ((int)(val8).ValueKind == 1)
																			{
																				num7 = 5;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
																				{
																					num7 = 14;
																				}
																				continue;
																			}
																			goto case 0;
																		case 0:
																		case 24:
																		{
																			_ = "Login4399";
																			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
																			(defaultInterpolatedStringHandler2).AppendLiteral("获取 OAuth 登录地址失败: status=");
																			defaultInterpolatedStringHandler2.AppendFormatted<int>((int)(_response_5__2).StatusCode);
																			(defaultInterpolatedStringHandler2).AppendLiteral(", responseBytes=");
																			defaultInterpolatedStringHandler2.AppendFormatted<int>((text).Length);
																			gX17swyO7x0JWQxdaD1.U3iyRWfbJV((string)40, (defaultInterpolatedStringHandler2).ToStringAndClear());
																			_ = 14;
																			continue;
																		}
																		case 19:
																			if (&_u__ == null)
																			{
																				num7 = 7;
																				continue;
																			}
																			goto case 18;
																		case 21:
																			{
																				try
																				{
																					int num8;
																					if (num4 != 3)
																					{
																						num8 = 14;
																						goto IL_0b41;
																					}
																					goto IL_0ebb;
																					IL_0e7e:
																					__u__2 = default;
																					num8 = 23;
																					goto IL_0b41;
																					IL_0b41:
																					num9 = num8;
																					goto IL_0b45;
																					IL_0b45:
																					int num10 = num9;
																					goto IL_0b49;
																					IL_0b49:
																					while (true)
																					{
																						switch (num10)
																						{
																						case 6:
																							goto end_IL_0b49;
																						case 8:
																						case 13:
																							val = hZBhgkWm11((object)(&_u__2));
																							num10 = 0;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
																							{
																								num10 = 21;
																							}
																							continue;
																						case 10:
																							num4 = (__1__state = 3);
																							num10 = 15;
																							continue;
																						case 5:
																							__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _CreateOAuthSessionAsync_d__31>(ref _u__2, ref this);
																							num10 = 12;
																							continue;
																						case 12:
																							return;
																						case 9:
																							goto IL_0c36;
																						case 7:
																						{
																							_ = "Login4399";
																							global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)6;
																							(defaultInterpolatedStringHandler).AppendLiteral("OAuth 会话就绪: status=");
																							defaultInterpolatedStringHandler.AppendFormatted<int>((int)(_response_5__2).StatusCode);
																							(defaultInterpolatedStringHandler).AppendLiteral(", clientId=");
																							(defaultInterpolatedStringHandler).AppendFormatted(g8kHLefERxBQolNcXL.ClientId);
																							(defaultInterpolatedStringHandler).AppendLiteral(", ");
																							(defaultInterpolatedStringHandler).AppendLiteral("hasRef=");
																							defaultInterpolatedStringHandler.AppendFormatted<bool>(!string.IsNullOrEmpty(g8kHLefERxBQolNcXL.Ref));
																							(defaultInterpolatedStringHandler).AppendLiteral(", hasBizId=");
																							defaultInterpolatedStringHandler.AppendFormatted<bool>(!string.IsNullOrEmpty(g8kHLefERxBQolNcXL.BizId));
																							(defaultInterpolatedStringHandler).AppendLiteral(", ");
																							(defaultInterpolatedStringHandler).AppendLiteral("hasRedirect=");
																							defaultInterpolatedStringHandler.AppendFormatted<bool>(!string.IsNullOrEmpty(g8kHLefERxBQolNcXL.RedirectUri));
																							(defaultInterpolatedStringHandler).AppendLiteral(", formFields=");
																							defaultInterpolatedStringHandler.AppendFormatted<int>((int)val);
																							gX17swyO7x0JWQxdaD1.rShyeXSwgD((string)77, (defaultInterpolatedStringHandler).ToStringAndClear());
																							_ = 6;
																							continue;
																						}
																						case 4:
																							goto IL_0e7e;
																						case 15:
																							__u__2 = _u__2;
																							num10 = 5;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																							{
																								num10 = 11;
																							}
																							continue;
																						case 11:
																							goto IL_0ebb;
																						case 14:
																							(_loginResponse_5__4).EnsureSuccessStatusCode();
																							num10 = 9;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
																							{
																								num10 = 5;
																							}
																							continue;
																						case 1:
																							_u__2 = val2;
																							num10 = 2;
																							continue;
																						case 2:
																							if (&_u__2 != null)
																							{
																								num10 = 8;
																								continue;
																							}
																							goto case 10;
																						case 0:
																							g8kHLefERxBQolNcXL = (G8kHLefERxBQolNcXL42)new G8kHLefERxBQolNcXL42(qIAhtIyjWr(val, "client_id"), qIAhtIyjWr(val, "state"), CollectionExtensions.GetValueOrDefault<string, string>((IReadOnlyDictionary<string, string>)(object)val, "ref") ?? string.Empty, CollectionExtensions.GetValueOrDefault<string, string>((IReadOnlyDictionary<string, string>)(object)val, "bizId") ?? string.Empty, CollectionExtensions.GetValueOrDefault<string, string>((IReadOnlyDictionary<string, string>)(object)val, "redirect_uri") ?? string.Empty);
																							num10 = 0;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
																							{
																								num10 = 7;
																							}
																							continue;
																						case 3:
																							goto end_IL_0b25;
																						}
																						if (num9 != 23)
																						{
																							if (num9 == 1003)
																							{
																								goto IL_0b45;
																							}
																							goto IL_0c36;
																						}
																						num4 = (__1__state = -1);
																						num10 = 13;
																						continue;
																						IL_0c36:
																						((_loginResponse_5__4).Content).ReadAsStringAsync(cancellationToken);
																						val2 = (ConfiguredTaskAwaitable<string>)0;
																						_ = 1;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
																						{
																							_ = 3;
																						}
																						continue;
																						end_IL_0b49:
																						break;
																					}
																					G8kHLefERxBQolNcXL42 g8kHLefERxBQolNcXL2 = g8kHLefERxBQolNcXL;
																					num8 = 3;
																					goto IL_0b41;
																					IL_0ebb:
																					_u__2 = __u__2;
																					num10 = 4;
																					goto IL_0b49;
																					end_IL_0b25:;
																				}
																				finally
																				{
																					if (num4 < 0)
																					{
																						int num11 = 0;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
																						{
																							num11 = 7;
																						}
																						while (true)
																						{
																							switch (num11)
																							{
																							default:
																								if (num12 == 991)
																								{
																									num11 = num12;
																									continue;
																								}
																								goto case 1;
																							case 2:
																								break;
																							case 1:
																								(_loginResponse_5__4).Dispose();
																								num11 = 3;
																								continue;
																							case 0:
																								if (_loginResponse_5__4 == null)
																								{
																									num11 = 1;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
																									{
																										num11 = 2;
																									}
																									continue;
																								}
																								goto case 1;
																							case 3:
																								break;
																							}
																							break;
																						}
																					}
																				}
																				goto end_IL_0665;
																			}
																			IL_0661:
																			num7 = num13;
																			continue;
																			IL_065d:
																			num13 = num14;
																			goto IL_0661;
																		}
																		goto IL_075f;
																		continue;
																		end_IL_0665:
																		break;
																	}
																}
																finally
																{
																	if (num4 < 0)
																	{
																		int num15 = 2;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
																		{
																			num15 = 5;
																		}
																		while (true)
																		{
																			switch (num15)
																			{
																			default:
																				if (num16 == 990)
																				{
																					num15 = num16;
																					continue;
																				}
																				break;
																			case 2:
																				if (_document_5__3 != null)
																				{
																					num15 = 8;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
																					{
																						num15 = 1;
																					}
																					continue;
																				}
																				goto end_IL_1140;
																			case 1:
																				break;
																			case 0:
																				goto end_IL_1140;
																			}
																			(_document_5__3).Dispose();
																			num15 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
																			{
																				num15 = 4;
																			}
																			continue;
																			end_IL_1140:
																			break;
																		}
																	}
																}
																goto end_IL_0408;
															}
															IL_0404:
															num6 = num17;
															continue;
															IL_0400:
															num17 = num18;
															goto IL_0404;
														}
														goto IL_0506;
														continue;
														end_IL_0408:
														break;
													}
												}
												finally
												{
													int num19;
													if (num4 >= 0)
													{
														num19 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
														{
															num19 = 0;
														}
														goto IL_11f7;
													}
													goto IL_125d;
													IL_11f7:
													while (true)
													{
														switch (num19)
														{
														default:
															if (num20 == 991)
															{
																num19 = num20;
																continue;
															}
															goto end_IL_11f7;
														case 3:
															(_response_5__2).Dispose();
															num19 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
															{
																num19 = 2;
															}
															continue;
														case 0:
															goto end_IL_11f7;
														case 2:
															break;
														case 1:
															goto end_IL_11f7;
														}
														goto IL_125d;
														continue;
														end_IL_11f7:
														break;
													}
													goto end_IL_11be;
													IL_125d:
													if (_response_5__2 != null)
													{
														num19 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
														{
															num19 = 5;
														}
														goto IL_11f7;
													}
													end_IL_11be:;
												}
												goto end_IL_0111;
											}
											IL_0109:
											num22 = num21;
											goto IL_010d;
											IL_010d:
											num5 = num22;
											continue;
										}
										goto IL_02d1;
										continue;
										end_IL_0111:
										break;
									}
								}
								catch (global::System.Exception)
								{
									int num23 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
									{
										num23 = 11;
									}
									while (true)
									{
										switch (num23)
										{
										default:
											switch (num25)
											{
											case 992:
												goto end_IL_12bb;
											case 12:
												return;
											}
											goto case 4;
										case 2:
											_loginResponse_5__4 = null;
											num23 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
											{
												num23 = 11;
											}
											break;
										case 1:
											_response_5__2 = null;
											num23 = 3;
											break;
										case 3:
											_document_5__3 = null;
											num23 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
											{
												num23 = 2;
											}
											break;
										case 4:
										{
											_ = __t__builder;
											int num24 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
											{
												num24 = 12;
											}
											num25 = num24;
											break;
										}
										case 0:
											{
												__1__state = -2;
												num23 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
												{
													num23 = 6;
												}
												break;
											}
											end_IL_12bb:
											break;
										}
									}
								}
							}
							goto case 6;
						case 3:
							break;
						case 2:
							_ = __t__builder;
							_ = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
							{
								_ = 4;
							}
							continue;
						case 4:
							_loginResponse_5__4 = null;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
							{
								num3 = 3;
							}
							continue;
						case 5:
							_response_5__2 = null;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							_document_5__3 = null;
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
							{
								num3 = 12;
							}
							continue;
						case 0:
							return;
						case 6:
							__1__state = -2;
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num3 = 0;
							}
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
				num4 = __1__state;
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
				{
					num = 13;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			do
			{
				while (true)
				{
					switch (num)
					{
					case 1:
						_ = __t__builder;
						_ = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
						{
							_ = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto end_IL_0012;
						case 0:
							return;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool hQF8Oo9QYVgpoGQbwjjX()
		{
			return zq1jSn9QVhM3xfI1JDEB == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object tSxQh59QS98Un2jd57sg()
		{
			return zq1jSn9QVhM3xfI1JDEB;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _DesktopLoginCoreAsync_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB> __t__builder;

		public string username;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public CancellationToken cancellationToken;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		public string password;

		public nNU9JoUBxAhVHRZ6PhH realNameInfo;

		public string successMessage;

		public bool retryIncompleteCookie;

		private int _attempt_5__2;

		private Dictionary<string, string> _forms_5__3;

		private HttpResponseMessage _response_5__4;

		private ConfiguredTaskAwaitable<Dictionary<string, string>>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<ValueTuple<bool, bool, string>>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__3;

		private ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter __u__4;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__5;

		internal static object FXSaJr9QcdpAwCmuEwpJ;

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
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								num3 = 2;
								continue;
							}
							goto end_IL_0012;
						case 0:
							return;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
				{
					num = 1;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool z8jCQW9Q0pt3FMCN3RpP()
		{
			return FXSaJr9QcdpAwCmuEwpJ == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object A5SYY19Q87WIMM3sGbLC()
		{
			return FXSaJr9QcdpAwCmuEwpJ;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoginAsync_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB> __t__builder;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		public string username;

		public nNU9JoUBxAhVHRZ6PhH realNameInfo;

		public string password;

		public CancellationToken cancellationToken;

		private Stopwatch _loginStopwatch_5__2;

		private ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter __u__1;

		internal static object S8qgRn9QQ41vPWw4TV5F;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0500: Expected O, but got I4
			//IL_058f: Expected O, but got I4
			//IL_066d: Expected O, but got I4
			//IL_0742: Expected O, but got I4
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Expected O, but got Ref
			//IL_0351: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3->IL048e: Incompatible stack heights: 2 vs 1
			//IL_0756->IL05e6: Incompatible stack heights: 2 vs 1
			//IL_080b->IL0784: Incompatible stack heights: 3 vs 1
			//IL_05ae->IL048e: Incompatible stack heights: 2 vs 1
			//IL_0761->IL05e6: Incompatible stack heights: 2 vs 1
			//IL_0816->IL0784: Incompatible stack heights: 3 vs 1
			//IL_08a1->IL0010: Incompatible stack heights: 3 vs 1
			//IL_08ac->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0350->IL02bd: Incompatible stack heights: 2 vs 1
			int num = 1;
			sDBJG2hcdnUxjaDOenm sDBJG2hcdnUxjaDOenm2 = default;
			int num4 = default;
			int num7 = default;
			int num9 = default;
			ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB> val = default;
			int num11 = default;
			int num13 = default;
			int num15 = default;
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
							if (num2 != 12)
							{
								if (num2 == 993)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							_ = __t__builder;
							_ = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								_ = 7;
							}
							continue;
						case 2:
							return;
						case 0:
							sDBJG2hcdnUxjaDOenm2 = __4__this;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
							{
								num3 = 3;
							}
							continue;
						case 3:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
									{
										num5 = 1;
									}
									goto IL_00af;
								}
								goto IL_00f8;
								IL_00f8:
								System.ObjectDisposedException.ThrowIf(sDBJG2hcdnUxjaDOenm2.tdDUfbM3uQ, sDBJG2hcdnUxjaDOenm2);
								int num6 = 5;
								goto IL_00a7;
								IL_00a7:
								num7 = num6;
								goto IL_00ab;
								IL_00af:
								while (true)
								{
									switch (num5)
									{
									case 0:
									case 1:
										goto IL_00ed;
									case 4:
										goto end_IL_00af;
									case 3:
										goto IL_0139;
									case 5:
										System.ArgumentNullException.ThrowIfNull(captchaCallback, "captchaCallback");
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
										{
											num5 = 3;
										}
										continue;
									case 2:
										try
										{
											int num8;
											if (num4 != 0)
											{
												num8 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
												{
													num8 = 9;
												}
												goto IL_02c5;
											}
											goto IL_03fd;
											IL_02c5:
											while (true)
											{
												switch (num8)
												{
												case 8:
													return;
												default:
													switch (num9)
													{
													case 999:
														break;
													default:
														goto end_IL_02c5;
													case 19:
														_u__ = val;
														num8 = 5;
														continue;
													}
													goto IL_02c1;
												case 9:
													sDBJG2hcdnUxjaDOenm2.mpuhy2Ntsb(username, password, realNameInfo, captchaCallback, retryIncompleteCookie: true, null, cancellationToken);
													val = (ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>)0;
													_ = 19;
													goto IL_02bd;
												case 7:
													__u__1 = _u__;
													num8 = 11;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
													{
														num8 = 8;
													}
													continue;
												case 11:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter, _LoginAsync_d__22>(ref _u__, ref this);
													num8 = 8;
													continue;
												case 5:
													if (&_u__ != null)
													{
														num8 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
														{
															num8 = 15;
														}
														continue;
													}
													goto case 0;
												case 0:
													num4 = (__1__state = 0);
													num8 = 7;
													continue;
												case 4:
													break;
												case 6:
													num4 = (__1__state = -1);
													num8 = 3;
													continue;
												case 1:
												case 3:
												{
													t30hHHfP8gMStFdbd6rB t30hHHfP8gMStFdbd6rB = (t30hHHfP8gMStFdbd6rB)(&_u__);
													goto IL_02bd;
												}
												case 10:
													__u__1 = default;
													num8 = 6;
													continue;
												case 2:
													goto end_IL_02c5;
													IL_02bd:
													num9 = 2;
													goto IL_02c1;
													IL_02c1:
													num8 = num9;
													continue;
												}
												goto IL_03fd;
												continue;
												end_IL_02c5:
												break;
											}
											goto end_IL_028d;
											IL_03fd:
											_u__ = __u__1;
											num8 = 10;
											goto IL_02c5;
											end_IL_028d:;
										}
										catch (OperationCanceledException)
										{
											int num10 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
											{
												num10 = 3;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													if (num11 == 990)
													{
														num10 = num11;
														continue;
													}
													break;
												case 0:
												{
													t30hHHfP8gMStFdbd6rB t30hHHfP8gMStFdbd6rB = t30hHHfP8gMStFdbd6rB.Fail("操作已取消");
													num10 = 2;
													continue;
												}
												case 1:
												{
													_ = "Login4399";
													global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
													(defaultInterpolatedStringHandler).AppendLiteral("4399 桌面登录被取消: username=");
													(defaultInterpolatedStringHandler).AppendFormatted(username);
													(defaultInterpolatedStringHandler).AppendLiteral(", elapsedMs=");
													defaultInterpolatedStringHandler.AppendFormatted<long>((_loginStopwatch_5__2).ElapsedMilliseconds);
													gX17swyO7x0JWQxdaD1.U3iyRWfbJV((string)35, (defaultInterpolatedStringHandler).ToStringAndClear());
													_ = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
													{
														_ = 0;
													}
													continue;
												}
												case 2:
													break;
												}
												break;
											}
										}
										catch (global::System.Exception ex2)
										{
											int num12 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
											{
												num12 = 3;
											}
											while (true)
											{
												switch (num12)
												{
												default:
													if (num13 == 990)
													{
														num12 = num13;
														continue;
													}
													break;
												case 0:
												{
													t30hHHfP8gMStFdbd6rB t30hHHfP8gMStFdbd6rB = t30hHHfP8gMStFdbd6rB.Fail(string.Concat("4399 Desktop 登录异常：", (ex2).Message));
													num12 = 2;
													continue;
												}
												case 1:
												{
													_ = "Login4399";
													global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
													(defaultInterpolatedStringHandler2).AppendLiteral("4399 桌面登录异常: username=");
													(defaultInterpolatedStringHandler2).AppendFormatted(username);
													(defaultInterpolatedStringHandler2).AppendLiteral(", elapsedMs=");
													defaultInterpolatedStringHandler2.AppendFormatted<long>((_loginStopwatch_5__2).ElapsedMilliseconds);
													(defaultInterpolatedStringHandler2).AppendLiteral(", error=");
													(defaultInterpolatedStringHandler2).AppendFormatted((ex2).Message);
													gX17swyO7x0JWQxdaD1.TyQywPUFFh((string)42, (defaultInterpolatedStringHandler2).ToStringAndClear(), ex2);
													_ = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
													{
														_ = 3;
													}
													continue;
												}
												case 2:
													break;
												}
												break;
											}
										}
										goto end_IL_0077;
									}
									if (num7 != 13)
									{
										if (num7 == 993)
										{
											goto IL_00ab;
										}
										goto IL_00ed;
									}
									gX17swyO7x0JWQxdaD1.IdOy6I4Chb("Login4399", string.Concat("4399 桌面登录开始: username=", username, ", realName=", ((object)realNameInfo == null) ? "未提供" : "已提供"));
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
									{
										num5 = 12;
									}
									continue;
									IL_00ed:
									num5 = 2;
									continue;
									end_IL_00af:
									break;
								}
								goto IL_00f8;
								IL_00ab:
								num5 = num7;
								goto IL_00af;
								IL_0139:
								_loginStopwatch_5__2 = System.Diagnostics.Stopwatch.StartNew();
								num6 = 13;
								goto IL_00a7;
								end_IL_0077:;
							}
							catch (global::System.Exception)
							{
								int num14 = 2;
								while (true)
								{
									switch (num14)
									{
									case 0:
										return;
									default:
										if (num15 != 10)
										{
											if (num15 == 990)
											{
												goto IL_0780;
											}
											goto case 2;
										}
										_loginStopwatch_5__2 = null;
										num14 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
										{
											num14 = 3;
										}
										break;
									case 2:
										__1__state = -2;
										num15 = 10;
										goto IL_0780;
									case 1:
										{
											_ = __t__builder;
											_ = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
											{
												_ = 8;
											}
											break;
										}
										IL_0780:
										num14 = num15;
										break;
									}
								}
							}
							goto case 4;
						case 1:
							num4 = __1__state;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								num3 = 4;
							}
							continue;
						case 5:
							break;
						case 4:
							__1__state = -2;
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
							{
								num3 = 5;
							}
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
				_loginStopwatch_5__2 = null;
				num = 12;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
								{
									num3 = 8;
								}
								continue;
							}
							goto end_IL_0012;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
						case 1:
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
				{
					num = 5;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool APX1dV9QCZwXpAQG5yq0()
		{
			return S8qgRn9QQ41vPWw4TV5F == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object MLV4819Q4NSM15MSQ2Dl()
		{
			return S8qgRn9QQ41vPWw4TV5F;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoginCoreAsync_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB> __t__builder;

		public string username;

		public bool retryIncompleteCookie;

		public CancellationToken cancellationToken;

		public string password;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		public nNU9JoUBxAhVHRZ6PhH realNameInfo;

		public string successMessage;

		private string _captchaCode_5__2;

		private string _captchaId_5__3;

		private int _attempt_5__4;

		private HttpClient _mobileHttp_5__5;

		private HttpResponseMessage _response_5__6;

		private ConfiguredTaskAwaitable<G8kHLefERxBQolNcXL42>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__3;

		private Dictionary<string, string> _captchaForms_5__7;

		private ConfiguredTaskAwaitable<ValueTuple<bool, bool, string>>.ConfiguredTaskAwaiter __u__4;

		private ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter __u__5;

		internal static object ORDlb59QhiM3PGwmWsdo;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
						case 0:
							return;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 1;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool d6i3B09QUl2bsBaJyUVm()
		{
			return ORDlb59QhiM3PGwmWsdo == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object ncyEVC9QrJZufuQwTCAR()
		{
			return ORDlb59QhiM3PGwmWsdo;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _PostPtloginFormAsync_d__38 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder;

		public string url;

		public IReadOnlyDictionary<string, string> form;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public CancellationToken cancellationToken;

		private HttpRequestMessage _request_5__2;

		private Stopwatch _requestStopwatch_5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		internal static object Fu52Bi9QoxZm3nbvmKII;

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
			//IL_004c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			while (true)
			{
				while (true)
				{
					switch (num)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_ = __t__builder;
					_ = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
					{
						_ = 0;
					}
				}
			}
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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 2;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						case 0:
							return;
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
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool g3CRW79QmphfRSXcylNP()
		{
			return Fu52Bi9QoxZm3nbvmKII == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object W4vDHW9Q7i5OmMwTYlT9()
		{
			return Fu52Bi9QoxZm3nbvmKII;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadOAuthCallbackAsync_d__34 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<Wl2fv0UW3tuhZfbWA4W> __t__builder;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public Uri callbackUri;

		public CancellationToken cancellationToken;

		private Stopwatch _callbackStopwatch_5__2;

		private HttpResponseMessage _response_5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object YGKKef9QAHhuAnrjrfbV;

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
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
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
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							continue;
						case 1:
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool dmW6Wc9QI85j5vEFLfJb()
		{
			return YGKKef9QAHhuAnrjrfbV == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object XqZ3uA9QBa814fetYdso()
		{
			return YGKKef9QAHhuAnrjrfbV;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RegisterOAuthLegacyAsync_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB> __t__builder;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public nNU9JoUBxAhVHRZ6PhH realNameInfo;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		public string username;

		public string password;

		public CancellationToken cancellationToken;

		private bool _accountCreated_5__2;

		private Stopwatch _registerStopwatch_5__3;

		private int _requestRefreshes_5__4;

		private object __u__1;

		private int _attempt_5__5;

		private Dictionary<string, string> _forms_5__6;

		private HttpResponseMessage _response_5__7;

		private ConfiguredTaskAwaitable<Dictionary<string, string>>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<ValueTuple<bool, bool, string>>.ConfiguredTaskAwaiter __u__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__4;

		private ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter __u__5;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__6;

		private static object hlh8XX9Qgh0Qt8wGEXWl;

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
						case 1:
							return;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
							{
								num3 = 0;
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
		internal static bool CYg9xK9QlmZyDq3UD7eI()
		{
			return hlh8XX9Qgh0Qt8wGEXWl == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object nHG7kr9Qd7hXn1LWOGUB()
		{
			return hlh8XX9Qgh0Qt8wGEXWl;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RegisterWebAsync_d__55 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB> __t__builder;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public nNU9JoUBxAhVHRZ6PhH realNameInfo;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		public string username;

		public string password;

		public CancellationToken cancellationToken;

		private bool _accountCreated_5__2;

		private int _attempt_5__3;

		private HttpClient _webHttp_5__4;

		private HttpResponseMessage _formResponse_5__5;

		private Dictionary<string, string> _forms_5__6;

		private string _captchaId_5__7;

		private HttpRequestMessage _request_5__8;

		private HttpResponseMessage _response_5__9;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<ValueTuple<bool, bool, string, string>>.ConfiguredTaskAwaiter __u__3;

		private object __u__4;

		internal static object N5DQnG9QKNq28Lu8EVcC;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								return;
							}
							goto end_IL_0012;
						case 0:
							num3 = 2;
							continue;
						case 2:
							break;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num3 = 2;
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
				while (num2 == 990);
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool JD4IqL9QH3qi5YSG7XQj()
		{
			return N5DQnG9QKNq28Lu8EVcC == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object QswFbr9QtSS1VdxsoHKU()
		{
			return N5DQnG9QKNq28Lu8EVcC;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RequestFormsAsync_d__32 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<Dictionary<string, string>> __t__builder;

		public sDBJG2hcdnUxjaDOenm __4__this;

		public YEOxnTfE6YtoCRHAQAYp action;

		public CancellationToken cancellationToken;

		private G8kHLefERxBQolNcXL42 _session_5__2;

		private HttpResponseMessage _response_5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object SccfQD9QOm6v1LJpA7lr;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							continue;
						case 2:
							return;
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
				num = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool i5joDa9Q50N0TVXb7y4x()
		{
			return SccfQD9QOm6v1LJpA7lr == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object e0Uv6r9Q68qghu3AOgwZ()
		{
			return SccfQD9QOm6v1LJpA7lr;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RequestWebCaptchaAsync_d__57 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<ValueTuple<bool, bool, string, string>> __t__builder;

		public HttpClient client;

		public string captchaId;

		public CancellationToken cancellationToken;

		public Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback;

		private HttpResponseMessage _response_5__2;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<string?>.ConfiguredTaskAwaiter __u__3;

		private static object eskXQx9QRKKHloJjnjHi;

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
						case 1:
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
						case 0:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool xbaS6H9QwmPlv7OhBmTx()
		{
			return eskXQx9QRKKHloJjnjHi == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object EqvF8A9Qe2seIPJYXm0m()
		{
			return eskXQx9QRKKHloJjnjHi;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendWebGetAsync_d__56 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder;

		public string url;

		public string referer;

		public HttpClient client;

		public CancellationToken cancellationToken;

		private HttpRequestMessage _request_5__2;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private static object uqqMDN9QsgDKoV8hZy02;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_00dd: Expected native int or pointer, but got O
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Expected O, but got Ref
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ed->IL0551: Incompatible stack heights: 3 vs 1
			//IL_05f8->IL0551: Incompatible stack heights: 3 vs 1
			//IL_064b->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0656->IL0010: Incompatible stack heights: 3 vs 1
			//IL_00ec->IL00a7: Incompatible stack heights: 2 vs 1
			//IL_02c3->IL0130: Incompatible stack heights: 2 vs 1
			//IL_02ce->IL0130: Incompatible stack heights: 2 vs 1
			int num = 4;
			int num4 = default;
			int num6 = default;
			int num8 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val = default;
			int num15 = default;
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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							_ = __t__builder;
							_ = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
							{
								_ = 3;
							}
							continue;
						case 2:
							_request_5__2 = null;
							num = 11;
							break;
						case 0:
							__1__state = -2;
							num = 2;
							break;
						case 1:
							return;
						case 3:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
									{
										num5 = 0;
									}
									goto IL_00a7;
								}
								goto IL_00ec;
								IL_00a7:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 == 990)
										{
											num5 = num6;
											continue;
										}
										goto case 1;
									case 0:
										global::System.Runtime.CompilerServices.Unsafe.Write(&((_SendWebGetAsync_d__56*)(nint)System.Net.Http.HttpMethod.Get)->_request_5__2, url);
										_ = 2;
										continue;
									case 2:
										break;
									case 1:
										try
										{
											int num7;
											if (num4 != 0)
											{
												num7 = 8;
												goto IL_0130;
											}
											goto IL_0369;
											IL_0183:
											if (num8 == 1003)
											{
												goto IL_012c;
											}
											goto IL_0369;
											IL_0130:
											while (true)
											{
												switch (num7)
												{
												case 14:
													return;
												case 9:
													((_request_5__2).Headers).TryAddWithoutValidation("Sec-Fetch-Site", "same-site");
													num7 = 13;
													continue;
												case 12:
													if (&_u__ != null)
													{
														num7 = 18;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
														{
															num7 = 6;
														}
														continue;
													}
													goto case 3;
												case 13:
													((_request_5__2).Headers).TryAddWithoutValidation("Sec-Fetch-Mode", "navigate");
													num7 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
													{
														num7 = 6;
													}
													continue;
												case 7:
													(client).SendAsync(_request_5__2, cancellationToken);
													val = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
													_ = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
													{
														_ = 3;
													}
													continue;
												case 8:
													((_request_5__2).Headers).Referrer = (Uri)(object)referer;
													num7 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
													{
														num7 = 9;
													}
													continue;
												case 15:
													goto end_IL_0130;
												case 5:
													__u__1 = _u__;
													num7 = 10;
													continue;
												case 6:
												case 11:
												{
													HttpResponseMessage val2 = (HttpResponseMessage)(object)(&_u__);
													num7 = 4;
													continue;
												}
												case 1:
													goto IL_0369;
												case 10:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _SendWebGetAsync_d__56>(ref _u__, ref this);
													num7 = 14;
													continue;
												case 3:
													num4 = (__1__state = 0);
													num7 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
													{
														num7 = 5;
													}
													continue;
												case 2:
													_u__ = val;
													num7 = 12;
													continue;
												case 0:
													((_request_5__2).Headers).TryAddWithoutValidation("Sec-Fetch-Dest", "iframe");
													num7 = 7;
													continue;
												case 4:
													goto end_IL_010d;
												}
												if (num8 == 23)
												{
													num4 = (__1__state = -1);
													num7 = 11;
													continue;
												}
												goto IL_0183;
												continue;
												end_IL_0130:
												break;
											}
											__u__1 = default;
											int num9 = 23;
											goto IL_0128;
											IL_012c:
											num7 = num8;
											goto IL_0130;
											IL_0128:
											num8 = num9;
											goto IL_012c;
											IL_0369:
											_u__ = __u__1;
											num9 = 15;
											goto IL_0128;
											end_IL_010d:;
										}
										finally
										{
											if (num4 < 0)
											{
												int num10 = 3;
												while (true)
												{
													IL_0485:
													int num11 = num10;
													while (true)
													{
														IL_0489:
														int num12 = num11;
														while (true)
														{
															switch (num12)
															{
															default:
																goto IL_04a2;
															case 1:
																break;
															case 2:
																goto end_IL_048d;
															case 3:
																if (_request_5__2 != null)
																{
																	break;
																}
																goto IL_0513;
															case 0:
																goto end_IL_048d;
															}
															goto IL_04b5;
															IL_04a2:
															if (num11 == 991)
															{
																goto IL_0489;
															}
															goto IL_04b5;
															IL_04b5:
															(_request_5__2).Dispose();
															num12 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
															{
																num12 = 3;
															}
															continue;
															end_IL_048d:
															break;
														}
														break;
														IL_0513:
														num10 = 2;
														goto IL_0485;
													}
													break;
												}
											}
										}
										goto end_IL_00a7;
									}
									goto IL_00ec;
									continue;
									end_IL_00a7:
									break;
								}
								goto end_IL_006f;
								IL_00ec:
								num5 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
								{
									num5 = 1;
								}
								goto IL_00a7;
								end_IL_006f:;
							}
							catch (global::System.Exception)
							{
								int num13 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
								{
									num13 = 7;
								}
								while (true)
								{
									switch (num13)
									{
									case 2:
										return;
									default:
										if (num15 != 10)
										{
											if (num15 == 990)
											{
												goto IL_054d;
											}
											goto case 1;
										}
										_request_5__2 = null;
										num13 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
										{
											num13 = 9;
										}
										break;
									case 1:
									{
										__1__state = -2;
										int num14 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
										{
											num14 = 4;
										}
										num15 = num14;
										goto IL_054d;
									}
									case 0:
										{
											_ = __t__builder;
											_ = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
											{
												_ = 2;
											}
											break;
										}
										IL_054d:
										num13 = num15;
										break;
									}
								}
							}
							goto case 0;
						case 4:
							num4 = __1__state;
							num3 = 3;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004d->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0058->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			do
			{
				while (true)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						_ = __t__builder;
						_ = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 9)
							{
								return;
							}
							goto end_IL_0012;
						case 0:
							num3 = 2;
							continue;
						case 2:
							break;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
							{
								num3 = 3;
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
				while (num2 == 990);
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool rNVCsP9QT2UtNChdSNuA()
		{
			return uqqMDN9QsgDKoV8hZy02 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object XSxQ8f9QNTMMgg3YqbLY()
		{
			return uqqMDN9QsgDKoV8hZy02;
		}
	}

	private static readonly object yEJhi4Rdhu;

	private readonly object TZYhneKJlN;

	private readonly object st1hzQBqBK;

	private readonly object cyIUb4AetY;

	private G8kHLefERxBQolNcXL42? W3CUXVAGoa;

	private bool tdDUfbM3uQ;

	private static object h7olOmZ0ZlbXIbyC9R9n;

	[MethodImpl((MethodImplOptions)8)]
	public sDBJG2hcdnUxjaDOenm()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> LoginAsync(string username, string password, nNU9JoUBxAhVHRZ6PhH? realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, CancellationToken cancellationToken)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.realNameInfo = realNameInfo;
		_ = 2;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053;
		_ = 11;
		obj.captchaCallback = captchaCallback;
		_ = 15;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_LoginAsync_d__22*)null)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> HKUh8Ahpeh(string username, string password, nNU9JoUBxAhVHRZ6PhH realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, CancellationToken cancellationToken)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.realNameInfo = realNameInfo;
		_ = 8;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037;
		_ = 7;
		obj.__1__state = -1;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_RegisterOAuthLegacyAsync_d__23*)3)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> mpuhy2Ntsb(string username, string password, nNU9JoUBxAhVHRZ6PhH? realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, bool retryIncompleteCookie, string? successMessage, CancellationToken cancellationToken)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.username = username;
		_ = 10;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce;
		_ = 7;
		obj.__4__this = this;
		_ = 9;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_LoginCoreAsync_d__24*)null)->__t__builder, ref obj);
		((AsyncTaskMethodBuilder)9).AwaitUnsafeOnCompleted<TaskAwaiter<IBuffer>, lskjRmm2JeVZWsE0GiI._SaveAsync_d__4>(ref *(TaskAwaiter<IBuffer>*)(&obj.__t__builder), ref *(lskjRmm2JeVZWsE0GiI._SaveAsync_d__4*)(&obj));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> AxXhW4HdAH(string responseBody, nNU9JoUBxAhVHRZ6PhH realNameInfo, string username, string password, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, bool retryIncompleteCookie, string? successMessage, CancellationToken cancellationToken)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__1__state = -1;
		_ = 3;
		obj.cancellationToken = cancellationToken;
		_ = 16;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_CompleteRealNameAsync_d__25*)1)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> DylhJY5dVm(string responseBody, nNU9JoUBxAhVHRZ6PhH realNameInfo, string username, string password, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> DMqhQmntX2(string username, string password, nNU9JoUBxAhVHRZ6PhH? realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, bool retryIncompleteCookie, string? successMessage, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.cancellationToken = cancellationToken;
		_ = 17;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e;
		((AsyncTaskMethodBuilder)0).AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter, lskjRmm2JeVZWsE0GiI._SaveAsync_d__4>(ref *(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter*)(&obj.__t__builder), ref *(lskjRmm2JeVZWsE0GiI._SaveAsync_d__4*)(&obj));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> O70hCb2j0L(Uri? location, string username, string password, nNU9JoUBxAhVHRZ6PhH? realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, bool retryIncompleteCookie, string? successMessage, CancellationToken cancellationToken)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.username = username;
		_ = 8;
		obj.captchaCallback = captchaCallback;
		_ = 7;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b;
		((AsyncTaskMethodBuilder<z2DZpauKHUbfBplLI1Q>*)9)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<qlD47ZXbusnos4ic8bvZ>.ConfiguredTaskAwaiter, KxOGVaFL8AQcstEY1GC._ResolveExternalConnectionTargetAsync_d__118>(ref this, ref this);
		_ = 16;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_CompleteOAuthAsync_d__28*)null)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task yxHh41DBDM(CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Threading.Tasks.Task<G8kHLefERxBQolNcXL42> bU3hhd7IsM(object username, object postClient, object followClient, CancellationToken cancellationToken)
	{
		//IL_0009: Expected O, but got I4
		object obj = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<G8kHLefERxBQolNcXL42> je1hUMLBN5(object username, Dictionary<string, string> device, object postClient, object followClient, CancellationToken cancellationToken)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.followClient = (HttpClient)followClient;
		_ = 14;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55;
		_ = 10;
		obj.cancellationToken = cancellationToken;
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_CreateOAuthSessionAsync_d__31*)3)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<Dictionary<string, string>> Iv9hrESj9U(YEOxnTfE6YtoCRHAQAYp action, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.action = action;
		_ = 3;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25;
		((AsyncTaskMethodBuilder<nNU9JoUBxAhVHRZ6PhH>*)7)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<nNU9JoUBxAhVHRZ6PhH>.ConfiguredTaskAwaiter, LqCNIN7faHo3aBdfb2m._GetRandomRealNameAsync_d__9>(ref this, ref this);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<ValueTuple<bool, bool, string>> aTphoeFDxm(Dictionary<string, string> forms, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, CancellationToken cancellationToken, HttpClient? httpClient = null)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<Wl2fv0UW3tuhZfbWA4W> jZUhmIk5pS(Uri callbackUri, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.__1__state = -1;
		_ = 4;
		obj.callbackUri = callbackUri;
		_ = 3;
		_ = obj;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private HttpClient BXYh7AnT0A(bool allowAutoRedirect)
	{
		return XanhAV2VW4(allowAutoRedirect, TZYhneKJlN);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient XanhAV2VW4(bool allowAutoRedirect, object cookies)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(HttpClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient UiDhIc4ffE(object cookies)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(HttpClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<HttpResponseMessage> MyyhBARicd(string url, IReadOnlyDictionary<string, string> form, CancellationToken cancellationToken)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.url = url;
		_ = 5;
		obj.cancellationToken = cancellationToken;
		_ = 3;
		obj.__4__this = this;
		_ = 6;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3;
		_ = 12;
		obj.form = form;
		_ = 1;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e;
		((AsyncTaskMethodBuilder)11).AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<px22fhXLZYPdnK7dFjdy>.ConfiguredTaskAwaiter, KxOGVaFL8AQcstEY1GC._StopInstanceAsync_d__97>(ref *(ConfiguredTaskAwaitable<px22fhXLZYPdnK7dFjdy>.ConfiguredTaskAwaiter*)(&obj.__t__builder), ref *(KxOGVaFL8AQcstEY1GC._StopInstanceAsync_d__97*)(&obj));
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_PostPtloginFormAsync_d__38*)4)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Dictionary<string, string> hZBhgkWm11(object html, string? stopBefore = null)
	{
		//IL_000c: Expected O, but got I4
		//IL_003d: Expected I4, but got O
		//IL_00d3: Expected I4, but got O
		//IL_0079: Expected O, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0137: Expected O, but got I4
		//IL_011e->IL0010: Incompatible stack types: I4 vs O
		//IL_02d2->IL0010: Incompatible stack types: I4 vs O
		//IL_00c5->IL0010: Incompatible stack types: I4 vs O
		//IL_00df->IL0010: Incompatible stack types: I4 vs O
		//IL_0107->IL0010: Incompatible stack types: I4 vs O
		//IL_0129->IL0010: Incompatible stack types: I4 vs O
		//IL_02dd->IL0010: Incompatible stack types: I4 vs O
		//IL_02a6->IL0010: Incompatible stack types: I4 vs O
		//IL_02b1->IL0010: Incompatible stack types: I4 vs O
		//IL_0168->IL0137: Incompatible stack heights: 0 vs 3
		//IL_013b->IL013b: Incompatible stack heights: 4 vs 1
		int num = 2;
		object obj4 = default;
		object obj3 = default;
		object obj8 = default;
		object result = default;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
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
						if ((nint)obj != 16)
						{
							if ((nint)obj == 997)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						if ((nint)obj4 < 0)
						{
							obj2 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
							{
								obj2 = 7;
							}
							continue;
						}
						goto case 5;
					case 8:
						obj4 = (html).IndexOf(stopBefore, (StringComparison)5);
						num = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num = 16;
						}
						break;
					case 4:
					case 7:
						obj3 = "<input(?=[^>]*type=[\"']hidden[\"'])(?=[^>]*name=[\"']([^\"']+)[\"'])(?=[^>]*value=[\"']([^\"']*)[\"'])[^>]*>";
						obj2 = 6;
						continue;
					case 5:
						obj8 = (html).Substring(0, (int)obj4);
						obj2 = 4;
						continue;
					case 9:
						return (Dictionary<string, string>)result;
					case 6:
						obj5 = (System.Text.RegularExpressions.Regex.Matches((string)obj8, (string)obj3, (RegexOptions)1)).GetEnumerator();
						obj2 = 3;
						continue;
					case 1:
						obj8 = html;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
						{
							obj2 = 6;
						}
						continue;
					case 3:
						while (true)
						{
							IL_01e5:
							int num2;
							if (!(obj5).MoveNext())
							{
								num2 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
								{
									num2 = 2;
								}
								goto IL_013b;
							}
							goto IL_0215;
							IL_0215:
							obj6 = (object)(FileAttributes)(obj5).Current;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								num2 = 6;
							}
							goto IL_013b;
							IL_013b:
							while (true)
							{
								switch (num2)
								{
								case 1:
									break;
								default:
									if ((nint)obj7 == 10)
									{
										goto IL_01e5;
									}
									if ((nint)obj7 == 990)
									{
										continue;
									}
									goto case 0;
								case 0:
								{
									System.Net.WebUtility.HtmlDecode((((obj6).Groups).Item).Value);
									System.Net.WebUtility.HtmlDecode((((obj6).Groups).Item).Value);
									int num3 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
									{
										num3 = 10;
									}
									obj7 = num3;
									continue;
								}
								case 2:
									goto IL_0215;
								}
								break;
							}
							break;
						}
						goto case 9;
					case 0:
						if (!string.IsNullOrEmpty(stopBefore))
						{
							num = 8;
							break;
						}
						goto case 4;
					case 2:
						result = System.StringComparer.Ordinal;
						obj2 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
						{
							obj2 = 1;
						}
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool nvVhl7nRbr(object html)
	{
		return (html).Contains("验证码错误", (StringComparison)4);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool eyfhdMvROj(HttpStatusCode statusCode, object html)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_006d->IL0010: Incompatible stack types: I4 vs O
		//IL_00e5->IL0010: Incompatible stack types: I4 vs O
		//IL_0078->IL0010: Incompatible stack types: I4 vs O
		//IL_00f0->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						goto IL_00a3;
					case 2:
						if ((int)statusCode != 429)
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto IL_00a3;
					case 3:
						return (html).Contains("风控", (StringComparison)4);
					case 5:
						return true;
					case 0:
						if ((html).Contains("请稍后再试", (StringComparison)4))
						{
							num = 5;
							break;
						}
						goto case 4;
					case 4:
						if (!(html).Contains("系统繁忙", (StringComparison)4))
						{
							num = 3;
							break;
						}
						goto case 5;
					case 1:
						{
							if ((int)statusCode != 202)
							{
								if (!(html).Contains("请求频率过快", (StringComparison)4))
								{
									obj2 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
									{
										obj2 = 3;
									}
									continue;
								}
								goto case 5;
							}
							num = 12;
							break;
						}
						IL_00a3:
						return true;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool zJUhKSmwnU(object? message)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_00eb->IL0010: Incompatible stack types: I4 vs O
		//IL_0144->IL0010: Incompatible stack types: I4 vs O
		//IL_008e->IL0010: Incompatible stack types: I4 vs O
		//IL_00f6->IL0010: Incompatible stack types: I4 vs O
		//IL_014f->IL0010: Incompatible stack types: I4 vs O
		//IL_0099->IL0010: Incompatible stack types: I4 vs O
		int num = 3;
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						goto IL_011e;
					case 4:
						if (!(message).Contains("帐号异常", (StringComparison)4))
						{
							obj2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto IL_011e;
					case 1:
						if (!(message).Contains("账户异常", (StringComparison)4))
						{
							obj2 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto IL_011e;
					case 0:
						return (message).Contains("用户不存在", (StringComparison)4);
					case 3:
						if (!string.IsNullOrWhiteSpace((string)message))
						{
							obj2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 5;
					case 5:
						return false;
					case 2:
						{
							if ((message).Contains("账号异常", (StringComparison)4))
							{
								break;
							}
							goto case 4;
						}
						IL_011e:
						return true;
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
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string c4khHBM5xq(object html, object fallback)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string qIAhtIyjWr(Dictionary<string, string> values, object key)
	{
		object obj = default;
		_ = obj;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_006e->IL0010: Incompatible stack types: I4 vs O
		//IL_00b2->IL0010: Incompatible stack types: I4 vs O
		//IL_00d7->IL0010: Incompatible stack types: I4 vs O
		//IL_0079->IL0010: Incompatible stack types: I4 vs O
		//IL_00bd->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
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
						if ((nint)obj == 11)
						{
							(cyIUb4AetY).Dispose();
							obj2 = 4;
							continue;
						}
						goto end_IL_0010;
					case 4:
						return;
					case 3:
						return;
					case 1:
						tdDUfbM3uQ = true;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							obj2 = 5;
						}
						continue;
					case 0:
						break;
					case 2:
						if (tdDUfbM3uQ)
						{
							return;
						}
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
						{
							obj2 = 11;
						}
						continue;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if ((nint)obj != 992)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			(st1hzQBqBK).Dispose();
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> w29hOlGhWe(string username, string password, nNU9JoUBxAhVHRZ6PhH? realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, string? successMessage, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> DZJh57OoOq(string username, string password, nNU9JoUBxAhVHRZ6PhH realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return WQRh6tZj85(username, password, realNameInfo, captchaCallback, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<t30hHHfP8gMStFdbd6rB> WQRh6tZj85(string username, string password, nNU9JoUBxAhVHRZ6PhH realNameInfo, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, CancellationToken cancellationToken)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__4__this = this;
		_ = 7;
		obj.realNameInfo = realNameInfo;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_RegisterWebAsync_d__55*)2)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<HttpResponseMessage> iuohRr3EXW(object client, object url, object referer, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.client = (HttpClient)client;
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04;
		((AsyncTaskMethodBuilder)12).AwaitUnsafeOnCompleted<object, KxOGVaFL8AQcstEY1GC._SuppressWaitAsync_d__90>(ref *(object*)(&obj.__t__builder), ref *(KxOGVaFL8AQcstEY1GC._SuppressWaitAsync_d__90*)(&obj));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<ValueTuple<bool, bool, string, string>> tKXhwxtTEj(object client, object captchaId, Func<string, CancellationToken, global::System.Threading.Tasks.Task<string?>> captchaCallback, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.captchaCallback = captchaCallback;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? Ly9hePLm2Q(object html)
	{
		//IL_000c: Expected O, but got I4
		//IL_0041: Expected I4, but got O
		//IL_0084: Expected O, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_008e->IL0010: Incompatible stack types: I4 vs O
		//IL_01f4->IL0010: Incompatible stack types: I4 vs O
		//IL_0134->IL0010: Incompatible stack types: I4 vs O
		//IL_01ff->IL0010: Incompatible stack types: I4 vs O
		//IL_0231->IL0010: Incompatible stack types: I4 vs O
		//IL_00de->IL0010: Incompatible stack types: I4 vs O
		//IL_0196->IL0010: Incompatible stack types: I4 vs O
		//IL_013f->IL0010: Incompatible stack types: I4 vs O
		//IL_00e9->IL0010: Incompatible stack types: I4 vs O
		//IL_010e->IL0010: Incompatible stack types: I4 vs O
		//IL_0119->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
		object obj5 = default;
		object obj3 = default;
		object obj4 = default;
		object obj6 = default;
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
						if ((nint)obj != 17)
						{
							if ((nint)obj == 998)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						if (!(obj5).Success)
						{
							obj2 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 8;
					case 1:
						obj3 = 0;
						obj2 = 5;
						continue;
					case 0:
						return null;
					case 6:
						break;
					case 4:
					case 5:
						if ((nint)obj3 >= ((global::System.Array)obj4).Length)
						{
							obj2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 10;
					case 10:
						obj6 = ((object[])obj4)[obj3];
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
						{
							obj2 = 6;
						}
						continue;
					case 8:
						if (((((obj5).Groups).Item).Value).Contains("<%", (StringComparison)4))
						{
							obj2 = 3;
							continue;
						}
						goto case 7;
					case 2:
						obj4 = new object[2]
						{
							(object)"captcha\\.do\\?captchaId=([A-Za-z0-9_-]{8,128})",
							(object)"captchaId=[\\\"']([A-Za-z0-9_-]{8,128})[\\\"']"
						};
						obj2 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
						{
							obj2 = 1;
						}
						continue;
					case 7:
						return (((obj5).Groups).Item).Value;
					case 3:
					case 9:
						obj3++;
						obj2 = 4;
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
			obj5 = System.Text.RegularExpressions.Regex.Match((string)html, (string)obj6, (RegexOptions)1);
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
			{
				num = 17;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool UTlhPtJGae(HttpStatusCode statusCode, object? location)
	{
		//IL_000c: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		//IL_0055: Expected O, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		//IL_0062: Expected O, but got I4
		//IL_005f->IL0010: Incompatible stack types: I4 vs O
		//IL_0076->IL0010: Incompatible stack types: I4 vs O
		//IL_00a2->IL0010: Incompatible stack types: I4 vs O
		//IL_00e4->IL0010: Incompatible stack types: I4 vs O
		//IL_0081->IL0010: Incompatible stack types: I4 vs O
		//IL_00ad->IL0010: Incompatible stack types: I4 vs O
		//IL_00ef->IL0010: Incompatible stack types: I4 vs O
		int num = 4;
		object obj3 = default;
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
						if ((nint)obj == 13)
						{
							goto case 3;
						}
						if ((nint)obj == 994)
						{
							goto end_IL_0010;
						}
						goto case 1;
					case 2:
						obj3 = 0;
						obj2 = 5;
						break;
					case 3:
						obj3 = 1;
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
						{
							obj2 = 7;
						}
						break;
					case 4:
						if (statusCode - 302 <= 1)
						{
							obj2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								obj2 = 3;
							}
							break;
						}
						goto case 6;
					case 6:
						if ((int)statusCode == 307)
						{
							goto end_IL_000c;
						}
						goto case 2;
					case 1:
					case 5:
						if (obj3 == null)
						{
							return false;
						}
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
						{
							obj2 = 7;
						}
						break;
					case 0:
						return location != null;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool zBahxDxa09(object body)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0074->IL0010: Incompatible stack types: I4 vs O
		//IL_00c0->IL0010: Incompatible stack types: I4 vs O
		//IL_007f->IL0010: Incompatible stack types: I4 vs O
		//IL_00cb->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 1:
					if (!(body).Contains("login_error", (StringComparison)5))
					{
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 2:
					if ((body).Contains("注册成功", (StringComparison)4))
					{
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					break;
				case 0:
					return !(body).Contains("ipt_error_warntip", (StringComparison)5);
				}
				return false;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool KtUtUMZ09nYoCFMNwD9A()
	{
		return h7olOmZ0ZlbXIbyC9R9n == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static sDBJG2hcdnUxjaDOenm Cn9xlvZ0DoS5WRSgXriK()
	{
		return (sDBJG2hcdnUxjaDOenm)h7olOmZ0ZlbXIbyC9R9n;
	}
}

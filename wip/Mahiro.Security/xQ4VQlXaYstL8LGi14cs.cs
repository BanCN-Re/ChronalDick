using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AafqXjf1hVZB7ZPy4vx1;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CdEjKjX5XwI8HIEc5VXp;
using IKwfJrf1tuGeXk619Ubi;
using KBx9lafY6LvYfHSvsVm4;
using KvbiMlf3gwoQ1cpM2EDk;
using OCafisfciLUeKiM14YoD;
using PBJaD7f1v6Jc7Mkd1mtT;
using QRgJ6Vf1lrdpBGToI64w;
using QTDL5wXBTqLlG2y5F5Yn;
using ROZe5Gf1WgRr9IZ64gbr;
using T1U6ZHfMT1Q9djhmoXGp;
using VU21QFfuKUEjJOH0Y5jf;
using YWbFytf30Le33aWY6omE;
using ap3MgVXGvTib4bByfaqS;
using b61SBNfMPmhr8rBaHFsX;
using cuWoLnfMvwjkfBSedrex;
using fDAldojjppXrctUVYOJn;
using fYjvfFf1p8udxK21D6pd;
using ff4WeOfMu3g1Tbs2mYMJ;
using gCm90lXYJptn2RjHumwY;
using hcoG9TfYeiGJFV8pdp1h;
using kWTDYTf3Vr9TFRvpdM2n;
using o0db2efamPVKRgC1Jp5p;
using tGDaaBfM67tepd1AQ3qo;
using tqNWl3fuBxINBMAcqY6D;
using vRw1G5fuqe7gay2J4PLD;
using vn7xlPf1FYwDtjMIxHKN;
using zCVMnbfabiR2jSY2xUjH;

namespace lNs02hXaSvAHW779wnjw;

internal sealed class xQ4VQlXaYstL8LGi14cs
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_54
	{
		public static __c_54 __9;

		public static Func<KJlRUyf1gXDQ3gU9B09h, edDuSrf3cqdhsaoORXqO> __9__15_0;

		public static Func<int, string> __9__22_0;

		internal static __c_54 LcTxm4DjyxFfG3eMVUHV;

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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 2;
							}
							num = 4;
							break;
						case 4:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
							{
								num3 = 9;
							}
							continue;
						case 3:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
							{
								num3 = 10;
							}
							continue;
						case 2:
							num = 11;
							break;
						case 1:
							return;
						case 0:
							__9 = (__c_54)new __c_54();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								num3 = 7;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_54()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal edDuSrf3cqdhsaoORXqO HOKLDgiq06O(KJlRUyf1gXDQ3gU9B09h pack)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string hAZLDl4e41I(int value)
		{
			return (value).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Wl4FP1DjWxdPaYWE7hWk()
		{
			return LcTxm4DjyxFfG3eMVUHV == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_54 LtZnK2DjJwMoZPkVZpYL()
		{
			return LcTxm4DjyxFfG3eMVUHV;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ComputeMd5Async_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public string filePath;

		public CancellationToken cancellationToken;

		private FileStream _stream_5__2;

		private object __7__wrap2;

		private int __7__wrap3;

		private string __7__wrap4;

		private ConfiguredValueTaskAwaitable<byte[]>.ConfiguredValueTaskAwaiter __u__1;

		private ValueTaskAwaiter __u__2;

		internal static object AqhAbDDjQ9kDqBxcpRuf;

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
						case 0:
							goto end_IL_000e;
						case 2:
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
							{
								num3 = 4;
							}
							continue;
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
							{
								num3 = 2;
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
		internal static bool pgjgWXDjCjMjIAqOZUMB()
		{
			return AqhAbDDjQ9kDqBxcpRuf == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object RX4j0fDj4uhaEATG0ytJ()
		{
			return AqhAbDDjQ9kDqBxcpRuf;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public c7lEmkf1MoB1jUf1XEF1 session;

		public wjHCLDf1ydVEraHow39U server;

		public xE8ewAf14UTc0cX2YgZI address;

		public jOW2VIf13IwuF12TX49n skinAsset;

		public Va1xfWf1HnAgPh5n5gEA serverResources;

		public Nafsw6f1xYhqCvXaY8qH sessionKind;

		public Ctv5QVfaoeUY53HaJXKy onlineLobby;

		public string skinPath;

		public int launcherPort;

		public string authServerUrl;

		public string playerName;

		public xQ4VQlXaYstL8LGi14cs __4__this;

		public string configPath;

		public CancellationToken cancellationToken;

		private Uri _authUri_5__2;

		private string _normalizedPlayerName_5__3;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private object __u__2;

		internal static object xFK79ZDjhADSlcj29lV8;

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
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num3 = 3;
							}
							continue;
						case 0:
							break;
						case 2:
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
							{
								num3 = 1;
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool GH9FXlDjUFDOXkFfVYk4()
		{
			return xFK79ZDjhADSlcj29lV8 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object wSlZkODjrgyecTMBHi8h()
		{
			return xFK79ZDjhADSlcj29lV8;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateLocalLobbyAsync_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public c7lEmkf1MoB1jUf1XEF1 session;

		public xeAGGAfu2g2orKD16Sip connection;

		public jOW2VIf13IwuF12TX49n skin;

		public xQ4VQlXaYstL8LGi14cs __4__this;

		public string configPath;

		public int launcherPort;

		public string authServerUrl;

		public string skinPath;

		public CancellationToken cancellationToken;

		public string password;

		private Uri _authUri_5__2;

		private string _playerName_5__3;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private object __u__2;

		internal static object NJIP2GDjopDAVTXZYloI;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_054f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Expected O, but got Ref
			//IL_0919: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0926: Unknown result type (might be due to invalid IL or missing references)
			//IL_0928: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ec: Expected O, but got I4
			//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be5->IL0b81: Incompatible stack heights: 3 vs 1
			//IL_0bf0->IL0b81: Incompatible stack heights: 3 vs 1
			//IL_0c7e->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0c89->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0393->IL00e8: Incompatible stack heights: 2 vs 1
			xQ4VQlXaYstL8LGi14cs xQ4VQlXaYstL8LGi14cs2 = default;
			int num3 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			int num6 = default;
			ConfiguredTaskAwaitable val2 = default;
			EZKYWqfuIYi9pxDWXEOM eZKYWqfuIYi9pxDWXEOM = default;
			bool flag = default;
			object _u__2 = default;
			int num7 = default;
			ConfiguredTaskAwaitable<string> val = default;
			cwSYjVfuzDOvn8hKeZih room = default;
			string text = default;
			uint userId = default;
			int num10 = default;
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
							if (num != 13)
							{
								if (num == 994)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							return;
						case 5:
							__1__state = -2;
							num2 = 1;
							continue;
						case 1:
							_authUri_5__2 = null;
							num2 = 2;
							continue;
						case 3:
							xQ4VQlXaYstL8LGi14cs2 = __4__this;
							num2 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
							{
								num2 = 6;
							}
							continue;
						case 4:
							num3 = __1__state;
							num2 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
							{
								num2 = 3;
							}
							continue;
						case 6:
							try
							{
								int num4;
								if (num3 != 0)
								{
									num4 = 40;
									goto IL_00e8;
								}
								goto IL_05c1;
								IL_05c1:
								_u__ = __u__1;
								num4 = 35;
								goto IL_00e8;
								IL_00e8:
								while (true)
								{
									int num5;
									switch (num4)
									{
									case 23:
										return;
									case 56:
										return;
									default:
										if (num6 != 67)
										{
											if (num6 == 1047)
											{
												goto IL_00e4;
											}
											goto case 21;
										}
										val2 = (System.IO.File.WriteAllTextAsync(configPath, yxP1KsfcGa5w7LC3JmL7.EdbfcnkO5vZ(JsonSerializer.Serialize<EZKYWqfuIYi9pxDWXEOM>(eZKYWqfuIYi9pxDWXEOM, (JsonSerializerOptions)m0AXatsOroq)), (Encoding)(object)0, cancellationToken)).ConfigureAwait(false);
										num4 = 18;
										continue;
									case 47:
										flag = false;
										num4 = 61;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
										{
											num4 = 32;
										}
										continue;
									case 7:
									{
										string text2 = configPath;
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
										{
											num4 = 4;
										}
										continue;
									}
									case 32:
									case 45:
										if (!flag)
										{
											num4 = 13;
											continue;
										}
										goto case 11;
									case 50:
										throw new global::System.Exception("基岩皮肤文件校验失败");
									case 0:
										if (launcherPort > 65535)
										{
											num4 = 50;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
											{
												num4 = 34;
											}
											continue;
										}
										goto case 47;
									case 57:
										__u__2 = default;
										num4 = 33;
										continue;
									case 36:
										if (string.Equals(System.IO.Path.GetExtension(configPath), ".cppconfig", (StringComparison)5))
										{
											num4 = 48;
											continue;
										}
										goto case 51;
									case 16:
										_ = "基岩版皮肤文件不存在";
										throw skinPath;
									case 5:
										flag = false;
										num4 = 55;
										continue;
									case 54:
										__u__2 = _u__2;
										num4 = 46;
										continue;
									case 10:
										if (num7 < 1)
										{
											num4 = 27;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
											{
												num4 = 24;
											}
											continue;
										}
										goto case 44;
									case 43:
										((LixQVCX5bgefMapc3r7K)xQ4VQlXaYstL8LGi14cs2.sDtXaOQWHn1).DTWX5kvU9Bh();
										num4 = 14;
										continue;
									case 26:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _CreateLocalLobbyAsync_d__20>(ref _u__, ref this);
										num4 = 32;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
										{
											num4 = 56;
										}
										continue;
									case 13:
										if (!System.Uri.TryCreate(authServerUrl, (UriKind)1, out _authUri_5__2))
										{
											num5 = 11;
											goto IL_00e0;
										}
										goto case 24;
									case 11:
									case 22:
										_ = "本地联机会话服务地址无效";
										throw new global::System.Exception("authServerUrl");
									case 59:
										_playerName_5__3 = (session.Nickname).Trim();
										num4 = 17;
										continue;
									case 2:
									case 55:
										if (flag)
										{
											num4 = 21;
											continue;
										}
										if (System.IO.File.Exists(skinPath))
										{
											ii6Xaowck87(skinPath, cancellationToken);
											val = (ConfiguredTaskAwaitable<string>)0;
											_ = 31;
											continue;
										}
										num4 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
										{
											num4 = 43;
										}
										continue;
									case 1:
									case 20:
										(_u__2).GetResult();
										num4 = 7;
										continue;
									case 27:
									case 53:
										flag = true;
										num4 = 49;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
										{
											num4 = 2;
										}
										continue;
									case 18:
										_u__2 = val2;
										num4 = 3;
										continue;
									case 9:
										_u__2 = __u__2;
										num4 = 57;
										continue;
									case 25:
										System.ArgumentNullException.ThrowIfNull(session, "session");
										num4 = 29;
										continue;
									case 12:
										room = connection.Room;
										num4 = 15;
										continue;
									case 28:
										break;
									case 8:
										num3 = (__1__state = 0);
										num4 = 58;
										continue;
									case 19:
									case 42:
										text = (string)(&_u__);
										num4 = 39;
										continue;
									case 29:
										System.ArgumentNullException.ThrowIfNull(connection, "connection");
										num4 = 6;
										continue;
									case 44:
										if (num7 > 32)
										{
											num4 = 53;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
											{
												num4 = 35;
											}
											continue;
										}
										goto case 5;
									case 3:
										if ((_u__2).IsCompleted)
										{
											num4 = 20;
											continue;
										}
										goto case 37;
									case 17:
										num7 = (_playerName_5__3).Length;
										num4 = 42;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
										{
											num4 = 10;
										}
										continue;
									case 15:
										eZKYWqfuIYi9pxDWXEOM = (EZKYWqfuIYi9pxDWXEOM)new EZKYWqfuIYi9pxDWXEOM
										{
											LaunchParameters = (GCYxx0fudHnHKC7IOS8r)new GCYxx0fudHnHKC7IOS8r(),
											WorldInfo = q9xXaIBt5SY(room),
											RoomInfo = PREXaBqnpng(connection, password, session.Token),
											PlayerInfo = (nWmdYYfMehOhwJjICbaM)new nWmdYYfMehOhwJjICbaM
											{
												UserId = userId,
												UserName = _playerName_5__3,
												Urs = (userId).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture)
											},
											SkinInfo = (u6wSlffMsE6QYvLUbSUk)new u6wSlffMsE6QYvLUbSUk
											{
												Skin = RjJcojfY55sN0GqYZJag.ToAsciiPath(skinPath),
												Md5 = text,
												Slim = jad59ifYwooR570v1Kfb.gsEfYPBtOrj(skinPath),
												SkinItemId = UdiXaCf5Od4(skin.ItemId)
											},
											AntiAddictionInfo = (XlPvCRfMpWye2JKG4EKx)new XlPvCRfMpWye2JKG4EKx(),
											Misc = (Ji9OfSfM3t9w7RI7oreG)new Ji9OfSfM3t9w7RI7oreG
											{
												MultiplayerGameType = 2,
												LauncherPort = launcherPort,
												AuthServerUrl = ((_authUri_5__2).AbsoluteUri).TrimEnd('/')
											},
											Path = RjJcojfY55sN0GqYZJag.ToAsciiPath(configPath)
										};
										num5 = 42;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
										{
											num5 = 67;
										}
										goto IL_00e0;
									case 33:
										num3 = (__1__state = -1);
										num4 = 63;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
										{
											num4 = 1;
										}
										continue;
									case 46:
										__t__builder.AwaitUnsafeOnCompleted<object, _CreateLocalLobbyAsync_d__20>(ref _u__2, ref this);
										num5 = 23;
										goto IL_00e0;
									case 34:
									case 38:
										flag = true;
										num4 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
										{
											num4 = 45;
										}
										continue;
									case 6:
										System.ArgumentNullException.ThrowIfNull(skin, "skin");
										num4 = 43;
										continue;
									case 40:
										if (num3 != 1)
										{
											num4 = 25;
											continue;
										}
										goto case 9;
									case 49:
										if (&_u__ != null)
										{
											num4 = 59;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
											{
												num4 = 42;
											}
											continue;
										}
										goto case 8;
									case 31:
										_u__ = val;
										num4 = 49;
										continue;
									case 58:
										__u__1 = _u__;
										num4 = 26;
										continue;
									case 39:
										if (string.Equals(text, skin.Md5, (StringComparison)5))
										{
											userId = FbpoHMXG3DhpVgCqmBYm.l1kXGEb5AaZ(session.UserId);
											num4 = 12;
											continue;
										}
										num4 = 59;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
										{
											num4 = 50;
										}
										continue;
									case 21:
										throw new global::System.Exception("基岩账号昵称无效，请重新登录");
									case 35:
										__u__1 = default;
										num4 = 30;
										continue;
									case 37:
										num3 = (__1__state = 1);
										num4 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
										{
											num4 = 54;
										}
										continue;
									case 51:
									case 52:
										_ = "基岩启动配置路径无效";
										throw new global::System.Exception("configPath");
									case 48:
										if (launcherPort < 1)
										{
											num4 = 38;
											continue;
										}
										goto case 0;
									case 14:
										if (!((LixQVCX5bgefMapc3r7K)xQ4VQlXaYstL8LGi14cs2.sDtXaOQWHn1).BQlX5YqJ5tO(configPath))
										{
											num4 = 51;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
											{
												num4 = 11;
											}
											continue;
										}
										goto case 36;
									case 41:
										if (PFxXa7cxksV(_authUri_5__2))
										{
											num4 = 59;
											continue;
										}
										goto case 11;
									case 24:
										if (!((_authUri_5__2).Scheme != Uri.UriSchemeHttp))
										{
											num4 = 27;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
											{
												num4 = 41;
											}
											continue;
										}
										goto case 11;
									case 30:
										num3 = (__1__state = -1);
										num4 = 65;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
										{
											num4 = 19;
										}
										continue;
									case 4:
										goto end_IL_00e8;
										IL_00e0:
										num6 = num5;
										goto IL_00e4;
										IL_00e4:
										num4 = num6;
										continue;
									}
									goto IL_05c1;
									continue;
									end_IL_00e8:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num8 = 2;
								while (true)
								{
									switch (num8)
									{
									case 0:
										return;
									default:
										if (num10 != 11)
										{
											if (num10 == 991)
											{
												goto IL_0b7d;
											}
											goto case 2;
										}
										_authUri_5__2 = null;
										num8 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
										{
											num8 = 1;
										}
										break;
									case 1:
										_playerName_5__3 = null;
										num8 = 3;
										break;
									case 3:
										_ = __t__builder;
										_ = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
										{
											_ = 9;
										}
										break;
									case 2:
										{
											__1__state = -2;
											int num9 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
											{
												num9 = 11;
											}
											num10 = num9;
											goto IL_0b7d;
										}
										IL_0b7d:
										num8 = num10;
										break;
									}
								}
							}
							goto case 5;
						case 0:
							break;
						case 2:
							_playerName_5__3 = null;
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num2 = 0;
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
				_ = __t__builder;
				_ = 13;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
				{
					_ = 12;
				}
			}
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
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num3 = 5;
							}
							continue;
						case 2:
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
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
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool OBUNG8DjmhovjKk4WMam()
		{
			return NJIP2GDjopDAVTXZYloI == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object U9O5pDDj7hq3I7RMyrb4()
		{
			return NJIP2GDjopDAVTXZYloI;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateSinglePlayerAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public Dw6GWNf3Bc1hwbOQdTkG snapshot;

		public c7lEmkf1MoB1jUf1XEF1 session;

		public jOW2VIf13IwuF12TX49n skinAsset;

		public Va1xfWf1HnAgPh5n5gEA deployedResources;

		public string worldId;

		public string skinPath;

		public string playerName;

		public xQ4VQlXaYstL8LGi14cs __4__this;

		public string configPath;

		public CancellationToken cancellationToken;

		public string worldName;

		private string _normalizedPlayerName_5__2;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private object __u__2;

		internal static object MxfQWDDjAAiiV6l6P7Ut;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_097a: Unknown result type (might be due to invalid IL or missing references)
			//IL_097c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_078d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected O, but got Ref
			//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0954: Unknown result type (might be due to invalid IL or missing references)
			//IL_068f: Unknown result type (might be due to invalid IL or missing references)
			//IL_069b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Expected O, but got I4
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bc6->IL0b95: Incompatible stack heights: 0 vs 2
			//IL_0b99->IL0b99: Incompatible stack heights: 3 vs 1
			//IL_0c62->IL0010: Incompatible stack heights: 3 vs 1
			//IL_06b1->IL00d3: Incompatible stack heights: 2 vs 1
			//IL_06bc->IL00d3: Incompatible stack heights: 2 vs 1
			int num = 4;
			xQ4VQlXaYstL8LGi14cs xQ4VQlXaYstL8LGi14cs2 = default;
			int num4 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			int num7 = default;
			ConfiguredTaskAwaitable val = default;
			string text4 = default;
			string text2 = default;
			object _u__2 = default;
			bool slim = default;
			uint userId = default;
			bool flag = default;
			ConfiguredTaskAwaitable<string> val2 = default;
			int num8 = default;
			int num10 = default;
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
								goto case 3;
							}
							_ = __t__builder;
							_ = 2;
							continue;
						case 3:
							xQ4VQlXaYstL8LGi14cs2 = __4__this;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num3 = 6;
							}
							continue;
						case 4:
							num4 = __1__state;
							num3 = 3;
							continue;
						case 2:
							return;
						case 1:
							__1__state = -2;
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num3 = 5;
							}
							continue;
						case 0:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 48;
									goto IL_00d3;
								}
								goto IL_021f;
								IL_021f:
								_u__ = __u__1;
								num5 = 54;
								goto IL_00d3;
								IL_00d3:
								while (true)
								{
									int num6;
									switch (num5)
									{
									case 35:
										return;
									case 50:
										return;
									default:
										if (num7 != 62)
										{
											if (num7 == 1042)
											{
												goto IL_00cf;
											}
											goto case 8;
										}
										val = (System.IO.File.WriteAllTextAsync(configPath, text4, (Encoding)(object)0, cancellationToken)).ConfigureAwait(false);
										num5 = 33;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
										{
											num5 = 56;
										}
										continue;
									case 2:
										System.ArgumentNullException.ThrowIfNull(skinAsset, "skinAsset");
										num5 = 54;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
										{
											num5 = 18;
										}
										continue;
									case 49:
										break;
									case 48:
										if (num4 != 1)
										{
											num5 = 39;
											continue;
										}
										goto case 25;
									case 52:
										num4 = (__1__state = 0);
										num5 = 36;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
										{
											num5 = 21;
										}
										continue;
									case 45:
										text2 = (string)(&_u__);
										num5 = 13;
										continue;
									case 16:
										_ = "世界 ID 不能为空";
										throw new global::System.Exception("worldId");
									case 15:
										if (string.IsNullOrWhiteSpace(skinPath))
										{
											num6 = 34;
											goto IL_00cb;
										}
										goto case 32;
									case 36:
										num4 = (__1__state = -1);
										num6 = 5;
										goto IL_00cb;
									case 25:
										_u__2 = __u__2;
										num5 = 46;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
										{
											num5 = 16;
										}
										continue;
									case 20:
										if (string.Equals(System.IO.Path.GetExtension(configPath), ".cppconfig", (StringComparison)5))
										{
											num5 = 53;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
											{
												num5 = 6;
											}
											continue;
										}
										goto case 9;
									case 26:
										num4 = (__1__state = 1);
										num5 = 3;
										continue;
									case 8:
										if (!string.IsNullOrWhiteSpace(worldId))
										{
											num5 = 60;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
											{
												num5 = 15;
											}
											continue;
										}
										goto case 16;
									case 28:
										slim = jad59ifYwooR570v1Kfb.gsEfYPBtOrj(skinPath);
										num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num5 = 15;
										}
										continue;
									case 10:
										text4 = yxP1KsfcGa5w7LC3JmL7.EdbfcnkO5vZ(JsonSerializer.Serialize<EZKYWqfuIYi9pxDWXEOM>((EZKYWqfuIYi9pxDWXEOM)new EZKYWqfuIYi9pxDWXEOM
										{
											LaunchParameters = (GCYxx0fudHnHKC7IOS8r)new GCYxx0fudHnHKC7IOS8r(),
											WorldInfo = NXOXayCisps(snapshot, worldName, worldId, deployedResources),
											RoomInfo = FxrXaWLSWuI(worldName, deployedResources),
											PlayerInfo = (nWmdYYfMehOhwJjICbaM)new nWmdYYfMehOhwJjICbaM
											{
												UserId = userId,
												UserName = _normalizedPlayerName_5__2,
												Urs = (userId).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture)
											},
											SkinInfo = (u6wSlffMsE6QYvLUbSUk)new u6wSlffMsE6QYvLUbSUk
											{
												Skin = RjJcojfY55sN0GqYZJag.ToAsciiPath(skinPath),
												Md5 = text2,
												Slim = slim,
												SkinItemId = UdiXaCf5Od4(skinAsset.ItemId)
											},
											AntiAddictionInfo = (XlPvCRfMpWye2JKG4EKx)new XlPvCRfMpWye2JKG4EKx(),
											Misc = dXkXaJe5hK4(),
											Path = RjJcojfY55sN0GqYZJag.ToAsciiPath(configPath)
										}, (JsonSerializerOptions)m0AXatsOroq));
										num6 = 62;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
										{
											num6 = 25;
										}
										goto IL_00cb;
									case 46:
										__u__2 = default;
										num5 = 36;
										continue;
									case 3:
										__u__2 = _u__2;
										num5 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
										{
											num5 = 23;
										}
										continue;
									case 11:
									case 27:
										flag = true;
										num5 = 22;
										continue;
									case 47:
									{
										string text3 = configPath;
										num6 = 24;
										goto IL_00cb;
									}
									case 23:
										__t__builder.AwaitUnsafeOnCompleted<object, _CreateSinglePlayerAsync_d__7>(ref _u__2, ref this);
										num5 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
										{
											num5 = 35;
										}
										continue;
									case 0:
										_u__ = val2;
										num6 = 53;
										goto IL_00cb;
									case 9:
									case 29:
										_ = "基岩启动配置路径无效";
										throw new global::System.Exception("configPath");
									case 6:
										ii6Xaowck87(skinPath, cancellationToken);
										val2 = (ConfiguredTaskAwaitable<string>)0;
										_ = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
										{
											_ = 5;
										}
										continue;
									case 43:
										throw new global::System.Exception("基岩默认皮肤文件校验失败");
									case 17:
										userId = FbpoHMXG3DhpVgCqmBYm.l1kXGEb5AaZ(session.UserId);
										num6 = 28;
										goto IL_00cb;
									case 19:
										flag = false;
										num5 = 24;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
										{
											num5 = 38;
										}
										continue;
									case 12:
										if (num8 < 1)
										{
											num5 = 27;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
											{
												num5 = 28;
											}
											continue;
										}
										goto case 37;
									case 53:
										if (&_u__ == null)
										{
											num5 = 52;
											continue;
										}
										goto case 45;
									case 32:
										if (System.IO.File.Exists(skinPath))
										{
											num5 = 21;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
											{
												num5 = 14;
											}
											continue;
										}
										goto case 1;
									case 33:
										_u__2 = val;
										num5 = 31;
										continue;
									case 41:
										num8 = (_normalizedPlayerName_5__2).Length;
										num5 = 12;
										continue;
									case 31:
										if ((_u__2).IsCompleted)
										{
											num5 = 4;
											continue;
										}
										goto case 26;
									case 7:
										num4 = (__1__state = -1);
										num5 = 45;
										continue;
									case 13:
										if (string.Equals(text2, skinAsset.Md5, (StringComparison)5))
										{
											num5 = 17;
											continue;
										}
										goto case 43;
									case 51:
										System.ArgumentNullException.ThrowIfNull(session, "session");
										num5 = 2;
										continue;
									case 44:
										if (!((LixQVCX5bgefMapc3r7K)xQ4VQlXaYstL8LGi14cs2.sDtXaOQWHn1).BQlX5YqJ5tO(configPath))
										{
											num5 = 29;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
											{
												num5 = 15;
											}
											continue;
										}
										goto case 20;
									case 18:
										System.ArgumentNullException.ThrowIfNull(deployedResources, "deployedResources");
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
										{
											num5 = 37;
										}
										continue;
									case 37:
										if (num8 > 32)
										{
											num5 = 48;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
											{
												num5 = 11;
											}
											continue;
										}
										goto case 19;
									case 54:
										__u__1 = default;
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num5 = 7;
										}
										continue;
									case 21:
										__u__1 = _u__;
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
										{
											num5 = 42;
										}
										continue;
									case 30:
										_ = "基岩角色名无效";
										throw new global::System.Exception("playerName");
									case 40:
										((LixQVCX5bgefMapc3r7K)xQ4VQlXaYstL8LGi14cs2.sDtXaOQWHn1).DTWX5kvU9Bh();
										num5 = 44;
										continue;
									case 4:
									case 5:
										(_u__2).GetResult();
										num5 = 47;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
										{
											num5 = 52;
										}
										continue;
									case 22:
									case 38:
										if (!flag)
										{
											num5 = 40;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
											{
												num5 = 46;
											}
											continue;
										}
										goto case 30;
									case 39:
										System.ArgumentNullException.ThrowIfNull(snapshot, "snapshot");
										num5 = 47;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
										{
											num5 = 51;
										}
										continue;
									case 42:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _CreateSinglePlayerAsync_d__7>(ref _u__, ref this);
										num5 = 50;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
										{
											num5 = 49;
										}
										continue;
									case 1:
									case 34:
										_ = "基岩版皮肤文件不存在";
										throw skinPath;
									case 14:
									{
										string text = playerName;
										_normalizedPlayerName_5__2 = ((text != null) ? (text).Trim() : null) ?? string.Empty;
										num5 = 41;
										continue;
									}
									case 24:
										goto end_IL_00d3;
										IL_00cf:
										num5 = num7;
										continue;
										IL_00cb:
										num7 = num6;
										goto IL_00cf;
									}
									goto IL_021f;
									continue;
									end_IL_00d3:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num9 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
								{
									num9 = 0;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										switch (num10)
										{
										case 10:
											return;
										case 990:
											continue;
										}
										break;
									case 0:
										_normalizedPlayerName_5__2 = null;
										num9 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
										{
											num9 = 1;
										}
										continue;
									case 2:
										__1__state = -2;
										num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
										{
											num9 = 1;
										}
										continue;
									case 1:
										break;
									}
									_ = __t__builder;
									num10 = 10;
								}
							}
							goto case 1;
						case 5:
							break;
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
				_normalizedPlayerName_5__2 = null;
				num = 12;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
				{
					num = 1;
				}
			}
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
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto end_IL_0012;
						case 0:
							return;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
				{
					num = 8;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool y5UeQjDjIUYGpNpMCZeg()
		{
			return MxfQWDDjAAiiV6l6P7Ut == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object M1GfyyDjB0xGVd1G0hAi()
		{
			return MxfQWDDjAAiiV6l6P7Ut;
		}
	}

	private static readonly object m0AXatsOroq;

	private readonly object sDtXaOQWHn1;

	internal static object fMkXaWZePQqFJC9rs2xU;

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<string> bSbXacgSKuj(string configPath, c7lEmkf1MoB1jUf1XEF1 session, wjHCLDf1ydVEraHow39U server, xE8ewAf14UTc0cX2YgZI address, jOW2VIf13IwuF12TX49n skinAsset, string skinPath, int launcherPort, string authServerUrl, string playerName, Va1xfWf1HnAgPh5n5gEA serverResources, CancellationToken cancellationToken)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return iReXa036PH1(configPath, session, server, address, skinAsset, skinPath, launcherPort, authServerUrl, playerName, Nafsw6f1xYhqCvXaY8qH.NetworkGame, serverResources, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<string> iReXa036PH1(string configPath, c7lEmkf1MoB1jUf1XEF1 session, wjHCLDf1ydVEraHow39U server, xE8ewAf14UTc0cX2YgZI address, jOW2VIf13IwuF12TX49n skinAsset, string skinPath, int launcherPort, string authServerUrl, string playerName, Nafsw6f1xYhqCvXaY8qH sessionKind, Va1xfWf1HnAgPh5n5gEA serverResources, CancellationToken cancellationToken, Ctv5QVfaoeUY53HaJXKy? onlineLobby = null)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<string> SZSXa8TfVUb(string configPath, Dw6GWNf3Bc1hwbOQdTkG snapshot, string worldName, string worldId, c7lEmkf1MoB1jUf1XEF1 session, jOW2VIf13IwuF12TX49n skinAsset, string skinPath, string playerName, Va1xfWf1HnAgPh5n5gEA deployedResources, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static P9rDk9f3kJVvuZy7D3dE NXOXayCisps(object snapshot, object worldName, object worldId, object deployedResources)
	{
		System.ArgumentNullException.ThrowIfNull(deployedResources, "deployedResources");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static Fqp3vUfM5I3TS6wbLd3D FxrXaWLSWuI(object worldName, object deployedResources)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Ji9OfSfM3t9w7RI7oreG dXkXaJe5hK4()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string GdiXaQ4h89w(object itemId)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string UdiXaCf5Od4(object itemId)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Va1xfWf1HnAgPh5n5gEA uUbXa4Ur8GL(Nafsw6f1xYhqCvXaY8qH sessionKind, object serverResources)
	{
		int num = 1;
		Va1xfWf1HnAgPh5n5gEA result = default;
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
						if (num2 != 13 && num2 == 994)
						{
							goto end_IL_0010;
						}
						goto case 6;
					case 3:
						result = (Va1xfWf1HnAgPh5n5gEA)serverResources;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
						{
							num3 = 8;
						}
						continue;
					case 5:
						break;
					case 1:
						System.ArgumentNullException.ThrowIfNull(serverResources, "serverResources");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
					case 4:
						goto IL_00e3;
					case 6:
						return result;
					case 0:
						{
							switch (sessionKind)
							{
							case Nafsw6f1xYhqCvXaY8qH.NetworkGame:
								break;
							case Nafsw6f1xYhqCvXaY8qH.RentalGame:
							case Nafsw6f1xYhqCvXaY8qH.LobbyGame:
								goto end_IL_000c;
							case Nafsw6f1xYhqCvXaY8qH.LocalLobby:
								goto IL_00e3;
							default:
								goto IL_0141;
							}
							goto case 3;
						}
						IL_0141:
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							num3 = 4;
						}
						continue;
						IL_00e3:
						_ = "sessionKind";
						_ = (object)sessionKind;
						throw new global::System.Exception("未知的基岩服务器会话类型");
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
			result = Va1xfWf1HnAgPh5n5gEA.Empty;
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string[] O2AXah3juI1(Nafsw6f1xYhqCvXaY8qH sessionKind, global::System.Collections.Generic.IReadOnlyList<string> itemIds, object serverId)
	{
		System.ArgumentNullException.ThrowIfNull(itemIds, "itemIds");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static edDuSrf3cqdhsaoORXqO[] ldIXaUFJARf(global::System.Collections.Generic.IReadOnlyList<KJlRUyf1gXDQ3gU9B09h> packs)
	{
		//IL_0027: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0014->IL0027: Incompatible stack heights: 2 vs 3
		__c_54 _;
		if (__c_54.__9__15_0 == null)
		{
			_ = __c_54.__9;
			__c_54.__9__15_0 = new Func<KJlRUyf1gXDQ3gU9B09h, edDuSrf3cqdhsaoORXqO>(__c_54.HOKLDgiq06O);
		}
		return Enumerable.ToArray<edDuSrf3cqdhsaoORXqO>(Enumerable.Select<KJlRUyf1gXDQ3gU9B09h, edDuSrf3cqdhsaoORXqO>((global::System.Collections.Generic.IEnumerable<KJlRUyf1gXDQ3gU9B09h>)(object)_, new Func<KJlRUyf1gXDQ3gU9B09h, edDuSrf3cqdhsaoORXqO>(__c_54.HOKLDgiq06O)));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void EIOXarL9Rej(string configPath)
	{
		int num = 3;
		int num4 = default;
		int num6 = default;
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
					goto case 1;
				case 2:
					return;
				case 1:
					try
					{
						if (!((LixQVCX5bgefMapc3r7K)sDtXaOQWHn1).BQlX5YqJ5tO(configPath))
						{
							return;
						}
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
						{
							num3 = 8;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 990)
								{
									num3 = num4;
									break;
								}
								return;
							case 1:
								if (System.IO.File.Exists(configPath))
								{
									num3 = 2;
									break;
								}
								return;
							case 2:
								System.IO.File.Delete(configPath);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
								{
									num3 = 3;
								}
								break;
							case 0:
								return;
							}
						}
					}
					catch (global::System.Exception)
					{
						int num5 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
						{
							num5 = 4;
						}
						while (true)
						{
							switch (num5)
							{
							case 0:
								return;
							}
							if (num6 == 988)
							{
								num5 = num6;
								continue;
							}
							return;
						}
					}
				case 3:
					if (!string.IsNullOrWhiteSpace(configPath))
					{
						num2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 2;
					}
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
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<string> ii6Xaowck87(object filePath, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string IBgXamFTMYl()
	{
		return System.Convert.ToBase64String(System.Security.Cryptography.RandomNumberGenerator.GetBytes(16));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool PFxXa7cxksV(object uri)
	{
		int num = 2;
		IPAddress val = default;
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
				case 1:
					return true;
				case 0:
					return System.Net.IPAddress.IsLoopback(val);
				case 3:
					return false;
				case 2:
					if (!string.Equals((uri).Host, "localhost", (StringComparison)5))
					{
						if (!System.Net.IPAddress.TryParse((uri).Host, ref val))
						{
							num2 = 3;
							break;
						}
						goto case 0;
					}
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
					{
						num2 = 1;
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
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<string> XXiXaACFEeU(string configPath, c7lEmkf1MoB1jUf1XEF1 session, xeAGGAfu2g2orKD16Sip connection, string password, jOW2VIf13IwuF12TX49n skin, string skinPath, int launcherPort, string authServerUrl, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static P9rDk9f3kJVvuZy7D3dE q9xXaIBt5SY(object room)
	{
		int num = 1;
		uint num4 = default;
		string text = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						obj = null;
						goto IL_01d9;
					case 2:
						if (!uint.TryParse(((cwSYjVfuzDOvn8hKeZih)room).RoomId, (NumberStyles)0, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, out num4))
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 6;
					case 6:
						if (num4 == 0)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						text = (num4).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num3 = 5;
						}
						continue;
					case 7:
						if (string.IsNullOrEmpty(text))
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 5;
					case 3:
					case 4:
						throw new global::System.Exception("公共房间编号无效，无法生成联机世界标识");
					case 1:
						System.ArgumentNullException.ThrowIfNull(room, "room");
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						return (P9rDk9f3kJVvuZy7D3dE)new P9rDk9f3kJVvuZy7D3dE
						{
							LevelId = text,
							Name = ((cwSYjVfuzDOvn8hKeZih)room).Name
						};
					case 0:
						{
							string levelId = ((cwSYjVfuzDOvn8hKeZih)room).LevelId;
							if (levelId == null)
							{
								num = 14;
								break;
							}
							obj = (levelId).Trim();
							goto IL_01d9;
						}
						IL_01d9:
						text = (string)obj;
						num = 7;
						break;
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
	internal static Fqp3vUfM5I3TS6wbLd3D PREXaBqnpng(object connection, object password, object sessionToken)
	{
		int port = ((xeAGGAfu2g2orKD16Sip)connection).Address.Port;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static P9rDk9f3kJVvuZy7D3dE D8bXagyHdFi(object lobby)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 2:
					System.ArgumentNullException.ThrowIfNull(lobby, "lobby");
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (string.IsNullOrWhiteSpace(((Ctv5QVfaoeUY53HaJXKy)lobby).RoomId))
					{
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
						{
							num2 = 0;
						}
						break;
					}
					return (P9rDk9f3kJVvuZy7D3dE)new P9rDk9f3kJVvuZy7D3dE
					{
						LevelId = (((Ctv5QVfaoeUY53HaJXKy)lobby).RoomId).Trim(),
						Name = (string.IsNullOrWhiteSpace(((Ctv5QVfaoeUY53HaJXKy)lobby).RoomName) ? "联机大厅房间" : (((Ctv5QVfaoeUY53HaJXKy)lobby).RoomName).Trim())
					};
				case 0:
					throw new global::System.Exception("联机大厅房间 ID 不能为空");
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Fqp3vUfM5I3TS6wbLd3D COpXal5p0RI(object address, object lobby, object itemIds, bool modPreDownload)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public xQ4VQlXaYstL8LGi14cs()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		sDtXaOQWHn1 = (object)new LixQVCX5bgefMapc3r7K((string?)null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool rLXiNKZexkIp8sspcvS6()
	{
		return fMkXaWZePQqFJC9rs2xU == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static xQ4VQlXaYstL8LGi14cs vpYXy6ZeFwLDn9rb1U21()
	{
		return (xQ4VQlXaYstL8LGi14cs)fMkXaWZePQqFJC9rs2xU;
	}
}

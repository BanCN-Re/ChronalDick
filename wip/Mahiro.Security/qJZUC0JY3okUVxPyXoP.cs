using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QYJtooPfnXCe6AdrjZX;
using Vlsi7UfO9ch6W4RxaQqv;
using XgJ6gce1wjf9QCp6VWH;
using fDAldojjppXrctUVYOJn;
using n5qsBmWAIuoooY62Aod;
using pDFcXyfOjGiubvpRL0gO;
using rpAOHpBy1Ss2rabyYHw;

namespace EiAPRwJSDFvNotiSTTX;

public sealed class qJZUC0JY3okUVxPyXoP
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_118
	{
		public static __c_118 __9;

		public static Func<string, bool> __9__13_2;

		public static Func<string, string> __9__13_3;

		public static Func<d2iiUHfOLr9ZvQq4WHMC, Version> __9__13_0;

		public static Func<d2iiUHfOLr9ZvQq4WHMC, string> __9__13_1;

		private static __c_118 vYQoUX9yOfCpH20QXuJn;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 3;
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
								goto case 3;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							break;
						case 3:
							num3 = 2;
							continue;
						case 0:
							__9 = (__c_118)new __c_118();
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
							{
								num3 = 5;
							}
							continue;
						case 4:
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
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_118()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool BY9fvuRwGld(string note)
		{
			return !string.IsNullOrWhiteSpace(note);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string LR0fva7b87Y(string note)
		{
			return (note).Trim();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal Version NrFfv1A2eh4(d2iiUHfOLr9ZvQq4WHMC entry)
		{
			//IL_0077: Expected O, but got I4
			int num = 1;
			Version version = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_0021;
					case 1:
						if (nJuJ4DkPkb(entry.Version, out version))
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 2;
					case 2:
						_ = 0;
						_ = 0;
						_ = 0;
						return (Version)(object)0;
					case 0:
						break;
					}
					goto IL_0077;
					IL_0021:
					if (num == 990)
					{
						break;
					}
					goto IL_0077;
					IL_0077:
					return version;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string WTTfv3R9mB3(d2iiUHfOLr9ZvQq4WHMC entry)
		{
			return entry.Date;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool epmlPD9y5Zy1kC2Y3iaL()
		{
			return vYQoUX9yOfCpH20QXuJn == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_118 KpuEqj9y6aFMYqnufTTa()
		{
			return vYQoUX9yOfCpH20QXuJn;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _FetchAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<PJWRpXfOZeOHKi4Pca4V> __t__builder;

		public string sinceVersion;

		public CancellationToken cancellationToken;

		private TaskAwaiter<string> __u__1;

		internal static object rr7ZVB9yRgkDpoj2ugAt;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0166: Expected O, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected O, but got Ref
			//IL_02e9: Expected I4, but got O
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3->IL04a2: Incompatible stack heights: 3 vs 1
			//IL_04ee->IL04a2: Incompatible stack heights: 3 vs 1
			//IL_0541->IL0010: Incompatible stack heights: 3 vs 1
			//IL_054c->IL0010: Incompatible stack heights: 3 vs 1
			int num = 2;
			int num4 = default;
			int num10 = default;
			PJWRpXfOZeOHKi4Pca4V pJWRpXfOZeOHKi4Pca4V = default;
			string text = default;
			int num7 = default;
			int num9 = default;
			TaskAwaiter<string> _u__ = default;
			int num12 = default;
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
							if (num2 != 10)
							{
								if (num2 == 991)
								{
									goto end_IL_0010;
								}
								goto case 1;
							}
							_ = __t__builder;
							_ = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								_ = 6;
							}
							continue;
						case 2:
							num4 = __1__state;
							num3 = 1;
							continue;
						case 1:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
									{
										num5 = 11;
									}
									goto IL_0091;
								}
								goto IL_021e;
								IL_0091:
								while (true)
								{
									object uri;
									switch (num5)
									{
									default:
										if (num10 != 26 && num10 == 1006)
										{
											goto IL_008d;
										}
										goto case 8;
									case 6:
										try
										{
											pJWRpXfOZeOHKi4Pca4V = JsonSerializer.Deserialize<PJWRpXfOZeOHKi4Pca4V>(text, (JsonSerializerOptions)KXTJmodIv7);
											int num6 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
											{
												num6 = 6;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													if (num7 == 988)
													{
														num6 = num7;
														continue;
													}
													break;
												case 0:
													break;
												}
												break;
											}
										}
										catch (JsonException ex)
										{
											JsonException ex2 = ex;
											int num8 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
											{
												num8 = 0;
											}
											while (true)
											{
												switch (num8)
												{
												default:
													if (num9 == 988)
													{
														goto IL_0193;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_0193:
												num8 = num9;
											}
											string.Concat("更新日志响应格式无效：", (ex2).Message);
											throw ex2;
										}
										goto case 15;
									case 5:
										if (&_u__ != null)
										{
											num10 = 26;
											goto IL_008d;
										}
										goto case 10;
									case 4:
										num4 = (__1__state = -1);
										num5 = 8;
										continue;
									case 16:
										break;
									case 15:
										if (pJWRpXfOZeOHKi4Pca4V == null)
										{
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
											{
												num5 = 2;
											}
											continue;
										}
										pJWRpXfOZeOHKi4Pca4V.LatestVersion = (pJWRpXfOZeOHKi4Pca4V.LatestVersion ?? string.Empty).Trim();
										num5 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
										{
											num5 = 21;
										}
										continue;
									case 11:
										if (sinceVersion == null)
										{
											num5 = 13;
											continue;
										}
										goto case 1;
									case 18:
										__u__1 = _u__;
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
										{
											num5 = 21;
										}
										continue;
									case 14:
										return;
									case 12:
										pJWRpXfOZeOHKi4Pca4V.Count = (int)pJWRpXfOZeOHKi4Pca4V.Entries;
										num5 = 17;
										continue;
									case 7:
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _FetchAsync_d__12>(ref _u__, ref this);
										num5 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
										{
											num5 = 12;
										}
										continue;
									case 1:
										uri = string.Concat((ChangelogUri).AbsoluteUri, "?since=", System.Uri.EscapeDataString(sinceVersion));
										goto IL_03ed;
									case 17:
									{
										PJWRpXfOZeOHKi4Pca4V pJWRpXfOZeOHKi4Pca4V2 = pJWRpXfOZeOHKi4Pca4V;
										num5 = 9;
										continue;
									}
									case 3:
										__u__1 = default;
										num5 = 4;
										continue;
									case 10:
										num4 = (__1__state = 0);
										num5 = 18;
										continue;
									case 8:
										text = (string)(&_u__);
										num5 = 6;
										continue;
									case 2:
										pJWRpXfOZeOHKi4Pca4V.Entries = CubJCvYKLg(pJWRpXfOZeOHKi4Pca4V.Entries);
										num5 = 12;
										continue;
									case 13:
										uri = ChangelogUri;
										goto IL_03ed;
									case 0:
										throw new global::System.Exception("更新日志响应为空。");
									case 9:
										goto end_IL_0091;
										IL_03ed:
										_u__ = (TaskAwaiter<string>)FcVJh8hoH5(uri, cancellationToken);
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
										{
											num5 = 19;
										}
										continue;
										IL_008d:
										num5 = num10;
										continue;
									}
									goto IL_021e;
									continue;
									end_IL_0091:
									break;
								}
								goto end_IL_0059;
								IL_021e:
								_u__ = __u__1;
								num5 = 3;
								goto IL_0091;
								end_IL_0059:;
							}
							catch (global::System.Exception)
							{
								int num11 = 2;
								while (true)
								{
									switch (num11)
									{
									default:
										if (num12 == 990)
										{
											num11 = num12;
											break;
										}
										goto case 0;
									case 0:
										_ = __t__builder;
										_ = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
										{
											_ = 1;
										}
										break;
									case 2:
										__1__state = -2;
										num11 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
										{
											num11 = 0;
										}
										break;
									case 1:
										return;
									}
								}
							}
							break;
						case 0:
							return;
						case 3:
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
				__1__state = -2;
				num = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
				{
					num = 10;
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
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
								{
									num3 = 7;
								}
								continue;
							}
							goto end_IL_0012;
						case 2:
							num3 = 1;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool bwPUrE9ywJylL5hbrEyr()
		{
			return rr7ZVB9yRgkDpoj2ugAt == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object jLBMtm9yeHEkM2E4ly7t()
		{
			return rr7ZVB9yRgkDpoj2ugAt;
		}
	}

	private static readonly object eALJoBOdTy;

	private static readonly object KXTJmodIv7;

	private static object nxL65YZSQxQuKP29ky3I;

	private static Uri ChangelogUri
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return OPkowHB8re070ZB8Cba.Changelog;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task<PJWRpXfOZeOHKi4Pca4V> xTXJcGhP0T(CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return XO7JQFEm5u(null, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task<PJWRpXfOZeOHKi4Pca4V> W8jJ0iw47P(string sinceVersion, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065->IL0010: Incompatible stack types: I4 vs O
		//IL_0070->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				object sinceVersion2;
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 989)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 0:
					sinceVersion2 = (sinceVersion).Trim();
					break;
				case 1:
					if (!string.IsNullOrWhiteSpace(sinceVersion))
					{
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					sinceVersion2 = null;
					break;
				}
				return XO7JQFEm5u((string?)sinceVersion2, cancellationToken);
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static string ECLJ8DrKaM()
	{
		return SjeRtgW7D9l0uhTX0Bd.BX5WIp7Qck("changelog.lastShownVersion");
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void gkTJydRdHq(string version)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_00a5->IL0010: Incompatible stack types: I4 vs O
		//IL_0058->IL0010: Incompatible stack types: I4 vs O
		//IL_00b0->IL0010: Incompatible stack types: I4 vs O
		//IL_0063->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		do
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 2:
					if (string.IsNullOrWhiteSpace(version))
					{
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					SjeRtgW7D9l0uhTX0Bd.OppWBrbmI0("changelog.lastShownVersion", (version).Trim());
					obj2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
					{
						obj2 = 0;
					}
					continue;
				case 0:
					return;
				case 1:
					return;
				}
				break;
			}
		}
		while ((nint)obj == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static int JL6JWL6oSt(string left, string right)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient X11JJVWTJe()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(HttpClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<PJWRpXfOZeOHKi4Pca4V> XO7JQFEm5u(string? sinceVersion, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.cancellationToken = cancellationToken;
		((AsyncTaskMethodBuilder)4).AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<oFthKhPXnfwgYxepFLD>.ConfiguredTaskAwaiter, VwcdmEeaHles4kN24T4._HandleAsync_d__4>(ref *(ConfiguredTaskAwaitable<oFthKhPXnfwgYxepFLD>.ConfiguredTaskAwaiter*)(&obj.__t__builder), ref *(VwcdmEeaHles4kN24T4._HandleAsync_d__4*)(&obj));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static List<d2iiUHfOLr9ZvQq4WHMC> CubJCvYKLg(List<d2iiUHfOLr9ZvQq4WHMC>? entries)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool nJuJ4DkPkb(string? value, out Version version)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<string> FcVJh8hoH5(object uri, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public qJZUC0JY3okUVxPyXoP()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool POEIkgZSChq7GguuVO6c()
	{
		return nxL65YZSQxQuKP29ky3I == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static qJZUC0JY3okUVxPyXoP gAeViKZS4nPjrxpXdtUo()
	{
		return (qJZUC0JY3okUVxPyXoP)nxL65YZSQxQuKP29ky3I;
	}
}

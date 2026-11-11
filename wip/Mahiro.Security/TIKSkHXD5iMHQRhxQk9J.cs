using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OgEF90XkLGk4frRtPhGI;
using QRgJ6Vf1lrdpBGToI64w;
using RkEBBcxE6uQHIJCVGy1;
using WFth0oXkkI4uwe3eKpjS;
using Wl7dkKXXTHKZKIdaS972;
using bVyVYtfFgCItGPihJweI;
using c2D37HfsFbaPpJo3F98A;
using ePeBZXfsCVxgSE2pDQBf;
using fDAldojjppXrctUVYOJn;
using gRbRfCXDGNq0RQfsTO53;
using gjyRx5f1wubbeI3q2eIF;
using mId2OCfVVq5QfVime49V;
using taWwShfspvnkAftsyduy;
using yL249dXkYNRLIEYB4Ivh;
using zX707pfFXiAmiNASTxFS;

namespace XFUlIaXD6X3PSE5BfgkU;

sealed class TIKSkHXD5iMHQRhxQk9J : global::System.IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_12
	{
		public static __c_12 __9;

		public static Func<Architecture> __9__5_0;

		public static Func<string, bool> __9__10_0;

		internal static __c_12 lbJiak9ei1SfevgmhkcF;

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
								goto case 4;
							}
							return;
						case 0:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						case 3:
							num3 = 2;
							continue;
						case 4:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							num3 = 4;
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
				__9 = (__c_12)new __c_12();
				num = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_12()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal Architecture OcSfzO4Panf()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return System.Runtime.InteropServices.RuntimeInformation.OSArchitecture;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool Y7Hfz5TFpQ3(string path)
		{
			return string.Equals(System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(path)), "bin", (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TjLEWP9envK84fILyFES()
		{
			return lbJiak9ei1SfevgmhkcF == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_12 gkqBqw9ezGW1RR3IZIdE()
		{
			return lbJiak9ei1SfevgmhkcF;
		}
	}

	private readonly object jtQXDN2k9tJ;

	private readonly object aqyXDMjltuJ;

	private readonly Func<Architecture> GLdXDpVSbLM;

	private readonly Func<string, CancellationToken, global::System.Threading.Tasks.Task<int?>>? MjIXDul8TlL;

	private bool xCyXDa9UpbX;

	internal static object NLNEAMZAzjWJvt2uc8tK;

	[MethodImpl((MethodImplOptions)8)]
	internal TIKSkHXD5iMHQRhxQk9J(fYpfncXXsYjDViJ21wwC downloader, HttpMessageHandler? metadataHandler = null, Func<Architecture>? architectureProvider = null, Func<string, CancellationToken, global::System.Threading.Tasks.Task<int?>>? versionProbe = null, VaDT0IXkDNInptZONphL? packageResolver = null)
	{
		aqyXDMjltuJ = ((object)packageResolver) ?? ((object)new uxUJy1XkVStdZ4Cb5SWj(metadataHandler));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task GwOXDRMTxLd(bnHA9vxvBiUJqO7FLm4 paths, ys1lxxfFBPhowwZS5N6T version, IProgress<pqWRiwfFbLTQvJu9JjbG>? progress, CancellationToken cancellationToken, RThjl9fsQN0B8woeqALL validationMode = RThjl9fsQN0B8woeqALL.Quick, bool force = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_EnsureAsync_d__6 ensureAsync_d__ = default(_EnsureAsync_d__6);
		ensureAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		_ = 16;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea;
		((AsyncTaskMethodBuilder<E9A673f1RYqU3JaH0aLP>*)4)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<KJlRUyf1gXDQ3gU9B09h>>.ConfiguredTaskAwaiter, qplCZ9fVkVaGf4yASyOF._CommitAsync_d__16>(ref *(ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<KJlRUyf1gXDQ3gU9B09h>>.ConfiguredTaskAwaiter*)(&ensureAsync_d__.__t__builder), ref *(qplCZ9fVkVaGf4yASyOF._CommitAsync_d__16*)(&ensureAsync_d__));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<YilkAdfsMNIVjttjoUmR> E53XDwqmpqS(bnHA9vxvBiUJqO7FLm4 paths, ys1lxxfFBPhowwZS5N6T version, CancellationToken cancellationToken)
	{
		System.ObjectDisposedException.ThrowIf(xCyXDa9UpbX, this);
		_ = 1;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994;
		_ = 3;
		uKGDFFfsxYJUyNmtk1xA uKGDFFfsxYJUyNmtk1xA = Q0byV3XDqBkO3fA2vDnD.Ky1XDiBEWHb(version, (Architecture)GLdXDpVSbLM);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int weZXDePY0Vg(object version)
	{
		return Q0byV3XDqBkO3fA2vDnD.Ky1XDiBEWHb(version, (Architecture)1).Feature;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task vDcXDPpZT3h(AHOqlMXkfZdK1SYPv1MP candidate, bnHA9vxvBiUJqO7FLm4 paths, ys1lxxfFBPhowwZS5N6T version, uKGDFFfsxYJUyNmtk1xA profile, IProgress<pqWRiwfFbLTQvJu9JjbG>? progress, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_InstallCandidateAsync_d__9 installCandidateAsync_d__ = default(_InstallCandidateAsync_d__9);
		installCandidateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Iv9XDx9y67H(object root)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ta8XDFyPiQP(object paths, object profile)
	{
		return System.IO.Path.Combine(((bnHA9vxvBiUJqO7FLm4)paths).GameBasePath, ((uKGDFFfsxYJUyNmtk1xA)profile).DirectoryName, "bin", "java.exe");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool gfOXDs6Dd7h(object exception)
	{
		int num = 5;
		bool result = default(bool);
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
						if (num2 == 14)
						{
							break;
						}
						if (num2 == 995)
						{
							goto end_IL_0010;
						}
						goto case 3;
					case 5:
						if (exception is Lazy<>)
						{
							num3 = 4;
							continue;
						}
						goto case 3;
					case 0:
						goto end_IL_000c;
					case 3:
						if (!(exception is JsonSerializerOptions))
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 1;
					case 2:
						if (!(exception is EventArgs))
						{
							num3 = 7;
							continue;
						}
						goto case 1;
					case 7:
						if (exception is HttpResponseHeaders)
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto end_IL_000c;
					case 1:
					case 4:
						result = true;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num3 = 12;
						}
						continue;
					case 6:
						break;
					}
					return result;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			result = false;
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void IEpXDTnMpTp(object path)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					if (!System.IO.Directory.Exists((string)path))
					{
						return;
					}
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
					{
						num2 = 2;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 1:
							break;
						}
						System.IO.Directory.Delete((string)path, true);
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
						{
							num2 = 7;
						}
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
						{
							num4 = 8;
						}
					}
					else
					{
						ex = obj2;
						num4 = 2;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 == 14)
							{
								goto case 0;
							}
							if (num5 == 994)
							{
								goto IL_00fc;
							}
							goto case 1;
						case 2:
							if (ex is IOException)
							{
								num4 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 4;
						case 0:
							flag = true;
							num4 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
							{
								num4 = 1;
							}
							continue;
						case 4:
							if (ex is UnauthorizedAccessException)
							{
								num6 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
								{
									num6 = 7;
								}
								goto IL_00f8;
							}
							goto case 6;
						case 6:
							flag = false;
							num6 = 5;
							goto IL_00f8;
						case 3:
							result = 0;
							break;
						case 1:
						case 5:
							{
								result = (flag ? 1 : 0);
								break;
							}
							IL_00fc:
							num4 = num5;
							continue;
							IL_00f8:
							num5 = num6;
							goto IL_00fc;
						}
						break;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num7 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
					{
						num7 = 6;
					}
					while (true)
					{
						switch (num7)
						{
						case 0:
							return;
						}
						if (num8 != 988)
						{
							return;
						}
						num7 = num8;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
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
						goto end_IL_0010;
					case 1:
						return;
					case 0:
						break;
					case 2:
						if (!xCyXDa9UpbX)
						{
							xCyXDa9UpbX = true;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
							{
								num3 = 1;
							}
						}
						continue;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if (num2 != 990)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			(aqyXDMjltuJ).Dispose();
			num = 9;
		}
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
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num3 = 8;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
						{
							num3 = 5;
						}
						continue;
					case 2:
						return;
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
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool oGnqCHZIbKhxkrghmj0F()
	{
		return NLNEAMZAzjWJvt2uc8tK == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TIKSkHXD5iMHQRhxQk9J TmM7ovZIXtPfiahBOaXu()
	{
		return (TIKSkHXD5iMHQRhxQk9J)NLNEAMZAzjWJvt2uc8tK;
	}
}

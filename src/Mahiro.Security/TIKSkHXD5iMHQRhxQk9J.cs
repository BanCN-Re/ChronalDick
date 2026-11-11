using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OgEF90XkLGk4frRtPhGI;
using RkEBBcxE6uQHIJCVGy1;
using WFth0oXkkI4uwe3eKpjS;
using Wl7dkKXXTHKZKIdaS972;
using bVyVYtfFgCItGPihJweI;
using c2D37HfsFbaPpJo3F98A;
using ePeBZXfsCVxgSE2pDQBf;
using fDAldojjppXrctUVYOJn;
using gRbRfCXDGNq0RQfsTO53;
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
		public static readonly __c_12 __9;

		public static Func<Architecture> __9__5_0;

		public static Func<string, bool> __9__10_0;

		internal static __c_12 lbJiak9ei1SfevgmhkcF;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_12()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task GwOXDRMTxLd(bnHA9vxvBiUJqO7FLm4 paths, ys1lxxfFBPhowwZS5N6T version, IProgress<pqWRiwfFbLTQvJu9JjbG>? progress, CancellationToken cancellationToken, RThjl9fsQN0B8woeqALL validationMode = RThjl9fsQN0B8woeqALL.Quick, bool force = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_EnsureAsync_d__6 ensureAsync_d__ = default(_EnsureAsync_d__6);
		ensureAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task<YilkAdfsMNIVjttjoUmR> E53XDwqmpqS(bnHA9vxvBiUJqO7FLm4 paths, ys1lxxfFBPhowwZS5N6T version, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		uKGDFFfsxYJUyNmtk1xA uKGDFFfsxYJUyNmtk1xA = Q0byV3XDqBkO3fA2vDnD.Ky1XDiBEWHb(version, GLdXDpVSbLM.Invoke());
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
		bool flag = false;
		return default(bool);
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
				catch (global::System.Exception obj) when (((Func<bool>)delegate
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
		xCyXDa9UpbX = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

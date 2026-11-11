using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using HN5yyEfpz8TLMVS2CfPf;
using fDAldojjppXrctUVYOJn;
using r7Ie1ifM7owYurGstPtD;

namespace M6r96MXONZeiN30OH6Ye;

sealed class hwiTKTXOTQtyeSoRURZk : global::System.IDisposable
{
	private static readonly object LRaXOi8CZXu;

	private readonly object FBgXOnQuryE;

	private bool kU9XOzkh8uI;

	internal static object bPvihMZ6LMS2hxZAhZ0b;

	[MethodImpl((MethodImplOptions)8)]
	internal hwiTKTXOTQtyeSoRURZk()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task un0XOM0dGcf(uY2l6VfMmfM34jZlW4GQ package, xssD3cfpnxdefR05FuDD installation, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_EnsureAsync_d__7 ensureAsync_d__ = default(_EnsureAsync_d__7);
		ensureAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task N9FXOpGao4X(Uri uri, string manifestPath, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_DownloadManifestAsync_d__8 downloadManifestAsync_d__ = default(_DownloadManifestAsync_d__8);
		downloadManifestAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task WP1XOuy53uq(object manifestPath, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ValidateManifestAsync_d__9 validateManifestAsync_d__ = default(_ValidateManifestAsync_d__9);
		validateManifestAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<bool> BNhXOajkanP(object manifestPath, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_IsManifestValidAsync_d__10 isManifestValidAsync_d__ = default(_IsManifestValidAsync_d__10);
		isManifestValidAsync_d__.__t__builder = AsyncTaskMethodBuilder<bool>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Va6XO1YwpSb(object installation, object executableDirectory)
	{
		string text = System.IO.Path.Combine((System.IO.Path.GetFullPath(((xssD3cfpnxdefR05FuDD)installation).InstallationPath)).TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		}), "patch.json");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<string> lipXO3Fwm3L(object path, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ComputeMd5Async_d__12 computeMd5Async_d__ = default(_ComputeMd5Async_d__12);
		computeMd5Async_d__.__t__builder = AsyncTaskMethodBuilder<string>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool Li0XOv96aI5(object host)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void M8JXOEc3YZA(object path)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			case 1:
				try
				{
					int num2;
					if (!System.IO.File.Exists((string)path))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
						{
							num2 = 2;
						}
						goto IL_0072;
					}
					goto IL_0096;
					IL_0072:
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 990)
							{
								goto IL_006e;
							}
							return;
						case 1:
							break;
						case 2:
							return;
						case 0:
							return;
						}
						break;
						IL_006e:
						num2 = num3;
					}
					goto IL_0096;
					IL_0096:
					System.IO.File.Delete((string)path);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
					{
						num2 = 5;
					}
					goto IL_0072;
				}
				catch (global::System.Exception)
				{
					int num4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
					{
						num4 = 5;
					}
					while (true)
					{
						switch (num4)
						{
						case 0:
							return;
						}
						if (num5 == 988)
						{
							num4 = num5;
							continue;
						}
						return;
					}
				}
			default:
				return;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		kU9XOzkh8uI = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PRyPQ7Z6jQi1IvTvZaT2()
	{
		return bPvihMZ6LMS2hxZAhZ0b == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static hwiTKTXOTQtyeSoRURZk tjqRGjZ6ZVaqt82wfrVI()
	{
		return (hwiTKTXOTQtyeSoRURZk)bPvihMZ6LMS2hxZAhZ0b;
	}
}

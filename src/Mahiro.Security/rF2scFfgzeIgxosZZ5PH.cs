using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Microsoft.Win32.SafeHandles;
using QZs97cfg7H5cG2l6dckf;
using RWlN5dfgQtL6wjOfDV7i;
using eKYaxffghFvoT0eZRTxb;
using fDAldojjppXrctUVYOJn;
using i6TlJMfuChv2AjPXr7O8;

namespace MQLtWrflbjL7rOmZhG0a;

sealed class rF2scFfgzeIgxosZZ5PH : global::System.IDisposable
{
	private readonly object YfUflZMDX7q;

	private readonly object YPIfl9YbrF1;

	[CompilerGenerated]
	private readonly long CmPflDNY3RZ;

	[CompilerGenerated]
	private readonly nint am6flkoUhkX;

	private static object PIZavTZ1uxPPJOd4W0GO;

	internal long CreationTime
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return CmPflDNY3RZ;
		}
	}

	internal nint Window
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return am6flkoUhkX;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal rF2scFfgzeIgxosZZ5PH(Process process, zG6ueUfuQUk6CEmxLYji instance)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal nint oAbflXIgyFU(string name)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		int num = 3;
		global::System.Collections.IEnumerator enumerator = default(global::System.Collections.IEnumerator);
		ProcessModule val = default(ProcessModule);
		int num5 = default(int);
		nint result = default(nint);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0025;
				case 2:
					enumerator = (((dynamic)(YPIfl9YbrF1)).Modules).GetEnumerator();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
					{
						num2 = 4;
					}
					continue;
				case 0:
					try
					{
						while (true)
						{
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
								{
									num3 = 4;
								}
								goto IL_0095;
							}
							goto IL_00ff;
							IL_00ff:
							val = (ProcessModule)(enumerator).Current;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
							{
								num3 = 2;
							}
							goto IL_0095;
							IL_0095:
							while (true)
							{
								int num4;
								switch (num3)
								{
								default:
									switch (num5)
									{
									case 992:
										goto IL_0091;
									case 12:
										return result;
									}
									goto case 3;
								case 0:
									break;
								case 2:
									goto IL_00ff;
								case 1:
									if (!string.Equals((val).ModuleName, name, (StringComparison)5))
									{
										break;
									}
									num4 = 3;
									goto IL_008d;
								case 3:
									result = (val).BaseAddress;
									num4 = 12;
									goto IL_008d;
								case 4:
									goto end_IL_00cf;
									IL_0091:
									num3 = num5;
									continue;
									IL_008d:
									num5 = num4;
									goto IL_0091;
								}
								break;
							}
							continue;
							end_IL_00cf:
							break;
						}
					}
					finally
					{
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						int num6 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									num6 = num7;
									continue;
								}
								break;
							case 2:
								(disposable).Dispose();
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
								{
									num6 = 8;
								}
								continue;
							case 0:
								break;
							case 1:
								goto end_IL_01d3;
							}
							if (disposable != null)
							{
								num6 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
								{
									num6 = 2;
								}
								continue;
							}
							break;
							continue;
							end_IL_01d3:
							break;
						}
					}
					break;
				case 3:
					((dynamic)(YPIfl9YbrF1)).Refresh();
					num2 = 2;
					continue;
				case 1:
					break;
				}
				goto IL_0282;
				IL_0025:
				if (num == 991)
				{
					break;
				}
				goto IL_0282;
				IL_0282:
				return 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal nint O5mflfKuKHa(string path)
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		global::System.Collections.IEnumerator enumerator = default(global::System.Collections.IEnumerator);
		nint result = default(nint);
		ProcessModule val = default(ProcessModule);
		int num4 = default(int);
		int num7 = default(int);
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
					goto case 2;
				case 0:
					try
					{
						while (true)
						{
							IL_016e:
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 2;
								goto IL_006f;
							}
							goto IL_0151;
							IL_006f:
							while (true)
							{
								switch (num3)
								{
								case 5:
									throw new InvalidOperationException("游戏中已加载其他版本的面板，请重启游戏后加载当前版本");
								case 4:
									goto IL_0101;
								case 1:
									goto IL_0151;
								case 3:
									goto IL_016e;
								case 2:
									goto end_IL_016e;
								case 0:
									return result;
								}
								break;
								IL_0101:
								if (string.Equals(System.IO.Path.GetFullPath((val).FileName), System.IO.Path.GetFullPath(path), (StringComparison)5))
								{
									result = (val).BaseAddress;
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
									{
										num3 = 11;
									}
								}
								else
								{
									num3 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
									{
										num3 = 8;
									}
								}
							}
							if (num4 != 13)
							{
								if (num4 == 993)
								{
									goto IL_006b;
								}
								goto IL_0151;
							}
							if (!string.Equals((val).ModuleName, "Chronal.Bedrock.GameOverlay.dll", (StringComparison)5))
							{
								continue;
							}
							int num5 = 4;
							goto IL_0067;
							IL_0151:
							val = (ProcessModule)(enumerator).Current;
							num5 = 13;
							goto IL_0067;
							IL_0067:
							num4 = num5;
							goto IL_006b;
							IL_006b:
							num3 = num4;
							goto IL_006f;
							continue;
							end_IL_016e:
							break;
						}
					}
					finally
					{
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						int num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									num6 = num7;
									continue;
								}
								break;
							case 0:
								if (disposable != null)
								{
									num6 = 2;
									continue;
								}
								goto end_IL_022d;
							case 2:
								break;
							case 1:
								goto end_IL_022d;
							}
							(disposable).Dispose();
							num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
							{
								num6 = 1;
							}
							continue;
							end_IL_022d:
							break;
						}
					}
					break;
				case 2:
					enumerator = (((dynamic)(YPIfl9YbrF1)).Modules).GetEnumerator();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					((dynamic)(YPIfl9YbrF1)).Refresh();
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					break;
				}
				return 0;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void grCflLEkhBi(string path)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal uint MkIfljPfSJe(S7TvvYfg4lFMFZrHEXNd action, byte[]? parameter, bool readBack = false)
	{
		int num = 3;
		return default(uint);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		((dynamic)(YfUflZMDX7q)).Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PXGZoBZ1aUHGQRNhEbTg()
	{
		return PIZavTZ1uxPPJOd4W0GO == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rF2scFfgzeIgxosZZ5PH fEiO5hZ116MEtxDwe4Fp()
	{
		return (rF2scFfgzeIgxosZZ5PH)PIZavTZ1uxPPJOd4W0GO;
	}
}

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Microsoft.Win32.SafeHandles;
using OE8PAefgrSKuKZENyuFO;
using QZs97cfg7H5cG2l6dckf;
using RWlN5dfgQtL6wjOfDV7i;
using eKYaxffghFvoT0eZRTxb;
using fDAldojjppXrctUVYOJn;
using i6TlJMfuChv2AjPXr7O8;

namespace MQLtWrflbjL7rOmZhG0a;

internal sealed class rF2scFfgzeIgxosZZ5PH : global::System.IDisposable
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
		//IL_042e->IL00b6: Incompatible stack heights: 0 vs 1
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		int num = 1;
		int num5 = default(int);
		long created = default(long);
		uint processId = default(uint);
		string executable = default(string);
		int num7 = default(int);
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
					case 2:
						System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						throw new global::System.Exception("无法打开目标游戏进程");
					case 4:
						return;
					case 1:
						YPIfl9YbrF1 = process;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						goto end_IL_0031;
					case 3:
						try
						{
							if (KIAFMLfgmmKb9KvNAddq.JIrfgIt4is4((SafeProcessHandle)YfUflZMDX7q, out var processMachine, out var nativeMachine))
							{
								int num4 = 13;
								while (true)
								{
									object obj;
									switch (num4)
									{
									default:
										if (num5 != 23)
										{
											if (num5 == 1003)
											{
												goto IL_0164;
											}
											goto case 9;
										}
										CmPflDNY3RZ = created;
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
										{
											num4 = 0;
										}
										continue;
									case 9:
										if (Window == 0)
										{
											num4 = 4;
											continue;
										}
										goto case 7;
									case 2:
									{
										if (nativeMachine != 34404)
										{
											num4 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
											{
												num4 = 13;
											}
											continue;
										}
										if (KIAFMLfgmmKb9KvNAddq.fsAfgBagJeb((SafeProcessHandle)YfUflZMDX7q, out created, out var _, out var _, out var _))
										{
											num5 = 23;
											goto IL_0164;
										}
										goto case 10;
									}
									case 6:
										am6flkoUhkX = (process).MainWindowHandle;
										num4 = 9;
										continue;
									case 8:
										if (processId == (process).Id)
										{
											return;
										}
										num4 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
										{
											num4 = 15;
										}
										continue;
									case 14:
										pydDVmfgJj3EZPhXWwwK.z4mfgCnNCXx(instance, (process).Id, created, executable);
										num4 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
										{
											num4 = 6;
										}
										continue;
									case 13:
										if (processMachine != 0)
										{
											num4 = 11;
											continue;
										}
										goto case 2;
									case 7:
										if (KIAFMLfgmmKb9KvNAddq.yXafggvOo76(Window, out processId) == 0)
										{
											num4 = 3;
											continue;
										}
										goto case 8;
									case 10:
										throw System.Runtime.InteropServices.Marshal.GetLastWin32Error();
									case 1:
									case 11:
										break;
									case 0:
									{
										ProcessModule obj2 = (process).MainModule;
										if (obj2 == null)
										{
											num4 = 12;
											continue;
										}
										obj = (obj2).FileName;
										goto IL_03b1;
									}
									case 12:
										obj = null;
										goto IL_03b1;
									case 5:
										throw new global::System.Exception("无法读取游戏进程路径");
									case 3:
									case 4:
									case 15:
										{
											throw new global::System.Exception("游戏窗口尚未就绪，请稍后重试");
										}
										IL_03b1:
										if (obj == null)
										{
											num4 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
											{
												num4 = 11;
											}
										}
										else
										{
											executable = (string)obj;
											num4 = 14;
										}
										continue;
										IL_0164:
										num4 = num5;
										continue;
									}
									break;
								}
							}
							throw new global::System.Exception("游戏内面板只支持 Windows AMD64 游戏进程");
						}
						catch
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
							{
								num6 = 5;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										break;
									}
									goto case 0;
								case 0:
									(YfUflZMDX7q).Dispose();
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
									{
										num6 = 6;
									}
									break;
								case 1:
									throw new global::System.Exception();
								}
							}
						}
					}
					switch (num2)
					{
					case 992:
						break;
					default:
						return;
					case 12:
						if (!(YfUflZMDX7q).IsInvalid)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num3 = 3;
							}
						}
						else
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_0031:
				break;
			}
			YfUflZMDX7q = KIAFMLfgmmKb9KvNAddq.PlBfgAUiDOZ(4096u, inherit: false, (process).Id);
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
			{
				num = 12;
			}
		}
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
					enumerator = ((YPIfl9YbrF1).Modules).GetEnumerator();
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
					(YPIfl9YbrF1).Refresh();
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
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
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
							IL_016a:
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 2;
								goto IL_006f;
							}
							goto IL_014d;
							IL_006f:
							while (true)
							{
								switch (num3)
								{
								case 5:
									throw new global::System.Exception("游戏中已加载其他版本的面板，请重启游戏后加载当前版本");
								case 4:
									goto IL_00fd;
								case 1:
									goto IL_014d;
								case 3:
									goto IL_016a;
								case 2:
									goto end_IL_016a;
								case 0:
									return result;
								}
								break;
								IL_00fd:
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
								goto IL_014d;
							}
							if (!string.Equals((val).ModuleName, "Chronal.Bedrock.GameOverlay.dll", (StringComparison)5))
							{
								continue;
							}
							int num5 = 4;
							goto IL_0067;
							IL_014d:
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
							end_IL_016a:
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
								goto end_IL_0229;
							case 2:
								break;
							case 1:
								goto end_IL_0229;
							}
							(disposable).Dispose();
							num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
							{
								num6 = 1;
							}
							continue;
							end_IL_0229:
							break;
						}
					}
					break;
				case 2:
					enumerator = ((YPIfl9YbrF1).Modules).GetEnumerator();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					(YPIfl9YbrF1).Refresh();
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
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
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
				SSAmZdfgUo0ZTXXl02Ri.cDTfgomyBWc((YPIfl9YbrF1).Id, CreationTime, S7TvvYfg4lFMFZrHEXNd.LoadComponent, null, readBack: false, path);
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
				{
					num2 = 2;
				}
			}
		}
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
		int num = 1;
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					(YfUflZMDX7q).Dispose();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
					{
						num2 = 2;
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
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto IL_0031;
					case 2:
						goto end_IL_000e;
					case 0:
						return;
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
					xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
					{
						num3 = 3;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
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

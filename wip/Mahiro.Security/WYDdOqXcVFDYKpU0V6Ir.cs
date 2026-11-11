using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace Oq4bQvXcYX4iV1AeqLRj;

internal sealed class WYDdOqXcVFDYKpU0V6Ir : global::System.IDisposable
{
	private readonly object e1UXc0vkSnZ;

	private TcpListener? VEfXc85D8el;

	[CompilerGenerated]
	private readonly int RDvXcyvLDRI;

	internal static object JCoLu5ZBPgW4P1dtfhSP;

	internal int Port
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return RDvXcyvLDRI;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private WYDdOqXcVFDYKpU0V6Ir(TcpListener listener)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		RDvXcyvLDRI = ((object)(ECCurve)(listener).LocalEndpoint).Port;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static WYDdOqXcVFDYKpU0V6Ir iTJXcSFrufH(int port = 0)
	{
		//IL_0264: Expected O, but got I4
		//IL_026e->IL0010: Incompatible stack heights: 2 vs 1
		int num = 4;
		bool flag = default(bool);
		WYDdOqXcVFDYKpU0V6Ir result = default(WYDdOqXcVFDYKpU0V6Ir);
		TcpListener val = default(TcpListener);
		int num5 = default(int);
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
					default:
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						goto case 9;
					case 9:
						flag = false;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
						{
							num3 = 16;
						}
						continue;
					case 5:
						return result;
					case 4:
						if (port >= 0)
						{
							num = 3;
							break;
						}
						goto case 2;
					case 3:
						if (port <= 65535)
						{
							num = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num = 16;
							}
							break;
						}
						goto case 2;
					case 2:
						flag = true;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 6;
						}
						continue;
					case 1:
					case 8:
						if (!flag)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 7;
					case 6:
						try
						{
							(val).Start();
							int num4 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									result = (WYDdOqXcVFDYKpU0V6Ir)new WYDdOqXcVFDYKpU0V6Ir(val);
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						catch
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num6 = 3;
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
									(val).Stop();
									num6 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
									{
										num6 = 1;
									}
									break;
								case 1:
									throw new global::System.Exception();
								}
							}
						}
						goto case 5;
					case 7:
						throw new global::System.Exception("port");
					case 0:
						_ = IPAddress.Loopback;
						val = (TcpListener)(object)port;
						_ = 6;
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
	internal TcpListener YOIXcc4gR1B()
	{
		int num = 3;
		TcpListener result = default(TcpListener);
		bool flag = default(bool);
		object obj = default(object);
		int num4 = default(int);
		int num6 = default(int);
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
					return result;
				case 2:
					flag = false;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					obj = e1UXc0vkSnZ;
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					try
					{
						System.Threading.Monitor.Enter(obj, ref flag);
						int num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 990)
								{
									num3 = num4;
									continue;
								}
								break;
							case 2:
								throw new global::System.Exception("Java 端口租约已转移或释放");
							case 0:
								if (VEfXc85D8el != null)
								{
									result = Interlocked.Exchange<TcpListener>(ref VEfXc85D8el, (TcpListener)null);
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
									{
										num3 = 2;
									}
								}
								else
								{
									num3 = 2;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					finally
					{
						if (flag)
						{
							int num5 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 989)
									{
										num5 = num6;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0184;
								}
								System.Threading.Monitor.Exit(obj);
								num5 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
								{
									num5 = 0;
								}
								continue;
								end_IL_0184:
								break;
							}
						}
					}
					goto case 0;
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
		int num = 4;
		TcpListener val = default(TcpListener);
		bool flag = default(bool);
		object obj = default(object);
		int num5 = default(int);
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
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						(val).Stop();
						num3 = 2;
						break;
					case 0:
						if (val == null)
						{
							return;
						}
						goto end_IL_000c;
					case 3:
						flag = false;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							num3 = 1;
						}
						break;
					case 2:
						return;
					case 4:
						obj = e1UXc0vkSnZ;
						num3 = 3;
						break;
					case 1:
						try
						{
							System.Threading.Monitor.Enter(obj, ref flag);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
							{
								num4 = 5;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										num4 = num5;
										continue;
									}
									break;
								case 1:
									val = Interlocked.Exchange<TcpListener>(ref VEfXc85D8el, (TcpListener)null);
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							int num6;
							if (!flag)
							{
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
								{
									num6 = 2;
								}
								goto IL_0170;
							}
							goto IL_0194;
							IL_0170:
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										goto IL_016c;
									}
									goto end_IL_0170;
								case 2:
									break;
								case 1:
									goto end_IL_0170;
								case 0:
									goto end_IL_0170;
								}
								goto IL_0194;
								IL_016c:
								num6 = num7;
								continue;
								end_IL_0170:
								break;
							}
							goto end_IL_0138;
							IL_0194:
							System.Threading.Monitor.Exit(obj);
							num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
							{
								num6 = 6;
							}
							goto IL_0170;
							end_IL_0138:;
						}
						goto case 0;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
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
						if (num2 == 9)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto IL_0031;
					case 0:
						break;
					case 1:
						return;
					case 2:
						goto end_IL_000e;
					}
					goto IL_0068;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0068;
					IL_0068:
					xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
					{
						num3 = 1;
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
	internal static bool PZgGoiZBx2T5LArwvZla()
	{
		return JCoLu5ZBPgW4P1dtfhSP == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static WYDdOqXcVFDYKpU0V6Ir RodMEjZBF9e6IfkSxc7R()
	{
		return (WYDdOqXcVFDYKpU0V6Ir)JCoLu5ZBPgW4P1dtfhSP;
	}
}

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OTMIUdXfMSKu2otAneho;
using bUfedyCg1PBqhqIkB8r;
using bjMUVyQHhKZ3abxaWAg;
using fDAldojjppXrctUVYOJn;

namespace W8Gl8FXfG1y3WnYk42Fc;

sealed class XSMnFTXfqjQRx80Q4ocS : global::System.IDisposable
{
	private readonly object MovXLbi0uuX;

	private readonly object AsqXLXn1ZKq;

	private readonly Action<string>? tAbXLfSsNep;

	private int KuSXLLJff4u;

	private int c9dXLjdHxLb;

	internal static object J0SWTNZ7gYpdNfLP2WJ8;

	[MethodImpl((MethodImplOptions)8)]
	internal XSMnFTXfqjQRx80Q4ocS(Process process, JBOeppXfN11uYcZf56Wc buffer, Action<string>? lineObserver = null)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Start()
	{
		//IL_0185: Expected O, but got Unknown
		int num = 1;
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
					case 3:
						return;
					case 4:
						return;
					case 2:
						goto end_IL_000c;
					case 1:
						System.ObjectDisposedException.ThrowIf(System.Threading.Volatile.Read(ref c9dXLjdHxLb) != 0, this);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						if (System.Threading.Interlocked.Exchange(ref KuSXLLJff4u, 1) != 0)
						{
							return;
						}
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				switch (num2)
				{
				case 992:
					break;
				default:
					return;
				case 11:
					try
					{
						((dynamic)(MovXLbi0uuX)).BeginOutputReadLine();
						int num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
						{
							num4 = 5;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							default:
								if (num5 == 989)
								{
									num4 = num5;
									continue;
								}
								break;
							case 0:
								break;
							}
							((dynamic)(MovXLbi0uuX)).BeginErrorReadLine();
							num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num4 = 2;
							}
						}
					}
					catch (InvalidOperationException ex)
					{
						InvalidOperationException ex2 = ex;
						int num6 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
						{
							num6 = 2;
						}
						while (true)
						{
							switch (num6)
							{
							case 0:
								return;
							default:
								if (num7 == 990)
								{
									num6 = num7;
									continue;
								}
								break;
							case 2:
								cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)ex2, "caught-exception", "Start", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\JavaProcessOutputCapture.cs", 43);
								num6 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							((JBOeppXfN11uYcZf56Wc)AsqXLXn1ZKq).Nt7Xfp8T3mK("stderr", string.Concat("进程输出捕获启动失败：", ((ex2).GetType()).Name));
							num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num6 = 1;
							}
						}
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void vc1XfiUjPLQ(object sender, DataReceivedEventArgs eventArgs)
	{
		FENXfzMSp6m("stdout", (eventArgs).Data);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ahcXfntYtQA(object sender, DataReceivedEventArgs eventArgs)
	{
		FENXfzMSp6m("stderr", (eventArgs).Data);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void FENXfzMSp6m(string channel, string? line)
	{
		int num = 4;
		string text = default(string);
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
							goto case 0;
						}
						return;
					case 3:
						break;
					case 1:
						try
						{
							Action<string>? obj = tAbXLfSsNep;
							int num4;
							if (obj == null)
							{
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
								{
									num4 = 1;
								}
							}
							else
							{
								obj.Invoke(text);
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
								{
									num4 = 3;
								}
							}
							while (true)
							{
								switch (num4)
								{
								case 0:
									return;
								case 1:
									return;
								}
								if (num5 == 989)
								{
									num4 = num5;
									continue;
								}
								return;
							}
						}
						catch
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								num6 = 6;
							}
							while (true)
							{
								switch (num6)
								{
								case 0:
									return;
								}
								if (num7 == 988)
								{
									num6 = num7;
									continue;
								}
								return;
							}
						}
					case 2:
						return;
					case 0:
						((JBOeppXfN11uYcZf56Wc)AsqXLXn1ZKq).Nt7Xfp8T3mK(channel, text);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						if (System.Threading.Volatile.Read(ref c9dXLjdHxLb) == 0)
						{
							num3 = 3;
							continue;
						}
						return;
					}
					if (string.IsNullOrEmpty(line))
					{
						goto end_IL_000c;
					}
					text = c7OGv5QKxt7AwetRqiP.acYQthGMrG(line);
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
					{
						num3 = 0;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		int num = 5;
		int num9 = default(int);
		int num11 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_000c:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 6:
						num3 = 3;
						continue;
					case 5:
						if (System.Threading.Interlocked.Exchange(ref c9dXLjdHxLb, 1) == 0)
						{
							num3 = 4;
							continue;
						}
						return;
					case 0:
						return;
					case 7:
						goto end_IL_0010;
					case 3:
						try
						{
							((dynamic)(MovXLbi0uuX)).CancelErrorRead();
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
							{
								num8 = 2;
							}
							while (true)
							{
								switch (num8)
								{
								case 0:
									return;
								}
								if (num9 != 988)
								{
									return;
								}
								num8 = num9;
							}
						}
						catch
						{
							int num10 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								case 0:
									return;
								}
								if (num11 != 988)
								{
									return;
								}
								num10 = num11;
							}
						}
					case 2:
						try
						{
							((dynamic)(MovXLbi0uuX)).CancelOutputRead();
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num4 = 2;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
							{
								num6 = 0;
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
						goto case 6;
					case 1:
						return;
					case 4:
						goto IL_0296;
					}
					switch (num2)
					{
					case 995:
						break;
					default:
						return;
					case 14:
						if (System.Threading.Volatile.Read(ref KuSXLLJff4u) == 0)
						{
							return;
						}
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
						{
							num3 = 0;
						}
						continue;
					}
					goto IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				((dynamic)(MovXLbi0uuX)).ErrorDataReceived -= new DataReceivedEventHandler(ahcXfntYtQA);
				num = 14;
				break;
				IL_0296:
				((dynamic)(MovXLbi0uuX)).OutputDataReceived -= new DataReceivedEventHandler(vc1XfiUjPLQ);
				num = 7;
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool EvwdpUZ7layZPoRZlu04()
	{
		return J0SWTNZ7gYpdNfLP2WJ8 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static XSMnFTXfqjQRx80Q4ocS jVaaSsZ7dR8XBUMjcmkg()
	{
		return (XSMnFTXfqjQRx80Q4ocS)J0SWTNZ7gYpdNfLP2WJ8;
	}
}

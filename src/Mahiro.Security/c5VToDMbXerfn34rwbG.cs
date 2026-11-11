using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using gh4IKxNGTwx3Xea0FWT;
using hGYycdXXDoG2mOL5yubN;
using spH9YHzfeKbvDBT5W0L;

namespace dwBQfPMXqPDU8deTdOQ;

public class c5VToDMbXerfn34rwbG
{
	internal static object qn9JLNZhjigTsodpWPml;

	[MethodImpl((MethodImplOptions)8)]
	public static D6WKW6NqlINYgWfn0kj oumMfiRKjG()
	{
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num4 = default(int);
		bool flag2 = default(bool);
		D6WKW6NqlINYgWfn0kj result = default(D6WKW6NqlINYgWfn0kj);
		DateTimeOffset observedAt = default(DateTimeOffset);
		bool flag = default(bool);
		string authBridgeComponentVersion = default(string);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		global::System.Exception ex = default(global::System.Exception);
		int num8 = default(int);
		bool flag3 = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num10 = default(int);
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
				case 0:
					try
					{
						string text = Q8xMnNXX9IjGqqCAeb4q.chNXXk5QNlI();
						int num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num3 = 3;
						}
						while (true)
						{
							int num5;
							string text2;
							switch (num3)
							{
							default:
								if (num4 != 18)
								{
									if (num4 != 998)
									{
										break;
									}
									goto IL_0069;
								}
								if (flag2)
								{
									num3 = 3;
									continue;
								}
								num5 = 0;
								goto IL_01d6;
							case 6:
							case 7:
								result = pR5MjhsDwB(observedAt, "official_launcher_not_found");
								num3 = 8;
								continue;
							case 3:
								num5 = (q5o4yvzXGfK2XxreLgF.axRzjBcyKF(text) ? 1 : 0);
								goto IL_01d6;
							case 9:
							{
								flag2 = q5o4yvzXGfK2XxreLgF.y4lzD8I9nU(text);
								int num6 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
								{
									num6 = 16;
								}
								num4 = num6;
								goto IL_0069;
							}
							case 1:
								if (!flag2)
								{
									num3 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								text2 = eSXMLb5F8Y(text);
								goto IL_01fe;
							case 0:
								if (!System.IO.File.Exists(text))
								{
									num3 = 6;
									continue;
								}
								goto case 9;
							case 5:
								if (string.IsNullOrWhiteSpace(text))
								{
									num3 = 7;
									continue;
								}
								goto case 0;
							case 2:
								text2 = string.Empty;
								goto IL_01fe;
							case 8:
								goto end_IL_006d;
							case 10:
								break;
							case 4:
								goto end_IL_006d;
								IL_0069:
								num3 = num4;
								continue;
								IL_01d6:
								flag = (byte)num5 != 0;
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
								{
									num3 = 1;
								}
								continue;
								IL_01fe:
								authBridgeComponentVersion = text2;
								num3 = 10;
								continue;
							}
							result = (D6WKW6NqlINYgWfn0kj)new D6WKW6NqlINYgWfn0kj(LauncherDetected: true, q5o4yvzXGfK2XxreLgF.BxEzkcSoLn(text), flag2, flag, 3, authBridgeComponentVersion, observedAt, flag ? "connection_environment_ready" : (flag2 ? "connection_bridge_update_required" : "connection_bridge_not_installed"));
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
							{
								num3 = 13;
							}
							continue;
							end_IL_006d:
							break;
						}
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num7 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
							{
								num7 = 3;
							}
						}
						else
						{
							ex = obj2;
							num7 = 6;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								if (num8 != 20)
								{
									if (num8 == 1000)
									{
										goto IL_02f3;
									}
									goto case 11;
								}
								goto case 5;
							case 0:
								if (!(ex is NotSupportedException))
								{
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
									{
										num7 = 11;
									}
									continue;
								}
								goto case 2;
							case 1:
								if (ex is SecurityException)
								{
									num7 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
									{
										num7 = 11;
									}
									continue;
								}
								goto case 7;
							case 9:
								flag3 = false;
								num7 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
								{
									num7 = 5;
								}
								continue;
							case 6:
								if (!(ex is IOException))
								{
									num7 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
									{
										num7 = 10;
									}
									continue;
								}
								goto case 2;
							case 7:
								if (ex is Win32Exception)
								{
									num7 = 2;
									continue;
								}
								goto case 9;
							case 2:
							case 4:
							case 8:
								flag3 = true;
								num8 = 20;
								goto IL_02f3;
							case 10:
								if (ex is UnauthorizedAccessException)
								{
									num7 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
									{
										num7 = 8;
									}
									continue;
								}
								goto case 11;
							case 12:
								if (!(ex is InvalidOperationException))
								{
									num7 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
									{
										num7 = 0;
									}
									continue;
								}
								goto case 2;
							case 11:
								if (!(ex is ArgumentException))
								{
									num7 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
									{
										num7 = 15;
									}
									continue;
								}
								goto case 2;
							case 3:
								result2 = 0;
								break;
							case 5:
								{
									result2 = (flag3 ? 1 : 0);
									break;
								}
								IL_02f3:
								num7 = num8;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num9 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num9 = 3;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 == 989)
								{
									num9 = num10;
									continue;
								}
								break;
							case 1:
								result = pR5MjhsDwB(observedAt, "connection_environment_probe_failed");
								num9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
								{
									num9 = 6;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 2;
				case 2:
					return result;
				case 1:
					observedAt = System.DateTimeOffset.UtcNow;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
					{
						num2 = 2;
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
	private static string eSXMLb5F8Y(object launcherPath)
	{
		int num = 1;
		int num3 = default(int);
		string result = default(string);
		string text3 = default(string);
		string text4 = default(string);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num9 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					string text = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath((string)launcherPath));
					int num2 = 9;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
					{
						num2 = 9;
					}
					while (true)
					{
						string text2;
						switch (num2)
						{
						default:
							if (num3 != 17)
							{
								if (num3 == 997)
								{
									goto IL_0078;
								}
								goto case 5;
							}
							result = string.Empty;
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
							{
								num2 = 11;
							}
							continue;
						case 1:
							text3 = (System.Diagnostics.FileVersionInfo.GetVersionInfo(text4)).FileVersion;
							num2 = 8;
							continue;
						case 8:
							if (!string.IsNullOrWhiteSpace(text3))
							{
								num2 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
								{
									num2 = 2;
								}
								continue;
							}
							text2 = string.Empty;
							break;
						case 9:
							if (string.IsNullOrWhiteSpace(text))
							{
								int num4 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
								{
									num4 = 17;
								}
								num3 = num4;
								goto IL_0078;
							}
							goto case 5;
						case 7:
							goto end_IL_007c;
						case 2:
							result = string.Empty;
							num2 = 4;
							continue;
						case 5:
							text4 = System.IO.Path.Combine(text, "Chronal.JavaOfficialHostBridge.dll");
							num2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
							{
								num2 = 6;
							}
							continue;
						case 6:
							if (!System.IO.File.Exists(text4))
							{
								num2 = 2;
								continue;
							}
							goto case 1;
						case 0:
							text2 = text3;
							break;
						case 4:
							goto end_IL_007c;
						case 3:
							goto end_IL_007c;
							IL_0078:
							num2 = num3;
							continue;
						}
						result = text2;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
						{
							num2 = 3;
						}
						continue;
						end_IL_007c:
						break;
					}
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num5 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
						{
							num5 = 0;
						}
					}
					else
					{
						ex = obj2;
						num5 = 10;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 != 23)
							{
								if (num6 == 1003)
								{
									goto IL_02a4;
								}
								goto case 3;
							}
							goto case 13;
						case 2:
						case 4:
						case 5:
						case 14:
						case 15:
							flag = true;
							num5 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
							{
								num5 = 1;
							}
							continue;
						case 9:
							if (!(ex is ArgumentException))
							{
								num5 = 12;
								continue;
							}
							goto case 2;
						case 12:
							if (ex is InvalidOperationException)
							{
								num5 = 19;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
								{
									num5 = 4;
								}
								continue;
							}
							goto case 11;
						case 10:
							if (ex is IOException)
							{
								num5 = 14;
								continue;
							}
							goto case 3;
						case 7:
							if (!(ex is Win32Exception))
							{
								num7 = 23;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
								{
									num7 = 18;
								}
								num6 = num7;
								goto IL_02a4;
							}
							goto case 2;
						case 13:
							flag = false;
							num5 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
							{
								num5 = 13;
							}
							continue;
						case 11:
							if (ex is NotSupportedException)
							{
								num5 = 19;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
								{
									num5 = 15;
								}
								continue;
							}
							goto case 8;
						case 3:
							if (!(ex is UnauthorizedAccessException))
							{
								num5 = 19;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
								{
									num5 = 9;
								}
								continue;
							}
							goto case 2;
						case 8:
							if (ex is SecurityException)
							{
								num5 = 5;
								continue;
							}
							goto case 7;
						case 0:
							result2 = 0;
							break;
						case 1:
						case 6:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_02a4:
							num5 = num6;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num8 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
					{
						num8 = 7;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							if (num9 == 989)
							{
								num8 = num9;
								continue;
							}
							break;
						case 0:
							result = string.Empty;
							num8 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
							{
								num8 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static D6WKW6NqlINYgWfn0kj pR5MjhsDwB(DateTimeOffset observedAt, object statusCode)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return (D6WKW6NqlINYgWfn0kj)new D6WKW6NqlINYgWfn0kj(LauncherDetected: false, LauncherRunning: false, BridgeInstalled: false, BridgeFilesCurrent: false, 3, string.Empty, observedAt, (string)statusCode);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SMgSxiZhZHuESOSW38PU()
	{
		return qn9JLNZhjigTsodpWPml == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static c5VToDMbXerfn34rwbG VC1Fb5Zh9jqNAMYGJdsr()
	{
		return (c5VToDMbXerfn34rwbG)qn9JLNZhjigTsodpWPml;
	}
}

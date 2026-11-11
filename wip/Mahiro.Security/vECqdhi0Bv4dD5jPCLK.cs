using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using CW7hqXicv7b4qGMMOt5;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using K8Bfv6n4XADtVn1mOXW;
using L2iMPciJAUUQWujaTvW;
using fDAldojjppXrctUVYOJn;
using lSwbeIiYncqNAPG924P;

namespace WBqLUri8LoiQLvO8XkF;

internal sealed class vECqdhi0Bv4dD5jPCLK : WU5IcQiSUC9FinMT5sJ
{
	internal static object MNTbCOZo5kyEj0yLmRnI;

	[MethodImpl((MethodImplOptions)8)]
	public P83acLiVaQYLLKlo2dq yiML4ryZBIj(J1NHH0nCOdcOgf7vIi2 launch)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		Process val = default(Process);
		int num5 = default(int);
		P83acLiVaQYLLKlo2dq result = default(P83acLiVaQYLLKlo2dq);
		H9xiuWiW89hL8qcyGK8 h9xiuWiW89hL8qcyGK = default(H9xiuWiW89hL8qcyGK8);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		global::System.Exception ex = default(global::System.Exception);
		int num8 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num11 = default(int);
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
						goto IL_04a2;
					case 4:
						if (!(launch.ProcessStartedAt == default(DateTimeOffset)))
						{
							val = null;
							num3 = 3;
							break;
						}
						goto end_IL_000c;
					case 3:
						try
						{
							val = System.Diagnostics.Process.GetProcessById(launch.ProcessId);
							int num4 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								num4 = 2;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									switch (num5)
									{
									case 993:
										break;
									default:
										goto end_IL_00b7;
									case 13:
										throw new global::System.Exception("官方游戏进程启动身份不匹配");
									}
									goto IL_00b3;
								case 1:
									result = h9xiuWiW89hL8qcyGK;
									num4 = 4;
									continue;
								case 3:
								{
									h9xiuWiW89hL8qcyGK.Dispose();
									int num6 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
									{
										num6 = 13;
									}
									num5 = num6;
									goto IL_00b3;
								}
								case 0:
									if (h9xiuWiW89hL8qcyGK.HasExpectedIdentity)
									{
										num4 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 3;
								case 2:
								{
									Process process = val;
									int processId = launch.ProcessId;
									DateTimeOffset processStartedAt = launch.ProcessStartedAt;
									h9xiuWiW89hL8qcyGK = (H9xiuWiW89hL8qcyGK8)new H9xiuWiW89hL8qcyGK8(process, processId, (processStartedAt).ToUniversalTime(), A82iy7YrmH(val), (val).SessionId);
									num4 = 5;
									continue;
								}
								case 5:
									val = null;
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
									{
										num4 = 0;
									}
									continue;
								case 4:
									break;
									IL_00b3:
									num4 = num5;
									continue;
									end_IL_00b7:
									break;
								}
								break;
							}
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num7 = 8;
							}
							else
							{
								ex = obj2;
								num7 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
								{
									num7 = 11;
								}
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 != 18)
									{
										if (num8 == 998)
										{
											goto IL_0226;
										}
										goto case 1;
									}
									if (!(ex is IOException))
									{
										num7 = 6;
										continue;
									}
									goto case 0;
								case 10:
									if (!(ex is NotSupportedException))
									{
										num9 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
										{
											num9 = 18;
										}
										num8 = num9;
										goto IL_0226;
									}
									goto case 0;
								case 4:
									if (!(ex is InvalidOperationException))
									{
										num7 = 7;
										continue;
									}
									goto case 0;
								case 2:
								case 3:
									flag = false;
									num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
									{
										num7 = 1;
									}
									continue;
								case 0:
									flag = true;
									num7 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
									{
										num7 = 4;
									}
									continue;
								case 7:
									if (!(ex is Win32Exception))
									{
										num7 = 10;
										continue;
									}
									goto case 0;
								case 5:
									if (!(ex is ArgumentException))
									{
										num7 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											num7 = 10;
										}
										continue;
									}
									goto case 0;
								case 6:
									if (!(ex is UnauthorizedAccessException))
									{
										num7 = 2;
										continue;
									}
									goto case 0;
								case 8:
									result2 = 0;
									break;
								case 1:
								case 9:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_0226:
									num7 = num8;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num10 = 2;
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 990)
									{
										num10 = num11;
										continue;
									}
									goto case 0;
								case 2:
									if (val != null)
									{
										num10 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
										{
											num10 = 0;
										}
										continue;
									}
									break;
								case 0:
									(val).Dispose();
									num10 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num10 = 2;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
							_ = "无法附加官方游戏进程";
							throw ex;
						}
						goto case 2;
					case 2:
						return result;
					case 0:
						if (launch.ProcessId > 0)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
							{
								num3 = 4;
							}
							break;
						}
						goto IL_04a2;
					case 1:
						{
							System.ArgumentNullException.ThrowIfNull(launch, "launch");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
							{
								num3 = 2;
							}
							break;
						}
						IL_04a2:
						_ = "官方游戏进程身份无效";
						throw new global::System.Exception("launch");
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
	private static string A82iy7YrmH(object process)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					if (num == 989)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
				{
					ProcessModule obj2 = (process).MainModule;
					if (obj2 == null)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = (obj2).FileName;
					break;
				}
				case 0:
					obj = null;
					break;
				}
				if (string.IsNullOrWhiteSpace((string)obj))
				{
					throw new global::System.Exception("无法读取官方游戏进程可执行路径");
				}
				return System.IO.Path.GetFullPath((string)obj);
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public vECqdhi0Bv4dD5jPCLK()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto end_IL_0012;
					case 1:
						break;
					case 2:
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
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
			while (num2 == 990);
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lAgD5uZo6HKnhxa4BKLR()
	{
		return MNTbCOZo5kyEj0yLmRnI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static vECqdhi0Bv4dD5jPCLK DaNkmEZoR7NPq4LkM4EO()
	{
		return (vECqdhi0Bv4dD5jPCLK)MNTbCOZo5kyEj0yLmRnI;
	}
}

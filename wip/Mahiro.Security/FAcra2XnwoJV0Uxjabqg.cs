using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using I8kVvQmUGdEncAIoxaC;
using PyuVEjXnR5rg1eGb5BfU;
using URYDCfoED4sjjHBaoJH;
using fDAldojjppXrctUVYOJn;

namespace fj1JbeXneT9aM4GFvt98;

internal class FAcra2XnwoJV0Uxjabqg
{
	private struct nUqXNMLVeGehJf8CoeEl
	{
		internal uint xvRLVPeO0WW;

		internal uint JusLVxXdoIv;

		internal uint syvLVFo6vvn;

		internal uint ktJLVsbt4pg;

		internal ulong vuVLVTvpSjU;

		internal ulong bXnLVNJOZ0N;

		internal ulong wHnLVMo6AFw;

		internal uint bN6LVpopkDr;

		internal uint tA7LVuWhqJY;
	}

	private struct bGPuOgLVakNQgWfKSVR1
	{
		internal uint SQCLV1IfPvY;

		internal uint KhyLV3sUHJq;

		internal uint YstLVvkYq9I;

		internal uint s7QLVEElmdm;

		internal ulong f3ULV24Fq85;
	}

	private delegate uint klDRtKLVqQXcIx7AqJnc(ref nUqXNMLVeGehJf8CoeEl request, ref bGPuOgLVakNQgWfKSVR1 result);

	internal static object sSrXgCZFvcGecryjw182;

	[MethodImpl((MethodImplOptions)8)]
	internal static ulong uXLXnP9reW5(uint pid, ulong created, V3RCVkXn6cotYi3kDTMp action, ulong address, int length, byte[]? bytes = null)
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
				case 0:
					throw new global::System.Exception("原生内存操作意外返回可重试分配冲突。");
				case 1:
					break;
				}
				goto IL_0056;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_0056;
				IL_0056:
				if (yrPXnFRyIO6(pid, created, action, address, length, bytes, allowAddressConflict: false, out var addressResult))
				{
					return addressResult;
				}
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool U9MXnxst4IH(uint pid, ulong created, ulong address, int length, out ulong allocated)
	{
		int num = 2;
		allocated = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool yrPXnFRyIO6(uint pid, ulong created, V3RCVkXn6cotYi3kDTMp action, ulong address, int length, object? bytes, bool allowAddressConflict, out ulong addressResult)
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		GCHandle val = default(GCHandle);
		bool result2 = default(bool);
		nUqXNMLVeGehJf8CoeEl nUqXNMLVeGehJf8CoeEl = default(nUqXNMLVeGehJf8CoeEl);
		int num6 = default(int);
		bGPuOgLVakNQgWfKSVR1 result = default(bGPuOgLVakNQgWfKSVR1);
		bGPuOgLVakNQgWfKSVR1 bGPuOgLVakNQgWfKSVR = default(bGPuOgLVakNQgWfKSVR1);
		nUqXNMLVeGehJf8CoeEl request = default(nUqXNMLVeGehJf8CoeEl);
		uint num7 = default(uint);
		klDRtKLVqQXcIx7AqJnc delegateForFunctionPointer = default(klDRtKLVqQXcIx7AqJnc);
		int num10 = default(int);
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						val = default(GCHandle);
						num3 = 6;
						continue;
					case 4:
						if (length <= 1048576)
						{
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 7;
					case 7:
						throw new global::System.Exception("length");
					case 1:
						if (bytes != null)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
							{
								num3 = 4;
							}
							continue;
						}
						break;
					case 0:
						addressResult = default;
						return result2;
					case 3:
						addressResult = 0uL;
						num3 = 2;
						continue;
					case 2:
						if (length >= 0)
						{
							num3 = 4;
							continue;
						}
						goto case 7;
					case 5:
						if (((global::System.Array)bytes).Length != length)
						{
							num3 = 7;
							continue;
						}
						break;
					case 6:
						try
						{
							int num4;
							if (bytes != null)
							{
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
								{
									num4 = 7;
								}
								goto IL_019a;
							}
							goto IL_05d0;
							IL_05d0:
							nUqXNMLVeGehJf8CoeEl = default(nUqXNMLVeGehJf8CoeEl);
							int num5 = 24;
							goto IL_0192;
							IL_0196:
							num4 = num6;
							goto IL_019a;
							IL_019a:
							while (true)
							{
								switch (num4)
								{
								case 10:
									result = bGPuOgLVakNQgWfKSVR;
									num4 = 6;
									continue;
								case 0:
									nUqXNMLVeGehJf8CoeEl.JusLVxXdoIv = 3u;
									num4 = 30;
									continue;
								case 29:
									throw new global::System.Exception("原生内存操作报告成功，但未返回分配地址。");
								case 13:
									addressResult = result.f3ULV24Fq85;
									num4 = 4;
									continue;
								case 31:
									request = nUqXNMLVeGehJf8CoeEl;
									num4 = 20;
									continue;
								case 23:
									nUqXNMLVeGehJf8CoeEl.bN6LVpopkDr = checked((uint)length);
									num4 = 31;
									continue;
								case 26:
									result2 = false;
									num4 = 21;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num4 = 33;
									}
									continue;
								case 7:
									bGPuOgLVakNQgWfKSVR.KhyLV3sUHJq = 3u;
									num4 = 37;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
									{
										num4 = 10;
									}
									continue;
								case 15:
									if (result.SQCLV1IfPvY == Marshal.SizeOf<bGPuOgLVakNQgWfKSVR1>())
									{
										num4 = 33;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
										{
											num4 = 11;
										}
										continue;
									}
									goto case 3;
								case 25:
									nUqXNMLVeGehJf8CoeEl.vuVLVTvpSjU = created;
									num4 = 8;
									continue;
								case 19:
									if (num7 == 8198)
									{
										num4 = 35;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
										{
											num4 = 9;
										}
										continue;
									}
									goto IL_0524;
								case 22:
									if (action == V3RCVkXn6cotYi3kDTMp.Allocate)
									{
										num4 = 19;
										continue;
									}
									goto IL_0524;
								case 4:
									result2 = true;
									num4 = 12;
									continue;
								case 6:
									num7 = delegateForFunctionPointer(ref request, ref result);
									num4 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
									{
										num4 = 26;
									}
									continue;
								case 24:
									nUqXNMLVeGehJf8CoeEl.xvRLVPeO0WW = (uint)Marshal.SizeOf<nUqXNMLVeGehJf8CoeEl>();
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num4 = 0;
									}
									continue;
								case 14:
									bGPuOgLVakNQgWfKSVR.SQCLV1IfPvY = (uint)Marshal.SizeOf<bGPuOgLVakNQgWfKSVR1>();
									num4 = 7;
									continue;
								case 3:
									throw new global::System.Exception("原生内存操作 ABI 不兼容。");
								case 27:
									goto IL_047b;
								case 17:
									if (action == V3RCVkXn6cotYi3kDTMp.Allocate)
									{
										num4 = 18;
										continue;
									}
									goto case 13;
								case 20:
									bGPuOgLVakNQgWfKSVR = default(bGPuOgLVakNQgWfKSVR1);
									num4 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
									{
										num4 = 14;
									}
									continue;
								case 28:
									nUqXNMLVeGehJf8CoeEl.ktJLVsbt4pg = pid;
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
									{
										num4 = 25;
									}
									continue;
								case 11:
									if (result.KhyLV3sUHJq != 3)
									{
										goto case 3;
									}
									goto IL_04ff;
								case 9:
									goto IL_0509;
								case 2:
									goto IL_0524;
								case 8:
									nUqXNMLVeGehJf8CoeEl.bXnLVNJOZ0N = address;
									num4 = 16;
									continue;
								case 21:
									goto end_IL_019a;
								case 18:
									if (result.f3ULV24Fq85 != 0L)
									{
										num4 = 13;
										continue;
									}
									goto case 29;
								case 30:
									nUqXNMLVeGehJf8CoeEl.syvLVFo6vvn = (uint)action;
									num4 = 28;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
									{
										num4 = 15;
									}
									continue;
								case 1:
									val = System.Runtime.InteropServices.GCHandle.Alloc(bytes, (GCHandleType)3);
									num4 = 5;
									continue;
								case 5:
									goto IL_05d0;
								case 16:
									goto IL_05e2;
								case 12:
									goto end_IL_019a;
								}
								if (num6 != 39)
								{
									if (num6 == 1019)
									{
										goto IL_0196;
									}
									goto IL_05e2;
								}
								if (result.YstLVvkYq9I != num7)
								{
									num4 = 3;
									continue;
								}
								if (allowAddressConflict)
								{
									num4 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
									{
										num4 = 22;
									}
									continue;
								}
								goto IL_0524;
								IL_0509:
								if (result.s7QLVEElmdm == 487)
								{
									goto IL_051a;
								}
								goto IL_0524;
								IL_0524:
								if (num7 == 0)
								{
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
									{
										num4 = 17;
									}
									continue;
								}
								goto IL_047b;
								IL_047b:
								throw new HeOiCXovnuVhGHyE2EO(num7, result.s7QLVEElmdm, checked((uint)result.f3ULV24Fq85), (string?)null);
								IL_05e2:
								long wHnLVMo6AFw;
								if (!(val).IsAllocated)
								{
									wHnLVMo6AFw = 0L;
								}
								else
								{
									nint num8 = (val).AddrOfPinnedObject();
									wHnLVMo6AFw = (num8).ToInt64();
								}
								nUqXNMLVeGehJf8CoeEl.wHnLVMo6AFw = (ulong)wHnLVMo6AFw;
								num4 = 23;
								continue;
								end_IL_019a:
								break;
							}
							goto end_IL_0162;
							IL_04ff:
							num5 = 39;
							goto IL_0192;
							IL_0192:
							num6 = num5;
							goto IL_0196;
							IL_051a:
							num5 = 26;
							goto IL_0192;
							end_IL_0162:;
						}
						finally
						{
							int num9;
							if (!(val).IsAllocated)
							{
								num9 = 2;
								goto IL_0657;
							}
							goto IL_069f;
							IL_069f:
							(val).Free();
							num9 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
							{
								num9 = 0;
							}
							goto IL_0657;
							IL_0657:
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 990)
									{
										goto IL_0653;
									}
									break;
								case 2:
									goto end_IL_0657;
								case 1:
									break;
								case 0:
									goto end_IL_0657;
								}
								goto IL_069f;
								IL_0653:
								num9 = num10;
								continue;
								end_IL_0657:
								break;
							}
						}
						goto case 0;
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
			delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer<klDRtKLVqQXcIx7AqJnc>((global::nint)rDf13emhypQ5FFQEmmM.pI3mIjtv0a("chronal_bedrock_memory_operation"));
			num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
			{
				num = 14;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto end_IL_0012;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						break;
					case 2:
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
			{
				num = 3;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool QQdb2iZFEFswthDHMpYx()
	{
		return sSrXgCZFvcGecryjw182 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static FAcra2XnwoJV0Uxjabqg Mi8iWwZF22OiZVFamfnI()
	{
		return (FAcra2XnwoJV0Uxjabqg)sSrXgCZFvcGecryjw182;
	}
}

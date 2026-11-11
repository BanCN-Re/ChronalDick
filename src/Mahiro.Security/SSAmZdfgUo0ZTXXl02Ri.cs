using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using eKYaxffghFvoT0eZRTxb;
using fDAldojjppXrctUVYOJn;
using iFG88Vmb1p0qPpvwBpT;

namespace OE8PAefgrSKuKZENyuFO;

internal class SSAmZdfgUo0ZTXXl02Ri
{
	private static object cKLLp5Z1di1YmpldmTyX;

	[MethodImpl((MethodImplOptions)8)]
	internal static uint cDTfgomyBWc(int pid, long created, S7TvvYfg4lFMFZrHEXNd action, byte[]? parameter, bool readBack, string component = "")
	{
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]> result = default(ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>);
		int num5 = default(int);
		uint tCLf2hXG36T = default(uint);
		int num7 = default(int);
		TaskAwaiter<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>> awaiter = default(TaskAwaiter<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>>);
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
						goto case 3;
					case 4:
						if (pid <= 0)
						{
							goto end_IL_000c;
						}
						goto case 5;
					case 2:
						try
						{
							if (result.Item1.Vgmf2QCLK8A != pid)
							{
								goto IL_0176;
							}
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
							{
								num4 = 4;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 != 13)
									{
										if (num5 == 993)
										{
											goto IL_00a9;
										}
										goto case 0;
									}
									if (parameter != null)
									{
										num4 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 5;
								case 5:
									tCLf2hXG36T = result.Item1.TCLf2hXG36T;
									num4 = 2;
									continue;
								case 0:
									(result.Item2).CopyTo(parameter, 0);
									num4 = 5;
									continue;
								case 4:
									if (result.Item1.nbff243SFxv == (ulong)created)
									{
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
										{
											num4 = 7;
										}
										continue;
									}
									break;
								case 3:
									break;
								case 1:
									if (result.Item2.Length == (readBack ? ((parameter != null) ? parameter.Length : 0) : 0))
									{
										if (readBack)
										{
											num5 = 13;
											goto IL_00a9;
										}
										goto case 5;
									}
									num4 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
									{
										num4 = 2;
									}
									continue;
								case 2:
									goto end_IL_00ad;
									IL_00a9:
									num4 = num5;
									continue;
								}
								goto IL_0176;
								continue;
								end_IL_00ad:
								break;
							}
							goto end_IL_0068;
							IL_0176:
							throw new InvalidDataException("面板原生操作回执不一致");
							end_IL_0068:;
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(result.Item2);
							int num6 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
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
					case 6:
						return tCLf2hXG36T;
					case 5:
						if (created > 0)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num3 = 7;
							}
							break;
						}
						goto case 3;
					case 7:
						result = awaiter.GetResult();
						num3 = 2;
						break;
					case 1:
						if (global::System.Enum.IsDefined<S7TvvYfg4lFMFZrHEXNd>(action))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
							{
								num3 = 9;
							}
							break;
						}
						goto case 3;
					case 3:
						throw new ArgumentException("面板原生操作身份无效");
					case 0:
						awaiter = hM3QRXozIobMSJf4Wde.ExecuteAsync(5u, new global::__f__AnonymousType54_6<int, long, uint, int, string, string>(pid, created, (uint)action, readBack ? 1 : 0, component, (parameter == null) ? string.Empty : System.Convert.ToBase64String(parameter)), System.Threading.CancellationToken.None).GetAwaiter();
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 7;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 14;
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
	internal static bool CwPSC0Z1KWDqhuEjfsMJ()
	{
		return cKLLp5Z1di1YmpldmTyX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SSAmZdfgUo0ZTXXl02Ri xRZs0ZZ1HILSyYetfBCp()
	{
		return (SSAmZdfgUo0ZTXXl02Ri)cKLLp5Z1di1YmpldmTyX;
	}
}

using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using knGiRcfu9DhbMgArQGtn;

namespace ApXVIGfLBExBOkmp7S8U;

internal sealed class DWmHe0fLIlSc8QoshHUj : IProgress<TNGLHufuZJeliMhnBLZ9>
{
	private readonly IProgress<TNGLHufuZJeliMhnBLZ9> VmVfLgZM4ye;

	private readonly double HSjfLlTHflt;

	private readonly double UPifLdbWSjt;

	private readonly object AoQfLK5IYvw;

	private double QC8fLHqa3r4;

	internal static object ouhRXqZT4nwClhIl68kP;

	[MethodImpl((MethodImplOptions)8)]
	internal DWmHe0fLIlSc8QoshHUj(IProgress<TNGLHufuZJeliMhnBLZ9> target, double minimum, double maximum)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Report(TNGLHufuZJeliMhnBLZ9 value)
	{
		int num = 1;
		double num5 = default(double);
		object aoQfLK5IYvw = default(object);
		bool flag = default(bool);
		int num6 = default(int);
		int num8 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						num5 = HSjfLlTHflt + System.Math.Clamp(value.Percent, 0.0, 100.0) * (UPifLdbWSjt - HSjfLlTHflt) / 100.0;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						aoQfLK5IYvw = AoQfLK5IYvw;
						num3 = 4;
						continue;
					case 3:
						try
						{
							System.Threading.Monitor.Enter(aoQfLK5IYvw, ref flag);
							int num4 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num6 == 990)
									{
										num4 = num6;
										continue;
									}
									break;
								case 1:
									QC8fLHqa3r4 = System.Math.Max(QC8fLHqa3r4, num5);
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
									{
										num4 = 2;
									}
									continue;
								case 2:
									break;
								case 0:
									goto end_IL_00a0;
								}
								num5 = QC8fLHqa3r4;
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
								{
									num4 = 2;
								}
								continue;
								end_IL_00a0:
								break;
							}
						}
						finally
						{
							if (flag)
							{
								int num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										if (num8 == 989)
										{
											num7 = num8;
											continue;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_015f;
									}
									System.Threading.Monitor.Exit(aoQfLK5IYvw);
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num7 = 6;
									}
									continue;
									end_IL_015f:
									break;
								}
							}
						}
						goto case 2;
					case 1:
						break;
					case 4:
						flag = false;
						num3 = 3;
						continue;
					case 2:
					{
						IProgress<TNGLHufuZJeliMhnBLZ9> vmVfLgZM4ye = VmVfLgZM4ye;
						TNGLHufuZJeliMhnBLZ9 tNGLHufuZJeliMhnBLZ = value.YikfukuNsXQ();
						tNGLHufuZJeliMhnBLZ.Percent = num5;
						vmVfLgZM4ye.Report(tNGLHufuZJeliMhnBLZ);
						num3 = 5;
						continue;
					}
					case 5:
						return;
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
			System.ArgumentNullException.ThrowIfNull(value, "value");
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
			{
				num = 8;
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
	internal static bool K2Cca6ZThWGE3Byy6M8d()
	{
		return ouhRXqZT4nwClhIl68kP == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static DWmHe0fLIlSc8QoshHUj BDxQyAZTU9KIcRfX5PmI()
	{
		return (DWmHe0fLIlSc8QoshHUj)ouhRXqZT4nwClhIl68kP;
	}
}

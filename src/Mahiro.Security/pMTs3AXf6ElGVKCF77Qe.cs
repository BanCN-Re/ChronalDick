using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using D4HtW1wPWHCymGsRKJs;
using GmAwUvfT43PML1wKX4Mx;
using RfcThffF5acZv2ZHiBS5;
using RkEBBcxE6uQHIJCVGy1;
using fDAldojjppXrctUVYOJn;
using v9jm3lwFCfAib18dIuA;

namespace qjcIUHXfRE7OdKebDLQv;

sealed class pMTs3AXf6ElGVKCF77Qe : ysbQEaweb8jDjbWGeJN, global::System.IDisposable
{
	private readonly object tCGXfxKBTgc;

	private readonly object wABXfFCLf0v;

	private readonly object LCGXfsg8bUP;

	private bool ukfXfTPs9SS;

	internal static object k1C2TBZ7oRX0JcOtUgQ8;

	[MethodImpl((MethodImplOptions)8)]
	internal pMTs3AXf6ElGVKCF77Qe(B1GNrVwxgR0eaU9Hq4q api, bnHA9vxvBiUJqO7FLm4 paths, HttpMessageHandler? downloadHandler = null)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task<oOa87CfFOPcp1Pqa8RP4> dBML4JlaoEl(string roleUuid, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ResolveAsync_d__5 resolveAsync_d__ = default(_ResolveAsync_d__5);
		resolveAsync_d__.__t__builder = AsyncTaskMethodBuilder<oOa87CfFOPcp1Pqa8RP4>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task<string> qUYXfwuTyPr(hFWt5VfTCtSkZp2qtnbD asset, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_GetOrDownloadAsync_d__6 getOrDownloadAsync_d__ = default(_GetOrDownloadAsync_d__6);
		getOrDownloadAsync_d__.__t__builder = AsyncTaskMethodBuilder<string>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool tn5XfetV2rh(object path, object asset)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		int num = 1;
		int num7 = default(int);
		bool result = default(bool);
		FileStream val2 = default(FileStream);
		int num4 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					FileInfo val = new FileInfo((string)path);
					int num2 = 12;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
					{
						num2 = 9;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num7 != 18)
							{
								if (num7 == 998)
								{
									goto IL_0066;
								}
								goto case 5;
							}
							goto case 10;
						case 5:
						case 8:
							result = false;
							num2 = 2;
							continue;
						case 4:
							if (((hFWt5VfTCtSkZp2qtnbD)asset).Size <= 0)
							{
								num7 = 18;
								goto IL_0066;
							}
							goto case 6;
						case 10:
							if (string.IsNullOrWhiteSpace(((hFWt5VfTCtSkZp2qtnbD)asset).Md5))
							{
								num2 = 7;
								continue;
							}
							goto case 0;
						case 9:
							if (!(val).Exists)
							{
								num2 = 8;
								continue;
							}
							goto case 4;
						case 0:
							val2 = System.IO.File.OpenRead((string)path);
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
							{
								num2 = 1;
							}
							continue;
						case 2:
							break;
						case 7:
							result = true;
							num2 = 3;
							continue;
						case 3:
							break;
						case 6:
							if ((val).Length != ((hFWt5VfTCtSkZp2qtnbD)asset).Size)
							{
								num2 = 5;
								continue;
							}
							goto case 10;
						case 1:
							{
								try
								{
									result = (System.Convert.ToHexString(System.Security.Cryptography.MD5.HashData((Stream)(object)val2))).Equals(((hFWt5VfTCtSkZp2qtnbD)asset).Md5, (StringComparison)5);
									int num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
									{
										num3 = 0;
									}
									while (true)
									{
										switch (num3)
										{
										default:
											if (num4 == 988)
											{
												num3 = num4;
												continue;
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									if (val2 != null)
									{
										int num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
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
												(val2).Dispose();
												num5 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
												{
													num5 = 4;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								break;
							}
							IL_0066:
							num2 = num7;
							continue;
						}
						break;
					}
				}
				catch (global::System.Exception)
				{
					int num8 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
					{
						num8 = 1;
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
						case 1:
							break;
						case 0:
							goto end_IL_030c;
						}
						result = false;
						num8 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num8 = 0;
						}
						continue;
						end_IL_030c:
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
	private static void G7mXfPaeNfr(object uri)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		ukfXfTPs9SS = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool NdIKhXZ7mIWincWwycKe()
	{
		return k1C2TBZ7oRX0JcOtUgQ8 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static pMTs3AXf6ElGVKCF77Qe UOVOnDZ77OIE65D5c3SF()
	{
		return (pMTs3AXf6ElGVKCF77Qe)k1C2TBZ7oRX0JcOtUgQ8;
	}
}

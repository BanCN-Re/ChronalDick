using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using kv4rFCXt5vWpEP7klgZ0;

namespace KiaSgnXtR0buq3Xh1g8j;

internal sealed class T7fHlCXt61wmEaJPLhon : IOException
{
	[CompilerGenerated]
	private readonly ONNOITXtOJ2NNuZvPNm7 MDQXterK5oG;

	private static object Ar8KphZ5uP9PYIwL32Tp;

	internal ONNOITXtOJ2NNuZvPNm7 Reason
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return MDQXterK5oG;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal T7fHlCXt61wmEaJPLhon(ONNOITXtOJ2NNuZvPNm7 reason, string message)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ONNOITXtOJ2NNuZvPNm7? FrQXtwclycV(object error)
	{
		int num = 4;
		global::System.Collections.Generic.IEnumerator<global::System.Exception> enumerator = default(global::System.Collections.Generic.IEnumerator<global::System.Exception>);
		int num5 = default(int);
		ONNOITXtOJ2NNuZvPNm7? result = default(ONNOITXtOJ2NNuZvPNm7?);
		ONNOITXtOJ2NNuZvPNm7 valueOrDefault = default(ONNOITXtOJ2NNuZvPNm7);
		int num7 = default(int);
		T7fHlCXt61wmEaJPLhon t7fHlCXt61wmEaJPLhon = default(T7fHlCXt61wmEaJPLhon);
		ONNOITXtOJ2NNuZvPNm7? result2 = default(ONNOITXtOJ2NNuZvPNm7?);
		AggregateException ex = default(AggregateException);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
						}
						else
						{
							try
							{
								while (true)
								{
									int num4;
									if (!(enumerator).MoveNext())
									{
										num4 = 5;
										goto IL_00fc;
									}
									goto IL_01ca;
									IL_00fc:
									while (true)
									{
										switch (num4)
										{
										default:
											if (num5 != 13)
											{
												if (num5 == 993)
												{
													goto IL_00f8;
												}
												goto IL_01ca;
											}
											return result;
										case 4:
											valueOrDefault = result.GetValueOrDefault();
											num4 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
											{
												num4 = 3;
											}
											continue;
										case 1:
											if (result.HasValue)
											{
												num4 = 4;
												continue;
											}
											break;
										case 0:
											break;
										case 3:
											result = valueOrDefault;
											num5 = 13;
											goto IL_00f8;
										case 2:
											goto IL_01ca;
										case 5:
											goto end_IL_0178;
											IL_00f8:
											num4 = num5;
											continue;
										}
										break;
									}
									continue;
									IL_01ca:
									result = FrQXtwclycV(enumerator.Current);
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
									{
										num4 = 7;
									}
									goto IL_00fc;
									continue;
									end_IL_0178:
									break;
								}
							}
							finally
							{
								int num6;
								if (enumerator == null)
								{
									num6 = 2;
									goto IL_021f;
								}
								goto IL_0267;
								IL_0267:
								(enumerator).Dispose();
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
								{
									num6 = 7;
								}
								goto IL_021f;
								IL_021f:
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 990)
										{
											goto IL_021b;
										}
										break;
									case 2:
										goto end_IL_021f;
									case 0:
										break;
									case 1:
										goto end_IL_021f;
									}
									goto IL_0267;
									IL_021b:
									num6 = num7;
									continue;
									end_IL_021f:
									break;
								}
							}
						}
						goto case 0;
					case 4:
						t7fHlCXt61wmEaJPLhon = error as T7fHlCXt61wmEaJPLhon;
						num3 = 3;
						continue;
					case 7:
						return FrQXtwclycV(((dynamic)(error)).InnerException);
					case 9:
						result2 = null;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
						{
							num3 = 5;
						}
						continue;
					case 5:
						return t7fHlCXt61wmEaJPLhon.Reason;
					case 2:
						ex = (AggregateException)((error is AggregateException) ? error : null);
						num3 = 10;
						continue;
					case 3:
						if (t7fHlCXt61wmEaJPLhon == null)
						{
							num3 = 2;
							continue;
						}
						goto case 5;
					case 1:
						break;
					case 6:
						return result2;
					case 0:
					case 8:
						if (((dynamic)(error)).InnerException == null)
						{
							num3 = 9;
							continue;
						}
						goto case 7;
					case 10:
						if (ex == null)
						{
							num3 = 8;
							continue;
						}
						break;
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
			enumerator = (ex).InnerExceptions.GetEnumerator();
			num = 17;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
			{
				num = 15;
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
	internal static bool Mrj5trZ5aVJVFPoiVs49()
	{
		return Ar8KphZ5uP9PYIwL32Tp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static T7fHlCXt61wmEaJPLhon Tabk95Z51kaqASLBtYHS()
	{
		return (T7fHlCXt61wmEaJPLhon)Ar8KphZ5uP9PYIwL32Tp;
	}
}
